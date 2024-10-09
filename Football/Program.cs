using System;

public struct Futbolchi
{
    public string Ism { get; set; }
    public int Yoshi { get; set; }
    public string Pozitsiya { get; set; }
    public int Gollar { get; set; }

    public Futbolchi(string ism, int yoshi, string pozitsiya)
    {
        Ism = ism;
        Yoshi = yoshi;
        Pozitsiya = pozitsiya;
        Gollar = 0;
    }

    public void GolUrish()
    {
        ++Gollar;
    }

    public void ChopEtish()
    {
        Console.WriteLine($"Futbolchi: {Ism}, Yoshi: {Yoshi}, Pozitsiyasi: {Pozitsiya}, Gollar: {Gollar}");
    }
}

public class Jamoa
{
    public string Nomi { get; set; }
    private Futbolchi[] futbolchilar;
    private int futbolchiSoni;

    public Jamoa(string nomi, int maksimalFutbolchiSoni)
    {
        Nomi = nomi;
        futbolchilar = new Futbolchi[maksimalFutbolchiSoni];
        futbolchiSoni = 0;
    }
    public void FutbolchiQoshish(Futbolchi futbolchi)
    {
        if(futbolchiSoni < futbolchilar.Length)
        {
            futbolchilar[futbolchiSoni] = futbolchi;
            futbolchiSoni++;
        }
        else
        {
            Console.WriteLine("Jamoa to'la, yangi futbolchi qo'shishning iloji yo'q.");
        }
    }

    public void StatistikaChopEtish()
    {
        Console.WriteLine($"Jamoa: {Nomi}");

        for(int i = 0; i < futbolchiSoni; i++)
        {
            futbolchilar[i].ChopEtish();
        }
    }

    public int UmumiyGollar()
    {
        int umumiyGollar = 0;

        for(int i = 0; i < futbolchiSoni; i++)
        {
            umumiyGollar += futbolchilar[i].Gollar;
        }
        return umumiyGollar;
    }
}

public class Program
{
    public static void Main()
    {
        Jamoa jamoa = new Jamoa("Barcelona", 2);

        Futbolchi futbolchi1 = new Futbolchi("Lionel Messi", 36, "Hujumchi");
        Futbolchi futbolchi2 = new Futbolchi("Marc Ter Stegen", 31, "Darvozabon");

        jamoa.FutbolchiQoshish(futbolchi1);
        jamoa.FutbolchiQoshish(futbolchi2);

        futbolchi1.GolUrish();
        futbolchi1.GolUrish();

        jamoa.StatistikaChopEtish();
        Console.WriteLine($"Umumiy Gollar: {jamoa.UmumiyGollar()}");
    }
}
