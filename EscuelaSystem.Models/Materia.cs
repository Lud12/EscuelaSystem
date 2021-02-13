using System;
using System.Collections.Generic;
using System.Text;


namespace EscuelaSystem.Models
{
    public class Materia : EntityBase
    {
        public string Codigo { get; set; }
        public String Descripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
