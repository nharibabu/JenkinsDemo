using System;
using NUnit.Framework;
using JenkinsDemo.Controllers;

namespace JenkinsDemoTest
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void AddTest()
        {
            // Unit Testing 
            HomeController ctrl = new HomeController();
            int sum = ctrl.Add(1, 2);
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void SubtractTest()
        {
            HomeController ctrl = new HomeController();
            int sub = ctrl.Subtract(2, 1);
            Assert.AreEqual(1, sub);
        }
    }
}
