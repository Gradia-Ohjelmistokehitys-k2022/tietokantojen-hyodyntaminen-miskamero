using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Autokauppa.model;
using Autokauppa.controller;


namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        private DatabaseHallinta dbHallinta;

        // KaupanLogiikka registerHandler;

        public MainMenu()
        {
            //registerHandler = new KaupanLogiikka();
            InitializeComponent();
            dbHallinta = new DatabaseHallinta();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            bool isConnected = dbHallinta.connectDatabase();
            if (isConnected)
            {
                MessageBox.Show("Yhteys tietokantaan toimii");
                // Fill the comboboxes with data
                FillComboboxSelections();
            }
            else
            {
                MessageBox.Show("Yhteys tietokantaan ei toimi");
            }
        }

        private void FillComboboxSelections()
        {
            // Fill the comboboxes with data
            cbMerkki.DataSource = dbHallinta.getAllAutoMakersFromDatabase();
            cbMalli.DataSource = dbHallinta.getAutoModelsByMakerId(1);
            cbMerkki.SelectedIndexChanged += new EventHandler(cbMerkki_SelectedIndexChanged);
            cbVari.DataSource = dbHallinta.getAllColorsFromDatabase();
            cbPolttoaine.DataSource = dbHallinta.getAllFuelsFromDatabase();
        }

        private void cbMerkki_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the current cbMerkki selected string value, query that from the table AutonMerkki and find the ID
            // then use that ID to get the models from the table AutonMalli
            string selectedMerkki = cbMerkki.Text;
            int makerID = dbHallinta.getAutoMakerID(selectedMerkki);
            cbMalli.DataSource = dbHallinta.getAutoModelsByMakerId(makerID);
        }

        private void testaaTietokantaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isConnected = dbHallinta.testDatabaseConnection();
            if (isConnected)
            {
                MessageBox.Show("Yhteys tietokantaan toimii");
            }
            else
            {
                MessageBox.Show("Yhteys tietokantaan ei toimi");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // disconnectDatabase
            dbHallinta.disconnectDatabase();
            Application.Exit();
        }
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            // allinta.saveAutoIntoDatabase(cbMerkki.Text, cbMalli.Text, cbVari.Text, cbPolttoaine.Text, tbHinta.Text, tbTilavuus.Text, tbMittarilukema.Text, dtpPaiva.Text);
            // public bool saveAutoIntoDatabase(Auto newAuto)
            dbHallinta.saveAutoIntoDatabase(new Auto
            {
                AutonMerkkiID = int.Parse(cbMerkki.Text),
                AutonMalliID = int.Parse(cbMalli.Text),
                VaritID = int.Parse(cbVari.Text),
                PolttoaineID = int.Parse(cbPolttoaine.Text),
                Hinta = decimal.Parse(tbHinta.Text),
                Moottorin_tilavuus = decimal.Parse(tbTilavuus.Text),
                Mittarilukema = int.Parse(tbMittarilukema.Text),
                Rekisteri_paivamaara = DateTime.Parse(dtpPaiva.Text)
            });
        }



        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentPrice = decimal.Parse(tbHinta.Text);
                int currentID = int.Parse(tbId.Text);

                int? nextCarID = dbHallinta.GetNextLowestByPrice(currentPrice, currentID);
                if (nextCarID.HasValue)
                {
                    tbId.Text = nextCarID.ToString();

                    Auto auto = dbHallinta.GetAutoByID(nextCarID.Value);
                    if (auto != null)
                    {
                        cbMerkki.Text = dbHallinta.getAutoMakerNameFromID(auto.AutonMerkkiID);
                        cbMalli.Text = dbHallinta.getAutoModelNameFromID(auto.AutonMalliID);
                        cbVari.Text = dbHallinta.getColorNameFromID(auto.VaritID);
                        cbPolttoaine.Text = dbHallinta.getFuelNameFromID(auto.PolttoaineID);
                        tbHinta.Text = auto.Hinta.ToString();
                        tbTilavuus.Text = auto.Moottorin_tilavuus.ToString();
                        tbMittarilukema.Text = auto.Mittarilukema.ToString();
                        dtpPaiva.Text = auto.Rekisteri_paivamaara.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("Auto with the specified ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("No higher ID available.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid price format.");
            }
        }

        private void btnEdellinen_Click(object sender, EventArgs e)
        {
            try
            {
                decimal currentPrice = decimal.Parse(tbHinta.Text);
                int currentID = int.Parse(tbId.Text);

                int? previousCarID = dbHallinta.GetPreviousLowestByPrice(currentPrice, currentID);
                if (previousCarID.HasValue)
                {
                    tbId.Text = previousCarID.ToString();

                    Auto auto = dbHallinta.GetAutoByID(previousCarID.Value);
                    if (auto != null)
                    {
                        cbMerkki.Text = dbHallinta.getAutoMakerNameFromID(auto.AutonMerkkiID);
                        cbMalli.Text = dbHallinta.getAutoModelNameFromID(auto.AutonMalliID);
                        cbVari.Text = dbHallinta.getColorNameFromID(auto.VaritID);
                        cbPolttoaine.Text = dbHallinta.getFuelNameFromID(auto.PolttoaineID);
                        tbHinta.Text = auto.Hinta.ToString();
                        tbTilavuus.Text = auto.Moottorin_tilavuus.ToString();
                        tbMittarilukema.Text = auto.Mittarilukema.ToString();
                        dtpPaiva.Text = auto.Rekisteri_paivamaara.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("Auto with the specified ID not found.");
                    }
                }
                else
                {
                    MessageBox.Show("No previous car available.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid price or ID format.");
            }
        }


    }
}
