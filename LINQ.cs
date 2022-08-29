using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Random;

namespace C_Sharp_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program1();
            //Program2();
            Program3();
            //Program4();
            Console.ReadKey(true);
        }

         static void Program1()
        {
            int[] arr1 = { 4, 5, -12, 5, -3, -5, 1, 34 };


            var query = from i in arr1
                        group i by i < 0;
            Console.WriteLine("Start \n");

            foreach (var item in query)
            {
                foreach (var elem in item)
                {
                    Console.WriteLine($"{elem}\t");
                }
                Console.WriteLine();
            }
        }
         static void Program2()
        {
            int D = 7;
            List<int> list1 = new List<int> { -10, 21, 46, 9, 10, -33, 77, 965, -80 };

            var result1 = list1.FirstOrDefault(x => (x > 0) && (x % 10 == D));

            Console.WriteLine(result1);
            Console.ReadKey();
        }

        static void Program3()
        {
            try
            {
                string[] A = { "ZXC is DOTA" ,
               "SHADOW FIEND" +
               "NECROPHOS",
                "ZXCURSED",
                 "HOMO"};
                int L = 24;
                IEnumerable<string>? query = from i in A
                                             where i.Length == L
                                             where Char.IsDigit(i[0]) == true
                                             select i;
                string? Str = "Not found";
                string? Temp = query.Last() ?? Str;
                Console.WriteLine(Temp);
            }
            catch (InvalidOperationException ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Program4()
        {
            int[] Arr = new int[] { 23, -12, 67, 34, 67, 23, 54, 89, -37, -67, 89 };
            IEnumerable<int>? query = from i in Arr.Select(i => i % 10).Where(i => i > 0).Distinct()
                                      select i;
            foreach (int i in query)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
