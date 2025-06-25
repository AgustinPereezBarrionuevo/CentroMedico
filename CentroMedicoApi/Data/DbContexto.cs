using CentroMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CentroMedicoApi.Data
{
    public class CentroMedicoContext : DbContext
    {
        public CentroMedicoContext(DbContextOptions<CentroMedicoContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<CentroMedico> CentrosMedicos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}