using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class ApplicationTesting
    {
        // Testar om användaren är inloggad.
        public static void ValidateUserAccess()
        {
            Console.WriteLine("\nITERATION 1: ETT LAG VILL ANMÄLA SIG TILL EN TRÄFF");
            SetTopicColor("\nValiderar huruvida användaren är inloggad,");
            SetTopicColor("och således tillåten att initiera funktion.\n");

            var userAccount = new UserAccount();

            Console.Write("Test 1: ");
            try
            {
                bool logged = true;
                    userAccount.Logged = logged;

                SetColor("Användaren är tillåten att initiera funktion.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var logged = false;
                    userAccount.Logged = logged;

                SetColor("ValidateUserAccess misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Testar format på inmatat lagnamn.
        public static void ValidateTeamname()
        {
            SetTopicColor("\nValiderar längden på tillgivet lagnamn.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var givenTeamname = "DettaÄrLagomLångt";
                    teamInfo.TeamName = givenTeamname;

                SetColor("Tilldelat lagnamn OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var givenTeamname = "DettaÄrKanskeAlldelesFörLångt";
                    teamInfo.TeamName = givenTeamname;

                SetColor("ValidateTeamname misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Testar antal inmatade gymnaster.
        public static void ValidateAmountOfGymnasts()
        {
            SetTopicColor("\nValiderar mängden gymnaster.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var amount = 10;
                    teamInfo.NumberOfGymnasts = amount;

                SetColor("Antal lagmedlemmar OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var amount = 13;
                    teamInfo.NumberOfGymnasts = amount;

                    SetColor("ValidateAmountOfGymnasts misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Testar formatet på gymnastens namn.
        public static void ValidateGymnastName()
        {
            SetTopicColor("\nValiderar format på namn.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var gymnastName = "Chuck Norris";
                    teamInfo.GymnastName = gymnastName;

                SetColor("Inmatat namn OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var gymnastName = "Chuck Norris 1337";
                    teamInfo.GymnastName = gymnastName;

                SetColor("ValidateGymnastName misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Följande testar gymnastens ålder.
        public static void ValidateGymnastAge()
        {
            SetTopicColor("\nValiderar värde på ålder.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var gymnastAge = 24;
                    teamInfo.GymnastAge = gymnastAge;

                SetColor("Inmatad ålder OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var gymnastAge = 10;
                    teamInfo.GymnastAge = gymnastAge;

                SetColor("ValidateGymnastAge misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 3: ");
            try
            {
                var gymnastAge = 85;
                    teamInfo.GymnastAge = gymnastAge;

                SetColor("ValidateGymnastAge misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Testar gymnastens genus.
        public static void ValidateGymnastGender()
        {
            SetTopicColor("\nValiderar gymnastens angivna genus.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var gymnastGender = "Male";
                    teamInfo.GymnastGender = gymnastGender;

                SetColor("Inmatat genus OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var gymnastGender = "Females";
                    teamInfo.GymnastGender = gymnastGender;

                SetColor("ValidateGymnastGender misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        // Testar formuläret.
        public static void ValidateForm()
        {
            SetTopicColor("\nValiderar formulärets fält.\n");

            var teamInfo = new ApplyTeam();

            Console.Write("Test 1: ");
            try
            {
                var givenTeamname = "DettaÄrLagomLångt";
                    teamInfo.TeamName = givenTeamname;
                var amount = 10;
                    teamInfo.NumberOfGymnasts = amount;
                var gymnastName = "Chuck Norris";
                    teamInfo.GymnastName = gymnastName;
                var gymnastAge = 24;
                    teamInfo.GymnastAge = gymnastAge;
                var gymnastGender = "Male";
                    teamInfo.GymnastGender = gymnastGender;

                SetColor("Formulärets fält OK", true);
                Console.WriteLine("\tFormulär skickas in och lagras i systemet.");
                Console.WriteLine("\tVerifikation skickas till användaren.\n");
            }
            catch
            {
                SetColor("Ett eller flera fält är inkorrekt inmatade. Var god försök igen.\n", false);
            }

            Console.Write("Test 2: ");
            try
            {
                var givenTeamname = "DettaÄrLagomLångt";
                    teamInfo.TeamName = givenTeamname;
                var amount = 10;
                    teamInfo.NumberOfGymnasts = amount;
                var gymnastName = "Chuck Norris 1337";
                    teamInfo.GymnastName = gymnastName;
                var gymnastAge = 24;
                    teamInfo.GymnastAge = gymnastAge;
                var gymnastGender = "Males";
                    teamInfo.GymnastGender = gymnastGender;

                SetColor("ValidateForm misslyckades", false);
            }
            catch
            {
                SetColor("Ett eller flera fält är inkorrekt inmatade. Var god försök igen.\n", false);
            }
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

        public static void SetTopicColor(string topic)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(topic);
            Console.ResetColor();
        }
    }
}
