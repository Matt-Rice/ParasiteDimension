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

        public addForm(Battle battle)
        {
            _selectedBattle = battle;
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {
            try
            {

                // Populate the form fields with the selected battle's details
                nameBox.Text = _selectedBattle.Name;
                descriptionBox.Text = _selectedBattle.Description;

                var enemies = _selectedBattle.EnemyList.ToList();

                enemyListBox.DataSource = enemies;
                enemyListBox.DisplayMember = "DisplayName";
                enemyListBox.ValueMember = "EnemyId";
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Battle not found");
                ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ActiveForm.Close();
            }
        }

        /// <summary>
        /// Saves the battle details and updates the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedBattle.Name = nameBox.Text;
                _selectedBattle.Description = descriptionBox.Text;

                using (var context = new AppDbContext())
                {
                    var battle = context.GetBattleById(_selectedBattle.BattleId);

                    if (battle == null)
                    {
                        MessageBox.Show("Battle not found.");
                        return;
                    }
                    else
                    {
                        battle.Name = _selectedBattle.Name;
                        battle.Description = _selectedBattle.Description;
                        battle.EnemyList = _selectedBattle.EnemyList;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void enemyLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Adds a new enemy to the battle and opens the enemy creation form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEnemyButton_Click(object sender, EventArgs e)
        {
            // Create a new enemy associated with the selected battle
            Enemy newEnemy = new Enemy
            {
                Name = "New Enemy",
                BattleId = _selectedBattle.BattleId,
                Battle = _selectedBattle
            };

            var success = false;
            try
            {
                using (var context = new AppDbContext())
                {
                    success = context.InsertEnemy(newEnemy);
                    if (!success)
                    {
                        MessageBox.Show("Failed to add new enemy to the database.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            _selectedBattle.AddOrUpdateEnemy(newEnemy);
            // Add the new enemy to the list box and refresh it
            RefreshEnemyList();
        }

        /// <summary>
        /// Deletes the selected enemy from the battle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteEnemyButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy to delete.");
                return;
            }

            try
            {
                bool success = false;
                using (var context = new AppDbContext())
                {
                    var enemyToDelete = context.GetEnemyById(selectedEnemy.EnemyId);
                    if (enemyToDelete != null)
                    {
                        success = context.DeleteEnemyByID(enemyToDelete.EnemyId);
                        if (!success)
                        {
                            MessageBox.Show("Failed to delete enemy from the database.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                    }
                    enemyPanel.Visible = false; // Hide the enemy details panel
                    // Remove the enemy from the battle's enemy list and refresh the list box
                    _selectedBattle.EnemyList.Remove(selectedEnemy);
                    RefreshEnemyList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                enemyPanel.Visible = true; // Show the enemy details panel

            }
            else
            {
                MessageBox.Show("Selected enemy is invalid.");

            }
        }

        /// <summary>
        /// Closes the form without saving changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        /// <summary>
        /// Increases the enemy's HP by the damage amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusHpButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }

            int damage; //specific amount of damage to be healed
            if (int.TryParse(damageTextBox.Text, out damage))
            {
                selectedEnemy.CurrentHp += damage;
                if (selectedEnemy.CurrentHp > selectedEnemy.MaxHp)
                {
                    selectedEnemy.CurrentHp = selectedEnemy.MaxHp; // Cap at MaxHp
                }
            }
            else
            {
                MessageBox.Show("Invalid damage amount. Please enter a valid number.");
                return;
            }
            try
            {
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.CurrentHp = selectedEnemy.CurrentHp;
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy in the database.");
                            return;
                        }
                        currentHpTextBox.Text = selectedEnemy.CurrentHp.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                    }
                }

                _selectedBattle.AddOrUpdateEnemy(selectedEnemy); // Update the battle's enemy list
                RefreshEnemyList(); // Refresh the enemy list box
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Decreases the enemy's HP by the damage amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusHpButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }

            int damage; //specific amount of damage to be healed
            if (int.TryParse(damageTextBox.Text, out damage))
            {
                selectedEnemy.CurrentHp -= damage;
                if (selectedEnemy.CurrentHp <= 0)
                {
                    selectedEnemy.CurrentHp += selectedEnemy.MaxHp; // Damage bleeds into next wound
                    selectedEnemy.CurrentWounds += 1; // Increase wound count
                    if (selectedEnemy.CurrentWounds >= selectedEnemy.MaxWounds)
                    {
                        selectedEnemy.CurrentWounds = selectedEnemy.MaxWounds; // Cap at MaxWounds
                        MessageBox.Show("Enemy has reached maximum wounds and is dead.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid damage amount. Please enter a valid number.");
                return;
            }
            try
            {
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.CurrentHp = selectedEnemy.CurrentHp;
                        enemy.CurrentWounds = selectedEnemy.CurrentWounds;
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy in the database.");
                            return;
                        }
                        currentHpTextBox.Text = selectedEnemy.CurrentHp.ToString();
                        currentWoundsTextBox.Text = selectedEnemy.CurrentWounds.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                    }
                }
                _selectedBattle.AddOrUpdateEnemy(selectedEnemy); // Update the battle's enemy list
                RefreshEnemyList(); // Refresh the enemy list box
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Subtracts a wound from the enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusWoundButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }

            selectedEnemy.CurrentWounds -= 1;
            if (selectedEnemy.CurrentWounds <= 0)
            {
                selectedEnemy.CurrentWounds = 0; // Cap at 0 wounds
                MessageBox.Show("Enemy has no wounds.");
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.CurrentWounds = selectedEnemy.CurrentWounds;
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy in the database.");
                            return;
                        }
                        currentWoundsTextBox.Text = selectedEnemy.CurrentWounds.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                    }
                }
                _selectedBattle.AddOrUpdateEnemy(selectedEnemy); // Update the battle's enemy list
                RefreshEnemyList(); // Refresh the enemy list box
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds a wound to the enemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusWoundButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }

            selectedEnemy.CurrentWounds += 1;
            if (selectedEnemy.CurrentWounds >= selectedEnemy.MaxWounds)
            {
                selectedEnemy.CurrentWounds = selectedEnemy.MaxWounds; // Cap at Max wounds
                MessageBox.Show("Enemy has reached maximum wounds and is dead.");
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.CurrentWounds = selectedEnemy.CurrentWounds;
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy in the database.");
                            return;
                        }
                        currentWoundsTextBox.Text = selectedEnemy.CurrentWounds.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                    }
                }
                _selectedBattle.AddOrUpdateEnemy(selectedEnemy); // Update the battle's enemy list
                RefreshEnemyList(); // Refresh the enemy list box
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void enemyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skillsButton_Click(object sender, EventArgs e)
        {
            Enemy? selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }
            using (var modal = new SkillForm(selectedEnemy))
            {
                modal.ShowDialog(this);
            }

        }
        private void weaponsButton_Click(object sender, EventArgs e)
        {
            Enemy? selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy == null)
            {
                MessageBox.Show("Please select an enemy before you continue");
                return;
            }
            using (var modal = new WeaponsForm(selectedEnemy))
            {
                modal.ShowDialog(this);
            }
        }

        private void saveEnemyButton_Click(object sender, EventArgs e)
        {
            var selectedEnemy = enemyListBox.SelectedItem as Enemy;
            if (selectedEnemy != null)
            {
                selectedEnemy.Name = enemyNameTextBox.Text;
                selectedEnemy.MaxHp = int.Parse(maxHpBox.Text);
                selectedEnemy.CurrentHp = int.Parse(currentHpTextBox.Text);
                selectedEnemy.MaxWounds = int.Parse(maxWoundsTextBox.Text);
                selectedEnemy.CurrentWounds = int.Parse(currentWoundsTextBox.Text);
                selectedEnemy.Strength = strengthTextBox.Text;
                selectedEnemy.Willpower = willpowerTextBox.Text;
                selectedEnemy.Agility = agilityTextBox.Text;
                selectedEnemy.Charisma = charismaTextBox.Text;
                selectedEnemy.Knowledge = knowledgeTextBox.Text;
                selectedEnemy.Intelligence = intelligenceTextBox.Text;
                selectedEnemy.Endurance = enduranceTextBox.Text;
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var enemyToUpdate = context.GetEnemyById(selectedEnemy.EnemyId);
                        if (enemyToUpdate != null)
                        {
                            enemyToUpdate.Name = selectedEnemy.Name;
                            enemyToUpdate.MaxHp = selectedEnemy.MaxHp;
                            enemyToUpdate.CurrentHp = selectedEnemy.CurrentHp;
                            enemyToUpdate.MaxWounds = selectedEnemy.MaxWounds;
                            enemyToUpdate.CurrentWounds = selectedEnemy.CurrentWounds;
                            enemyToUpdate.Strength = selectedEnemy.Strength;
                            enemyToUpdate.Willpower = selectedEnemy.Willpower;
                            enemyToUpdate.Agility = selectedEnemy.Agility;
                            enemyToUpdate.Charisma = selectedEnemy.Charisma;
                            enemyToUpdate.Knowledge = selectedEnemy.Knowledge;
                            enemyToUpdate.Intelligence = selectedEnemy.Intelligence;
                            enemyToUpdate.Endurance = selectedEnemy.Endurance;
                            bool success = context.UpdateEnemy(enemyToUpdate);
                            if (!success)
                            {
                                MessageBox.Show("Failed to update enemy in the database.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected enemy not found in the database.");
                        }
                    }
                    _selectedBattle.AddOrUpdateEnemy(selectedEnemy); // Update the battle's enemy list
                    RefreshEnemyList(); // Refresh the enemy list box
                    MessageBox.Show("Enemy details saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No enemy is currently selected.");
            }
        }

        private void RefreshEnemyList()
        {
            enemyListBox.DataSource = null;
            _selectedBattle.UpdateEnemyList(); // Ensure the battle's enemy list is up-to-date
            enemyListBox.DataSource = _selectedBattle.EnemyList.ToList();
            enemyListBox.DisplayMember = "DisplayName";
            enemyListBox.ValueMember = "EnemyId";
        }
    }
}
