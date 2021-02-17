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
    public class EstudiantesModel : PageModel
    {
     private readonly IEstudianteRepository _estudianteRepository;

    public EstudiantesModel(IEstudianteRepository estudianteRepository)
        {
            _estudianteRepository = estudianteRepository;
         }

            [BindProperty]
            public IEnumerable<Estudiante> Estudiantes { get; set; }

            public IActionResult OnGet()
            {
                Estudiantes = _estudianteRepository.List();
                return Page();
            }
        }
    }

