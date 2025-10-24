using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }
        // Navigation property
        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
