using CPQUI.Controls;
using CPQUI.Drivers;

namespace CPQUI.StepDefinitions
{
    [Binding]
    public class ASubjectiveStepDefinitions
    {
        private readonly Driver _driver;
        private readonly CommonControls _commonControls;

        private ASubjectiveStepDefinitions(Driver driver)
        {
            _driver = driver;
            _commonControls = new CommonControls(_driver.Page);
        }

        [Given(@"I update the appropriate organisation units for the given roles to proceed")]
        public async Task GivenIUpdateTheAppropriateOrganisationUnitsForTheGivenRolesToProceed()
        {
            await _commonControls.UpdateTheAppropriateOrganisationUnitsForTheGivenRolesToProceed();
        }
    }
}
