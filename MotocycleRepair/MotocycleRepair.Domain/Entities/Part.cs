using MotocycleRepair.Domain.Common;

public class Part : BaseAuditableEntity
{
    public string PartName { get; set; }
    public decimal Price { get; set; }
    public string PartType { get; set; }
    public string Description { get; set; }

    // Navigation property
    public virtual ICollection<SubPart> SubParts { get; set; } = new List<SubPart>();
}