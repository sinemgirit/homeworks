
//İkisinin de çalışma mantığı  aynıdır, ama while döngüsünde parantez içerisindeki koşul sağlandığı sürece kod bloğu çalışacaktır.
// Do-while döngüsünde durum false olsa bile döngü en az bir kere çalışacaktır.



// do while öreneği
int girilenSayi = 0;

do
{
	Console.WriteLine("0'dan büyük bir sayı giriniz: ");
	girilenSayi = int.Parse(Console.ReadLine());
	if (girilenSayi < 100)
	{
		Console.WriteLine("doğru sayı girdiniz!");	
	}
	else
	{
		Console.WriteLine("daha küçük sayı giriniz");	
	}
} while (girilenSayi > 100);




