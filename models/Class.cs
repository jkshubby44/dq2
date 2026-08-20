namespace program.Models;

public class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = string.Empty;

    public string Section { get; set; } = string.Empty;

    public ICollection<Student> Students
        { get; set; } = new List<Student>();

    public ICollection<TeachingAssignment> TeachingAssignments
        { get; set; } = new List<TeachingAssignment>();
}