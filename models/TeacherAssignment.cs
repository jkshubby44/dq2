namespace program.Models;

public class TeachingAssignment
{
    public int AssignmentId { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public int ClassId { get; set; }

    public string AcademicYear { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public Teacher Teacher { get; set; } = null!;

    public Subject Subject { get; set; } = null!;

    public Class Class { get; set; } = null!;

    public ICollection<Attendance> Attendances
        { get; set; } = new List<Attendance>();

    public ICollection<Performance> Performances
        { get; set; } = new List<Performance>();

    public ICollection<Schedule> Schedules
        { get; set; } = new List<Schedule>();

    public ICollection<NotebookCheck> NotebookChecks
        { get; set; } = new List<NotebookCheck>();
}