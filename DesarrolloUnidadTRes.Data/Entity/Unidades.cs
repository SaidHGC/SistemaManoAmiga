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
    
    public partial class Unidades
    {
        public int id { get; set; }
        public string straNoPlacas { get; set; }
        public string strModelo { get; set; }
        public string strMarca { get; set; }
        public int idCatTipoUnidad { get; set; }
        public int idCatEdoAgencia { get; set; }
        public int idCatAseguradora { get; set; }
        public int idCatDisponibilidad { get; set; }
    
        public virtual UniCatAgencia UniCatAgencia { get; set; }
        public virtual UniCatDisponibilidad UniCatDisponibilidad { get; set; }
        public virtual UniCatEdoAgencia UniCatEdoAgencia { get; set; }
        public virtual UniCatTipoUnidad UniCatTipoUnidad { get; set; }
    }
}
