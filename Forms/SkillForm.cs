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
                if (skillListBox.DataSource == null)
                {
                    return; // No data source, nothing to do
                }

                var selectedSkill = skillListBox.SelectedItem as Skill;
                if (selectedSkill != null)
                {
                    skillNameTextBox.Text = selectedSkill.Name;
                    valueTextBox.Text = selectedSkill.Value;
                    skillPanel.Visible = true; // Show the skill details panel
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
                if (selectedSkill != null)
                {
                    selectedSkill.Name = skillNameTextBox.Text;
                    selectedSkill.Value = valueTextBox.Text;
                    using (var context = new AppDbContext())
                    {
                        bool success = context.UpdateSkill(selectedSkill);
                        if (!success)
                        {
                            MessageBox.Show("Failed to save skill. Please try again.");
                            return;
                        }
                    }
                    RefreshSkillList(); // Refresh the skill list in the UI
                }
                else
                {
                    MessageBox.Show("No skill selected to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving skill: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Skill newSkill = new Skill
            {
                Name = "New Skill",
                EnemyId = _selectedEnemy.EnemyId
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
                _selectedEnemy.UpdateSkillList(); // Ensure the enemy's skill list is up to date before closing
                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedSkill = skillListBox.SelectedItem as Skill;
            if (selectedSkill != null)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        bool success = context.DeleteSkillByID(selectedSkill.SkillId);
                        if (!success)
                        {
                            MessageBox.Show("Failed to delete skill. Please try again.");
                            return;
                        }
                    }
                    skillPanel.Visible = false; // Hide the skill details panel
                    RefreshSkillList(); // Refresh the skill list in the UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting skill: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No skill selected to delete.");
            }
        }

        private void RefreshSkillList()
        {
            skillListBox.DataSource = null;
            _selectedEnemy.UpdateSkillList(); // Ensure the enemy's skill list is up to date
            skillListBox.DataSource = _selectedEnemy.SkillList.ToList();
            skillListBox.DisplayMember = "Name";
            skillListBox.ValueMember = "SkillId";
        }


    }
}
