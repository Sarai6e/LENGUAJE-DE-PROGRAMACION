using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class Proveedor
{
    public int Id { get; set; }
    public string NombreEmpresa { get; set; }
    public string NombreContacto { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string CorreoElectronico { get; set; }
    public string TerminosPago { get; set; }
}

public class ProveedorDAL
{
    private readonly string connectionString = "Your_Connection_String";

    public List<Proveedor> ObtenerProveedores()
    {
        List<Proveedor> proveedores = new List<Proveedor>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Proveedores";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Proveedor proveedor = new Proveedor
                {
                    Id = Convert.ToInt32(reader["IdProveedor"]),
                    NombreEmpresa = Convert.ToString(reader["NombreEmpresa"]),
                    NombreContacto = Convert.ToString(reader["NombreContacto"]),
                    Direccion = Convert.ToString(reader["Direccion"]),
                    Telefono = Convert.ToString(reader["Telefono"]),
                    CorreoElectronico = Convert.ToString(reader["CorreoElectronico"]),
                    TerminosPago = Convert.ToString(reader["TerminosPago"])
                };
                proveedores.Add(proveedor);
            }

            reader.Close();
        }

        return proveedores;
    }

    public List<Proveedor> BuscarProveedores(string criterio)
    {
        // Implementa la lógica de búsqueda de proveedores según el criterio especificado
        // Puedes usar consultas SQL con parámetros o LINQ para filtrar los proveedores en función del criterio de búsqueda
    }

    public List<Proveedor> FiltrarProveedores(string terminosPago)
    {
        // Implementa la lógica de filtrado de proveedores por términos de pago
        // Puedes usar consultas SQL con parámetros o LINQ para filtrar los proveedores por los términos de pago especificados
    }

    public List<Proveedor> ObtenerProveedoresPaginados(int pagina, int proveedoresPorPagina)
    {
        // Implementa la lógica para obtener una página específica de proveedores según el número de página y la cantidad de proveedores por página
        // Puedes usar consultas SQL con OFFSET y FETCH o LINQ para realizar la paginación de los proveedores
    }
}

// En tu controlador de ASP.NET MVC o en otro lugar de tu aplicación web, puedes usar estas funciones de la siguiente manera:

public class ProveedorController : Controller
{
    private readonly ProveedorDAL proveedorDAL = new ProveedorDAL();

    public ActionResult Index(int pagina = 1)
    {
        int proveedoresPorPagina = 10; // Cantidad de proveedores a mostrar por página
        List<Proveedor> proveedores = proveedorDAL.ObtenerProveedoresPaginados(pagina, proveedoresPorPagina);
        return View(proveedores);
    }

    [HttpPost]
    public ActionResult Buscar(string criterio)
    {
        List<Proveedor> proveedores = proveedorDAL.BuscarProveedores(criterio);
        return View("Index", proveedores);
    }

    [HttpPost]
    public ActionResult Filtrar(string terminosPago)
    {
        List<Proveedor> proveedores = proveedorDAL.FiltrarProveedores(terminosPago);
        return View("Index", proveedores);
    }
}
