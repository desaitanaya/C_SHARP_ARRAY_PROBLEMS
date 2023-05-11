namespace ArrayPrimeNumber
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
            
            int flag = 0, sum=0;
            for(int i=0; i < size; i++)
            {
                for (int j = 2; j <= array[i] / 2; j++)
                {
                    //Condition to check a prime number
                    if (array[i] % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
                
                if (flag == 0)
                {
                    //Adding all the prime numbers in array
                    sum = sum + array[i];
                }
               
            }
            Console.WriteLine("Sum of Prime numbers in array : " + sum);
            
            
        }
    }
}