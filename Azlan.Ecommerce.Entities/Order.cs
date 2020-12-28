using System;
using System.Collections.Generic;
using System.Text;

namespace Azlan.Ecommerce.Entities
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public EnumOrderState OrderState { get; set; }
        public EnumPaymentTypes PaymentTypes { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderNote { get; set; }

        // For payment apis;
        public string PaymentId { get; set; }
        public string PaymentToken { get; set; }
        // for iyzico;
        public string ConversationId { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }

    public enum EnumOrderState
    {
        Processing=0,
        Shipped=1,
        Delivered=2
    }

    public enum EnumPaymentTypes
    {
        Eft=0,
        Cod=1,
        Gcash=2
    }
}
