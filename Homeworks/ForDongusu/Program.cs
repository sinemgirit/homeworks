
using System.Transactions;

Console.Write("Kaç adet ürün istiyorsunuz:");
Console.WriteLine();
int piece=Convert.ToInt32(Console.ReadLine());
double total = 0;

for (int i = 0; i<piece; i++)
{
	
	Console.Write("ürün fiyatı giriniz:");
	Console.WriteLine();
	double productprice = Convert.ToDouble(Console.ReadLine());
	total=total+productprice;


}
Console.WriteLine("Ürnün Toplam Fiyatı:" + total);

Console.ReadKey();
