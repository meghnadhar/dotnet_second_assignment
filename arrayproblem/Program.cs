using System;

namespace Arrayproblem
{
    public class Array1
    {
        public int  Call(int s){
            int []array=new int[s];
            int i;
            for(i=0;i<s;i++)
            {
                 array[i]=i+1;
                 Console.WriteLine(" {0} ",array[i]);
                 if(i==10)
                 {
                  Console.WriteLine("array crosses 10");
                 }
            }
            return array.Length;
     }
 public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int s=int.Parse(Console.ReadLine());
            Array1 sec=new Array1();
            int l=sec.Call(s);
        }
    }
    }
}