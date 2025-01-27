using Keen.Game2.Game.Plugins;
using Keen.VRage;
using Keen.VRage.Library.Diagnostics;
using Keen.VRage.Core.EngineComponents;
using Keen.VRage.DCS;
using Keen.VRage.DCS.Components;

namespace PluginTemplate;

public class PluginTemplate : IPlugin
{
    public PluginTemplate()
    {
        Log.Default.WriteLine($"[PluginTemplate] Loaded plugin");
    }
}
