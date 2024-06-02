using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusZaPlus.Models
{
    public class Linija
    {
        public int ID_linije { get; set; }
        public int ID_stanice_polazak { get; set; }
        public int ID_stanice_dolazak { get; set; }
        public int ID_vozila { get; set; }
        public TimeSpan Termin_dolaska { get; set; }
        public string Opis { get; set; }
    }
}
