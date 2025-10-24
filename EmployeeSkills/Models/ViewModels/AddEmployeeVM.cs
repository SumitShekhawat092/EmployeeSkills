using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.Models.ViewModels
{
    public class AddEmployeeVM
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please select at lest one skill.")]
        public List<int> SelectedSkillIds { get; set; }

        public IEnumerable<SelectListItem> SkillItems { get; set; }
    }
}
