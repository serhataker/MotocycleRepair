using MotocycleRepair.Domain.Common;

public class SupplierPart : BaseAuditableEntity
{
    public Guid SupplierId { get; set; }
    public Guid PartId { get; set; }
    public string Description { get; set; }

    // Navigation properties
    public virtual Supplier Supplier { get; set; }
    public virtual Part Part { get; set; }
}