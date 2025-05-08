using Microsoft.EntityFrameworkCore;

namespace MvcNetCoreAWSPostgresEC2.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }
        public DbSet<MvcNetCoreAWSPostgresEC2.Models.Departamento> Departamentos { get; set; }
    }
}
