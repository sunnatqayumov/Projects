class Programm
{
    static string talabaMalumotlari = "";

    static void Qosh(int id, string ism, string familiya, int yosh)
    {
        if(talabaMalumotlari == "")
        {
            talabaMalumotlari = $"{id},{ism},{familiya},{yosh}";
        }
        else
        {
            talabaMalumotlari += $";{id},{ism},{familiya},{yosh}";
        }
        Console.WriteLine("Talaba qo'shildi.");
    }

    static void Ochir(int id)
    {
        string[] talabalar = talabaMalumotlari.Split(';');
        string yangiMalumotlar = "";

        for(int i = 0; i < talabalar.Length; i++)
        {
            string[] malumotlar = talabalar[i].Split(',');

            if(int.Parse(malumotlar[0]) != id)
            {
                if(yangiMalumotlar != "")
                {
                    yangiMalumotlar += ";";
                }
                yangiMalumotlar += talabalar[i];
            }
        }
        talabaMalumotlari = yangiMalumotlar;
        Console.WriteLine("Talaba o'chirildi.");
    }

    static void Korsat()
    {
        if(talabaMalumotlari == "")
        {
            Console.WriteLine("Talabalar ro'yxati bo'sh.");
            return;
        }

        string[] talabalar = talabaMalumotlari.Split(';');

        for(int i = 0; i < talabalar.Length; i++)
        {
            string[] malumotlar = talabalar[i].Split(',');
            Console.WriteLine($"{malumotlar[0]} - {malumotlar[1]} {malumotlar[2]}, Yosh: {malumotlar[3]}");
        }
    }

    static void Main()
    {
        while(true)
        {
            Console.WriteLine("1. Talaba qo'shish");
            Console.WriteLine("2. Talabani o'chirish");
            Console.WriteLine("3. Talabalarni ko'rsatish");
            Console.WriteLine("4. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");
            string tanlov = Console.ReadLine()!;  

            switch(tanlov)
            {
                case "1":
                    Console.Write("Talaba ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Talaba ismi: ");
                    string ism = Console.ReadLine()!;
                    Console.Write("Talaba familiyasi: ");
                    string familiya = Console.ReadLine()!;
                    Console.Write("Talaba yoshi: ");
                    int yosh = Convert.ToInt32(Console.ReadLine());
                    Qosh(id, ism, familiya, yosh);
                    break;
                case "2":
                    Console.Write("O'chirilishi kerak bo'lgan talabaning IDsi: ");
                    int ochirID = Convert.ToInt32(Console.ReadLine());
                    Ochir(ochirID);
                    break;
                case "3":
                    Korsat();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, qaytadan urinib ko'ring.");
                    break;
            }
        }
    }
}