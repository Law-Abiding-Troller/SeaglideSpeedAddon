using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
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
            if (__instance.)//unfinished
            { 
                var newallowedtech = new TechType[] { TechType.SeaTreaderPoop, LawAbidingTroller.SeaglideModConcept.SeaglideModules.SpeedPrefab.SeaglideSpeedModulePrefab.Info.TechType, SeaglideSpeedModuleMk2.Info.TechType, SeaglideSpeedModuleMk3.Info.TechType, SeaglideEfficiencyModuleMk1.Info.TechType, };
            }
            __instance.allo//also unfinished, im attempting to set the allowed tech for the storage container

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
        [HarmonyPatch(nameof(LawAbidingTroller.SeaglideModConcept.Plugin.UpdateSeaglideSpeed))] //patch the update method
        [HarmonyPostfix]
        public static void UpdateSeaglideSpeed_PostFix(LawAbidingTroller.SeaglideModConcept.Plugin __instance)
        {
            switch (__instance.currentspeed)
            {
                case 0:
                    __instance.ResetSeaglideSpeed();
                    Player.main.UpdateMotorMode();
                    break;
                case 5:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[0]);
                    Player.main.UpdateMotorMode();
                    break;
                case 6:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[1]);
                    Player.main.UpdateMotorMode();
                    break;
                case 7:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[2]);
                    Player.main.UpdateMotorMode();
                    break;
                case 8:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[3]);
                    Player.main.UpdateMotorMode();
                    break;
                case 9:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[4]);
                    Player.main.UpdateMotorMode();
                    break;
                case 10:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[5]);
                    Player.main.UpdateMotorMode();
                    break;
                case 11:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[6]);
                    Player.main.UpdateMotorMode();
                    break;
                case 12:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[7]);
                    Player.main.UpdateMotorMode();
                    break;
                case 13:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[8]);
                    Player.main.UpdateMotorMode();
                    break;
                case 14:
                    __instance.IncreaseSeaglideSpeed(Plugin.speedmultiplier[9]);
                    Player.main.UpdateMotorMode();
                    break;
                default:
                    LawAbidingTroller.SeaglideModConcept.Plugin.Logger.LogWarning("Unknown Speed Selection. Defaulting to normal");
                    __instance.ResetSeaglideSpeed();
                    Player.main.UpdateMotorMode();
                    break;
            }
        }
    }
}
