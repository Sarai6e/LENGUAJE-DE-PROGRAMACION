using System;

namespace Usuarios.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Cargo { get; set; }
        public string NumeroCelular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
    }
}
