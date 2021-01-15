using Microsoft.AspNetCore.Mvc;
using PracticaEntity.Models;
using PracticaEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaEntity.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamento repo;

        public DepartamentosController(RepositoryDepartamento repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            return View(departamentos);
        }
    }
}
