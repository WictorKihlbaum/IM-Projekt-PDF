using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class Form
    {
        private int givenPoint;

        private int gymnastPoint1;
        private int gymnastPoint2;
        private int gymnastPoint3;
        private int gymnastPoint4;
        private int gymnastPoint5;

        public int GivenPoint
        {
            get
            {
                return givenPoint;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                givenPoint = value;
            }
        }

        public int GymnastPoint1
        {
            get
            {
                return gymnastPoint1;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                gymnastPoint1 = value;
            }
        }

        public int GymnastPoint2
        {
            get
            {
                return gymnastPoint2;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                gymnastPoint2 = value;
            }
        }

        public int GymnastPoint3
        {
            get
            {
                return gymnastPoint3;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                gymnastPoint3 = value;
            }
        }

        public int GymnastPoint4
        {
            get
            {
                return gymnastPoint4;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                gymnastPoint4 = value;
            }
        }

        public int GymnastPoint5
        {
            get
            {
                return gymnastPoint5;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Inmatat poäng för lågt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }
                else if (value > 10)
                {
                    throw new ArgumentException("Inmatat poäng för högt. Gymnasten kan enbast tilldelas poäng 1-10.");
                }

                gymnastPoint5 = value;
            }
        }

        public void CalculateAveragePoint()
        {
            SetColor("Samtliga poängfält OK. Uträkning av medelpoäng initieras.", true);

            int averagePoint = (gymnastPoint1 + gymnastPoint2 + gymnastPoint3 + gymnastPoint4 + gymnastPoint5) / 5;
            Console.WriteLine("\t(Det uträknade medelpoänget är {0}).", averagePoint);
        }

        public void CalculateTeamPoint()
        {
            SetColor("Samtliga poängfält OK. Uträkning av lagpoäng initieras.", true);

            int teamPoint = gymnastPoint1 + gymnastPoint2 + gymnastPoint3 + gymnastPoint4 + gymnastPoint5;
            Console.WriteLine("\t(Det uträknade lagpoänget är {0}).", teamPoint);
        }

        public static void SetColor(string message, bool trueOrFalse)
        {
            if (trueOrFalse == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }

            Console.ResetColor();
        }

        public Form(int givenPoint, int gymnastPoint1, int gymnastPoint2, int gymnastPoint3, int gymnastPoint4, int gymnastPoint5)
        {
            GivenPoint = givenPoint;
            GymnastPoint1 = gymnastPoint1;
            GymnastPoint2 = gymnastPoint2;
            GymnastPoint3 = gymnastPoint3;
            GymnastPoint4 = gymnastPoint4;
            GymnastPoint5 = gymnastPoint5;
        }

        public Form(){}
    }
}
