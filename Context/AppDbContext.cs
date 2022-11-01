using ApiDicasWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiDicasWeb.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options ) {}

        public DbSet<Dica>? Dicas { get; set; }
    }
}
