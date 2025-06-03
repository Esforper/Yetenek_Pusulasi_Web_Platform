// Services/ScenarioService.cs
public class ScenarioService
{
    private readonly IScenarioFactory _scenarioFactory;
    private readonly IScenarioRepository _scenarioRepository;
    // Identity'den öğrenci bilgilerini almak için UserManager da inject edilebilir.
    // private readonly UserManager<ApplicationUser> _userManager;

    public ScenarioService(IScenarioFactory scenarioFactory, IScenarioRepository scenarioRepository)
    {
        _scenarioFactory = scenarioFactory;
        _scenarioRepository = scenarioRepository;
    }

    // Belirli bir öğrenci için yeni bir senaryo oluşturur ve kaydeder
    public async Task<IScenario> CreateAndSaveScenarioAsync(string studentId, ScenarioType type, DifficultyLevel difficulty)
    {
        // Burada öğrencinin geçmiş performansına göre type ve difficulty belirlenebilir.
        // Şimdilik direkt parametre olarak alıyoruz.

        IScenario newScenario = _scenarioFactory.CreateScenario(type, difficulty);

        // İsterseniz senaryoyu öğrenciye atama gibi ek bilgilerle zenginleştirebilirsiniz.
        // newScenario.AssignedStudentId = studentId; (IScenario arayüzüne eklenmeli)

        return await _scenarioRepository.AddAsync(newScenario);
    }

    public async Task<IScenario> GetScenarioByIdAsync(int scenarioId)
    {
        return await _scenarioRepository.GetByIdAsync(scenarioId);
    }

    public async Task<ScenarioEvaluationResult> EvaluateStudentAnswerAsync(int scenarioId, string studentAnswer)
    {
        IScenario scenario = await _scenarioRepository.GetByIdAsync(scenarioId);
        if (scenario == null)
        {
            // Hata yönetimi
            throw new ArgumentException("Scenario not found");
        }

        return scenario.Evaluate(studentAnswer);
    }
}