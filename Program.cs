using System;

namespace CSharp.LabExercise2
{
    class Lasagna
    {
        public int ExpectedMinutesInOven() => 40;
        public int RemainingMinutesInOven( int minutesInOven) => ExpectedMinutesInOven() - minutesInOven ;
        public int PreparationTimeInMinutes(int layers) => 2 * layers;
        public int ElapsedTimeInMinutes(int layers, int minutesInOven) => PreparationTimeInMinutes(layers) + RemainingMinutesInOven(minutesInOven);
    }

    class Program
    {
        static void Number2()
        {
            Lasagna lasagna = new Lasagna();

            while (true)
            {
                Console.WriteLine("Lucian Lasagna");
                Console.WriteLine("[1] Expected Time in Oven (minutes)");
                Console.WriteLine("[2] Remaining Time in Oven (minutes)");
                Console.WriteLine("[3] Preparation Time (minutes)");
                Console.WriteLine("[4] Elapsed Time (minutes)");
                Console.WriteLine("[5] Exit");
                Console.Write("Please Enter a number of your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Expected Time : {0} minutes", lasagna.ExpectedMinutesInOven());
                        break;
                    case 2:
                        Console.Write("Please enter the minutes that the Lasagna is inside the oven: ");
                        int minutesInOven = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Remaining Time in the Oven: {0} minutes ", lasagna.RemainingMinutesInOven(minutesInOven));
                        break;
                    case 3:
                        Console.Write("Please enter how many layers your Lasagna will have: ");
                        int layers = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Preparation Time of Lasagna: {0} minutes ", lasagna.PreparationTimeInMinutes(layers));
                        break;
                    case 4:
                        Console.Write("Please enter how many layers your Lasagna will have: ");
                        layers = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please enter the minutes that the Lasagna is inside the oven: ");
                        minutesInOven = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Elapsed Time: {0} minutes ", lasagna.ElapsedTimeInMinutes(layers, minutesInOven));
                        break;
                    case 5:
                        Console.WriteLine("Exit..");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        static void Number1()
        {
            int[] numbers = new int[5];
            int i;
            for (i = 0; i < numbers.Length; i++ )
            {
                Console.Write("Enter number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 10 && input <= 100)
                {
                    Boolean duplicateNumber = false;
                    for ( int j = 0; j < numbers.Length; j++)
                    {
                        if (input == numbers[j])
                        {
                            duplicateNumber = true;
                        }
                    }
                    if (!duplicateNumber)
                    {
                        numbers[i] = input;
                        foreach (int number in numbers)
                        {
                            Console.Write($"{number},");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{input} has already been entered");
                        i--;
                    }
                    

                }

                else
                {
                    Console.WriteLine("Number must be 10 - 100");
                }
                
            }

        }

        static void Main(string[] args)
        {
            //Number1();
            Number2();
        }
    }
}
