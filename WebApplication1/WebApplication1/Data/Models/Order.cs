﻿namespace WebApplication1.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
