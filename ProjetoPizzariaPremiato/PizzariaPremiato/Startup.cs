using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PizzariaPremiatoInjecao.Database;
using PizzariaPremiatoInjecao.ExtensaoRepositorio;
using PizzariaPremiatoInjecao.ExtensaoServicos;

namespace PizzariaPremiato
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddMvc();
            services.RegistrarDatabase();
            services.RegistrarServicos();
            services.RegistrarRepositorio();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

           
           /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
           
        }
    }
}
