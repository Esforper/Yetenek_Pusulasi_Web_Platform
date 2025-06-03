// Models/ProblemSolvingScenario.cs
public class ProblemSolvingScenario : IScenario
{
    public int Id { get; set; }
    public string Title => "Zorlu Bulmaca";
    public string Description { get; private set; }
    public ScenarioType Type => ScenarioType.ProblemSolving;
    public DifficultyLevel Difficulty { get; private set; }

    public ProblemSolvingScenario(DifficultyLevel difficulty, string specificDescription = "Verilen problemi çözmek için adımlarınızı açıklayın.")
    {
        Difficulty = difficulty;
        Description = specificDescription + $" (Zorluk: {difficulty})";
    }

    public ScenarioEvaluationResult Evaluate(string studentAnswer)
    {
        // Burada probleme özgü değerlendirme mantığı olacak.
        // Örnek: Anahtar kelime kontrolü, adım sayısı, mantıksal tutarlılık vs.
        // Basit bir örnek:
        if (studentAnswer.ToLower().Contains("çözüm") && studentAnswer.Length > 50)
        {
            return new ScenarioEvaluationResult { IsSuccessful = true, Feedback = "Harika bir problem çözme yaklaşımı!", Score = 85 };
        }
        return new ScenarioEvaluationResult { IsSuccessful = false, Feedback = "Daha detaylı bir açıklama veya farklı bir yaklaşım deneyebilirsiniz.", Score = 40 };
    }
}