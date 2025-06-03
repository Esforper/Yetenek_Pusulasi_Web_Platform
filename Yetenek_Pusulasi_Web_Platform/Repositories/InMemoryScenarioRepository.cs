// Repositories/InMemoryScenarioRepository.cs (Örnek amaçlı)
public class InMemoryScenarioRepository : IScenarioRepository
{
    private readonly List<IScenario> _scenarios = new List<IScenario>();
    private int _nextId = 1;

    public Task<IScenario> GetByIdAsync(int id)
    {
        return Task.FromResult(_scenarios.FirstOrDefault(s => s.Id == id));
    }

    public Task<IScenario> AddAsync(IScenario scenario)
    {
        scenario.Id = _nextId++;
        _scenarios.Add(scenario);
        return Task.FromResult(scenario);
    }
}