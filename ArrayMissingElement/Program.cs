using System.Diagnostics.CodeAnalysis;

namespace ArrayMissingELement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, total_sum = 0;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Calculating the sum of natural numbers in array
            total_sum = (size + 1) * (size + 2) / 2;
            for(int i=0; i < size;i++)
            {
                //Subtracting the total sum by the element present in array
                total_sum -= array[i];
            }

            Console.WriteLine("Missing element in the array is : " + total_sum);
        }
    }
}