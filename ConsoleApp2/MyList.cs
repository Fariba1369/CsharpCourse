using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MyList
    {
        int[] array;
        int[] array2 = { 5, 6, 7};

        //public static void MyMetod(int input)
        //{
        //    // definition
        //}

        public MyList()
        {
            array = array2;
        }

        public MyList(int a, int b, int c)
        {
            int[] temp = { a, b, c};
            array = temp;
        }

        public bool Contains(int input)        // 1, 2, 3, 4   Contains(3) => true
        {
            //for(int i=0; i< array.Length; i++)
            //{
            //    if (array[i] == input)
            //        return true;
            //}
            foreach(int n in array)
            {
                if(n == input)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
