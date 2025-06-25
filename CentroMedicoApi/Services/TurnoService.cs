using CentroMedicoApi.Data;
using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CentroMedicoApi.Services
{
    public class TurnoService : ITurnoService
    {
        private readonly CentroMedicoContext _context;

        public TurnoService(CentroMedicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Turno>> GetAllAsync()
        {
            return await _context.Turnos.ToListAsync();
        }

        public async Task<Turno> GetByIdAsync(int id)
        {
            return await _context.Turnos.FindAsync(id);
        }

        public async Task<Turno> AddAsync(Turno turno)
        {
            _context.Turnos.Add(turno);
            await _context.SaveChangesAsync();
            return turno;
        }

        public async Task<bool> UpdateAsync(Turno turno)
        {
            var existing = await _context.Turnos.FindAsync(turno.Id);
            if (existing == null) return false;

            existing.PacienteId = turno.PacienteId;
            existing.ProfesionalId = turno.ProfesionalId;
            existing.FechaHora = turno.FechaHora;
            existing.Estado = turno.Estado;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.Turnos.FindAsync(id);
            if (existing == null) return false;

            _context.Turnos.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
