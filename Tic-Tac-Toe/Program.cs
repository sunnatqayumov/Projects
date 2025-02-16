class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;
    static int choice;
    static int flag = 0; // 1 - yutdi, -1 - durang, 0 - davom etish

    public static void Main()
    {
        do
        {
            Console.WriteLine("O'yinchi 1: X va O'yinchi 2: O");
            Console.WriteLine("\n");

            Board(); //Chop etish

            Console.WriteLine($"\nO'yinchi {currentPlayer}, tanlang: ");
            choice = int.Parse(Console.ReadLine()!);

            //Katak balandligi
            if (board[choice - 1] != 'X')
            {
                if (board[choice - 1] != 'O')
                {
                    if (currentPlayer == 1)
                    {
                        board[choice - 1] = 'X';
                        currentPlayer = 2;
                    }
                    else
                    {
                        board[choice - 1] = 'O';
                        currentPlayer = 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bu joy band. Iltimos, boshqa joy tanlang.");
            }

            flag = CheckWin(); // G'olib yoki durangni tekshirish
        }while (flag == 0);

        Board(); //Chop etish

        if(flag == 1)
        {
            Console.WriteLine($"O'yinchi {currentPlayer - 1} g'olib bo'ldi!");
        }
        else if(flag == -1)
        {
            Console.WriteLine($"O'yinchi {currentPlayer} g'olib bo'ldi!");
        }
        else
        {
            Console.WriteLine("O'yin durrang bilan yakunlandi.");
        }
    }

    public static void Board()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]} ");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]} ");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]} ");
        Console.WriteLine("     |     |      ");
        Console.ResetColor();
    }

    public static int CheckWin()
    {
        // Gorizontal
        for (int i = 0; i < 9; i += 3)
        {
            if (board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                return 1;
        }
        // Vertikal
        for (int i = 0; i < 3; i++)
        {
            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                return 1;
        }
        // Diagonal
        if (board[0] == board[4] && board[4] == board[8])
            return 1;
        if (board[2] == board[4] && board[4] == board[6])
            return 1;
            
        // Durang
        for(int i = 0; i < 9; i++)
        {
            if(board[i] != 'X' && board[i] != 'O')
                return 0;
        }
        return -1;
    }
}