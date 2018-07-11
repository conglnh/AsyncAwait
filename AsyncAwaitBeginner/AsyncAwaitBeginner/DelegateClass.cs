using System;

namespace AsyncAwaitBeginner
{
    public class DelegateClass
    {

        public delegate string MyDelegate(string firstName, string lastName);

        public static string SayHello(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }

        public static void LetGo()
        {

        }

        public static void LetGo(object value, object test)
        {

        }

        public static void TestDelegate()
        {
            Console.WriteLine("Main thread finished!\n");
            MyDelegate myDelegate = new MyDelegate(DelegateClass.SayHello);
            Console.WriteLine(myDelegate("Cong", "Hoang"));
            Console.Read();
        }
    }
}
