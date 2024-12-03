namespace JCystems.SemanticWebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public abstract class ObservableControllerBase(ILogger<ObservableControllerBase> logger) : ControllerBase
    {
        protected ILogger<ObservableControllerBase> Logger { get; set; } = logger;
    }
}
