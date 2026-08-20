namespace program.Models;

public class Teacher
{
    public int TeacherId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public User User { get; set; } = null!;

    public ICollection<TeachingAssignment> TeachingAssignments
        { get; set; } = new List<TeachingAssignment>();
}