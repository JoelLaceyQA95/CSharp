using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            English E = new English();
            E.words("I am in QA");
        }

        class English
        {
            public void words(string sentence)
            {
                sentence.Split(' ');
                int numWords = sentence.Length;

                Console.Write(numWords);
                Console.Read();
               
            }
        }

    }
}
