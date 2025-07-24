using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Thing.Models;

namespace Thing;
    public class AppDbContext : DbContext
    {
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=app.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Enemy>()
            .HasOne(e => e.Battle)
            .WithMany(b => b.EnemyList)
            .HasForeignKey(e => e.BattleId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Skill>()
            .HasOne(s => s.Enemy)
            .WithMany(e => e.SkillList)
            .HasForeignKey(s => s.SkillId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Weapon>()
            .HasOne(w => w.Enemy)
            .WithMany(e => e.WeaponList)
            .HasForeignKey(w => w.WeaponId)
            .OnDelete(DeleteBehavior.Cascade);

    }

    public Battle? GetBattleById(int battleId)
    {
        Battle? selectedBattle;
        using (var context = new AppDbContext())
        {
            try
            {
                selectedBattle = context.Battles
                    .Include(b => b.EnemyList)
                    .Where(b => b.BattleId == battleId)
                    .FirstOrDefault() ?? throw new NullReferenceException(nameof(addForm));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        return selectedBattle;
    }


}

