using Microsoft.EntityFrameworkCore;
using MvcNetCoreAWSPostgresEC2.Data;
using MvcNetCoreAWSPostgresEC2.Models;

namespace MvcNetCoreAWSPostgresEC2.Repositories
{
    public class RepositoryHospital
    {

        private HospitalContext _context;

        public RepositoryHospital(HospitalContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> GetDepartamentos()
        {
            return await _context.Departamentos.ToListAsync();
        }

        public async Task<Departamento> FindDepartamento(int id)
        {
            return await _context.Departamentos.FindAsync(id);
        }

        public async Task<Departamento> AddDepartamento(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();
            return departamento;
        }
    }
}
