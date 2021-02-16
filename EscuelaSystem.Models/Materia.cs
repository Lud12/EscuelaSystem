using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo de Materia no puede estar vacio")]
        [MinLength(2, ErrorMessage = "El campo Codigo de Materia debe tener minimo 2 caracteres")]
        [MaxLength(10, ErrorMessage = "El campo Codigo de Materia debe tener maximo 10 caracteres")]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Materia no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El campo Nombre de Materia debe tener minimo 3 caracteres")]
        [MaxLength(25, ErrorMessage = "El campo Nombre de Materia debe tener maximo 25 caracteres")]
        [Display(Name = "Nombre de Materia")]
        public string Descripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
