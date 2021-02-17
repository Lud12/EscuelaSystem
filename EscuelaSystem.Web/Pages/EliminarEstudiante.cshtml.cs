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
    public class EliminarEstudianteModel : PageModel
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EliminarEstudianteModel(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }
        public IActionResult OnGet(int id)
        {
            Estudiante = _estudianteRepository.GetbyId(id);
            if (Estudiante == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var estudianteToUpdate = _estudianteRepository.GetbyId(id);
            if (estudianteToUpdate == null)
                return NotFound();

            estudianteToUpdate.Carnet = Estudiante.Carnet;
            estudianteToUpdate.Nombre = Estudiante.Nombre;
            estudianteToUpdate.Activo = Estudiante.Activo;

            _estudianteRepository.Delete(estudianteToUpdate);

            return RedirectToPage("./Estudiantes");
        }
    }
}
