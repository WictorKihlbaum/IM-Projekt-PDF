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
        private int markedFiles;

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

        public int MarkedFiles
        {
            get
            {
                return markedFiles;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Publicering ej möjlig. Var god markera ett dokument.");
                }
                else if (value > 1)
                {
                    throw new ArgumentException("Publicering ej möjlig. Du kan endast publicera ett dokument åt gången.");
                }

                markedFiles = value;
            }
        }

        public StoredFiles(int files, int filesToPublish, int markedFiles)
        {
            Files = files;
            FilesToPublish = filesToPublish;
            MarkedFiles = markedFiles;
        }

        public StoredFiles(){}
    }
}
