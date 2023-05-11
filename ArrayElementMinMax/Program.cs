namespace ArrayElementMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            //Taking input from the user
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Storing First element of array in min and max variable 
            int max = array[0];
            int min = array[0];

            for(int i = 0; i < size; i++)
            {
                //Comparing the max with other elements in array to find out maximum element in array
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Maximum element in array is : " + max);

            for (int i = 0; i < size; i++)
            {
                //Comparing the min with other elements in array to find out minimum element in array
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Minimum element in array is : " + min);

        }
    }
}