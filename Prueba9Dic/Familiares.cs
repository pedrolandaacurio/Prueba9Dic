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
    
    public partial class Familiares
    {
        public int Id_Familiar { get; set; }
        public string Familiar { get; set; }
        public Nullable<int> Id_Victima { get; set; }
    
        public virtual Victimas Victimas { get; set; }
    }
}
