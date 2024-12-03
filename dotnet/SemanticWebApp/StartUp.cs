namespace JCystems.SemanticWebApp
{
    using JCystems.SemanticWebApp.Bots;
    using JCystems.SemanticWebApp.Controllers;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Builder.Integration.AspNet.Core;
    using Microsoft.Bot.Connector.Authentication;

    /// <seealso href="https://github.com/microsoft/BotBuilder-Samples/blob/main/samples/csharp_dotnetcore/02.echo-bot/Startup.cs" />
    public class Startup(IConfiguration configuration)
    {
        public IConfiguration Configuration { get; } = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddHttpClient()
                .AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.MaxDepth = HttpHelper.BotMessageSerializerSettings.MaxDepth;
                });

            services
                .AddSingleton<BotFrameworkAuthentication, ConfigurationBotFrameworkAuthentication>() // Create the Bot Framework Authentication to be used with the Bot Adapter.
                .AddSingleton<IBotFrameworkHttpAdapter, AdapterWithErrorHandler>() // Create the Bot Adapter with error handling enabled.
                .AddTransient<IBot, EchoBot>(); // Create the bot as a transient. In this case the ASP Controller is expecting an IBot.

            services
                .Scan(scan => scan
                    .FromAssemblyOf<BotController>()
                        .AddClasses()
                            .AsImplementedInterfaces()
                            .WithTransientLifetime()
                );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app
                    .UseSwagger()
                    .UseSwaggerUI()
                    .UseDeveloperExceptionPage();
            }

            app
                .UseDefaultFiles()
                .UseStaticFiles()
                .UseWebSockets()
                .UseRouting()
                // .UseHttpsRedirection()
                // .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
