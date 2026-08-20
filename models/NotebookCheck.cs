namespace program.Models;

public class NotebookCheck
{
    public int NotebookCheckId { get; set; }

    public int StudentId { get; set; }

    public int AssignmentId { get; set; }

    public DateTime CheckDate { get; set; }

    public string Status { get; set; } = string.Empty;

    public string? Remarks { get; set; }

    public Student Student { get; set; } = null!;

    public TeachingAssignment Assignment { get; set; } = null!;
}