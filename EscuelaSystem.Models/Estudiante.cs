using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EscuelaSystem.Models
{
    public class Estudiante : EntityBase
    {
        [Required(ErrorMessage = "El campo Carnet de Estudiante no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Carnet de Estudiante debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Carnet de Estudiante debe tener maximo 10 caracteres")]
        [Display(Name = "Carnet de Estudiante")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Estudiante no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre de Estudiante debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de Estudiante debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Estudiante")]
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
