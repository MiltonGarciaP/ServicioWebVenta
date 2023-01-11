using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
