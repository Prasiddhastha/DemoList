using System;
using System.Collections.Generic;
namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);//Add()
            numbers.AddRange(new[] {5, 6, 7});  //AddRange(addarray or list)
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            var index= numbers.IndexOf(5);//IndexOf(value) give index of that value
            Console.WriteLine();
            Console.WriteLine("index of 5 is "+index);
            Console.WriteLine("Last index of 1 is " + numbers.LastIndexOf(1));//last index of 1 i.e 4
            Console.WriteLine("Count: "+numbers.Count);//var.Count ->gives count of list
            Console.WriteLine();
             numbers.Remove(1);//var.Remove(value)->remove that value
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.RemoveAt(3);//var.RemoveAt(index of the number which u want to remove)
            Console.WriteLine();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            numbers.Clear();
            Console.WriteLine("Count: "+numbers.Count);
        }
    }
}
