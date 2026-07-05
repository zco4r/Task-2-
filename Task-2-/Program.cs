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
    

        int x = 0;
        bool isValid = false;

        do
        {
            try
            {
                Console.Write("Enter a positive whole number: ");
                x = int.Parse(Console.ReadLine());
                
                if (x > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Please enter a valid whole number.");
            }
        } 
        while (!isValid);

        int Sum = 0;
        for (int i = 1; i <= x; i = i + 1)
        {
            Sum = Sum + i;
        }

        Console.WriteLine("The Sum of numbers from 1 to " + x + " is: " + Sum);
        //------------------------------------------------------------------------------9

        int correctPin = 1234;
        decimal balance = 100.000m;
        int Attempts = 0;
        bool isAuthenticated = false;

        while (Attempts < 3)
        {
            try
            {
                Console.Write("Enter your PIN: ");
                int enteredPin = int.Parse(Console.ReadLine());

                if (enteredPin == correctPin)
                {
                    isAuthenticated = true;
                    break;
                }
                else
                {
                    Attempts = Attempts + 1;
                    Console.WriteLine("Wrong PIN.");
                }
            }
            catch (Exception)
            {
                Attempts = Attempts + 1;
                Console.WriteLine("Invalid input. Counts as a wrong attempt.");
            }
        }

        if (!isAuthenticated)
        {
            Console.WriteLine("Card Blocked");
            return;
        }

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1) Deposit, 2) Withdraw, 3) Check Balance, 4) Exit");
            Console.Write("Choose an option: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: 
                        Console.Write("Enter deposit amount: ");
                        decimal dep = decimal.Parse(Console.ReadLine());
                        if (dep > 0) { balance = balance + dep; Console.WriteLine("New Balance: " + balance); }
                        else Console.WriteLine("Invalid amount.");
                        break;
                    case 2: 
                        Console.Write("Enter withdrawal amount: ");
                        decimal with = decimal.Parse(Console.ReadLine());
                        if (with > 0 && with <= balance) { balance = balance - with; Console.WriteLine("New Balance: " + balance); }
                        else Console.WriteLine("Invalid amount or insufficient funds.");
                        break;
                    case 3: 
                        Console.WriteLine("Current Balance: " + balance);
                        break;
                    case 4: 
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }
        }
        //-------------------------------------------------------------------------------10



        
    }
}
        
        
    

