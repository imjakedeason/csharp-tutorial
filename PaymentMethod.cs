
namespace Program {
    abstract class PaymentMethod
    {
        public abstract string Name { get; }
    }

    class CreditCardPayment : PaymentMethod
    {
        public override string Name => "Credit Card";
    }

    class CashPayment : PaymentMethod
    {
        public override string Name => "Cash";
    }

    class CheckPayment : PaymentMethod
    {
        public override string Name => "Check";
    }
}