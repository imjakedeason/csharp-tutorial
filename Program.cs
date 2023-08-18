namespace Program
{
    class Application
    {
        static void Main(string[] args){
            MainMenu menu = new MainMenu();
            string ime = menu.SimName();
            int age = menu.SimAge();
            string klasa = menu.ZanimanjeClass();

            Sim player = new Sim(ime, age, klasa);
            player.print();
        }
    }
}