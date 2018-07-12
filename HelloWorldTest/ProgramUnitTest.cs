using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp;
namespace HelloWorldTest
{
    [TestClass]
    public class ProgramUnitTest
    {
        [TestMethod]
        public void DisplayMessageTest()
        {
            Assert.Equals("Hello World", Program.DisplayMessage());
        }
    }
}
