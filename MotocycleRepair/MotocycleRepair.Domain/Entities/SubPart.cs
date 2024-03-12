using MotocycleRepair.Domain.Common;

public class SubPart : BaseAuditableEntity
{
    public Guid PartId { get; set; }
    public string SubPartName { get; set; }
    public decimal SubPartPrice { get; set; }
    public string SubPartType { get; set; }
    public string Description { get; set; }

    // Navigation property
    public virtual Part Part { get; set; }
}
