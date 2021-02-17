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
    public class EliminarDocenteModel : PageModel
    {
        private readonly IDocenteRepository _docenteRepository;

        public EliminarDocenteModel(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }

        [BindProperty]
        public Docente Docente { get; set; }
        public IActionResult OnGet(int id)
        {
            Docente = _docenteRepository.GetbyId(id);
            if (Docente == null)
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

            var docenteToUpdate = _docenteRepository.GetbyId(id);
            if (docenteToUpdate == null)
                return NotFound();

            docenteToUpdate.Codigo = Docente.Codigo;
            docenteToUpdate.Nombre = Docente.Nombre;
            docenteToUpdate.EnLabor = Docente.EnLabor;

            _docenteRepository.Delete(docenteToUpdate);

            return RedirectToPage("./Docentes");
        }
    }
}