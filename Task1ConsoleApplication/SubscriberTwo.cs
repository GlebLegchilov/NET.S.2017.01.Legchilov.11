using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1ConsoleApplication
{
    class SubscriberTwo
    {
        public void Register(Clock clock)
        {
            clock.NewSub += SubscriberTwoMsg;
        }

        public void Unregister(Clock clock)
        {
            clock.NewSub -= SubscriberTwoMsg;
        }

        private void SubscriberTwoMsg(object sender, ClockEventArgs eventArgs)
        {
            Console.WriteLine("SubscriberOne:");
            Console.WriteLine("Timer value = {0}, Subscribers number = {1}", eventArgs.Seconds, eventArgs.SubNumber);
        }
    }
}
