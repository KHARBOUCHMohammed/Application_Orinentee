using static TextCasing;
using System;
using System.Web.Services.Protocols;
public class Client
{
    static void Main(string[] args)
    {
        TextCasing service = new TextCasing();

        System.Console.WriteLine(service.InvertStringCase("mohammed"));
        
        Console.ReadLine();
    }
}
