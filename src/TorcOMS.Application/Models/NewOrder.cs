namespace TorcOMS.Application.Models
{
    public class NewOrder
    {
        public long CustomerId { get; set; }
        public long ProductId { get; set; }
        public int ProductQty { get; set; }
    }
}
