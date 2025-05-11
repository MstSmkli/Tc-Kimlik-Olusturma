using System;
using System.Threading;

class Program
{
	static void Main(string[] args)
	{
		Baslangic();
		Cikti(TC);
	}

	static string TC;

	static void Baslangic()
	{
		Console.Write("Adınızı giriniz: ");
		string ad = Console.ReadLine();
		string adBuyuk = ad.ToUpper();
		Console.WriteLine($"MERHABA {adBuyuk}, TC KİMLİK NUMARANIZ OLUŞTURULUYOR...");
		Thread.Sleep(5000);
		int ilkDeger = IlkDeger();
		TC = TCOlustur(ilkDeger);
	}

	static int IlkDeger()
	{
		Random rand = new Random();
		return rand.Next(1, 10);
	}

	static string TCOlustur(int ilkDeger)
	{
		int[] tcArray = new int[11];
		Random rand = new Random();
		tcArray[0] = ilkDeger;

		for (int i = 1; i < 9; i++)
		{
			tcArray[i] = rand.Next(0, 10);
		}

		int toplam = 0;
		for (int i = 0; i < 10; i++)
		{
			toplam += tcArray[i];
		}

		tcArray[9] = toplam % 10;

		int sonHane = toplam % 10;
		if (sonHane % 2 != 0)
		{
			sonHane = (sonHane + 1) % 10;
		}
		tcArray[10] = sonHane;

		return string.Join("", tcArray);
	}

	static void Cikti(string tc)
	{
		Console.WriteLine($"OLUŞTURULAN TC KİMLİK NUMARASI: {tc}");
	}
}
