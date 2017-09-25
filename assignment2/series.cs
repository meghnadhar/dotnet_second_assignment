using System;

namespace Fibonacci
{
    public class MySeries{

    public  int FiboFunction(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (FiboFunction(n - 1) + FiboFunction(n - 2));
            }
        }
  }
}