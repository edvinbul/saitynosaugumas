namespace WebApplication1.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderNumber { get; set; }
        public int CarNumber { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }

        
    }
}
