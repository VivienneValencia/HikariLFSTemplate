using System;
using System.Data.SQLite;
using System.Windows.Forms;
using HikariLFSTemplate.Models;

namespace HikariLFSTemplate
{
    public partial class AuftragsverwaltungForm : Form
    {
        private string connectionString = "Data Source=relations.db;Version=3;"; // Gleiche Datenbankdatei

        public AuftragsverwaltungForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadOrders();
            LoadRelations();  // Neue Methode zum Laden der Relationen
        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "CREATE TABLE IF NOT EXISTS Orders (Id INTEGER PRIMARY KEY AUTOINCREMENT, OrderType TEXT, OrderDetails TEXT, RelationId INTEGER)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        private void LoadRelations()
        {
            cmbRelation.Items.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM Relations";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Relation relation = new Relation(reader.GetInt32(0), reader.GetString(1), "", "", "", "");
                    cmbRelation.Items.Add(relation);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string orderType = cmbOrderType.SelectedItem?.ToString();
            string orderDetails = txtOrderDetails.Text;
            Relation selectedRelation = (Relation)cmbRelation.SelectedItem;  // Ausgewählte Relation

            if (!string.IsNullOrEmpty(orderType) && !string.IsNullOrEmpty(orderDetails) && selectedRelation != null)
            {
                AddOrderToDatabase(orderType, orderDetails, selectedRelation.Id);
                LoadOrders();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }

        private void AddOrderToDatabase(string orderType, string orderDetails, int relationId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Orders (OrderType, OrderDetails, RelationId) VALUES (@OrderType, @OrderDetails, @RelationId)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@OrderType", orderType);
                command.Parameters.AddWithValue("@OrderDetails", orderDetails);
                command.Parameters.AddWithValue("@RelationId", relationId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void LoadOrders()
        {
            lstOrders.Items.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Id, OrderType, OrderDetails, RelationId FROM Orders";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int relationId = reader.GetInt32(3);
                    string relationName = GetRelationNameById(relationId);
                    Order order = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), relationName);
                    lstOrders.Items.Add(order);
                }
            }
        }

        private string GetRelationNameById(int relationId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Name FROM Relations WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", relationId);
                connection.Open();
                return command.ExecuteScalar()?.ToString();
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                Order selectedOrder = (Order)lstOrders.SelectedItem;
                selectedOrder.OrderType = cmbOrderType.SelectedItem?.ToString();
                selectedOrder.OrderDetails = txtOrderDetails.Text;
                selectedOrder.RelationName = ((Relation)cmbRelation.SelectedItem).Name;
                UpdateOrderInDatabase(selectedOrder);
                LoadOrders();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Auftrag aus der Liste aus.");
            }
        }

        private void UpdateOrderInDatabase(Order order)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Orders SET OrderType = @OrderType, OrderDetails = @OrderDetails, RelationId = @RelationId WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@OrderType", order.OrderType);
                command.Parameters.AddWithValue("@OrderDetails", order.OrderDetails);
                command.Parameters.AddWithValue("@RelationId", GetRelationIdByName(order.RelationName));
                command.Parameters.AddWithValue("@Id", order.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private int GetRelationIdByName(string relationName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT Id FROM Relations WHERE Name = @Name";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", relationName);
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                Order selectedOrder = (Order)lstOrders.SelectedItem;
                DeleteOrderFromDatabase(selectedOrder.Id);
                LoadOrders();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Auftrag aus der Liste aus.");
            }
        }

        private void DeleteOrderFromDatabase(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "DELETE FROM Orders WHERE Id = @Id";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void ClearInputFields()
        {
            cmbOrderType.SelectedIndex = -1;
            txtOrderDetails.Clear();
            cmbRelation.SelectedIndex = -1;
        }

        private void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                Order selectedOrder = (Order)lstOrders.SelectedItem;
                cmbOrderType.SelectedItem = selectedOrder.OrderType;
                txtOrderDetails.Text = selectedOrder.OrderDetails;
                cmbRelation.SelectedItem = selectedOrder.RelationName;
            }
        }
    }

    public class Order
    {
        public int Id { get; private set; }
        public string OrderType { get; set; }
        public string OrderDetails { get; set; }
        public string RelationName { get; set; }

        public Order(int id, string orderType, string orderDetails, string relationName)
        {
            Id = id;
            OrderType = orderType;
            OrderDetails = orderDetails;
            RelationName = relationName;
        }

        public override string ToString()
        {
            return $"{OrderType} - {OrderDetails} - {RelationName}";
        }
    }
}
