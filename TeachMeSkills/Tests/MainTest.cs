using NUnit.Framework;
using TeachMeSkills.Utils;

namespace TeachMeSkills.Tests
{
    internal class MainTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }
    }
}
