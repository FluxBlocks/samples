using FluxBlocks.Plugin;
using Microsoft.Extensions.DependencyInjection;


namespace PluginTime
{
    public class PluginTime : IUiPlugin
    {
        public string GetName() => "PluginTime";

        public string GetDescription() => "Time tracking UI";

        public string GetVersion() => "0.0.1";

        public void Configure(IServiceCollection services)
        {
            
        }
    }
}
