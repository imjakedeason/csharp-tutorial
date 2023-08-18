namespace Program {
    class MainMenu {
        private string zanClass;
        public string SimName() {
            string? name;
            bool running = true;
            do {
                // Ime Sima
                Console.WriteLine("\n******************");
                Console.WriteLine("\nKREIRANJE SIMA");
                Console.WriteLine("\n******************");
                Console.WriteLine("\nUpišite ime Sima: ");
                name = Console.ReadLine();

                // Ako nema unosa, prekida se rad aplikacije
                if (name == null || name == "") {
                    Console.WriteLine("\nGreška prilikom unosa. Aplikacija će se zatvoritit.");
                } else {
                    running = false;
                }
            } while (running);
            return zanClass;
        }
        public int SimAge() {
            int? age;
            bool running = true;
            do {
                // Godine Sima
                Console.WriteLine("\n******************");
                Console.WriteLine("\nUpišite godine Sima: ");
                age = Console.ReadLine();

                // Ako nema unosa, prekida se rad aplikacije
                if (age == null || age == "") {
                    Console.WriteLine("\nGreška prilikom unosa. Aplikacija će se zatvoriti.");
                } else if
            }
        }
        public string ZanimanjeClass() {
            bool running = true;
            do {
                // Izbornik zanimanja
                Console.WriteLine("1. Astronaut ");
                Console.WriteLine("2. Doktor ");
                Console.WriteLine("3. Kuhar ");
                Console.WriteLine("4. Cvjećar ");
                Console.WriteLine("5. Znanstvenik ");
                Console.WriteLine("6. Slikar ");
                Console.WriteLine("7. Ribar ");
                Console.WriteLine("8. Odvjetnik ");
                Console.WriteLine("\nUpišite broj klase zanimanja za vašeg Sima: ");

                // Korisnik odabire klasu zanimanja
                string? key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                //Ako izbor nije 1-8, prekini rad aplikacije
                if (choice == 1) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Astronaut");
                    Console.WriteLine("\n******************");
                    zanClass = "Astronaut";
                    running = false;
                } else if (choice == 2) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Doktor");
                    Console.WriteLine("\n******************");
                    zanClass = "Doktor";
                    running = false;
                } else if (choice == 3) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Kuhar");
                    Console.WriteLine("\n******************");
                    zanClass = "Kuhar";
                    running = false;
                } else if (choice == 4) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Cvjećar");
                    Console.WriteLine("\n******************");
                    zanClass = "Cvjećar";
                    running = false;
                } else if (choice == 5) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Znanstvenik");
                    Console.WriteLine("\n******************");
                    zanClass = "Znanstvenik";
                    running = false;
                } else if (choice == 6) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Slikar");
                    Console.WriteLine("\n******************");
                    zanClass = "Slikar";
                    running = false;
                } else if (choice == 7) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Ribar");
                    Console.WriteLine("\n******************");
                    zanClass = "Ribar";
                    running = false;
                } else if (choice == 8) {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nOdabrali ste klasu: Odvjetnik");
                    Console.WriteLine("\n******************");
                    zanClass = "Odvjetnik";
                    running = false;
                } else {
                    Console.WriteLine("\nNedozvoljeni unos. Probajte ponovo.");
                }
            } while (running);

            return (zanClass);
        }
    }
}

// namespace Program {
//     class MainMenu {
//         private string charClass;
//         public string CharacterClass() {
//             bool running = true;
//             do { 
//                 // Izbornik
//                 Console.WriteLine("1. Warrior ");
//                 Console.WriteLine("2. Mage ");
//                 Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

//                 // Korisnik bira klasu
//                 string key = Console.ReadLine();
//                 int choice = key == "" ? 0 : int.Parse(key);

//                 // Ako izbor nije 1 ili 2, prekini rad aplikacije
//                 if (choice == 1) {
//                     Console.WriteLine("\nOdabrali ste klasu: Warrior");
//                     charClass = "Warrior";
//                     running = false;
//                 } else if (choice == 2) {
//                     Console.WriteLine("\nOdabrali ste klasu: Mage");
//                     charClass = "Mage";
//                     running = false;
//                 } else {
//                     Console.WriteLine("\nNedozvoljeni unos! Probajte ponovno.");
//                 } 
//             } while (running);
            
//             return charClass;
//         }

//         public string CharacterName() {
//             string name;
//             bool running = true;
//             do {
//                 // Ako je izbor u redu, pitaj igrača za ime lika
//                 Console.WriteLine("\n****************************");
//                 Console.WriteLine("\nUpišite ime vašeg lika: ");
//                 name = Console.ReadLine();

//                 // Ako nema unosa, prekini rad aplikacije
//                 if (name == null || name == "") {
//                     Console.WriteLine("\nGreška! Niste unijeli ime lika. Aplikacija će se zatvoriti.");
//                 }
//                 else {
//                     running = false;
//                 }
//             } while (running);

//             return charClass;
//         }
//     }
// }