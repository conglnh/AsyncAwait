using System;
using System.Threading;

namespace AsyncAwaitBeginner
{
    public class ThreadClass
    {
        private static readonly Thread NewThread = new Thread(WriteB);
        private static readonly Thread ThreadParameter = new Thread(Print);
        public static void ThreadWithoutParameter()
        {
            Console.WriteLine("Create new thread....\n");

            var t = new Thread((obj) =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + "*********");
                    Thread.Sleep(70);
                };
            });
            Console.WriteLine("Start new thread....\n");

            NewThread.Start();
            NewThread.Join();
            Console.Write(NewThread.ThreadState);
            //t.Start("123");
            //for (var i = 0; i < 50; i++)
            //{
            //    Console.WriteLine("NUMBER" + i);
            //    Thread.Sleep(70);
            //}
        } 

        public static void ThreadWithParamater()
        {
            ThreadParameter.Start(new Student
            {
                Name = "Cong",
                BirthDay = DateTime.Now,
            });
        }

        public static void WriteB()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.Write("B : " + i);
                 
                Thread.Sleep(100);
            }
        }

        public static void Print(object student)
        {
            Student st = (Student)student;
            Console.Write(st.Name + "\t" + st.BirthDay.ToShortDateString());
        }
    }

    class Student
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
