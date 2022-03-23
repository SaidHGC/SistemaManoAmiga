using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloUnidadTRes.Data.Entity
{
    class Usuarios
    {
        int IdUsuario { get; set; }
        int IdEmpleado { get; set; }
        string NombreUsuario { get; set; }
        string Password { get; set; }
    }
}
