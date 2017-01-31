using System;
using System.Collections.Generic;
using System.IO;

namespace mobile37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mobile37 v0.1";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            byte farg = 0; //farg - number of filename-arguments
            foreach (string arg in args)
                if (arg.IndexOf(".txt") != -1) farg++;
            string s1 = "input.txt",
                s2 = "output.txt";

            if (farg == 1)
                s1 = args[0];
            else if (farg > 1)
            {
                s1 = args[0];
                s2 = args[1];
            }

            if (File.Exists(s1))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray; // text color
                Console.WriteLine("Mobile37 v0.1");
                int t1 = DateTime.Now.Day * 86400000 + //first time
                         DateTime.Now.Hour * 3600000 +
                         DateTime.Now.Minute * 60000 +
                         DateTime.Now.Second * 1000 +
                         DateTime.Now.Millisecond;
                List<string> x = new List<string>();
                List<string> y = new List<string>();
                x.AddRange(File.ReadAllLines(s1));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Name of source file:      {0}", s1);
                Console.WriteLine(" Total:                    {0} strings", x.Count);

                int n = 0; //number of l33t numbers. def 0
                byte length = 6; //default value of length mobile number
                foreach (string arg in args) //arg cycle
                    if (arg.IndexOf("-l") != -1) //if user set argument length value
                        try
                        {
                            length = Convert.ToByte(arg.Substring(2, arg.Length - 2));
                        } //crop length value. ex. "-l7" > "7"
                        catch
                        {
                        }
                foreach (string v in x) //if not reach to last line 
                {
                    string s;
                    s = v; //temp for l33t checking and printing
                    if (s.Length == length)
                    {
                        s = s.Replace('a', '4');
                        s = s.Replace('e', '3');
                        s = s.Replace('g', '9');
                        s = s.Replace('i', '1');
                        s = s.Replace('l', '1');
                        s = s.Replace('o', '0');
                        s = s.Replace('s', '5');
                        s = s.Replace('z', '2');
                        s = s.Replace('t', '7');
                        s = s.Replace('A', '4');
                        s = s.Replace('E', '3');
                        s = s.Replace('G', '6');
                        s = s.Replace('I', '1');
                        s = s.Replace('L', '1');
                        s = s.Replace('O', '0');
                        s = s.Replace('S', '5');
                        s = s.Replace('Z', '2');
                        s = s.Replace('T', '7');
                        s = s.Replace('B', '8');
                        try
                        {
                            Convert.ToInt32(s); //if s was not l33t number continue cycle
                            y.Add(v + ":" + s); //google:600913
                            n++;
                        }
                        catch
                        {
                        }
                    }
                }
                int t2 = DateTime.Now.Day * 86400000 + //second time
                         DateTime.Now.Hour * 3600000 +
                         DateTime.Now.Minute * 60000 +
                         DateTime.Now.Second * 1000 +
                         DateTime.Now.Millisecond;

                File.WriteAllLines(s2, y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Name of output file:      {0}", s2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" Elapsed time:             {0} milleseconds", t2 - t1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" L33t:                     {0}  numbers", n);
            }
            else if (args.Length == 0 | Array.IndexOf(args, "-?") != -1 | Array.IndexOf(args, "/?") != -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nUsage:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" -?                  Prints this help");
                Console.WriteLine(" -q                  Close program after l33t");
                Console.WriteLine(" -l%n%               Set mobile numbers %n% length. Default value is 6.");
                Console.WriteLine(" %f1%.txt            L33t mobile numbers from %f1%.txt to output.txt");
                Console.WriteLine(" %f1%.txt %f2%.txt   L33t mobile numbers from %f1%.txt to %f2%.txt");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nTip:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" If you dont use any argument, program will search input.txt file in the same");
                Console.WriteLine(" directory and l33t mobile numbers to output.txt");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to exit");
            if (Array.IndexOf(args, "-q") == -1 & Array.IndexOf(args, "/q") == -1) Console.ReadKey();
        }
    }
}