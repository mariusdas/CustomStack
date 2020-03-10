using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    public class CustomStack
    {
        private int[] items;
        private int top = 0;
        private bool max_capacity = false;
        public CustomStack(int capacity)
        {
            items = new int[capacity];
        }

        public void Push(int item)
        {
            if (max_capacity == false)
            {
                items[top] = item;
            }
            if (top + 1 == items.Length)
            {
                if (max_capacity)
                {
                    Console.WriteLine("Stack reached limit of capacity " + items.Length);
                    //throw new ArgumentOutOfRangeException();
                }
                max_capacity = true;
                return;
            }
            top = (top + 1) % items.Length;
        }
        public int Pop()
        {
            if (max_capacity)
            {
                max_capacity = false;
            }
            else
            {
                top = (items.Length + top - 1) % items.Length;
            }

            var return_item = items[top];

            items[top] = 0;

            return return_item;
        }

        public void Add()
        {
            var add1 = this.Pop();
            var add2 = this.Pop();

            var sum = add1 + add2;

            this.Push(sum);

            Console.WriteLine(sum);
        }

        public void Sub()
        {
            var add1 = this.Pop();
            var add2 = this.Pop();

            var sum = add1 - add2;

            if(sum < 0)
            {
                sum = 1024 - ((sum * -1) % 1024);
            }

            this.Push(sum);

            Console.WriteLine(sum);
        }
    }
}
