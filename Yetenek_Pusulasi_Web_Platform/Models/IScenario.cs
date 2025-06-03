public interface IScenario
{
    int Id { get; set; } // Veritabanından geliyorsa
    string Title { get; }
    string Description { get; }
    ScenarioType Type { get; }
    DifficultyLevel Difficulty { get; }

    // Öğrenciye senaryoyu sunmak için kullanılabilir (View Model döndürebilir)
    // Bu metot, senaryoya özgü UI elemanlarını veya verilerini hazırlayabilir.
    // Şimdilik basit tutalım, UI kısmı Controller ve View'larda ele alınacak.
    // void PresentUI(dynamic viewModel);

    ScenarioEvaluationResult Evaluate(string studentAnswer);
}