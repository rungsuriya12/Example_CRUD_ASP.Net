using System;
using System.Collections.Generic;

namespace MyApi.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public decimal Price { get; set; }
}
