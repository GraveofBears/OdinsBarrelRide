using BepInEx;
using UnityEngine;
using PieceManager;
using ServerSync;
using HarmonyLib;



namespace OdinsBarrelRide
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class OdinsBarrelRide : BaseUnityPlugin
    {
        private const string ModName = "OdinsBarrelRide";
        private const string ModVersion = "1.0.4";
        private const string ModGUID = "org.bepinex.plugins.odinsbarrelride";


        private void Awake()
        {

            BuildPiece OdinsBarrelRide = new(PiecePrefabManager.RegisterAssetBundle("barrelwhip"), "OdinsBarrelRide");
            OdinsBarrelRide.Name.English("OdinsBarrelRide");
            OdinsBarrelRide.Description.English("Ride or Die");
            OdinsBarrelRide.RequiredItems.Add("Wood", 20, true);
            OdinsBarrelRide.RequiredItems.Add("LeatherScraps", 4, true); ;
            OdinsBarrelRide.Crafting.Set(CraftingTable.Workbench);
            OdinsBarrelRide.Category.Add(BuildPieceCategory.Misc);

            BuildPiece OdinsDuckRide = new(PiecePrefabManager.RegisterAssetBundle("barrelwhip"), "OdinsDuckRide");
            OdinsDuckRide.Name.English("OdinsDuckRide");
            OdinsDuckRide.Description.English("Quack or Die");
            OdinsDuckRide.RequiredItems.Add("Feathers", 10, true);
            OdinsDuckRide.RequiredItems.Add("LeatherScraps", 4, true);
            OdinsDuckRide.Crafting.Set(CraftingTable.Workbench);
            OdinsDuckRide.Category.Add(BuildPieceCategory.Misc);


        }


    }
}
