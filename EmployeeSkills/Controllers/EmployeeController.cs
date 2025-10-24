using EmployeeSkills.Models;
using EmployeeSkills.Models.Entities;
using EmployeeSkills.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeSkills.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees
                .Include(e => e.EmployeeSkills)
                .ThenInclude(es => es.Skill)
                .ToListAsync();

            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var vm = new AddEmployeeVM
            {
                SkillItems = await _context.Skills
                    .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.SkillName })
                    .ToListAsync()
            };

            return PartialView("_AddEmployee", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeVM model)
        {
            ModelState.Remove(nameof(model.SkillItems));
            if (!ModelState.IsValid)
            {
                model.SkillItems = await _context.Skills
                    .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.SkillName })
                    .ToListAsync();

                return PartialView("_AddEmployee", model);
            }

            var employee = new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeSkills = model.SelectedSkillIds.Select(id => new EmployeeSkill
                {
                    SkillId = id
                }).ToList()
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            // Return json for ajax success
            return Json(new
            {
                success = true,
                employee = new
                {
                    employee.Id,
                    employee.FirstName,
                    employee.LastName,
                    Skills = employee.EmployeeSkills.Select(es => es.SkillId)
                }
            });
        }
    }
}
