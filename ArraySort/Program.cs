using System.Drawing;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size1, size2, size3, i=0 , j = 0, k = 0 ;
            Console.WriteLine("Enter the size of First array :");
            size1 = int.Parse(Console.ReadLine());

            int[] first_array = new int[size1];

            //Taking input from the user
            Console.WriteLine("Enter the First array elements : ");
            for ( i= 0; i < size1; i++)
            {
                first_array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of Second array :");
            size2 = int.Parse(Console.ReadLine());

            int[] second_array = new int[size2];

            //Taking input from the user
            Console.WriteLine("Enter the Second array elements : ");
            for (i = 0; i < size2; i++)
            {
                second_array[i] = int.Parse(Console.ReadLine());
            }

            //Resultant Array
            size3 = size1 + size2;
            int[] resultant_array = new int[size3];

            i = 0;
            //Storing the elements of First and Second array into Resultant array
            while(i<size1)
            {
                resultant_array[k] = first_array[i];
                i++;
                k++;
            }
            while(j<size2)
            {
                resultant_array[k] = second_array[j];
                j++;
                k++;
            }
            

            int temp = 0;
            for(i=0; i<size3; i++)
            {
                for(j=i+1; j<size3; j++)
                {
                    if (resultant_array[i] > resultant_array[j])
                    {
                        //Sorting the array elements
                        temp = resultant_array[i];
                        resultant_array[i] = resultant_array[j];
                        resultant_array[j] = temp;
                    }
                }
                
            }

            //Displaying the Resultant array
            Console.WriteLine("Sorted elements in array : ");
            for(i=0; i < size3; i++)
            {
                Console.WriteLine(resultant_array[i]);
            }
        }
    }
}