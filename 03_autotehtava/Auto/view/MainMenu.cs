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
            }
            else
            {
                MessageBox.Show("Yhteys tietokantaan ei toimi");
            }
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
                    //tbHinta.Text = auto.Hinta.ToString();
                    //tbRekisteriPaivamaara.Text = auto.Rekisteri_paivamaara.ToString("yyyy-MM-dd");
                    //tbMoottorinTilavuus.Text = auto.Moottorin_tilavuus.ToString();
                    //tbMittarilukema.Text = auto.Mittarilukema.ToString();

                    cbMerkki.Text = auto.AutonMerkkiID.ToString();
                    cbMalli.Text = auto.AutonMalliID.ToString();
                    cbVari.Text = auto.VaritID.ToString();
                    cbPolttoaine.Text = auto.PolttoaineID.ToString();
                    tbHinta.Text = auto.Hinta.ToString();
                    tbTilavuus.Text = auto.Moottorin_tilavuus.ToString();
                    tbMittarilukema.Text = auto.Mittarilukema.ToString();
                    dtpPaiva.Text = auto.Rekisteri_paivamaara.ToString("yyyy-MM-dd");

                    // Set other textboxes as needed
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
    }
}
