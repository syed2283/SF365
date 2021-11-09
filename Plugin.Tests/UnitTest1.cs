using System;
using Microsoft.Crm.Sdk.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using SF365.Plugins;
namespace Plugin.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Unit Test")]
        public void TestContactDuplicateCheck()
        {
            using (var pipline = new PluginPipeline(FakeMessageNames.Create, FakeStages.PreOperation,
                new Microsoft.Xrm.Sdk.Entity("contact")))
            {
                var plugin = new ContactDuplicateCheck();
                try
                {
                    pipline.Execute(plugin);
                    Assert.Fail("Exception not thrown");
                }
                catch (InvalidPluginExecutionException ex)
                {
                    Assert.IsTrue(ex.Message.Contains("Working on it"), "Must throw exeception");
                }
            }
        }
    }
}
