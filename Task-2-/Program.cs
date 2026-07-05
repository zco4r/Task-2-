namespace Task_2_;

class Program
{
    static void Main()
    {

        Console.Write("Enter a starting number: ");


        if (int.TryParse(Console.ReadLine(), out int startNumber))
        {
            for (int i = startNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Liftoff!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        //------------------------------------------------------------------------1
        Console.WriteLine("Enter a number (N) to calculate the sum:");
        string input2 = Console.ReadLine();
        int n = int.Parse(input2);

        int sum = 0;

        for (int i = 1; i <= n; i = i + 1)
        {
            sum = sum + i;
        }

        Console.WriteLine("The sum is: " + sum);
        //-------------------------------------------------------------------2
        
        
        Console.WriteLine("Enter a number to see its multiplication table:");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        
         for (int i = 1; i <= 10; i = i + 1)
         {
          
          int result = number * i;
          
          Console.WriteLine(number + " x " + i + " = " + result);
        }
         
        //--------------------------------------------------------------------3

        string realPassword = "Spark2026";
        string userInput = "";

        Console.WriteLine("Please enter the password:");
        userInput = Console.ReadLine();

        while (userInput != realPassword)
        {
         Console.WriteLine("Incorrect password, try again");
            
        userInput = Console.ReadLine();
        }

        Console.WriteLine("Access Granted");
        //--------------------------------------------------------------------4
        int secret = 42;
        
        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Guess the secret number: ");
            string inpuT = Console.ReadLine();
            guess = int.Parse(inpuT);
            
            attempts = attempts + 1;

            if (guess > secret)
            {
                Console.WriteLine("Too high");
            }
            else if (guess < secret)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Correct! It took you " + attempts + " attempts.");
            }

        } while (guess != secret);
        //----------------------------------------------------------------------------5
        
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;

            Console.WriteLine("The result is: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
                    
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        //---------------------------------------------------------------------------6
                
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Say Hello");
            Console.WriteLine("2) Show Current Time-of-day Greeting");
            Console.WriteLine("3) Exit");
            Console.Write("Your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Good day!");
                        break;
                    case 3:
                        isRunning = false;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Please choose 1, 2, or 3.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }
        //--------------------------------------------------------------------------------7

        Console.Write("Enter a positive whole number (N): ");
        int N = int.Parse(Console.ReadLine());
        
        int SUM = 0;

        for (int i = 1; i <= n; i = i + 1)
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
        }

        Console.WriteLine("The sum of even numbers is: " + sum);
    //-------------------------------------------------------------------------------------8

        
    }
}
        
        
    

