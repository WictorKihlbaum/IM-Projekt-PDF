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
        private bool authority;
        
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

        public bool Authority
        {
            get
            {
                return authority;
            }
            set
            {
                if (value == false)
                {
                    throw new ArgumentException("Publicering misslyckades. Du har ej auktoritet att publicera (detta) dokument.\n");
                }

                authority = value;
            }
        }

        public UserAccount(bool logged, bool authority)
        {
            Logged = logged;
            Authority = authority;
        }

        public UserAccount(){}
    }
}
