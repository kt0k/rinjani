﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Rinjani.Tests
{
    [TestClass]
    public class JsonConfigStoreTest
    {
        [TestMethod]
        public void JsonConfigStoreConfigTest()
        {
            var store = new JsonConfigStore("config_test.json", new List<IConfigValidator>());
            var config = store.Config;
            Assert.AreEqual(true, config.DemoMode);
            Assert.AreEqual(100, config.PriceMergeSize);
            Assert.AreEqual(3, config.Brokers.Count);
            Assert.AreEqual(Broker.Bitflyer, config.Brokers[1].Broker);
            Assert.AreEqual(0.30m, config.Brokers[1].MaxLongPosition);
        }
    }
}