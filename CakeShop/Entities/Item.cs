using System;
using System.Collections.Generic;

namespace CakeShop.Entities;

public partial class Item
{
    public int Id { get; init; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? ImagePath { get; set; }

    public decimal? Price { get; set; }
}
