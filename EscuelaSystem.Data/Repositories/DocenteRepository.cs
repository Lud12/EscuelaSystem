using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;

namespace EscuelaSystem.Data.Repositories
{
    public class DocenteRepository : Repository<Docente>, IDocenteRepository
    {
        private readonly ApplicationDbContext _db;
        public DocenteRepository(ApplicationDbContext db) : base(db)
        {

        }

        public void EnLabor()
        {
            var labor = _db.Docentes.Where(c => c.EnLabor == true).ToList();
            _db.RemoveRange(labor);
            _db.SaveChanges();
        }
    }
}
