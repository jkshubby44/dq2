namespace program.Models;

public class Schedule
{
    public int ScheduleId { get; set; }

    public int AssignmentId { get; set; }

    public string Day { get; set; } = string.Empty;

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string? Room { get; set; }

    public TeachingAssignment Assignment { get; set; } = null!;
}