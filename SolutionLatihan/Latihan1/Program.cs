//// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Transactions;

///Latihan 1
Console.WriteLine("Hello, World!");
Console.WriteLine("Saya sedang belajar bahasa C#");
Console.WriteLine("Ini sangat mengagumkan");
Console.WriteLine(2 + 3);
Console.Write("ini contoh write aja");
//Console.Write("cek bedanya");
Console.WriteLine();
Console.WriteLine(19.99);
Console.WriteLine('B');
Console.WriteLine(1 + 1 == 5 ? "jawaban ini benar" : "jawaban ini  salah");
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine(DateTime.Now.ToString());


Console.WriteLine("test ini dari github");

Console.WriteLine("tugas untuk nambahin github");

Console.WriteLine("ok ada perubahan");
//tes perubahan

//penambahan koding

Console.WriteLine();
string nama = "Hendry Priyatno";
Console.WriteLine(nama);
Console.WriteLine("-----------------------------------");
char baris = '-';
Console.WriteLine(baris);
Console.Write("No |");
Console.Write("Nama          |");
Console.WriteLine("Umur          |");
Console.WriteLine("-----------------------------------");
Console.WriteLine(baris);
Console.Write("1  |");
Console.Write("Udin          |");
Console.WriteLine("19            |");
int Joko = 25;
Console.Write("2  |");
Console.Write("Joko          |");
Console.Write(Joko);
Console.WriteLine("            |");
double Adi = 17.5;
Console.Write("3  |");
Console.Write("Adi           |");
Console.Write(Adi);
Console.WriteLine("          |");

Console.Write("4  |");
Console.Write("Slamet        |");

Console.WriteLine("              |");
Console.Write("5  |");
Console.Write("Candra        |");
Console.Write(Joko);
Console.WriteLine("            |");


Console.WriteLine();


/*Latihan 2*/
string nama1 = "Jhone";
string nama2 = "Shena";
int umur = 30;

Console.WriteLine(nama1);
Console.WriteLine(nama1);

Console.WriteLine(nama2);

Console.WriteLine(nama1 + nama2);

// merubah tipe data umur dari integer menjadi string
Console.WriteLine("nama : " + nama1 + ", umurnya : " + umur.ToString());
// cara lain untuk mengkonversi tipe data dengan Convert
Console.WriteLine("nama : " + nama2 + ", umur:" + Convert.ToString(umur));


int angka1 = 3;
int angka2 = 5;

int hasil = angka1 + angka2;

Console.WriteLine(hasil);
Console.WriteLine(angka1 + angka2);

double double1 = 1.8;
double double2 = 2.2;

double hasildouble = double1 + double2; // menyimpan terlebih dahulu hasil perhitungan

Console.WriteLine(hasildouble); // menapilkan hasil dari perhitungan
Console.WriteLine(double1 + double2); //menampilkan hasil perhitungan

Console.WriteLine();

Console.WriteLine("masukan username:");

//string userName = Console.ReadLine(); //untuk membaca line yang user input

//Console.WriteLine("Username adalah: " + userName); // menampilkan variable userName



// deklarasikan data daftar menu
string menu1 = "1. Ayam Bakar";
string menu2 = "2. Nasi Liwet";
string menu3 = "3. Es Teh Manis";
string menu4 = "4. Kerupuk Olga";
string menu5 = "5. Es Jeruk";


//// menampilkan data menu;
string menu = @"Menu Restoran Maju Mundur";
Console.WriteLine(menu);
Console.WriteLine(menu1);
Console.WriteLine(menu2);
Console.WriteLine(menu3);
Console.WriteLine(menu4);
Console.WriteLine(menu5);

Console.Write("Masukan pilihan anda : ");
string pilihan = Console.ReadLine();

// memberikan kondisi data yang di input user
string keterangan = "menu tidak terdaftar";
if (pilihan == "1")
{
    keterangan = menu1;
}
else if (pilihan == "2")
{
    keterangan = menu2;
}
else if (pilihan == "3")
{
    keterangan = menu3;
}
else if (pilihan == "4")
{
    keterangan = menu4;
}
else if (pilihan == "5")
{
    keterangan = menu5;
}



Console.WriteLine("Anda memilih nomor: " + pilihan + " adalah :" + keterangan);

Console.WriteLine();
Console.WriteLine("Operator - aritmatika");
// operator
// arithmatika
int x = 5;
int y = 2;

Console.WriteLine(x + y);
Console.WriteLine(x - y);
Console.WriteLine(x * y);
Console.WriteLine(x / y);
Console.WriteLine(x % y);
//Console.WriteLine(x++);
//Console.WriteLine(x--);


Console.WriteLine("Assignment Operators");
Console.WriteLine(x += 3); // x = x +3 ---> 5 +3  = x = 8
Console.WriteLine(y -= 3); // x = 8 ----> x = x -3 ----> 8 - 3 ==? 5


Console.WriteLine("Comparison Operators");

Console.WriteLine(5 == 5); // ---> ? true
Console.WriteLine(3 == 7);

Console.WriteLine(5 < 3);// ? false
Console.WriteLine(3 < 10);// ? true


Console.WriteLine(3 > 5);//false

Console.WriteLine(3 >= 4); //false

Console.WriteLine(7 >= 7);// true

Console.WriteLine(9 <= 7);

Console.WriteLine(9 <= 9);

// 1,2,3,4,5,6
// <5 ? 1,2,3,4
// <=5 ? 1,2,3,4,5
// >4 ? 5,6...
// >=4 ? 4,5,6...

Console.WriteLine("Strings");
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());



Console.WriteLine();
Console.WriteLine("Booleans");

if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}


Console.WriteLine();
Console.WriteLine("Switch");

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Day not found");
        break;
}


Console.WriteLine();
Console.WriteLine("While Loop");

int whileData = 0;
while (whileData < 5)
{
    Console.WriteLine(whileData);
    whileData++;
}

whileData = 0;
do
{
    Console.WriteLine(whileData);
    whileData++;
}
while (whileData < 5);

Console.WriteLine();
Console.WriteLine("For Loop");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------------------");
Console.WriteLine("For Loop");

/*
 
i= 1
Outer: 1
    j=1 di ulang sampai j<=3, dengan j++


Outer: 1
    Inner: 1
    Inner: 2
    Inner: 3

i=2
Outer: 2
    Inner: 1
    Inner: 2
    Inner: 3





 */




Console.ReadKey();



