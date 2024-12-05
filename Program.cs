using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241205CS002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //用遞迴Recursive (也就是讓: 函式自己呼叫自己)
            // ex 算階層, 5!=5*4*3*2*1, 10!=10*9*8*7*....*1
            double result = CountLevel(10);
            if (result > 0)
                Console.WriteLine(result);
            else
                Console.WriteLine("計算錯誤或Ram不夠大!");

            //假設要輸入10位學生的數學成績,同時算平均.
            //不用陣列做法
         

            //做法2: 使用陣列

            //做法3: 使用串列


        }

       static void test1()
        {
            //做法1: 不使用陣列情況
            //存分數的變數
            float score = 0;
            //存分數總和的變數
            float sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("請輸入成績:");
                try
                {
                    score = float.Parse(Console.ReadLine());
                    sum = sum + score;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("輸入資料錯誤:");
                    return;
                }

            }

            Console.WriteLine("你輸入的總分為:" + sum.ToString());
            Console.WriteLine("平均分數為:" + (sum / 10).ToString());
        }
       static void test2()
        {
            int a = 5; float m = 0;
            int[] z = { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(z[0].ToString());
                Console.WriteLine(z[1].ToString());
                Console.WriteLine(z[100].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("超過陣列範圍,錯誤代碼:" + ex.Message);
            }

        }
       static void test3() { }

       static int CountLevel(int n)
        {
            if (n < 0)
                return -1;

            if (n == 1)
                return 1;
            else
                return n * CountLevel(n - 1);
        }
    }
}
