namespace HikariLFSTemplate.Models
{

    public class Order
    {
        public int Id { get; private set; }
        public string OrderType { get; set; }
        public string OrderDetails { get; set; }

        public Order(int id, string orderType, string orderDetails)
        {
            Id = id;
            OrderType = orderType;
            OrderDetails = orderDetails;
        }

        public override string ToString()
        {
            return $"{OrderType} - {OrderDetails}";
        }
    }
}