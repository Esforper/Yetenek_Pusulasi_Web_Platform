// Services/Factories/ConcreteScenarioFactory.cs
public class ConcreteScenarioFactory : IScenarioFactory
{
    public IScenario CreateScenario(ScenarioType type, DifficultyLevel difficulty)
    {
        // Senaryo açıklamaları veritabanından veya konfigürasyondan da gelebilir.
        // Şimdilik sabit değerler kullanıyoruz.
        switch (type)
        {
            case ScenarioType.ProblemSolving:
                return new ProblemSolvingScenario(difficulty, "Bir grup arkadaşınızla kayboldunuz. Geri dönüş yolunu nasıl bulursunuz?");
            case ScenarioType.Empathy:
                return new EmpathyScenario(difficulty, "Arkadaşın sınavdan düşük not aldı ve çok üzgün. Ona nasıl destek olursun?");
            case ScenarioType.AnalyticalThinking:
                // return new AnalyticalThinkingScenario(difficulty, "...");
                // Şimdilik NotImplementedException, diğer senaryolar eklendikçe doldurulur.
                throw new NotImplementedException($"Scenario type {type} is not yet implemented in the factory.");
            case ScenarioType.DecisionMaking:
                // return new DecisionMakingScenario(difficulty, "...");
                throw new NotImplementedException($"Scenario type {type} is not yet implemented in the factory.");
            default:
                throw new ArgumentOutOfRangeException(nameof(type), $"Unsupported scenario type: {type}");
        }
    }
}