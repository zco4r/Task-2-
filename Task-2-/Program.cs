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
 
            }
        }
             
        


























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
