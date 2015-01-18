using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace loginuser.cs
{
    public class User
    {
        private string usernameInput;
        private string passwordInput;


        // Kapslar in 'usernameInput' och returnerar dess värde.
        // Är användarnamnet (strängen) i fel format skrivs lämpligt meddelande ut. 
        public string UsernameInput
        {
            get
            {
                return usernameInput;
            }
            set
            {
                if (!CheckUsernameInput(value))
                {
                    throw new ArgumentException("Inkorrekt inmatning av användarnamn.");
                }

                usernameInput = value;
            }
        }

        // Kapslar in 'passwordInput' och returnerar dess värde. 
        // Är lösenordet (strängen) i fel format skrivs lämpligt meddelande ut. 
        public string PasswordInput
        {
            get
            {
                return passwordInput;
            }
            set
            {
                if (!CheckPasswordInput(value))
                {
                    throw new ArgumentException("Inkorrekt inmatning! Lösenordet måste innehålla 4-8 tecken och minst en siffra.\n");
                }

                passwordInput = value;
            }
        }

        // Kontrollerar att användarnamnet (strängen) har korrekt format.
        public bool CheckUsernameInput(string username)
        {
            return Regex.IsMatch(username, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        }

        // Kontrollerar att lösenordet (strängen) har korrekt format.
        public bool CheckPasswordInput(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d).{4,8}$");
        }

        // Konstruktor med parametrar.
        public User(string username, string password)
        {
            UsernameInput = username;
            PasswordInput = password;
        }

        // Tom konstruktor.
        public User(){}
    }
}
