namespace program.Models;

public class Equipment
{
    public int EquipmentId { get; set; }

    public int EquipmentCategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public string Condition { get; set; } = string.Empty;

    public EquipmentCategory EquipmentCategory { get; set; } = null!;

    public ICollection<EquipmentTransaction> Transactions
        { get; set; } = new List<EquipmentTransaction>();
}