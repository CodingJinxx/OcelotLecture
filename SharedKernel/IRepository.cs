namespace Warehouse.API;

public interface IRepository<T> where T : IEntity, new()
{
    public void Create(T item);
    public void Delete(int id);
    public T GetById(int id);
    
    public IEnumerable<T> GetAll();
    public void Update(int id, T item);
}