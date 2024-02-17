using System;

namespace Csharp_Quiz_Game
{
    class Program
    {
        static int Score = 0;
        static string input = "A";
        static void Main(string[] args)
        {

            // Question 1
            Console.WriteLine("Who is The Creator Of C# \n A.Bjarne Stroustrup \n B.Tim Berners-Lee \n C.Anders Hejlsberg \n D.Brendan Eich");
            input = Console.ReadLine() ?? "A";
            Question("C",input);

            // Question 2
            Console.WriteLine("What does 'C#' stand for? \n A. C Sharp \n B. Code Language \n C. Core Syntax \n D. Computer Science");
            input = Console.ReadLine() ?? "A";
            Question("A", input);

            // Question 3
            Console.WriteLine("Which programming paradigm does C# primarily follow? \n A. Procedural \n B. Functional \n C. Object-Oriented \n D. Logical");
            input = Console.ReadLine() ?? "A";
            Question("C", input);

            // Question 4
            Console.WriteLine("What is the main purpose of the 'using' statement in C#? \n A. Declaring variables \n B. Including namespaces \n C. Loop iteration \n D. Exception handling");
            input = Console.ReadLine() ?? "A";
            Question("B", input);

            // Question 5
            Console.WriteLine("How do you declare a variable in C#? \n A. var variableName; \n B. int variableName; \n C. variableName as int; \n D. #define variableName");
            input = Console.ReadLine() ?? "A";
            Question("B", input);

           // Question 6
            Console.WriteLine("What is the default access modifier for class members in C#? \n A. Public \n B. Private \n C. Protected \n D. Internal");
            input = Console.ReadLine() ?? "A";
            Question("B", input);

            // Question 7
            Console.WriteLine("Which keyword is used for inheritance in C#? \n A. derive \n B. inherit \n C. extends \n D. : (colon)");
            input = Console.ReadLine() ?? "A";
            Question("D", input);

            // Question 8
            Console.WriteLine("What is the purpose of the 'Main' method in a C# console application? \n A. Initializing variables \n B. Handling exceptions \n C. Entry point of the program \n D. Closing the application");
            input = Console.ReadLine() ?? "A";
            Question("C", input);

            // Question 9
            Console.WriteLine("How do you comment a single line in C#? \n A. // comment \n B. /* comment */ \n C. -- comment \n D. # comment");
            input = Console.ReadLine() ?? "A";
            Question("A", input);

            // Question 10
            Console.WriteLine("What is the role of the 'new' keyword in C#? \n A. Creating a new instance of a class \n B. Declaring a new variable \n C. Defining a new method \n D. Allocating memory for a variable");
            input = Console.ReadLine() ?? "A";
            Question("A", input);

            // Question 11
            Console.WriteLine("Which of the following is a value type in C#? \n A. String \n B. Array \n C. Class \n D. int");
            input = Console.ReadLine() ?? "A";
            Question("D", input);

            // Question 12
            Console.WriteLine("What does the 'var' keyword represent in C#? \n A. Variable \n B. Value \n C. Variant \n D. Compiler-inferred type");
            input = Console.ReadLine() ?? "A";
            Question("D", input);

            // Question 13
            Console.WriteLine("In C#, what is the purpose of the 'StringBuilder' class? \n A. String manipulation with regular expressions \n B. Efficient string concatenation \n C. Handling XML documents \n D. File I/O operations");
            input = Console.ReadLine() ?? "A";
            Question("B", input);

            // Question 14
            Console.WriteLine("Which keyword is used to explicitly raise an exception in C#? \n A. Throw \n B. Raise \n C. Catch \n D. Exception");
            input = Console.ReadLine() ?? "A";
            Question("A", input);

            // Question 15
            Console.WriteLine("What is the difference between 'const' and 'readonly' in C#? \n A. 'const' is for variables, 'readonly' is for fields \n B. 'readonly' is for variables, 'const' is for fields \n C. They are interchangeable \n D. 'readonly' is for methods, 'const' is for properties");
            input = Console.ReadLine() ?? "A";
            Question("A", input);


            Console.WriteLine($"Your Final Score is {Score}/15");
            Console.ReadKey();
        }

        static void Question(string answer , string input)
        {
            if(answer == input)
            {
                Score++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct Answer!!!");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Answer :(");
                Console.ResetColor();
            }
        }
    }
}