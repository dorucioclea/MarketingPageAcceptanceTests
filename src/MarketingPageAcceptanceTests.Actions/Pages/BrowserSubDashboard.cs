﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using MarketingPageAcceptanceTests.Actions.Utils;
using OpenQA.Selenium;
using Xunit.Abstractions;

namespace MarketingPageAcceptanceTests.Actions.Pages
{
    public class BrowserSubDashboard : PageAction
    {
        public BrowserSubDashboard(IWebDriver driver) : base(driver)
        {
        }

        public IList<string> GetSections()
        {
            return driver.FindElements(pages.BrowserBasedDashboard.Sections)
                .Select(s => s.FindElement(pages.BrowserBasedDashboard.SectionTitle).Text)
                .ToList();
        }

        public void SectionsHaveStatusIndicators()
        {
            var sections = GetSections();

            foreach (var section in sections)
            {
                driver.FindElements(pages.BrowserBasedDashboard.Sections)
                .Single(s => s.FindElement(pages.BrowserBasedDashboard.SectionTitle).Text == section)
                .ContainsElement(pages.BrowserBasedDashboard.StatusIndicator).Should().BeTrue();
            }
        }

        public void OpenSection(string sectionName)
        {
            driver.FindElements(pages.BrowserBasedDashboard.Sections)
                .Single(s => s.FindElement(pages.BrowserBasedDashboard.SectionTitle).Text == sectionName)
                .FindElement(pages.BrowserBasedDashboard.SectionTitle)
                .Click();

            wait.Until(s => s.FindElement(pages.Common.PageTitle).Text.Contains(sectionName.ToLower()));
        }
    }
}