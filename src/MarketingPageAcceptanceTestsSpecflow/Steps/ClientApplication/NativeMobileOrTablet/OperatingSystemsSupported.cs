﻿using MarketingPageAcceptanceTestsSpecflow.Utils;
using TechTalk.SpecFlow;

namespace MarketingPageAcceptanceTestsSpecflow.Steps.ClientApplication.NativeMobileOrTablet
{
    [Binding]
    public class OperatingSystemsSupported : TestBase
    {
        public OperatingSystemsSupported(UITest test, ScenarioContext context) : base(test, context)
        {
        }

        [Given(@"that a User has provided a value for the Mandatory Information for (.*) section on (.*) sub dashboard")]
        public void GivenThatAUserHasProvidedAValueForTheMandatoryInformation(string section, string subDashboard)
        {
            _test.pages.Dashboard.NavigateToSection("Client application type");
            _test.pages.ClientApplicationTypes.SelectCheckbox(subDashboard);
            _test.pages.ClientApplicationTypes.SaveAndReturn();
            _test.pages.Dashboard.NavigateToSection(subDashboard, true);
            _test.pages.BrowserSubDashboard.OpenSection(section);

            _test.pages.NativeMobileOperatingSystems.SelectCheckboxes(1);
            _test.pages.Common.SectionSaveAndReturn();
        }

        [Given(@"that an answer has not been provided to the mandatory question for (.*) section on (.*) sub dashboard")]
        public void GivenThatAnAnswerHasNotBeenProvidedToTheMandatoryQuestion(string section, string subDashboard)
        {
            _test.pages.Dashboard.NavigateToSection("Client application type");
            _test.pages.ClientApplicationTypes.SelectCheckbox(subDashboard);
            _test.pages.ClientApplicationTypes.SaveAndReturn();
            _test.pages.Dashboard.NavigateToSection(subDashboard, true);
        }

        [Given(@"the User has entered (.*) characters for (.*) section on (.*) sub dashboard")]
        public void GivenTheUserHasEnteredText(int characters, string section, string subDashboard)
        {
            _test.pages.Dashboard.NavigateToSection("Client application type");
            _test.pages.ClientApplicationTypes.SelectCheckbox(subDashboard);
            _test.pages.ClientApplicationTypes.SaveAndReturn();
            _test.pages.Dashboard.NavigateToSection(subDashboard, true);
            _test.pages.BrowserSubDashboard.OpenSection(section);

            _test.pages.NativeMobileOperatingSystems.SelectCheckboxes(1);

            _test.pages.NativeMobileOperatingSystems.TextAreaSendText(characters);
        }

        [Given(@"that a User has not provided any mandatory data on (.*) sub dashboard for (.*) section")]
        public void GivenThatAUserHasNotProvidedAnyMandatoryDataOnNativeMobileOrTabletSubDashboardForSupportedOperatingSystemsSection(string subDashboard, string section)
        {
            _test.pages.Dashboard.NavigateToSection("Client application type");
            _test.pages.ClientApplicationTypes.SelectCheckbox(subDashboard);
            _test.pages.ClientApplicationTypes.SaveAndReturn();
            _test.pages.Dashboard.NavigateToSection(subDashboard, true);
            _test.pages.BrowserSubDashboard.OpenSection(section);
        }

        [Given(@"validation has been triggered on (.*) section (.*)")]
        public void GivenValidationHasBeenTriggeredOnNativeMobileOrTabletSectionSupportedOperatingSystems(string subDashboard, string section)
        {
            GivenThatAUserHasNotProvidedAnyMandatoryDataOnNativeMobileOrTabletSubDashboardForSupportedOperatingSystemsSection(subDashboard, section);

            _test.pages.Common.SectionSaveAndReturn();
        }


        [Given(@"the User has saved all data for (.*) section on (.*) sub dashboard")]
        public void GivenTheUserHasSavedAllDataForSupportedOperatingSystemsSectionOnNativeMobileOrTabletSubDashboard(string section, string subDashboard)
        {
            GivenTheUserHasEnteredText(100, section, subDashboard);

            _test.pages.Common.SectionSaveAndReturn();

            _test.pages.Common.ClickSubDashboardBackLink();
        }

    }
}