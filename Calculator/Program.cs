class Program
    {
        static void Main()
        {
            bool Continue = true;
            string history = "";

            while(Continue)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Perform a calculation");
                Console.WriteLine("2. View calculation history");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int tanlov = Convert.ToInt32(Console.ReadLine()!);

                switch(tanlov)
                {
                    case 1:
                        Console.Write("Enter the first number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine()!);
                        Console.Write("Enter the second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine()!);
                        Console.WriteLine("Choose an operation (+, -, *, /): ");
                        string operation = Console.ReadLine()!;

                        double result = 0;

                        switch(operation)
                        {
                            case "+":
                                result = num1 + num2;
                                break;
                            case "-":
                                result = num1 - num2;
                                break;
                            case "*":
                                result = num1 * num2;
                                break;
                            case "/":
                                if(num2 == 0)
                                {
                                    Console.WriteLine("Cannot divide by 0!");
                                    break;
                                }
                                result = num1 / num2;
                            break;
                            
                            default:
                                Console.WriteLine("Invalid operation. Please try again.");
                            break;
                        }

                            Console.WriteLine("Result: " + result);
                            history += $"{num1} {operation} {num2} = {result}\n";
                    break;

                    case 2:
                        if(history == "")
                        {
                            Console.WriteLine("Calculation history is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Calculation history:");
                            Console.WriteLine(history);
                        }
                    break;

                    case 3:
                        Continue = false;
                        Console.WriteLine("Exiting...");
                    break;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                    break;
                }
            }
        }
    }