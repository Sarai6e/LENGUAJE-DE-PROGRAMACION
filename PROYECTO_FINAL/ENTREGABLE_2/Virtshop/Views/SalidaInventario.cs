using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class SalidaInventario
{
    public int Id { get; set; }
    public int IdProducto { get; set; }
    public int CantidadRetirada { get; set; }
    public DateTime FechaHoraSalida { get; set; }
    public string MotivoSalida { get; set; }
    public int? IdCliente { get; set; }
    public string NumeroFactura { get; set; }
}

public class SalidaInventarioDAL
{
    private readonly string connectionString = "Your_Connection_String";

    public List<SalidaInventario> ObtenerSalidas()
    {
        List<SalidaInventario> salidas = new List<SalidaInventario>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Salidas";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                SalidaInventario salida = new SalidaInventario
                {
                    Id = Convert.ToInt32(reader["IdSalida"]),
                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                    CantidadRetirada = Convert.ToInt32(reader["CantidadRetirada"]),
                    FechaHoraSalida = Convert.ToDateTime(reader["FechaHoraSalida"]),
                    MotivoSalida = Convert.ToString(reader["MotivoSalida"]),
                    IdCliente = reader["IdCliente"] as int?,
                    NumeroFactura = Convert.ToString(reader["NumeroFactura"])
                };
                salidas.Add(salida);
            }

            reader.Close();
        }

        return salidas;
    }

    // Implementa métodos similares para buscar, filtrar y paginar las salidas de inventario según sea necesario
}

// En tu controlador de ASP.NET MVC o en otro lugar de tu aplicación web, puedes usar estas funciones de la siguiente manera:

public class SalidaInventarioController : Controller
{
    private readonly SalidaInventarioDAL salidaInventarioDAL = new SalidaInventarioDAL();

    public ActionResult Index()
    {
        List<SalidaInventario> salidas = salidaInventarioDAL.ObtenerSalidas();
        return View(salidas);
    }

    // Implementa acciones adicionales según sea necesario, como buscar, filtrar y paginar las salidas de inventario
}
