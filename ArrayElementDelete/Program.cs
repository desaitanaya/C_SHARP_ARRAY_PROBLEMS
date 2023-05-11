namespace ArrayElementDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, position, i;

            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            //Array declaration
            int[] array = new int[size];

            Console.WriteLine("Enter the array elements : ");
            for (i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the position of element to be deleted : ");
            position = int.Parse(Console.ReadLine());

            i = 0;
            //Finding out the position in array
            while (i != position - 1)
            {
                i++;
            }

            //After finding out, replacing the element with it right element
            while (i < size-1)
            {
                array[i] = array[i + 1];
                i++;
            }
            size--;
            
            Console.WriteLine("Displaying Array after deleting element at position " + position + " : ");
            for(i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}