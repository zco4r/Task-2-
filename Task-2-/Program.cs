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
 
            }
        }
