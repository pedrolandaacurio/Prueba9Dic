//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba9Dic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Informantes
    {
        public int Id_Informante { get; set; }
        public string Nombres_Inf { get; set; }
        public string ApellidoPaterno_Inf { get; set; }
        public string ApellidoMaterno_Inf { get; set; }
        public Nullable<int> Id_Sitio { get; set; }
    
        public virtual Sitios Sitios { get; set; }
    }
}
