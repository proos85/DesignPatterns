using System;
using System.Text;

namespace Patterns
{
    static class Program
    {
        static void Main()
        {
            SetConsoleOutputEncoding();
            RunFactoryPaternExamples();
        }

        private static void SetConsoleOutputEncoding()
        {
            Console.OutputEncoding = Encoding.UTF8;
        }

        private static void RunFactoryPaternExamples()
        {
            //RunFactoryExamples();
            //RunDecoratorExamples();
            RunFinalWithTestingExamples();
        }

        private static void RunFactoryExamples()
        {
            //Factories._1_Creating_Basic_Pizza.Example.Run();
            //Factories._2_Simple_Factory.Example.Run();
            //Factories._3_Factory_Method.Example.Run();
            //Factories._4_Abstract_Factory.Example.Run();
        }

        private static void RunDecoratorExamples()
        {
            //Decorator._1_Decorated_Classes.Example.Run();
            //Decorator._2_Correct_Use_Of_Decorator.Example.Run();
            //Decorator._3_Apply_Decorated_Ingredients_With_Builder.Example.Run();
        }

        private static void RunFinalWithTestingExamples()
        {
            Testing._1_With_Testing.Example.Run();
        }
    }
}
