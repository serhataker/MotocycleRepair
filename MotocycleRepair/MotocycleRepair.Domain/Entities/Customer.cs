using MotocycleRepair.Domain.Common;

public class Customer : BaseAuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }
    public string Description { get; set; }

    // Navigation property
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
