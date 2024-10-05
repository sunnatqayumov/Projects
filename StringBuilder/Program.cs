using System.Text;

class Programm
{
    public static void Main()
    {
        string Matn = Console.ReadLine()!;
        StringBuilder builder = new StringBuilder(Matn);

        Console.WriteLine("\nDastlabki matn: ");
        Console.WriteLine("Matn: " + builder.ToString());
        Console.WriteLine("Dastlabki Matn uzunligi: {0}", builder.Length);
        Console.WriteLine($"Dastlabki matn Sig'imi: {builder.Capacity}");

        Console.WriteLine("\nMatnni Katta harflarda: ");
        Console.WriteLine(Matn.ToUpper());

        Console.WriteLine("\nMatn oxiriga yangi qoshimcha qo'shish:");
        builder.Append("Bu yangi qo'shimcha matn");
        Console.WriteLine(builder);

        Console.WriteLine("\nMatndan bir qismini o'chirish: ");
        Console.WriteLine("Qaysi indexdan boshlab o'chirishni xoxlaysiz (raqam kiriting): ");
        int son = int.Parse(Console.ReadLine()!);
        Console.WriteLine("O'chiriladigan belgilar soni: (raqam kiriting): ");
        int son1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine(builder.Remove(son, son1));

        Console.WriteLine("\nMatndan so'zni almashtirish: ");
        Console.WriteLine("Qaysi so'zni almashtirmoqchisiz: ");
        string input = Console.ReadLine()!;
        Console.WriteLine("Yangi so'zni kiriting: ");
        string input1 = Console.ReadLine()!;
        Console.WriteLine("Matn almashtirilgandan keyingi holat: " + builder.Replace(input, input1));

        Console.WriteLine("Yakuniy matn: " + builder);
        Console.WriteLine("Uzunligi " + builder.Length);
        Console.WriteLine("Sig'imi: " + builder.Capacity);
    }
}