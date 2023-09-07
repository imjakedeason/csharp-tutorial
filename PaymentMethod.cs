
namespace Program {
    abstract class PaymentMethod
    {
        public abstract string Name { get; }
    }

    class CreditCardPayment : PaymentMethod
    {
        public override string Name => "Kreditna kartica";
    }

    class CashPayment : PaymentMethod
    {
        public override string Name => "Gotovina";
    }

    class CheckPayment : PaymentMethod
    {
        public override string Name => "Ček";
    }
}