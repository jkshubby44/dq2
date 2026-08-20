namespace program.Models;

public class EquipmentCategory
{
    public int EquipmentCategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public ICollection<Equipment> Equipment
        { get; set; } = new List<Equipment>();
}