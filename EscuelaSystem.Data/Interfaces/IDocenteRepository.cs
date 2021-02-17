using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystem.Models;
using EscuelaSystemData.Interfaces;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IDocenteRepository : IRepository<Docente>
    {
        void EnLabor();
    }
}
