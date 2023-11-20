using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzariaPremiatoRepositorio.Database;

namespace PizzariaPremiatoInjecao.Database
{
    public static class ExtensaoDatabase
    {

        public static IServiceCollection RegistrarDatabase(this IServiceCollection servicos)
        {
            servicos.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=pizzaria_db;Integrated Security=True;");

            });

            return servicos;
        }

    }
}
