public interface IScenarioFactory
{
    IScenario CreateScenario(ScenarioType type, DifficultyLevel difficulty);
}