using System;
using System.Collections.Generic;

namespace MyApi.Models;

public partial class Appuser
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    public string? Address { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

    public float? Salary { get; set; }
}
