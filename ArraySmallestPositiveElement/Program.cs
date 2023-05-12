namespace ArraySmallestPositiveElement
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


            int temp = 0;
            //Sorting the array elements in ascending order
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            int num = 1;
            for(int i= 0; i < size; i++)
            {
                /*Will check if the number is present in array or not and if
                 * not then it will return that number */
                if (array[i] == num)
                {
                    num++;
                }
            }
            Console.WriteLine("Smallest positive missing element in array is : " + num);
        }
    }
}