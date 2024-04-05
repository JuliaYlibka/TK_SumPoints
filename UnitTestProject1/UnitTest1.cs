using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK_SumPoints;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Test("1", "2", "3", "4");
        }
        [TestMethod]
        public void TestMethod2()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Test(" ","","60","10");
        }
    }
}
