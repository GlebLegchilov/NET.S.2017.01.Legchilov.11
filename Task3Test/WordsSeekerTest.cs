using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;


namespace Task3Test
{
    [TestFixture]
    public class WordsSeekerTest
    {
        [TestCase("blablabbalbroblublabrombfebtw", null)]
        public void Seek_Exeption(string text, string element)
        {
            FileStorage storage = new FileStorage();
            WordsSeeker wordSeeker = new WordsSeeker();
            wordSeeker.Text = text;
            wordSeeker.SaveData(storage);
            wordSeeker = new WordsSeeker();
            wordSeeker.LoadData(storage);
            Assert.Throws<ArgumentNullException> (() => wordSeeker.Seek(element));
        }


        [TestCase("blablabbalbroblublabrombfebtw", "bla", ExpectedResult =3)]
        [TestCase("blablabbalbroblublabrombfebtw", "Игорь", ExpectedResult = 0)]
        [TestCase("Тестовый файл содержит некоторую информацию. Определить частоту встречаемости слов в тексте. Разработать unit-тесты.", "unit", ExpectedResult = 1)]
        public int Seek_positivTest(string text, string element)
        {
            FileStorage storage = new FileStorage();
            WordsSeeker wordSeeker = new WordsSeeker();
            wordSeeker.Text = text;
            wordSeeker.SaveData(storage);
            wordSeeker = new WordsSeeker();
            wordSeeker.LoadData(storage);
            return wordSeeker.Seek(element);
        }
    }
}
