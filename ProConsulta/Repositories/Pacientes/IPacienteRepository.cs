using ProConsulta.Models;

namespace ProConsulta.Repositories.Pacientes
{
    public interface IPacienteRepository
    {
        Task AddAsync(Paciente paciente);
        Task UpdateAsync(Paciente paciente);
        Task<List<Paciente>> GetAllAsync();
        Task<Paciente> GetByIdAsync(int id);
        Task DeleteByIdAsync(int id);

    }
}
