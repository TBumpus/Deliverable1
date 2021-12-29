using System;

public class Deliverable1
{
    static public void Main()
    {

        int numberPeople;
        double totalLoavesNeeded;
        double totalSlicesNeeded;
        double totalPeanutNeeded;
        double totalJellyNeeded;
        int slicesPerLoaf = 28;
        int jarPeanutButter = 32;
        int jarJelly = 48;
        double totalJellyJars;
        double totalPeanutJars;
        string restart = "y";
        
        do    
        {
            Console.WriteLine("How many people are we making PB and J sandwiches for?");
            string userInput = Console.ReadLine();

            int.TryParse(userInput, out numberPeople);

            totalSlicesNeeded = numberPeople * 2;

            totalPeanutNeeded = numberPeople * 2;

            totalJellyNeeded = numberPeople * 4;

            
            totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;

            totalLoavesNeeded = (int)Math.Ceiling(totalLoavesNeeded);


            totalPeanutJars = totalPeanutNeeded / jarPeanutButter;
            totalPeanutJars = (int)Math.Ceiling(totalPeanutJars);

            totalJellyJars = totalJellyNeeded / jarJelly;
            totalJellyJars = (int)Math.Ceiling(totalJellyJars);

            
            Console.WriteLine(numberPeople);
            Console.WriteLine();
            Console.WriteLine("You need:");
            Console.WriteLine(totalSlicesNeeded);
            Console.WriteLine("slices of bread");
            Console.WriteLine();
            Console.WriteLine(totalPeanutNeeded);
            Console.WriteLine("tablespoons of peanut butter");
            Console.WriteLine();
            Console.WriteLine(totalJellyNeeded);
            Console.WriteLine("teaspoons of jelly");
            Console.WriteLine();
            Console.WriteLine("Which is...");
            Console.WriteLine();
            Console.WriteLine(totalLoavesNeeded);
            Console.WriteLine("Loaves of bread");

            Console.WriteLine(totalPeanutJars);
            Console.WriteLine("Jars of peanut butter");

            Console.WriteLine(totalJellyJars);
            Console.WriteLine("Jars of jelly");
            Console.WriteLine();
            Console.WriteLine("would you like to restart? ");
            Console.WriteLine("Enter yes or y to continue, or enter any other key to exit");
            

            
            restart = Console.ReadLine();
            if (restart == "yes")
            {
                restart = "y";
            }

          


        } while (restart == "y");
        Console.WriteLine("Goodbye!");
    }


}