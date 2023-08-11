using System.Globalization;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] posao = new string[3] { "programer", "devops", "dizajner"};
string[] ucenik = new string[3] { "Perica", "Ivica", "Lukica"};
int[] ocjena = new int[3] { 2, 3, 5};

ucenik[1];
ocjena[1];

Person user = new Person("Željko", "Zvekić", 23, true, posao[0]); //objekt (također, mora biti iznad klase ako je u istom .cs)
Person user2 = new Person("Jake", "Deason", 24, false, posao[2]); //definiramo podatak

Console.WriteLine("**********************************************************");
Console.WriteLine("Ime i prezime: {0} {1}", user.ime, user.prezime);
Console.WriteLine("Dob: {0}", user.age);
Console.WriteLine("Spol: {0}", user.gender ? "Muško" : "Žensko");
Console.WriteLine("Posao: {0}", user.posao);

Console.WriteLine("**********************************************************");
Console.WriteLine("Ime i prezime: {0} {1}", user2.ime, user2.prezime);
Console.WriteLine("Dob: {0}", user2.age);
Console.WriteLine("Spol: {0}", user2.gender ? "Muško" : "Žensko");
Console.WriteLine("Posao: {0}", user2.posao);
Console.WriteLine("**********************************************************");

class Person {
    public string ime; //private zabranjuje korištenje gore u console.writeline
    public string prezime;
    public int age;
    public bool gender; // muško true, žensko false
    public string posao;

    public Person(string ime, string prezime, int age, bool gender, string posao) {
        this.ime = ime;
        this.prezime = prezime;
        this.age = age;
        this.gender = gender;
        this.posao = posao;
    } 
}
