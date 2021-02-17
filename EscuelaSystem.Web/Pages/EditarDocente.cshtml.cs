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
    public class EditarDocenteModel : PageModel
    {
        private readonly IDocenteRepository _docenteRepository;

        public EditarDocenteModel(IDocenteRepository docenteRepository)
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

            var DocenteToUpdate = _docenteRepository.GetbyId(id);
            if (DocenteToUpdate == null)
                return NotFound();

            DocenteToUpdate.Codigo = Docente.Codigo;
            DocenteToUpdate.Nombre = Docente.Nombre;
            DocenteToUpdate.EnLabor = Docente.EnLabor;

            _docenteRepository.Update(DocenteToUpdate);

            return RedirectToPage("./Docentes");
        }
    }
}

