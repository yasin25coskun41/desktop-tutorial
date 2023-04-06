console.write(" kac adaet sayı gireceksiniz:");
int N = Convert.ToInt32(Console.readline());
double  karetoplam =0;
int i =0;
while(i<n) 
{
    console.writeline ("{0}. sayıyı giriniz:", i+1);
    int sayi = Convert.ToInt32(Console.Readline());
    karetoplam += Math.Pow(sayi , 2);
    i++;
}
Console.writeline("Girilen sayıların karelerinin toplmaı={0}", karetoplam);
console.Readkey();