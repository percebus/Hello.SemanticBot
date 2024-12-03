namespace JCystems.SemanticWebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Integration.AspNet.Core;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("api/messages")]
    public class MessagesController(ILogger<MessagesController> logger, IBot bot, IBotFrameworkHttpAdapter adapter)
        : BotControllerBase(logger, bot, adapter)
    {
    }
}
