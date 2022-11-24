using Warehouse.API;

namespace Warehouse.Model;

public class StockedItem : IEntity
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
}