# HelloAustralia.Tests

This project contains automated tests for the HelloAustralia minimal API application.

## Purpose

- Ensure the API endpoints in HelloAustralia work as expected
- Provide integration and unit test coverage for new and existing features

## How to Run Tests

From the root of the solution, run:

```
dotnet test
```

This will build the solution and execute all tests in this project.

## Structure

- Tests are written using xUnit and ASP.NET Core's WebApplicationFactory for integration testing.
- Add new test classes and methods as you add new features or endpoints to the main API.
