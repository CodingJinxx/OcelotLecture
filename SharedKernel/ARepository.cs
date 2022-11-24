namespace Warehouse.API;

public class ARepository<T> : IRepository<T> where T : IEntity, new()
{
    private readonly Dictionary<int, T> _store = new Dictionary<int, T>();
    public void Create(T item) => _store.Add(item.Id, item);
    public void Delete(int id) => _store.Remove(id);
    public T GetById(int id) => _store[id];
    public IEnumerable<T> GetAll() => _store.Values;
    public void Update(int id, T item) => _store[id] = item;
}