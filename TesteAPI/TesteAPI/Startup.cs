using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Repositorio.Contexto;

namespace TesteAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            //configuração de string de conexao com o banco MySQL
            //arquivo obrigatorio e quando houver mudança será recarregado
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json",optional:false,reloadOnChange:true);

            Configuration = builder.Build();//constroi chave de valor das configurações
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TesteAPI",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Email = "rafael.actt@gmail.com",
                        Name = "Rafael Castro",
                        Url = new Uri("https://github.com/rafael-act/CastGroup-Teste")
                    },
                    Description = "Aplicação desenvolvida para teste de avaliação técnico CastGroup"
                });
            });

            //configurando string de conexao
            var connectionString = Configuration.GetConnectionString("CastGroupDB");
            services.AddDbContext<CastGroupContexto>(option => 
                                                     option.UseLazyLoadingProxies()
                                                     .UseMySql(connectionString,ServerVersion.AutoDetect("connectionString"),
                                                     m=>m.MigrationsAssembly("TesteAPI.Repositorio")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteAPI v1")) ;
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
