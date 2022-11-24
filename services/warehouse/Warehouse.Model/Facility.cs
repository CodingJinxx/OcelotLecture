using Warehouse.API;

namespace Warehouse.Model;

public class Facility : IEntity
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public List<int> StockedItemIds { get; set; }
}