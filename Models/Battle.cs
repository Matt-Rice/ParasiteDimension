using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Thing.Models
{
    public class Battle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BattleId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Enemy> EnemyList = new();

        public void AddOrUpdateEnemy(Enemy enemy)
            {
                if (enemy.BattleId != BattleId)
                {
                    enemy.BattleId = BattleId;
                }
                var existingEnemy = EnemyList.FirstOrDefault(e => e.EnemyId == enemy.EnemyId);
                if (existingEnemy != null)
                {
                   var index = EnemyList.IndexOf(existingEnemy);
                    // Update existing enemy
                    EnemyList[index] = enemy;
                }
                else
                {
                    // Add new enemy
                    EnemyList.Add(enemy);
                }
            }

        public void UpdateEnemyList()
        {
            using (var context = new AppDbContext())
            {
                var enemyList = context.GetBattleById(BattleId).EnemyList;
                if (enemyList != null)
                {
                    EnemyList = enemyList;
                }
                else
                {
                    MessageBox.Show("No enemies found for this battle.");
                }
            }
        }
    }


}
