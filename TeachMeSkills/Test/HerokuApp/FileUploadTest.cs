using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
