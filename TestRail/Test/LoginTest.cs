using TestRail.Models;
using TestRail.Utils;

namespace TestRail.Test
{
    internal class LoginTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);
        }

        [Test]
        public void CorrectLogin()
        {
            var user = new UserModel()
            {
                UserName = Configurator.ReadConfiguration().Username,
                Password = Configurator.ReadConfiguration().Password
            };

            Assert.That(UserStep.SuccessfulLogin(user).AddProjectButton().Enabled);
        }
    }
}
