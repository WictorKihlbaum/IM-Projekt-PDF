using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class FormTesting
    {
        public static void ValidateUserAccess()
        {
            Console.WriteLine("\nITERATION 2: EN JURY VILL MATA IN SINA POÄNG FÖR VIDARE BERÄKNINGAR");
            SetTopicColor("\nValiderar huruvida användaren är inloggad,");
            SetTopicColor("och således tillåten att initiera funktion.\n");

            var userAccount = new UserAccount();

            Console.Write("Test 1: ");
            try
            {
                bool logged = true;
                userAccount.Logged = logged;

                SetColor("Användaren är tillåten att initiera funktion.", true);
                InitiateFunction();
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

        public static void InitiateFunction()
        {
            Console.WriteLine("\tFunktion initieras.");
            Console.WriteLine("\tFormulär visas.\n");
        }

        public static void ValidateGivenPoint()
        {
            SetTopicColor("\nValiderar värdet på gymnastens tilldelade poäng.\n");

            var gymnastPoints = new Form();

            Console.Write("Test 1: ");
            try
            {
                int point = 8;
                gymnastPoints.GivenPoint = point;

                SetColor("Tilldelat värde OK.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                int point = 12;
                gymnastPoints.GivenPoint = point;

                SetColor("ValidateGivenPoint misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 3: ");
            try
            {
                int point = 0;
                gymnastPoints.GivenPoint = point;

                SetColor("ValidateGivenPoint misslyckades", false);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }
        }

        public static void ValidateAveragePointFields()
        {
            SetTopicColor("\nValiderar en gymnasts tilldelade poäng i en gren.\n");
            var gymnastPoints = new Form();

            Console.Write("Test 1: ");
            try
            {
                int point1 = 9;
                int point2 = 3;
                int point3 = 5;
                int point4 = 7;
                int point5 = 5;

                gymnastPoints.GymnastPoint1 = point1;
                gymnastPoints.GymnastPoint2 = point2;
                gymnastPoints.GymnastPoint3 = point3;
                gymnastPoints.GymnastPoint4 = point4;
                gymnastPoints.GymnastPoint5 = point5;

                gymnastPoints.CalculateAveragePoint();
            }
            catch
            {
                SetColor("Ett eller flera poängfält var inkorrekt inmatade,", false);
                SetColor("\tuträkning av medelpoäng kan inte initieras.\n", false);
            }

            Console.Write("Test 2: ");
            try
            {
                int point1 = 9;
                int point2 = 0;
                int point3 = 0;
                int point4 = 7;
                int point5 = 11;

                gymnastPoints.GymnastPoint1 = point1;
                gymnastPoints.GymnastPoint2 = point2;
                gymnastPoints.GymnastPoint3 = point3;
                gymnastPoints.GymnastPoint4 = point4;
                gymnastPoints.GymnastPoint5 = point5;

                SetColor("ValidateAveragePointFields misslyckades", false);
            }
            catch
            {
                SetColor("Ett eller flera poängfält var inkorrekt inmatade,", false);
                SetColor("\tuträkning av medelpoäng kan inte initieras.\n", false);
            }
        }

        public static void ValidateTeamPointFields()
        {
            SetTopicColor("Validerar gymnasternas tillsatta medelpoäng.\n");
            var gymnastPoints = new Form();

            Console.Write("Test 1: ");
            try
            {
                int point1 = 7;
                int point2 = 4;
                int point3 = 2;
                int point4 = 9;
                int point5 = 6;

                gymnastPoints.GymnastPoint1 = point1;
                gymnastPoints.GymnastPoint2 = point2;
                gymnastPoints.GymnastPoint3 = point3;
                gymnastPoints.GymnastPoint4 = point4;
                gymnastPoints.GymnastPoint5 = point5;

                gymnastPoints.CalculateTeamPoint();
            }
            catch
            {
                SetColor("Ett eller flera poängfält var inkorrekt inmatade,", false); 
                SetColor("\tuträkning av lagpoäng kan inte initieras.\n", false);
            }

            Console.Write("Test 2: ");
            try
            {
                int point1 = 0;
                int point2 = 4;
                int point3 = 12;
                int point4 = 9;
                int point5 = 6;

                gymnastPoints.GymnastPoint1 = point1;
                gymnastPoints.GymnastPoint2 = point2;
                gymnastPoints.GymnastPoint3 = point3;
                gymnastPoints.GymnastPoint4 = point4;
                gymnastPoints.GymnastPoint5 = point5;

                SetColor("ValidateTeamPointFields misslyckades", false);
            }
            catch
            {
                SetColor("Ett eller flera poängfält var inkorrekt inmatade,", false);
                SetColor("\tuträkning av lagpoäng kan inte initieras.\n", false);
            }
        }

        public static void ValidateStoredFiles()
        {
            SetTopicColor("Validerar huruvida filen med resultat har skickats in och lagrats i systemet.\n");
            var storedFiles = new StoredFiles();

            Console.Write("Test 1: ");
            try
            {
                var files = 99999;
                storedFiles.Files = files + 1;

                SetColor("Filen lagrades korrekt i systemet.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
            }

            Console.Write("Test 2: ");
            try
            {
                var files = 100000;
                storedFiles.Files = files + 1;

                SetColor("Filen lagrades korrekt i systemet.", true);
            }
            catch (ArgumentException error)
            {
                SetColor(error.Message, false);
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
