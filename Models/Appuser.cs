using System;
using System.Collections.Generic;

namespace MyApi.Models;

public partial class Appuser
{ 
    
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string? Address { get; set; }

    public float? Salary { get; set; }
}
