using Microsoft.AspNetCore.Mvc;
using MvcNetCoreAWSPostgresEC2.Models;
using MvcNetCoreAWSPostgresEC2.Repositories;

namespace MvcNetCoreAWSPostgresEC2.Controllers
{
    public class DepartamentosController : Controller
    {

        private RepositoryHospital _repository;

        public DepartamentosController(RepositoryHospital repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var departamentos = await _repository.GetDepartamentos();
            return View(departamentos);
        }

        public async Task<IActionResult> Details(int id)
        {
            var departamento = await _repository.FindDepartamento(id);
            if (departamento == null)
            {
                return NotFound();
            }
            return View(departamento);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddDepartamento(departamento);
                return RedirectToAction("Index");
            }
            return View(departamento);
        }
    }
}
