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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalerieProjet.components
{
    public partial class Produits : Form
    {
        // Calling connectionString to access the DB 
        private string connectionString = "Data Source=myDB.db; Version=3;";
        public Produits()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Produits_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // insert btn method
        private void insertBtn_Click(object sender, EventArgs e)
        {
            string prodName = txtprodNom.Text;
            string prodPrixUnite = txtprixUnit.Text;
            string prodQuantite = txtQuantite.Text;
            string prodDescription = txtDescription.Text;

            string query = "INSERT INTO Produits (prodName, prodDescription, prodPrixUnite, prodQuantite) " +
                           "VALUES (@prodName, @prodDescription, @prodPrixUnite, @prodQuantite)";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@prodName", prodName);
                        cmd.Parameters.AddWithValue("@prodDescription", prodDescription);
                        cmd.Parameters.AddWithValue("@prodPrixUnite", prodPrixUnite);
                        cmd.Parameters.AddWithValue("@prodQuantite", prodQuantite);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Inserted Successfully");
                    ProduitsData(); // Ensure ProduitsData() refreshes your DataGrid or UI
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        
        //update btn method
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string prodName = txtprodNom.Text;
            string prodPrixUnite = txtprixUnit.Text;
            string prodQuantite = txtQuantite.Text;
            string prodDescription = txtDescription.Text;

            // Assuming there is a TextBox for the Product ID
            int prodId = int.Parse(txtprodId.Text); 

            string query = "UPDATE Produits SET prodName=@prodName, prodDescription=@prodDescription, prodPrixUnite=@prodPrixUnite, prodQuantite=@prodQuantite WHERE prodId=@prodId";

            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                try
                {
                    cnn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@prodName", prodName);
                        cmd.Parameters.AddWithValue("@prodDescription", prodDescription);
                        cmd.Parameters.AddWithValue("@prodPrixUnite", prodPrixUnite);
                        cmd.Parameters.AddWithValue("@prodQuantite", prodQuantite);
                        cmd.Parameters.AddWithValue("@prodId", prodId); // Add the prodId parameter

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Updated Successfully");
                    ProduitsData(); // Refresh data
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        //delete btn method
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int prodId = int.Parse(txtprodId.Text);


            string query = "delete from Produits where prodId=@prodId";
            using (SQLiteConnection cnn = new SQLiteConnection(connectionString))
            {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@prodId", prodId);
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Product Deleted Successfully");
            ProduitsData();
        }
        // show data in grid 
        private void ProduitsData()
        {
            string query = "SELECT * FROM Produits";

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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchByName(txtSearch.Text);
        }
        //search method , by product name 
        private void SearchByName(string searchValue)
        {
            string query = "SELECT * FROM Produits WHERE prodName LIKE @searchValue";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtprodId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtprodNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprixUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtquantitee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
