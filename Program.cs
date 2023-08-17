using System.Globalization;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] zanr = new string[] { "pop", "country", "rap", "indie", "alternative"};

PjesmaTaylorSwift pjesma1 = new PjesmaTaylorSwift("Blank Space", false, "Taylor Swift", "Max Martin", "Shellback", "3:51", 2014, zanr[0]);
PjesmaTaylorSwift pjesma2 = new PjesmaTaylorSwift("Clean", true, "Taylor Swift", "Imogen Heap", "Taylor Swift", "4:31", 2014, zanr[0]);
PjesmaTaylorSwift pjesma3 = new PjesmaTaylorSwift("right where you left me", false, "Taylor Swift", "Aaron Dessner", "Taylor Swift", "4:05", 2020, zanr[3]);
PjesmaTaylorSwift pjesma4 = new PjesmaTaylorSwift("Enchanted", true, "Taylor Swift", "Christopher Rowe", "Taylor Swift", "5:53", 2023, zanr[4]);
PjesmaTaylorSwift pjesma5 = new PjesmaTaylorSwift("...Ready For It?", false, "Taylor Swift", "Max Martin", "Shellback", "3:28", 2017, zanr[2]);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma1.ime, pjesma1.taylorsversion ? "(Taylor's Version)" : ""); 
Console.WriteLine("Izvođač: {0}", pjesma1.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma1.producent1, pjesma1.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma1.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma1.godina);
Console.WriteLine("Žanr: {0}", pjesma1.zanr);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma2.ime, pjesma2.taylorsversion ? "(Taylor's Version)" : "");
Console.WriteLine("Izvođač: {0}", pjesma2.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma2.producent1, pjesma2.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma2.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma2.godina);
Console.WriteLine("Žanr: {0}", pjesma2.zanr);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma3.ime, pjesma3.taylorsversion ? "(Taylor's Version)" : "");
Console.WriteLine("Izvođač: {0}", pjesma3.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma3.producent1, pjesma3.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma3.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma3.godina);
Console.WriteLine("Žanr: {0}", pjesma3.zanr);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma4.ime, pjesma4.taylorsversion ? "(Taylor's Version)" : "");
Console.WriteLine("Izvođač: {0}", pjesma4.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma4.producent1, pjesma4.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma4.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma4.godina);
Console.WriteLine("Žanr: {0}", pjesma4.zanr);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma5.ime, pjesma5.taylorsversion ? "(Taylor's Version)" : "");
Console.WriteLine("Izvođač: {0}", pjesma5.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma5.producent1, pjesma5.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma5.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma5.godina);
Console.WriteLine("Žanr: {0}", pjesma5.zanr);

class PjesmaTaylorSwift {
    public string ime;
    public bool taylorsversion; //Namješteno je kada je true, onda se pojavi tekst. Kada je false, onda se pojavi prazno.
    public string izvodac;
    public string producent1;
    public string producent2;
    public string trajanje;
    public int godina;
    public string zanr;

    public PjesmaTaylorSwift(string ime, bool taylorsversion, string izvodac, string producent1, string producent2,  string trajanje, int godina, string zanr) {
        this.ime = ime;
        this.taylorsversion = taylorsversion;
        this.izvodac = izvodac;
        this.producent1 = producent1;
        this.producent2 = producent2;
        this.trajanje = trajanje;
        this.godina = godina;
        this.zanr = zanr;
    }
}