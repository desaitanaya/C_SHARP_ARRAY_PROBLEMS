namespace ArrayProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, num;
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

            Console.WriteLine("Enter the number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers whose product is equal to given number : ");
            for(int i = 0; i < size; i++)
            {
                for(int j = i+1; j < size; j++)
                {
                    if (array[i] * array[j] == num)
                    {
                        Console.WriteLine(array[i]);
                        Console.WriteLine(array[j]);
                    }
                }
            }

        }
    }
}