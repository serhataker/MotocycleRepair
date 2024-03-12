using MotocycleRepair.Domain.Common;

public class Supplier : BaseAuditableEntity
{
    public string SupplierName { get; set; }
    public string CompanyTitle { get; set; }
    public string TaxNumber { get; set; }
    public decimal SalePrice { get; set; }
    public string Description { get; set; }
}
