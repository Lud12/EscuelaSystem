using System;
using System.Collections.Generic;
using System.Text;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;

namespace EscuelaSystem.Data.Repositories
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        private readonly ApplicationDbContext _db;
        public MateriaRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
