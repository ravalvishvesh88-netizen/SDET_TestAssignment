# Selenium C# NUnit Automation Framework

## Overview
This project is a scalable UI automation framework built using:
- C#
- Selenium WebDriver
- NUnit

It follows **Page Object Model (POM)** and industry best practices for maintainability and readability.

---

## Tech Stack

- Language: C#
- Framework: NUnit
- Automation: Selenium WebDriver
- Design Pattern: Page Object Model
- Logging: Custom Logger
- Wait Handling: Explicit Waits

---

## Project Structure

```
Drivers      -> WebDriver initialization
Pages        -> Page Object classes
Tests        -> Test scenarios
Utilities    -> Helper classes
Logs         -> Execution logs
Reports      -> Test reports
Docs         -> Test strategy document
```

---

## Prerequisites

- .NET 8 SDK
- Visual Studio / VS Code
- Chrome Browser
- Git

---

## Setup Instructions

```bash
git clone https://github.com/<your-username>/selenium-csharp-nunit-framework.git
cd selenium-csharp-nunit-framework
dotnet restore
```

---

## Run Tests

Run all tests:

```bash
dotnet test
```

Run specific test:

```bash
dotnet test --filter "FullyQualifiedName~LoginTests"
```

---

## Framework Highlights

- Page Object Model implementation
- Reusable driver factory
- Explicit wait handling
- Logging support
- Clean separation of concerns

---

## Logging

Logs are generated using custom logger:
- Stored in `/Logs`
- Helps debug failures

---

## Reporting

(Default NUnit reporting)

Can be extended to:
- Extent Reports
- Allure Reports

---

## Test Coverage

- User Registration
- User Login
- UI Validations

---

## Future Enhancements

- Screenshot on failure
- Parallel execution
- CI/CD integration
- External test data (JSON/Excel)
- Advanced reporting

---

## Author

Vishvesh Raval