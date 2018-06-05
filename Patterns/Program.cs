namespace Patterns
{
    static class Program
    {
        static void Main()
        {
            RunFactoryPaternExamples();
        }

        private static void RunFactoryPaternExamples()
        {
            //RunFactoryExamples();
            RunDecoratorExamples();
        }

        private static void RunFactoryExamples()
        {
            Factories._1_Creating_Basic_Pizza.Example.Run();
            //Factories._2_Simple_Factory.Example.Run();
            //Factories._3_Factory_Method.Example.Run();
            //Factories._4_Abstract_Factory.Example.Run();
        }

        private static void RunDecoratorExamples()
        {
            Decorator._1_Creating_Basic_Pizza.Example.Run();
            Decorator._2_Simple_Factory.Example.Run();
            Decorator._3_Factory_Method.Example.Run();
            Decorator._4_Abstract_Factory.Example.Run();
        }
    }
}
