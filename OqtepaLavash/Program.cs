class OqTepaLavash
{
    public static void Main()
    {
        double umumiyNarx = 0;

        while(true)
        {
            Console.WriteLine("Oq Tepa Lavash Menyusi:");
            Console.WriteLine("1. Lavashlar");
            Console.WriteLine("2. Burgerlar");
            Console.WriteLine("3. Snaclar");
            Console.WriteLine("4. Ichimliklar");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");

            int tanlov = int.Parse(Console.ReadLine()!);

            if(tanlov == 1)
            {
                umumiyNarx += Lavash();
            }
            else if(tanlov == 2)
            {
                umumiyNarx += Burger();
            }
            else if(tanlov == 3)
            {
                umumiyNarx += Snaclar();
            }
            else if(tanlov == 4)
            {
                umumiyNarx += Ichimliklar();
            }
            else if(tanlov == 5)
            {
                Console.WriteLine($"Jami hisob: {umumiyNarx} so'm. Tanlovingiz uchun raxmat.");
                break;
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Qaytadan tanlang.");
            }
        }
    }

    static double Lavash()
    {
        double narx = 0;

        while (true)
        {
            Console.WriteLine("Lavashlar Menyusi:");
            Console.WriteLine("1. Tandir Lavash (15000 so'm)");
            Console.WriteLine("2. Mol Go'shtili Lavash (20000 so'm)");
            Console.WriteLine("3. Qo'y Go'shtili Lavash (22000 so'm)");
            Console.WriteLine("4. Tovuq Go'shtili Lavash (18000 so'm)");
            Console.WriteLine("5. Sirli Lavash (17000 so'm)");
            Console.WriteLine("6. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");

            int tanlov = int.Parse(Console.ReadLine()!);

            if(tanlov == 1)
            {
                narx += 15000;
            }
            else if(tanlov == 2)
            {
                narx += 20000;
            }
            else if(tanlov == 3)
            {
                narx += 22000;
            }
            else if(tanlov == 4)
            {
                narx += 18000;
            }
            else if(tanlov == 5)
            {
                narx += 17000;
            }
            else if(tanlov == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Qaytadan tanlang.");
            }
        }
        return narx;
    }

    static double Burger()
    {
        double narx = 0;

        while (true)
        {
            Console.WriteLine("Burgerlar Menyusi:");
            Console.WriteLine("1. Cheese Burger (18000 so'm)");
            Console.WriteLine("2. Chicken Burger (16000 so'm)");
            Console.WriteLine("3. Double Burger (25000 so'm)");
            Console.WriteLine("4. Chicken Cheese (20000 so'm)");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");

            int tanlov = int.Parse(Console.ReadLine()!);

            if(tanlov == 1)
            {
                narx += 18000;
            }
            else if(tanlov == 2)
            {
                narx += 16000;
            }
            else if(tanlov == 3)
            {
                narx += 25000;
            }
            else if(tanlov == 4)
            {
                narx += 20000;
            }
            else if(tanlov == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Qaytadan tanlang.");
            }
        }
        return narx;
    }

    static double Snaclar()
    {
        double narx = 0;

        while(true)
        {
            Console.WriteLine("Snaclar Menyusi:");
            Console.WriteLine("1. Kartoshka Free (5000 so'm)");
            Console.WriteLine("2. Dumaloq Kartoshka (7000 so'm)");
            Console.WriteLine("3. Derevyanskiy Kartoshka (8000 so'm)");
            Console.WriteLine("4. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");

            int tanlov = int.Parse(Console.ReadLine()!);

            if(tanlov == 1)
            {
                narx += 5000;
            }
            else if(tanlov == 2)
            {
                narx += 7000;
            }
            else if(tanlov == 3)
            {
                narx += 8000;
            }
            else if(tanlov == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Qaytadan tanlang.");
            }
        }
        return narx;
    }

    static double Ichimliklar()
    {
        double narx = 0;

        while(true)
        {
            Console.WriteLine("Ichimliklar Menyusi:");
            Console.WriteLine("1. Coca-Cola (4000 so'm)");
            Console.WriteLine("2. Fanta (4000 so'm)");
            Console.WriteLine("3. Sprite (4000 so'm)");
            Console.WriteLine("4. Pepsi (4000 so'm)");
            Console.WriteLine("5. Chiqish");
            Console.Write("Tanlovingizni kiriting: ");

            int tanlov = int.Parse(Console.ReadLine()!);

            if(tanlov == 1 || tanlov == 2 || tanlov == 3 || tanlov == 4)
            {
                narx += 4000;
            }
            else if(tanlov == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Qaytadan tanlang.");
            }
        }
        return narx;
    }
}