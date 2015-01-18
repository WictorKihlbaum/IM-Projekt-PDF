using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class Loginsystem
    {
        public string _username;
        public string _password;
        private bool access;

        // Metoden jämför klassernas användarnamn och lösenord mot varandra.
        // Lämpliga meddelanden skrivs ut beroende på vilka värden dessa har.
        public void validateUserInput(User userInput) 
        { 
            if (_username == userInput.UsernameInput && _password == userInput.PasswordInput)
            {
                access = true;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Inloggning lyckades.");
                Console.ResetColor();
            }
            else if (_username == userInput.UsernameInput && _password != userInput.PasswordInput)
            {
                access = false;
                throw new ArgumentException("Inloggning misslyckades. Ditt lösenord är inkorrekt.");
            }
            else if (_username != userInput.UsernameInput && _password == userInput.PasswordInput)
            {
                access = false;
                throw new ArgumentException("Inloggning misslyckades. Ditt användarnamn är inkorrekt.");
            }
            else
            {
                access = false;
                throw new ArgumentException("Inloggning misslyckades. Användarnamn och lösenord stämmer inte överens.");
            }
        }

        // Konstruktor med parametrar.
        public Loginsystem(string username, string password)
        {
            _username = username;
            _password = password;
        }

        // Tom konstruktor.
        public Loginsystem(){}
    }
}
