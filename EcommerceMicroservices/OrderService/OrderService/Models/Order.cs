﻿namespace OrderService.Models
{
    public class Order
    {   
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
    }
}
