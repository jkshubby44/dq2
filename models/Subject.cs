namespace program.Models;

public class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = string.Empty;

    public ICollection<TeachingAssignment> TeachingAssignments
        { get; set; } = new List<TeachingAssignment>();
}