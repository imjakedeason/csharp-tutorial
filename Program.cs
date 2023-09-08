using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        static List<Product> storeProducts = new List<Product>
        {
            new Product { ProductNumber = 1, Name = "Sušilo za kosu", Price = 10.80m, Quantity = 140 },
            new Product { ProductNumber = 2, Name = "Mikrovalna", Price = 15.40m, Quantity = 360 },
            new Product { ProductNumber = 3, Name = "Hladnjak", Price = 22.60m, Quantity = 430 },
            new Product { ProductNumber = 4, Name = "Lampa za stol", Price = 20.40m, Quantity = 840 }
        };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine(">>>>>>>>>> Trgovina: <<<<<<<<<<");
                Console.WriteLine("1. Popis proizvoda");
                Console.WriteLine("2. Dodaj novi proizvod");
                Console.WriteLine("3. Kupi proizvod");
                Console.WriteLine("4. Izlaz iz aplikacije");

                int choice = GetChoice(1, 4);

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

        static void ListAllProducts()
        {
            Console.WriteLine(">>>>>>>>>> Dostupni proizvodi: <<<<<<<<<<");
            foreach (var product in storeProducts)
            {
                Console.WriteLine($"{product.ProductNumber}. {product.Name} - {product.Price} € (Kol: {product.Quantity})");
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("***********************************");
            Console.Write(">>>>> Unesite ime proizvoda: ");
            string name = Console.ReadLine();

            Console.WriteLine("***********************************");
            Console.Write(">>>>> Unesite cijenu za novi proizvod: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("***********************************");
                Console.Write(">>>>> Unesite količinu na stanju za novi proizvod: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    int productNumber = storeProducts.Count + 1;
                    storeProducts.Add(new Product { ProductNumber = productNumber, Name = name, Price = price, Quantity = quantity });
                    Console.WriteLine($"Novi proizvod je dodan u trgovinu pod nazivom: '{name}'");
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

        static void BuyProduct()
        {
            ListAllProducts();
            Console.WriteLine("***********************************");
            Console.Write($"Odaberite proizvod koji želite kupiti: ");
            Console.WriteLine("\nZa povratak nazad u Izbornik, unesite '0'.");

            int choice = GetChoice(0, storeProducts.Count);

            if (choice == 0)
                return;

            Product selectedProduct = storeProducts[choice - 1];
            Console.WriteLine($">>>>> Izabrali ste proizvod: ");
            Console.WriteLine($"{selectedProduct.Name} - {selectedProduct.Price} € | {selectedProduct.Quantity}");

            Console.WriteLine("***********************************");
            Console.Write($"Unesite količinu proizvoda koju želite kupiti: ");
            int selectedQuantity = GetChoice(0, selectedProduct.Quantity);

            if (selectedQuantity == 0)
                return;

            if (selectedQuantity > selectedProduct.Quantity)
            {
                Console.WriteLine("Neodgovarajuća količina. Pokušajte ponovno.");
                return;
            }

            Console.WriteLine("Odaberite vrstu plaćanja:");
            Console.WriteLine("1. Kreditna kartica");
            Console.WriteLine("2. Gotovina");
            Console.WriteLine("3. Ček");

            int paymentChoice = GetChoice(0, 3);

            switch (paymentChoice)
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
            Console.WriteLine($"Odabrali ste sljedeći naćin plaćanja: {selectedProduct.SelectedPaymentMethod.Name}");

            Console.WriteLine(">>>>> Odaberite način dostave:");
            Console.WriteLine("1. Osobno preuzimanje");
            Console.WriteLine("2. Dostava poštom");
            Console.WriteLine("3. Dostava kurirskom službom");

            int deliveryChoice = GetChoice(0, 3);

            string senderName = "Meredith Swift Inc.";
            string senderAddress = "Ulica sezam 13, 1989 Red City";
            DateTime currentDate = DateTime.Now;
            string deliveryDate = currentDate.AddMonths(1).ToString("dd.MM.yyyy");
            string duePickupDate = "-";

            string receiverName = "-";
            string receiverAddress = "-";
            string receiverNumber = "-";
            string courierName = "-";
            string courierAddress = "-";

            switch (deliveryChoice)
            {
                case 1:
                    selectedProduct.SelectedDeliveryMethod = new PickupDelivery();
                    Console.Write(">>>>> Ime primatelja: ");
                    receiverName = Console.ReadLine();
                    Console.Write(">>>>> Telefonski broj primatelja: ");
                    receiverNumber = Console.ReadLine();
                    deliveryDate = "-";
                    duePickupDate = currentDate.AddMonths(2).ToString("dd.MM.yyyy");
                    break;
                case 2:
                    selectedProduct.SelectedDeliveryMethod = new PostDelivery();
                    Console.Write(">>>>> Ime primatelja: ");
                    receiverName = Console.ReadLine();
                    Console.Write(">>>>> Adresa primatelja: ");
                    receiverAddress = Console.ReadLine();
                    Console.Write(">>>>> Telefonski broj primatelja: ");
                    receiverNumber = Console.ReadLine();
                    break;
                case 3:
                    selectedProduct.SelectedDeliveryMethod = new CourierDelivery();
                    Console.Write(">>>>> Ime primatelja: ");
                    receiverName = Console.ReadLine();
                    Console.Write(">>>>> Adresa primatelja: ");
                    receiverAddress = Console.ReadLine();
                    Console.Write(">>>>> Telefonski broj primatelja: ");
                    receiverNumber = Console.ReadLine();
                    courierName = "Olivia Swift Express";
                    courierAddress = "Benjamin Street 7, 1989 Red City";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Odabrali ste sljedeći naćin dostave: {selectedProduct.SelectedDeliveryMethod.Name}");

            // Receipt

            Console.WriteLine("**************************************************");
            Console.WriteLine(">>>>>>>>>> Račun: <<<<<<<<<<");
            Console.WriteLine($"Proizvod: {selectedProduct.Name} Količina: {selectedQuantity}");
            decimal totalWithoutVAT = selectedProduct.Price * selectedQuantity;
            Console.WriteLine($"Cijena: {selectedProduct.Price} € | Iznos: {totalWithoutVAT} €");
            decimal vatPercentage = 0.20m; // PDV je 20%
            decimal vatPrice = totalWithoutVAT * vatPercentage;
            Console.WriteLine($"PDV ({vatPercentage * 100}%): {vatPrice:00} €");
            decimal totalWithVAT = totalWithoutVAT + vatPrice;
            Console.WriteLine("***********************************");
            Console.WriteLine($"Iznos s PDV-om: {totalWithVAT:00} €");
            Console.WriteLine("***********************************");
            Console.WriteLine($"Način plaćanja: {selectedProduct.SelectedPaymentMethod.Name}");
            Console.WriteLine($"Način dostave: {selectedProduct.SelectedDeliveryMethod.Name}");
            Console.WriteLine($">>> Ime pošaljitelja: {senderName}");
            Console.WriteLine($">>> Adresa pošaljitelja: {senderAddress}");
            Console.WriteLine($">>> Datum dostave: {deliveryDate}");
            Console.WriteLine($">>> Ime primatelja: {receiverName}");
            Console.WriteLine($">>> Adresa primatelja: {receiverAddress}");
            Console.WriteLine($">>> Krajnji datum preuzimanja: {duePickupDate}");
            Console.WriteLine($">>> Telefonski broj primatelja: {receiverNumber}");
            Console.WriteLine($">>> Ime kurira: {courierName}");
            Console.WriteLine($">>> Adresa kurirske službe: {courierAddress}");

            Console.WriteLine("**************************************************");
            Console.WriteLine("Hvala Vam na kupovini!");

            selectedProduct.Quantity -= selectedQuantity;

            Console.WriteLine(">>>>> Pritisnite Enter za nastavak.");
            Console.ReadLine();
        }

        static int GetChoice(int min, int max)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
            {
                Console.WriteLine("Pogrešan unos. Pokušajte ponovno.");
            }
            return choice;
        }
    }
}