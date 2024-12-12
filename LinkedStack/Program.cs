using System;
namespace LinkedStack
{

   class StackDrive
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Enter expression to check if balanced or not");
                string exp= Console.ReadLine();
                if (AreBalanced(exp))
                {
                    Console.WriteLine("The expression is balanced");
                }
                else
                {
                    Console.WriteLine("The expression is NOT balanced");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool AreBalanced(string exp)
        {
            Stack<char> stack = new Stack<char>();
            bool valid = true ;
            for(int i=0; i<exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    stack.Push(exp[i]);
                }
               else if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (stack.IsEmpty() || !ArePair(stack.getTop(), exp[i]))
                    {
                       
                             valid=false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                
            }
            if (!stack.IsEmpty())
            {
                valid= false;
            }
          
            return valid;
            
        }

        public static bool ArePair(char open, char close)
        {
            if (open == '(' && close == ')')
                return true;
            else if (open == '{' && close == '}')
                return true;
            else if (open == '[' && close == ']')
                return true;
            else
                return false;
        }

        /*public static bool AreBalanced(string exp)
        {

            Stack<char> stack = new Stack<char>();
            bool valid = true;

             for(int i = 0; i < exp.Length; i++)
             {
                 if (exp[i]=='{' || exp[i]=='(' || exp[i] == '[')
                 {
                     stack.Push(exp[i]);
                 }

                     if (exp[i] == '}')
                     {
                     if (!stack.IsEmpty())
                     {

                         if (stack.PopTop() == '{')
                         {
                             valid = true;
                         }
                         else
                         {
                             valid = false;
                         }
                     }
                     else
                     {
                         valid = false;
                     }

                     }
                     else if (exp[i] == ']')
                     {
                     if (!stack.IsEmpty())
                     {
                         if (stack.PopTop() == '[')
                         {
                             valid = true;
                         }
                         else
                         {
                             valid = false;
                         }
                     }
                     else
                     {
                         valid = false;
                     }

                 }
                     else if (exp[i] == ')')
                     {
                     if (!stack.IsEmpty())
                     {

                         if (stack.PopTop() == '(')
                         {
                             valid = true;
                         }
                         else
                         {
                             valid = false;
                         }
                     }
                     else
                     {
                         valid = false;
                     }

                 }
                 }


             if (!stack.IsEmpty())
             {
                 valid = false;
             }
             return valid;

        }*/




    }

}

