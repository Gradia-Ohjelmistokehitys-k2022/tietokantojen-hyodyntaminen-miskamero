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
            //dbHallinta.saveAutoIntoDatabase(new Auto
            //{
            //    AutonMerkkiID = int.Parse(cbMerkki.Text),
            //    AutonMalliID = int.Parse(cbMalli.Text),
            //    VaritID = int.Parse(cbVari.Text),
            //    PolttoaineID = int.Parse(cbPolttoaine.Text),
            //    Hinta = decimal.Parse(tbHinta.Text),
            //    Moottorin_tilavuus = decimal.Parse(tbTilavuus.Text),
            //    Mittarilukema = int.Parse(tbMittarilukema.Text),
            //    Rekisteri_paivamaara = DateTime.Parse(dtpPaiva.Text)
            //});
            // let's create a new auto into the db using Auto.cs
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO Auto (Hinta, Rekisteri_paivamaara, Moottorin_tilavuus, Mittarilukema, AutonMerkkiID, AutonMalliID, VaritID, PolttoaineID) " +
                        "VALUES (@Hinta, @Rekisteri_paivamaara, @Moottorin_tilavuus, @Mittarilukema, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID)";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@Hinta", newAuto.Hinta);
                    command.Parameters.AddWithValue("@Rekisteri_paivamaara", newAuto.Rekisteri_paivamaara);
                    command.Parameters.AddWithValue("@Moottorin_tilavuus", newAuto.Moottorin_tilavuus);
                    command.Parameters.AddWithValue("@Mittarilukema", newAuto.Mittarilukema);
                    command.Parameters.AddWithValue("@AutonMerkkiID", newAuto.AutonMerkkiID);
                    command.Parameters.AddWithValue("@AutonMalliID", newAuto.AutonMalliID);
                    command.Parameters.AddWithValue("@VaritID", newAuto.VaritID);
                    command.Parameters.AddWithValue("@PolttoaineID", newAuto.PolttoaineID);

                    command.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    MessageBox.Show("Database connection is not open.");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving auto into database: " + e.Message);
                return false;
            }

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
            List<string> makers = new List<string>();
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Merkki FROM AutonMerkki";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        makers.Add(reader["Merkki"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching auto makers: " + e.Message);
            }
            return makers.Cast<object>().ToList();
        }

        public List<string> getAutoModelsByMakerId(int makerId)
        {
            // Filter to only list the current maker's models
            List<string> models = new List<string>();
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT Auton_mallin_nimi FROM AutonMallit WHERE AutonMerkkiID = @makerId";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@makerId", makerId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Add the model name to the list
                        models.Add(reader["Auton_mallin_nimi"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching auto models: " + e.Message);
            }
            return models;
        }

        public int getAutoMakerID(string maker)
        {
            try
            {
                if (dbYhteys.State == System.Data.ConnectionState.Open)
                {
                    string query = "SELECT ID FROM AutonMerkki WHERE Merkki = @maker";
                    SqlCommand command = new SqlCommand(query, dbYhteys);
                    command.Parameters.AddWithValue("@maker", maker);
                    object result = command.ExecuteScalar();
                    return result != null ? (int)result : -1;
                }
                else
                {
                    MessageBox.Show("Database connection is not open.");
                    return -1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error fetching auto maker ID: " + e.Message);
                return -1;
            }
        }
    }
}
