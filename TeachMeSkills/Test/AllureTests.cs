using Allure.NUnit.Attributes;
using Allure.Net.Commons;
using NUnit.Framework;

namespace TeachMeSkills.Test
{
    [TestFixture]
    public class AllureTests : BaseTest
    {
        [Test]
        [AllureSeverity(SeverityLevel.critical)]
        public void SeverityTest()
        {
            Assert.Pass();
        }

        [Test]
        [AllureDescription("test to show description")]
        public void DescriptionTest()
        {
            Assert.Pass();
        }

        [Test]
        [AllureIssue("BUG-06")]
        public void IssuesTest()
        {
            Assert.Pass();
        }

        [Test]
        [AllureOwner("Ekaterina Siniak")]
        public void OwnerTest()
        {
            Assert.Pass();
        }

        [Test]
        [AllureTms("TMS-111")]
        public void TmsTest()
        {
            Assert.Pass();
        }

        [Test]
        [AllureLink("Website", "https://google.com")]
        public void LinkTest()
        {
            Assert.Pass();
        }

        [Test]
        public void FailedTest()
        {
            Assert.Fail();
        }
    }
}
