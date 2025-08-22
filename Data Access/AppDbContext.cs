using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
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

    #region Get By ID
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

    public Enemy? GetEnemyById(int enemyId)
    {
        Enemy? selectedEnemy;

        try
        {
            using (var context = new AppDbContext())
            {
                selectedEnemy = context.Enemies
                    .Include(e => e.SkillList)
                    .Include(e => e.WeaponList)
                    .Where(e => e.EnemyId == enemyId)
                    .FirstOrDefault() ?? throw new NullReferenceException(nameof(addForm));
            }
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

        return selectedEnemy;
    }
        public Skill? GetSkillById(int skillId)
    {
        Skill? selectedSkill;

        try
        {
            using (var context = new AppDbContext())
            {
                selectedSkill = context.Skills
                    .Where(s => s.SkillId == skillId)
                    .FirstOrDefault() ?? throw new NullReferenceException(nameof(addForm));
            }
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

        return selectedSkill;
    }
        public Weapon? GetWeaponById(int weaponId)
    {
        Weapon? selectedWeapon;

        try
        {
            using (var context = new AppDbContext())
            {
                selectedWeapon = context.Weapons
                    .Where(w => w.WeaponId == weaponId)
                    .FirstOrDefault() ?? throw new NullReferenceException(nameof(addForm));
            }
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

        return selectedWeapon;
    }

    #endregion

    #region Insert Entities

    public bool InsertEnemy(Enemy enemy)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Enemies.Add(enemy);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }

    public bool InsertBattle(Battle battle)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Battles.Add(battle);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }
        
    public bool InsertSkill(Skill skill)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Skills.Add(skill);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }
        
    public bool InsertWeapon(Weapon weapon)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Weapons.Add(weapon);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }
    #endregion

    #region Delete By ID
    public bool DeleteBattleByID(int battleId)
    {
        bool success = false;
        try
        {
            using (var db = new AppDbContext())
            {
                var battle = db.GetBattleById(battleId);

                db.Battles.Remove(battle);
                db.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        return success;
    }
        public bool DeleteSkillByID(int skillId)
    {
        bool success = false;
        try
        {
            using (var db = new AppDbContext())
            {
                var skill = db.GetSkillById(skillId);

                db.Skills.Remove(skill);
                db.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        return success;
    }
        public bool DeleteEnemyByID(int enemyId)
    {
        bool success = false;
        try
        {
            using (var db = new AppDbContext())
            {
                var enemy = db.GetEnemyById(enemyId);

                db.Enemies.Remove(enemy);
                db.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        return success;
    }
        public bool DeleteWeaponByID(int weaponId)
    {
        bool success = false;
        try
        {
            using (var db = new AppDbContext())
            {
                var weapon = db.GetWeaponById(weaponId);

                db.Weapons.Remove(weapon);
                db.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }

        return success;
    }

    #endregion

    #region Update Entities

    public bool UpdateEnemy(Enemy enemy)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Enemies.Update(enemy);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }

    public bool UpdateBattle(Battle battle)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Battles.Update(battle);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }

    public bool UpdateSkill(Skill skill)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Skills.Update(skill);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }

    public bool UpdateWeapon(Weapon weapon)
    {
        bool success = false;
        try
        {
            using (var context = new AppDbContext())
            {
                context.Weapons.Update(weapon);
                context.SaveChanges();
                success = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return success;
    }
    #endregion
}



