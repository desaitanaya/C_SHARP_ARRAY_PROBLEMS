namespace ArrayDuplicateElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, count = 0;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            //Finding out the duplicate elements in array
            for(int i=0; i < size; i++)
            {
                for(int j=i+1; j <size; j++)
                {
                    if (array[i] == array[j])
                    {
                        count = count + 1;
                    }
                }
               
            }

            Console.WriteLine("Count of Duplicate elements in array : " + count);
        }
    }
}