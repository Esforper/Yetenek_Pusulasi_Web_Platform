// Repositories/IScenarioRepository.cs
public interface IScenarioRepository
{
    Task<IScenario> GetByIdAsync(int id);
    Task<IScenario> AddAsync(IScenario scenario);
    // Diğer CRUD operasyonları eklenebilir
}