namespace Program {
    interface IDelivery
    {
        string Name { get; }
    }

    class PickupDelivery : IDelivery
    {
        public string Name => "Osobno preuzimanje";
    }

    class PostDelivery : IDelivery
    {
        public string Name => "Dostava poštom";
    }

    class CourierDelivery : IDelivery
    {
        public string Name => "Dostava kurirskom službom";
    }
}