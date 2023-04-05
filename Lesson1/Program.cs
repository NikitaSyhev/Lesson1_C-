using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1

{ 
    public class MyTest
    {
        public int a = 23;
        public MyTest()
           
    {
        Console.WriteLine("Object created");
    }
         public int myDouble(int _arg)
        {
            return _arg * 2;
        }
}

    internal class Program
    {
        static void myConvert(string _prompt, out int? a)   // out модицифкатор
        {
            // int a = 0;
            a = null;
            Console.WriteLine(_prompt);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
          //  return a;
        }

        static void Main(string[] args)
        {
            int a = 4;
            int? a1 = null; // int ? расширенный int который может принимать значение null
            string b = "6a";
            while (a1 == null)
            {
                myConvert("Enter a number: ", out a1);
            }
            //  myConvert("Введите число: ", out a1);
            var aaa = new MyTest();
           // Console.WriteLine(aaa.myDouble(a)); 
            Console.WriteLine(a+b);

            int[] arr =  new int[3] { 1, 2, 3 };
            foreach (var i in arr)
            {
                Console.Write(i +" ");
             
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            var list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
                Console.WriteLine(list[i]);
            }
            list.Add(-7);
            int counter = 0;
            foreach (var item in list)
            {
                Console.Write("{0} равен {1}", counter, item); //placeholder
                Console.Write($"Элемент { counter} равен { item}\n"); ; ; // идентиченая запись, вместо $ можно записать эскейп последовательность
                counter++;
            }


            Console.ReadKey();
        }

    }
}
