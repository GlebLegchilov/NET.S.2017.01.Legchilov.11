using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task3;

namespace Task3Test
{
    class FileStorage : IFileStorage
    {
        public string FileName { get; set; }

        public FileStorage(string fileName = "text.txt")
        {
            FileName = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName);
        }

        public void StoreData(string text)
        {
            using (TextWriter writer = File.CreateText(FileName))
            {
                writer.Write(text);
                writer.Flush();
            }
        }


        public string LoadData()
        {
            using (TextReader reader = File.OpenText(FileName))
                return reader.ReadToEnd();
        }
    }
    
}
