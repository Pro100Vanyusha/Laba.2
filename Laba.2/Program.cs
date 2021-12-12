using System;

namespace Laba._2
{
    class Program
    {
        static void Resaize(ref int[] array, int NewSize)
        {
            int[] newArray = new int[NewSize];

            for (int i = 0; i < array.Length; i++)
               newArray[i] = array[i];
                
            array = newArray;
       }
        static void Main(string[] args)
        {
            int[] myArray = { 13000, 8000, 25650, 45, 17, 24 };

            Resaize(ref myArray, 12);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);

            }
        }  
        
    }
    
}
