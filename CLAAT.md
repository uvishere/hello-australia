# Hello Australia Workshop

id: hello-australia-workshop
title: Hello Australia Workshop
summary: Build a .net web api project using MCP tools (mostly vibe coding)
authors: Yuba Raj (UV) Panta
categories: AI, .net
environments: dotnet, AI, Github
status: **Published**
feedback link: [https://github.com/uvishere/event-planner-adk/issues/new](https://github.com/uvishere/event-planner-adk/issues/new)
duration: 60
url: <https://hello-australia.uvishere.com>
theme: googlecloud

## Overview

This workshop is designed to provide a hands-on introduction to building a .NET web API project using modern Model Context Protocol (MCP) tools and AI agents. You will:

- Learn how to use Coder as your development workbench, including tips for maximizing productivity in a cloud-based environment.
- Configure MCPs to connect your workspace to essential services like GitHub and Atlassian, enabling seamless automation and integration.
- Explore how AI Agents and MCP can streamline your workflow, automate repetitive tasks, and help you focus on building features.
- Practice real-world scenarios, not just theory—this is a practical, step-by-step workshop.

> **Note:** Special gifts are available for participants who finish the workshop on time! Stay focused and make the most of this opportunity.

## Prerequisites

Before you begin, make sure you have the following:

- **Access to Coder:** [Coder](https://coder.pageupinternal.cloud) is the cloud-based development environment used in this workshop. If you don't have access, contact your administrator or workshop leader. _(Placeholder: Add contact info or instructions for access)_
- **An AI Agent:** You should have access to Copilot, Cursor, or another AI Agent of your choice. These tools will help you automate coding and documentation tasks.
- **GitHub Personal Access Token (PAT):** This is required for authenticating with GitHub APIs. _(Placeholder: Add link or instructions for generating a PAT)_
- **Basic familiarity with .NET and web APIs:** While the workshop is beginner-friendly, some prior exposure will help you get the most out of the session.

## 1: Get to your workspace

Follow these steps to set up your development environment:

1. **Login to Coder:** Go to [Coder](https://coder.pageupinternal.cloud) and sign in with your credentials.
2. **Create a workspace:** Use the "AI Workbench" template to create a new workspace. This template comes pre-configured with the tools you'll need.
3. **Open your code editor:** Launch VS Code, Cursor, or your preferred editor. Make sure it is connected to your Coder workspace.
4. _(Optional Placeholder: Add screenshots or a video walkthrough for workspace setup)_

> **Why this matters:** Setting up your workspace correctly ensures you have all the tools and permissions needed for the rest of the workshop.

## 2: Configure MCP servers

In this step, you'll connect your workspace to external services using MCP servers. This enables automation, integration, and AI-powered workflows.

- **What is MCP?** Model Context Protocol (MCP) is a framework for connecting your development environment to external tools and services, such as GitHub and Atlassian. [Learn more here.](https://medium.com/all-things-gcp/unlocking-your-developer-abilities-with-model-context-protocol-mcp-9b1def292d0b)

- **Steps:**
  1. Open the `mcp.json` file in your workspace root (either inside .vscode or .cursor).
  1. Paste the following configuration (replace placeholders as needed):

    For VS Code:

     ```json
        {
        "mcpServers": {
            "github-remote": {
            "url": "https://api.githubcopilot.com/mcp/",
            "authorization_token": "Bearer <your-github-PAT>>"
            },
            "atlassian": {
            "command": "npx",
            "args": [
                "-y",
                "mcp-remote",
                "https://mcp.atlassian.com/v1/sse"
            ]
            }
        }
        }
     ```

    For Cursor

    ```json
    {
      "servers": {
          "github-remote": {
              "type": "http",
              "url": "https://api.githubcopilot.com/mcp/",
              "headers": {
                  "Authorization": "Bearer ${input:github_mcp_pat}"
              }
          }
      },
      "atlassian": {
          "command": "npx",
          "args": [
              "-y",
              "mcp-remote",
              "https://mcp.atlassian.com/v1/sse"
          ]
      },
      "inputs": [
          {
              "type": "promptString",
              "id": "github_mcp_pat",
              "description": "GitHub Personal Access Token",
              "password": true
          }
      ]
    }

    ```

  1. Save the file.
  1. _(Placeholder: Add more detailed instructions or screenshots for configuring MCP servers)_

> **Tip:** Proper MCP configuration is essential for enabling AI agents and automations to interact with your repositories and tickets.

## 3: Build a feature

Let's practice building a feature using your AI agent and MCP integration.

- **Scenario:** You have a new feature request, tracked as ticket `SP-5169`.
- **Prompt to use:**

  ```text
  Hey, can you work on this feature SP-5169? Work on it and create a draft PR on the same repo. Feel free to create a branch if you need to.
  ```

- **What happens:**
  - The AI agent will analyze the ticket, create a new branch if necessary, implement the feature, and open a draft pull request for review.
  - You can review the changes, add comments, or request further modifications.
- _(Placeholder: Add expected output, screenshots, or a checklist for reviewing the PR)_

> **Why this matters:** This workflow demonstrates how AI agents can automate routine development tasks, freeing you to focus on higher-level design and problem-solving.

## 4: Write a test

Testing is a critical part of software development. In this step, you'll use your AI agent to generate and submit unit tests for your API endpoints.

- **Scenario:** There is a ticket, `SP-5170`, that requires generating unit tests for each API endpoint.
- **Prompt to use:**

  ```text
  Visit the SP-5170 and create a draft PR based on the description.
  ```

- **What happens:**
  - The AI agent will review the implementation from the previous step, generate appropriate unit tests, and submit them as a draft pull request.
  - You should review the tests for coverage and correctness.
- _(Placeholder: Add a checklist for test quality, or a template for test review)_

> **Tip:** Automated test generation helps ensure your code is robust and reduces the risk of bugs in production.

## 5 Bonus: Prepare for your performance review

As a bonus, let's see how AI can help you summarize your work for a performance review.

- **Scenario:** You want to create a summary of your recent work from JIRA and Confluence to present to your manager.
- **Prompt to use:**

  ```text
  Look into all the JIRA and Confluence documents and create a nice summary out of it which I can present to my manager.
  ```

- **What happens:**
  - The AI agent will gather information from your tickets and documentation, then generate a concise summary of your achievements and contributions.
  - You can edit or expand this summary as needed before sharing it with your manager.
- _(Placeholder: Add a template for the summary, or tips for customizing it)_

> **Why this matters:** Regularly summarizing your work helps you track your progress, communicate your value, and prepare for reviews or promotions.

---

## Additional Resources

- _(Placeholder: Add links to documentation, support channels, or further reading)_
- _(Placeholder: Add FAQ or troubleshooting tips)_
