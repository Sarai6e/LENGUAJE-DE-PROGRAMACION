using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string SKU { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int CantidadStock { get; set; }
    public string UnidadMedida { get; set; }
    public DateTime? FechaVencimiento { get; set; }
}

public class ProductoDAL
{
    private readonly string connectionString = "Your_Connection_String";

    public List<Producto> ObtenerProductos()
    {
        List<Producto> productos = new List<Producto>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Productos";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(reader["IdProducto"]),
                    Nombre = Convert.ToString(reader["Nombre"]),
                    Descripcion = Convert.ToString(reader["Descripcion"]),
                    SKU = Convert.ToString(reader["SKU"]),
                    Categoria = Convert.ToString(reader["Categoria"]),
                    Precio = Convert.ToDecimal(reader["Precio"]),
                    CantidadStock = Convert.ToInt32(reader["CantidadStock"]),
                    UnidadMedida = Convert.ToString(reader["UnidadMedida"]),
                    FechaVencimiento = reader["FechaVencimiento"] as DateTime?
                };
                productos.Add(producto);
            }

            reader.Close();
        }

        return productos;
    }

    public List<Producto> BuscarProductos(string criterio)
    {
        // Implementa la lógica de búsqueda de productos según el criterio especificado
        // Puedes usar consultas SQL con parámetros o LINQ para filtrar los productos en función del criterio de búsqueda
    }

    public List<Producto> FiltrarProductos(string categoria)
    {
        // Implementa la lógica de filtrado de productos por categoría
        // Puedes usar consultas SQL con parámetros o LINQ para filtrar los productos por la categoría especificada
    }

    public List<Producto> ObtenerProductosPaginados(int pagina, int productosPorPagina)
    {
        // Implementa la lógica para obtener una página específica de productos según el número de página y la cantidad de productos por página
        // Puedes usar consultas SQL con OFFSET y FETCH o LINQ para realizar la paginación de los productos
    }
}

// En tu controlador de ASP.NET MVC o en otro lugar de tu aplicación web, puedes usar estas funciones de la siguiente manera:

public class ProductoController : Controller
{
    private readonly ProductoDAL productoDAL = new ProductoDAL();

    public ActionResult Index(int pagina = 1)
    {
        int productosPorPagina = 10; // Cantidad de productos a mostrar por página
        List<Producto> productos = productoDAL.ObtenerProductosPaginados(pagina, productosPorPagina);
        return View(productos);
    }

    [HttpPost]
    public ActionResult Buscar(string criterio)
    {
        List<Producto> productos = productoDAL.BuscarProductos(criterio);
        return View("Index", productos);
    }

    [HttpPost]
    public ActionResult Filtrar(string categoria)
    {
        List<Producto> productos = productoDAL.FiltrarProductos(categoria);
        return View("Index", productos);
    }
}
