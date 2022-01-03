using System;
using System.Collections.Generic;
using System.Text;
 
class Program
{
    static void Main()
    {
        int[] test = CopyEven(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        foreach (int num in test)
        {
            Console.Write(num + ",");
        }
        Console.WriteLine();
    }
 
    static int[] CopyEven(int[] numbers)
    {
        int[] result = new int[0];
 
        foreach (int element in numbers)
        {
            if ((element % 2 == 0) && (element != 0))
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = element;
            }
        }
        return result;
    }
}