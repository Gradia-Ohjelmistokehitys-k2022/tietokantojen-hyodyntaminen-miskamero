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
                FillComboboxes();
            }
            else
            {
                MessageBox.Show("Yhteys tietokantaan ei toimi");
            }
        }

        private void FillComboboxes()
        {
            // Fill the comboboxes with data
            cbMerkki.DataSource = dbHallinta.getAllAutoMakersFromDatabase();
            cbMalli.DataSource = dbHallinta.getAutoModelsByMakerId(1);
            cbMerkki.SelectedIndexChanged += new EventHandler(cbMerkki_SelectedIndexChanged);
        }

        private void cbMerkki_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the current cbMerkki selected string value, query that from the table AutonMerkki and find the ID
            // then use that ID to get the models from the table AutonMalli
            // all in this method
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

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(tbId.Text);

            // Find the next available ID
            int? nextID = dbHallinta.GetNextAvailableID(currentID);
            if (nextID.HasValue)
            {
                tbId.Text = nextID.ToString();

                // Get the Auto object with the new ID and display it
                Auto auto = dbHallinta.GetAutoByID(nextID.Value);
                if (auto != null)
                {
                    cbMerkki.Text = auto.AutonMerkkiID.ToString();
                    cbMalli.Text = auto.AutonMalliID.ToString();
                    cbVari.Text = auto.VaritID.ToString();
                    cbPolttoaine.Text = auto.PolttoaineID.ToString();
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

        private void btnEdellinen_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(tbId.Text);

            // Find the previous available ID
            int? previousID = dbHallinta.GetPreviousAvailableID(currentID);
            if (previousID.HasValue)
            {
                tbId.Text = previousID.ToString();

                // Get the Auto object with the previous ID and display it
                Auto auto = dbHallinta.GetAutoByID(previousID.Value);
                if (auto != null)
                {
                    cbMerkki.Text = auto.AutonMerkkiID.ToString();
                    cbMalli.Text = auto.AutonMalliID.ToString();
                    cbVari.Text = auto.VaritID.ToString();
                    cbPolttoaine.Text = auto.PolttoaineID.ToString();
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
                MessageBox.Show("No lower ID available.");
            }
        }

    }
}
