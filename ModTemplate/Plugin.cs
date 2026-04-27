using BepInEx;
using com.github.zehsteam.ModTemplate.Dependencies.LethalConfigMod;
using com.github.zehsteam.ModTemplate.Helpers;
using com.github.zehsteam.ModTemplate.Managers;
using HarmonyLib;

namespace com.github.zehsteam.ModTemplate;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(LethalConfigProxy.PLUGIN_GUID, BepInDependency.DependencyFlags.SoftDependency)]
internal class Plugin : BaseUnityPlugin
{
    private readonly Harmony _harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

    internal static Plugin Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        ModTemplate.Logger.Initialize(BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_GUID));
        ModTemplate.Logger.LogInfo($"{MyPluginInfo.PLUGIN_NAME} has awoken!");

        //_harmony.PatchAll(typeof());

        //Assets.Load();

        ConfigManager.Initialize(Config);

        //NetworkUtils.NetcodePatcherAwake();
    }
}
