public struct Manzil
{
    public string Kocha { get; set; }
    public string Shahar { get; set; }
    public int PochtaIndeksi { get; set; }

    public Manzil(string kocha, string shahar, int pochtaIndeksi)
    {
        Kocha = kocha;
        Shahar = shahar;
        PochtaIndeksi = pochtaIndeksi;
    }

    public string ToString()
    {
        return $"{Kocha}, {Shahar}, {PochtaIndeksi}";
    }
}

public class Xodim
{
    public string Ism { get; set; }
    public string Familiya { get; set; }
    public DateTime TugilganSana { get; set; }
    public string Lavozim { get; set; }
    public double IshHaqi { get; set; }
    public Manzil Manzil { get; set; }

    public Xodim(string ism, string familiya, DateTime tugilganSana, string lavozim, double ishHaqi, Manzil manzil)
    {
        Ism = ism;
        Familiya = familiya;
        TugilganSana = tugilganSana;
        Lavozim = lavozim;
        IshHaqi = ishHaqi;
        Manzil = manzil;
    }

    public string ToString()
    {
        return $"Ism: {Ism}, Familiya: {Familiya}, Tugilgan Sana: {TugilganSana.ToShortDateString()}, Lavozim: {Lavozim}, Ish Haqi: {IshHaqi}, Manzil: {Manzil}";
    }
}

public class Program
{
    static List<Xodim> xodimlarBazasi = new List<Xodim>();

    public static void Main()
    {
        XodimlarQoshish();

        while(true)
        {
            string tanlov = Console.ReadLine()!;
            switch (tanlov)
            {
                case "1":
                    XodimlarniKorish();
                    break;
                case "2": //Lavozim bo'yicha qidirish
                    break;
                case "3":
                    YangiXodimQoshish();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov, qaytadan kiriting!");
                    break;
            }
        }
    }
    public static void XodimlarQoshish()
    {
        xodimlarBazasi.Add(new Xodim("Sunnat", "Qayumov", new DateTime(2007, 2, 8), "Dasturchi", 5000, new Manzil("Beruniy", "Toshkent", 777777)));
        xodimlarBazasi.Add(new Xodim("Fera", "Mukhsimov", new DateTime(2008, 4, 8), "Dizayner Dasturchi", 3500, new Manzil("Beruniy 41", "Toshkent", 111111)));
    }
    public static void XodimlarniKorish()
    {
        foreach(var xodim in xodimlarBazasi)
        {
            Console.WriteLine(xodim);
        }
    }
    public static void YangiXodimQoshish()
    {
        Console.WriteLine("Yangi xodim uchun ma'lumotlarni kiriting:");

        Console.Write("Ismi: ");
        string ism = Console.ReadLine()!;

        Console.Write("Familiyasi: ");
        string familiya = Console.ReadLine()!;

        Console.Write("Tug'ilgan sana: ");
        DateTime tugilganSana = DateTime.Parse(Console.ReadLine()!);

        Console.Write("Lavozimi: ");
        string lavozim = Console.ReadLine()!;

        Console.Write("Ish haqi: ");
        double ishHaqi = double.Parse(Console.ReadLine()!);

        Console.Write("Ko'cha: ");
        string kocha = Console.ReadLine()!;

        Console.Write("Shahar: ");
        string shahar = Console.ReadLine()!;

        Console.Write("Pochta indeksi: ");
        int pochtaIndeksi = int.Parse(Console.ReadLine()!);

        Manzil manzil = new Manzil(kocha, shahar, pochtaIndeksi);

        Xodim yangiXodim = new Xodim(ism, familiya, tugilganSana, lavozim, ishHaqi, manzil);
        xodimlarBazasi.Add(yangiXodim);

        Console.WriteLine("Yangi xodim qo'shildi.");
    }
}