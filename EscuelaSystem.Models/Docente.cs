using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
    public class Docente : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo de Docente no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Codigo de Docente debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Codigo de Docente debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de Docente")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Docente no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre de Docente debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de Docente debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Docente")]
        public string Nombre { get; set; }
        public bool EnLabor { get; set; }
    }
}
