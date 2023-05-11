namespace ArrayElementFrequency
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

            //Checking the frequency of element in array
            for (int i = 0; i < size; i++)
            {
                int count = 0;
                int flag = 0;
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] == array[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                //If element is already visited
                if (flag == 1)
                {
                    continue;
                }

                //Incremeting the count of element in array
                for (int j = 0; j <= i; j++)
                {
                    if (array[i] == array[j])
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine("Frequency of " + array[i] + " is : " + count);

            }


        }
    }
}

    
