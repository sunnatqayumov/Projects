using System;
using System.Threading.Tasks;
using PrayerTimes.Services;
using Spectre.Console;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        AnsiConsole.Markup("[bold yellow]Namoz Vaqtlari Dasturi[/]\n");
        
        string city = AnsiConsole.Ask<string>("[bold green]Shahar nomini kiriting:[/]");
        string country = AnsiConsole.Ask<string>("[bold green]Mamlakat nomini kiriting:[/]");
        
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        var prayerTimesServices = new GetPrayerTimes();
        var prayerTimes = await prayerTimesServices.GetPrayerTimesAsync(city, country, date);
        
        if (prayerTimes != null)
        {
            var table = new Table();
            table.AddColumn("[bold red]Namoz[/]");
            table.AddColumn("[bold yellow]Vaqti[/]");
            
            table.AddRow("Fajr", prayerTimes.Fajr!);
            table.AddRow("Sunrise", prayerTimes.Sunrise!);
            table.AddRow("Dhuhr", prayerTimes.Dhuhr!);
            table.AddRow("Asr", prayerTimes.Asr!);
            table.AddRow("Maghrib", prayerTimes.Maghrib!);
            table.AddRow("Isha", prayerTimes.Isha!);
            
            AnsiConsole.Render(table);
        }
        else
        {
            AnsiConsole.Markup("[bold red]Namoz vaqtlarini olishda xatolik yuz berdi.[/]");
        }
    }
}