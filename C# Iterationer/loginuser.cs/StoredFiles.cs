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
        private int filesToPublish;

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
                    throw new ArgumentException("Systemets utrymme överbelastat! Dokumentet lagrades inte.\n");
                }

                files = value;
            }
        }

        public int FilesToPublish
        {
            get
            {
                return filesToPublish;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Det finns inga lagrade dokument i systemet att publicera.");
                }

                filesToPublish = value;
            }
        }

        public StoredFiles(int files, int filesToPublish)
        {
            Files = files;
            FilesToPublish = filesToPublish;
        }

        public StoredFiles(){}
    }
}
