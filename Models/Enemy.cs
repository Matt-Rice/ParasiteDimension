using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class Enemy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnemyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string DisplayName => CurrentWounds >= MaxWounds ? $"{Name} (Dead)" : Name;
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int MaxWounds { get; set; }
        public int CurrentWounds { get; set; }
        public string Strength { get; set; } = string.Empty;  
        public string Willpower { get; set; } = string.Empty;
        public string Agility { get; set; } = string.Empty;
        public string Charisma { get; set; } = string.Empty;
        public string Knowledge { get; set; } = string.Empty;
        public string Intelligence { get; set; } = string.Empty;
        public string Endurance { get; set; } = string.Empty;
        public List<Skill> SkillList { get; set; } = new();
        public List<Weapon> WeaponList { get; set; } = new();
        public int BattleId { get; set; }
        public Battle Battle { get; set; }

        public void UpdateSkillList()
        {
            try 
            { 
                using (var context = new AppDbContext())
                {
                    var skillList = context.GetEnemyById(EnemyId).SkillList;
                    if (skillList != null)
                    {
                        SkillList = skillList;
                    }
                    else
                    {
                        MessageBox.Show("No skills found for this enemy.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating skill list: " + ex.Message);
            }
        }

        public void UpdateWeaponList()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var weaponList = context.GetEnemyById(EnemyId).WeaponList;
                    if (weaponList != null)
                    {
                        WeaponList = weaponList;
                    }
                    else
                    {
                        MessageBox.Show("No weapons found for this enemy.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating weapon list: " + ex.Message);
            }
        }
    }
}
