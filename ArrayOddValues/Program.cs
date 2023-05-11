namespace ArrayOddValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, j = 0, k = 0;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Declaring array
            int[] array = new int[size];
            

            //Taking input from the user
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Odd elements in the array are : ");
            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

            

  

        }
    }
}