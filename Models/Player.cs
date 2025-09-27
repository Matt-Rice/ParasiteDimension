using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Initiative { get; set; } = 0;
        public bool IsDead { get; set; } = false;
        public int BattleId { get; set; }
        public Battle Battle { get; set; }

    }
}
