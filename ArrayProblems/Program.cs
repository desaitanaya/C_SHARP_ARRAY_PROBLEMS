namespace ArrayProblems
{
    class PrintArrayElements
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int[] array = new int[5];

            Console.WriteLine("Enter the array elements : ");
            for(int i=0; i<10; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            //Displaying the array elements
            Console.WriteLine("Array elements are : ");
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}