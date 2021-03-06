﻿using MarketingPageAcceptanceTestsSpecflow.Utils;
using TechTalk.SpecFlow;

namespace MarketingPageAcceptanceTestsSpecflow.Steps.Features
{
    [Binding]
    public class DisplayFeatures : TestBase
    {
        public DisplayFeatures(UITest test, ScenarioContext context) : base(test, context)
        {
        }

        [Given(@"that a (Supplier|User) has chosen to manage Marketing Page Information")]
        public void GivenThatASupplierHasChosenToManageMarketingPageInformation(string user)
        {
        }

        [Then(@"the Features section content validation status is displayed")]
        public void ThenTheFeaturesSectionContentValidationStatusIsDisplayed()
        {
            _test.pages.Dashboard.SectionHasStatus("Features");
        }
    }
}
