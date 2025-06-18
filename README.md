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



---

This project is part of a hands-on workshop to improve .NET and AI agent skills.

---

### contributors only

#### Deploy

1. Install claat
2. from root working directory run `claat export -o ./docs/ CLAAT.md`
3. Once exported, go inside the `docs/hello-australia-workshop` folder
4. Run `gcloud storage cp -r * gs://hello-australia.uvishere.com`
