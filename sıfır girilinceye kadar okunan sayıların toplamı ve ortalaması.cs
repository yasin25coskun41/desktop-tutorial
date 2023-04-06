Console.writeline("sayıyı giriniz:");
int sayi = convert.ToInt32(console.readline());
int toplam = sayi;
int i = 0 , sayac=1;


while ( sayi!=0)
{
    Console.writeline("sayi giriniz:");
    sayi = Convert.ToInt32(Console.readline());
    toplam += sayi;
    if (sayi!=0)
    sayac++;
}
Console.writeline("Girilen sayıların Toplamı ={0} ortalaması={1}", toplam,toplam/sayac);
Console.Readkey();


