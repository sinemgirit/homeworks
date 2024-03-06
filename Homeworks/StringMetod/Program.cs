using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

Contains(); BoslukBirak();
EndsWith(); BoslukBirak();
StartsWith(); BoslukBirak();
Insert(); BoslukBirak();
Remove(); BoslukBirak();
Remove2(); BoslukBirak();
Replace(); BoslukBirak();
Substring(); BoslukBirak();
Substring2(); BoslukBirak();
ToLower(); BoslukBirak();
ToUpper(); BoslukBirak();
Split(); BoslukBirak();
TrimMetod(); BoslukBirak();
TrimEndMetod(); BoslukBirak();
TrimStartMetod();

static void Contains() 
{
	//sinem.Contains(“”); = String içinde aranan harf ya da kelime var mı yok mu bakar.Eğer varsa “True” yoksa “False” döner.
	string sinem = "bu benim deneme alanım";
	bool ornek = sinem.Contains("be");  //metin stringinde "be" var mı yok mu?
	//Console.WriteLine(ornek);           //True değerini döndürecektir.
	Console.WriteLine($"input:{sinem}- metod:contains- sitring içinde 'be' var mı");
	Console.WriteLine(ornek);
}
static void EndsWith()
{
	//sinem.EndsWith(“”); = metin stringinin en sonunda aranan kelime var mı yokmu bakar.Eğer varsa “True” yoksa “False” döner
	string sinem = "bu benim deneme alanım";
	bool ornek1 = sinem.EndsWith("asd");   //metin stringinin sonunda "asd" var mı?
	Console.WriteLine($"input:{sinem}- metod:Endwith- sitring sonunda 'asd' var mı ");
	Console.WriteLine(ornek1);
}
static void StartsWith()
{
	string sinem = "bu benim deneme alanım";
	//sinem.StartsWith(“”); = metin stringi aranan kelimelerlemi başlıyor bakar.True ya da False döner.
	bool ornek3 = sinem.StartsWith("b");    //metin stringi "b" ile başlıyor mu?
	Console.WriteLine($"input:\"bu benim deneme alanım\" - metod:StartsWith- sitring  'b' ile mi başlıyor");            //True yazacaktır.
	Console.WriteLine(ornek3);
}
static void Insert()
{
	//sinem.Insert(indexNo,””); = Bu metod sayesinde istediğimiz indexten sonrasına istediğimiz kelimeyi ekletebiliriz.Aşağıdaki örneği inceleyiniz.
	string sinem = "bu benim deneme alanım";
	sinem = sinem.Insert(2, "sinem");
	Console.WriteLine($"input:sinem- metod:Insert - sitring 2.indexten sonra sinem yazıyor.");
	Console.WriteLine(sinem);
}

static void Remove()
{
	string sinem = "bu benim deneme alanım";
	sinem = sinem.Remove(15); //15.indexten itibaren sil.
	Console.WriteLine($"input:bu benim deneme alanım - metod:Remove - 15.indexten sonra sil .");
	Console.WriteLine(sinem);
}
static void Remove2()
{
	string sinem = "bu benim deneme alanım";
	sinem = sinem.Remove(2, 3); //2.indexten itibaren 4 karakter sil.
	Console.WriteLine($"input:bu benim deneme alanım - metod:Remove - 2.indexten itibaren 4 karakter sil.");
	Console.WriteLine(sinem);
}
static void Replace()
{
	//sinem.Replace(‘bu değerleri’,’buna cevir’); = Bu metod iki parametre almaktadır.Birincisine değiştirilmek istenen karakter,
	//ikincisine yerine getirilecek karakterdir.
	string sinem = "bu benim deneme alanım";
	sinem = sinem.Replace('b', 'p');     //"b" leri "p" yap
	Console.WriteLine($"input:bu benim deneme alanım - metod:Replace - \"b\" leri \"p\" yap .");
	Console.WriteLine(sinem);
}
static void Substring()
{
	//sinem.Substring(4); = 4.indexten itibaren tüm karakteri alır.
	string sinem = "bu benim deneme alanım";
	Console.WriteLine($"input:bu benim deneme alanım - metod:Substring - 4.indexten itibaren tüm karakteri alır.");
	Console.WriteLine(sinem);
}
static void Substring2()
{
	//metin.Substring(2,2); = 2.indexten itibaren başlar 2 karakter alır.
	string sinem = "bu benim deneme alanım";
	sinem = sinem.Substring(4, 2);
	Console.WriteLine($"input:bu benim deneme alanım - metod:Substring - 4.indexten itibaren başlar 2 karakter alır.");
	Console.WriteLine(sinem);
}
	static void ToLower()
{
	string sinem = "BU BENİM DENEME ALANIM";
	sinem=sinem.ToLower(); // Bütün harfleri küçük yapar.
	Console.WriteLine($"input:BU BENİM DENEME ALANIM - metod:ToLower - Bütün harfleri küçük yapar.");
	Console.WriteLine(sinem);
}
static void ToUpper()
{
	string sinem = "bu benim deneme alanım";
	sinem= sinem.ToUpper(); //Bütün harfleri büyük yapar.	
	Console.WriteLine($"input:bu benim deneme alanım - metod:ToUpper - Bütün harfleri büyük yapar.");
	Console.WriteLine(sinem);
}
static void Split()
{
	//sinem.Split(‘,’);= Kelimeler arasında ayraç olarak gösterdiğimiz ifadeyi algılar ve teker teker
	//kelimelerle işlem yapmamızı sağlayan metoddur.Aşağıdaki örneği inceleyiniz.
	string sinem = "bu,benim,deneme,alanım";
	string[] sinem2 = sinem.Split(',');
	Console.WriteLine($"input:bu benim deneme alanım - metod:Split - , ayraç olarak görür alt alta yazar.");//*metin2 dizi değişkenine Splitmetoduyla "," ayraç göstererek kelimeleri teker teker alıyorum.//
	for (int i = 0; i < sinem2.Length; i++)
	{
		Console.WriteLine(sinem2[i]);
	}
}
static void TrimMetod()
{
	string sinem = "   bu benim deneme alanım    ";
	sinem=sinem.Trim(); //metin değişkeninin başındaki ve sonundaki boşlukları siler.
	Console.WriteLine($"input:   bu benim deneme alanım    - metod:Trim - metin değişkeninin başındaki ve sonundaki boşlukları siler.");
	Console.WriteLine(sinem);
}
static void TrimEndMetod()
{
	string sinem = "bu benim deneme alanım   ";
	sinem=sinem.TrimEnd(); // metin değişkeninin sonundaki boşlukları siler.
	Console.WriteLine($"input:bu benim deneme alanım     - metod:TrimEnd - metin değişkeninin sonundaki boşlukları siler.");
	Console.WriteLine(sinem);
}
static void TrimStartMetod()
{
	string sinem = "    bu benim deneme alanım";
	sinem=sinem.TrimStart(); //metin değişkeninin başındaki boşlukları siler.
	Console.WriteLine($"input:    bu benim deneme alanım - metod:TrimStart - metin değişkeninin başındaki  boşlukları siler.");
	Console.WriteLine(sinem);
}
static void BoslukBirak()
{
	for (int i = 0; i < 100; i++)
	{
		Console.Write("=");
	}
	Console.WriteLine();
}





