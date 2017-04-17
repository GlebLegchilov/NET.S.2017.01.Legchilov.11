using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public sealed class ClockEventArgs : EventArgs
    {
        /// <summary>
        /// Timer's seconds
        /// </summary>
        public string Seconds { get;}
        /// <summary>
        /// Subscribers number
        /// </summary>
        public string SubNumber { get; }

        /// <summary>
        /// Initilasi ClockEventArgs's object
        /// </summary>
        /// <param name="seconds">Timer's seconds</param>
        /// <param name="subs">Subscribers number</param>
        public ClockEventArgs(string seconds, string subs)
        {
            if (string.IsNullOrEmpty(seconds)) throw new ArgumentNullException(nameof(seconds));
            if (string.IsNullOrEmpty(subs)) throw new ArgumentNullException(nameof(subs));
            SubNumber = subs;
            Seconds = seconds;
        }
    }
}
