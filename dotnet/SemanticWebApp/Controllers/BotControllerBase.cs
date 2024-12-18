﻿namespace JCystems.SemanticWebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Integration.AspNet.Core;

    /// <seealso href="https://github.com/microsoft/BotBuilder-Samples/blob/main/samples/csharp_dotnetcore/02.echo-bot/Controllers/BotControllerBase.cs"/>
    /// <![CDATA[NOTE]]>
    /// This ASP Controller is created to handle a request. 
    /// Dependency Injection will provide the Adapter and IBot implementation at runtime. 
    /// Multiple different IBot implementations running at different endpoints can be achieved 
    /// by specifying a more specific type for the bot constructor argument.
    /// <![CDATA[NOTE]]>
    public abstract class BotControllerBase(
        ILogger<BotControllerBase> logger,
        IBot bot,
        IBotFrameworkHttpAdapter adapter)
          : ObservableControllerBase(logger)
    {
        protected IBotFrameworkHttpAdapter BotFrameworkHttpAdapter { get; } = adapter;

        protected IBot Bot { get; } = bot;

        [HttpPost]
        [HttpGet] // NOTE: Only for websockets
        public async Task PostAsync()
        {
            // this.Logger.LogInformation("{1}.{2}()...", nameof(BotControllerBase), nameof(this.PostAsync));

            // Delegate the processing of the HTTP POST to the adapter.
            // The adapter will invoke the bot.
            await this.BotFrameworkHttpAdapter.ProcessAsync(
                this.Request,
                this.Response,
                this.Bot);
        }
    }
}
