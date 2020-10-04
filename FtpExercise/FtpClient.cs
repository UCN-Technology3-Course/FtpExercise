using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpExercise
{
    class FtpClient
    {
        public IEnumerable<string> GetFileList()
        {
            // TODO: Get list of files from the ftp server and return a list of filenames.

            throw new NotImplementedException();
        }

        public void UploadFile(string localpath)
        {
            // TODO: Upload the file defined in the localpath parameter to the ftp server.

            throw new NotImplementedException();
        }

        public void DownloadFile(string remotefilename)
        {
            // TODO: Download the file defined in the remotefilename from the ftp server and write it to your harddrive.

            throw new NotImplementedException();
        }
    }
}
