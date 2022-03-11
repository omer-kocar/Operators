// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("****** Atama ve işlemli atama ******");
// Atama ve işlemli atama
int x = 3;
int y = 3;

y++;
Console.WriteLine(y);
y += 5;
Console.WriteLine(y);
y /= 2;
Console.WriteLine(y);
x *= 6;
Console.WriteLine(x);

Console.WriteLine("****** Mantıksal Operatorler ******");
// Mantıksal Operatorler
// ||, &&, !

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("Perfect!");
if (isSuccess || isCompleted)
    Console.WriteLine("Great!");
if (isSuccess && !isCompleted)
    Console.WriteLine("Fine!");


Console.WriteLine("****** İlişkisel operatörler ******");
// ilişkisel operatorler
// <, >, <=, >=, ==, !=
int a = 3;
int b = 4;
bool sonuc = a<b;

Console.WriteLine(sonuc + " first");
sonuc = a>b;
Console.WriteLine(sonuc + " second");
sonuc = a>=b;
Console.WriteLine(sonuc + " third");
sonuc = a<=b;
Console.WriteLine(sonuc + " fourth");
sonuc = a==b;
Console.WriteLine(sonuc+ " fifth");
sonuc = a!=b;
Console.WriteLine(sonuc + " sixth");

Console.WriteLine("****** Aritmetik operatörler ******");

int sayi1 = 10;
Console.WriteLine(sayi1);
int sayi2 = 5;
Console.WriteLine(sayi2);
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);
int sonuc2 =  sayi1 * sayi2;
Console.WriteLine(sonuc2);
int sonuc3 = sayi1 + sayi2;
Console.WriteLine(sonuc3);
sonuc1 = sayi1++;
Console.WriteLine(sonuc1);

// %  mod alma

int sonuc4 = 20%3;
Console.WriteLine(sonuc4 + ": Mod ");








