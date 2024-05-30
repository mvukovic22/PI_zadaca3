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

        /*public Linija(int id, string pocStanica, string zavrStanica, int brBus, string pocVrijeme, string zavrVrijeme)
        {
            ID_linije = id;
            PocetnaStanica = pocStanica;
            ZavrsnaStanica = zavrStanica;
            BrojAutobusa = brBus;
            PocetnoVrijeme = pocVrijeme;
            ZavrsnoVrijeme = zavrVrijeme;
        }*/
    }
}
