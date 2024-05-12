using TestRail.Models;
using TestRail.Utils;

namespace TestRail.Test
{
    [TestFixture]
    internal class DashboardTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Configurator.ReadConfiguration().Url);

            var user = new UserModel()
            {
                UserName = Configurator.ReadConfiguration().Username,
                Password = Configurator.ReadConfiguration().Password
            };
            UserStep.SuccessfulLogin(user);
        }
    }
}
