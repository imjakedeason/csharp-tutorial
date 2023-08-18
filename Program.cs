namespace Program
{
    class Application
    {
        static void Main(string[] args){
            MainMenu menu = new MainMenu();
            string klasa = menu.CharacterClass();
            string ime = menu.CharacterName();

            Character player = new Character(klasa, ime); // zelena boja označava klasu
            player.print();
        }
    }
}









// using System.Globalization;
// using System.Text.RegularExpressions;
// Console.OutputEncoding = System.Text.Encoding.UTF8;

// int[] brojevi = new int[4] { 2, 4, 6, 8 };
// int[] drugiBrojevi = new int[4] { 1, 3, 5, 7 };

// Mnozenje rezultat = new Mnozenje();
// rezultat.kvadriranje(brojevi);

// Mnozenje drugiRezultat = new Mnozenje();
// drugiRezultat.kvadriranje(drugiBrojevi);

// class Mnozenje {
//     public void kvadriranje(int[] data) {
//         Console.WriteLine("POCETAK");
//         foreach(int x in data) {
//             Console.WriteLine("Broj: " + x);
//             Console.WriteLine(x * x);
//         }
//         Console.WriteLine("KRAJ");
//     }
// }


// string[] posao = new string[3] { "programer", "devops", "dizajner"};
// string[] ucenik = new string[3] { "Perica", "Ivica", "Lukica"};
// int[] ocjena = new int[3] { 2, 3, 5};

// Person user = new Person("Željko", "Zvekić", 23, true, posao[0]); //objekt (također, mora biti iznad klase ako je u istom .cs)
// Person user2 = new Person("Jake", "Deason", 24, false, posao[2]); //definiramo podatak
// Person user3 = new Person("Pero", "Perić", 30, false, posao[1]); 
// Person user4 = new Person("Marko", "Marić", 41, false, posao[1]); 
// Person user5 = new Person("Domi", "Marić", 19, false, posao[1]); 

// List<Person> userList = new List<Person>();
// List<Person> userList2 = new List<Person>();

// userList.Add(user);
// userList.Add(user2);
// userList.Add(user3);

// userList2.Add(user4);
// userList2.Add(user5);

// PrintUser print = new PrintUser();
// print.printUsers(userList);
// print.printUsers(userList2);

// // Console.WriteLine("**********************************************************");
// // Console.WriteLine("Ime i prezime: {0} {1}", user.ime, user.prezime);
// // Console.WriteLine("Dob: {0}", user.age);
// // Console.WriteLine("Spol: {0}", user.gender ? "Muško" : "Žensko");
// // Console.WriteLine("Posao: {0}", user.posao);

// // Console.WriteLine("**********************************************************");
// // Console.WriteLine("Ime i prezime: {0} {1}", user2.ime, user2.prezime);
// // Console.WriteLine("Dob: {0}", user2.age);
// // Console.WriteLine("Spol: {0}", user2.gender ? "Muško" : "Žensko");
// // Console.WriteLine("Posao: {0}", user2.posao);
// // Console.WriteLine("**********************************************************");

// class Person {
//     public string ime; //private zabranjuje korištenje gore u console.writeline
//     public string prezime;
//     public int age;
//     public bool gender; // muško true, žensko false
//     public string posao;

//     public Person(string ime, string prezime, int age, bool gender, string posao) {
//         this.ime = ime;
//         this.prezime = prezime;
//         this.age = age;
//         this.gender = gender;
//         this.posao = posao;
//     }
// }

// class PrintUser {
//     public void printUsers(List<Person> users) {
//         // //foreach loop
//         // users.ForEach(x => {
//         //     Console.WriteLine("**********************************************************");
//         //     Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime);
//         //     Console.WriteLine("Dob: {0}", x.age);
//         //     Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko");
//         //     Console.WriteLine("Posao: {0}", x.posao);
//         // });

//         foreach(Person x in users) {
//             Console.WriteLine("**********************************************************");
//             Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime);
//             Console.WriteLine("Dob: {0}", x.age);
//             Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko");
//             Console.WriteLine("Posao: {0}", x.posao);
//         }
//     } 
// }