using Microsoft.EntityFrameworkCore;
using TWJobs.Core.Data.EntityConfigs;
using TWJobs.Core.Models;

namespace TWJobs.Core.Data.Contexts
{
    public class TWJobsDbContext : DbContext
    {
        public DbSet<Job> Jobs => Set<Job>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=NomeDoServidor;Database=NomeDoBancoDeDados;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new JobEntityConfig());
        }
    }
}
