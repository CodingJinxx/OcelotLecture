﻿using Warehouse.API;

namespace Item.Model;

public class CataloguedItem : IEntity
{
    public int Id { get; set; }
    public string Identitifer { get; set; }
    public string Description { get; set; }
}