Random rastgele = new Random();
int sayi = rastgele.Next(1, 10);
int number;
do
{
	Console.WriteLine("1-10 arasında bir sayı giriniz");
	number = Convert.ToInt32(Console.ReadLine());
} while (number < 0 || number > 10);

while (number != sayi)
{
	Console.WriteLine("Tekrar tahminde bulunun");
	number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("rastgele sayı" + number);
Console.ReadKey();