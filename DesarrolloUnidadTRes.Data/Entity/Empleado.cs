//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesarrolloUnidadTRes.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int id { get; set; }
        public int idCatEmpleado { get; set; }
        public string strNombre { get; set; }
        public string strApPaterno { get; set; }
        public string strApMaterno { get; set; }
        public Nullable<System.DateTime> dteFechaContratacion { get; set; }
        public int idCatCede { get; set; }
        public int idCatSexo { get; set; }
        public int idCatStatus { get; set; }
        public int idCatPuesto { get; set; }
        public Nullable<bool> boolCapacitaciones { get; set; }
        public Nullable<bool> boolAntescedentes { get; set; }
        public Nullable<bool> boolINE { get; set; }
        public Nullable<bool> boolCurp { get; set; }
        public Nullable<bool> boolLicencia { get; set; }
        public int idCatLicencia { get; set; }
    
        public virtual EmpCatCede EmpCatCede { get; set; }
        public virtual EmpCatEmpleado EmpCatEmpleado { get; set; }
        public virtual EmpCatLicencia EmpCatLicencia { get; set; }
        public virtual EmpCatPuesto EmpCatPuesto { get; set; }
        public virtual EmpCatSexo EmpCatSexo { get; set; }
        public virtual EmpCatStatus EmpCatStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
