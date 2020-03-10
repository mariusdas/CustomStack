using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Check Stack Capacity
            CustomStack stack_capacity_check = new CustomStack(5);
            stack_capacity_check.Push(5);
            stack_capacity_check.Push(3);
            stack_capacity_check.Push(2);
            stack_capacity_check.Push(1);
            stack_capacity_check.Push(56);
            stack_capacity_check.Push(57);

            CustomStack stack_minus_mod_check = new CustomStack(5);
            stack_minus_mod_check.Push(7);
            stack_minus_mod_check.Push(5);
            stack_minus_mod_check.Sub();

            CustomStack stack_check = new CustomStack(5);
            stack_check.Push(10);
            stack_check.Push(7);
            stack_check.Add();
            stack_check.Push(25);
            stack_check.Sub();
            Console.ReadLine();
        }
    }
}
