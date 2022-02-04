﻿using System;
using Google.Framework.Tools;
using Infrastructure.Settings;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Google.Tests.Tests
{
    [TestFixture]
    public class TestBase
    {
        public WebDriverManager Manager;
        public Appsettings Settings;

        public TestBase()
        {
            Manager = new WebDriverManager();
            Settings = new ConfigurationManager().GetSettings();
        }

        [TearDown]
        public void TeardownTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = new ScreenshotMaker(Manager.Driver, TestContext.CurrentContext.Test.Name);
                Console.WriteLine("The screen shot was made into " + screenshot.Path);
                TestContext.AddTestAttachment(screenshot.Path);
            }
        }

        [OneTimeTearDown]
        public void Stop()
        {
            Manager.Dispose();
        }
    }
}