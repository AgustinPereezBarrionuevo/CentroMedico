using CentroMedicoApi.Data;
using CentroMedicoApi.Interfaces;
using CentroMedicoApi.Models;
using Microsoft.EntityFrameworkCore;

public class CentroMedicoService : ICentroMedicoService
{
    private readonly CentroMedicoContext _context;

    public CentroMedicoService(CentroMedicoContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CentroMedico>> GetAllAsync()
    {
        return await _context.CentrosMedicos.ToListAsync();
    }

    public async Task<CentroMedico> GetByIdAsync(int id)
    {
        return await _context.CentrosMedicos.FindAsync(id);
    }

    public async Task<CentroMedico> AddAsync(CentroMedico centroMedico)
    {
        _context.CentrosMedicos.Add(centroMedico);
        await _context.SaveChangesAsync();
        return centroMedico;
    }

    public async Task<bool> UpdateAsync(CentroMedico centroMedico)
    {
        var existing = await _context.CentrosMedicos.FindAsync(centroMedico.Id);
        if (existing == null) return false;

        existing.Nombre = centroMedico.Nombre;
        existing.Direccion = centroMedico.Direccion;
        existing.Telefono = centroMedico.Telefono;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var existing = await _context.CentrosMedicos.FindAsync(id);
        if (existing == null) return false;

        _context.CentrosMedicos.Remove(existing);
        await _context.SaveChangesAsync();
        return true;
    }
}
