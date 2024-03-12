using MotocycleRepair.Domain.Common;

public class Product : BaseAuditableEntity
{
    public Guid CustomerId { get; set; }
    public string ProductName { get; set; }
    public int Year { get; set; }
    public int Kilometers { get; set; }
    public string ChassisNumber { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }

    // Navigation properties
    public virtual Customer Customer { get; set; }
    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
