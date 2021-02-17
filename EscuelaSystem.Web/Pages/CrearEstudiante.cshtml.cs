using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class CrearEstudianteModel : PageModel
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public CrearEstudianteModel(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _estudianteRepository.Insert(Estudiante);

            return RedirectToPage("./Estudiantes");
        }
    }
}
