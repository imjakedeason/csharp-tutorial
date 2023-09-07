
namespace Program {
    class Product
    {
        public int ProductNumber { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public PaymentMethod? SelectedPaymentMethod { get; set; }
        public IDelivery? SelectedDeliveryMethod { get; set; }
    }
}