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
            //E.words("I am in QA");
            //E.find("i am, going, am to london", "am");
            //E.verticalSentence("i am going to qa");
            E.verticalSentenceReverse("i am going to qa");
        }

        class English
        {
            public void words(string sentence)
            {
                string[] numWords = sentence.Split(' ');

                Console.Write(numWords.Length);
                Console.Read();

            }

            public void find(string message, string findWhat)
            {
                int occurances = 0;

                for (int i = 0; i < (message.Length - findWhat.Length + 1); i++)
                {
                    if (message.Substring(i, findWhat.Length) == findWhat)
                    {
                        occurances++;
                    }

                }
                Console.Write(occurances);
                Console.Read();
            }

            public void verticalSentence(string sentence)
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] != ' ')
                    {
                        Console.Write(sentence[i]);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                    Console.Read();
                }

            public void verticalSentenceReverse(string sentence)
            {
                for (int i = sentence.Length; i == 0; i--)
                {
                    if (sentence[i] != ' ')
                    {
                        Console.Write(sentence[i]);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                Console.Read();
            }
        }

        }
    }
