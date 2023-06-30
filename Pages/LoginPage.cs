using CPQUI.Helper;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class LoginPage
    {
        private readonly IPage _page;

        //Constructor
        public LoginPage(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(70000);
        }

        //Properties
        private ILocator UsernameTextBox => _page.GetByLabel("Username");
        private ILocator PasswordTextBox => _page.GetByLabel("Password");
        private ILocator LoginButton => _page.GetByRole(AriaRole.Button, new() { Name = "Log in" });

        //Methods
        public async Task Login(string? userName, string? password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = string.Empty;
            } 
            if (string.IsNullOrWhiteSpace(password))
            {
                password = string.Empty;
            }
            await UsernameTextBox.FillAsync(userName);
            await PasswordTextBox.FillAsync(password);
            await LoginButton.ClickAsync();
        }
    }
}
