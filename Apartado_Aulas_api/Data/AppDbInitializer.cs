
using Apartado_Aulas_api.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Apartado_Aulas_api.Data

{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Edificios.Any())
                {
                    context.Edificios.AddRange(new Edificio()
                    {
                        NumeroEdificio = 1000,
                        NombreEdificio = "Auditorio",
                        Encargado = "Juanito",
                        CantAulas = 3,

                    },
                    new Edificio()
                    {
                        NumeroEdificio = 2000,
                        NombreEdificio = "Biblioteca",
                        Encargado = "Jaimito",
                        CantAulas = 8,

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
