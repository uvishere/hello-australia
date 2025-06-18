# HelloAustralia

A minimal ASP.NET Core Web API project for learning and experimentation.

## Purpose

- Practice building and testing minimal APIs in .NET
- Experiment with AI agents, MCP integration, and developer productivity tools

## Features

- Simple API endpoint: `/` returns a welcome message
- `/states` returns a list of all Australian states and territories

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Running the API

From the root directory, run:

```
dotnet run
```

The API will be available at `https://localhost:5001` or `http://localhost:5000` by default.

### Running Tests

To run all automated tests (in the Tests/HelloAustralia.Tests project):

```
dotnet test
```

## Contributing

- Add new endpoints or features in `Program.cs`
- Add or update tests in the `Tests/HelloAustralia.Tests` project

---

This project is part of a hands-on workshop to improve .NET and AI agent skills.
