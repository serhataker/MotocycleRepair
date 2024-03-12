using MotocycleRepair.Domain.Common;

public class Process : BaseAuditableEntity
{
    public Guid ProductId { get; set; }
    public string ProcessName { get; set; }
    public string ProcessType { get; set; }
    public int Duration { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    // Navigation property
    public virtual Product Product { get; set; }
}
