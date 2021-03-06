﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlockchainRyzhkovy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainRyzhkovy.Tests
{
    [TestClass()]
    public class ChainTests
    {
        [TestMethod()]
        public void ChainTest()
        {
            var chain = new Chain();
            chain.Add("Code blog", "Admin");

            Assert.AreEqual(2, chain.Blocks.Count);
            Assert.AreEqual("Code blog", chain.Last.Data);
           
        }
    }
}