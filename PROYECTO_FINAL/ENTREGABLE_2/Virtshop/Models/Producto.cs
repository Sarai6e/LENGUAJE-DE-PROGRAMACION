// Producto.cs
using System;

public class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string SKU { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int CantidadStock { get; set; }
    public string UnidadMedida { get; set; }
    public DateTime? FechaVencimiento { get; set; }
}

// Proveedor.cs
public class Proveedor
{
    public int IdProveedor { get; set; }
    public string NombreEmpresa { get; set; }
    public string NombreContacto { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }
    public string TerminosPago { get; set; }
}

// EntradaInventario.cs
public class EntradaInventario
{
    public int IdEntrada { get; set; }
    public int IdProducto { get; set; }
    public int CantidadRecibida { get; set; }
    public DateTime FechaHoraEntrada { get; set; }
    public int IdProveedor { get; set; }
    public string NumeroFactura { get; set; }
}

// SalidaInventario.cs
public class SalidaInventario
{
    public int IdSalida { get; set; }
    public int IdProducto { get; set; }
    public int CantidadRetirada { get; set; }
    public DateTime FechaHoraSalida { get; set; }
    public string MotivoSalida { get; set; }
    public int? IdCliente { get; set; }
    public string NumeroFactura { get; set; }
}

// MovimientoInventario.cs
public class MovimientoInventario
{
    public int IdMovimiento { get; set; }
    public string TipoMovimiento { get; set; }
    public int IdProducto { get; set; }
    public int CantidadMovida { get; set; }
    public DateTime FechaHoraMovimiento { get; set; }
    public int? IdOrigen { get; set; }
    public int? IdDestino { get; set; }
}
