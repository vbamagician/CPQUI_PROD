using Microsoft.Playwright;

namespace CPQUI.Drivers
{
    internal class Driver : IDisposable
    {
        private readonly Task<IPage> _page;

        //private IBrowser? _browser;
        private IBrowserContext? _browserContext;

        public Driver() => _page = InitializePlaywright();

        public IPage Page => _page.Result;

        private async Task<IPage> InitializePlaywright()
        {
            //Playwright
            IPlaywright playwright = await Playwright.CreateAsync();

            /*//Browser
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 100
            });*/

            //Browser
            var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            _browserContext = await browser.NewContextAsync(new()
            {
                //RecordVideoDir = "videos/"
            });

            //Page
            return await _browserContext.NewPageAsync();
        }

        public void Dispose() => _browserContext?.CloseAsync();
    }
}
