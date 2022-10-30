using FluxBlocks.Plugin;
using Microsoft.Extensions.DependencyInjection;


namespace PluginHRServices
{
    public class PluginHRServices : ILogicPlugin
    {
        public string GetName() => "PluginHRServices";

        public string GetDescription() => "PluginHRServices";

        public string GetVersion() => "0.0.1";

        public void Configure(IServiceCollection services)
        {
            services.AddTransient<ITest, Test>();
        }
    }
}
