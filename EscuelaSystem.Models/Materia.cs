using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage = "El campo Codigo de Materia no puede estar vacio")]
        [MinLength(2)]
        [MaxLength(10)]
        [Display(Name = "Codigo de Materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Materia no puede estar vacio")]
        [MinLength(3)]
        [MaxLength(25)]
        [Display(Name = "Nombre de Materia")]
        public string Descripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
