/* Author: Rachel Rozet
 * Date: 2/13/2023
 * Description: Creating a Console application that will randomly populate an array with integers numbers between 10 and 50, 
 * and return the summation of all the elements of an array (the array is the parameter for this method). 
 * */

namespace Deliverable5_RachelRozet
{
    internal class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 15");

            try
            {
                int input = int.Parse(Console.ReadLine());

                if (5 <= input && input <= 15)
                {
                    int[] MyArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(MyArray));
                }

                else
                {
                    Console.WriteLine("Input does not match integer requirements. Please run the program again.");
                }
            }

            catch
            {
                Console.WriteLine("Input does not match integer requirements. Please run the program again.");
            }


        }
    }
}