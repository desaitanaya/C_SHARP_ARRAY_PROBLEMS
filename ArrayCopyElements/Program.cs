namespace ArrayCopyElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] first_array = new int[size];
            int[] second_array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                first_array[i] = int.Parse(Console.ReadLine());
            }

            //Displaying the first array elements
            Console.WriteLine("First Array Elements : ");
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(first_array[i]);
            }

            //Copying the elements of first array to second array
            for(int i=0; i < size; i++)
            {
                second_array[i] = first_array[i];
            }

            //Displaying the second array elements
            Console.WriteLine("Second Array Elements : ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(second_array[i]);
            }
        }
    }
}