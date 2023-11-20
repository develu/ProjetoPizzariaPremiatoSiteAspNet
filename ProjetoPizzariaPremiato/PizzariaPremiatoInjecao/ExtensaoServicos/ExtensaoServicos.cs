using Microsoft.Extensions.DependencyInjection;
using PizzariaPremiatoServicos.Interfaces.Categoria;
using PizzariaPremiatoServicos.Interfaces.Pizza;
using PizzariaPremiatoServicos.Interfaces.UsuarioLogin;
using PizzariaPremiatoServicos.Servicos.Categoria;
using PizzariaPremiatoServicos.Servicos.Pizza;
using PizzariaPremiatoServicos.Servicos.UsuarioLogin;

namespace PizzariaPremiatoInjecao.ExtensaoServicos
{
    public static class ExtensaoServicos
    {
        public static IServiceCollection RegistrarServicos(this IServiceCollection servicos)
        {

            servicos.AddScoped<IUsuarioLoginServico, UsuarioLoginServico>();
            servicos.AddScoped<IPizzaServico, PizzaServico>();
            servicos.AddScoped<ICategoriaServico, CategoriaServico>();

            return servicos;
        }
    }
}
