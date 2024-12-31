using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalerieProjet.components
{
    public partial class Clients : Form
    {
        // Calling connectionString to access the DB 
        private string connectionString = "Data Source=myDB.db; Version=3;";
        public Clients()
        {
            InitializeComponent();
        }

        // insert client method
        private void insertBtn_Click(object sender, EventArgs e)
        {
            string clientName = txtclientNom.Text;
            string clientPrenom = txtclientPrenom.Text;
            string adresse = txtadresse.Text;

            string query = "INSERT INTO Clients (clientName, clientPrenom, adresse) " +
                           "VALUES (@clientName, @clientPrenom, @adresse)";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@clientName", clientName);
                        cmd.Parameters.AddWithValue("@clientPrenom", clientPrenom);
                        cmd.Parameters.AddWithValue("@adresse", adresse);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Client Inserted Successfully");
                    ClientsData(); // Ensure ProduitsData() refreshes your DataGrid or UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // update client method
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string clientName = txtclientNom.Text;
            string clientPrenom = txtclientPrenom.Text;
            string adresse = txtadresse.Text;
            // Assuming there is a TextBox for the Client ID
            int clientId = int.Parse(txtclientId.Text);

            string query = "UPDATE Clients SET clientName=@clientName, clientPrenom=@clientPrenom, adresse=@adresse WHERE clientId=@clientId";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@clientName", clientName);
                        cmd.Parameters.AddWithValue("@clientPrenom", clientPrenom);
                        cmd.Parameters.AddWithValue("@adresse", adresse);
                        cmd.Parameters.AddWithValue("@clientId", clientId); 

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Client Updated Successfully");
                    ClientsData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        // delete client method
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(txtclientId.Text);


            string query = "delete from Clients where clientId=@clientId";
            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Commande Deleted Successfully");
            ClientsData();
        }
        // show data inn grid 
        private void ClientsData()
        {
            string query = "SELECT * FROM Clients";

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
        //search field 
        private void txtSearchClt_TextChanged(object sender, EventArgs e)
        {
            SearchByName(txtSearchClt.Text);
        }

        //search method , by client name 
        private void SearchByName(string searchValue)
        {
            string query = "SELECT * FROM Clients WHERE clientPrenom LIKE @searchValue";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtclientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtclientNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
