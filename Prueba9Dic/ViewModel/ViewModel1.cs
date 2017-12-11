using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba9Dic.ViewModel
{
    public class ViewModel1
    {
        public int Id_Sitio { get; set; }
        public string CodigoSitio { get; set; }
        public string Coord_X { get; set; }
        public string Coord_Y { get; set; }
        public Nullable<decimal> Altitud { get; set; }
        public Nullable<int> Propiedad { get; set; }
        public string Antecedentes { get; set; }
        public string RelatoAcontecimientos { get; set; }
        public Nullable<System.DateTime> FechaEvento { get; set; }
        public Nullable<System.DateTime> FechaInhumacion { get; set; }
        public Nullable<decimal> NumeroVictimas { get; set; }
        public Nullable<bool> ExhumacionAnterior { get; set; }
        public Nullable<bool> MaterialesAdicionales { get; set; }
        public List<Informantes> ListInformantes { get; set; }
        public List<Victimas> ListVictimas { get; set; }
        public List<Familiares> ListFamiliares { get; set; }
        public List<Testigos> ListTestigos { get; set; }
    }
}