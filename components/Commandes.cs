using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalerieProjet.components
{
    public partial class Commandes : Form
    {
        // Calling connectionString to access the DB 
        private string connectionString = "Data Source=myDB.db; Version=3;";
        public Commandes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtLivraison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // insert commande method
        private void insertBtn_Click(object sender, EventArgs e)
        {
            string qteCommandee = txtqteCommandee.Text;
            string livraison = txtLivraison.Text;
            string clientId = txtclientId.Text;
            string prodId = txtprodId.Text;
            string prixTot = txtPrixTot.Text;
            string query = "INSERT INTO Commandes (quantiteCommandee, livraison, clientId, prodId, prixTotal) " +
                           "VALUES (@qteCommandee, @livraison, @clientId, @prodId, @prixTot)";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@qteCommandee", qteCommandee);
                        cmd.Parameters.AddWithValue("@livraison", livraison);
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@prodId", prodId);
                        cmd.Parameters.AddWithValue("@prixTot", prixTot);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Commande Inserted Successfully");
                    CommandesData(); // Ensure ProduitsData() refreshes your DataGrid or UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // update commande method
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string qteCommandee = txtqteCommandee.Text;
            string livraison = txtLivraison.Text;
            string clientId = txtclientId.Text;
            string prodId = txtprodId.Text;
            string prixTot = txtPrixTot.Text;
            // Assuming there is a TextBox for the Client ID
            int cmdId = int.Parse(txtcmdId.Text);

            string query = "UPDATE Commandes SET quantiteCommandee=@qteCommandee, livraison=@livraison, clientId=@clientId,prodId=@prodId, prixTotal=@prixTot  WHERE cmdId=@cmdId";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@qteCommandee", qteCommandee);
                        cmd.Parameters.AddWithValue("@livraison", livraison);
                        cmd.Parameters.AddWithValue("@clientId", clientId);
                        cmd.Parameters.AddWithValue("@prodId", prodId);
                        cmd.Parameters.AddWithValue("@prixTot", prixTot);
                        cmd.Parameters.AddWithValue("@cmdId", cmdId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Commande Updated Successfully");
                    CommandesData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // delete commande method
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int cmdId = int.Parse(txtcmdId.Text);


            string query = "delete from Commandes where cmdId=@cmdId";
            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@cmdId", cmdId);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Commande Deleted Successfully");
            CommandesData();
        }

        // show data in grid 
        private void CommandesData()
        {
            string query = "SELECT * FROM Commandes";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=myDB.db;Version=3;"))
            {
                try
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // search field 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchByName(txtSearch.Text);
        }
        //search method , by commande id 
        private void SearchByName(string searchValue)
        {
            string query = "SELECT * FROM Commandes WHERE cmdId LIKE @searchValue";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        // Add a parameter with a wildcard for partial matches
                        cmd.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Commandes_Load(object sender, EventArgs e)
        {

        }
    }
}
