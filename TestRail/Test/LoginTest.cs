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
        [Category("Positive")]
        public void CorrectLogin()
        {
            var user = new UserModel()
            {
                UserName = Configurator.ReadConfiguration().Username,
                Password = Configurator.ReadConfiguration().Password
            };

            Assert.That(UserStep.SuccessfulLogin(user).AddProjectButton().Enabled);
        }

        [Test]
        [Category("Negative")]
        public void LoginWithoutPassword()
        {
            var user = new UserModel()
            {
                UserName = Configurator.ReadConfiguration().Username
            };

            Assert.That(UserStep.UnsuccesfulLoginWithoutPassword(user).GetMessageText() == "Password is required.");
        }
    }
}
