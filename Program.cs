using System;
using System.Data.SQLite;
using System.Windows.Forms;
using AnimalerieProjet;
using System.Runtime.InteropServices;

namespace Animalerie
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ***this line is added***
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            // Create or open the SQLite connection
            SQLiteConnection sqlite_conn = CreateConnection();

            // Create the Produits table if it does not exist
            CreateTable(sqlite_conn);
            // Create the CLients table if it does not exist
            CreateClientsTable(sqlite_conn);
            // Create the Commandes table if it does not exist
            CreateCommandesTable(sqlite_conn);
            // Close the SQLite connection after table creation
            sqlite_conn.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
        // ***also dllimport of that function***
        [DllImport("user32.dll", EntryPoint = "SetProcessDPIAware")]
        private static extern bool SetProcessDPIAware();
        // Method to create or open an SQLite connection
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            string connectionString = "Data Source=myDB.db; Version=3; New=True; Compress=True;";
            sqlite_conn = new SQLiteConnection(connectionString);

            try
            {
                sqlite_conn.Open();
                Console.WriteLine("Database connection established.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while opening the database: {ex.Message}");
            }

            return sqlite_conn;
        }

        // Method to create the Produits table
        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string createProduitsTable = @"
            CREATE TABLE IF NOT EXISTS Produits (
                prodId INTEGER PRIMARY KEY AUTOINCREMENT,
                prodName VARCHAR(50),
                prodDescription TEXT,
                prodPrixUnite DECIMAL(10, 2),
                prodQuantite INT
            )";

            try
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createProduitsTable;
                sqlite_cmd.ExecuteNonQuery();

                Console.WriteLine("Table Produits created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the table: {ex.Message}");
            }
        }

        // Method to create the Clients table
        static void CreateClientsTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string createClientsTable = @"
            CREATE TABLE IF NOT EXISTS Clients (
                clientId INTEGER PRIMARY KEY AUTOINCREMENT,
                clientName TEXT(50),
                clientPrenom TEXT(50),
                adresse TEXT(100)
            )";

            try
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createClientsTable;
                sqlite_cmd.ExecuteNonQuery();

                Console.WriteLine("Table Clients created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the table: {ex.Message}");
            }
        }


        // Method to create the Produits table
        static void CreateCommandesTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string createCommandesTable = @"
            CREATE TABLE IF NOT EXISTS Commandes (
                cmdId INTEGER PRIMARY KEY AUTOINCREMENT,
                quantiteCommandee INTEGER(4),
                livraison TEXT(20),
                prixTotal REAL(3,3) NOT NULL,
                clientId REFERENCES Clients (clientId) NOT NULL,
                prodId REFERENCES Produits (prodId) NOT NULL
            )";

            try
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createCommandesTable;
                sqlite_cmd.ExecuteNonQuery();

                Console.WriteLine("Table Commandes created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the table: {ex.Message}");
            }
        }
    }
}
