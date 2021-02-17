using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;

namespace EscuelaSystem.Data.Repositories
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        private readonly ApplicationDbContext _db;
        public EstudianteRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void Activo()
        {
            var activos = _db.Estudiantes.Where(c => c.Activo == true).ToList();
            _db.RemoveRange(activos);
            _db.SaveChanges();
        }
    }
}
