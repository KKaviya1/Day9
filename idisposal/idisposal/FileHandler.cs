using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace idisposal
{
    public  class FileHandler : IDisposable
    {
        File fileObject = null;
        static int totalFiles = 0;
        bool disposedvalue;

        public FileHandler(string fileName)
        {
            if(fileObject == null)
            {
                totalFiles++;
                fileObject = new File(fileName);
            }
            Console.WriteLine("file created");
            Console.WriteLine("number of files are:" + totalFiles);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposedvalue)
            {

                if (disposing)
                {
                    totalFiles = 0;
                }
            }
            Console.WriteLine("file {0} has been disposed", fileObject.Name);
            fileObject = null;
            disposedvalue = true;
        }
            public void Dispose()
            {
                Dispose(disposing :true);
                GC.SuppressFinalize(this);
            }
        public void GetFileDetails()
        {
            Console.WriteLine(fileObject.Name+"file has been created successfully");
        }
        ~FileHandler()
        {
            Dispose(false);
        }

        }

    }

