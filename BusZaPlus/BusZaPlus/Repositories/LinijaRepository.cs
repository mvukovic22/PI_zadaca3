using DBLayer;
using BusZaPlus.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusZaPlus.Repositories
{
    public class LinijaRepository
    {
        public static Linija GetLinija(int id)
        {
            Linija linija = null;

            string sql = $"SELECT * FROM VozneLinije WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                linija = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return linija;
        }

        public static List<Linija> GetLinije()
        {
            var linije = new List<Linija>();

            string sql = "SELECT * FROM VozneLinije";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Linija linija = CreateObject(reader);
                linije.Add(linija);
            }

            reader.Close();
            DB.CloseConnection();

            return linije;
        }

        private static Linija CreateObject(SqlDataReader reader)
        {
            int id_linije = int.Parse(reader["ID_linije"].ToString());
            int id_stanice_polazak = int.Parse(reader["ID_stanice_polazak"].ToString());
            int id_stanice_dolazak = int.Parse(reader["ID_stanice_dolazak"].ToString());
            int id_vozila = int.Parse(reader["ID_vozila"].ToString());
            TimeSpan termin_dolaska = (TimeSpan)reader["Termin_dolaska"];
            string opis = reader["Opis"].ToString();

            var linija = new Linija
            {
                ID_linije = id_linije,
                ID_stanice_polazak = id_stanice_polazak,
                ID_stanice_dolazak = id_stanice_dolazak,
                ID_vozila = id_vozila,
                Termin_dolaska = termin_dolaska,
                Opis = opis
            };

            return linija;
        }

        public static void UnosLinije(Linija linija)
        { 
            string sql = $"INSERT INTO dbo.VozneLinije (ID_linije, ID_stanice_dolazak, ID_stanice_polazak, ID_vozila, Termin_dolaska, Opis ) VALUES('{linija.ID_linije}','{linija.ID_stanice_dolazak}', '{linija.ID_stanice_polazak}', '{linija.ID_vozila}', '{linija.Termin_dolaska}', '{linija.Opis}')"; 
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /*public static void UpdateEvaluation(Linija linija)
        {
            string sql = $"UPDATE dbo.VozneLinije SET ID_linije = {linija.ID_linije}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }*/
    }
}
