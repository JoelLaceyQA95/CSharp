using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_setTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Results peter = new Results();

            peter.physics = 160;
            peter.chemistry = 10;
            peter.maths = 10;

            peter.showResults();
            Console.Read();



        }

        class Results {
            private int phy;
            private int che;
            private int mat;
            private int classesPassed;

            public int physics
            {
                set
                {
                    if(value >= 0 && value <= 150)
                    {
                        phy = value;

                        if (phy >= 60)
                        {
                            classesPassed++;
                        }
                    }
                    else
                    {
                        phy = -1;
                        Console.Write("invalid physics mark ");
                    }
                }

                get
                {
                    return phy;
                }
            }

            public int chemistry
            {
                set
                {
                    if (value >= 0 && value <= 150)
                    {
                        che = value;
                        if (che >= 60)
                        {
                            classesPassed++;
                        }
                    }
                    else
                    {
                        che = -1;
                        Console.Write("invalid chemistry mark ");
                    }
                }

                get
                {
                    return che;
                }
            }

            public int maths
            {
                set
                {
                    if (value >= 0 && value <= 150)
                    {
                        mat = value;
                        if (mat >= 60)
                        {
                            classesPassed++;
                        }
                    }
                    else
                    {
                        mat = -1;
                        Console.Write("invalid maths mark ");
                    }
                }

                get
                {
                    return mat;
                }
            }

            public void showResults()
            {
                if ((phy < 0 || phy > 150) || (che < 0 || che > 150) || (mat < 0 || mat > 150))
                {
                    Console.Write("no results available, re enter marks");
                }
                else
                {
                    int total;
                    float perc;

                    total = phy + che + mat;
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
                        else if (mat < 60)
                        {
                            Console.Write("retake maths! ");
                        }
                    }
                    else if (classesPassed == 1)
                    {
                        Console.Write("repeat the course");
                    }
                    else if (classesPassed == 3)
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
}
