using CentroMedicoApi.Data;
using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CentroMedicoApi.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly CentroMedicoContext _context;

        public PacienteService(CentroMedicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Paciente> AddAsync(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
            return paciente;
        }

<<<<<<< HEAD
        public async Task<Paciente?> GetByIdAsync(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            await _context.SaveChangesAsync();
        }
=======
        public Paciente GetById(int id)
        {
            return _pacientes.FirstOrDefault(p => p.Id == id);
        }


        public void Delete(int id)
        {
            var paciente = GetById(id);
            if (paciente != null)
            {
                _pacientes.Remove(paciente);
            }
        }


>>>>>>> 1180917e3681d575638bed515d97e3a9e9e74b55
    }
}
