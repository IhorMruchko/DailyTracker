namespace DailyTracker.LIB.Entities;

public class Day
{
    public DayOfWeek DayName { get; set; }

    public List<DailyTask> EveryDayRoutine { get; set; } = new List<DailyTask>();

    public List<DailyTask> Tasks { get; set; } = new List<DailyTask>();
}
