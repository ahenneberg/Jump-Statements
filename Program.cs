/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Statements
{
    class Program
    {
        static void Main()
        {
            /* The C# jump statements are break, continue, goto, return, and throw. 
             
             Jump statements obey the reliability rules of try statements.
             This means that:
             - A jump out of a try block always executes the try's finally block 
             before reaching the target of the jump.
             - A jump cannot be made from the inside to the outside of a finally
             block (except via throw). */

            // The Break Statement
            /* The break statement ends the execution of the body of an iteration
             or switch statement: */
            int x = 0;
            while (true)
            {
                if (x++ > 5)
                    break;      // Break from the loop
            }
            // Execution continues here after the break
            
            // The Continue Statement
            /* The continue statement forgoes the remaining statements in a loop
             and makes an early start on the next iteration. The following loop
             skips even numbers: */
            for (int i = 0; i < 10; i ++)
            {
                if ((i % 2) == 0)   // If i is even,
                    continue;       // continue with next iteration
                Console.WriteLine(i + " ");
                //OUTPUT: 1 3 5 7 9
            }

            // The Goto Statement
            /* The goto statement transfers execution to another label within a
             statement block. The form is as follows: 
               goto statement-label;
             Or, when used within a switch statement:
               goto case case-constant;    // (Only works with constants, not patterns) 
             A label is a placeholder in a code block that precedes a statement,
             denoted with a colon suffix. The following iterates the numbers 1 thru 5,
             mimicking a for loop: */
            int I = 1;
            startLoop:
            if (I <= 5)
            {
                Console.WriteLine(I + " ");
                I++;
                goto startLoop;
                // OUTPUT: 1 2 3 4 5
            }
            /* The goto case case-constant transfers execution to another case in a switch
             block. */

            // Return Statement Example:
            AsPercentage(0.05m);

            // The Throw Statement:
            // The throw statement throws an exception to indicate an error has occurred.
            int w = 1;
            if (w == null)
                throw new ArgumentNullException();

            // Miscellaneous Statements:
            /* The using statement provides an elegant syntax for calling Dispose on objects
             that implement IDisposable, within a finally block. */
            /* The lock statement is a shortcut for calling the Enter and Exit methods of
             the Monitor class (Chapters 14 and 23.) */
        }
        // The Return Statement:
        /* The return statement exits the method and must return an expression of the 
         method's return type if the method is nonvoid: */
         static decimal AsPercentage (decimal d)
        {
            decimal p = d * 100m;
            return p;           // Return to the calling method with value
        }
        // A return statement can appear anywhere in a method (except in a finally block). 
    }
}
