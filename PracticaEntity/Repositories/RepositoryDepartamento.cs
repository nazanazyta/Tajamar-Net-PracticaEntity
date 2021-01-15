using PracticaEntity.Data;
using PracticaEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaEntity.Repositories
{
    public class RepositoryDepartamento
    {
        private DepartamentoContext context;

        public RepositoryDepartamento(DepartamentoContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }
    }
}
