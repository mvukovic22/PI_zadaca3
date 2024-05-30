using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusZaPlus.Models
{
    public abstract class VozneLinije : object
    {
        public int ID_linije { get; set; }
        public int ID_stanice { get; set; }

        public int ID_vozila { get; set; }
        public TimeSpan Termin_Odlaska { get; set; }
        public TimeSpan Termin_Dolaska { get; set; }
        public string Opis { get; set; }

    }

    public class Zaposlenik : VozneLinije
    { 
        public int ID_zaposlenik { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
