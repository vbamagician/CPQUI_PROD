using Microsoft.Playwright;

namespace CPQUI.Pages
{
    internal class OpportunityPage
    {
        private readonly IPage _page;
        
        // Constructor
        public OpportunityPage(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(70000);
        }

        // Common Properties
        private ILocator OpportunityValueLable => _page.Locator("//table[@class='kk_VerticalDS']/tbody/tr[2]/td[1]/span/table/tbody/tr[2]/td[3]/b");
    
        // Common Method
        public async Task<bool> IsValueOfOpportunityExpected()
        {
            var opportunityValue = await OpportunityValueLable.InnerTextAsync();
            var opportunityValueText = opportunityValue.ToString();

            if (opportunityValueText != "")
                return true;
            else
                return false;
        }
    }
}
