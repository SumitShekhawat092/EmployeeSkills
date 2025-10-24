using EmployeeSkills.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSkills.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EmployeeSkill>()
               .HasKey(x => new { x.EmployeeId, x.SkillId });


            //relationship with Employee
            modelBuilder.Entity<EmployeeSkill>().HasOne(es => es.Employee)
                .WithMany(e => e.EmployeeSkills)
                .HasForeignKey(es => es.EmployeeId);

            // Relationship with Skill
            modelBuilder.Entity<EmployeeSkill>().HasOne(es => es.Skill)
                .WithMany(s => s.EmployeeSkills)
                .HasForeignKey(es => es.SkillId);

            // Default Skills
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, SkillName = "C#" },
                new Skill { Id = 2, SkillName = "Dot Net" },
                new Skill { Id = 3, SkillName = "SQL" },
                new Skill { Id = 4, SkillName = "Angular" },
                new Skill { Id = 5, SkillName = "React Js" }
            );

        }

    }
}
