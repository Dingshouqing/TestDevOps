using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDemo.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int x, y;
            x = 20;
            y = 30;
            int sum = Program.Add(x, y);
            Assert.AreEqual(50, sum, "Add result should be same as expected");
        }
    }
}