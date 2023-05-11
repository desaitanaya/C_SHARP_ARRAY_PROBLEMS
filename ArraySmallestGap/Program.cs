namespace ArraySmallestGap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            //Sorting the elements in Ascending order
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }

            //Finding out the minimum gap between the elements in array
            int min_gap = int.MaxValue;
            for(int i = 0; i < size; i++)
            {
                for(int j = i+1; j < size; j++)
                {
                    if (array[j] - array[i] < min_gap)
                    {
                        min_gap = array[j] - array[i];
                    }
                }
                
            }

            Console.WriteLine("Minimum gap between the elements in array is : " + min_gap);
        }
    }
}