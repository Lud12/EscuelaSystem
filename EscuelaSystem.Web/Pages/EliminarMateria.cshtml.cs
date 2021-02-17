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
    public class EliminarMateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRepository;

        public EliminarMateriaModel(IMateriaRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public Materia Materia { get; set; }
        public IActionResult OnGet(int id)
        {
            Materia = _materiaRepository.GetbyId(id);
            if (Materia == null)
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

            var materiaToUpdate = _materiaRepository.GetbyId(id);
            if (materiaToUpdate == null)
                return NotFound();

            materiaToUpdate.Codigo = Materia.Codigo;
            materiaToUpdate.Descripcion = Materia.Descripcion;
            materiaToUpdate.Habilitada = Materia.Habilitada;

            _materiaRepository.Delete(materiaToUpdate);

            return RedirectToPage("./Materias");
        }
    }
}