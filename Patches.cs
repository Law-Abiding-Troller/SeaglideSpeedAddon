using HarmonyLib;
using LawAbidingTroller.LiteralSeaglideUpgrades;
using LawAbidingTroller.LiteralSeaglideUpgrades.Seaglide_Modules.Efficiency_Modules;
using LawAbidingTroller.SeaglideModConcept;
using LawAbidingTroller.SeaglideModConcept.SeaglideModules.SpeedPrefab;
using LiteralSeaglideUpgrades;


namespace SeaglideSpeedAddon
{
    [HarmonyPatch(typeof(LawAbidingTroller.SeaglideModConcept.Plugin))] //patch the plugin class
    public class PluginPatches
    {
        [HarmonyPatch(nameof(LawAbidingTroller.SeaglideModConcept.Plugin.Update))] //patch the update method
        [HarmonyPostfix]
        public static void Update_Postfix(LawAbidingTroller.SeaglideModConcept.Plugin instance)
        {
            if (instance.defineallowedtech && !Plugin.Whatdoicallthislol)
            {
                instance.allowedtech[7] = Plugin.Prefabinfo[0].TechType;
                instance.allowedtech[8] = Plugin.Prefabinfo[1].TechType;
                instance.allowedtech[9] = Plugin.Prefabinfo[2].TechType;
                instance.allowedtech[10] = Plugin.Prefabinfo[3].TechType;
                instance.allowedtech[11] = Plugin.Prefabinfo[4].TechType;
                instance.allowedtech[12] = Plugin.Prefabinfo[5].TechType;
                instance.allowedtech[13] = Plugin.Prefabinfo[6].TechType;
                instance.allowedtech[14] = Plugin.Prefabinfo[7].TechType;
                instance.allowedtech[15] = Plugin.Prefabinfo[8].TechType;
                instance.allowedtech[16] = Plugin.Prefabinfo[9].TechType;
                instance.seaglidestorage[0].container.SetAllowedTechTypes(instance.allowedtech);
                Plugin.Whatdoicallthislol = true;
            }
        }
    }
}