using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using EscuelaSystemData.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class EditarEstudianteModel : PageModel
    {
        private readonly IEstudianteRepository _estudianteRepository;

        public EditarEstudianteModel(IEstudianteRepository estudianteRepository)
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

            var EstudianteToUpdate = _estudianteRepository.GetbyId(id);
            if (EstudianteToUpdate == null)
                return NotFound();

            EstudianteToUpdate.Carnet = Estudiante.Carnet;
            EstudianteToUpdate.Nombre = Estudiante.Nombre;
            EstudianteToUpdate.Activo = Estudiante.Activo;

            _estudianteRepository.Update(EstudianteToUpdate);

            return RedirectToPage("./Estudiantes");
        }
    }
}
    

