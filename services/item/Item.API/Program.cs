using Item.Model;
using Microsoft.AspNetCore.Mvc;
using Warehouse.API;
using Warehouse.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository<CataloguedItem>, ARepository<CataloguedItem>>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Warehouse CRUD

app.MapCRUD<CataloguedItem>("items");

app.Run();