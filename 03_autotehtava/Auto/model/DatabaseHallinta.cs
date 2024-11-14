using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
           yhteysTiedot =
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = Autokauppa;" +
                "Trusted_Connection = True;";
            dbYhteys = new SqlConnection();
        }

        public bool connectDatabase()
        {
            dbYhteys.ConnectionString = yhteysTiedot;
            
            try
            { 
                dbYhteys.Open();
                MessageBox.Show("Yhteys avattu");
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public bool testDatabaseConnection()
        {
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                return false;
            }
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;

            
        }
        public int? GetNextAvailableID(int currentID)
        {
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT TOP 1 ID FROM Auto WHERE ID > @currentID ORDER BY ID ASC";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@currentID", currentID);

                    object result = command.ExecuteScalar();
                    return result != null ? (int?)result : null;
                }
                else
                {
                    MessageBox.Show("Database connection is not open.");
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching the next available ID: " + e.Message);
                return null;
            }
        }

        public int? GetPreviousAvailableID(int currentID)
        {
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT TOP 1 ID FROM Auto WHERE ID < @currentID ORDER BY ID DESC";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@currentID", currentID);

                    object result = command.ExecuteScalar();
                    return result != null ? (int?)result : null;
                }
                else
                {
                    MessageBox.Show("Database connection is not open.");
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching the previous available ID: " + e.Message);
                return null;
            }
        }

        public Auto GetAutoByID(int id)
        {
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT * FROM Auto WHERE ID = @id";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Auto auto = new Auto
                        {
                            ID = (int)reader["ID"],
                            Hinta = (decimal)reader["Hinta"],
                            Rekisteri_paivamaara = (DateTime)reader["Rekisteri_paivamaara"],
                            Moottorin_tilavuus = (decimal)reader["Moottorin_tilavuus"],
                            Mittarilukema = (int)reader["Mittarilukema"],
                            AutonMerkkiID = (int)reader["AutonMerkkiID"],
                            AutonMalliID = (int)reader["AutonMalliID"],
                            VaritID = (int)reader["VaritID"],
                            PolttoaineID = (int)reader["PolttoaineID"]
                        };
                        reader.Close();
                        return auto;
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching auto details: " + e.Message);
            }
            return null;
        }
        public List<object> getAllAutoMakersFromDatabase()
        {
            List<object> palaute=null;
            return palaute;

        }

        public List<object> getAutoModelsByMakerId(int makerId) 
             
        {
            List<object> palaute = null;
            return palaute;
        }

    }
}
