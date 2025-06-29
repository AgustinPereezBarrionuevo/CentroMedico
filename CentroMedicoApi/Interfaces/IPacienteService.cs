﻿using CentroMedicoApi.Models;

namespace CentroMedicoApi.Interfaces
{
    public interface IPacienteService
    {
        Task<IEnumerable<Paciente>> GetAllAsync();
        Task<Paciente?> GetByIdAsync(int id);
        Task<Paciente> AddAsync(Paciente paciente);
        Task UpdateAsync(Paciente paciente);
        Task DeleteAsync(int id);
    }
}
