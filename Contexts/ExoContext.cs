using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=DESKTOP-N1ATTAE\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
                );
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
