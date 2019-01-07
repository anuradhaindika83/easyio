using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using EasyIO;
using System.IO;

namespace EasyIO.Test
{
    [TestClass]
    public class FileIOTest
    {
        [TestMethod]
        public void OpenReadTest()
        {
            string filename = "testdata\\test.txt";
            var stream = filename.OpenRead();
            Assert.IsNotNull(stream);
            stream.Close();
        }

        [TestMethod]
        public void OpenReadTestFailed()
        {
            string filename = "testdata\\invalidfile.txt";
            Assert.ThrowsException<FileNotFoundException>(() => filename.OpenRead());
            
        }
    }
}
