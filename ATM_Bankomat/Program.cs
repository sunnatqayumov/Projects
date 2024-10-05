    double balans = 0;

    Console.WriteLine("+-----------------------------------------+");
    Console.WriteLine("|                Language                 |");
    Console.WriteLine("+-----------------------------------------+");
    Console.WriteLine("| 1. Ingliz tili                          |");
    Console.WriteLine("| 2. Rus tili                             |");
    Console.WriteLine("| 3. Uzbek tili                           |");
    Console.WriteLine("+-----------------------------------------+");
    Console.Write("Tanlovingizni kiriting: ");

    int Tanlov = Convert.ToInt32(Console.ReadLine());

if(Tanlov == 1)
{
    for(int i = 0; i != 4; i++)
    {
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                 Simple ATM                |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|                 User Interface            |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |              ATM Menu               |  |");
        Console.WriteLine("|  |-------------------------------------|  |");
        Console.WriteLine("|  | 1. Check Balance                    |  |");
        Console.WriteLine("|  | 2. Deposit                          |  |");
        Console.WriteLine("|  | 3. Withdraw                         |  |");
        Console.WriteLine("|  | 4. Exit                             |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                     |                       ");
        Console.WriteLine("                     | User Input            ");
        Console.WriteLine("                     V                       ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                Main Programm              |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  balance = 0                              |");
        Console.WriteLine("|  choice = User Input                      |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |            Switch statement            |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  | 1. Check Balance    --> Display     |  |");
        Console.WriteLine("|  | 2. Deposit          --> Update      |  |");
        Console.WriteLine("|  | 3. Withdraw         --> Update      |  |");
        Console.WriteLine("|  | 4. Exit             --> Terminate   |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                       |                     ");
        Console.WriteLine("                       | Update Balance      ");
        Console.WriteLine("                       V                     ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|               Update Balance              |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  If depost: balance += deposite_amount    |");
        Console.WriteLine("|  If withdraw: balance -= withdrawal_amount|");
        Console.WriteLine("+-------------------------------------------+");
        Console.Write("Enter your Choice: ");
        int tanlov = Convert.ToInt32(Console.ReadLine());

        switch(tanlov)
        {
            case 1:
            Console.WriteLine("Your balance: " + balans);
            break;

            case 2:
            Console.WriteLine("Enter your name and your password: ");
            string name = Console.ReadLine()!;
            int password = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount of money: ");
            double depozit = Convert.ToDouble(Console.ReadLine());

            balans += depozit;
            balans -= depozit / 100;
            Console.WriteLine("Deposit made. New balance: " + balans);
            break;

            case 3:
            Console.WriteLine("Enter your name and your password: ");
            string name1 = Console.ReadLine()!;
            int password1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Withdrawal amount: ");
            double yechibOlish = Convert.ToDouble(Console.ReadLine());

            if(yechibOlish <= balans)
            {
                balans -= yechibOlish;
                balans -= yechibOlish / 100;
                Console.WriteLine("The money has been successfully withdrawn. Your new balance: " + balans);
            }
            else
            {
                Console.WriteLine("insufficient funds.");
            }
            break;

            case 4:
            Console.WriteLine("You have successfully logged out.");
            break;

            default:
            Console.WriteLine("Wrong choice. Please try again.");
            break;
        }
    }
}
else if(Tanlov == 2)
{
    for(int i = 0; i != 4; i++)
    {
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                 Простой АТМ               |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|         Ползовательский интерфейс         |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |              ATМ меню               |  |");
        Console.WriteLine("|  |-------------------------------------|  |");
        Console.WriteLine("|  | 1. проверить Баланс                 |  |");
        Console.WriteLine("|  | 2. Депозит                          |  |");
        Console.WriteLine("|  | 3. Снятие денег                     |  |");
        Console.WriteLine("|  | 4. Выход                            |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                     |                       ");
        Console.WriteLine("                     | ползовательский ввод  ");
        Console.WriteLine("                     V                       ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                Оснавная программа         |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  баланс = 0                               |");
        Console.WriteLine("|  Выбор = ползовательский ввод             |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |            Оператор переключения    |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  | 1. Проверить Баланс --> Дисплей     |  |");
        Console.WriteLine("|  | 2. Депозит          --> обновлять   |  |");
        Console.WriteLine("|  | 3. Снятие денег     --> обновлять   |  |");
        Console.WriteLine("|  | 4. Выход            --> прекратить  |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                       |                     ");
        Console.WriteLine("                       | Обнавить баланс     ");
        Console.WriteLine("                       V                     ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                 Обнавить баланс           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  Если депозит: баланс += депозит сумма    |");
        Console.WriteLine("|  Если снятие денег:                       |");
        Console.WriteLine("|  баланс -= Снятие денег сумма             |");
        Console.WriteLine("+-------------------------------------------+");
        Console.Write("Ввидите ваш вибор: ");
        int tanlov = Convert.ToInt32(Console.ReadLine());

        switch(tanlov)
        {
            case 1:
            Console.WriteLine("Ваш баланс: " + balans);
            break;

            case 2:
            Console.WriteLine("Ввидите ваш имя и пароль: ");
            string name = Console.ReadLine()!;
            int password = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввидите ваш депозит: ");
            double depozit = Convert.ToDouble(Console.ReadLine());

            balans += depozit;
            balans -= depozit / 100;
            Console.WriteLine("Депозит сделан. Ваш новый баланс: " + balans);
            break;

            case 3:
            Console.WriteLine("Ввидите ваш имя и пароль: ");
            string name1 = Console.ReadLine()!;
            int password1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сумма снятия денег: ");
            double yechibOlish = Convert.ToDouble(Console.ReadLine());

            if(yechibOlish <= balans)
            {
                balans -= yechibOlish;
                balans -= yechibOlish / 100;
                Console.WriteLine("Денги сняты успешно . Новый баланс: " + balans);
            }
            else
            {
                Console.WriteLine("Недостаточно средств.");
            }
            break;

            case 4:
            Console.WriteLine("Успешно вышли из система.");
            break;

            default:
            Console.WriteLine("Неправильный выбор. Пожалуйста попробуйте ещё раз.");
            break;
        }
    }
}
else if(Tanlov == 3)
{
    for(int i = 0; i != 4; i++)
    {
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                  Oddiy ATM                |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|           Foydalanuvchi Interfeysi        |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |              ATM Menyu              |  |");
        Console.WriteLine("|  |-------------------------------------|  |");
        Console.WriteLine("|  | 1. Balansni tekshirish              |  |");
        Console.WriteLine("|  | 2. Deposit                          |  |");
        Console.WriteLine("|  | 3. Pul yechib olish                 |  |");
        Console.WriteLine("|  | 4. Chiqish                          |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                     |                       ");
        Console.WriteLine("                     | Foydalanuvchi kiritish");
        Console.WriteLine("                     V                       ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|                Asosiy Programma           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  balansingiz = 0                          |");
        Console.WriteLine("|  tanlov = foydalanuvchi kiritish          |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  |         Almashtirish bayonoti       |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|  | 1. Balansni tekshirish --> Displey  |  |");
        Console.WriteLine("|  | 2. Depasit          --> Yangilash   |  |");
        Console.WriteLine("|  | 3. Pul yechish      --> Yangilash   |  |");
        Console.WriteLine("|  | 4. Chiqish          --> Tugatish    |  |");
        Console.WriteLine("|  +-------------------------------------+  |");
        Console.WriteLine("|                                           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("                       |                     ");
        Console.WriteLine("                       | Balansni yangilash  ");
        Console.WriteLine("                       V                     ");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|               Balansni yangilash          |");
        Console.WriteLine("+-------------------------------------------+");
        Console.WriteLine("|  Agar depozit: balans += deposit_miqdor   |");
        Console.WriteLine("|  Agar yechilgan pul:                      |");
        Console.WriteLine("|  balans -= Yechilgan pul_miqdor           |");
        Console.WriteLine("+-------------------------------------------+");
        Console.Write("Tanlovingizni kiriting: ");
        int tanlov = Convert.ToInt32(Console.ReadLine());

        switch(tanlov)
        {
            case 1:
            Console.WriteLine("Balansingiz: " + balans);
            break;

            case 2:
            Console.WriteLine("Ismingizni va parolni kiriting: ");
            string name = Console.ReadLine()!;
            int password = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pul qo'yish miqdorini kiriting: ");
            double depozit = Convert.ToDouble(Console.ReadLine());

            balans += depozit;
            balans -= depozit / 100;
            Console.WriteLine("Depozit amalga oshirildi. Yangi balansingiz: " + balans);
            break;

            case 3:
            Console.WriteLine("Ismingizni va parolni kiriting: ");
            string name1 = Console.ReadLine()!;
            int password1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yechib olish miqdori: ");
            double yechibOlish = Convert.ToDouble(Console.ReadLine());

            if(yechibOlish <= balans)
            {
                balans -= yechibOlish;
                balans -= yechibOlish / 100;
                Console.WriteLine("Pul muvaffaqiyatli yechib olindi. Yangi balansingiz: " + balans);
            }
            else
            {
                Console.WriteLine("Mablag' yetarli emas.");
            }
            break;

            case 4:
            Console.WriteLine("Tizimdan muvaffaqiyatli chiqdingiz.");
            break;

            default:
            Console.WriteLine("Notog'ri tanlov. Iltimos qaytadan urinib ko'ring.");
            break;
        }
    }
}