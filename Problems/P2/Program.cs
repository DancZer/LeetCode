using System;
using System.Linq;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();


            Console.Write("First:");
            var l1 = ListNode.FromArray(new []{0,1,1});
            l1.Print();

            Console.Write("Second:");
            var l2 = ListNode.FromArray(new []{0,9,9});
            l2.Print();

            var result = s.AddTwoNumbers(l1, l2);

            Console.Write("Result:");
            result.Print();
        }
    }

 public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }

     public static ListNode FromArray(int[] array){
         ListNode node = null;
         ListNode first = null;

         foreach (var v in array)
         {
            if(first == null){
                first = node = new ListNode(v);
            }else{
                node.next = new ListNode(v);
                node = node.next;
            }
         }

         return first;
     }

     public void Print(){
        Console.Write(val);
        var result = next;
        while(result != null){
            Console.Write(",");
            Console.Write(result.val);
            result = result.next;
        }
        Console.WriteLine();
     }
 }

    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode result = new ListNode(l1.val+l2.val);
            
            int addNext = 0;

            //Console.WriteLine("Val:"+result.val);

            if(result.val >= 10){
                addNext = 1;
                result.val -= 10;
            }

            //result.Print();

            var node = result;
            
            l1 = l1?.next;
            l2 = l2?.next;

            //Console.WriteLine("AddNext:"+addNext);

            while(l1 != null || l2 != null){
                var v1 = l1 != null ? l1.val : 0;    
                var v2 = l2 != null ? l2.val : 0;

                node.next = new ListNode(v1 + v2 + addNext);
                node = node.next;
            
                addNext = 0;

                //Console.WriteLine("Val:"+node.val);

                if(node.val >= 10){
                    addNext = 1;
                    node.val -= 10;
                }else{
                    addNext = 0;
                }
                //Console.WriteLine("AddNext:"+addNext);

                l1 = l1?.next;
                l2 = l2?.next;

                //result.Print();
            }

            if(addNext>0){
                node.next = new ListNode(addNext);
            }

            return result;
        }
    }
}
