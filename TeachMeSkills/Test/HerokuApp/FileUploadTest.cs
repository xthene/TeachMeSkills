using Allure.NUnit.Attributes;
using NUnit.Framework;
using System.Reflection;

namespace TeachMeSkills.Test.HerokuApp
{
    internal class FileUploadTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl(Helpers.Configurator.ReadConfiguration().FormyProjectHerokuAppUrl + "fileupload");
        }

        [Test]
        [AllureEpic("Web interface")]
        [AllureFeature("File upload")]
        [AllureStory("Reset button")]
        public void CheckFileUpload()
        {
            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources",
                "test1.txt");

            FileUploadPage.FileUploadInput().SendKeys(filePath);
            FileUploadPage.ResetButtonClick();

            Assert.That(FileUploadPage.FileUploadInput().Text, Is.EqualTo(""));
        }
    }
}
