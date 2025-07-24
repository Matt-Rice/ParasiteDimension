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
       
        }

        private void SkillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
