using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Assets;
using LawAbidingTroller.SeaglideModConcept.SeaglideModules.SpeedPrefab;

namespace SeaglideSpeedAddon
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInDependency("com.snmodding.nautilus", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.lawabidingtroller.literalseaglideupgrades", BepInDependency.DependencyFlags.HardDependency)]

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
        public static bool Whatdoicallthislol = false;
        public static float[] Speedmultiplier = { 8, 12, 17, 23, 30, 38, 47, 57, 68, 80 };
        public static CustomPrefab[] Speedprefab = new CustomPrefab[10];
        public static PrefabInfo[] Prefabinfo = new PrefabInfo[10];
        public static int Index;
        public static float Changespeedmultiplier = 4;
        private static void InitializePrefabs()
        {
            for (Index = 0; Index < 10; Index++)
            {
                Speedmultiplier[Index] += Changespeedmultiplier;
                SeaglideSpeedModulePrefab.Register();
                Logger.LogInfo(Index.ToString());
                if (Index == 8)
                {
                    Changespeedmultiplier = 20;
                }
                else
                {
                    Changespeedmultiplier++;
                }
            }
        }
    }
}