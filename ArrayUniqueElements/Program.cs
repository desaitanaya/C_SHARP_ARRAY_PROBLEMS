namespace ArrayUniqueElements
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

            for (int i = 0; i < size; i++)
            {
                int flag = 0;
                //Checking the left side of the elements are equal or not
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        flag++;
                    }
                }
                //Checking the right side of the elements are equal or not
                for (int k=i+1; k<size; k++)
                {
                    if (array[i] == array[k])
                    {
                        flag++;
                    }
                    //Checking the adjacent element is equal or not
                    if (array[i] == array[i + 1])
                    {
                        i++;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Unique element in array : " + array[i]);
                }
            }
            

        }

    }
}
