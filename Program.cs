using System.Globalization;
using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] zanr = new string[] { "pop", "country", "rap", "indie", "alternative"};

Pjesma_Taylor_Swift pjesma = new Pjesma_Taylor_Swift("Blank Space", "Taylor Swift", "Max Martin", "Shellback", "3:51", 2014, zanr[0], true);

Console.WriteLine("**************************************************");
Console.WriteLine("Ime pjesme: {0} {1}", pjesma.ime, pjesma.taylors_version);
Console.WriteLine("Izvođač: {0}", pjesma.izvodac);
Console.WriteLine("Producenti: {0}, {1}", pjesma.producent1, pjesma.producent2);
Console.WriteLine("Trajanje pjesme: {0}", pjesma.trajanje);
Console.WriteLine("Godina objavljivaja: {0}", pjesma.godina);
Console.WriteLine("Žanr: {0}", pjesma.zanr);

class Pjesma_Taylor_Swift {
    public string ime;
    public string izvodac;
    public string producent1;
    public string producent2;
    public string trajanje;
    public int godina;
    public string zanr;
    public bool taylors_version;

    public Pjesma_Taylor_Swift(string ime, string, string izvodac, string producent1, string producent2,  string trajanje, int godina, string zanr, bool taylors_version) {
        this.ime = ime;
        this.izvodac = izvodac;
        this.producent1 = producent1;
        this.producent2 = producent2;
        this.trajanje = trajanje;
        this.godina = godina;
        this.zanr = zanr;
        this.taylors_version = taylors_version;
        }
}
