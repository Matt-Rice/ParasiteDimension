
using System.Data.Entity;
using Thing.Models;
namespace Thing
{
    public partial class ParasiteDimension : Form
    {
        public ParasiteDimension()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedBattle = battleListBox.SelectedItem as Battle;
            if (selectedBattle == null)
            {
                MessageBox.Show("Please select a battle to edit.");
                return;
            }

            OpenModal(selectedBattle);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Battle? selectedBattle = battleListBox.SelectedItem as Battle;
            if (selectedBattle == null)
            {
                MessageBox.Show("Please select a battle to delete.");
                return;
            }
            DeleteBattle(selectedBattle);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Battle newBattle;

            using (var context = new AppDbContext())
            {
                newBattle = new Battle()
                {
                    Name = "New Battle",
                    EnemyList = new List<Enemy>()
                };

                context.Battles.Add(newBattle);
                context.SaveChanges();
            }
            OpenModal(newBattle);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBattles();
        }

        public void OpenModal(Battle battle)
        {

            using (var modal = new addForm(battle))
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Okay");
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Cancelled");
                }
            }
        }

        /// <summary>
        /// Method to load battles from the database and populate the ListBox.
        /// </summary>
        public void LoadBattles()
        {
            using var db = new AppDbContext();

            var battles = db.Battles
                .Include(b => b.EnemyList)
                .OrderBy(b => b.Name)
                .ToList();

            battleListBox.DataSource = battles;
            battleListBox.DisplayMember = "Name";
            battleListBox.ValueMember = "BattleId";
        }

        /// <summary>
        /// Delete a battle from the database and refresh the ListBox.
        /// </summary>
        /// <param name="battle"></param>
        public void DeleteBattle(Battle battle)
        {
            using var db = new AppDbContext();
            db.Battles.Remove(battle);
            db.SaveChanges();
            LoadBattles();
        }
        private void battleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
