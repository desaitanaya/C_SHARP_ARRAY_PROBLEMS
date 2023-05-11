namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of array :");
            size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            //Taking the input from the user 
            Console.WriteLine("Enter the array elements : ");
            for(int i=0; i<size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Displaying the array elements in reverse order
            Console.WriteLine("Array elements in Reverse order : ");
            for(int i=size-1; i>=0; i--)
            {
                Console.WriteLine(array[i]);    
            }



        }

    }
}
