using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SplitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id \t\tSource\t\t\tDestination\t\tDate\t\tStatus\t\tNetwork ");
            FileStream fs = new FileStream("D:\\Example\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                string[] strings = line.Split(':');
                if (strings.Length > 1)
                {
                    if (line.StartsWith("Date"))
                    {
                        string date = strings[1].Split(' ')[0];
                        Console.Write(date + "\t");
                    }
                    else
                        Console.Write(strings[1]+"\t\t" );
                }

                else
                    {
                        Console.WriteLine();
                    }

                }

            }
        }
    }


