public class ScenarioEvaluationResult
{
    public bool IsSuccessful { get; set; }
    public string Feedback { get; set; }
    public int Score { get; set; } // Opsiyonel, değerlendirme şekline göre değişir
    // Diğer değerlendirme metrikleri eklenebilir
}