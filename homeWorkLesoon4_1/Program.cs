using System;

namespace homeWorkLesoon4_1
{
    class Program
    {
        public delegate dynamic SimpleOperation(int firstNumber, int secondNumber);
        static void Main(string[] args)
        {
            SimpleOperation myDelegateAdd = new SimpleOperation(Calculator.Add);
            SimpleOperation myDelegateSub = new SimpleOperation(Calculator.Sub);
            SimpleOperation myDelegateMult = new SimpleOperation(Calculator.Mult);
            SimpleOperation myDelegateDiv = new SimpleOperation(Calculator.Div);

            Console.WriteLine(myDelegateAdd(10, 5));
            Console.WriteLine(myDelegateSub(10, 5));
            Console.WriteLine(myDelegateMult(3, 6));
            Console.WriteLine(myDelegateDiv(12, 3));


            Console.ReadKey();
        }
    }
}
