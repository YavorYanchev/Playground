﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContosoUniversity.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(false);
        }
    }
}
