
using ClassIsland.Core.Abstractions;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Controls.CommonDialog;
using ClassIsland.Core.Extensions.Registry;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExtraIsland
{
    [PluginEntrance]
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            services.AddComponent<Components.BetterCountdown,Components.BetterCountdownSettings>();
            services.AddComponent<Components.FluentClock>();
        }
    }
}