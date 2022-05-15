using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1;



namespace TestAtlasProject
{
    [TestClass]
    public class TestProject
    {
        [TestMethod]
        public void TestCheckPass()
        {
            MyLogic ml = new MyLogic();
            int a = 13924;
            int b = 16418;
            int c = 13924;
            bool result = ml.CheckPass(a, b, c);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void Testlogin()
        {
            

        }
    }
}
