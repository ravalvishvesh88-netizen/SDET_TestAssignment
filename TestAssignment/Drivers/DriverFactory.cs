using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment.Drivers
{
    public class DriverFactory
    {
        public static IWebDriver InitDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--headless");              // Run without UI
            options.AddArgument("--no-sandbox");            // Required for CI
            options.AddArgument("--disable-dev-shm-usage"); // Fix memory issues
            return new ChromeDriver(options);

        }
    }
}
