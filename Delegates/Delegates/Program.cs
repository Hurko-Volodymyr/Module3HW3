namespace Delegates
{
    internal class Program
    {
        public static void Show(bool status)
        {
            Console.WriteLine(status);
        }

        private static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();
            Console.WriteLine("True scenario:");
            class2.Calc(class2.PowDelegate, 4, 4);
            class2.Result(8);
            class1.ShowHandler = Show;
            class1.ShowHandler.Invoke(class2.Status);
            Console.WriteLine("False scenario:");
            class2.Calc(class2.PowDelegate, 3, 4);
            class2.Result(5);
            class1.ShowHandler.Invoke(class2.Status);
        }
    }
}