using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Program {
    class Program {
        static List<Product> storeProducts = new List<Product>();
        static PaymentMethod selectedPaymentMethod;

        static void Main(string[] args) // main menu 
        {
            Store();

            while (true)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Izbornik:");
                Console.WriteLine("***********************************");
                Console.WriteLine("1. Popis proizvoda");
                Console.WriteLine("2. Dodaj novi proizvod");
                Console.WriteLine("3. Kupi proizvod");
                Console.WriteLine("4. Izlaz iz aplikacije");
                Console.WriteLine("***********************************");
                Console.Write("Unesite svoj izbor: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ListProducts();
                            break;
                        case 2:
                            AddProduct();
                            break;
                        case 3:
                            BuyProduct();
                            break;
                        case 4:
                            Console.WriteLine("Izlazim iz programa.");
                            return;
                        default:
                            Console.WriteLine("Pogrešan izbor. Pokušajte ponovno.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Unesite valjanu opciju.");
                }
            }
        }

        static void Store()
        {
            storeProducts.Add(new Product { ProductNumber = 1, Name = "Sušilo za kosu", Price = 10.80, Quantity = 14 });
            storeProducts.Add(new Product { ProductNumber = 2, Name = "Mikrovalna", Price = 15.40, Quantity = 6 });
            storeProducts.Add(new Product { ProductNumber = 3, Name = "Hladnjak", Price = 22.60, Quantity = 30 });
            storeProducts.Add(new Product { ProductNumber = 4, Name = "Lampa za stol", Price = 5.10, Quantity = 14 });
        }

        static void ListProducts() // lista proizvoda
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Proizvodi u trgovini:");
            Console.WriteLine("***********************************");
            Console.WriteLine("Broj\tIme proizvoda\t\tCijena\t\tKoličina");

            foreach (var product in storeProducts)
            {
                Console.WriteLine($"{product.ProductNumber}\t{product.Name}\t\t{product.Price}\t\t{product.Quantity}");
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Pritisnite Enter za nastavak.");
            Console.ReadLine();
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

        static void BuyProduct() // kupovina proizvoda
        {
            Console.WriteLine("\n***********************************");
            Console.WriteLine("Kupovina proizvoda:");
            ListProducts();

            Console.WriteLine("***********************************");
            Console.Write("Unesite broj proizvoda koji želite kupiti (0 za nazad): ");
            if (int.TryParse(Console.ReadLine(), out int productNumber) && productNumber > 0 && productNumber <= storeProducts.Count)
            {
                Product selectedProduct = storeProducts[productNumber - 1];

                Console.WriteLine("***********************************");
                Console.Write($"Unesite količinu proizvoda '{selectedProduct.Name}' koju želite kupiti (0 za nazad): ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                {
                    if (quantity <= selectedProduct.Quantity)
                    {
                        Console.WriteLine("\n***********************************");
                        Console.WriteLine($"Ukupni iznos za {quantity} '{selectedProduct.Name}' je: {selectedProduct.Price * quantity}");

                        Console.WriteLine("\n***********************************");
                        Console.WriteLine("Odaberite način plaćanja:");
                        Console.WriteLine("***********************************");
                        Console.WriteLine("1. Kreditna kartica");
                        Console.WriteLine("2. Gotovina");
                        Console.WriteLine("3. Ček");
                        Console.WriteLine("***********************************");
                        Console.Write("Unesite svoj izbor plaćanja: ");

                        if (int.TryParse(Console.ReadLine(), out int paymentChoice))
                        {
                            switch (paymentChoice)
                            {
                                case 1:
                                    selectedPaymentMethod = new CashPayment();
                                    break;
                                case 2:
                                    selectedPaymentMethod = new CreditCardPayment();
                                    break;
                                default:
                                    Console.WriteLine("Nevažeći izbor plaćanja. Plaćanje otkazano.");
                                    return;
                            }

                            selectedPaymentMethod.MakePayment(selectedProduct.Price * quantity);
                            selectedProduct.Quantity -= quantity;
                            Console.WriteLine($"Uspješno ste kupili {quantity} '{selectedProduct.Name}'.");
                        }
                        else
                        {
                            Console.WriteLine("Nevažeći izbor plaćanja. Plaćanje otkazano.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nedovoljna količina'{selectedProduct.Name}' u trgovini.");
                    }
                }
                else
                {
                    Console.WriteLine("Nevažeća količina. Unesite važeći broj.");
                }
            }
            else if (productNumber == 0)
            {
                // odlazak nazad u main menu
            }
            else
            {
                Console.WriteLine("Nevažeći broj proizvoda. Unesite važeći broj.");
            }
        }
    }
}