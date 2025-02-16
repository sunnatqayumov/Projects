using System;
using Spectre.Console;
using System.Collections.Generic;

namespace FamilyManagementSystemSpectre
{
    public class FamilyMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Job { get; set; }
        public decimal Income { get; set; }

        public FamilyMember(string name, string surname, DateTime birthDate, string job, decimal income)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Job = job;
            Income = income;
        }
    }
    public class Expense
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Expense(string category, decimal amount, string description)
        {
            Category = category;
            Amount = amount;
            Description = description;
        }
    }
    public class FamilyManagementSystem
    {
        private List<FamilyMember> familyMembers = new List<FamilyMember>();
        private List<Expense> expenses = new List<Expense>();

        public void AddFamilyMember(FamilyMember member)
        {
            familyMembers.Add(member);
        }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public void DisplayFamilyMembers()
        {
            AnsiConsole.MarkupLine("[bold yellow]Family Members:[/]");

            var table = new Table();
            table.AddColumn("[cyan]Name[/]");
            table.AddColumn("[cyan]Surname[/]");
            table.AddColumn("[cyan]Birth Date[/]");
            table.AddColumn("[cyan]Job[/]");
            table.AddColumn("[cyan]Income[/]");

            foreach (var member in familyMembers)
            {
                table.AddRow(member.Name, member.Surname, member.BirthDate.ToShortDateString(), member.Job, $"{member.Income:C}");
            }

            AnsiConsole.Render(table);
        }

        public void DisplayExpenses()
        {
            AnsiConsole.MarkupLine("[bold yellow]Expenses:[/]");

            var table = new Table();
            table.AddColumn("[bold cyan]Category[/]");
            table.AddColumn("[bold cyan]Amount[/]");
            table.AddColumn("[bold cyan]Description[/]");

            foreach (var expense in expenses)
            {
                table.AddRow(expense.Category, $"{expense.Amount:C}", expense.Description);
            }

            AnsiConsole.Render(table);
        }

        public void GenerateFinancialReport()
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            foreach (var member in familyMembers)
            {
                totalIncome += member.Income;
            }

            foreach (var expense in expenses)
            {
                totalExpenses += expense.Amount;
            }

            AnsiConsole.MarkupLine($"[bold green]Jami daromad: {totalIncome:C}[/]");
            AnsiConsole.MarkupLine($"[bold green]Jami xarajatlar: {totalExpenses:C}[/]");

            decimal balance = totalIncome - totalExpenses;
            AnsiConsole.MarkupLine(balance >= 0
                ? $"[bold green]Balance: {balance:C}[/]"
                : $"[bold red]Balance: {balance:C}[/]");
        }
    }

    class Program
    {
        static FamilyManagementSystem system = new FamilyManagementSystem();

        static void Main()
        {
            AnsiConsole.Write(
                new FigletText("Family Management System")
                    .Centered()
                    .Color(Color.Aqua));

            AnsiConsole.MarkupLine("[bold yellow]Welcome to the Family Management System![/]");

            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    var task = ctx.AddTask("[yellow]Loading system...[/]");

                    while (!ctx.IsFinished)
                    {
                        task.Increment(20);
                        Thread.Sleep(300);
                    }
                });
                AnsiConsole.MarkupLine("[green]System successfully loaded![/]");

            while (true)
            {
                var option = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[bold yellow]Select an option:[/]")
                        .AddChoices(new[] 
                        {
                            "Add Family Member",
                            "Add Expense",
                            "View Family Members",
                            "View Expenses",
                            "Generate Financial Report",
                            "Exit"
                        }));

                switch (option)
                {
                    case "Add Family Member":
                        AddFamilyMember();
                        break;

                    case "Add Expense":
                        AddExpense();
                        break;

                    case "View Family Members":
                        system.DisplayFamilyMembers();
                        break;

                    case "View Expenses":
                        system.DisplayExpenses();
                        break;

                    case "Generate Financial Report":
                        system.GenerateFinancialReport();
                        break;

                    case "Exit":
                        AnsiConsole.MarkupLine("[bold red]Exiting the application...[/]");
                        return;

                    default:
                        AnsiConsole.MarkupLine("[bold red]Invalid option selected. Please try again.[/]");
                        break;
                }

                AnsiConsole.MarkupLine("[green]Press any key to return to the main menu...[/]");
                Console.ReadKey(intercept: true);
            }
        }

        static void AddFamilyMember()
        {
            Console.WriteLine("Adding a new family member");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter Lastname: ");
            string surname = Console.ReadLine()!;

            Console.Write("Enter Birth Date (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Enter Job: ");
            string job = Console.ReadLine()!;

            Console.Write("Enter Income: ");
            decimal income = decimal.Parse(Console.ReadLine()!);

            system.AddFamilyMember(new FamilyMember(name, surname, birthDate, job, income));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Family member added successfully!");
            Console.ResetColor();
        }

        static void AddExpense()
        {
            Console.WriteLine("Adding a new expense");
            Console.Write("Enter Expense Category: ");
            string category = Console.ReadLine()!;

            Console.Write("Enter Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine()!);

            Console.Write("Enter Description: ");
            string description = Console.ReadLine()!;

            system.AddExpense(new Expense(category, amount, description));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Expense added successfully!");
            Console.ResetColor();
        }
    }
}