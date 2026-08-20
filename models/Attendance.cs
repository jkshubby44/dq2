namespace program.Models;

public class Attendance
{
    public int AttendanceId { get; set; }

    public int StudentId { get; set; }

    public int AssignmentId { get; set; }

    public DateTime AttendanceDate { get; set; }

    public string Status { get; set; } = string.Empty;

    public string? Remarks { get; set; }

    public Student Student { get; set; } = null!;

    public TeachingAssignment Assignment { get; set; } = null!;
}