using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Concepto
{
    public long Id { get; set; }

    public long? IdVentas { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Importe { get; set; }

    public int? IdProducto { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Venta? IdVentasNavigation { get; set; }
}
