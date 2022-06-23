// prompts the user to enter an integer.

Console.WriteLine("Learn your squares and cubes!");

bool tryAgain = true;
while (tryAgain)
{
    
        Console.WriteLine("Enter an integer: ");
        int choice = int.Parse(Console.ReadLine());

    

        // display first rows
        Console.WriteLine("Number\tSquared\tCubed");
        Console.WriteLine("======\t=======\t=====");

        // displays chart data
        for (int i = 1; i <= choice; i++)
        {
            Console.WriteLine(i + "\t" + NumberSquared(i) + "\t" + NumberCubed(i));
        }

        static int NumberSquared(int choice)
        {
            return (choice * choice);
        }
        static int NumberCubed(int choice)
        {
            return (choice * choice * choice);
        }

        Console.WriteLine("Would you like to restart? y/n: ");
        string restart = Console.ReadLine().ToLower();

        if (restart != "y")
        {
            tryAgain = false;
        }
    } 

Console.WriteLine("\nGoodbye!");