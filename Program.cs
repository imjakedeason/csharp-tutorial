using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Program {
    class Program
    {
        static List<Product> storeProducts = new List<Product>
        {
            new Product { ProductNumber = 1, Name = "Sušilo za kosu", Price = 10.80, Quantity = 14 },
            new Product { ProductNumber = 2, Name = "Mikrovalna", Price = 15.40, Quantity = 6 },
            new Product { ProductNumber = 3, Name = "Hladnjak", Price = 22.60, Quantity = 30 },
            new Product { ProductNumber = 4, Name = "Lampa za stol", Price = 5.10, Quantity = 14 }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Trgovina:");
                Console.WriteLine("1. Popis proizvoda");
                Console.WriteLine("2. Dodaj novi proizvod");
                Console.WriteLine("3. Kupi proizvod");
                Console.WriteLine("4. Izlaz iz aplikacije");

                int choice = GetChoice(1, 3);

                switch (choice)
                {
                    case 1:
                        ListAllProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        BuyProduct();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void ListAllProducts() // izlistaj proizvode
        {
            Console.WriteLine("Available Products:");
            foreach (var product in storeProducts)
            {
                Console.WriteLine($"{product.ProductNumber}. {product.Name} - ${product.Price} (Qty: {product.Quantity})");
            }
        }

        static void AddProduct() // dodaj proizvode
        {
            Console.WriteLine("\n***********************************");
            Console.Write("Unesite ime proizvoda: ");
            string name = Console.ReadLine();

            Console.WriteLine("\n***********************************");
            Console.Write("Unesite cijenu novog proizvoda: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("\n***********************************");
                Console.Write("Unesite količinu novog proizvoda: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    int productNumber = storeProducts.Count + 1;
                    storeProducts.Add(new Product { ProductNumber = productNumber, Name = name, Price = price, Quantity = quantity });
                    Console.WriteLine($"Proizvod '{name}' dodan je u trgovinu.");
                }
                else
                {
                    Console.WriteLine("Neodgovarajuća količina. Unesite valjani broj.");
                }
            }
            else
            {
                Console.WriteLine("Neodgovarajuća cijena. Unesite valjani broj.");
            }
        }

        static void BuyProduct() // kupovina
        {
            ListAllProducts();
            Console.WriteLine("0. Return to Main Menu");

            int choice = GetChoice(0, storeProducts.Count);

            if (choice == 0)
                return;

            Product selectedProduct = storeProducts[choice - 1];
            Console.WriteLine($"You selected: {selectedProduct.Name} - ${selectedProduct.Price}");

            BuyProductQuantity(selectedProduct);
            selectedProduct.SelectedPaymentMethod = null;
            BuyProductPayment(selectedProduct);
            BuyProductDelivery(selectedProduct);
        }

        static void BuyProductQuantity(Product product)
        {
            Console.Write($"Enter the quantity you want to buy (0 to return to Main Menu): ");
            int quantity = GetChoice(0, product.Quantity);

            if (quantity == 0)
                return;

            if (quantity > product.Quantity)
            {
                Console.WriteLine("Invalid quantity. Please try again.");
                BuyProductQuantity(product);
                return;
            }
        }

        static void BuyProductPayment(Product selectedProduct)
        {
            Console.WriteLine("Choose Payment Method:");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. Cash");
            Console.WriteLine("3. Check");
            Console.WriteLine("0. Return to Main Menu");

            int choice = GetChoice(0, 3);

            switch (choice)
            {
                case 1:
                    selectedProduct.SelectedPaymentMethod = new CreditCardPayment();
                    break;
                case 2:
                    selectedProduct.SelectedPaymentMethod = new CashPayment();
                    break;
                case 3:
                    selectedProduct.SelectedPaymentMethod = new CheckPayment();
                    break;
                default:
                    break;
            }
        }

        static void BuyProductDelivery(Product product)
        {
            Console.WriteLine("Choose Delivery Method:");
            Console.WriteLine("1. Pickup Delivery");
            Console.WriteLine("2. Post Delivery");
            Console.WriteLine("3. Courier Delivery");
            Console.WriteLine("0. Return to Main Menu");

            int choice = GetChoice(0, 3);

            switch (choice)
            {
                case 1:
                    {
                    Console.Write("Receiver Name: ");
                    string receiverName = Console.ReadLine();

                    Console.Write("Receiver Number: ");
                    string receiverNumber = Console.ReadLine();

                    Console.Write("Sender Name: ");
                    string senderName = Console.ReadLine();

                    Console.Write("Sender Address: ");
                    string senderAddress = Console.ReadLine();

                    Console.Write("Due Pickup Date: ");
                    string duePickupDate = Console.ReadLine();

                    GenerateReceipt(product, "Pickup Delivery", receiverName, receiverNumber, senderName, senderAddress, duePickupDate);
                    break;
                    }
                case 2:
                    {
                    Console.Write("Receiver Name: ");
                    string receiverName = Console.ReadLine();

                    Console.Write("Receiver Number: ");
                    string receiverNumber = Console.ReadLine();

                    Console.Write("Sender Name: ");
                    string senderName = Console.ReadLine();

                    Console.Write("Sender Address: ");
                    string senderAddress = Console.ReadLine();

                    Console.Write("Delivery Date: ");
                    string deliveryDate = Console.ReadLine();

                    GenerateReceipt(product, "Post Delivery", receiverName, receiverNumber, senderName, senderAddress, deliveryDate);
                    break;
                    }
                case 3:
                    {
                    Console.Write("Receiver Name: ");
                    string receiverName = Console.ReadLine();

                    Console.Write("Receiver Number: ");
                    string receiverNumber = Console.ReadLine();

                    Console.Write("Sender Name: ");
                    string senderName = Console.ReadLine();

                    Console.Write("Sender Address: ");
                    string senderAddress = Console.ReadLine();

                    Console.Write("Delivery Date: ");
                    string deliveryDate = Console.ReadLine();

                    Console.Write("Courier Name: ");
                    string courierName = Console.ReadLine();

                    Console.Write("Courier Address: ");
                    string courierAddress = Console.ReadLine();

                    GenerateReceipt(product, "Courier Delivery", receiverName, receiverNumber, senderName, senderAddress, deliveryDate, courierName, courierAddress);
                    break;
                    }
                default:
                    break;
            }
        }

        static void GenerateReceipt(Product product, string deliveryMethod, string receiverName, string receiverNumber, string senderName, string senderAddress, string deliveryOrPickupDate, string courierName = "", string courierAddress = "")
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Unit Price: ${product.Price}");
            double totalWithoutVAT = product.Price;
            Console.WriteLine($"Total without VAT: ${totalWithoutVAT}");
            double vatPercentage = 0.20; // Assuming a VAT of 20%
            double vatPrice = totalWithoutVAT * vatPercentage;
            Console.WriteLine($"VAT ({vatPercentage * 100}%): ${vatPrice}");
            double totalWithVAT = totalWithoutVAT + vatPrice;
            Console.WriteLine($"Total with VAT: ${totalWithVAT}");
            Console.WriteLine($"Payment Method: {product.SelectedPaymentMethod}");
            Console.WriteLine($"Delivery Method: {deliveryMethod}");
            Console.WriteLine($"Receiver Name: {receiverName}");
            Console.WriteLine($"Receiver Number: {receiverNumber}");
            Console.WriteLine($"Sender Name: {senderName}");
            Console.WriteLine($"Sender Address: {senderAddress}");
            Console.WriteLine($"Delivery/Pickup Date: {deliveryOrPickupDate}");
            if (!string.IsNullOrEmpty(courierName) && !string.IsNullOrEmpty(courierAddress))
            {
                Console.WriteLine($"Courier Name: {courierName}");
                Console.WriteLine($"Courier Address: {courierAddress}");
            }

            // Return to the Main Menu
        }

        static int GetChoice(int min, int max)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            return choice;
        }
    }
}


// postavi sender info... 
// povećaj količine
// napravi da bude lijepo