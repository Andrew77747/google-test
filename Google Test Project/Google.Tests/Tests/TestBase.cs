using Google.Framework.Tools;
using NUnit.Framework;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class TestBase
    {
        public WebDriverManager Manager;

        public TestBase()
        {
            Manager = new WebDriverManager();
        }

        [OneTimeTearDown]
        public void Stop()
        {
            Manager.Dispose();
        }
    }
}