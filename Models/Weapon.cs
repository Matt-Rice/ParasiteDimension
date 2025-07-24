using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class Weapon
    {
            public int WeaponId { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Damage { get; set; } = string.Empty;
            public int EnemyId { get; set; }
            public Enemy Enemy { get; set; }
    }
}


