using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloUnidadTRes.Data.Entity
{
    class Empleados
    {
        int IdEmpleado { get; set; }
        int IdCatEmpleado { get; set; }
        string Nombre { get; set; }
        string ApPaterno { get; set; }
        string ApMaterno { get; set; }
        DateTime FechaIngreso { get; set; }
        int IdCatCede { get; set; }
        int IdCatSexo { get; set; }
        int IdCatStatus { get; set; }
        int IdCatPuesto { get; set; }
        bool Capacitaciones { get; set; }
        bool Antescedentes { get; set; }
        bool INE { get; set; }
        bool Curp { get; set; }
        bool Licencia { get; set; }
        int IdCatLicencia { get; set; }
    }
}
