using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUi.UnitTestExperiment.AppUi;

namespace WinUi.UnitTestExperiment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new TestViewModel();

            Assert.IsTrue(sut.GetValue(true));
        }
    }
}
