using Dtos.OrderDetails;

namespace Dtos.Order
{
    public class OrderDetailsDTO
    {
        public OrderDetailsDTO(int id, DateTime date, decimal total, string? status = null, IEnumerable<OrderDetialsMinimalDTO>? orderDetails = null)
        {
            Id = id;
            Date = date;
            Total = total;
            Status = status;
            OrderDetails = orderDetails;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string? Status { get; set; }


        public virtual IEnumerable<OrderDetialsMinimalDTO>? OrderDetails { get; set; }
        //public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        //relation with User

        //public virtual User User { get; set; }
        //relation with UserPaymetMethod

        // public virtual UserPaymetMethod UserPaymetMethod { get; set; }

        //relation with ShoppingMethod

        // public virtual ShoppingMethod ShoppingMethod { get; set; }





        //relation with Address
        // public virtual Address Address { get; set; }
    }
}
