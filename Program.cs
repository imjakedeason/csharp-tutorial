namespace Program
{
    class Application
    {
        static void Main(string[] args){
            MainMenu menu = new MainMenu();
            string ime = menu.SimName();
            string klasa = menu.ZanimanjeClass();

            Sim player = new Sim(ime, klasa);
            player.print();
        }
    }
}