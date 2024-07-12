using System;
using System.Data.SQLite;
using System.Windows.Forms;
using HikariLFSTemplate.Models;
namespace HikariLFSTemplate.Admin
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Data Source=relations.db;Version=3;";

        public AdminForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadRelations();
        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "CREATE TABLE IF NOT EXISTS Relations (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Barcode TEXT, Size TEXT)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            string name = txtRelationName.Text;
            string barcode = txtBarcode.Text;
            string size = txtSize.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(barcode) && !string.IsNullOrEmpty(size))
            {
                AddRelationToDatabase(name, barcode, size);
                LoadRelations();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }

        private void btnEditRelation_Click(object sender, EventArgs e)
        {
            if (lstRelations.SelectedItem != null)
            {
                Relation selectedRelation = (Relation)lstRelations.SelectedItem;
                selectedRelation.Name = txtRelationName.Text;
                selectedRelation.Barcode = txtBarcode.Text;
                selectedRelation.Size = txtSize.Text;
                UpdateRelationInDatabase(selectedRelation);
                LoadRelations();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Lagerplatz aus der Liste aus.");
            }
        }

        private void btnDeleteRelation_Click(object sender, EventArgs e)
        {
            if (lstRelations.SelectedItem != null)
            {
                Relation selectedRelation = (Relation)lstRelations.SelectedItem;
                DeleteRelationFromDatabase(selectedRelation.Id);
                LoadRelations();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Lagerplatz aus der Liste aus.");
            }
        }

        private void lstRelations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRelations.SelectedItem != null)
            {
                Relation selectedRelation = (Relation)lstRelations.SelectedItem;
                txtRelationName.Text = selectedRelation.Name;
                txtBarcode.Text = selectedRelation.Barcode;
                txtSize.Text = selectedRelation.Size;
            }
        }

        private void LoadRelations()
        {
            lstRelations.Items.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Id, Name, Barcode, Size FROM Relations";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Relation relation = new Relation(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    lstRelations.Items.Add(relation);
                }
            }
        }

        private void AddRelationToDatabase(string name, string barcode, string size)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Relations (Name, Barcode, Size) VALUES (@Name, @Barcode, @Size)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Size", size);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdateRelationInDatabase(Relation relation)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Relations SET Name = @Name, Barcode = @Barcode, Size = @Size WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", relation.Name);
                command.Parameters.AddWithValue("@Barcode", relation.Barcode);
                command.Parameters.AddWithValue("@Size", relation.Size);
                command.Parameters.AddWithValue("@Id", relation.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void DeleteRelationFromDatabase(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "DELETE FROM Relations WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void ClearInputFields()
        {
            txtRelationName.Clear();
            txtBarcode.Clear();
            txtSize.Clear();
        }
    }

 
}
