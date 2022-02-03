using Google.Framework.Tools;
using NUnit.Framework;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class TestBase
    {
        public WebDriverManager Manager;

        [SetUp]
        public void Start()
        {
            //Manager = new WebDriverManager();
        }

        //[TearDown]
        //public void Stop()
        //{
        //    Manager.Dispose();
        //}
    }
}