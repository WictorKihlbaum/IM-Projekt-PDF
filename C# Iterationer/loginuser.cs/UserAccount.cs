using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class UserAccount
    {
        private bool logged;
        
        public bool Logged
        {
            get
            {
                return logged;
            }
            set
            {
                if (!value)
                {
                    throw new ArgumentException("Användaren är ej tillåten att initiera funktion.");
                }

                logged = value;
            }
        }

        public UserAccount(bool logged)
        {
            Logged = logged;
        }

        public UserAccount(){}
    }
}
