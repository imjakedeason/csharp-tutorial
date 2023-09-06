namespace Program {
    abstract class PaymentMethod {
        protected const double VATRate = 0.20; // Vrijednost PDV-a
        public abstract void MakePayment(double amount);
    }

    class CreditCardPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            double vatCost = Math.Round(amount * VATRate, 2);
            double totalAmount = Math.Round(amount + vatCost, 2);
            Console.WriteLine($"Iznos bez PDV-a: {amount}");
            Console.WriteLine($"Iznos PDV-a: {vatCost}");
            Console.WriteLine($"Iznos sa PDV-om: {totalAmount}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Narudžba plaćena kreditnom karticom.");
            Console.WriteLine("-----------------------------------");
        }
    }

    class CashPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            double vatCost = Math.Round(amount * VATRate, 2);
            double totalAmount = Math.Round(amount + vatCost, 2);
            Console.WriteLine($"Iznos bez PDV-a: {amount}");
            Console.WriteLine($"Iznos PDV-a: {vatCost}");
            Console.WriteLine($"Iznos sa PDV-om: {totalAmount}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Narudžba plaćena gotovinom.");
            Console.WriteLine("-----------------------------------");
        }
    }

    class CheckPayment : PaymentMethod {
        public override void MakePayment(double amount) {
            double vatCost = Math.Round(amount * VATRate, 2);
            double totalAmount = Math.Round(amount + vatCost, 2);
            Console.WriteLine($"Iznos bez PDV-a: {amount}");
            Console.WriteLine($"Iznos PDV-a: {vatCost}");
            Console.WriteLine($"Iznos sa PDV-om: {totalAmount}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Narudžba plaćena čekom.");
            Console.WriteLine("-----------------------------------");
        }
    }

//     class CreditCardPayment : PaymentMethod {
//         public override void MakePayment(double amount) {
//             Console.WriteLine($"Plaćen iznos od {amount:C} karticom.");
//         }
//     }

//     class CashPayment : PaymentMethod {
//         public override void MakePayment(double amount) {
//             Console.WriteLine($"Plaćen iznos od {amount:C} u gotovini.");
//         }
//     }

//     class CheckPayment : PaymentMethod {
//         public override void MakePayment(double amount) {
//             Console.WriteLine($"Plaćen iznos od {amount:C} čekom.");
//         }
//     }
}