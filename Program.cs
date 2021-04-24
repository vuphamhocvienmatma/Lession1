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

            //Bài 1
            //string text = "Cong ty Stanford – Dao tao va phat trien cong nghe";

            //string[] spilted = text.Split(" ");

            //int i = 0;

            //foreach (var item in spilted)
            //{
            //    Console.WriteLine("Kí tự trong mảng: " + i + " " + item);
            //    i++;
            //}          

            //bài 2
            //Khai báo biến

            //int n = 0;

            //Console.Write("Nhập số phần tử của mảng gồm n = ");

            //n = int.Parse(Console.ReadLine());

            //double[] arr = new double[n];

            ////Nhập các thông tin cho các phần tử
            //for (int i = 0; i < n; i++) { 
            //    Console.Write("Phần từ thứ i của mảng Arr là: arr[" + i + "] = ");               
            //    arr[i] = double.Parse(Console.ReadLine());
            //}

            //double max = arr[0];

            //double min = arr[0];

            ////Tìm max, min
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine("Max" + max);
            //Console.WriteLine("Min" + min);

            //bài 3
            int n = 0;

            Console.Write("Nhập số phần tử của mảng gồm n = ");

            n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];

            //Nhập các thông tin cho các phần tử
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần từ thứ i của mảng Arr là: arr[" + i + "] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            double temp = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                  
                }
            }

            //In kết quả sau khi sắp xếp tăng dần
            Console.WriteLine("Dãy sắp xếp tăng dần là: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
