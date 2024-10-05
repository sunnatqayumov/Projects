class Programm
{
    public static string MySpaceship(string str)
    {
        int x = 0, y = 0;
        string direction = "";
        string[] arr = {"yuqori", "o'ng", "past", "chap"};
        int Index = 0;

        foreach(char ch in str)
        {
            if(ch == 'R')
            {
                Index = (Index + 1) % 4;
            }
            else if(ch == 'L')
            {
                Index = (Index + 3) % 4;
            }
            else if(ch == 'A')
            {
                if(arr[Index] == "yuqori")     y++;
                else if (arr[Index] == "past") y--;
                else if (arr[Index] == "o'ng") x++;
                else if (arr[Index] == "chap") x--;
            }
        }

        direction = arr[Index];
        return $"{{x: {x}, y: {y}, direction: '{direction}'}}";
    }

    public static void Main()
    {
        string input = Console.ReadLine()!;

        string result = MySpaceship(input);

        Console.WriteLine(result);
    }
}