//Console.WriteLine("Hello, World!");

byte    b = 5;          //1 byte
sbyte   c = 5;          //1 byte

short   d = 5;          //2 byte from -32768 to 32768
ushort  e = 5;          //2 byte from   0    to 65365

Int16   f = 2;          //2 byte
int     g = 2;          //4 byte
Int32   h = 2;          //4 byte
uint    i = 2;          //4 byte
Int64   j = 2;          //8 byte
long    k = 2;          //8 byte
// REEL Sayılar
float   l = 2;          //4 byte
double  m = 2;          //8 byte
decimal n = 2;          //16 byte

char    o = 'a';        //2 byte
string  p = "HUZEYFE";  //LİMİTSİZ

bool    r = true;
bool    s = false;

DateTime d1 = DateTime.Now;
//Console.WriteLine(d1);

object t = 'a';
object u = "obe";
object v = 4.3;
object y = 45;

//string ifadeler

string str1 = "";
string str2 = string.Empty;
string str3 = str1 + '&' + str2;

//Boolean

bool bool1 = 10<2;

//Değişken Dönüşümleri
string  str11 = "20";
int int1 = 23;
string serirakam = str11 + int1.ToString();
string serirakam1 = str11 + Convert.ToString(int1);

//System.Console.WriteLine(serirakam1);

int sum = int1 + int.Parse(str11);

//System.Console.WriteLine(sum);

string dateTime = DateTime.Now.ToString("dd/MM/yyyy"); 
string dateTime1 = DateTime.Now.ToString("hh:mm:ss");
System.Console.WriteLine(dateTime);
System.Console.WriteLine(dateTime1);


