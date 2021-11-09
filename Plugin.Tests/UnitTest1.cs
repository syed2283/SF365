using System;
using Microsoft.Crm.Sdk.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF365.Plugins;
namespace Plugin.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var pipline = new PluginPipeline(FakeMessageNames.Create, FakeStages.PreOperation,
                new Microsoft.Xrm.Sdk.Entity("contact")))
            {
                var plugin = new ContactDuplicateCheck();

            }
        }
    }
}
