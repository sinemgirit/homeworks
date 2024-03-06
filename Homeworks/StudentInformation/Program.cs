
using System.Xml.Linq;


Console.Write("kaç öğrenci var");
int student=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(student);
int sinav1, sinav2, sinav3;
for (int i = 0; i < student; i++)
{
	Console.WriteLine("öğrenci adını giriniz");
	string name = Console.ReadLine();
	Console.WriteLine("öğrenci soyadını giriniz");
	string surname = Console.ReadLine();
	Console.WriteLine("öğrenci 1.sınav notu giriniz");
	string quizString = Console.ReadLine();
	if (quizString == "")
	{
		sinav1 = 0;
	}
	else
	{
		sinav1 = Convert.ToInt32(quizString);	
	}
	Console.WriteLine("öğrenci 2.sınav notu giriniz");
	string  quiz2String = Console.ReadLine();
	if (quiz2String == "")
	{
		sinav2 = 0;
	}
	else
	{
		sinav2=Convert.ToInt32(quiz2String);	
	}
	Console.WriteLine("öğrenci 3.sınav notu giriniz");
	string quiz3String = Console.ReadLine();
	if (quiz3String == "")
	{
		sinav3 = 0;
	}
	else
	{
		sinav3 = Convert.ToInt32(quiz3String);
	}
		int ortalama = (sinav1 + sinav2 + sinav3) / 3;
		Console.WriteLine(name + surname +" Not Ortalaması: " + ortalama);
	BoslukBirak();
}
static void BoslukBirak()
{
	for (int i = 0; i < 30; i++)
	{
		Console.Write("=");
	}
	Console.WriteLine();
}