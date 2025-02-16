using PersonManagementSystem;

namespace PersonManagementSystem
{
    interface IPerson
    {
        void DisplayInfo();
        int CalculateAge();
    }
    class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {FirstName}, Familiya: {LastName}, Yosh: {CalculateAge()}");
        }
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if(DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
    class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, DateTime birthDate, string position, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {FirstName}, Familiya: {LastName}, Yosh: {CalculateAge()}");
            Console.WriteLine($"Lavozim: {Position}, Ish haqi: {Salary:C}");
        }
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if(DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
    class Manager : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Team { get; set; }
        public Manager(string firstName, string lastName, DateTime birthDate, string position, decimal salary, string team)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
            Team = team;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Ism: {FirstName}, Familiya: {LastName}, Yosh: {CalculateAge()}");
            Console.WriteLine($"Lavozim: {Position}, Ish haqi: {Salary:C}");
            Console.WriteLine($"Jamoa: {Team}");
        }
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            if(DateTime.Now.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }
    }
    class Program
    {
        public static void Main()
        {
            Person person = new Person("Ali", "Karimov", new DateTime(1995, 5, 12));
            person.DisplayInfo();

            Employee employee = new Employee("Olim", "Oripov", new DateTime(1990, 3, 8), "Dasturchi", 1500);
            employee.DisplayInfo();

            Manager manager = new Manager("Aziza", "Yusupova", new DateTime(1985, 7, 19), "Boshliq", 2500, "Katta va tajribali jamoa");
            manager.DisplayInfo();
        }
    }
}