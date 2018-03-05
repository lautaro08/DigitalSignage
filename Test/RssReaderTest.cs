using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using Microsoft.Practices.Unity;
using UI;

namespace Test
{
    /// <summary>
    /// Summary description for RssReaderTest
    /// </summary>
    [TestClass]
    public class RssReaderTest
    {

        //resuelve la dependencia para el servicio de campañas
        private IRssReader iRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetFeeds()
        {
            var rssUrl = "https://www.clarin.com/rss/lo-ultimo/";
            var feeds = this.iRssReader.Read(rssUrl);
            Assert.IsNotNull(feeds);
        }
    }
}
