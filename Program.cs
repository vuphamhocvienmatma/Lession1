using System;
using System.Collections.Generic;
using System.Text;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;         
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Ánh óc chó, ánh ăn cứt gà, ánh cười khà khà");
            //}
            //for (int i = 10 - 1; i >= 0; i--)
            //{

            //}

            //List<String> a = new List<string>();
            //a.Add("aaaa");
            //a.Add("bbbb");
            //a.Add("ccccc");

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("biến J là: " + j);
                }
                Console.WriteLine("biến I là: "  + i);
            }
            Console.ReadKey();
        }
    }
}
