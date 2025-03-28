using System;
using System.Collections.Generic;

namespace GenerateEntity.Models;

public partial class MyTable
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
