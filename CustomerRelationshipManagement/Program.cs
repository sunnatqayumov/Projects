using System;
using System.Collections.Generic;
using Spectre.Console;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }

    protected Person(string firstName, string lastName, string email, string position)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Position = position;
    }
}
public class Customer : Person, ISalable
{
    public string IDSerialNumber { get; set; }
    public string Company { get; set; }
    public decimal TotalSales { get; set; }

    public Customer(string firstName, string lastName, string email, string position, string idSerialNumber, string company)
        : base(firstName, lastName, email, position)
    {
        IDSerialNumber = idSerialNumber;
        Company = company;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} - {Email} - Lavozim: {Position} - ID: {IDSerialNumber} - Kompaniya: {Company} - Savdo soni: {TotalSales}";
    }

    void ISalable.AddSale(decimal amount)
    {
        TotalSales += amount;
    }
    decimal ISalable.GetSales()
    {
        return TotalSales;
    }
}
public interface ISalable
{
    void AddSale(decimal amount);
    decimal GetSales();
}
public class CRMSystem
{
    public List<Customer> customers = new List<Customer>();

    public void Menu()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("CRM Management")
                .Centered()
                .Color(Color.Yellow));

        while(true)
        {
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[yellow]Bosh menyuga xush kelibsiz![/]")
                    .PageSize(10)
                    .AddChoices("Mijozlar", "Mahsulotlar", "Mijozlarni Ko'rish", "Mahsulotlarni Ko'rish", "Qidirish", "Muhim Savdolar", "Chiqish"));

            switch(choice)
            {
                case "Mijozlar":
                    CustomerMenu();
                    break;
                case "Mahsulotlar":
                    ProductMenu();
                    break;
                case "Mijozlarni Ko'rish":
                    CustomerInfo();
                    break;
                case "Mahsulotlarni Ko'rish":
                    ProductInfo();
                    break;
                case "Qidirish":
                    SearchCustomers();
                    break;
                case "Muhim Savdolar":
                    ImportantSales();
                    break;
                case "Chiqish":
                    return;
            }
        }
    }

    public void CustomerMenu()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Mijozlar")
                    .Centered()
                    .Color(Color.Maroon));

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[yellow]Mijozlar menyusi:[/]")
                .AddChoices("Mijoz Qo'shish", "Mijoz Yangilash", "Mijoz O'chirish", "Orqaga"));

        switch (choice)
        {
            case "Mijoz Qo'shish":
                AddCustomer();
                break;
            case "Mijoz Yangilash":
                UpdateCustomer();
                break;
            case "Mijoz O'chirish":
                DeleteCustomer();
                break;
            case "Orqaga":
                return;
        }
    }

    public void ProductMenu()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Mahsulotlar")
                .Centered()
                .Color(Color.Maroon));

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[yellow]Mahsulotlar menyusi:[/]")
                .AddChoices("Savdoni Ro'yxatdan O'tkazish", "Savdoni Yangilash", "Orqaga"));

        switch(choice)
        {
            case "Savdoni Ro'yxatdan O'tkazish":
                RegisterSale();
                break;
            case "Savdoni Yangilash":
                UpdateSale();
                break;
            case "Orqaga":
                return;
        }
    }

    public void AddCustomer()
    {
        Console.Clear();
        AnsiConsole.Write(
                new FigletText("Mijoz qo'shish")
                .Centered()
                .Color(Color.Maroon));

        Console.WriteLine("Ismni kiriting:");
        var firstName = Console.ReadLine()!;

        Console.WriteLine("Familiyani kiriting:");
        var lastName = Console.ReadLine()!;

        Console.WriteLine("Emailni kiriting:");
        var email = Console.ReadLine()!;

        Console.WriteLine("Lavozimni kiriting:");
        var position = Console.ReadLine()!;

        Console.WriteLine("ID Seriya raqamini kiriting:");
        var idSerialNumber = Console.ReadLine()!;

        Console.WriteLine("Kompaniya nomini kiriting:");
        var company = Console.ReadLine()!;

        var customer = new Customer(firstName, lastName, email, position, idSerialNumber, company);

        customers.Add(customer);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Mijoz muvaffaqiyatli qo'shildi!");
        Console.ResetColor();
    }
    public void CustomerInfo()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Mijozlarni ko'rish")
                .Centered()
                .Color(Color.Maroon));

        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[yellow]Ism[/]");
        table.AddColumn("[yellow]Familiya[/]");
        table.AddColumn("[yellow]Email[/]");
        table.AddColumn("[yellow]Lavozim[/]");
        table.AddColumn("[yellow]ID Seriya Raqami[/]");
        table.AddColumn("[yellow]Kompaniya[/]");

        foreach (var customer in customers)
        {
            table.AddRow(customer.FirstName, customer.LastName, customer.Email, customer.Position, customer.IDSerialNumber, customer.Company);
        }
        AnsiConsole.Write(table);
    }

    public void ProductInfo()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Mahsulotlarni ko'rish")
                .Centered()
                .Color(Color.Maroon));
    }

    public void SearchCustomers()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Qidirish")
                .Centered()
                .Color(Color.Maroon));
        
        Console.Write("Qidirish uchun ism, familiya, email yoki ID ni kiriting: ");
        var query = Console.ReadLine()!;

        var results = new List<Customer>();

        foreach (var customer in customers)
        {
            if (customer.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(customer);
            }
            else if (customer.LastName.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(customer);
            }
            else if (customer.Email.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(customer);
            }
            else if (customer.IDSerialNumber.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(customer);
            }
        }
        if(results.Count > 0)
        {
            var table = new Table();
            table.Border(TableBorder.Rounded);

            table.AddColumn("[yellow]Ism[/]");
            table.AddColumn("[yellow]Familiya[/]");
            table.AddColumn("[yellow]Email[/]");
            table.AddColumn("[yellow]Lavozim[/]");
            table.AddColumn("[yellow]ID Seriya Raqami[/]");
            table.AddColumn("[yellow]Kompaniya[/]");

            foreach (var customer in results)
            {
                table.AddRow(customer.FirstName, customer.LastName, customer.Email, customer.Position, customer.IDSerialNumber, customer.Company);
            }
            AnsiConsole.Write(table);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hech qanday natija topilmadi.[/]");
            Console.ResetColor();
        }
    }

    public void ImportantSales()
    {
        Console.Clear();
            AnsiConsole.Write(
                new FigletText("Muhim savdolar")
                    .Centered()
                    .Color(Color.Maroon));
    }

    private void UpdateCustomer()
    {
        Console.Clear();
            Console.Clear();
            AnsiConsole.Write(
                new FigletText("Mijozni yangilash")
                    .Centered()
                    .Color(Color.Maroon));

        Console.Write("Yangilash uchun mijoz emailini kiriting: ");
        var email = Console.ReadLine()!;

        Customer customer = null!;

        foreach (var c in customers)
        {
            if (c.Email == email)
            {
                customer = c;
                break;
            }
        }

        if(customer != null)
        {
            Console.WriteLine("Mijoz topildi!");
            Console.WriteLine("Hozirgi ma'lumotlar: ");
            Console.WriteLine($"Ism: {customer.FirstName}");
            Console.WriteLine($"Familiya: {customer.LastName}");
            Console.WriteLine($"Lavozim: {customer.Position}");
            Console.WriteLine($"ID Seriya Raqami: {customer.IDSerialNumber}");
            Console.WriteLine($"Kompaniya: {customer.Company}");
            Console.WriteLine();

            Console.Write("Yangi ismni kiriting: ");
            customer.FirstName = Console.ReadLine()!;

            Console.Write("Yangi familiyani kiriting: ");
            customer.LastName = Console.ReadLine()!;

            Console.Write("Yangi lavozimni kiriting: ");
            customer.Position = Console.ReadLine()!;

            Console.Write("Yangi ID seriya raqamini kiriting: ");
            customer.IDSerialNumber = Console.ReadLine()!;

            Console.Write("Yangi kompaniya nomini kiriting: ");
            customer.Company = Console.ReadLine()!;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mijoz muvaffaqiyatli yangilandi!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Mijoz topilmadi.");
        }
    }


    private void DeleteCustomer()
    {
        Console.Clear();
        AnsiConsole.Write(
                new FigletText("Mijoz o'chirish")
                .Centered()
                .Color(Color.Maroon));

        Console.Write("O'chirish uchun mijoz emailini kiriting: ");
        var email = Console.ReadLine();

        Customer customer = null!;

        foreach (var c in customers)
        {
            if(c.Email == email)
            {
                customer = c;
                break;
            }
        }

        if(customer != null)
        {
            customers.Remove(customer);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mijoz o'chirildi!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mijoz topilmadi.");
            Console.ResetColor();
        }
    }

    public void RegisterSale()
    {
        Console.Clear();
        AnsiConsole.Write(
            new FigletText("Savdoni Ro'yxatdan o'tkazish")
            .Centered()
            .Color(Color.Maroon));

        Console.WriteLine("Savdo qo'shish uchun mijoz emailini kiriting: ");
        var email = Console.ReadLine();

        Customer customer = null!;

        foreach(var c in customers)
        {
            if(c.Email == email)
            {
                customer = c;
                break;
            }
        }

        if (customer == null)
        {
            Console.WriteLine("Mijoz topilmadi!");
            return;
        }

        Console.WriteLine("Savdo miqdorini kiriting: ");
        var amountInput = Console.ReadLine()!;

        Console.WriteLine($"Savdo muvaffaqiyatli ro'yxatdan o'tkazildi! Mijoz: {customer.FirstName} {customer.LastName}, Miqdori: {amountInput} so'm.");
    }

    private void UpdateSale()
    {
        Console.Clear();
        AnsiConsole.Write(
            new FigletText("Savdoni Yangilash")
            .Centered()
            .Color(Color.Maroon));

        Console.WriteLine("Yangilash uchun mijoz emailini kiriting: ");
        var email = Console.ReadLine();

        Customer customer = null!;

        foreach (var c in customers)
        {
            if (c.Email == email)
            {
                customer = c;
                break;
            }
        }

        if(customer == null)
        {
            Console.WriteLine("Mijoz topilmadi!");
            return;
        }

        Console.WriteLine($"Hozirgi umumiy savdo miqdori: {RegisterSale} so'm");
        Console.WriteLine("Yangi savdo miqdorini kiriting: ");
        var amountInput = Console.ReadLine()!;

        Console.WriteLine($"Savdo yangilandi! Yangi umumiy savdo miqdori: {amountInput} so'm.");
    }
}

class Program
{
    public static void Main()
    {
        var CRMSystem = new CRMSystem();
        CRMSystem.Menu();
    }
}