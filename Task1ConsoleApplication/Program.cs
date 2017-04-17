using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task1;

namespace Task1ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clock clock = new Clock();
            //SubscriberOne subOne = new SubscriberOne();
            //SubscriberTwo subTwo = new SubscriberTwo();

            //subOne.Register(clock);
            //subTwo.Register(clock);
            //clock.Start(100);

            Console.WriteLine(Seek("text.txt", "Bla"));

            Console.ReadKey();
        }

        public static int Seek(string fileName, string value)
        {
            //using (TextWriter writer = File.CreateText(fileName))
            //{
            //    writer.WriteLine("BlaBloasfasfBla");
            //    writer.WriteLine("BlaBloasfasfBlaBluBlu");
            //    writer.WriteLine("asfafBloafafBla");
            //    writer.WriteLine("BasfaflaafaBlosafafBlaasfasfBluBlu");
            //}

            string line;
            int result = 0, position = -1;
            using (TextReader reader = File.OpenText(fileName))
                while (reader.Peek() > -1)
                {
                    line = reader.ReadLine();
                    do
                    {
                        position = line.IndexOf(value, (position + 1));
                        if (position >= 0) result++;
                    }
                    while (position >= 0);
                }
            return result;
        }
    }
}
