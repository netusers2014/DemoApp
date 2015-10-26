using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFilter
{
    class TestLambda
    {
        public static void Main(String[] arg)
        {
            List<int> no = new List<int>();
            no.AddRange(new int[] { 20, 30, 40, 50,1,3 });
            // Predicate<int> evenNumber = new Predicate<int>(evenNumbers);
            /* List<int> filter = no.FindAll(delegate(int i)
             {
                 return i % 2 == 0;
             }); */
            //List<int> filter = no.FindAll(i => i % 2 == 0);
            var filter = from n in no where n % 2 == 0 select n;
            foreach (int n in filter)
            {
                System.Console.WriteLine(n);
            }



        }
        static bool evenNumbers(int n)
        {
            return n % 2 == 0;
        }
    }






}
