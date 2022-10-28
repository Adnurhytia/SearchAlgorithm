using System;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[]arr = new int[20];
        //Number of elements in the array
        int n;
        //get the number of elements to storein the array 
        int i;

        public void input()
        {
            while(true)
            {
                Console.WriteLine("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elements.\n");
            }

        }
    }
}