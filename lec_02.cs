using System;
using System.Collections;
using library_1;
namespace lec_02
{
    class lec_02
    {
        static void Main(string[] args)
        {
            //CONVERSIONS IN DATATYPES
            //from other datatypes to string: we use varName.ToString()
            //from string to other: int.Parse("fsf")
            ////FOR IMPLICIT DATATYPES:
            //var a = 10;
            //Console.WriteLine("a: " + a + "\n");
            ////FOR DYNAMIC:
            //dynamic b = 4;
            //Console.WriteLine("b: " + b + "\n");
            //b = "fd";
            //Console.WriteLine("b: " + b + "\n");
            //FOR EACH LOOP
            //when we typecast using system.covert.ToInt32(), it store value after rounding it off. (int) won't do it.
            //int[] arr = { 1, 2, 3 };
            //foreach(int x in arr)
            //{
            //    Console.Write(x +" ");
            //}
            //ARRAYLIST:
            //ArrayList arr = new ArrayList();
            //arr.Add(1);
            //arr.Add("tre");
            //arr.Add('h');
            //arr.Capacity = 5;
            //Console.WriteLine(arr.Capacity);
            //arr.Add(null);
            ////conversion to original type
            //foreach (var x in arr)
            //{
            //    Console.Write(x + " ");
            //}
            //string x = "r";
            //char y = System.Convert.ToChar(x);
            //Console.WriteLine($"y:{y} x:{x}");
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr[2].GetType());
            Console.WriteLine(Class1.add(1, 2, 3));
        }
    }
}
