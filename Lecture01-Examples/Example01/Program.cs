﻿using System;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Write("請輸入帳號:");
            Console.WriteLine("我今天心情{0}{1}", "很", "開心");
            Console.Read();
            //Console.Read();不讓視窗一閃而過 CTRL+F5
        }
    }
}