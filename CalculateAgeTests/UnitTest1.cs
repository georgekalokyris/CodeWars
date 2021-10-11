using NUnit.Framework;
using System;


namespace CalculateAgeTests
{
    
    public class Tests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void MyTest()
            {
                Assert.AreEqual("You are 17 years old.", HowOldWillIBeIn2099.CalculateAge(2003, 2020));
                Assert.AreEqual("You are 1 year old.", HowOldWillIBeIn2099.CalculateAge(2019, 2020));
                Assert.AreEqual("You were born this very year!", HowOldWillIBeIn2099.CalculateAge(2003, 2003));
                Assert.AreEqual("You will be born in 17 years.", HowOldWillIBeIn2099.CalculateAge(2020, 2003));
                Assert.AreEqual("You will be born in 1 year.", HowOldWillIBeIn2099.CalculateAge(2020, 2019));
            }
        }
    }
}