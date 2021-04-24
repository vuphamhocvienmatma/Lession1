using System;
using System.Collections.Generic;
using System.Text;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ánh óc chó, ánh ăn cứt gà, ánh cười khà khà");
            }
            for (int i = 10 - 1; i >= 0; i--)
            {

            }



            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            int[] Kteam = new int[3];

            string[] Kteam1 = new string[] { "Anh", "Love", "Em" };

            Kteam1.SetValue("Tao", 0);
            Kteam1.SetValue("May", 2);
            Kteam1[0] = "";

            object giaTri = Kteam1.GetValue(1);


            for (int i = 0; i < Kteam1.Length; i++) // Vì các phần tử có chỉ số là 0 1 2 nên điều kiện dừng là i < 3
            {
                Console.WriteLine("đang ở phần tử: " + Kteam1[i]);
            }

            Console.WriteLine(giaTri);

            List<String> a = new List<string>();
            a.Add("a");
            a.Add("d");
            a.Add("l");
            a.Insert(10, "v");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
