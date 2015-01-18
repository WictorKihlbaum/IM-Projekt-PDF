using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace loginuser.cs
{
    public class ApplyTeam
    {
        private string teamName;
        private int numberOfGymnasts;
        private string gymnastName;
        private int gymnastAge;
        private string gymnastGender;

        public string TeamName
        {
            get
            {
                return teamName;
            }
            set
            {
                if (!CheckTeamNameInput(value))
                {
                    throw new ArgumentException("Lagnamnet får endast bestå av 3-25 tecken.");
                }

                teamName = value;
            }
        }

        public int NumberOfGymnasts
        {
            get
            {
                return numberOfGymnasts;
            }
            set
            {
                if (value < 5 || value > 12)
                {
                    throw new ArgumentException("Laget får endast bestå av 5-12 gymnaster.");
                }
                
                numberOfGymnasts = value;
            }
        }

        public string GymnastName
        {
            get
            {
                return gymnastName;
            }
            set
            {
                if (!CheckGymnastName(value))
                {
                    throw new ArgumentException("Inmatat namn tillåts ej.");
                }

                gymnastName = value;
            }
        }

        public int GymnastAge
        {
            get
            {
                return gymnastAge;
            }
            set
            {
                if (value < 12)
                {
                    throw new ArgumentException("Gymnast tillåts ej delta pga låg ålder.");
                }
                else if (value > 80)
                {
                    throw new ArgumentException("Gymnast tillåts ej delta pga hög ålder.");
                }

                gymnastAge = value;
            }
        }

        public string GymnastGender
        {
            get
            {
                return gymnastGender;
            }
            set
            {
                if (!CheckGymnastGender(value))
                {
                    throw new ArgumentException("Svar tillåts ej. Var god ange kön igen ('M', 'Male', 'F', 'Female').");
                }

                gymnastGender = value;
            }
        }

        public bool CheckTeamNameInput(string teamName)
        {
            return Regex.IsMatch(teamName, @"^.{3,25}$");
        }

        public bool CheckGymnastName(string gymnastName)
        {
            return Regex.IsMatch(gymnastName, @"^[A-Za-z\s]{1,}[\.]{0,1}[A-Za-z\s]{0,}$");
        }

        public bool CheckGymnastGender(string gymnastGender)
        {
            return Regex.IsMatch(gymnastGender, @"^M(ale)?$|^F(emale)?$");
        }

        public ApplyTeam(string teamName, int numberOfGymnasts, string gymnastName, int gymnastAge, string gymnastGender)
        {
            TeamName = teamName;
            NumberOfGymnasts = numberOfGymnasts;
            GymnastName = gymnastName;
            GymnastAge = gymnastAge;
            GymnastGender = gymnastGender;
        }

        public ApplyTeam(){}
    }
}
