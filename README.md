# samples

## Overview
This sample illuistrates how to use FluxBlocks Plugins to seperate UI and logic code. FluxBlocks aims to be a simple solution to help with seperations of concerns. This project shows a method to link plugins together with project references to enable regular Visual Studio compiling and debugging, at run time the framework will scan the plugins directory and dynamically add in the plugins. This is wired up in the project file as MSBuild commands.

## Getting Started
1. Edit the project file for MvcApp and update PluginPubDir to point to where the code is checked out on your machine.

2. Now you are ready build and execute the project.

3. FluxBlocks is an opinionated framework with some required conventions.
  * The framework will scan a folder in the executing path of the host application. This folder can only can IUiPlugin and ILogicPlugin plugins.
  * Plugins must be contained in their own sub folder in the plugins root folder and name as the assemblyName. Example from the samples - PluginTime.
  * The Plugin class name must be the assemblyName. Example from the samples - PluginTime.PluginTime.
  * Plugins are required to be either IUiPlugin or ILogicPlugin - inheriting both will result in errors.
  * Including in other sub folders inside of the plugin root folder will result in errors.
  * Below is PluginHRServices as an example of how to implement a plugin. Notice the Configure function takes in an IServiceCollection and you register your services the same as you would in Startup.ConfigureServices - FluxBlocks will register these when it loads your plugin.

4. FluxBlocks is in Beta - Open GitHub Issues and we will respond back within a few days.

```
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
```
