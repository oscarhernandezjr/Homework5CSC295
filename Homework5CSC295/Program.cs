using System;

namespace ParenthesisCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an expression to check if balanced:");
            string expression = Console.ReadLine();

            bool isBalanced = ParenthesisChecker.IsBalanced(expression);
            if (isBalanced)
            {
                Console.WriteLine("Expression is balanced.");
            }
            else
            {
                Console.WriteLine("Expression is not balanced.");
            }

            // Additional test cases can be ran here
            RunSampleTests();
        }

        static void RunSampleTests()
        {
            string[] testExpressions = {
                "",
                "()",
                "[{}]",
                "({[]})",
                "({[})",
                "[(])",
                "No parentheses here",

            };

            Console.WriteLine("\nRunning sample tests:");
            foreach (string expr in testExpressions)
            {
                bool result = ParenthesisChecker.IsBalanced(expr);
                Console.WriteLine($"Expression: {expr} -> Balanced: {result}");
            }
        }
    }
}
