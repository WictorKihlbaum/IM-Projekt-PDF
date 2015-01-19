using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginuser.cs
{
    public class StoredFiles
    {
        private int files;

        public int Files
        {
            get
            {
                return files;
            }
            set
            {
                if (value > 100000)
                {
                    throw new ArgumentException("Systemets utrymme överbelastat! Filen lagrades inte.\n");
                }

                files = value;
            }
        }

        public StoredFiles(int files)
        {
            Files = files;
        }

        public StoredFiles(){}
    }
}
