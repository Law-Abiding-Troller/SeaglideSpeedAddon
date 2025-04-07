using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Assets;
using rail;
using Unity.Collections;
using LawAbidingTroller.SeaglideModConcept.SeaglideModules.SpeedPrefab;

namespace SeaglideSpeedAddon
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.lawabidingtroller.literalseaglideupgrades", BepInDependency.DependencyFlags.SoftDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public new static ManualLogSource Logger { get; private set; }

        private static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();

        private void Awake()
        {
            // set project-scoped logger instance
            Logger = base.Logger;
            // Initialize custom prefabs after a slight delay
            InitializePrefabs();

            // register harmony patches, if there are any
            Harmony.CreateAndPatchAll(Assembly, $"{PluginInfo.PLUGIN_GUID}");
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
        public static bool whatdoicallthislol = false;
        public static float[] speedmultiplier = new float[10] { 8, 12, 17, 23, 30, 38, 47, 57, 68, 80 };
        public static CustomPrefab[] speedprefab = new CustomPrefab[10];
        public static PrefabInfo[] prefabinfo = new PrefabInfo[10];
        public static int index;
        public static float changespeedmultiplier = 4;
        private void InitializePrefabs()
        {
            for (index = 0; index < 10; index++)
            {
                speedmultiplier[index] += changespeedmultiplier;
                SeaglideSpeedModulePrefab.Register();
                Logger.LogInfo(index.ToString());
                if (index == 8)
                {
                    changespeedmultiplier = 20;
                }
                else
                {
                    changespeedmultiplier++;
                }
            }
        }
    }
}