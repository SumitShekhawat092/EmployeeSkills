using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.Models.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string SkillName { get; set; }

        // Navigation property
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
