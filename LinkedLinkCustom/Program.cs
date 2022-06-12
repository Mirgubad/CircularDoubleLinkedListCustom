using System;
using System.Collections.Generic;

namespace LinkedLinkCustom
{
    class Program
    {

        static void Main(string[] args)
        {
          
            MyDoubleLinkedList<int> nums = new();
            nums.AddFirst(9);
            nums.AddFirst(10);
            nums.AddFirst(11);
            nums.AddLast(32);

            Console.WriteLine($"Count is:{nums.Count}");
        
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
             
        }
    }
}
