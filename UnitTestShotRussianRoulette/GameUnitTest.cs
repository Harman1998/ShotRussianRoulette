using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShotRussianRoulette
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                ShotRussianRoulette.GameLogic test = new ShotRussianRoulette.GameLogic();

                int testResult = test.SpinGun();

                Assert.IsTrue(testResult < 7);

            }
        }

         [TestMethod]
        public void TestMethod2()
        {
            ShotRussianRoulette.GameLogic test = new ShotRussianRoulette.GameLogic();

            int testResult2 = test.FireGun();

                Assert.IsTrue(testResult2 < 4);

            }
        }
    }

