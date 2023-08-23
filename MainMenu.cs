namespace Program {
    class MainMenu {
        private string charClass;
        public string CharacterClass() {
            bool running = true;
            do { 
                // Izbornik
                Console.WriteLine("1. Warrior ");
                Console.WriteLine("2. Mage ");
                Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

                // Korisnik bira klasu
                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                // Ako izbor nije 1 ili 2, prekini rad aplikacije
                if (choice == 1) {
                    Console.WriteLine("\nOdabrali ste klasu: Warrior");
                    charClass = "Warrior";
                    running = false;
                } else if (choice == 2) {
                    Console.WriteLine("\nOdabrali ste klasu: Mage");
                    charClass = "Mage";
                    running = false;
                } else {
                    Console.WriteLine("\nNedozvoljeni unos! Probajte ponovno.");
                } 
            } while (running);
            
            return charClass;
        }

        public string CharacterName() {
            // Ako je izbor u redu, pitaj igrača za ime lika
            Console.WriteLine("\n****************************");
            Console.WriteLine("\nUpišite ime vašeg lika: ");
            string name = Console.ReadLine();

            // Ako nema unosa, prekini rad aplikacije
            if (name == null || name == "") {
                Console.WriteLine("\nGreška! Niste unijeli ime lika. Aplikacija će se zatvoriti.");
                Environment.Exit(0);
            }
            
            return name;
        }
    }
}