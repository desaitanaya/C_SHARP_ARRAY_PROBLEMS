namespace ArrayInsertElementUnsorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int size, i = 0;

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

            Console.WriteLine("Enter the position to be inserted :");
            position = int.Parse(Console.ReadLine());

            //Shifting the elements to right side
            for (i = size; i > position; i--)
            {
                array[i] = array[i - 1];
            }
            array[position-1] = element;

            for (i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}