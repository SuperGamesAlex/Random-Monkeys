﻿using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Map;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using UnhollowerBaseLib;
using RandomMonkeys.Display;

namespace RandomMonkeys.Towers
{
    class Tier_2 : ModTower
    {
        public override string TowerSet => SUPPORT;
        public override string BaseTower => TowerType.DartMonkey;
        public override string Description => "Random Tower Tier 2";

        public override int Cost => 1800;
        public override int TopPathUpgrades => 0;
        public override int MiddlePathUpgrades => 0;
        public override int BottomPathUpgrades => 0;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            Il2CppStructArray<AreaType> newAreaType = new Il2CppStructArray<AreaType>(2);

            newAreaType[0] = AreaType.land;
            newAreaType[1] = AreaType.water;

            towerModel.areaTypes = newAreaType;

            towerModel.ApplyDisplay<RandomDisplay>();
        }

        public override string Icon => "Tier2-Icon";
        public override string Portrait => "Tier2-Icon";
    }
}