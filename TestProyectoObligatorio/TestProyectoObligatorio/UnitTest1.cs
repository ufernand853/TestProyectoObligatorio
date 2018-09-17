using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProyectoObligatorio
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SistemFilesOpener TestFileSistemOpener = new SistemFilesOpener();
            TestFileSistemOpener.FileOpener("C:\Test");

        }
    }
}
