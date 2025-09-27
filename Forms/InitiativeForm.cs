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

namespace Thing.Forms
{
    public partial class InitiativeForm : Form
    {

        private List<InitiativeEntry> _initiativeList = new();
        private int _currentTurnIndex = 0;

        public InitiativeForm(List<Player> playerList, List<Enemy> enemyList)
        {

            CreateInitiativeList(playerList, enemyList);
            _currentTurnIndex = 0;
            InitializeComponent();
            RefreshInitiativeList();
            DisplayCurrentTurn();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateInitiativeList(List<Player> players, List<Enemy> enemies)
        {
            _initiativeList.Clear();
            foreach (var player in players)
            {
                _initiativeList.Add(new InitiativeEntry
                {
                    Name = player.Name,
                    Initiative = player.Initiative
                });
            }
            foreach (var enemy in enemies)
            {
                _initiativeList.Add(new InitiativeEntry
                {
                    Name = enemy.Name,
                    Initiative = enemy.Initiative
                });
            }
            _initiativeList = _initiativeList.OrderByDescending(i => i.Initiative).ToList();

        }
        private void RefreshInitiativeList()
        {
            initiativeListBox.DataSource = null;
            initiativeListBox.DataSource = _initiativeList;
            initiativeListBox.DisplayMember = "DisplayName";
        }

        private void DisplayCurrentTurn()
        {
            if (_initiativeList.Count == 0)
            {
                turnLabel.Text = "No entries in initiative list.";
                turnLabel.Visible = true;
                return;
            }
            var current = _initiativeList[_currentTurnIndex];
            turnLabel.Text = $"Current Turn: {current.Name}";
            turnLabel.Visible = true;
        }

        private void InitiativeForm_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (_initiativeList.Count == 0) return;
            _currentTurnIndex = (_currentTurnIndex + 1) % _initiativeList.Count;
            DisplayCurrentTurn();
        }
    }
}
