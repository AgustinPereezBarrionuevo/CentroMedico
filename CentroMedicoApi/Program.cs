
using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Services;

namespace CentroMedicoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          

            builder.Services.AddControllers();

            builder.Services.AddSingleton<IPacienteService, PacienteService>();
            builder.Services.AddSingleton<ICentroMedicoService, CentroMedicoService>();
            builder.Services.AddSingleton<IProfesionalService, ProfesionalService>();
            builder.Services.AddSingleton<ITurnoService, TurnoService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

         
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
