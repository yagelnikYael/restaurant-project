namespace restaurantProject.enties
{
    public class Order 
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public int TotalCost { get; set; }
    }
}
