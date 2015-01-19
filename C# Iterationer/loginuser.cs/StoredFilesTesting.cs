using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class StoredFilesTesting
    {
        public static void ValidateUserAccess()
        {
            Console.WriteLine("\nITERATION 3: PUBLICERING AV LAGRAT DOKUMENT I SYSTEMET");
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
        }

        public static void ValidatePublishableFiles()
        {
            SetTopicColor("\nValiderar mängden publicerbara dokument.\n");
            var storedFiles = new StoredFiles();

            Console.Write("Test 1: ");
            try
            {
                int files = 5;
                storedFiles.FilesToPublish = files;

                Console.WriteLine("Det finns {0} dokument att publicera.", files);
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
