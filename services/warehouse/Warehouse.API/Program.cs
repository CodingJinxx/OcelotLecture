using Microsoft.AspNetCore.Mvc;
using Warehouse.API;
using Warehouse.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository<Facility>, ARepository<Facility>>();
builder.Services.AddSingleton<IRepository<StockedItem>, ARepository<StockedItem>>();
builder.Services.AddSingleton<IRepository<Location>, ARepository<Location>>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Warehouse CRUD

app.MapCRUD<Facility>("facilities");
app.MapCRUD<StockedItem>("stockeditems");
app.MapCRUD<Location>("locations");

app.Run();