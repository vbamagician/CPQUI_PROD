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

        //SSO Properties 
        private ILocator PrimaryCPQLoginButton => _page.Locator("//button[@id='buttonAADSignIn']");
        private ILocator SSOUserNameTextBox => _page.Locator("//input[@name='loginfmt']");
        private ILocator SSOUserNameFormNextButton => _page.Locator("//input[@value='Next']");
        private ILocator SSOPasswordTextBox => _page.Locator("//input[@name='passwd']");
        private ILocator SSOSignInButton => _page.Locator("//input[@value='Sign in']");
        private ILocator SSOStaySignedInYesButton => _page.Locator("//input[@value='Yes']");


        //SSO Login Methods
        public async Task SSOLogin(string username, string password)
        {
            await ClickOnPrimaryCPQLoginButton();
            await EnterSSOUserName(username);
            await ClickOnNextButtonToEnterSSOPassword();
            await EnterSSOPassword(password);
            await ClickOnSignInButtonToFinishSSOLoginOperation();
            await ClickOnYesButtonToFinishSSOLoginOperation();
        }

        private async Task ClickOnYesButtonToFinishSSOLoginOperation()
        {
            await SSOStaySignedInYesButton.ClickAsync();
        }

        private async Task ClickOnSignInButtonToFinishSSOLoginOperation()
        {
            await SSOSignInButton.ClickAsync();
        }

        private async Task EnterSSOPassword(string password)
        {
            await SSOPasswordTextBox.FillAsync(password);
        }

        private async Task ClickOnNextButtonToEnterSSOPassword()
        {
            await SSOUserNameFormNextButton.ClickAsync();
        }

        private async Task EnterSSOUserName(string userName)
        {
            await SSOUserNameTextBox.FillAsync(userName);
        }

        private async Task ClickOnPrimaryCPQLoginButton()
        {
            await PrimaryCPQLoginButton.ClickAsync();
        }

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
