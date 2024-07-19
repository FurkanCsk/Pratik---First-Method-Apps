
// 1 ---> Geriye Değer Döndürmeyen Bir void metot.
//        Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
static void Lyrics()
{
    Console.WriteLine("Herkesi yavaş yavaş tanıyorsun, pastadaki mum sayısı çoğaldıkça.");
}
Lyrics();

// 2 ---> Geriye Tamsayı Döndüren Bir metot
//        Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.


Random rnd = new Random();
int number = rnd.Next(1000);
Console.WriteLine(SplitMod(number));
static int SplitMod(int number)
{
    return number % 2;
}

// 3 ---> Parametre Alan ve Geriye Değer Döndüren Bir Metot
//        Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

Console.WriteLine(Multi(5,8));
static int Multi(int a, int b)
{
    return a * b;
}

// 4 ---> Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
//        Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

Person("Furkan", "Coşkun");
static void Person(string name,string surname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}
