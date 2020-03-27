using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 3:
            decimal a, b, c;
            String[] nums = Console.ReadLine().Split();
            a = decimal.Parse(nums[0]);
            b = decimal.Parse(nums[1]);
            c = decimal.Parse(nums[2]);
            decimal min_el = Math.Min(Math.Min(a, b), c);
            decimal max_el = Math.Max(Math.Max(a,b), c);
            decimal mid_el = a + b + c - max_el - min_el;
            a = min_el;
            b = mid_el;
            c = max_el;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
 
        }
    }
}
