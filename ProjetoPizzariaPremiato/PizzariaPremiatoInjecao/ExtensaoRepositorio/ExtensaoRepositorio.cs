using Microsoft.Extensions.DependencyInjection;
using PizzariaPremiatoRepositorio.interfaces;
using PizzariaPremiatoRepositorio.repositorio;

namespace PizzariaPremiatoInjecao.ExtensaoRepositorio
{
    public static class ExtensaoRepositorio
    {
        public static IServiceCollection RegistrarRepositorio(this IServiceCollection servicos) {

            servicos.AddScoped<IUsuarioLoginRepositorio, UsuarioLoginRepositorio>();            
            servicos.AddScoped<IPizzaRepositorio, PizzaRepositorio>();            
            servicos.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();            

            return servicos;
        }
    }
}
