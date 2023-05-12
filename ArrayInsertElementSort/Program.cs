namespace ArrayInsertElementSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int size, i=0;

            Console.WriteLine("Enter the size of array : ");
            size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            int element = 0, position = 0;
            Console.WriteLine("Enter the element to be inserted : ");
            element = int.Parse(Console.ReadLine());

            int temp = 0;
            for ( i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] > array[j])
                    {
                        //Sorting the array elements
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

            }
            for (i = 0; i < size; i++)
            {
                //Finding out the index of element
                if(element < array[i])
                {
                    position = i;
                    break;
                }
            }
            
            //Shifting the elements to right side
            for(i=size; i>position; i--)
            {
                array[i] = array[i - 1];
            }
            array[position] = element;

            for(i=0; i<size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}