# Hello Australia Workshop

- Aims to provide learning about

  - How to use Coder as your workbench
  - How to configure MCPs
  - How to use AI Agents and MCP to improve your productivitiy

- This might be something you've seen already but have you practiced it? In this workshop, we'll do some hands on.

There's special gifts available to people to finishes the workshop on time, so don't be lazy and stgart working on it.

## Prerequisites

- Get access to Coder
- Have access to either Copilot or Cursor (or any other AI Agent of choice)
- Create a Github PAT

## 1: Get to your workspace

1. Login to [Coder](https://coder.pageupinternal.cloud)
2. Create workspace from template - AI Workbench
3. Open VS Code / Cursor (Any editor of your choice)

## 2: Configure MCP servers

Now, we're going to configure two MCP servers, Github & Atlassian.

If you more info about what's MCP and how it works visit this [blog](https://medium.com/all-things-gcp/unlocking-your-developer-abilities-with-model-context-protocol-mcp-9b1def292d0b).

In VS Code,

1. Go to mcp.json, and paste the following code:

   ```
       Add Code here
   ```

## 3: Use case 1: Build a feature

Test this prompt

    ```
    Hey can you wok on this feature SP-5169? Work on it and create a draft PR on the same repo.
    Feel free to create a branch if you need to
    ```

## 4: Write a test

There's another ticket SP-5170 that's to generate unit tests for each of the api endpoints. How would you do that?

    ```
    Visit the SP-5169 and create a draft PR based on the description.
    ```

## 5 Bonus: Prepare for your performance review

How about:

    ```
    Look into all the JIRA and confluence document and create a nice summary out of it which I can present to my manager.
    ```
