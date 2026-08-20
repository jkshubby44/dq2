namespace program.Models;

public class Performance
{
    public int PerformanceId { get; set; }

    public int StudentId { get; set; }

    public int AssignmentId { get; set; }

    public string ExamType { get; set; } = string.Empty;

    public DateTime ExamDate { get; set; }

    public decimal MarksObtained { get; set; }

    public decimal MaxMarks { get; set; }

    public string? Grade { get; set; }

    public string? Remarks { get; set; }

    public Student Student { get; set; } = null!;

    public TeachingAssignment Assignment { get; set; } = null!;
}