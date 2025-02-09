using ConsoleApp1.Models;
using System;
using ConsoleApp1.Services;

class Program
{
    static void Main(string[] args)
    {
        BokService bokService = new BokService();

        Console.WriteLine("Lägger till en ny bok i databasen...");
        var nyBok = new Bok
        {
            Titel = "MongoDB Code First",
            Språk = "Svenska",
            Pris = 199.99M,
            Utgivningsdatum = "2025-02-06",
            FörfattarId = "64b6c5dff9e7d4b9b67b9b99" 
        };

        bokService.AddBok(nyBok);
        Console.WriteLine("Boken har lagts till!");

        Console.WriteLine("\nLista alla böcker:");
        var böcker = bokService.GetAll();
        foreach (var bok in böcker)
        {
            Console.WriteLine($"Titel: {bok.Titel}, Pris: {bok.Pris}");
        }
    }
}


