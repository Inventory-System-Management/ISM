namespace ISM.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
        public double TotalAmount { get; set; }

        public int UserId { get; set; }

        public int OrderDetailId { get; set; }
        public Order_Detail? Order_Detail { get; set; }
    }
}
