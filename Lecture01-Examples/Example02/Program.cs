﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "阿哲",
                phone = "0912553444",
                address = "新北市板橋區板橋車站",
            };
            Console.WriteLine("學生姓名:{0}", "TEL:{1}", "address:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address);
        }
    }
}

