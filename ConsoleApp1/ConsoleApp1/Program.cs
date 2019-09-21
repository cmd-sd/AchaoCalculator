using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            Random b1 = new Random();
            //Console.ReadLine("请输入题目数：");
            int a = Convert.ToInt32(Console.ReadLine());
            jisuan ji = new jisuan();
            for (int i = 0; i < a; i++)
            {
                int c = b1.Next(0, 2);
                if (c == 0)//两个运算符
                {
                    int c1 = b1.Next(0, 100);
                    int c2 = b1.Next(0, 100);
                    int c3 = b1.Next(0, 100);
                    string str1 = symbol(b1.Next(0, 4));
                    string str2 = symbol(b1.Next(0, 4));
                    ji.process1(c1, c2, c3, str1, str2);
                }
                else//三个运算符
                {
                    int c1 = b1.Next(0, 100);
                    int c2 = b1.Next(0, 100);
                    int c3 = b1.Next(0, 100);
                    int c4 = b1.Next(0, 100);
                    string str1 = symbol(b1.Next(0, 4));
                    string str2 = symbol(b1.Next(0, 4));
                    string str3 = symbol(b1.Next(0, 4));
                    ji.process2(c1, c2, c3, c4, str1, str2, str3);
                }
            }
        }
        public static string symbol(int a)
        {
            string[] z = new string[4] { "+", "-", "*", "/" };
            if (a == 0)
                return z[0];
            else if (a == 1)
                return z[1];
            else if (a == 2)
                return z[2];
            else
                return z[3];
        }
    }
}
