using System;
using System.Collections.Generic;
using System.Linq;

namespace P66
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var r = s.PlusOne(new []{9});

            Console.WriteLine("Result: "+string.Join(",", r));
        }
    }

    public class Solution {
        public int[] PlusOne(int[] digits) {
            var result = new List<int>();
            
            var add = 1;
            for(int i=digits.Length-1; i>=0; --i){
                var v = digits[i] + add;
                
                if(v >= 10){
                    add = 1;
                    v -= 10;
                }else{
                    add = 0;
                }
                result.Add(v);
            }
            
            if(add>0){
                result.Add(add);
            }
            
            return result.Reverse<int>().ToArray<int>();
        }
    }
}
