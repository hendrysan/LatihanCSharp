// See https://aka.ms/new-console-template for more information
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
//TUGAS LATIHAN 1

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

//latihan 2

string nama1 = "Jhone";
string nama2 = "Shena";
int umur = 30;



Console.WriteLine(nama1);
Console.WriteLine(nama1);

Console.WriteLine(nama2);

Console.WriteLine(nama1 + nama2);

//merubah tipe data umur dari integer menjadi string
Console.WriteLine("nama : " + nama1 + ", umurnya : " + umur.ToString());
//cara lain untuk mengkonversi tipe data dengan convert
Console.WriteLine("nama ; " + nama2 + ", umur :" + Convert.ToString(umur));


int angka1 = 3;
int angka2 = 5;

int hasil = angka1 + angka2;

Console.WriteLine(hasil);
Console.WriteLine(angka1 + angka2);

double double1 = 1.8;
double double2 = 2.2;

double hasildouble = double1 + double2;

Console.WriteLine(hasildouble);
Console.Write(double1 + double2);

Console.WriteLine("masukkan user name :");
string userName = Console.ReadLine(); //untuk membaca Line yang user input
Console.WriteLine("User Name adalah: " + userName); // menampilkan variabel userName

Console.WriteLine("TES");
Console.WriteLine();

//TUGAS LATIHAN 2

string Restoran = "Menu Restoran Maju Mundur";
Console.WriteLine(Restoran);
Console.WriteLine();
string no1 = "Ayam Bakar";
string no2 = "Nasi Liwet";
string no3 = "Es Teh Manis";
string no4 = "Kerupuk Olga";
string no5 = "Es Jeruk";
Console.WriteLine("1. " + no1);
Console.WriteLine("2. " + no2);
Console.WriteLine("3. " + no3);
Console.WriteLine("4. " + no4);
Console.WriteLine("5. " + no5);
Console.WriteLine();
Console.WriteLine("masukkan pilihan anda : ");
string userNa = Console.ReadLine();
Console.WriteLine("Anda memilih nomer " + userNa + " adalah " );

//Deklarasikan data daftar menu
string menu1 = " Ayam Bakar";
string menu2 = " Nasi Liwet";
string menu3 = " Es Teh Manis";
string menu4 = " Kerupuk Olga";
string menu5 = " Es Jeruk";


// menampilkan data menu;
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
Console.WriteLine("switch");

int day = 8;
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
// Outputs "Thursday" (day 4)

int whileData = 0;
while (whileData < 5)
{
    Console.WriteLine(whileData);
    whileData++;
}

while (whileData < 5) ;

Console.WriteLine();
Console.WriteLine("For Loop");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i <= 10; i = i + 2)
{
    Console.WriteLine(i);
}


Console.ReadKey();