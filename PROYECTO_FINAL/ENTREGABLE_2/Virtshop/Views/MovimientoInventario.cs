using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class MovimientoInventario
{
    public int Id { get; set; }
    public string TipoMovimiento { get; set; }
    public int IdProducto { get; set; }
    public int CantidadMovida { get; set; }
    public DateTime FechaHoraMovimiento { get; set; }
    public int? IdOrigen { get; set; }
    public int? IdDestino { get; set; }
}

public class MovimientoInventarioDAL
{
    private readonly string connectionString = "Your_Connection_String";

    public List<MovimientoInventario> ObtenerMovimientos()
    {
        List<MovimientoInventario> movimientos = new List<MovimientoInventario>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Movimientos";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MovimientoInventario movimiento = new MovimientoInventario
                {
                    Id = Convert.ToInt32(reader["IdMovimiento"]),
                    TipoMovimiento = Convert.ToString(reader["TipoMovimiento"]),
                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                    CantidadMovida = Convert.ToInt32(reader["CantidadMovida"]),
                    FechaHoraMovimiento = Convert.ToDateTime(reader["FechaHoraMovimiento"]),
                    IdOrigen = reader["IdOrigen"] as int?,
                    IdDestino = reader["IdDestino"] as int?
                };
                movimientos.Add(movimiento);
            }

            reader.Close();
        }

        return movimientos;
    }

    // Implementa métodos similares para buscar, filtrar y paginar los movimientos de inventario según sea necesario
}

// En tu controlador de ASP.NET MVC o en otro lugar de tu aplicación web, puedes usar estas funciones de la siguiente manera:

public class MovimientoInventarioController : Controller
{
    private readonly MovimientoInventarioDAL movimientoInventarioDAL = new MovimientoInventarioDAL();

    public ActionResult Index()
    {
        List<MovimientoInventario> movimientos = movimientoInventarioDAL.ObtenerMovimientos();
        return View(movimientos);
    }

    // Implementa acciones adicionales según sea necesario, como buscar, filtrar y paginar los movimientos de inventario
}
