
namespace Program {
    class Product
    {
        public int ProductNumber { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public object SelectedPaymentMethod { get; internal set; }
    }
}