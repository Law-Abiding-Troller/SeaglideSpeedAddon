using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void Update_Postfix(LawAbidingTroller.SeaglideModConcept.Plugin __instance)
        {
            if (__instance.defineallowedtech && !Plugin.whatdoicallthislol)
            {
                var allowedtech = new TechType[17] { TechType.SeaTreaderPoop, SeaglideSpeedModulePrefab.Info.TechType, SeaglideSpeedModuleMk2.Info.TechType, SeaglideSpeedModuleMk3.Info.TechType, SeaglideEfficiencyModuleMk1.Info.TechType, SeaglideEfficiencyModuleMk2.Info.TechType, SeaglideEfficiencyModuleMk3.Info.TechType, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None, TechType.None };
                __instance.allowedtech[7] = Plugin.prefabinfo[0].TechType;
                __instance.allowedtech[8] = Plugin.prefabinfo[1].TechType;
                __instance.allowedtech[9] = Plugin.prefabinfo[2].TechType;
                __instance.allowedtech[10] = Plugin.prefabinfo[3].TechType;
                __instance.allowedtech[11] = Plugin.prefabinfo[4].TechType;
                __instance.allowedtech[12] = Plugin.prefabinfo[5].TechType;
                __instance.allowedtech[13] = Plugin.prefabinfo[6].TechType;
                __instance.allowedtech[14] = Plugin.prefabinfo[7].TechType;
                __instance.allowedtech[15] = Plugin.prefabinfo[8].TechType;
                __instance.allowedtech[16] = Plugin.prefabinfo[9].TechType;
                __instance.seaglidestorage[0].container.SetAllowedTechTypes(__instance.allowedtech);
                Plugin.whatdoicallthislol = true;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[0].TechType))
            {
                __instance.currentspeed = 5;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[1].TechType))
            {
                __instance.currentspeed = 6;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[2].TechType))
            {
                __instance.currentspeed = 7;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[3].TechType))
            {
                __instance.currentspeed = 8;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[4].TechType))
            {
                __instance.currentspeed = 9;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[5].TechType))
            {
                __instance.currentspeed = 10;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[6].TechType))
            {
                __instance.currentspeed = 11;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[7].TechType))
            {
                __instance.currentspeed = 12;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[8].TechType))
            {
                __instance.currentspeed = 13;
            }
            if (__instance.seaglidestorage[0].container.Contains(Plugin.prefabinfo[9].TechType))
            {
                __instance.currentspeed = 14;
            }
        }
    }
}
