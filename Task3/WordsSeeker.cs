using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    public class WordsSeeker
    {
        public string Text { get; set; }

        /// <summary>
        /// Load text from file
        /// </summary>
        /// <param name="storage"></param>
        public void LoadData(IFileStorage storage)
        {
            if (storage == null) throw new ArgumentNullException(nameof(storage));
            Text = storage.LoadData();
        }

        /// <summary>
        /// Save text in file
        /// </summary>
        /// <param name="storage"></param>
        public void SaveData(IFileStorage storage)
        {
            if (storage == null) throw new ArgumentNullException(nameof(storage));
            storage.StoreData(Text);
        }

        /// <summary>
        /// Seek number of occurrences
        /// </summary>
        /// <param name="value">String for search</param>
        /// <returns>Number of occurrences</returns>
        public int Seek(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
            int result = 0, position = -1;
            do
            {
                position = Text.IndexOf(value, (position + 1));
                if (position >= 0) result++;
            }
            while (position >= 0);
            return result;
        }          
    }
}
