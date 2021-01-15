using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaEntity.Models;

namespace PracticaEntity.Data
{
    public class DepartamentoContext: DbContext
    {
        public DepartamentoContext(DbContextOptions options)
            : base(options)
        {}

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
