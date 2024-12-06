# Hello.SemanticBot

[`TODO`s](./TODO.md) | [`LICENSE`](LICENSE.md) | [`HISTORY`](HISTORY.md)

## Background

In CoPilot studio, "Adding a Skill" seems to always refer to an openAPI endpoint. With a single `api/messages` POST endpoint.

## Motivation

I wanted to put together a botSDK with a SemanticKernel chat app

## Hypothesis

_'Adding a "Skill" to CoPilot studio is as trivial as creating a WebApp with a single `api/messages` POST endpoint that handles `Activity`'_

### Result

TBD

## Findings

### 2024-12-04

- With the need to use **BotSDK Emulator**, and needing to intercept activity with things like `node`'s `offline-directline`, the hypothesis seems to be less likely to be true.

## Repositories

- [`microsoft`](https://github.com/microsoft/BotBuilder)
  - [`botframework-sdk`](https://github.com/microsoft/botframework-sdk)
  - [`BotBuilder-Samples`](https://github.com/microsoft/BotBuilder-Samples/)
    - ...
      - [02.echo-bot](https://github.com/microsoft/BotBuilder-Samples/tree/main/samples/csharp_dotnetcore/02.echo-bot)
- [`ryanvolum`](https://github.com/ryanvolum)
  - [`offline-directline`](https://github.com/ryanvolum/offline-directline)

## Resources

- [Bot Framework Solutions Documentation](https://microsoft.github.io/botframework-solutions/index#tutorials)

### MSLearn

- [Configure a Bot Framework skill for use in Copilot Studio](https://learn.microsoft.com/en-us/microsoft-copilot-studio/configuration-add-skills)
- [Test and debug with the Emulator](https://learn.microsoft.com/en-us/azure/bot-service/bot-service-debug-emulator?view=azure-bot-service-4.0&tabs=csharp)
