using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
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
                case 2:
                    __instance.IncreaseSeaglideSpeed(SeaglideSpeedModulePrefab.mk1speedmultiplier);
                    Player.main.UpdateMotorMode();
                    break;
                case 3:
                    __instance.IncreaseSeaglideSpeed(SeaglideSpeedModuleMk2.mk2speedmultiplier);
                    Player.main.UpdateMotorMode();
                    break;
                case 4:
                    __instance.IncreaseSeaglideSpeed(SeaglideSpeedModuleMk3.mk3speedmultiplier);
                    Player.main.UpdateMotorMode();
                    break;
                default:
                    Logger.LogWarning("Unknown Speed Selection. Defaulting to normal");
                    __instance.ResetSeaglideSpeed();
                    Player.main.UpdateMotorMode();
                    break;
            }
        }
    }
}
