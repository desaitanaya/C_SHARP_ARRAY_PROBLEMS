namespace ArraySum
{
   class ArraySum
    {
        static void Main(string[] args)
        {
            int size, sum=0;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            //Taking input from the user
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Displaying the sum of elements in array
            Console.WriteLine("Sum of elements in array : ");
            for (int i = 0; i<size; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine(sum);

        }
    }
}