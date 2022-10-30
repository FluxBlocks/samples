using FluxBlocks.Plugin;
using Microsoft.Extensions.DependencyInjection;


namespace PluginHR
{
    public class PluginHR : IUiPlugin
    {
        public string GetName() => "PluginHR";

        public string GetDescription() => "HR UI";

        public string GetVersion() => "0.0.1";

        public void Configure(IServiceCollection services)
        {
            
        }
    }
}
