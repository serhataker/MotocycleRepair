using MotocycleRepair.Domain.Common;

public class SupplierSubPart : BaseAuditableEntity
{
    public Guid SupplierId { get; set; }
    public Guid SubPartId { get; set; }
    public string Description { get; set; }

    // Navigation properties
    public virtual Supplier Supplier { get; set; }
    public virtual SubPart SubPart { get; set; }
}