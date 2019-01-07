using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasyIO
{
    public static class FileIO
    {
        /// <summary>
        /// Opens an existing file for reading. 
        /// </summary>
        /// <returns></returns>
        public static FileStream OpenRead(this String name)
        {
            return File.Open(name, FileMode.Open);
        }
    }
}
