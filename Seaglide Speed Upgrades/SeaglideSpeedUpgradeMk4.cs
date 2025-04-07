using System.Collections.Generic;
using Nautilus.Assets;
using Nautilus.Assets.Gadgets;
using Nautilus.Assets.PrefabTemplates;
using UnityEngine;
using LawAbidingTroller.SeaglideModConcept.SeaglideModules.SpeedPrefab;

namespace SeaglideSpeedAddon
{
    public class SeaglideSpeedModulePrefab
    {
        public static TechType techType = TechType.VehiclePowerUpgradeModule;
        public static void Register()
        {

            Plugin.prefabinfo[Plugin.index] = PrefabInfo.WithTechType($"SeaglideSpeedUpgradeMk{GetSpeed()}", $"Seaglide Speed Upgrade Module Mk {GetSpeed()}", $"Mk {GetSpeed()} Speed Upgrade Module for the Seaglide. {Plugin.speedmultiplier[Plugin.index]}x normal speed.")
                .WithIcon(SpriteManager.Get(TechType.Seaglide));
            Plugin.speedprefab[Plugin.index] = new CustomPrefab(Plugin.prefabinfo[Plugin.index]);
            var clone = new CloneTemplate(Plugin.prefabinfo[Plugin.index], techType);
            clone.ModifyPrefab += obj =>
            {
                GameObject model = obj.gameObject;
                model.transform.localScale = Vector3.one / 0002;
            };
            Plugin.speedprefab[Plugin.index].SetGameObject(clone);
            Plugin.speedprefab[Plugin.index].SetRecipe(new Nautilus.Crafting.RecipeData()
            {
                craftAmount = 1,
                Ingredients = new List<CraftData.Ingredient>()
                {
                    new CraftData.Ingredient(TechType.Lubricant, 3),
                    new CraftData.Ingredient(TechType.AdvancedWiringKit, 2),
                    new CraftData.Ingredient(TechType.Battery, 1),
                    new CraftData.Ingredient(GetCurrentModule(), 1)
                }
            })
            .WithFabricatorType(CraftTree.Type.Fabricator)
            .WithStepsToFabricatorTab("Personal", "Tools", "SeaglideTab")
            .WithCraftingTime(5f);
            Plugin.speedprefab[Plugin.index].SetUnlock(TechType.Seaglide);
            Plugin.speedprefab[Plugin.index].Register();

            Plugin.Logger.LogInfo($"Prefab SeaglideSpeedUpgradeMk{Plugin.changespeedmultiplier} successfully initalized!");
        }
        static TechType GetCurrentModule()
        {
            if (Plugin.index == 0)
            {
                return TechType.WiringKit;
            }
            else
            {
                return Plugin.prefabinfo[Plugin.index - 1].TechType;
            }
        }
        static float GetSpeed()
        {
            if (Plugin.changespeedmultiplier == 20)
            {
                return 13;
            }
            else
            {
                return Plugin.changespeedmultiplier;
            }
        }
    }
}