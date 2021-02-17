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
    public class DocentesModel : PageModel
    {
        private readonly IDocenteRepository _docenteRepository;

        public DocentesModel(IDocenteRepository docenteRepository)
        {
            _docenteRepository = docenteRepository;
        }

        [BindProperty]
        public IEnumerable<Docente> Docentes { get; set; }

        public IActionResult OnGet()
        {
            Docentes = _docenteRepository.List();
            return Page();
        }
    }
}

