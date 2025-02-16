public struct Olchov
{
    public string OlchovTuri;
    public double Hajmi;

    public Olchov(string olchovTuri, double hajmi)
    {
        OlchovTuri = olchovTuri;
        Hajmi = hajmi;
    }

    public override string ToString()
    {
        return $"{Hajmi} {OlchovTuri}";
    }
}

public class Mahsulot
{
    public string Nom { get; set; }
    public string Kod { get; set; }
    public double Narx { get; set; }
    public int Miqdor { get; set; }
    public Olchov OlchovBirligi { get; set; }

    public Mahsulot(string nom, string kod, double narx, int miqdor, Olchov olchovBirligi)
    {
        Nom = nom;
        Kod = kod;
        Narx = narx;
        Miqdor = miqdor;
        OlchovBirligi = olchovBirligi;
    }

    public override string ToString()
    {
        return $"Nom: {Nom}, Kod: {Kod}, Narx: {Narx}, Miqdor: {Miqdor}, O'lchov: {OlchovBirligi}";
    }
}
public class InventarTizimi
{
    public List<Mahsulot> mahsulotlar = new List<Mahsulot>();

    public void MahsulotQoshish(Mahsulot mahsulot)
    {
        mahsulotlar.Add(mahsulot);
        Console.WriteLine("Mahsulot qo'shildi.");
    }

    public void MahsulotOchirish(string kod)
    {
        var mahsulot = mahsulotlar.Find(m => m.Kod == kod);
        if(mahsulot != null)
        {
            mahsulotlar.Remove(mahsulot);
            Console.WriteLine("Mahsulot o'chirildi.");
        }
        else
        {
            Console.WriteLine("Mahsulot topilmadi.");
        }
    }

    public void MahsulotQidirish(string kod)
    {
        var mahsulot = mahsulotlar.Find(m => m.Kod == kod);
        if(mahsulot != null)
        {
            Console.WriteLine(mahsulot);
        }
        else
        {
            Console.WriteLine("Mahsulot topilmadi.");
        }
    }

    public void MahsulotlarRoyxati()
    {
        Console.WriteLine("Mahsulotlar ro'yxati:");
        foreach (var mahsulot in mahsulotlar)
        {
            Console.WriteLine(mahsulot);
        }
    }
}
class Program
{
    static void Main()
    {
        InventarTizimi tizim = new InventarTizimi();
        while(true)
        {
            Console.WriteLine("\nMahsulot Inventar Tizimi");
            Console.WriteLine("1. Mahsulot qo'shish");
            Console.WriteLine("2. Mahsulotni o'chirish");
            Console.WriteLine("3. Mahsulotni qidirish");
            Console.WriteLine("4. Mahsulotlar ro'yxatini ko'rish");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlang: ");
            string tanlov = Console.ReadLine()!;

            switch (tanlov)
            {
                case "1":
                    MahsulotQoshish(tizim);
                    break;
                case "2":
                    MahsulotOchirish(tizim);
                    break;
                case "3":
                    MahsulotQidirish(tizim);
                    break;
                case "4":
                    tizim.MahsulotlarRoyxati();
                    break;
                case "5":
                    Console.WriteLine("Dasturdan chiqildi.");
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov, qayta urinib ko'ring.");
                    break;
            }
        }
    }

    static void MahsulotQoshish(InventarTizimi tizim)
    {
        Console.Write("Mahsulot nomi: ");
        string nom = Console.ReadLine()!;

        Console.Write("Mahsulot kodi: ");
        string kod = Console.ReadLine()!;

        Console.Write("Narxi: ");
        if (!double.TryParse(Console.ReadLine(), out double narx))
        {
            Console.WriteLine("Noto'g'ri narx kiritildi.");
            return;
        }

        Console.Write("Miqdori: ");
        if (!int.TryParse(Console.ReadLine(), out int miqdor))
        {
            Console.WriteLine("Noto'g'ri miqdor kiritildi.");
            return;
        }

        Console.Write("O'lchov turi (masalan: kg, litr): ");
        string olchovTuri = Console.ReadLine()!;

        Console.Write("Hajmi: ");
        if (!double.TryParse(Console.ReadLine(), out double hajmi))
        {
            Console.WriteLine("Noto'g'ri hajm kiritildi.");
            return;
        }

        Olchov olchov = new Olchov(olchovTuri, hajmi);
        Mahsulot mahsulot = new Mahsulot(nom, kod, narx, miqdor, olchov);
        tizim.MahsulotQoshish(mahsulot);
    }

    static void MahsulotOchirish(InventarTizimi tizim)
    {
        Console.Write("O'chirish uchun mahsulot kodi: ");
        string kod = Console.ReadLine()!;
        tizim.MahsulotOchirish(kod);
    }

    static void MahsulotQidirish(InventarTizimi tizim)
    {
        Console.Write("Qidirish uchun mahsulot kodi: ");
        string kod = Console.ReadLine()!;
        tizim.MahsulotQidirish(kod);
    }
}