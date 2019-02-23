using System;

namespace Example01//C程式設計基礎283期第2講part1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入數字1:");
            int number1 = int.Parse(Console.ReadLine());//ReadLine輸入，輸入資料型態要為int
            Console.Write("請輸入數字2:");
            int number2 = int.Parse(Console.ReadLine());//Parse文字轉數字

            Console.WriteLine("{0}+{1}+{2}"
                ,number1
                ,number2
                ,number1+number2//50分
                );
        }
    }
}