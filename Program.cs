using System.Globalization;
using System.Text.RegularExpressions;

string hello = "Dobar dan.";
string poruka = "Ovo je poruka.";

Console.WriteLine(hello);
Console.WriteLine(poruka);
Console.OutputEncoding = System.Text.Encoding.UTF8;

// tip nazivVarijable = vrijednost
// int number = 12345;
double decimalNum = 3.14566;
// string valuta = "€";
Boolean trueFalse = false;

int number = 12011;
string valuta = "180";

// casting, parsiranje
string result = ((number + int.Parse(valuta)) / 100).ToString();
string booleanString = trueFalse.ToString();
string doubleString = decimalNum.ToString();

int cijeli = (int)decimalNum;
int cijelidva = trueFalse ? 1 : 0;
// int result = int.Parse(Regex.Match(number, @"\d").Value, NumberFormatInfo.InvariantInfo);

Console.WriteLine("Cijena proizvoda je: " + cijelidva);

