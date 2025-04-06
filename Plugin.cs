using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Assets;
using Unity.Collections;

namespace SeaglideSpeedAddon
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.snmodding.nautilus")]
    [BepInDependency("com.lawabidingtroller.literalseaglideupgrades")]
    public class Plugin : BaseUnityPlugin
    {
        public new static ManualLogSource Logger { get; private set; }

        private static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();

        private void Awake()
        {
            // set project-scoped logger instance
            Logger = base.Logger;

            // Initialize custom prefabs
            InitializePrefabs();

            // register harmony patches, if there are any
            Harmony.CreateAndPatchAll(Assembly, $"{PluginInfo.PLUGIN_GUID}");
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
        public static float[] speedmultiplier = { 8 };
        public static CustomPrefab[] speedprefab;
        public static PrefabInfo[] prefabinfo;
        public static int index;
        public static float changespeedmultiplier = 4;
        private void InitializePrefabs()
        {
            for (index = 0; index < 10; index++)
            {
                speedmultiplier[index] += changespeedmultiplier;
                changespeedmultiplier++;
                SeaglideSpeedModulePrefab.Register();
            }
        }
    }
}