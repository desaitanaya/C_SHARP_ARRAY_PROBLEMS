namespace ArrayElementEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, j=0, k=0;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Declaring array
            int[] array = new int[size];

            //Declaring array for storing even numbers
            int[] even = new int[size];

            //Declaring array for storing odd numbers
            int[] odd = new int[size];

            //Taking input from the user
            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < size; i++)
            {
                //Checking if the number is even or odd
                if (array[i] % 2 == 0)
                {
                    even[j] = array[i];
                    j++;
                }
                else
                {
                    odd[k] = array[i];
                    k++;
                }
            }

            Console.WriteLine("Even elements in the array are : ");
            for (int i = 0; i < j; i++){
                Console.WriteLine(even[i]);
            }

            Console.WriteLine("Odd elements in the array are : ");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(odd[i]);
            }

        }
    }
}