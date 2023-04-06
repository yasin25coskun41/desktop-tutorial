double cifttoplam = 0, tektoplam =0 ;
int i = 0;
while (i <10)
{
    console.write("{0} sayıyı girin:", i+1);
    double sayi = Convert.ToDouble(console.writeline());
    if( sayi % 2 == 0 )
    cifttoplam = cifttoplam + sayi;
    else  
    tektoplam = tektoplam + sayi
    i++;
}
console.writeline  ("ciftlerin toplamı={0}\n teklerin toplamı={1}",cifttoplam,tektoplam);
console.Readkey();
