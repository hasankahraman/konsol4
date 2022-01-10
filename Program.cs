// See https://aka.ms/new-console-template for more information
// Implicit Conversion - Bilinçsiz Dönüşüm
Console.WriteLine("******Implicit Conversion - Bilinçsiz Dönüşüm*****");
byte a = 5;
sbyte b = 30;
short c= 10;

int d = a+b+c;
Console.WriteLine("d " + d);

long e = d;
Console.WriteLine("e " + e);

float f = e;
Console.WriteLine("f " + f);

string s = "Hasan";
char k = 'k';

object o = s+k+d;
Console.WriteLine(o);


//Explicit Conversion - Bilinçli Dönüşüm

Console.WriteLine("******Explicit Conversion - Bilinçli Dönüşüm*****");

int x = 4;
byte y = (byte)x;
Console.WriteLine("y: " + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t: " + t);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v: " + v);

/// ToString Methodu
Console.WriteLine("******ToString Methodu*****");

int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy: " + yy);

string xy = (12.5f).ToString();
Console.WriteLine("xy: " + xy);


/// System.Convert Methodu
Console.WriteLine("******System.Convert*****");

string s1 = "10";
string s2 = "20";
int sayi1, sayi2, toplam;
sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

toplam = sayi1 + sayi2;
Console.WriteLine("toplam: " + toplam);

/// Parse Methodu
Console.WriteLine("******Parse*****");

string metin1 = "10";
string metin2 = "10,25";
int rakam1;
double double1;
rakam1 = Int32.Parse(metin1);
double1 = Double.Parse(metin2);
Console.WriteLine("rakam1: " + rakam1);
Console.WriteLine("double1: " + double1);