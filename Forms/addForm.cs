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
using Thing.Forms;

namespace Thing
{
    public partial class addForm : Form
    {
        private Battle _selectedBattle;

        public addForm(Battle battle)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    _selectedBattle = context.GetBattleById(battle.BattleId);

                    if (_selectedBattle == null)
                    {
                        MessageBox.Show("The selected battle is invalid");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                var players = _selectedBattle.PlayerList.ToList();

                enemyListBox.DataSource = enemies;
                enemyListBox.DisplayMember = "DisplayName";
                enemyListBox.ValueMember = "EnemyId";

                playerListBox.DataSource = players;
                playerListBox.DisplayMember = "Name";
                playerListBox.ValueMember = "PlayerId";
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Battle not found");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
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
                        bool success = context.UpdateBattle(battle);
                        if (success)
                        {
                            MessageBox.Show("Battle details saved successfully.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update battle in the database.");
                        }
                    }
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
                BattleId = _selectedBattle.BattleId
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

            try
            {
                var selectedEnemy = GetEnemyFromListBox();
                if (selectedEnemy == null)
                {
                    MessageBox.Show("Please select an enemy before you continue");
                    return;
                }
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
            if (enemyListBox.DataSource == null)
            {
                return; // No data source, nothing to do
            }

            try
            {
                var selectedEnemy = GetEnemyFromListBox();

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
                    armorTextBox.Text = selectedEnemy.Armor;
                    movementTextBox.Text = selectedEnemy.Movement;
                    enemyInitiativeTextBox.Text = selectedEnemy.Initiative.ToString();

                    enemyPanel.Visible = true; // Show the enemy details panel

                }
                else
                {
                    MessageBox.Show("Selected enemy is invalid.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Closes the form without saving changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Increases the enemy's HP by the damage amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusHpButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEnemy = GetEnemyFromListBox();
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
            try
            {
                var selectedEnemy = GetEnemyFromListBox();
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
                        bool negative = true;
                        while (negative)
                        {
                            selectedEnemy.CurrentHp += selectedEnemy.MaxHp; // Damage bleeds into next wound
                            selectedEnemy.CurrentWounds += 1; // Increase wound count
                            if (selectedEnemy.CurrentWounds >= selectedEnemy.MaxWounds)
                            {
                                selectedEnemy.CurrentWounds = selectedEnemy.MaxWounds; // Cap at MaxWounds
                                selectedEnemy.CurrentHp = selectedEnemy.MaxHp;
                                MessageBox.Show("Enemy has reached maximum wounds and is dead.");
                                negative = false; // Exit loop if enemy is dead
                            }
                            if (selectedEnemy.CurrentHp > 0) negative = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid damage amount. Please enter a valid number.");
                    return;
                }
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
            try
            {
                var selectedEnemy = GetEnemyFromListBox();
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
            var selectedEnemy = GetEnemyFromListBox();
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
            Enemy? selectedEnemy = GetEnemyFromListBox();
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
            Enemy? selectedEnemy = GetEnemyFromListBox();
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
            var selectedEnemy = GetEnemyFromListBox();
            if (selectedEnemy != null)
            {
                int maxHp, currentHp, maxWounds, currentWounds, initiative;

                if (!int.TryParse(maxHpBox.Text, out maxHp))
                {
                    MessageBox.Show("Invalid value for Max HP. Please enter a number.");
                    return;
                }

                if (!int.TryParse(currentHpTextBox.Text, out currentHp))
                {
                    MessageBox.Show("Invalid value for Current HP. Please enter a number.");
                    return;
                }

                if (!int.TryParse(maxWoundsTextBox.Text, out maxWounds))
                {
                    MessageBox.Show("Invalid value for Max Wounds. Please enter a number.");
                    return;
                }

                if (!int.TryParse(currentWoundsTextBox.Text, out currentWounds))
                {
                    MessageBox.Show("Invalid value for Current Wounds. Please enter a number.");
                    return;
                }

                if (!int.TryParse(enemyInitiativeTextBox.Text, out initiative))
                {
                    MessageBox.Show("Invalid value for Initiative. Please enter a number.");
                    return;
                }

                // Only set values if all parsing succeeded
                selectedEnemy.MaxHp = maxHp;
                selectedEnemy.CurrentHp = currentHp;
                selectedEnemy.MaxWounds = maxWounds;
                selectedEnemy.CurrentWounds = currentWounds;
                selectedEnemy.Initiative = initiative;
                selectedEnemy.Name = enemyNameTextBox.Text;
                selectedEnemy.Strength = strengthTextBox.Text;
                selectedEnemy.Willpower = willpowerTextBox.Text;
                selectedEnemy.Agility = agilityTextBox.Text;
                selectedEnemy.Charisma = charismaTextBox.Text;
                selectedEnemy.Knowledge = knowledgeTextBox.Text;
                selectedEnemy.Intelligence = intelligenceTextBox.Text;
                selectedEnemy.Endurance = enduranceTextBox.Text;
                selectedEnemy.Armor = armorTextBox.Text;
                selectedEnemy.Movement = movementTextBox.Text;

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
                            enemyToUpdate.Armor = selectedEnemy.Armor;
                            enemyToUpdate.Movement = selectedEnemy.Movement;
                            enemyToUpdate.Initiative = selectedEnemy.Initiative;
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
            // Save the currently selected EnemyId (if any)
            int? selectedEnemyId = null;
            if (enemyListBox.SelectedItem is Enemy selectedEnemy)
            {
                selectedEnemyId = selectedEnemy.EnemyId;
            }

            enemyListBox.DataSource = null;
            _selectedBattle.UpdateEnemyList(); // Ensure the battle's enemy list is up-to-date
            var enemies = _selectedBattle.EnemyList.ToList();
            enemyListBox.DataSource = enemies;
            enemyListBox.DisplayMember = "DisplayName";
            enemyListBox.ValueMember = "EnemyId";

            // Restore selection if possible
            if (selectedEnemyId.HasValue)
            {
                for (int i = 0; i < enemies.Count; i++)
                {
                    if (enemies[i].EnemyId == selectedEnemyId.Value)
                    {
                        enemyListBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private Enemy? GetEnemyFromListBox()
        {
            try
            {
                var enemy = enemyListBox.SelectedItem as Enemy;
                if (enemy == null)
                {
                    MessageBox.Show("Please select an enemy before you continue");
                    return null;
                }
                using (var context = new AppDbContext())
                {
                    var dbEnemy = context.GetEnemyById(enemy.EnemyId);
                    if (dbEnemy != null)
                    {
                        return dbEnemy;
                    }
                    else
                    {
                        MessageBox.Show("Enemy not found in the database.");
                        return enemy; // Return the original enemy if not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null; // Return the original enemy in case of error
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void strengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void intelligenceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerListBox.DataSource == null)
            {
                return; // No data source, nothing to do
            }

            try
            {
                var selectedPlayer = GetPlayerFromListBox();

                if (selectedPlayer != null)
                {
                    playerNameTextBox.Text = selectedPlayer.Name;
                    playerInitiativeTextBox.Text = selectedPlayer.Initiative.ToString();
                    deadCheckBox.Checked = selectedPlayer.IsDead;

                    playerPanel.Visible = true; // Show the enemy details panel

                }
                else
                {
                    MessageBox.Show("Selected enemy is invalid.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void savePlayerButton_Click(object sender, EventArgs e)
        {
            var selectedPlayer = GetPlayerFromListBox();
            if (selectedPlayer != null)
            {
                int initiative;

                if (!int.TryParse(playerInitiativeTextBox.Text, out initiative))
                {
                    MessageBox.Show("Invalid value for Initiative. Please enter a number.");
                    return;
                }

                selectedPlayer.Name = playerNameTextBox.Text;
                selectedPlayer.Initiative = initiative;
                selectedPlayer.IsDead = deadCheckBox.Checked;
                try
                {
                    using (var context = new AppDbContext())
                    {
                        var playerToUpdate = context.GetPlayerById(selectedPlayer.PlayerId);
                        if (playerToUpdate != null)
                        {
                            playerToUpdate.Name = selectedPlayer.Name;
                            playerToUpdate.Initiative = selectedPlayer.Initiative;
                            playerToUpdate.IsDead = selectedPlayer.IsDead;
                            bool success = context.UpdatePlayer(playerToUpdate);
                            if (!success)
                            {
                                MessageBox.Show("Failed to update player in the database.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selected player not found in the database.");
                        }
                    }
                    RefreshPlayerList(); // Refresh the player list box
                    MessageBox.Show("Player details saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No player is currently selected.");
            }
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPlayer = GetPlayerFromListBox();
                if (selectedPlayer == null)
                {
                    MessageBox.Show("Please select a player before you continue");
                    return;
                }
                bool success = false;
                using (var context = new AppDbContext())
                {
                    var playerToDelete = context.GetPlayerById(selectedPlayer.PlayerId);
                    if (playerToDelete != null)
                    {
                        success = context.DeletePlayerByID(playerToDelete.PlayerId);
                        if (!success)
                        {
                            MessageBox.Show("Failed to delete player from the database.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Player not found in the database.");
                    }
                    playerPanel.Visible = false; // Hide the player details panel
                    // Remove the player from the battle's player list and refresh the list box
                    _selectedBattle.PlayerList.Remove(selectedPlayer);
                    RefreshPlayerList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {

            // Create a new player associated with the selected battle
            Player newPlayer = new Player
            {
                Name = "New Player",
                BattleId = _selectedBattle.BattleId
            };
            var success = false;
            try
            {
                using (var context = new AppDbContext())
                {
                    success = context.InsertPlayer(newPlayer);
                    if (!success)
                    {
                        MessageBox.Show("Failed to add new player to the database.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            _selectedBattle.PlayerList.Add(newPlayer);
            // Add the new player to the list box and refresh it
            RefreshPlayerList();
        }

        private void RefreshPlayerList()
        {
            // Save the currently selected PlayerId (if any)
            int? selectedPlayerId = null;
            if (playerListBox.SelectedItem is Player selectedPlayer)
            {
                selectedPlayerId = selectedPlayer.PlayerId;
            }
            playerListBox.DataSource = null;
            _selectedBattle.UpdatePlayerList(); // Ensure the battle's player list is up-to-date
            var players = _selectedBattle.PlayerList.ToList();
            playerListBox.DataSource = players;
            playerListBox.DisplayMember = "Name";
            playerListBox.ValueMember = "PlayerId";
            // Restore selection if possible
            if (selectedPlayerId.HasValue)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    if (players[i].PlayerId == selectedPlayerId.Value)
                    {
                        playerListBox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private Player? GetPlayerFromListBox()
        {
            try
            {
                var player = playerListBox.SelectedItem as Player;
                if (player == null)
                {
                    MessageBox.Show("Please select an player before you continue");
                    return null;
                }
                using (var context = new AppDbContext())
                {
                    var dbPlayer = context.GetPlayerById(player.PlayerId);
                    if (dbPlayer != null)
                    {
                        return dbPlayer;
                    }
                    else
                    {
                        MessageBox.Show("Player not found in the database.");
                        return player; // Return the original player if not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null; // Return the original player in case of error
            }
        }

        private void turnOrderButton_Click(object sender, EventArgs e)
        {
            List<Player> players = new List<Player>();
            List<Enemy> enemies = new List<Enemy>();

            using (var context = new AppDbContext())
            {
                players = context.GetPlayersByBattleId(_selectedBattle.BattleId).ToList().Where(p => !p.IsDead).ToList();
                enemies = context.GetEnemiesByBattleId(_selectedBattle.BattleId).ToList().Where(e => !e.IsDead).ToList();
            }
            using (var modal = new InitiativeForm(players, enemies))
            {
                modal.ShowDialog(this);
            }
        }
    }
}
