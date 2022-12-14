using Warehouse.API;

namespace Warehouse.Model;

public class Location : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
}