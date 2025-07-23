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
    public partial class addForm : Form
    {
        private Battle _selectedBattle;
        public addForm(Battle selectedBattle)
        {
            InitializeComponent();
            _selectedBattle = selectedBattle;
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            if (_selectedBattle == null)
            {
                MessageBox.Show("No battle selected.");
                return;
            }

            // Populate the form fields with the selected battle's details
            nameBox.Text = _selectedBattle.Name;
            descriptionBox.Text = _selectedBattle.Description;

            var enemies = _selectedBattle.EnemyList.ToList();

            enemyListBox.DataSource = enemies;
            enemyListBox.DisplayMember = "Name";
            enemyListBox.ValueMember = "EnemyId";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            var name = nameBox.Text.Trim();
            var description = descriptionBox.Text.Trim();

        }

        private void enemyLabel_Click(object sender, EventArgs e)
        {

        }

        private void addEnemyButton_Click(object sender, EventArgs e)
        {

        }

        private void editEnemyButton_Click(object sender, EventArgs e)
        {
            if (enemyListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an enemy to edit.");
                return;
            }
            else
            {
                var selectedEnemy = enemyListBox.SelectedItem as Enemy;
                if (selectedEnemy != null)
                {
                    nameBox.Text = selectedEnemy.Name;
                    //descriptionBox.Text = selectedEnemy.Description; // Assuming Enemy has a Description property
                    // You can also populate other fields as needed
                }
                else
                {
                    MessageBox.Show("Selected enemy is invalid.");
                }
            }
        }

        private void deleteEnemyButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy != null)
            {
                enemyNameTextBox.Text = selectedEnemy.Name;
                maxHpBox.Text = selectedEnemy.MaxHp.ToString();
                currentHpTextBox.Text = selectedEnemy.CurrentHp.ToString();
                maxWoundsTextBox.Text = selectedEnemy.MaxWounds.ToString();
                currentWoundsTextBox.Text = selectedEnemy.CurrentWounds.ToString();
                strengthTextBox.Text = selectedEnemy.Strength;
                willpowerTextBox.Text = selectedEnemy.Willpower;
                agilityTextBox.Text = selectedEnemy.Agility;
                charismaTextBox.Text = selectedEnemy.Charisma;
                knowledgeTextBox.Text = selectedEnemy.Knowledge;
                intelligenceTextBox.Text = selectedEnemy.Intelligence;
                enduranceTextBox.Text = selectedEnemy.Endurance;

                //descriptionBox.Text = selectedEnemy.Description; // Assuming Enemy has a Description property
                // You can also populate other fields as needed
            }
            else
            {
                MessageBox.Show("Selected enemy is invalid.");

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            addForm.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusHpButton_Click(object sender, EventArgs e)
        {

        }

        private void minusHpButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void minusWoundButton_Click(object sender, EventArgs e)
        {

        }

        private void armorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void willpowerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weaponsButton_Click(object sender, EventArgs e)
        {

        }

        private void skillsButton_Click(object sender, EventArgs e)
        {

        }

        private void plusWoundButton_Click(object sender, EventArgs e)
        {

        }

        private void enemyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skillsButton_Click_1(object sender, EventArgs e)
        {
            using (var modal = new SkillForm())
            {
                modal.ShowDialog(this);
            }

        }

        private void weaponsButton_Click_1(object sender, EventArgs e)
        {
            using (var modal = new WeaponsForm())
            {
                modal.ShowDialog(this);
            }
        }
    }
}
