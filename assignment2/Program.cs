using System;

namespace Fibonacci
{
class Program
    {
     static void Main(){
         int n, i = 0, c;
            Console.WriteLine("Enter the number of terms of the series:");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fibonacci series of the  entered values are: \n");

            MySeries f1=new MySeries();
            for (c = 1; c <= n; c++)
            {
                int result = f1.FiboFunction(i);
                Console.WriteLine(result + " " );
                i++;
            }
            Console.WriteLine();
    
         
     }
    }

}