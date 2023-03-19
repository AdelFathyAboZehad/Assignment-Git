namespace Dtos.Order
{
    public class OrderMinimalDTO
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public OrderMinimalDTO(DateTime date, decimal total, string status)
        {
            Date = date;
            Total = total;
            Status = status;
        }

    }
}
