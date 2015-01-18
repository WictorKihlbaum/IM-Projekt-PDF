using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class Tests
    {
        // Metoden testar samtliga utfall vid inloggning till systemet.
        public static void CompareUserInput()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNedan följer tester på inloggning. Användarnamn och lösenord jämförs.\n");
            Console.ResetColor();

            // Test 1. Lyckad inloggning. Användarnamn och lösenord har lika värden i båda klasser.
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
            
            // Test 2. Misslyckad inloggning #1. Lösenorden har ej lika värde i klasserna.
            try
            {
                var loginSystemTest2 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest2 = new User("wictor.kihlbaum@gmail.com", "hej456");
                loginSystemTest2.validateUserInput(userTest2);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            
            // Test 3. Misslyckad inloggning #2. Användarnamnen har ej lika värde i klasserna.
            try
            {
                var loginSystemTest3 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest3 = new User("wictor@gmail.com", "hej123");
                loginSystemTest3.validateUserInput(userTest3);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }

            // Test 4. Misslyckad inloggning #3. Varken användarnamn eller lösenord har lika värde.
            try
            {
                var loginSystemTest4 = new Loginsystem("wictor.kihlbaum@gmail.com", "hej123");
                var userTest4 = new User("wictor@gmail.com", "hej456");
                loginSystemTest4.validateUserInput(userTest4);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
        }

        // Metoden testar formatet av inmatat användarnamn.
        public static void CheckUsernameFormat()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNedan följer tester på kontroll av användarnamnformat\n");
            Console.ResetColor();

            var userUsernameInput = new User();
            
            // Test 1. Korrekt format.
            try
            {
                userUsernameInput.UsernameInput = "wictor.kihlbaum@gmail.com";
                Console.WriteLine("Korrekt inmatning av användarnamn.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Testet misslyckades");
            }

            // Test 2. Inkorrekt format.
            try
            {
                userUsernameInput.UsernameInput = "wictor.gmail.com";
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
        }
        
        // Metoden testar formatet av inmatat lösenord.
        public static void CheckPasswordFormat()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nNedan följer tester på kontroll av lösenordformat\n");
            Console.ResetColor();

            var userPasswordInput = new User();

            // Test 1. Korrekt format.
            try
            {
                userPasswordInput.PasswordInput = "hej123";
                Console.WriteLine("Korrekt inmatning av lösenord.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Testet misslyckades");
            }

            // Test 2. Inkorrekt format.
            try
            {
                userPasswordInput.PasswordInput = "hej";
            }
            catch (ArgumentException error)
            {
                Console.WriteLine(error.Message);
            }
            
        }
    }
}
