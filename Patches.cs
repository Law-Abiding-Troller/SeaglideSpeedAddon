using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using LawAbidingTroller.SeaglideModConcept;
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
            
        }
    }
}