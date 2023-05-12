namespace ArrayNegativeNumbersSum
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

            int sum = 0;
            sum = array[0] + array[1];
            Console.WriteLine("Sum of two lowest negative number in array is : " + sum);
        }
    }
}