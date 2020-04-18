using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            int a = 0;
            int b = 1;            
            var fibonacci = new List<int>();
            fibonacci.Add(0);
            for (int i = 0; i < fibonacci.Count; i++)
            {                
                int temp = a;                
                a = b;
                b = temp + b;
                if (a > 350)
                    break;
                fibonacci.Add(a);
            }

            return fibonacci;
        }         
            
        
        public bool IsFibonacci(int numberToTest)
        {
            var list = Fibonacci();
            if (list.Contains(numberToTest))
                return true;
            return false;

        }
    }
}
