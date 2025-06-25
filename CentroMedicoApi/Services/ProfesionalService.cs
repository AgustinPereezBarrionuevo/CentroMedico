using CentroMedicoApi.Data;
using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CentroMedicoApi.Services
{
    public class ProfesionalService : IProfesionalService
    {
        private readonly CentroMedicoContext _context;

        public ProfesionalService(CentroMedicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesional>> GetAllAsync()
        {
            return await _context.Profesionales.ToListAsync();
        }

        public async Task<Profesional> GetByIdAsync(int id)
        {
            return await _context.Profesionales.FindAsync(id);
        }

        public async Task<Profesional> AddAsync(Profesional profesional)
        {
            _context.Profesionales.Add(profesional);
            await _context.SaveChangesAsync();
            return profesional;
        }


        public async Task<bool> UpdateAsync(Profesional profesional)
        {
            var existing = await _context.Profesionales.FindAsync(profesional.Id);
            if (existing == null) return false;

            existing.Nombre = profesional.Nombre;
            existing.Especialidad = profesional.Especialidad;
            existing.Matricula = profesional.Matricula;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _context.Profesionales.FindAsync(id);
            if (existing == null) return false;

            _context.Profesionales.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

       
    }
}
