using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK_SumPoints;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitPozitiveTest
    {
        [TestMethod]
        public void PozitiveTestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("1", "2", "3", "4"));
        }
        [TestMethod]
        public void PozitiveTestMethod2()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("10", "2", "3", "4"));
        }
        [TestMethod]
        public void PozitiveTestMethod3()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("10", "3", "3", "4"));
        }
        [TestMethod]
        public void PozitiveTestMethod4()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("10", "20", "10", "10"));
        }
        [TestMethod]
        public void PozitiveTestMethod5()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("10", "50", "30", "4"));
        }
    }
    [TestClass]
    public class UnitNegativeTest
    {
        [TestMethod]
        public void NegativeTestMethod1()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test(" ", "2", "3", "4"));
        }
        [TestMethod]
        public void NegativeTestMethod2()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("1.2", "2", "3", "4"));
        }
        [TestMethod]
        public void NegativeTestMethod3()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("1", "-2", "3", "4"));
        }
        [TestMethod]
        public void NegativeTestMethod4()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("11", "2", "3", "4"));
        }
        [TestMethod]
        public void NegativeTestMethod5()
        {
            MainWindow mainWindow = new MainWindow();
            Assert.IsTrue(mainWindow.Test("л", "о", "ж", "ь"));
        }

    }
}

