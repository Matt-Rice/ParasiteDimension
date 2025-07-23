using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class Enemy
    {
        public int EnemyId { get; set; }
        public string Name { get; set; } = string.Empty;
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
    }
}
