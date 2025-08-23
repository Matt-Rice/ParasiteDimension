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
    public partial class WeaponsForm : Form
    {
        private Enemy _selectedEnemy;
        public WeaponsForm(Enemy selectedEnemy)
        {
            _selectedEnemy = selectedEnemy;
            InitializeComponent();
        }
        private void WeaponsForm_Load(object sender, EventArgs e)
        {
            var weapons = _selectedEnemy.WeaponList.ToList();
            weaponListBox.DataSource = weapons;
            weaponListBox.DisplayMember = "Name";
            weaponListBox.ValueMember = "WeaponId";
        }

        private void weaponListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedWeapon = weaponListBox.SelectedItem as Weapon;
                if (selectedWeapon != null)
                {
                    weaponNameTextBox.Text = selectedWeapon.Name;
                    damageTextBox.Text = selectedWeapon.Damage;
                    weaponPanel.Visible = true; // Show the weapon details panel
                }
                else
                {
                    MessageBox.Show("Weapon is invalid or not selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting weapon: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Weapon newWeapon = new Weapon
            {
                Name = "New Weapon",
                EnemyId = _selectedEnemy.EnemyId,
                Enemy = _selectedEnemy
            };
            try
            {
                using (var context = new AppDbContext())
                {
                    bool success = context.InsertWeapon(newWeapon);
                    if (!success)
                    {
                        MessageBox.Show("Failed to add weapon. Please try again.");
                        return;
                    }
                }
                _selectedEnemy.WeaponList.Add(newWeapon); // Update the enemy's weapon list in memory
                RefreshWeaponList(); // Refresh the weapon list in the UI
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding weapon: " + ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedWeapon = weaponListBox.SelectedItem as Weapon;
                if (selectedWeapon != null)
                {
                    selectedWeapon.Name = weaponNameTextBox.Text;
                    selectedWeapon.Damage = damageTextBox.Text;
                    using (var context = new AppDbContext())
                    {
                        bool success = context.UpdateWeapon(selectedWeapon);
                        if (!success)
                        {
                            MessageBox.Show("Failed to save weapon. Please try again.");
                            return;
                        }
                    }
                    RefreshWeaponList(); // Refresh the weapon list in the UI
                }
                else
                {
                    MessageBox.Show("No weapon selected to save.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving weapon: " + ex.Message);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedWeapon = weaponListBox.SelectedItem as Weapon;
            if (selectedWeapon != null)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        bool success = context.DeleteWeaponByID(selectedWeapon.WeaponId);
                        if (!success)
                        {
                            MessageBox.Show("Failed to delete weapon. Please try again.");
                            return;
                        }
                    }
                    weaponPanel.Visible = false; // Hide the weapon details panel
                    _selectedEnemy.WeaponList.Remove(selectedWeapon); // Update the enemy's weapon list in memory
                    RefreshWeaponList(); // Refresh the weapon list in the UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting weapon: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No weapon selected to delete.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedEnemy.UpdateWeaponList(); // Ensure the enemy's weapon list is up to date before closing
                using (var context = new AppDbContext())
                {
                    var enemy = context.GetEnemyById(_selectedEnemy.EnemyId);
                    if (enemy != null)
                    {
                        enemy.WeaponList = _selectedEnemy.WeaponList.ToList(); // Update the enemy's weapons in the database
                        bool success = context.UpdateEnemy(enemy);
                        if (!success)
                        {
                            MessageBox.Show("Failed to update enemy weapons. Please try again.");
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

        private void RefreshWeaponList()
        {
            weaponListBox.DataSource = null;
            _selectedEnemy.UpdateWeaponList(); // Ensure the enemy's weapon list is up to date
            weaponListBox.DataSource = _selectedEnemy.WeaponList.ToList();
            weaponListBox.DisplayMember = "Name";
            weaponListBox.ValueMember = "WeaponId";
        }
    }
}
