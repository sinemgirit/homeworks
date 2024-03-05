





SiparisNumarasıYaz();

Console.WriteLine("Sipariş Numarası seçiniz ");
string secim=Console.ReadLine();

switch (secim)
{
	case "1":
		Console.WriteLine("kalem ürününü seçtiniz");
		break;
	case "2":
		Console.WriteLine("silgi ürününü seçtiniz");
		break;
	case "3":
		Console.WriteLine("defter ürününü seçtiniz");
		break;
	case "4":
		Console.WriteLine("Kalemlik ürününü seçtiniz");
		break;

	default:
		break;
}


static void SiparisNumarasıYaz()

{
	Console.Clear();


	Console.WriteLine("1) Kalem");
	Console.WriteLine("2) Silgi");
	Console.WriteLine("3) Defter");
	Console.WriteLine("4) Kalemlik");
	Console.WriteLine("0) Çıkış");
	Console.WriteLine();

}



