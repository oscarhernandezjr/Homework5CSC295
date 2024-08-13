using System;
using System.Collections;

namespace ParenthesisCheckerApp
{
    public class ParenthesisChecker
    {
        public static bool IsBalanced(string expression)
        {
            // If expression is empty, then it is balanced
            if (string.IsNullOrEmpty(expression))
                return true;

            Stack stack = new Stack();

            foreach (char ch in expression)
            {
                // Push  brackets onto  stack
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char lastOpened = (char)stack.Pop();
                    if (!BracketsMatch(lastOpened, ch))
                        return false;
                }
            }

            // If stack is empty, then it is balanced
            return stack.Count == 0;
        }

        private static bool BracketsMatch(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}