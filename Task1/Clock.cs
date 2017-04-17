using System;
using System.Linq;
using System.Threading;

namespace Task1
{
    public class Clock
    {
        public event EventHandler<ClockEventArgs> NewSub = delegate { };

        /// <summary>
        /// Start timer
        /// </summary>
        /// <param name="seconds">Timer's seconds</param>
        public void Start(int seconds)
        {
            if (seconds < 0) throw new ArgumentException("{0} must be positive", nameof(seconds));
            TimerCallback tm = new TimerCallback(OnEndTime);
            Timer timer = new Timer(tm, seconds.ToString(), seconds, Timeout.Infinite);
        }

        /// <summary>
        /// Callback function
        /// </summary>
        /// <param name="obj">Timer's seconds</param>
        private void OnEndTime(object obj)
        {
            EventHandler<ClockEventArgs> temp = NewSub;
            temp?.Invoke(this, new ClockEventArgs((string)obj, (temp.GetInvocationList().Count() - 1).ToString()));
        }
    }
}
