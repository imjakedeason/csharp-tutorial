namespace Program {
    interface IDelivery
    {
        string Name { get; }
    }

    class PickupDelivery : IDelivery
    {
        public string Name => "Pickup Delivery";
    }

    class PostDelivery : IDelivery
    {
        public string Name => "Post Delivery";
    }

    class CourierDelivery : IDelivery
    {
        public string Name => "Courier Delivery";
    }
}