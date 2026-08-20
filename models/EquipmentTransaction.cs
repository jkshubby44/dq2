namespace program.Models;

public class EquipmentTransaction
{
    public int TransactionId { get; set; }

    public int EquipmentId { get; set; }

    public int UserId { get; set; }

    public int Quantity { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string Status { get; set; } = string.Empty;

    public Equipment Equipment { get; set; } = null!;

    public User User { get; set; } = null!;
}