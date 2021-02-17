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
    public class CrearDocenteModel : PageModel
    {
        private readonly IDocenteRepository _docenteRepository;

        public CrearDocenteModel(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }

        [BindProperty]
        public Docente Docente { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _docenteRepository.Insert(Docente);

            return RedirectToPage("./Docentes");
        }
    }
}
