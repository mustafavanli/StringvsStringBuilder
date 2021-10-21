using System;
using System.Diagnostics;
using System.Text;

namespace StringvsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new Test();
            //t.Id = 5;
            //Console.WriteLine($"ilk Id : {t.Id}");

            //Test t1 = t;
            //t1.Id = 10;

            //Console.WriteLine($"t.Id : {t.Id}  t1.Id : {t1.Id}");

            //string tStr = "mustafa";
            //string tStr1 = "ahmet";

            //string fullname = tStr + tStr1;
            //tStr += "cantekin";
            //Console.WriteLine($"tStr : {tStr} tStr1 : {tStr1} FullName : {fullname}");

            //int i = 1;

            //int j = i;
            //i = 10;
            //Console.WriteLine($" i : {i }   j : {j}");

            int counter = 1000;
            Stopwatch sw = Stopwatch.StartNew();
            string text = "";

            for (int i = 0; i < counter; i++)
            {
                text += i.ToString();
            }
            sw.Stop();
            long stringms = sw.ElapsedMilliseconds;

            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < counter ; i++)
            {
                sb.Append(i.ToString());
            }
            sw.Stop();

            Console.WriteLine("Total MS for string: " + stringms);
            Console.WriteLine("Total MS for StringBuilder: " + sw.ElapsedMilliseconds);

            Console.Read();
        }
        public class Test
        {
            public int Id { get; set; }
        }
    }
}
