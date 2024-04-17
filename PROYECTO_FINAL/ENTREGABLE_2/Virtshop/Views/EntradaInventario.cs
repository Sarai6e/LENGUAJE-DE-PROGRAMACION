using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class EntradaInventario
{
    public int Id { get; set; }
    public int IdProducto { get; set; }
    public int CantidadRecibida { get; set; }
    public DateTime FechaHoraEntrada { get; set; }
    public int IdProveedor { get; set; }
    public string NumeroFactura { get; set; }
}

public class EntradaInventarioDAL
{
    private readonly string connectionString = "Your_Connection_String";

    public List<EntradaInventario> ObtenerEntradas()
    {
        List<EntradaInventario> entradas = new List<EntradaInventario>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Entradas";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                EntradaInventario entrada = new EntradaInventario
                {
                    Id = Convert.ToInt32(reader["IdEntrada"]),
                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                    CantidadRecibida = Convert.ToInt32(reader["CantidadRecibida"]),
                    FechaHoraEntrada = Convert.ToDateTime(reader["FechaHoraEntrada"]),
                    IdProveedor = Convert.ToInt32(reader["IdProveedor"]),
                    NumeroFactura = Convert.ToString(reader["NumeroFactura"])
                };
                entradas.Add(entrada);
            }

            reader.Close();
        }

        return entradas;
    }

    // Implementa métodos similares para buscar, filtrar y paginar las entradas de inventario según sea necesario
}

// En tu controlador de ASP.NET MVC o en otro lugar de tu aplicación web, puedes usar estas funciones de la siguiente manera:

public class EntradaInventarioController : Controller
{
    private readonly EntradaInventarioDAL entradaInventarioDAL = new EntradaInventarioDAL();

    public ActionResult Index()
    {
        List<EntradaInventario> entradas = entradaInventarioDAL.ObtenerEntradas();
        return View(entradas);
    }

    // Implementa acciones adicionales según sea necesario, como buscar, filtrar y paginar las entradas de inventario
}
