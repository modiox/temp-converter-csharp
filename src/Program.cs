using System;

class Program
{
    static void Main(string[] args)
    {

        try {

        while(true) {
          Console.WriteLine("Enter a temperature and its unit (C or F): or type 'End' to quit the app..");
          string input = Console.ReadLine();
          string[] parts = input.Split(' ');

        if(input.ToLower() == "end") {
            Console.WriteLine("You've exited the app..");
            break;
         }

        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid input format. Please enter temperature followed by unit (C or F).");
            continue;
        }
        Console.WriteLine(parts[0]);
        Console.WriteLine(parts[1]);


        }
      

        }
        catch {

        }
      
    }}