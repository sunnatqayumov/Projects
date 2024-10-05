class Programm
{
    public static void Main()
    {
        Random rndm = new Random();

        int[] kod = new int[4];

        for(int i = 0; i < 4; i++)
        {
            kod[i] = rndm.Next(1, 10);
        }
        int urinishlar = 10;

        while(urinishlar > 0)
        {
            Console.WriteLine("Qolgan urinishlar: " + urinishlar);
            Console.Write("Kodni taxmin qiling (4 ta raqam): ");
            string kirish = Console.ReadLine()!;

            if(kirish.Length != 4)
            {
                Console.WriteLine("Iltimos, to'g'ri kod kiriting (4 ta raqam).");
            }

            int[] taxmin = new int[4];

            for(int i = 0; i < 4; i++)
            {
                taxmin[i] = int.Parse(kirish[i].ToString());
            }

            int togriJoylashgan = 0;

            for(int i = 0; i < 4; i++)
            {
                if(taxmin[i] == kod[i])
                {
                    togriJoylashgan++;
                }
            }

            int togriRaqam = 0;

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if(taxmin[i] == kod[j] && i != j)
                    {
                        togriRaqam++;
                        break;
                    }
                }
            }
            Console.WriteLine("To'g'ri joylashgan raqamlar: {0}", togriJoylashgan);
            Console.WriteLine("To'g'ri, lekin noto'g'ri joylashgan raqamlar: {0}", togriRaqam);

            if(togriJoylashgan == 4)
            {
                Console.WriteLine("Tabriklaymiz! Siz g'alaba qozondingiz!");
                break;
            }
            urinishlar--;
        }

        if(urinishlar == 0)
        {
            Console.WriteLine("Urinishlar tugadi. To'g'ri kod: {0}", string.Join("", kod));
        }
        Console.ReadKey();
    }
}