using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Price i Product tablosundan degil Cart tan alicazki zam gelmisse kullanici cart a ekledigi fiyattan alsin;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
