namespace DailyTracker.LIB.Entities;

public class DailyTask
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TimeOnly? Start { get; set; } = null;

    public TimeOnly? Duration { get; set; } = null;

    public bool IsDone { get; set; } = false;
}