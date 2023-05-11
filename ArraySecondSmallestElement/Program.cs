namespace ArraySecondSmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, i = 0;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (i = 0; i < size - 1; i++)
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
            Console.WriteLine("Second smallest element in array is : " + array[1]);

        }
    }
}
