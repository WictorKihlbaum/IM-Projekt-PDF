using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class Integrationtest
    {
        public static void CompareUserInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNedan följer tester vid inloggning.");
            Console.WriteLine("Klassernas användarnamn och lösenord jämförs mot varandra.\n");
            Console.ResetColor();

            // Test 1. Lyckad inloggning. Klassernas användarnamn och lösenord tilldelas lika värde.
            try
            {
                var loginSystemTest1 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest1 = new User("wictor.kihlbaum@gmail.com", "hej123");
                loginSystemTest1.validateUserInput(userTest1);
            }
            catch
            {
                throw new ArgumentException("Testet misslyckades!");
            }
            
            // Test 2. Misslyckad inloggning #1. Klassernas lösenord tilldelas ej lika värde.
            try
            {
                var loginSystemTest2 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest2 = new User("wictor.kihlbaum@gmail.com", "hej456");
                loginSystemTest2.validateUserInput(userTest2);
            }
            catch (ArgumentException error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }

            // Test 3. Misslyckad inloggning #2. Klassernas användarnamn tilldelas ej lika värde.
            try
            {
                var loginSystemTest3 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest3 = new User("wictor@gmail.com", "hej123");
                loginSystemTest3.validateUserInput(userTest3);
            }
            catch (ArgumentException error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }

            // Test 4. Misslyckad inloggning #3. Varken användarnamn eller lösenord tilldelas lika värde.
            try
            {
                var loginSystemTest4 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest4 = new User("wictor@gmail.com", "hej456");
                loginSystemTest4.validateUserInput(userTest4);
            }
            catch (ArgumentException error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }
        }
    }
}
