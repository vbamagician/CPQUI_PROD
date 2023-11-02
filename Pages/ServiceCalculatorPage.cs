using CPQUI.Controls;
using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class ServiceCalculatorPage
    {
        private readonly IPage _page;
        private readonly CommonControls _controls;

        // Constructor
        public ServiceCalculatorPage(IPage page)
        {
            _page = page;
            _controls = new CommonControls(_page);
            _page.SetDefaultTimeout(70000);
        }

        //Properties
        private ILocator DownloadFileButton => _page.Locator("//button[text()='Download']");
        private ILocator PopupWindowCloseButton => _page.GetByRole(AriaRole.Button, new() { Name = "Close" });
        private ILocator UploadFileButton => _page.GetByRole(AriaRole.Button, new() { Name = "Upload" });
        private ILocator ChooseFileButton => _page.GetByText("Choose files");
        private ILocator UploadDocumentButton => _page.GetByText("Upload Document");
        
        //Methods
        public async Task DownloadCalculator()
        {
            Console.WriteLine("Waiting for file to download");
            var download = await _page.RunAndWaitForDownloadAsync( async () => await DownloadFileButton.ClickAsync() );

            Console.WriteLine("Saving file to a folder");
            await download.SaveAsAsync("MAS Data - Unified Support for Azure.xlsb");
        }

        public async Task ClosePopupWindow()
        {
            Console.WriteLine("About to click on Close button ");
            await PopupWindowCloseButton.ClickAsync();
            Console.WriteLine("Clicked on close button");
        }

        public async Task UploadCalculator()
        {
            await UploadFileButton.ClickAsync();
            var fileChooser = await _page.RunAndWaitForFileChooserAsync( async () => await ChooseFileButton.ClickAsync() );
            await fileChooser.SetFilesAsync(@"..\..\..\Support\" + "MAS Data - Unified Support for Azure.xlsb");
            await UploadDocumentButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }

        public async Task ClickOnNextButtonFromServiceCalculatorPage(string pagePlacementText)
        {
            await _controls.WaitForPageAppears(pagePlacementText);
            _controls.HoldThread(1000);
            await _controls.NextButton(pagePlacementText).ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
