using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class jisuan
    {
        StreamWriter sw1 = new StreamWriter(@"D:\ce.txt");
        Random b1 = new Random();
        public static bool ansx(double sum)
        {
            if (sum == (int)sum)
                return true;
            else
                return false;
        }
        public static double counter(int c, int d, string e)
        {
            if (e == "+")
                return c + d;
            else if (e == "-")
                return c - d;
            else if (e == "*")
                return c * d;
            else
            {
                if (d != 0)
                {
                    int m = c / d;
                    if (m * d == c)
                        return c / d;
                    else
                    {
                        return 0;
                    }

                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
        public void process1(int c1,int c2,int c3,string str1,string str2)
        {
            if ((str1 == "+" || str1 == "-") && (str2 == "*" || str2 == "/"))
            {
                double sum = counter(c2, c3, str2);
                while (sum < 0&& ansx(sum)==false)
                {
                    c3 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum=counter(c3,c2,str2);
                }
                double temp = counter(c1, (int)sum, str1);
                while (temp < 0 && ansx(temp)==false)
                {
                    c1 = b1.Next(1, 100);
                    temp = counter(c1, (int)sum, str1);
                }
                Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "=" + (int)temp);
                sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "=" + (int)temp + "\r\n");
            }
            else
            {
                double sum = counter(c1, c2, str1);
                while (sum < 0 && ansx(sum)==false&&counter(c1,c2,str1)==0)
                {
                    c1 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum = counter(c1, c2, str1);
                }
                double temp = counter(c3, (int)sum, str2);
                while (temp < 0 && ansx(temp) == false && counter((int)sum, c3, str2) == 0)
                {
                    c3 = b1.Next(1, 100);
                    temp = counter(c3, (int)sum, str1);
                }
                Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "=" + (int)temp);
                sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "=" + (int)temp + "\r\n");
            }
        }
        public void process2(int c1,int c2,int c3,int c4,string str1,string str2,string str3)
        {
            if ((str1 == "+" || str1 == "-") && (str2 == "*" || str2 == "/") && (str3 == "*" || str3 == "/"))
            {
                double sum = counter(c2, c3, str2);
                while (sum < 0 && ansx(sum)==false)
                {
                    c3 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum = counter(c3, c2, str2);
                }
                double temp = counter(c4, (int)sum, str3);
                while (temp < 0 && ansx(temp)==false)
                {
                    c4 = b1.Next(1, 100);
                    temp = counter(c4, (int)sum, str3);
                }
                double final = counter(c1, (int)temp, str1);
                while (final < 0 && ansx(final) == false)
                {
                    c1 = b1.Next(1, 100);
                    final = counter(c1, (int)temp, str1);
                    if (final > 0 && ansx(final))
                    {
                        Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final);
                        sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final + "\r\n");
                        //break;
                    }
                }

            }
            else if ((str1 == "+" || str1 == "-") && (str2 == "*" || str2 == "/") && (str3 == "-" || str3 == "+"))
            {
                double sum = counter(c2, c3, str2);
                while (sum < 0 && ansx(sum)==false)
                {
                    c3 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum = counter(c3, c2, str2);
                }
                double temp = counter(c1, (int)sum, str1);
                while (temp < 0 && ansx(temp)==false)
                {
                    c1 = b1.Next(1, 100);
                    temp = counter(c1, (int)sum, str1);
                }
                double final = counter(c4, (int)temp, str3);
                while (final < 0 && ansx(final)==false)
                {
                    c4 = b1.Next(1, 100);
                    final = counter(c4, (int)temp, str1);
                    if (final > 0 && ansx(final)==false)
                    {
                        Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final);
                        sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final + "\r\n");
                        //break;
                    }
                }
            }
            else if ((str1 == "*" || str1 == "/") && (str2 == "+" || str2 == "-") && (str3 == "*" || str3 == "/"))
            {
                double sum = counter(c1, c2, str1);
                while (sum < 0 && ansx(sum)==false)
                {
                    c1 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum = counter(c1, c2, str1);
                }
                double temp = counter(c3,c4 , str3);
                while (temp < 0 && ansx(temp)==false)
                {
                    c3 = b1.Next(1, 100);
                    c4 = b1.Next(1, 100);
                    temp = counter(c3, c4, str3);
                }
                double final = counter((int)sum, (int)temp, str2);
                Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final);
                sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final + "\r\n");
            }
            else
            {
                double sum = counter(c1, c2, str1);
                while (sum < 0 && ansx(sum)==false)
                {
                    c1 = b1.Next(1, 100);
                    c2 = b1.Next(1, 100);
                    sum = counter(c1, c2, str1);
                }
                double temp = counter(c3, (int)sum, str2);
                while (temp < 0 && ansx(temp)==false)
                {
                    c3 = b1.Next(1, 100);
                    temp = counter(c3, (int)sum, str2);
                }
                double final = counter(c4, (int)temp, str3);
                while (final < 0 && ansx(final)==false)
                {
                    c4 = b1.Next(1, 100);
                    final = counter(c4, (int)temp, str1);
                    if (final > 0 && ansx(final))
                    {
                        Console.WriteLine(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final);
                        sw1.Write(c1 + "" + str1 + "" + c2 + "" + str2 + "" + c3 + "" + str3 + c4 + "=" + (int)final + "\r\n");
                    }
                }
            }
        }
    }
}
