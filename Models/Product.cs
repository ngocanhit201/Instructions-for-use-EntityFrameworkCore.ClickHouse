using System;
using System.Collections.Generic;

namespace GenerateEntity.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }
}
