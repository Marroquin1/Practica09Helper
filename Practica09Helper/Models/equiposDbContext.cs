using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace Practica09Helper.Models
{
    public class equiposDbContext: DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<equipos> equipos { get; set; }
    }
}
