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
        private ILocator DownloadFileButton => _page.GetByRole(AriaRole.Button, new() { Name = "Download" });
        private ILocator PopupWindowCloseButton => _page.GetByRole(AriaRole.Button, new() { Name = "Close" });
        private ILocator UploadFileButton => _page.GetByRole(AriaRole.Button, new() { Name = "Upload" });
        private ILocator ChooseFileButton => _page.GetByText("Choose files");
        private ILocator UploadDocumentButton => _page.GetByText("Upload Document");
        
        //Methods
        public async Task DownloadCalculator()
        {
            var download = await _page.RunAndWaitForDownloadAsync( async () => await DownloadFileButton.ClickAsync() );
            await download.SaveAsAsync("MAS Data - Unified Support for Azure.xlsb");
        }

        public async Task ClosePopupWindow()
        {
            await PopupWindowCloseButton.ClickAsync();
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
            await _controls.NextButton.ClickAsync();
            await _controls.WaitForLoadingScreenToDisappear();
        }
    }
}
