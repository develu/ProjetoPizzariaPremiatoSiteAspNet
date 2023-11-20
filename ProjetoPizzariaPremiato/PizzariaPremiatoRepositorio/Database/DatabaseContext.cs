using Microsoft.EntityFrameworkCore;
using PizzariaPremiatoRepositorio.Entidades;

namespace PizzariaPremiatoRepositorio.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Categoria> CategoriaEntity { get; set; }
        public DbSet<Pizza> PizzaEntity { get; set; }
        public DbSet<UsuarioLogin> UsuarioLogin { get; set; }

    }
}

