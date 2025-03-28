using System;
using System.Collections.Generic;

namespace GenerateEntity.Models;

public partial class User
{
    public uint Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Timestamp { get; set; }
}
