namespace Program {
    abstract class PaymentMethod {
    public abstract void MakePayment(double amount);
    }

    class CreditCardPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            Console.WriteLine($"Plaćen iznos od {amount:C} karticom.");
        }
    }

    class CashPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            Console.WriteLine($"Plaćen iznos od {amount:C} u gotovini.");
        }
    }

    class CheckPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            Console.WriteLine($"Plaćen iznos od {amount:C} čekom.");
        }
    }
}