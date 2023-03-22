// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

byte b = 5; // 1 byte
sbyte c = 5; // 1 byte

short s = 5; // 2 byte
ushort us = 5; // 2 byte

Int16 i16 = 2; //2 byte
int i = 2; // 4 byte
Int32 i32 = 2; // 4 byte
Int64 i64 = 2; // 8 byte

uint ui = 2;  //4 byte
long l = 4 ; // 8 byte
ulong ul = 4; // 8 byte

  
float f = 5; // 4 byte
double d = 5; // 8 byte
decimal de = 5; // 16 byte

char ch = '2'; // 2 byte yer kaplar
string str = "Betül"; // Sınırsız

bool b1 = true;
bool b2 = false;


// bilinmeyen değişkenler

DateTime dt = DateTime.Now;//çalıştırılan anın tarih ve saat karşılığını verir.
Console.Write(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;

//string tanımlama şekilleri

string str1 = string.Empty;
string name = "Betül";
string surname = "Salim";
Console.Write("\n");
str = name + " " + surname;
Console.Write(str);

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 + integer2;


bool bool1 = 10>2;


//stringe çevirme

string str20 = "20";
int integer20 = 20;

string newString = str20 + integer20.ToString();
Console.Write("\n"+newString);

int newInteger = integer20 + Convert.ToInt32(str20);
Console.Write("\n"+newInteger);

int newInteger1 = integer20 + int.Parse(str20);
Console.Write("\n"+newInteger1);

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.Write("\n"+datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine("\n"+datetime2);

string datetimehour = DateTime.Now.ToString("HH:mm");
Console.Write("\n"+datetimehour);