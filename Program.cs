﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
namespace _20241205CS002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> EngScore = new List<double> { 99, 20, 50, 60, 100, 80 };
            //先排序
            EngScore.Sort();

            foreach (var eachscore in EngScore)
                Console.WriteLine(eachscore);

            
            Console.WriteLine("總分數為:"+ EngScore.Sum().ToString());
            Console.WriteLine("總共有"+EngScore.Count().ToString()+"組資料");
            Console.WriteLine("平均分數為:"+(EngScore.Sum()/EngScore.Count()).ToString());


        }

        static void MyStackDemo()
        {
            Stack<int> MyNumbers = new Stack<int>();
            MyNumbers.Push(40);
            MyNumbers.Push(100);
            MyNumbers.Push(80);
            MyNumbers.Push(54);

            foreach (var number in MyNumbers)
            {

                Console.WriteLine(number);
            }


            Console.WriteLine(MyNumbers.Pop());

        }
        static void CountGradeByList()
        {
            //計算學生10位的平均成績
            //做法3: 使用串列
            List<double> EngSccore = new List<double>();
            List<string> StdName = new List<string>();




            Console.WriteLine("請輸入10位同學成績:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第" + (i + 1) + "位");
                try
                {
                    EngSccore.Add(double.Parse(Console.ReadLine()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("輸入錯誤!" + ex.Message);
                }

            }

            double sum = 0;
            foreach (var EachScore in EngSccore)
            {
                sum = sum + EachScore;

            }

            Console.Write("平均成績為:" + (sum / 10).ToString());
        }

        static void HowToSetArray()
        {
            //甲:陣列配記憶體空間方式
            float[] MathScore = new float[100];
            double[] ChineseScore = new double[5];
            int[] count = new int[5];

            //乙:陣列先給定初始值,則可以不用配空間.
            // 知道陣列的初始值,而且陣列內的資料數量不大時,可以用.
            float[] MathScore2 = { 0, 0, 0, 0, 0, 0, 0, 0 };
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
        static void DemoForTryCath()
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
        static void test2()
        {
            //做法2: 使用陣列
            float[] MathScore = new float[10];
            float sum = 0;
            try
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("請輸入第" + (i + 1).ToString() + "位學生成績:");
                    MathScore[i] = float.Parse(Console.ReadLine());
                    sum = sum + MathScore[i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            //show資料
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine("十位學生平均成績為:" + (sum / 10).ToString());
            // 因為有用陣列紀錄十位學生的成績,所以....可以印出十位同學的成績
            //利用for迴圈來走訪陣列
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第" + i.ToString() + "位學生成績:" + MathScore[i].ToString());
            }
        }
        static void test3() {
            /* 串列用法 介紹 */
            List<double> scores = new List<double>();
            scores.Add(10.21);
            scores.Add(11.23);
            scores.Add(56.33);
            scores.Remove(11.23);
            foreach (var StudentScore in scores)
            {
                Console.WriteLine(StudentScore);
            }

        }

        static int CountLevel(int n)
        {
            //用遞迴Recursive (也就是讓: 函式自己呼叫自己)
            // ex 算階層, 5!=5*4*3*2*1, 10!=10*9*8*7*....*1

            /*主程式main叫用內容
             double result = CountLevel(10);
             if (result > 0)
                Console.WriteLine(result);
            else
                Console.WriteLine("計算錯誤或Ram不夠大!");
            */

            if (n < 0)
                return -1;

            if (n == 1)
                return 1;
            else
                return n * CountLevel(n - 1);
        }
    }
}
