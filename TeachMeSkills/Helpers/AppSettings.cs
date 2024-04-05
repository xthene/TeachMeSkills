namespace TeachMeSkills.Helpers
{
    public class AppSettings
    {
        public string? BrowserType { get; set; }
        public double Timeout { get; set; }
        public string SauceDemoUrl { get; set; }
        public string UserNameSauceDemo { get; set; }
        public string PasswordSauceDemo { get; set; }
        public string IncorrectPasswordSauceDemo { get; set; }
    }
}
