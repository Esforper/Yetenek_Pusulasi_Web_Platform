public class EmpathyScenario : IScenario
{
    public int Id { get; set; }
    public string Title => "Duygusal Durum Analizi";
    public string Description { get; private set; }
    public ScenarioType Type => ScenarioType.Empathy;
    public DifficultyLevel Difficulty { get; private set; }

    public EmpathyScenario(DifficultyLevel difficulty, string specificDescription = "Bu durumda karakterin ne hissettiğini ve nedenini açıklayın.")
    {
        Difficulty = difficulty;
        Description = specificDescription + $" (Zorluk: {difficulty})";
    }

    public ScenarioEvaluationResult Evaluate(string studentAnswer)
    {
        // Empatiye özgü değerlendirme mantığı.
        // Örnek: Duygu ifadelerinin kullanımı, perspektif alma becerisi vs.
        if (studentAnswer.ToLower().Contains("anlamak") && studentAnswer.ToLower().Contains("hissetmek"))
        {
            return new ScenarioEvaluationResult { IsSuccessful = true, Feedback = "Karakterin duygularını iyi analiz ettiniz.", Score = 90 };
        }
        return new ScenarioEvaluationResult { IsSuccessful = false, Feedback = "Karakterin duygusal durumunu daha derinlemesine incelemeyi deneyin.", Score = 50 };
    }
}
