using BepInEx.Configuration;
using com.github.zehsteam.ModTemplate.Helpers;

namespace com.github.zehsteam.ModTemplate.Managers;

internal static class ConfigManager
{
    public static ConfigFile ConfigFile { get; private set; }

    // Misc
    public static ConfigEntry<bool> Misc_ExtendedLogging { get; private set; }

    public static void Initialize(ConfigFile configFile)
    {
        ConfigFile = configFile;
        BindConfigs();
    }

    private static void BindConfigs()
    {
        ConfigHelper.SkipAutoGen();

        // Misc
        Misc_ExtendedLogging = ConfigHelper.Bind("Misc", "ExtendedLogging", defaultValue: false, "Enable extended logging.");
    }
}
