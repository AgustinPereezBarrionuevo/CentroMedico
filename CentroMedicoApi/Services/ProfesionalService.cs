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

<<<<<<< HEAD
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
=======
        public Profesional GetById(int id)
        {
            return _profesionales.FirstOrDefault(c => c.Id == id);
        }

        public Profesional Update(int id, Profesional actualizado)
        {
            var existente = GetById(id);
            if (existente == null)
                return null;

            existente.Nombre = actualizado.Nombre;
            existente.Especialidad = actualizado.Especialidad;
            existente.Matricula = actualizado.Matricula;

            return existente;
        }

        public void Delete(int id)
        {
            var profesional = GetById(id);
            if (profesional != null)
            {
                _profesionales.Remove(profesional);
            }
>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
        }
    }
}
