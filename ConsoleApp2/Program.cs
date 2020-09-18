using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var mylist = new MyList(1, 2, 3);
            //MyList mylist = new MyList();

            var res = mylist.Contains(3);

            Console.WriteLine(res);

            //var number = 10;

            //string[] arry = { "a1", "b1", "c1" };

            //var list = new List<int>() { 5, 2, 7 };

            //list.Add("d1");
            //var result = list.Contains("c2");
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();
            //list.Sort();
            //Console.WriteLine("count: " + list.Count);
            //list.ForEach(x => Console.WriteLine(x));
            //Console.WriteLine();

            //foreach (var str in list)
            //{
            //    Console.WriteLine(str);
            //}

            //var i = 0;
            //while(i < number)
            //{
            //    var j = 0;
            //    while(j <= i)
            //    {
            //        Console.Write("*  ");
            //        j++;
            //    }
            //    Console.WriteLine("");
            //    i++;
            //}



            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*  ");
            //        //Console.WriteLine("*");
            //    }
            //    Console.WriteLine("");
            //}

            //if(number >= 10 && ctrl)
            //{
            //    Console.WriteLine("in if");
            //}
            //else if(t == 0)
            //{
            //    Console.WriteLine("in else if");
            //}
            //else
            //{
            //    Console.WriteLine("in else");
            //}
        }
    }
}
