using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thing.Models;

namespace Thing
{
    public partial class SkillForm : Form
    {
        private Enemy _selectedEnemy;
        public SkillForm(Enemy selectedEnemy)
        {
            _selectedEnemy = selectedEnemy;
            InitializeComponent();
        }

        private void SkillForm_Load(object sender, EventArgs e)
        {
            var skills = _selectedEnemy.SkillList.ToList();
            skillListBox.DataSource = skills;
            skillListBox.DisplayMember = "Name";
            skillListBox.ValueMember = "SkillId";

        }

        private void SkillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedSkill = skillListBox.SelectedItem as Skill;
                if (selectedSkill != null)
                {
                    skillNameTextBox.Text = selectedSkill.Name;
                    valueTextBox.Text = selectedSkill.Value;
                }
                else
                {
                    MessageBox.Show("Skill is invalid or not selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting skill: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSkill = skillListBox.SelectedItem as Skill;

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Skill newSkill = new Skill
            {
                Name = skillNameTextBox.Text,
                EnemyId = _selectedEnemy.EnemyId,
                Enemy = _selectedEnemy
            };

            try
            {
                using (var context = new AppDbContext())
                {
                    bool success = context.InsertSkill(newSkill);
                    if (!success)
                    {
                        MessageBox.Show("Failed to add skill. Please try again.");
                        return;
                    }
                }
                _selectedEnemy.SkillList.Add(newSkill); // Update the enemy's skill list in memory
                RefreshSkillList(); // Refresh the skill list in the UI
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding skill: " + ex.ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(_selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.SkillList = _selectedEnemy.SkillList.ToList(); // Update the enemy's skills in the database
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy skills. Please try again.");
                            return;
                        }
                    }
                }
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message);
            }
        }

        private void RefreshSkillList()
        {
            skillListBox.DataSource = null;
            skillListBox.DataSource = _selectedEnemy.SkillList.ToList();
            skillListBox.DisplayMember = "Name";
            skillListBox.ValueMember = "SkillId";
        }
    }
}
