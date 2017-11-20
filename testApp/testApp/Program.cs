using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            one T = new one();
            //T.message();

            results Peter = new results();
            results Smith = new results();

            Peter.physics(100);
            Peter.chemistry(50);
            Peter.maths(50);

            Peter.showResults();
    
            Console.Read();
          

        }
    }


    class one
    {
        public void message()
        {
            Console.Write("Hello my friend");
            Console.Read();
        }
    }

    class results
    {
        private int phy, che, math;

        private int classesPassed = 0;

        public void physics(int mark)
        {
            if(mark >= 0 && mark <= 150)
            {
                phy = mark;

                if (phy >= 60)
                {
                    classesPassed++;
                }
            }
            else
            {
                Console.Write("invalid physics mark ");
            }
        }

        public void chemistry(int mark)
        {
            if (mark >= 0 && mark <= 150)
            {
                che = mark;

                if(che >= 60)
                {
                    classesPassed++;
                }
            }
            else
            {
                Console.Write("invalid chemistry mark ");
            }
        }

        public void maths(int mark)
        {
            if (mark >= 0 && mark <= 150)
            {
                math = mark;

                if (math >= 60)
                {
                    classesPassed++;
                }
            }
            else
            {
                Console.Write("invalid maths mark ");
            }
        }

        public void showResults()
        {
            if ((phy < 0 || phy > 150) || (che < 0 || che > 150) || (math < 0 || math > 150))
            {
                Console.Write("no results available, re enter marks");
            }
            else
            {
                int total;
                float perc;

                total = phy + che + math;
                perc = (float)(total * 100) / 450;
                if (classesPassed == 2)
                {
                    if (che < 60)
                    {
                        Console.Write("retake chemistry! ");
                    }
                    else if (phy < 60)
                    {
                        Console.Write("retake physics! ");
                    }
                    else if (math < 60)
                    {
                        Console.Write("retake maths! ");
                    }
                }else if(classesPassed == 1)
                {
                    Console.Write("repeat the course");
                }
                else if(classesPassed == 3)
                {
                    Console.Write("total marks: " + total + " ");
                    Console.Write("percentage: " + perc + " ");
                    Console.Read();
                }
                else
                {
                    Console.Write("go home!");
                }

            }
        }
    }
}
