using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyJob.Packages.Net.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var action = new HttpAction()
            {
                Url = "http://news.baidu.com/ent",
                Method = "GET"
            };

            var response = action.Run(null);
            Assert.IsNotNull(response);
        }
    }
}
