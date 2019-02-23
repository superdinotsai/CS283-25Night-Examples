using System;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            float y = (1.0f / 2.0f) * (a + b);
            Console.WriteLine(a + b == c);
            Console.WriteLine((a + b)*1/2);
            Console.WriteLine((1 / 2)*(a + b));//1/2會當整數所以=0
            Console.WriteLine((1.0 / 2.0) * (a + b));//小數計算會有誤差(某種特殊的狀況下會發生)
            Console.WriteLine(y);//正確值
        }
    }
}