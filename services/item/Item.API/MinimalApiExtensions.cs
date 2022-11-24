using Microsoft.AspNetCore.Mvc;
using Warehouse.Model;

namespace Warehouse.API;

public static class MinimalApiExtensions
{
    public static WebApplication MapCRUD<T>(this WebApplication app, string routePrefix) where T : IEntity, new()
    {
        app.MapGet($"/{routePrefix}", (IRepository<T> repo) =>
        {
            return repo.GetAll();
        });

        app.MapGet($"/{routePrefix}/{{id}}", (IRepository<T> repo, int id) =>
        {
            return repo.GetById(id);
        });

        app.MapPost($"/{routePrefix}", (IRepository<T> repo, [FromBody]T entity) =>
        {
            repo.Create(entity);
            return Results.Created($"/warehouse/{entity.Id}", entity);
        });

        app.MapPut($"/{routePrefix}/{{id}}", (IRepository<T> repo, int id, [FromBody]T entity) =>
        {
            repo.Update(id, entity);
            return Results.NoContent();
        });

        app.MapDelete($"/{routePrefix}/{{id}}", (IRepository<T> repo, int id) =>
        {
            repo.Delete(id);
            return Results.NoContent();
        });
        
        return app;
    }
}