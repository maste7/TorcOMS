namespace TorcOMS.Domain.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long ProductId { get; set; }
        public int ProductQty { get; set; }
        public decimal TotalCost { get; set; }

    }
}
