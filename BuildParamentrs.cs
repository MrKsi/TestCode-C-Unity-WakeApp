using BitBenderGames;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
/// <summary>
/// Тип кнопок,которые будут появляться снизу экрана при выборе текущего строения.
/// </summary>
public enum TypeButtonsForObjects
{
    Information,
    Default,
    Building,
    Barn,
    Mine,
    Casern,
    Obstalces,
}
/// <summary>
/// Тип текущего строения.
/// </summary>
public enum TypeBuild
{
    Casern,
    ClanCastle,
    Fire,
    Turret,
    Burn,
    BuilderHome,
    Fence,
    GoldenVoxel,
    Guidhall,
    Mine,
    BigStone,
    BiggerStone,
    SimpleStone,
    SmallStone,
    SimpleTree,
    SmallTree,
    BigTree,
    HatchThons,
    Thons,
    TreeThons,
}
[System.Serializable]
public class NameTypeBuild
{
    /// <summary>
    /// Тип текущего строения.
    /// </summary>
    public enum TypeBuild
    {
        Casern,
        ClanCastle,
        Fire,
        Turret,
        Burn,
        BuilderHome,
        Fence,
        GoldenVoxel,
        Guidhall,
        Mine,
        BigStone,
        BiggerStone,
        SimpleStone,
        SmallStone,
        SimpleTree,
        SmallTree,
        BigTree,
        HatchThons,
        Thons,
        TreeThons,
    }
    public TypeBuild typeBuild;
    public NameTypeBuild() { }

}
/// <summary>
/// Класс содержащий константы, необходимые для быстрого доступа к словарю перевода имени текущего строения на разные языки.
/// </summary>
class ConstStirngNamesBuild
{
    
    public const int TypeCasern = 0;
    public const int TypeClanCastle = 1;
    public const int TypeFire = 2;
    public const int TypeTurret = 3;
    public const int TypeBurn = 4;
    public const int TypeBuilderHome = 5;
    public const int TypeFence = 6;
    public const int TypeGoldenVoxel = 7;
    public const int TypeGuildhall = 8;
    public const int TypeMine = 9;
    public const int TypeBigStone = 10;
    public const int TypeBiggerStone = 11;
    public const int TypeSimpleStone = 12;
    public const int TypeSmallStone = 13;
    public const int TypeSimpleTree = 14;
    public const int TypeSmallTree = 15;
    public const int TypeBigTree = 16;
    public const int TypeHatchThons = 17;
    public const int TypeThons = 18;
    public const int TypeTreeThons = 19;
}
/// <summary>
/// Класс ,содержащий константы, необходимые для установки значений обычных харатеристик текущего здания конкретного текущего уровня.
/// </summary>
public class DefaultConstCharacterHaractiristicks
{
    public const float CasernMoneyLvL1 = 2000f;
    public const float CasernXPBuildLvL1 = 250f;
    public const float CasernMoneyLvL2 = 5000f;
    public const float CasernXPBuildLvL2 = 5000f;
    public const float CasernMoneyLvL3 = 9000f;
    public const float CasernXPBuildLvL3 = 750f;
    public const float CasernSpeedingTraninngArmy = 30f;
    public const float CasernHealthLvL1 = 250f;
    public const float CasernArmorLvL1 = 100f;
    public const float CasernTimeRespawnLvL1 = 3f;
    public const float CasernDiamondSpeedLvL1 = 2f;
    public const float CasernHealthLvL2 = 500f;
    public const float CasernArmorLvL2 = 250f;
    public const float CasernTimeRespawnLvL2 = 4f;
    public const float CasernDiamondSpeedLvL2 = 20f;
    public const float CasernHealthLvL3 = 1250f;
    public const float CasernArmorLvL3 = 500f;
    public const float CasernTimeRespawnLvL3 = 5f;
    public const float CasernDiamondSpeedLvL3 = 40f;
    public const float ClanCastleMoneyLvL1 = 10000f;
    public const float ClanCastleXPBuildLvL1 = 2000f;
    public const float ClanCastleMoneyLvL2 = 50000f;
    public const float ClanCastleXPBuildLvL2 = 4000f;
    public const float ClanCastleMoneyLvL3 = 95000f;
    public const float ClanCastleXPBuildLvL3 = 6000f;
    public const float ClanCastleHealthLvL1 = 1000f;
    public const float ClanCastleArmorLvL1 = 500f;
    public const float ClanCastleTimeRespawnLvL1 = 2f;
    public const float ClanCastleDiamondSpeedLvL1 = 200f;
    public const float ClanCastleHealthLvL2 = 3000f;
    public const float ClanCastleArmorLvL2 = 750f;
    public const float ClanCastleTimeRespawnLvL2 = 3f;
    public const float ClanCastleDiamondSpeedLvL2 = 400f;
    public const float ClanCastleHealthLvL3 = 7000f;
    public const float ClanCastleArmorLvL3 = 1350f;
    public const float ClanCastleTimeRespawnLvL3 = 4f;
    public const float ClanCastleDiamondSpeedLvL3 = 600f;
    public const float FireXPBuild = 5f;
    public const float FireMoney = 100f;
    public const float FireBrocken = 50f;
    public const float FireBrockenHealthLvL = 100f;
    public const float FireBrockenArmor = 25f;
    public const float FireBrockenTimeRespawn = 1f;
    public const float FireBrockenDiamondSpeedLvL = 1f;
    public const float TurretMoneyLvL1 = 2000f;
    public const float TurrentXPBuildLvL1 = 500f;
    public const float TurretMoneyLvL2 = 4500f;
    public const float TurrentXPBuildLvL2 = 1500f;
    public const float TurretMoneyLvL3 = 8500f;
    public const float TurrentXPBuildLvL3 = 3000f;
    public const float TurretHealthLvL1 = 300f;
    public const float TurretArmorLvL1 = 100f;
    public const float TurretTimeRespawnLvL1 = 1f;
    public const float TurretDiamondSpeedLvL1 = 2f;
    public const float TurretHealthLvL2 = 550f;
    public const float TurretArmorLvL2 = 250f;
    public const float TurretTimeRespawnLvL2 = 2f;
    public const float TurretDiamondSpeedLvL2 = 50f;
    public const float TurretHealthLvL3 = 1300f;
    public const float TurretArmorLvL3 = 900f;
    public const float TurretTimeRespawnLvL3 = 4f;
    public const float TurretDiamondSpeedLvL3 = 80f;
    public const float BarnMoneyLvL1 = 1000f;
    public const float BarnXPBuildLvL1 = 1000f;
    public const float BarnMoneyLvL2 = 2500f;
    public const float BarnXPBuildLvL2 = 2000f;
    public const float BarnMoneyLvL3 = 4000f;
    public const float BarnXPBuildLvL3 = 3000f;
    public const float BarnHealthLvL1 = 150f;
    public const float BarnMaxCapacityLvL1 = 3000f;
    public const float BarnArmorLvL1 = 15f;
    public const float BarnTimeRespawnLvL1 = 3f;
    public const float BarnMoneyDiamondSpeedLvL1 = 2f;
    public const float BarnHealthLvL2 = 350f;
    public const float BarnMaxCapacityLvL2 = 9000f;
    public const float BarnArmorLvL2 = 150f;
    public const float BarnTimeRespawnLvL2 = 4f;
    public const float BarnMoneyDiamondSpeedLvL2 = 16f;
    public const float BarnHealthLvL3 = 750f;
    public const float BarnMaxCapacityLvL3 = 12000f;
    public const float BarnArmorLvL3 = 250f;
    public const float BarnTimeRespawnLvL3 = 5f;
    public const float BarnMoneyDiamondSpeedLvL3 = 32f;
    public const float BuilderHomeXPBuildLvL1 = 5000f;
    public const float BuilderHomeXPBuildLvL2 = 10000f;
    public const float BuilderHomeXPBuildLvL3 = 15000f;
    public const float BuilderHomeDiamondMoney = 150f;
    public const float BuilderHomeMoneyLvL2 = 100000f;
    public const float BuilderHomeMoneyLvL3 = 200000f;
    public const float BuilderHomeHealthLvL1 = 200f;
    public const float BuilderHomeArmorLvL1 = 75f;
    public const float BuilderHomeTimeRespawnLvL1 = 1f;
    public const float BuilderHomeDiamondSpeedLvL1 = 200f;
    public const float BuilderHomeHealthLvL2 = 400f;
    public const float BuilderHomeArmorLvL2 = 150f;
    public const float BuilderHomeTimeRespawnLvL2 = 4f;
    public const float BuilderHomeDiamondSpeedLvL2 = 600f;
    public const float BuilderHomeHealthLvL3 = 800f;
    public const float BuilderHomeArmorLvL3 = 450f;
    public const float BuilderHomeTimeRespawnLvL3 = 5f;
    public const float BuilderHomeDiamondSpeedLvL3 = 1200f;
    public const float FenceBrockenMoney = 100f;
    public const float FenceBrockenHealthLvL = 200f;
    public const float FenceBrockenArmor = 75f;
    public const float FenceBrockenTimeRespawn = 1f;
    public const float FenceBrockenMoneyLvL2 = 2000f;
    public const float FenceXPBuildLvL2 = 1500f;
    public const float FenceXPBuildLvL3 = 3500f;
    public const float FenceBrockenMoneyLvL3 = 5000f;
    public const float FenceBrockenDiamondLvL2 = 15f;
    public const float FenceBrockenDiamondLvL3 = 45f;
    public const float GoldenVoxelXPBuildLvL1 = 1000f;
    public const float GoldenVoxelMoneyLvL1 = 1500f;
    public const float GoldenVoxelXPBuildLvL2 = 1250f;
    public const float GoldenVoxelMoneyLvL2 = 3500f;
    public const float GoldenVoxelMoneyLvL3 = 7500f;
    public const float GoldenVoxelXPBuildLvL3 = 1750f;
    public const float GoldenVoxelHealthlLvl1 = 300f;
    public const float GoldenVoxelCapacityLvL1 = 6000f;
    public const float GoldenVoxelArmorLvL1 = 125f;
    public const float GoldenVoxelTimeRespawnLvL1 = 3f;
    public const float GoldenVoxelDiamondSpeedLvL1 = 2f;
    public const float GoldenVoxeHealthlLvl2 = 600f;
    public const float GoldenVoxelCapacityLvL2 = 18000f;
    public const float GoldenVoxelArmorLvL2 = 250f;
    public const float GoldenVoxelTimeRespawnLvL2 = 4f;
    public const float GoldenVoxelDiamondSpeedLvL2 = 8f;
    public const float GoldenVoxeHealthlLvl3 = 900f;
    public const float GoldenVoxelCapacityLvL3 = 27000f;
    public const float GoldenVoxelArmorLvL3 = 300f;
    public const float GoldenVoxelTimeRespawnLvL3 = 5f;
    public const float GoldenVoxelDiamondSpeedLvL3 = 16f;
    public const float GuildHallXPBuildLvL1 = 500f;
    public const float GuildHallXPBuildLvL2 = 5000f;
    public const float GuildHallXPBuildLvL3 = 25000f;
    public const float GuildhallMoneyLvL2 = 50000f;
    public const float GuildhallMoneyLvL3 = 100000f;
    public const float GuildhallHealthLvL1 = 750f;
    public const float GuildhallArmorLvL1 = 355f;
    public const float GuildhallTimeRespawnLvL1 = 1f;
    public const float GuildhallHealthLvL2 = 1500f;
    public const float GuildhallArmorLvL2 = 750f;
    public const float GuildhallTimeRespawnLvL2 = 3f;
    public const float GuildhallDiamondSpeedLvL2 = 194f;
    public const float GuildhallHealthLvL3 = 3500f;
    public const float GuildhallArmorLvL3 = 1550f;
    public const float GuildhallTimeRespawnLvL3  = 5f;
    public const float GuildhallDiamondSpeedLvL3 = 211f;
    public const float MineXPBuildLvL1 = 125f;
    public const float MineMoneyLvL1 = 1750f;
    public const float MineXPBuildLvL2 = 525f;
    public const float MineMoneyLvL2 = 7050f;
    public const float MineXPBuildLvL3 = 1500f;
    public const float MineMoneyLvL3 = 9750f;
    public const float MineHealthLvL1 = 250f;
    public const float MineArmorLvL1 = 75f;
    public const float MineTimeRespawnLvL1 = 1f;
    public const float MineDiamondSpeedLvL1 = 2f;
    public const float MineHealthLvL2 = 750f;
    public const float MineArmorLvL2 = 275f;
    public const float MineTimeRespawnLvL2 = 3f;
    public const float MineDiamondSpeedLvL2 = 8f;
    public const float MineHealthLvL3 = 1000f;
    public const float MineArmorLvL3 = 495f;
    public const float MineTimeRespawnLvL3 = 4f;
    public const float MineDiamondSpeedLvL3 = 16f;

    public const float HatchThonsMoneyLvL1 = 1500f;
    public const float HatchThonsXPBuildLvL1 = 5f;
    public const float HatchThonsHealthLvL1 = 100f;
    public const float HatchThonsArmorLvL1 = 100f;
    public const float HatchThonsDiamondSpeedLvL1 = 2f;

    public const float HatchThonsMoneyLvL2 = 5000f;
    public const float HatchThonsXPBuildLvL2 = 500f;
    public const float HatchThonsHealthLvL2 = 550f;
    public const float HatchThonsArmorLvL2 = 350f;
    public const float HatchThonsDiamondSpeedLvL2 = 10f;

    public const float HatchThonsMoneyLvL3 = 9975f;
    public const float HatchThonsXPBuildLvL3 = 2500f;
    public const float HatchThonsHealthLvL3 = 1225f;
    public const float HatchThonsArmorLvL3 = 700f;
    public const float HatchThonsDiamondSpeedLvL3 = 35f;


    public const float ThonsMoneyLvL1 = 500f;
    public const float ThonsXPBuildLvL1 = 5f;
    public const float ThonsHealthLvL1 = 25f;
    public const float ThonsArmorLvL1 = 10f;
    public const float ThonsDiamondSpeedLvL1 = 2f;

    public const float ThonsMoneyLvL2 = 875f;
    public const float ThonsXPBuildLvL2 = 500f;
    public const float ThonsHealthLvL2 = 50f;
    public const float ThonsArmorLvL2 = 20f;
    public const float ThonsDiamondSpeedLvL2 = 15f;

    public const float ThonsMoneyLvL3 = 1250f;
    public const float ThonsXPBuildLvL3 = 2500f;
    public const float ThonsHealthLvL3 = 75f;
    public const float ThonsArmorLvL3 = 30f;
    public const float ThonsDiamondSpeedLvL3 = 55f;

    public const float TreeThonsMoneyLvL1 = 5000f;
    public const float TreeThonsXPBuildLvL1 = 500f;
    public const float TreeThonsHealthLvL1 = 100f;
    public const float TreeThonsArmorLvL1 = 100f;
    public const float TreeThonsDiamondSpeedLvL1 = 100f;

    public const float TreeThonsMoneyLvL2 = 10000f;
    public const float TreeThonsXPBuildLvL2 = 2500f;
    public const float TreeThonsHealthLvL2 = 500f;
    public const float TreeThonsArmorLvL2 = 500f;
    public const float TreeThonsDiamondSpeedLvL2 = 150f;


    public const float TreeThonsMoneyLvL3 = 15000f;
    public const float TreeThonsXPBuildLvL3 = 2500f;
    public const float TreeThonsHealthLvL3 = 1000f;
    public const float TreeThonsArmorLvL3 = 1000f;
    public const float TreeThonsDiamondSpeedLvL3 = 200f;

    public const float ObstacelsXPDestroy = 500f;

    public DefaultConstCharacterHaractiristicks() { }

}
class ObstaclesDiamondSpeeding
{
    public const float BigStoneDiamondSpeeding = 5f;
    public const float BiggerStoneDiamondSpeeding = 10f;
    public const float SimpleStoneDiamondSpeeding = 3f;
    public const float SmallStoneDiamondSpeeding = 2f;
    public const float SimpleTreeDiamondSpeeding = 3f;
    public const float SmallTreeDiamondSpeeding = 2f;
    public const float BigTreeDiamondSpeeding = 5f;

}
class CountsBuidlingsForUpgradeNextLevelInGuindhall
{
    public const int maxMinesLvL1 = 2;
    public const int maxBarnLvL1 = 2;
    public const int maxGoldenVoxelLvL1 = 1;
    public const int maxBuilderHomeLvL1 = 2;

    public const int maxHatchThonsLvL2 = 3;
    public const int maxThonsLvL2 = 3;
    public const int maxTreeThonsLvL2 = 2;
    public const int maxGoldenVoxelLvL2 = 3;
}
class ConstArmyBuys
{
    public const int CountBuyStonenschik = 50;
    public const float TimerRespawnStonenschik = 30;
    public const int CountBuyKopeischik = 200;
    public const float TimerRespawnKopeischik = 59;
    public const int CountBuyDybenschik = 500;
    public const float TimerRespawnDybinschik = 59;

    public const float CasernReductionTime = 0.05f;
    public const int CasernLvL1MaxCountArmy = 20;
    public const int CasernLvL2MaxCountArmy = 40;
    public const int CasernLvL3MaxCountArmy = 60;

    public const float CasernHeathAIStonenschikUp = 25, CasernHeathAIDybinschikUp = 20;
    public const float CasernHeathAIKopeischikUp = 10;
    public const float CasernArmorAIStonenschikUp = 25, CasernArmorAIDybinschikUp = 30;
    public const float CasernArmorAIKopeischikUp = 5;

    public const float CasernDamageAIStonenschikUp = 20, CasernDamageAIDybinschik = 15, CasernDamageAIKopeischink = 15;
}
/// <summary>
/// Класс содержащий константы величин, для зданий с дополнительным характиристиками.
/// </summary>
class ConstTimeDoubleCharacterRistick
{
    public const float TimeTraningArmyLvL1 = 1f;
    public const float TimeTraningArmyLvL2 = 5f;
    public const float MaxTimeTraningArmy = 10f;
    public const float TimeArbeitFoodInMinutLvL1 = 2f;
    public const float TimeArbeitFoodInMinutLvL2 = 4f;
    public const float MaxTimeArbeitFoodInMinut = 6f;
    public const float TimeDropGoldLvL1 = 2f;
    public const float TimeDropGoldLvL2 = 5f;
    public const float MaxTimeDropGold = 7f;
    public const float TimeBuilderPropLvL1 = 3f;
    public const float TimeBuilderPropLvL2 = 6f;
    public const float MaxTimeBuilderProp = 9f;
    public const float TimeTurretTimeReloadLvL1 = 1f;
    public const float TimeTurretTimeReloadLvL2 = 2f;
    public const float MaxTimeTurretReload = 4f;
    public const float DamageTurretLvL1 = 100f;
    public const float DamageTurretLvL2 = 450f;
    public const float MaxDamagerTurret = 650f;
    public const float HatchThonsDamageLvL1 = 25f;
    public const float HatchThonsTimeReloadLvL1 = 5f;
    public const float HatchThonsTimeRespawnLvL1 = 15f;
    public const float HatchThonsDamageLvL2 = 50f;
    public const float HatchThonsTimeReloadLvL2 = 3f;
    public const float HatchThonsTimeRespawnLvL2 = 10f;
    public const float HatchThonsDamageLvL3 = 100f;
    public const float HatchThonsTimeReloadLvL3 = 3f;
    public const float HatchThonsTimeRespawnLvL3 = 5f;
    public const float ThonsDamageLvL1 = 75f;
    public const float ThonsTimeReloadLvL1 = 30f;
    public const float ThonsTimeRespawnLvL1 = 60f;
    public const float ThonsDamageLvL2 = 100f;
    public const float ThonsTimeReloadLvL2 = 20f;
    public const float ThonsTimeRespawnLvL2 = 45f;
    public const float ThonsDamageLvL3 = 150f;
    public const float ThonsTimeReloadLvL3 = 10f;
    public const float ThonsTimeRespawnLvL3 = 25f;
    public const float TreeThonsDamageLvL1 = 100f;
    public const float TreeThonsTimeReloadLvL1 = 30f;
    public const float TreeThonsTimeRespawnLvL1 = 45f;
    public const float TreeThonsDamageLvL2 = 200f;
    public const float TreeThonsTimeReloadLvL2 = 15f;
    public const float TreeThonsTimeRespawnLvL2 = 25f;
    public const float TreeThonsDamageLvL3 = 300f;
    public const float TreeThonsTimeReloadLvL3 = 5f;
    public const float TreeThonsTimeRespawnLvL3 = 5f;
}

class ConstBuildLoot
{
    public const int BarnLvL1Food = 100;
    public const int BarnLvL2Food = 500;
    public const int BarnLvL3Food = 1000;
    public const int GoldenVoxelLvL1Gold = 150;
    public const int GoldenVoxelLvL2Gold = 500;
    public const int GoldenVoxelLvL3Gold = 750;
    public const int MineVoxelLvL1Gold = 165;
    public const int MineVoxelLvL2Gold = 525;
    public const int MineVoxelLvL3Gold = 775;
    public const int GuidhallLvL1Diamond = 1;
    public const int GuidhallLvL2Diamond = 2;
    public const int GuidhallLvL3Diamond = 3;
    public const int CasernLvL1Food = 50;
    public const int CasernLvL2Food = 150;
    public const int CasernLvL3Food = 500;
}
/// <summary>
/// Класс содержащий константы, необозодимые для определения текущего языка.
/// </summary>
class ConstLanguage
{
    
    public const int ru_RU = 0;
    public const int us_US = 1;
    public const int uk_UK = 2;
    public const int po_PO = 3;
    public const int fr_FR = 4;
    public const int Esp_ESP = 5;
   
}

/// <summary>
/// Класс занимающийся различными настройками для здания, его правильным отображением таких окнах так
/// информация,улучшение,а также,что необходимо ,чтобы построить данное здание, какой валютой стройтся здание.
/// </summary>
public class BuildParamentrs : MonoBehaviour
{
    /// <summary>
    /// Типы таймеров для строительства 1 это немнгоневнная постройка 0 - мгновенная постройка.
    /// </summary>
    public const int typeTimeOne = 1, typeTimeNull = 0;
    /// <summary>
    /// Константная переменная необходимая для определения важных компонентов UI текущего здания.
    /// </summary>NameModel
    const string NameModel = "Model";
    /// <summary>
    /// Непосредственно объект UIBuildScreenUse содержащий в себе все необходимые UI компоненты для взаимодействия игрока.
    /// </summary>
    const string UICanvas = "UIBuildScreenUse";
    /// <summary>
    /// Константа необходиманя для поиска панели строительства в объекте UICanvas.
    /// </summary>
    const string UIPanelUseBuild = "PanelUseBuild";
    /// <summary>
    /// Константа необходимая для поиска стрелки на объекте казармы.
    /// </summary>
    const string ArrowCasern = "ArrowCasern";
    /// <summary>
    /// Константа необходимая для поиска стрелки на объекте амбара.
    /// </summary>
    const string ArrowBurn = "ArrowBurn";
    /// <summary>
    /// Константа определения кнопки начала строительства.
    /// </summary>
    const string UISuccessInstallButton = "SuccessInstallButton";
    /// <summary>
    /// Тэг ботов, благодаря которым здания не реагируют на их пересечение.
    /// </summary>
    const string TagBotNotRegister = "AI",TagBotRegister = "NPC";
    const string NameTagStonenschik = "Stonenschik", NameTagKopeischik = "Kopeischik", NameTagDybinschik = "Dybinschik";
    const string TagPointFire = "Point ";
    const string TagPointFence = "Point", TagFence = "Fence";
    /// <summary>
    /// Рабочий Canvas на экране.
    /// </summary>
    const string UICanvasInScreen = "Canvas";
    /// <summary>
    /// Путь до звуков разрушения
    /// </summary>
    const string PathToDestorySounds = "Online/BattleForPlayers/DestroySounds/siegedie_";
    const string PathToDamageSounds = "Online/BattleForPlayers/DamageSounds/bighit_0";
    const string PathToDamageSoundKopeischik = "Online/BattleForPlayers/SwichSoundsKopeischik/woodrattle_";
    /// <summary>
    /// Пределы рандома для разных звуков.
    /// </summary>
    const int MinSoundDestroyBuild = 1, MaxSoundDestroyBuild = 4;
    const int MinSoundDamageBuild = 1, MaxSoundDamageBuild = 7;
    const int MinSoundDamageKopeischikBuild = 1, MaxSoundKopeischikBuild = 5;
    /// <summary>
    /// Объект содержащий в себе все элементы управления кнопками.
    /// </summary>
    const string UIButtonsForObjects = "ButtonsForObjects";
    /// <summary>
    /// Название контейнера в котором находяться все строения.
    /// </summary>
    const string NameTerrainBuildAndObstacels = "TerrainBuildAndObstacels";
    /// <summary>
    /// Путь до моделей ,которые можно купить в магазине.
    /// </summary>
    const string PathToObjectsBuild = "Graphic/Models/Prefabs/Shop/";
    /// <summary>
    /// Кнопка информации о текущем строении.
    /// </summary>
    const int ButtonInformation = 0;
    /// <summary>
    /// Индекс модели с нулевым индексом нужно для тех строений , которые не имеют модели прокачки до следующий уровней.
    /// </summary>
    const int modelBuildIsNull = 0;
    /// <summary>
    /// Кнопка улучшения текущего строения.
    /// </summary>
    const int ButtonUpgrade = 1;
    /// <summary>
    /// Кнопка ускорения строительства текущего строения.
    /// </summary>
    const int ButtonSpeedingBuild = 2;
    /// <summary>
    /// Кнопка тренировки войск текущий казармы.
    /// </summary>
    const int ButtonTraningArmy = 3;
    /// <summary>
    /// Кнопка ускорения тренировки войск текущей казармы.
    /// </summary>
    const int ButtonSpeedingTraningArmy = 4;
    /// <summary>
    /// Кнопка выбора костра для спавна войск.
    /// </summary>
    const int ButtonSelectSpawnPointArmy = 5;
    /// <summary>
    /// Кнопка создания клана.
    /// </summary>
    const int ButtonCreateClan = 6;
    /// <summary>
    /// Кнопка уничтожить препятствие.
    /// </summary>
    const int ButtonDeleteObstacle = 7;
    /// <summary>
    /// Кнопка собрать еду с амбара.
    /// </summary>
    const int ButtonPickUpFood = 8;
    /// <summary>
    /// Кнопка собрать золото с шахты.
    /// </summary>
    const int ButtonPickUpGold = 9;
    /// <summary>
    /// Константное значение выработки еды.
    /// </summary>
    const int ConstCountSpawnButtonProduceFood = 10;
    /// <summary>
    /// Константное значение выработки золота.
    /// </summary>
    const int ConstCountSpawnButtonProduceGold = 200;
    /// <summary>
    /// Задаём константу объекта ChildeNameUIText для нахождения непосредненно самого NameText.
    /// </summary>
    const int ChildenNameUIText = 1;
    /// <summary>
    /// Задаём константу объекта ChildenLvLUIText для нахождения непосредненно самого LvLText.
    /// </summary>
    const int ChildenLvLUIText = 2;
    /// <summary>
    /// Задаём константу объекта ScrollBarTimeBuild для нахождения ScrollBar непосредненно самого MaxValue из ScrollBar.
    /// </summary>
    const int ScrollBarTimeBuild = 3;
    /// <summary>
    /// Задаём константу объекта PickUpFood для нахождения непосредственно данного объекта в самом UIBuildScreenUse(UICanvas)
    /// </summary>
    const int PickUpFoodAndGold = 4;
    /// <summary>
    /// Задаём константу объекта TextFull для нахождения непосредственно данного объекта в самом UIBuildScreenUse(UICanvas)
    /// </summary>
    const int TextFull = 5;
    /// <summary>
    /// Константа GoldenVoxelModels ,определяющая количество моделей GoldenVoxel.
    /// </summary>
    const int GoldenVoxelModelsCount = 4;
    const string NameConteinerSliders = "ConteinerSliders";
    /// <summary>
    /// Название модели строительного забора.
    /// </summary>
    const string NameFenceBuild = "FenceBuild";
    /// <summary>
    /// Задаём константу объекта Bedding для его изменения под размеры нового текущего строения.
    /// </summary>
    const string NameBedding = "Bedding";
    /// <summary>
    /// Константа GameController, содержащая в себе название объекта, в который будут загоняться данные ресурсов.
    /// </summary>
    const string NameGameController = "GameController";
    /// <summary>
    /// Константаная строка пути к объекту дыма,используемому в процессе строительства текущего строения.
    /// </summary>
    const string PatchToSmokeEffect = "Graphic/Effects/SmokeEffect";
    /// <summary>
    /// Константная строка пути к персонажу строитель, который будет использоваться в процессе строительства текущего строения, как сократитель его времени.
    /// </summary>
    const string PathToBuilderPerson = "Graphic/Models/Builder/Prefab/Builder";
    /// <summary>
    /// Отладочные сообщения. Необходим для проведения отладки при строительстве текущего строения.
    /// </summary>
    const string MessageOnOffDebugTEST_CheckBuildDebug = "Отладка моделей ", MessageCurrentBuildingSuccessTEST_CheckBuildDebug = "Строительство текущего строения успешно завершено!", MessageCountBuilingHomesSuccess = "Успешное подсчитывание количества домов строителей их: ", MessageCallBuilderSuccess = "Успешный вызов строителя!", MessageCountBuildingHomesFailed = "Не удалось подсчитать количество домов строителей.", MessageCallBuilderFailed = "Не удалось вызвать строителя.";
    /// <summary>
    /// Отладочные сообщения, включения выключения режима отладки текущего строения.
    /// </summary>
    const string DebugMessageOn = " включена!",DebugMessageOff = "отключена!";
    /// <summary>
    /// Константное значение названия игровой зоны.
    /// </summary>
    const string NameTerrain = "Terrain";
    /// <summary>
    /// Константное значение индекса спавна строителя в объекте дом строителя.
    /// </summary>
    const int IndexSpawnBuilderPoint = 1;
    /// <summary>
    /// Константы для работы персонажа строитель 2 - идёт домой , 0 - идёт работать.
    /// </summary>
    const int modeToHome = 2, modeToBuilding = 0;
    /// <summary>
    /// Константы для работы персонажей строителей,которые своей работой сокращают время строительства текущего строения.
    /// </summary>
    const float secondsBuildingSpeedLvL1 = 0.05f, secondsBuildingSpeedLvL2 = 0.15f, secondsBuildingSpeedLvL3 = 0.25f;
    /// <summary>
    /// Константы для поворотов строения влево и вправо.
    /// </summary>
    const int LeftRotateView = -90, RightRotateView = 90;
    /// <summary>
    /// Константа определяющая число точек на объекте огня.
    /// </summary>
    const int MaxPointFire = 60;
    /// <summary>
    /// Константы для определения количества одного дня в секундах, часа в секундах и минуты в секундах.
    /// </summary>
    const int OneDayInSeconds = 86400, OneHourInSeconds = 3600, OneMinutInSecods = 60;
    /// <summary>
    /// Количество дней,часов,минут,секунд сколько будет улучшаться - строиться здание.
    /// </summary>
    [HideInInspector]
    public float days, hours, mins, seconds;
    /// <summary>
    /// Переменная вырабатывающая, количество ресурсов.
    /// </summary>
    private float SpawnResources;
    /// <summary>
    /// Тип используемых ресурсов для постройки уничтожения текущего строения (0 - ничего 1 - золото 2 - еда 3 - алмазы)
    /// </summary>
    //[HideInInspector] // Скрываем текущую переменную в испекторе.
    public int typeResoucresUse = 0;
    /// <summary>
    /// Ресурсы необходимые для уборки препятствий со сцены.
    /// </summary>
    public const int SmallStoneResources = 1000, SimpleStoneResources = 500, BigStoneResources = 5000, BiggerStoneResources = 15000, SimpleTreeResources = 500, SmallTreeResources = 1000, BigTreeResources = 5000;
    /// <summary>
    /// Точка спавна войск.
    /// </summary>
    const string NamePointSpawnArmy = "PointSpawnArmy";
    /// <summary>
    /// Путь до модели прачника.
    /// </summary>
    const string PathStonenschik = "Graphic/Models/Army/Prefabs/Stonenschik";
    /// <summary>
    /// Путь до модели копейщика.
    /// </summary>
    const string PathKopeischink = "Graphic/Models/Army/Prefabs/Kopeischik";
    /// <summary>
    /// Путь до модели дубинщика.
    /// </summary>
    const string PathDybinschik = "Graphic/Models/Army/Prefabs/Dybinschik";
    /// <summary>
    /// Путь до префаба с иконкой и текстом количества
    /// </summary>
    const string PathToBackgroundList = "Graphic/UI/Prefabs/BackgroundIconYouArmy";
    /// <summary>
    /// Путь до иконки строительство завершено.
    /// </summary>
    const string PathToXPBuildSuccess = "Graphic/UI/GamePlayIcons/XPBuildSuccess";
    /// <summary>
    /// Путь до звука строительство завершено.
    /// </summary>
    const string PathToSoundBuildSucess = "Sounds/Buildings/BuildSuccess";
    /// <summary>
    /// Поиск в панели Army по индексу 0 (Background)
    /// </summary>
    const int BackgroundSearchInPanelArmy = 0;
    /// <summary>
    /// Название объекта ,куда будет поступать все BackgdroundIconYouArmy объекты.
    /// </summary>
    const string NameScrollViewYouArmyInCasern = "ScrollViewYouArmyInCasern";
    const string NameOnlineObjectDropsKopo = "Online/BattleForPlayers/ObjectDrops/Kopo";
    /// <summary>
    /// Индексы иконок действий с строением.
    /// </summary>
    const int FoodIcon = 0, GoldIcon = 1, BuildIcon = 2;
    const int NullSearchNumber = 0,OneSearchNumber = 1;
    /// <summary>
    /// Индексы иконок войск.
    /// </summary>
    const int NameStonenscik = 0, NameKopeischik = 1, NameDybischink = 2;
    const string NameResources = "[BATTLE OBJECT COUNT ARMY RESOURCES]";
    /// <summary>
    /// Дым заспавнен или нет?
    /// </summary>
    bool SmokeSpawned = false;
    /// <summary>
    /// Индексы золота еды алмазов Sliders.
    /// </summary>
    const int MoneySlider = 0, FoodSlider = 1, DiamondSlider = 2;

    const string NameBuilder = "Builder";
    /// <summary>
    /// Проверка типа текущего строения для определения его имени.
    /// </summary>
    /// <returns>Возвращает имя текущего строения.</returns>
    public static int SearchNamehForTypeBuild(TypeBuild typeBuild)
    {
        if (typeBuild == TypeBuild.Casern)
            return ConstStirngNamesBuild.TypeCasern; // Имя текущего строения - Казарма.
        else if (typeBuild == TypeBuild.ClanCastle)
            return ConstStirngNamesBuild.TypeClanCastle; // Имя текущего строения - Замок клана.
        else if (typeBuild == TypeBuild.Fire)
            return ConstStirngNamesBuild.TypeFire; // Имя текущего строения - Костёр.
        else if (typeBuild == TypeBuild.Turret)
            return ConstStirngNamesBuild.TypeTurret; // Имя текущего строения - Башня.
        else if (typeBuild == TypeBuild.Burn)
            return ConstStirngNamesBuild.TypeBurn; // Имя текущего строения - Амбар.
        else if (typeBuild == TypeBuild.BuilderHome)
            return ConstStirngNamesBuild.TypeBuilderHome; // Имя текущего строения - Дом строителя.
        else if (typeBuild == TypeBuild.Fence)
            return ConstStirngNamesBuild.TypeFence; // Имя текущего строения - Забор.
        else if (typeBuild == TypeBuild.GoldenVoxel)
            return ConstStirngNamesBuild.TypeGoldenVoxel; // Имя текущего строения - Золотохранилище.
        else if (typeBuild == TypeBuild.Guidhall)
            return ConstStirngNamesBuild.TypeGuildhall; // Имя текущего строения - Ратуша.
        else if (typeBuild == TypeBuild.Mine)
            return ConstStirngNamesBuild.TypeMine; // Имя текущего строения - Шахта.
        else if (typeBuild == TypeBuild.BigStone)
            return ConstStirngNamesBuild.TypeBigStone; // Имя текущего строения - Большой камень.
        else if (typeBuild == TypeBuild.BiggerStone)
            return ConstStirngNamesBuild.TypeBiggerStone; // Имя текущего строения - Огромный камень.
        else if (typeBuild == TypeBuild.SimpleStone)
            return ConstStirngNamesBuild.TypeSimpleStone; // Имя текущего строения - Маленький камень.
        else if (typeBuild == TypeBuild.SmallStone)
            return ConstStirngNamesBuild.TypeSmallStone; // Имя текущего строения - Средний камень.
        else if (typeBuild == TypeBuild.SimpleTree)
            return ConstStirngNamesBuild.TypeSimpleTree; // Имя текущего строения - Маленькое дерево.
        else if (typeBuild == TypeBuild.SmallTree)
            return ConstStirngNamesBuild.TypeSmallTree; // Имя текущего строения - Среднее дерево.
        else if (typeBuild == TypeBuild.BigTree)
            return ConstStirngNamesBuild.TypeBigTree; // Имя текущего строения - Большое дерево.
        else if (typeBuild == TypeBuild.HatchThons)
            return ConstStirngNamesBuild.TypeHatchThons; // Имя текущего строения - Люковая ловушка.
        else if (typeBuild == TypeBuild.Thons)
            return ConstStirngNamesBuild.TypeThons; // Имя текущего строения - Шипы.
        else if (typeBuild == TypeBuild.TreeThons)
            return ConstStirngNamesBuild.TypeTreeThons; // Имя текущего строения - Виселица.
        else
            return -1; // Имя текущего строения - Ошибка не удалось вычислить имя текущего строения.
    }
    //********************************************************ИНСПЕКТОР*************************************************************//
    [SerializeField] private Mesh[] modelsBuild; // Модели мешей строения.
    [SerializeField] private Sprite[] iconsBuild; // Иконки мешей строения.
    [SerializeField] private Sprite[] iconsCasernArmy; // Иконки войск.
    [SerializeField] private Sprite[] iconsIconSelectBuildQueset; // Иконки золота,еды,строительства.
    [SerializeField] private TypeBuild typeBuild; // Тип текущего строения, по нему определяется имя, и важные характеристики в окне улучшения и информация.
    [SerializeField] private TypeButtonsForObjects ButtonsObject; // Тип кнопок, которые будут появляться снизу экрана,если строение построенно.
    [SerializeField] public int СurrentLevel; // Текущий уровень здания.
    [SerializeField] private bool TEST_CheckBuildDebug; // Тестовая булевская переменная для проверки того, как будет выглядить строение на разных уровнях. 
    [SerializeField] private bool SkipTimeBuild; // Булевская переменная отвечающая за пропуск процесса строительства текущего строения.
    [SerializeField] private Transform PointSpawnTurrentObject; // Спавн стрел объекта.
    //А также для проверки успешного завершения строительства текущего строения.
    //********************************************************ИНСПЕКТОР*************************************************************//
    [HideInInspector] // Скрываем текущую переменную в инспекторе.
    public int NameBuild = 0; // Имя текущего строения, определяется постредством типа в методе NameBuildCheck
    [HideInInspector] // Скрываем текущую переменную в инспекторе.
    public float ObstalceRecailBuild = 0.0f; // Стоимость строения в ресурсах.
   // [HideInInspector] // Скрываем текущую переменную в инспекторе.
    public bool Buidling = false; // Переменная булевская определяющая строиться ли здание в данный момент времени или нет.
    public bool BuildingSuccess = false; // Переменная булевская определяющая пострено ли здание или нет.
    [HideInInspector] public bool shop = false; // Булевская переменная проверяющая, факт покупки строения в магазине - true и false - если строение улучшается.
    
    public GameObject Parent; // Родилеть текущего строения.
    [HideInInspector] // Скрываем данную переменную в инспекторе.
    public float ReductionTime = 0.0f; // Сокращение текущего времени строительства.
    [HideInInspector] // Скрываем данную переменную в инспекторе.
    public TypeButtonsForObjects tempTypeButtonsForObjects; // Запонимание перед строительством строение, а собственно,что у нас до этого могли вылезти за кнопки?
    [HideInInspector] // Скрываем данную переменную в инспекторе.
    private ConteinerLanguage conteinerLanguage; // Объявляем контейнер со списком локализации.
    [HideInInspector]
    public Transform HomeTargetPointBuilder;
    public float CurrentHealthBuild = 0.0f; // Текущий уровень здоровья здания.
    private float MaxCapacityBarn = 0.0f; // Максимальная вместимость еды в амбаре.
    private float MaxCapacityGoldenVoxel = 0.0f; // Максимальная вместимость золота в золотохранилище.
    private float CurrentProduceGoldMine = 0.0f; // Текущее вырабатонное количество золота шахтой.
    private float CurrentProduceFoodBarn = 0.0f; // Текущее вырабатонное количество еды амбаром.
    private float MaxHealthBuild = 0.0f; // Максимальное количество здоровья у здания.
    private float CurrentArmorBuild = 0.0f; // Текущая стоикость здания.
    private float MaxArmorBuild = 0.0f; // Максимальное количество стойкости у здания.
    private float CurrentTimeRespawnBuild = 0.0f; // Текущее время респавна строения.
    private float MaxTimeRespawnBuild = 0.0f; // Максимальное время возрождения строения.
    private float CurrentTimeTraningArmyBuild = 0.0f; // Текущее время тренировки армии.
    private float MaxCurrentTimeTraningArmyBuild = 0.0f; // Максимальное время тренировки армии.
    private float CurrentTimeFoodBuild = 0.0f; // Текущее время добычи еды в минуту.
    private float MaxCurrentTimeFoodBuild = 0.0f; // Максимальное время выработки пищи у амбара.
    private float CurrentTimeGoldBuild = 0.0f; // Текущее время добычи золота.
    private float MaxCurrentTimeGoldBuild = 0.0f; // Максимальное время добычи золота у шахты.
    private float CurrentTimeBuilderHomeBuild = 0.0f; // Текущее время строительства здания.
    private float MaxCurrentTimeBUilderHomeBuild = 0.0f; //Максимальное время строительства здания.
    private float CurrentTimeTurretReloadBuild = 0.0f; // Текущее время перезарядки башни.
    private float MaxCurrentTimeTurretReloadBuild = 0.0f; // Максимальное время перезарядки башни.
    private float CurrentDamageTurrentBuild = 0.0f; // Текущий урон башни.
    private float MaxCurrentDamageTurretBuild = 0.0f; // Максимальный урон башни.

    private float MaxTimeReloadHatchThons = 0.0f; // Максимальное время перезарядки текущей люковой ловушки.
    private float CurrentTimeReloadHatchThonsBuild = 0.0f; // Текущее время перезарядки люковой ловушки.
    private float MaxCurrentDamageHatchThons = 0.0f; // Максимальный урон полученный от люковой ловушки.
    private float CurrentDamageHatchThonsBuild = 0.0f; // Текущий урон полученный от люковой ловушки.
    private float MaxTimeReloadThons = 0.0f; // Максимальное время перезарядки текущей шипов ловушки.
    private float CurrentTimeReloadThonsBuild = 0.0f; // Текущее время перезарядки ловушки шипов.
    private float MaxCurrentDamageThons = 0.0f; // Максимальный урон от ловушки шипов.
    private float CurrentDamageThonsBuild = 0.0f; // Текущий урон от ловушки шипов.
    private float MaxTimeReloadTreeThons = 0.0f; // Максимальное времия перезарядки текущей виселицы ловушки.
    private float MaxCurrentDamageTreeThons = 0.0f; // Максимальный урон от виселицы ловушки.
    private float CurrentDamageTreeThonsBuild = 0.0f; // Текущий урон от виселицы ловушки.
    private float CurrentTimeReloadTreeThonsBuild = 0.0f; // Текущее время перезарядки ловушки виселицы.

    private float CurrentDiamondForSpeeding = 0.0f;
    private float MoneyBuild = 0.0f;
    private int CurrentLootBuildGold = 0; // Текущее количество добычи в строении.
    private int CurrentLootBuildFood = 0; // Текущее количество добычи в строении.
    private int CurrentLootBuildDiamond = 0; // Текущее количество добычи в строении.
    bool loadBuidling = false; // Подгружаем постройку кнопок
    private int typeTimer = 0; // Тип таймера для построек.
   [HideInInspector] public int CommonCountArmy = 0; // Армия в целом.
   [HideInInspector] public int CountStonenschik, CountKopeischik, CountDybinschik = 0; // Количество прачников копейщиков и дубинщиков.
    public float TimerReductionIsMins = DefaultConstCharacterHaractiristicks.CasernSpeedingTraninngArmy, TimerReductionIsSec = 0.0f;
    [HideInInspector]
    public bool isReductionInConteriersArmys = false; // Булевская переменная отвечающая за ReductionTime
    [HideInInspector]
    public bool CreateInBattleLootBuild = false; // Создать ли добычу для текущего строения?
    public bool BattleBuild = false; // Это строение находиться на поле битвы?
    public bool isBuidlingXP = false; // Это строение постренно и нужно собрать с него XP?
    [HideInInspector]public List<int> QueneTraningArmy;
    private int PreviousLevelDebug = 0; // Предыдущий уровень строения (нужно для отладки смены колизии строении)
    GameObject SmokeEffect; // Эффект дыма - появляет при начале строительства текущего здания.
    public Transform FireObject; // Объект огня на которой будет указана точка сбора игроком.
    [HideInInspector]public Transform[] PointsFire; // Массив точек для ботов ожидающих сражение.
    [HideInInspector] public int CountArmyInCasern = 0;
    [HideInInspector] // Скрываем перенную вызываемого строителя в испекторе.
    public GameObject CalledBuilder; // Персонаж вызываемый строитель.

    /// <summary>
    /// Списки времени
    /// </summary>
    public float TimerRespawnStonenschik = 0.0f, TimerRespawnDybinschik = 0.0f, TimerRespawnKopeischik = 0.0f;
    public float TimerRespawnStonenschikDown = 0.0f, TimerRespawnDybinschikDown = 0.0f, TimerRespawnKopeischikDown = 0.0f;

    /// <summary>
    /// Количество генеращийся армии
    /// </summary>
    public int CurrentCountArmyStonenschik,CurrentCountArmyDybinschik,CurrentConutArmyKopeischik;
    public int CurrentCountArmyBuyStonenschikOK = 0, CurrentCountArmyBuyDybinschikOK = 0, CurrentCountArmyBuyKopeischikOK = 0;

    GameObject BackgroundCreatedStonenschik, BackgroundCreatedKopeischik, BackgroundCreatedDybinschik; // Созданная иконка.

    public int indexQuene = 0;
    /// <summary>
    /// Проверка на создание иконки армии.
    /// </summary>
    public bool isCreatedBackgroundIconYouArmyStonenschik, isCreatedBackgroundIconYouArmyDybinschik, isCreatedBackgroundIconYouArmyKopeischik;

    public Vector3 previousPosBuild;
    public bool Permission = true; // Возможность строить строение.

    public Transform PointForNextFence; // Точка на следующий забор.
    //Вызываемые объекты из других источников
    public TypeBuild typeBuildRead { get => typeBuild; } // Атрибут только чтение(Чтение типа текущего строения typeBuild)
    public TypeButtonsForObjects ButtonsObjectRead { get => ButtonsObject; } // Атрибут только чтение(Чтение типа кнопок у текущего строения ButtonsObject)
    public Sprite[] iconsBuildRead { get => iconsBuild; } // Атрибут только чтение(Чтение иконок текущего строения iconsBuild)
    public int CurrentLevelRead { get => СurrentLevel; } // Атрибут только чтение(Чтение текущего уровня текущего строения)
    public float BarnMaxCapacity { get => DefaultConstCharacterHaractiristicks.BarnMaxCapacityLvL3; } // Атрибут только чтение(Чтение максимального количества вместимости в Амбар)
    public float CurrentCapacityBarn { get => MaxCapacityBarn; } // Атрибут только чтение(Чтение текущего количество вместимости в Амбар)
    public float GoldenVoxelMaxCapacity { get => DefaultConstCharacterHaractiristicks.GoldenVoxelCapacityLvL3; } // Атрибут только чтение(Чтение максимального количества вместимости в Золотохранилище)
    public float CurrentCapacityGoldenVoxel { get => MaxCapacityGoldenVoxel; } // Атрибут только чтение(Чтение текущего количество вместимости в Золотохранилище)
    public float CurrentDiamondForSpeed { get => CurrentDiamondForSpeeding; } // Атрибут только чтение(Чтение количество алмазов оставшихся до окончания строительства текущего строения)
    public float MaxHealth { get => MaxHealthBuild; } // Атрибут только чтение(Чтение переменной максимального здоровья у текущего строения - MaxHealthBuild)
    public float MaxArmor { get => MaxArmorBuild; } //Атрибут только чтение(Чтение переменной максимальной стойкости у текущего строения - MaxArmorBuild)
    public float MaxTimeRespawn { get => MaxTimeRespawnBuild; } // Атрибут только чтение(Чтение переменной максимального времени респавна у текущего строения - MaxArmorBuild)
    public float MaxTimeTraningArmy { get => MaxCurrentTimeTraningArmyBuild; } // Атрибут только чтение(Чтение переменной максимального времени тренировки войск у текущего строения - MaxArmorBuild)
    public float MaxTimeFood { get => MaxCurrentTimeFoodBuild; }  // Атрибут только чтение(Чтение переменной максимальное время выработки еды текущего строения - MaxArmorBuild)
    public float MaxTimeGold { get => MaxCurrentTimeGoldBuild; } // Атрибут только чтение(Чтение переменной максимальное время добычи золота у текущего строения - MaxArmorBuild)
    public float MaxTimeBuilderHome { get => MaxCurrentTimeBUilderHomeBuild; } // Атрибут только чтение(Чтение переменной максимальное время строительства у текущего строения - MaxArmorBuild)
    public float MaxTimeTurretReload { get => MaxCurrentTimeTurretReloadBuild; } // Атрибут только чтение(Чтение переменной максимальной время перезарядки у туррели у текущего строения - MaxArmorBuild)
    public float MaxDamageTurret { get => MaxCurrentDamageTurretBuild; } // Атрибут только чтение(Чтение переменной максимального урона у текущего строения - MaxArmorBuild)
    public int LvL { get => СurrentLevel; } // Атрибут только чтение(Чтение переменной текущего уровня у текущего строения - CurrentLevel)
    public float Armor { get => CurrentArmorBuild; } // Атрибут только чтение(Чтение переменной стойкость у текущего строения)
    public float TimeRespawn { get => CurrentTimeRespawnBuild; } // Атрибут только чтение(Чтение переменной респавна текущего строения)
    public float TimeTraningArmy { get => CurrentTimeTraningArmyBuild; } // Атрибут только чтение(Чтение переменной времени тренировки армиии у текущего строения(Казармы))
    public float TimeFood { get => CurrentTimeFoodBuild; } // Атрибут только чтение(Чтение переменной времени выработки пищи в минуту у текущего строения(Амбар))
    public float TimeGold { get => CurrentTimeGoldBuild; } // Атрибут только чтение(Чтение переменной времени добычи золота у текущего строения(Шахта))
    public float TimeBuilderHome { get => CurrentTimeBuilderHomeBuild; } // Атрибут только чтение(Чтение переменной времени уменьшения строительства у текущего строения(Дом строителя))
    public float TimeTurretReload { get => CurrentTimeTurretReloadBuild; } // Атрибут только чтение(Чтение переменной времени перезарядки башни текущего строения)
    public float DamageTurret { get => CurrentDamageTurrentBuild; } // Атрибут только чтение(Чтение переменной урона башни текущего строения)

    public float MaxTimeHatchThonsReload { get => MaxTimeReloadHatchThons; }  // Атрибут только чтение(Чтение максимального количества времени для перезарядки люковой ловушки)
    public float TimeReloadHatchThons { get => CurrentTimeReloadHatchThonsBuild; }// Атрибут только чтение(Чтение текущего времени перезарядки люковой ловушки)
    public float MaxDamageHatchThons { get => MaxCurrentDamageHatchThons; }// Атрибут только чтение(Чтение максимального урона люковой ловушки)
    public float DamageHatchThons { get => CurrentDamageHatchThonsBuild; }// Атрибут только чтение(Чтение текущего урона люковой ловушки)

    public float MaxTimeThonsReload { get => MaxTimeReloadThons; }// Атрибут только чтение(Чтение максимального времи перезарядки для шипов)
    public float TimeReloadThons { get => CurrentTimeReloadThonsBuild; }// Атрибут только чтение(Чтение текущего времи перезарядки для шипов)
    public float MaxDamageThons { get => MaxCurrentDamageThons; }// Атрибут только чтение(Чтение максимального урона от шипов)
    public float DamageThons { get => CurrentDamageThonsBuild; }// Атрибут только чтение(Чтение текущего урона от шипов)

    public float MaxTimeTreeThonsReload { get => MaxTimeReloadTreeThons; }// Атрибут только чтение(Чтение максимального времени виселицы ловушки перезарядки)
    public float TimeReloadTreeThons { get => CurrentTimeReloadTreeThonsBuild; }// Атрибут только чтение(Чтение текущего времени перезарядки виселицы ловушки)
    public float MaxDamageTreeThons { get => MaxCurrentDamageTreeThons; }// Атрибут только чтение(Чтение максимального урона от виселицы ловушки)
    public float DamageTreeThons { get => CurrentDamageTreeThonsBuild; }// Атрибут только чтение(Чтение текущего урона от виселицы ловушки)

    public GameObject otherSettings;
    /// <summary>
    /// Метод Старта. Запускает необходимые процедуры, для текущего строения.
    /// </summary>
    void Start()
    {
        QueneTraningArmy = new List<int>();
        if (!SkipTimeBuild)
            typeTimer = typeTimeOne; // Приравниваем тип таймера к 1 так как постройка будет строиться определённое время.
        else
            typeTimer = typeTimeNull;
        if (BattleBuild)
        {
            transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).gameObject.SetActive(!BattleBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(ChildenNameUIText).gameObject.SetActive(!BattleBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(ChildenLvLUIText).gameObject.SetActive(!BattleBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(!BattleBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(PickUpFoodAndGold).gameObject.SetActive(!BattleBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(TextFull).gameObject.SetActive(!BattleBuild);
            if(typeBuild != TypeBuild.Fence && typeBuild != TypeBuild.HatchThons && typeBuild != TypeBuild.Thons && typeBuild != TypeBuild.TreeThons)
            GameObject.Find(NameGameController).GetComponent<BattleController>().CountBuidlings++;
        }
        if (!BattleBuild)
        {
            if (GameObject.Find(NameGameController).GetComponent<TraningGameScene>().isTraning)
                if (typeBuild == TypeBuild.Casern)
                {
                    if (!GameObject.Find(NameGameController).GetComponent<TraningGameScene>().CasernObject)
                        GameObject.Find(NameGameController).GetComponent<TraningGameScene>().CasernObject = gameObject;
                    if (!GameObject.Find(NameGameController).GetComponent<TraningGameScene>().CasernTraningObject)
                        GameObject.Find(NameGameController).GetComponent<TraningGameScene>().CasernTraningObject = transform.Find(NameModel).Find(UICanvas).Find(ArrowCasern).GetComponent<Image>();
                }
                else if (typeBuild == TypeBuild.Burn)
                {
                    if (!GameObject.Find(NameGameController).GetComponent<TraningGameScene>().BurnArrowTraningObject)
                        GameObject.Find(NameGameController).GetComponent<TraningGameScene>().BurnArrowTraningObject = transform.Find(NameModel).Find(UICanvas).GetChild(NullSearchNumber).GetChild(OneSearchNumber).GetChild(NullSearchNumber).GetComponent<Image>();
                    if (!GameObject.Find(NameGameController).GetComponent<TraningGameScene>().BurnTraningObject)
                        GameObject.Find(NameGameController).GetComponent<TraningGameScene>().BurnTraningObject = transform.Find(NameModel).Find(UICanvas).Find(ArrowBurn).GetComponent<Image>();
                }
        }
        conteinerLanguage = new ConteinerLanguage(); // Объявляем новый контейнер для языков.
        if (TEST_CheckBuildDebug) // Если откладка моделей текущего строения по уровням включена,то выводим об этом сообщение.
            Debug.Log(MessageOnOffDebugTEST_CheckBuildDebug + gameObject.name + DebugMessageOn);
        else // Иначе выводим сообщение, то что отладка отключена.
            Debug.Log(MessageOnOffDebugTEST_CheckBuildDebug + gameObject.name + DebugMessageOff);
        if (СurrentLevel == 0 && tempTypeButtonsForObjects != TypeButtonsForObjects.Obstalces) // Если уровень текущего здания равен 0,то необходимо сделать его 1, а также если текущее строение не препятствие,то
            СurrentLevel = 1;
        PreviousLevelDebug = СurrentLevel; // Приравниваем текущий уровень к предыдущему.
        //Определяем имя текущего строения.
        NameBuild = SearchNamehForTypeBuild(typeBuild);
        //На вход метод получает два параметра тип текущего строения и текущий выбранный язык в игре. (Пока что я не реализовал остальные языки поэтому пишу вторым
        //параметром пишу константу русского языка).
        NameChanged(NameBuild,ConstLanguage.ru_RU); // Вызывает метод для смены имени текущему строению
        //Вызываем метод,который задаёт константные значения максимального здоровья максимальной стойкости, времени возрождения и дополонительных параметров строения текущего уровня.
        BuildConstSetup(СurrentLevel,typeBuild, typeTimeOne);
        //Вызываем метод, для определения предыдущей позиции строения
        UpdatePreviousPos();
        //Определяем стоимость текущего строения,если оно является препятствием.
        //Отключаем ScrollBar - счётчик времени показывающий сколько осталось до окончания строительства текущего строения.
        gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(false);
        //Вызываем метод работающий c UI панелью и кнопками текущего строения.
        ArbeitButtonsAndUIPanelCurrentBuild();
        // Вызываем метод проверки измения модели текущего строения при переходе на какой-либо из уровней.
        ModelChanged(СurrentLevel); 
        if (typeBuild == TypeBuild.BuilderHome && BuildingSuccess)// Если тип строения является дом строителя и он не улучшается и не строиться,то
        {
            if (СurrentLevel == 1)
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 2; // То прибавляем переменную максимальное количество строителей на 2
            else if (СurrentLevel == 2)
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 3; // То прибавляем переменную максимальное количество строителей на 3
            else if (СurrentLevel == 3)
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 4; // То прибавляем переменную максимальное количество строителей на 4
        }
        if (typeBuild == TypeBuild.Fire)
        {
            PointsFire = new Transform[MaxPointFire];
            for (int i = 0; i < MaxPointFire; i++)
            {
                PointsFire[i] = transform.Find(TagPointFire + '(' + (i+1) + ')');
                Debug.Log(PointsFire[i]);
            }
        }
        if (ButtonsObject == TypeButtonsForObjects.Barn || ButtonsObject == TypeButtonsForObjects.Mine) // Если текущее строение имеет тип Амбар или Шахта,то
            //Переопределяем переменную выработки ресурсов
            SpawnResources = CurrentTimeFoodBuild;
        //Определяем тип ресурсов строения для оплаты улучшения текущего строения.
        if(ButtonsObject != TypeButtonsForObjects.Obstalces)
        {
            //Если данное строение является дом строителя и его уровень 1 ,то устанавливаем тип ресурсов (алмазы).
            if (typeBuild == TypeBuild.BuilderHome && СurrentLevel == 1)
                typeResoucresUse = 3;
            else // Иначе устанавливаем тип ресурсов золото.
                typeResoucresUse = 1;
        }
        //Определяем тип ресурсов используемых для уничтожения препятствий со сцены и их стоимость.
        if(ButtonsObject == TypeButtonsForObjects.Obstalces)
        {
            BuildingSuccess = true; // Делаем препятсвие автоматически построенным.
            //Определяем тип ресурсов препятствий.
            if (typeBuild == TypeBuild.SmallStone || typeBuild == TypeBuild.SimpleStone || typeBuild == TypeBuild.BigStone) // Если текущее строение является камнем разных размеров ,кроме огромного,то
                typeResoucresUse = 1; // Устанавливаем тип оплаты ресурсами(золото) для уничтожения текущего препятствия.
            else if (typeBuild == TypeBuild.BiggerStone || typeBuild == TypeBuild.SmallTree || typeBuild == TypeBuild.SimpleTree || typeBuild == TypeBuild.BigTree) // Иначе ,если тип текущего препятствия огромный камень,то
                typeResoucresUse = 2; // Устанавливаем тип оплаты ресурсами(еда) для уничтожения текущего препятствия.
            //Определяем стоимость препятствий.
            if (typeBuild == TypeBuild.SimpleTree)
                ObstalceRecailBuild = SimpleTreeResources;
            else if (typeBuild == TypeBuild.SmallTree)
                ObstalceRecailBuild = SmallTreeResources;
            else if (typeBuild == TypeBuild.BigTree)
                ObstalceRecailBuild = BigTreeResources;
            else if (typeBuild == TypeBuild.SmallStone)
                ObstalceRecailBuild = SmallStoneResources;
            else if (typeBuild == TypeBuild.SimpleStone)
                ObstalceRecailBuild = SimpleStoneResources;
            else if (typeBuild == TypeBuild.BigStone)
                ObstalceRecailBuild = BigStoneResources;
            else if (typeBuild == TypeBuild.BiggerStone)
                ObstalceRecailBuild = BiggerStoneResources;
        }
        if(ButtonsObject == TypeButtonsForObjects.Casern)
        {
            TimerRespawnDybinschik = TimerRespawnDybinschikDown = ConstArmyBuys.TimerRespawnDybinschik;
            TimerRespawnKopeischik = TimerRespawnKopeischikDown = ConstArmyBuys.TimerRespawnKopeischik;
            TimerRespawnStonenschik = TimerRespawnStonenschikDown = ConstArmyBuys.TimerRespawnStonenschik;
        }

    }
    /// <summary>
    /// Метод Обновления. Запускет необходимые процедуры для строительства - улучешния здания,а также проверки того как будет выглядить здание на разных уровнях.
    /// </summary>
    void Update()
    {
        if (TEST_CheckBuildDebug && tempTypeButtonsForObjects != TypeButtonsForObjects.Obstalces && tempTypeButtonsForObjects != TypeButtonsForObjects.Mine && typeBuild != TypeBuild.GoldenVoxel && PreviousLevelDebug != СurrentLevel) // Если включён режим отладки мешей строений и пользователь не просматривает препятствие, то 
            ModelChanged(СurrentLevel); // Вызываем метод проверки измения модели текущего строения при переходе на какой-либо из уровней.
        if (tempTypeButtonsForObjects != TypeButtonsForObjects.Obstalces) // Если, текущее строение не является препятствием,то
            LvLInstall(СurrentLevel, ConstLanguage.ru_RU); // Включаем для отображения текущего уровня здания.
        if (Buidling) // Если наше текущее здание строиться,то
        {
            //Отключаем верхние кнопки над строением
            BuildingSuccess = false;
            gameObject.transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).gameObject.SetActive(false);
            ButtonsObject = TypeButtonsForObjects.Building; // Меняем тип кнопок на строительный(Только ускорение строительства)
            gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = iconsIconSelectBuildQueset[BuildIcon];
            if (gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>())
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = false;
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(Buidling);
            //Включаем или выключаем панель строительства если вы в режиме отладки или постройка куплена в магаизне и мы не начали строительство,то true иначе false.
            gameObject.transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).gameObject.SetActive(false);
            //Запонинаем ,какой тип имело текущее строение до момента начала строительства или сноса препятсивия
            if(!loadBuidling)
            {
                if (typeBuild == TypeBuild.Burn)
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Barn;
                else if (typeBuild == TypeBuild.Casern)
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Casern;
                else if (typeBuild == TypeBuild.Fire)
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Information;
                else if (typeBuild == TypeBuild.Mine)
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Mine;
                else if (typeBuild == TypeBuild.BiggerStone || typeBuild == TypeBuild.BigStone || typeBuild == TypeBuild.BigTree || typeBuild == TypeBuild.SimpleStone || typeBuild == TypeBuild.SimpleTree || typeBuild == TypeBuild.SmallStone || typeBuild == TypeBuild.SmallTree)
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Obstalces;
                else
                    tempTypeButtonsForObjects = TypeButtonsForObjects.Default;
                loadBuidling = true;
            }
                //Вызываем метод таймера,который и начнёт строительства здания и отображение постройки
                TimeBuidling();
        }
        if (ButtonsObject == TypeButtonsForObjects.Barn && !isBuidlingXP && !Buidling && BuildingSuccess)
            gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = iconsIconSelectBuildQueset[FoodIcon];
        else if (ButtonsObject == TypeButtonsForObjects.Mine && !isBuidlingXP && !Buidling && BuildingSuccess)
            gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = iconsIconSelectBuildQueset[GoldIcon];

        if (isReductionInConteriersArmys) // Вызываем метод уменьшения ReductionTime.
            ReductionTimeInCasern();
        if (isBuidlingXP)
        {
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == transform)
            {
                CreateSoundXPBuild();
                if (СurrentLevel == 1)
                {
                    if (typeBuild == TypeBuild.BuilderHome)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BuilderHomeXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Burn)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Casern)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL1;
                    else if (typeBuild == TypeBuild.ClanCastle)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ClanCastleXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Fire)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.FireXPBuild;
                    else if (typeBuild == TypeBuild.GoldenVoxel)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Guidhall)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL1;
                    else if (typeBuild == TypeBuild.HatchThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.HatchThonsXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Mine)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.MineXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Thons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ThonsXPBuildLvL1;
                    else if (typeBuild == TypeBuild.TreeThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TreeThonsXPBuildLvL1;
                    else if (typeBuild == TypeBuild.Turret)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL1;
                    else if (typeBuild == TypeBuild.BiggerStone || typeBuild == TypeBuild.BigStone || typeBuild == TypeBuild.BigTree || typeBuild == TypeBuild.SimpleStone || typeBuild == TypeBuild.SimpleTree || typeBuild == TypeBuild.SmallStone || typeBuild == TypeBuild.SmallTree)
                    {
                        GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false);
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ObstacelsXPDestroy;
                        Destroy(Parent); // Удаляем препятствие со сцены.
                    }
                }
                else if (СurrentLevel == 2)
                {
                    if (typeBuild == TypeBuild.BuilderHome)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BuilderHomeXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Burn)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Casern)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL2;
                    else if (typeBuild == TypeBuild.ClanCastle)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ClanCastleXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Fence)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.FenceXPBuildLvL2;
                    else if (typeBuild == TypeBuild.GoldenVoxel)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Guidhall)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL2;
                    else if (typeBuild == TypeBuild.HatchThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.HatchThonsXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Mine)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.MineXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Thons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ThonsXPBuildLvL2;
                    else if (typeBuild == TypeBuild.TreeThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TreeThonsXPBuildLvL2;
                    else if (typeBuild == TypeBuild.Turret)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL2;
                }
                else if(СurrentLevel == 3)
                {
                    if (typeBuild == TypeBuild.BuilderHome)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BuilderHomeXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Burn)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Casern)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL3;
                    else if (typeBuild == TypeBuild.ClanCastle)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ClanCastleXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Fence)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.FenceXPBuildLvL3;
                    else if (typeBuild == TypeBuild.GoldenVoxel)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Guidhall)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL3;
                    else if (typeBuild == TypeBuild.HatchThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.HatchThonsXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Mine)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.MineXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Thons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.ThonsXPBuildLvL3;
                    else if (typeBuild == TypeBuild.TreeThons)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TreeThonsXPBuildLvL3;
                    else if (typeBuild == TypeBuild.Turret)
                        GameObject.Find(NameGameController).GetComponent<ResourcesController>().XPValue += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL3;
                }
                isBuidlingXP = false;
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = isBuidlingXP;
            }
        }
        //Если текущее строение находиться в режиме битвы,то
        if (CreateInBattleLootBuild)
            //Вызываем метод, который задаст текущему строению добычу по уровню и прибавит её SlidersParametrs
            CreateLootBuild();
            
        if ((ButtonsObject == TypeButtonsForObjects.Barn || ButtonsObject == TypeButtonsForObjects.Mine) && !Buidling && BuildingSuccess) // Если текущее строение имеет тип Амбар или Шахта и оно не строится,то
            //Вызываем метод сбора ресурсов у обоих этих строении
            ResourcesPickUp(ButtonsObject);
        else if ((ButtonsObject == TypeButtonsForObjects.Barn || ButtonsObject == TypeButtonsForObjects.Mine) && Buidling && !BuildingSuccess && !isBuidlingXP && gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled)
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = false;

        if(typeTimer == typeTimeOne && !BattleBuild)
            if(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == transform)
                if(Buidling && !BuildingSuccess)
                    if (transform.position != previousPosBuild)
                        transform.position = previousPosBuild;
        if (typeTimer == typeTimeOne && !BattleBuild)
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform != transform)
            if(BuildingSuccess && !Buidling && !Permission)
                if(transform.position != previousPosBuild)
                    transform.position = previousPosBuild;
        if(ButtonsObject == TypeButtonsForObjects.Casern && !Buidling && BuildingSuccess && !isBuidlingXP)
        {
            CommonCountArmy = CountStonenschik + CountKopeischik + CountDybinschik;
            CountArmyInCasern = CurrentCountArmyBuyStonenschikOK + CurrentCountArmyBuyKopeischikOK + CurrentCountArmyBuyDybinschikOK;
            gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = CurrentCountArmyStonenschik > 0 || CurrentCountArmyDybinschik > 0 || CurrentConutArmyKopeischik > 0;
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(CurrentCountArmyStonenschik > 0 || CurrentCountArmyDybinschik > 0 || CurrentConutArmyKopeischik > 0);
            if (CurrentCountArmyStonenschik > 0 || CurrentCountArmyDybinschik > 0 || CurrentConutArmyKopeischik > 0)
            //Вызываем метод, занимающийся обновлением времени и спавном войск.
            UpdatedTimeTraningArmy();
        }

        if(typeBuild == TypeBuild.HatchThons)
            if (CurrentTimeReloadHatchThonsBuild > 0)
                 CurrentTimeReloadHatchThonsBuild -= Time.deltaTime;
        else if(typeBuild == TypeBuild.Thons)
            if(CurrentTimeReloadThonsBuild > 0)
                 CurrentTimeReloadThonsBuild -= Time.deltaTime;
        else if(typeBuild == TypeBuild.TreeThons)
            if (CurrentTimeReloadTreeThonsBuild > 0)
                CurrentTimeReloadTreeThonsBuild -= Time.deltaTime;
            
    }
    /// <summary>
    /// Метод ,занимающийся созданием звука подбора XP с построенного здания.
    /// </summary>
    void CreateSoundXPBuild()
    {
        GameObject audioObject = new GameObject();
        audioObject.AddComponent<AudioSource>();
        audioObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(PathToSoundBuildSucess);
        audioObject.GetComponent<AudioSource>().Play();
        Destroy(audioObject, audioObject.GetComponent<AudioSource>().clip.length);
    }
    /// <summary>
    /// Метод,занимающийся определением текущего типа строения для создания на нём потенциальной добычи.
    /// </summary>
    void CreateLootBuild()
    {
        bool Gold = false, Diamond = false, Food = false;
        if(typeBuild == TypeBuild.Mine)
        {
            if (СurrentLevel == 1)
                CurrentLootBuildGold = ConstBuildLoot.MineVoxelLvL1Gold;
            else if(СurrentLevel == 2)
                CurrentLootBuildGold = ConstBuildLoot.MineVoxelLvL2Gold;
            else if(СurrentLevel == 3)
                CurrentLootBuildGold = ConstBuildLoot.MineVoxelLvL3Gold;
            Gold = true;
        }else if(typeBuild == TypeBuild.GoldenVoxel)
        {
            if (СurrentLevel == 1)
                CurrentLootBuildGold = ConstBuildLoot.GoldenVoxelLvL1Gold;
            else if (СurrentLevel == 2)
                CurrentLootBuildGold = ConstBuildLoot.GoldenVoxelLvL2Gold;
            else if (СurrentLevel == 3)
                CurrentLootBuildGold = ConstBuildLoot.GoldenVoxelLvL3Gold;
            Gold = true;
        }
        else if(typeBuild == TypeBuild.Burn)
        {
            if (СurrentLevel == 1)
                CurrentLootBuildFood = ConstBuildLoot.BarnLvL1Food;
            else if (СurrentLevel == 2)
                CurrentLootBuildFood = ConstBuildLoot.BarnLvL2Food;
            else if (СurrentLevel == 3)
                CurrentLootBuildFood = ConstBuildLoot.BarnLvL3Food;
            Food = true;
        }
        else if(typeBuild == TypeBuild.Guidhall)
        {
            if (СurrentLevel == 1)
                CurrentLootBuildDiamond = ConstBuildLoot.GuidhallLvL1Diamond;
            else if (СurrentLevel == 2)
                CurrentLootBuildDiamond = ConstBuildLoot.GuidhallLvL2Diamond;
            else if (СurrentLevel == 3)
                CurrentLootBuildDiamond = ConstBuildLoot.GuidhallLvL3Diamond;
            Diamond = true;
        }
        else if(typeBuild == TypeBuild.Casern)
        {
            if (СurrentLevel == 1)
                CurrentLootBuildFood = ConstBuildLoot.CasernLvL1Food;
            else if (СurrentLevel == 2)
                CurrentLootBuildFood = ConstBuildLoot.CasernLvL2Food;
            else if (СurrentLevel == 3)
                CurrentLootBuildFood = ConstBuildLoot.CasernLvL3Food;
            Food = true;
        }
        if (Gold)
            GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(MoneySlider).GetComponent<Slider>().maxValue += CurrentLootBuildGold;
        else if(Food)
            GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(FoodSlider).GetComponent<Slider>().maxValue += CurrentLootBuildFood;
        else if(Diamond)
            GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(DiamondSlider).GetComponent<Slider>().maxValue += CurrentLootBuildDiamond;
        
        CreateInBattleLootBuild = false;
    }
    /// <summary>
    /// Дополнительный метод отключения компонентов камеры при нажатии на кнопку сбора пищи или золота.
    /// </summary>
    public void WorkInCameraObject() 
    {
        Camera.main.GetComponent<TouchInputController>().enabled = false;
        Camera.main.GetComponent<MobileTouchCamera>().enabled = false;
        Camera.main.GetComponent<MobilePickingController>().enabled = false;
    }
    /// <summary>
    /// Метод, занимающий обновлением предыдущей позиции строения.
    /// </summary>
    public void UpdatePreviousPos()
    {
        previousPosBuild = transform.position;
    }
    /// <summary>
    /// Метод ,занимающийся разрушением строения.
    /// </summary>
    /// <param name="DamageArmy">На вход подаётся переменная максимального урона от типа войск.</param>
    public void DamageBuild(float DamageArmy,int TypeSoundDamage)
    {
        if(CurrentHealthBuild > 0)
        {
            const float MinDamageBuild = 10f;
            CurrentHealthBuild -= Random.Range(MinDamageBuild, DamageArmy);
            if (!transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.activeSelf)
            {
                transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().maxValue = MaxHealthBuild;
                transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(true);
            }
            if (CurrentHealthBuild > 0)
                transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetChild(ScrollBarTimeBuild).GetComponent<Text>().text = Mathf.RoundToInt(CurrentHealthBuild) + "/" + Mathf.RoundToInt(MaxHealthBuild);
            else
                transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetChild(ScrollBarTimeBuild).GetComponent<Text>().text = 1f + "/" + Mathf.RoundToInt(MaxHealthBuild);
            transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value = CurrentHealthBuild;
            CreateAudioClipDamageBuild(TypeSoundDamage);
            if (!SmokeSpawned)
            {
                SmokeSpawned = true;
                CreateSmokeEffect();
            }
        }
        else
        {
            Destroy(SmokeEffect);
            if (typeBuild == TypeBuild.BuilderHome)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().BuilderHomeID] = false;
            else if (typeBuild == TypeBuild.Burn)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().BurnID] = false;
            else if (typeBuild == TypeBuild.Casern)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().CasernID] = false;
            else if (typeBuild == TypeBuild.Turret)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().TurrentID] = false;
            else if (typeBuild == TypeBuild.Fire)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().FireID] = false;
            else if (typeBuild == TypeBuild.GoldenVoxel)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().GoldenVoxelID] = false;
            else if (typeBuild == TypeBuild.Guidhall)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().GuidhallID] = false;
            else if (typeBuild == TypeBuild.Mine)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().MineID] = false;
            else if (typeBuild == TypeBuild.Fence)
                GameObject.Find(NameGameController).GetComponent<BattleController>().SelectedBuildIsFound[GameObject.Find(NameGameController).GetComponent<BattleController>().FenceID] = false;
            CreateAudioClipDestoryBuild();
            if (typeBuild == TypeBuild.Mine)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentGoldLootTest += CurrentLootBuildGold;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.MineXPBuildLvL1;
                    else if(СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.MineXPBuildLvL2;
                    else if(СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.MineXPBuildLvL3;
                }
                else
                {
                    GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountGold += CurrentLootBuildGold;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.MineXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.MineXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.MineXPBuildLvL3;
                }
                    
            }
            else if (typeBuild == TypeBuild.GoldenVoxel)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentGoldLootTest += CurrentLootBuildGold;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL3;
                }
                else
                {
                    GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountGold += CurrentLootBuildGold;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GoldenVoxelXPBuildLvL3;
                }

            }
                    
            else if (typeBuild == TypeBuild.Burn)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentFoodLootTest += CurrentLootBuildFood;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL3;
                }
                else
                {
                    GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountFood += CurrentLootBuildFood;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.BarnXPBuildLvL3;
                }
                    
            }

            else if (typeBuild == TypeBuild.Guidhall)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentDiamondLootTest += CurrentLootBuildDiamond;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL3;
                }
                else
                {
                    GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountDiamond += CurrentLootBuildDiamond;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.GuildHallXPBuildLvL3;
                }  
            }
                           
            else if (typeBuild == TypeBuild.Casern)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentFoodLootTest += CurrentLootBuildFood;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL3;
                }
                else
                {
                    GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountFood += CurrentLootBuildFood;
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.CasernXPBuildLvL3;
                }
                    
            }
            else if(typeBuild == TypeBuild.Fire)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.FireXPBuild;
                else
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.FireXPBuild;
            }
            else if(typeBuild == TypeBuild.Turret)
            {
                if (GameObject.Find(NameGameController).GetComponent<BattleController>().TestModeBattle)
                {
                    if (СurrentLevel == 1)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameGameController).GetComponent<BattleController>().CurrentXPTest += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL3;
                }
                else
                {
                    if (СurrentLevel == 1)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL1;
                    else if (СurrentLevel == 2)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL2;
                    else if (СurrentLevel == 3)
                        GameObject.Find(NameResources).GetComponent<ArmyResourcesOnline>().CountXP += DefaultConstCharacterHaractiristicks.TurrentXPBuildLvL3;
                }
            }
                GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(MoneySlider).GetComponent<Slider>().value -= CurrentLootBuildGold;
                GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(FoodSlider).GetComponent<Slider>().value -= CurrentLootBuildFood;
                GameObject.Find(UICanvasInScreen).transform.Find(NameConteinerSliders).GetChild(DiamondSlider).GetComponent<Slider>().value -= CurrentLootBuildDiamond;
            if (typeBuild != TypeBuild.Fence && typeBuild != TypeBuild.HatchThons && typeBuild != TypeBuild.Thons && typeBuild != TypeBuild.TreeThons)
                GameObject.Find(NameGameController).GetComponent<StatsBattle>().CountDestroyBuild++;
            Destroy(Parent);
        }
      
    }
    /// <summary>
    /// Метод, занимающийся обновлением времени и спавном войск.
    /// </summary>
    void UpdatedTimeTraningArmy()
    {
        GameObject.Find(NameGameController).GetComponent<GraphicUI>().UpdateCountPlaceInArmy();
        gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = iconsCasernArmy[QueneTraningArmy[indexQuene]];
        if(QueneTraningArmy.Count > 0)
        {
            if (CurrentCountArmyStonenschik > 0 && QueneTraningArmy[indexQuene] == 0)
            {
                ScrollbarMaxValueChanged(1);
                PrintTextBuildingTimer(0.0f, 0.0f, 0.0f, TimerRespawnStonenschikDown, ConstLanguage.ru_RU);
                if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                else
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime;
                if (TimerRespawnStonenschikDown > 0)
                {
                    if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                        TimerRespawnStonenschikDown -= Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                    else
                        TimerRespawnStonenschikDown -= Time.deltaTime;
                }
                else
                {
                    CurrentCountArmyStonenschik--;
                    if (CurrentCountArmyStonenschik == 0)
                    {
                        if (QueneTraningArmy.Count > 1)
                        {
                            Debug.Log("Conut > 1");
                            QueneTraningArmy.RemoveAt(indexQuene);
                        }
                        else
                        {
                            Debug.Log("Conut == 1");
                            QueneTraningArmy = new List<int>();
                        }
                    }

                    GameObject newStonenschik = Instantiate(Resources.Load<GameObject>(PathStonenschik));
                    newStonenschik.gameObject.name = "Stonenschik";
                    newStonenschik.GetComponent<NavMeshAgent>().Warp(new Vector3(transform.Find(NameModel).Find(NamePointSpawnArmy).position.x, 1.943334f, transform.Find(NameModel).Find(NamePointSpawnArmy).position.z));
                    newStonenschik.GetComponent<AI>().HeatlhAI += (ConstArmyBuys.CasernHeathAIStonenschikUp * СurrentLevel);
                    newStonenschik.GetComponent<AI>().ArmorAI += (ConstArmyBuys.CasernArmorAIStonenschikUp * СurrentLevel);
                    newStonenschik.GetComponent<AI>().DamageAI += (ConstArmyBuys.CasernDamageAIStonenschikUp * СurrentLevel);
                    newStonenschik.GetComponent<AI>().CurrentLevelPerson = GetComponent<BuildParamentrs>().CurrentLevelRead;
                    newStonenschik.GetComponent<AI>().transfromCasern = GetComponent<BuildParamentrs>().transform;
                    newStonenschik.GetComponent<AI>().FirePlace = GetComponent<BuildParamentrs>().FireObject;
                    newStonenschik.GetComponent<AI>().Target = GetComponent<BuildParamentrs>().FireObject.GetComponent<BuildParamentrs>().PointsFire[GetComponent<BuildParamentrs>().CountArmyInCasern];
                    newStonenschik.GetComponent<AI>().HomeTarget = GetComponent<BuildParamentrs>().transform;
                    newStonenschik.transform.SetParent(GameObject.Find(NameTerrainBuildAndObstacels).transform);
                    GetComponent<BuildParamentrs>().CountArmyInCasern++;
                    if (!isCreatedBackgroundIconYouArmyStonenschik)
                    {
                        BackgroundCreatedStonenschik = Instantiate(Resources.Load<GameObject>(PathToBackgroundList));
                        BackgroundCreatedStonenschik.transform.SetParent(GameObject.Find(NameGameController).GetComponent<GraphicUI>().PanelArmy.transform.GetChild(BackgroundSearchInPanelArmy).Find(NameScrollViewYouArmyInCasern).GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy));
                        BackgroundCreatedStonenschik.transform.GetChild(BackgroundSearchInPanelArmy).GetComponent<Image>().sprite = iconsCasernArmy[NameStonenscik];
                        CurrentCountArmyBuyStonenschikOK = 1;
                        BackgroundCreatedStonenschik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyStonenschikOK;
                        isCreatedBackgroundIconYouArmyStonenschik = true;
                    }
                    else
                    {
                        CurrentCountArmyBuyStonenschikOK++;
                        BackgroundCreatedStonenschik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyStonenschikOK;
                    }
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value = 0;
                    TimerRespawnStonenschikDown = TimerRespawnStonenschik;
                }
            }

            if (CurrentConutArmyKopeischik > 0 && QueneTraningArmy[indexQuene] == 1)
            {
                ScrollbarMaxValueChanged(2);
                PrintTextBuildingTimer(0.0f, 0.0f, 0.0f, TimerRespawnKopeischikDown, ConstLanguage.ru_RU);
                if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                else
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime;
                if (TimerRespawnKopeischikDown > 0)
                {
                    if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                        TimerRespawnKopeischikDown -= Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                    else
                        TimerRespawnKopeischikDown -= Time.deltaTime;
                }
                else
                {
                    CurrentConutArmyKopeischik--;
                    if (CurrentConutArmyKopeischik == 0)
                    {
                        if (QueneTraningArmy.Count > 1)
                        {
                            Debug.Log("Conut > 1");
                            QueneTraningArmy.RemoveAt(indexQuene);
                        }
                        else
                        {
                            Debug.Log("Conut == 1");
                            QueneTraningArmy = new List<int>();
                        }
                    }
                    GameObject newKopeischink = Instantiate(Resources.Load<GameObject>(PathKopeischink));
                    newKopeischink.gameObject.name = "Kopeischik";
                    newKopeischink.GetComponent<NavMeshAgent>().Warp(new Vector3(transform.Find(NameModel).Find(NamePointSpawnArmy).position.x, 1.943334f, transform.Find(NameModel).Find(NamePointSpawnArmy).position.z));
                    newKopeischink.GetComponent<AI>().HeatlhAI += (ConstArmyBuys.CasernHeathAIKopeischikUp * СurrentLevel);
                    newKopeischink.GetComponent<AI>().ArmorAI += (ConstArmyBuys.CasernArmorAIKopeischikUp * СurrentLevel);
                    newKopeischink.GetComponent<AI>().DamageAI += (ConstArmyBuys.CasernDamageAIKopeischink * СurrentLevel);
                    newKopeischink.GetComponent<AI>().CurrentLevelPerson = GetComponent<BuildParamentrs>().CurrentLevelRead;
                    newKopeischink.GetComponent<AI>().transfromCasern = GetComponent<BuildParamentrs>().transform;
                    newKopeischink.GetComponent<AI>().FirePlace = GetComponent<BuildParamentrs>().FireObject;
                    newKopeischink.GetComponent<AI>().Target = GetComponent<BuildParamentrs>().FireObject.GetComponent<BuildParamentrs>().PointsFire[GetComponent<BuildParamentrs>().CountArmyInCasern];
                    newKopeischink.GetComponent<AI>().HomeTarget = GetComponent<BuildParamentrs>().transform;
                    newKopeischink.transform.SetParent(GameObject.Find(NameTerrainBuildAndObstacels).transform);
                    GetComponent<BuildParamentrs>().CountArmyInCasern++;
                    if (!isCreatedBackgroundIconYouArmyKopeischik)
                    {
                        BackgroundCreatedKopeischik = Instantiate(Resources.Load<GameObject>(PathToBackgroundList));
                        BackgroundCreatedKopeischik.transform.SetParent(GameObject.Find(NameGameController).GetComponent<GraphicUI>().PanelArmy.transform.GetChild(BackgroundSearchInPanelArmy).Find(NameScrollViewYouArmyInCasern).GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy));
                        BackgroundCreatedKopeischik.transform.GetChild(BackgroundSearchInPanelArmy).GetComponent<Image>().sprite = iconsCasernArmy[NameKopeischik];
                        CurrentCountArmyBuyKopeischikOK = 1;
                        BackgroundCreatedKopeischik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyKopeischikOK;
                        isCreatedBackgroundIconYouArmyKopeischik = true;
                    }
                    else
                    {
                        CurrentCountArmyBuyStonenschikOK++;
                        BackgroundCreatedKopeischik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyKopeischikOK;
                    }
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value = 0;
                    TimerRespawnKopeischikDown = TimerRespawnKopeischik;
                }
            }

            if (CurrentCountArmyDybinschik > 0 && QueneTraningArmy[indexQuene] == 2)
            {
                ScrollbarMaxValueChanged(3);
                PrintTextBuildingTimer(0.0f, 0.0f, 0.0f, TimerRespawnDybinschikDown, ConstLanguage.ru_RU);
                if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                else
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value += Time.deltaTime;
                if (TimerRespawnDybinschikDown > 0)
                {
                    if (GetComponent<BuildParamentrs>().isReductionInConteriersArmys)
                        TimerRespawnDybinschikDown -= Time.deltaTime + ConstArmyBuys.CasernReductionTime;
                    else
                        TimerRespawnDybinschikDown -= Time.deltaTime;
                }
                else
                {
                    CurrentCountArmyDybinschik--;
                    if (CurrentCountArmyDybinschik == 0)
                    {
                        if (QueneTraningArmy.Count > 1)
                        {
                            Debug.Log("Conut > 1");
                            QueneTraningArmy.RemoveAt(indexQuene);
                        }
                        else
                        {
                            Debug.Log("Conut == 1");
                            QueneTraningArmy = new List<int>();
                        }

                    }
                    GameObject newDybinschik = Instantiate(Resources.Load<GameObject>(PathDybinschik));
                    newDybinschik.gameObject.name = "Dybinschik";
                    newDybinschik.GetComponent<NavMeshAgent>().Warp(new Vector3(transform.Find(NameModel).Find(NamePointSpawnArmy).position.x, 1.943334f, transform.Find(NameModel).Find(NamePointSpawnArmy).position.z));
                    newDybinschik.GetComponent<AI>().HeatlhAI += (ConstArmyBuys.CasernHeathAIDybinschikUp * СurrentLevel);
                    newDybinschik.GetComponent<AI>().ArmorAI += (ConstArmyBuys.CasernArmorAIDybinschikUp * СurrentLevel);
                    newDybinschik.GetComponent<AI>().DamageAI += (ConstArmyBuys.CasernDamageAIDybinschik * СurrentLevel);
                    newDybinschik.GetComponent<AI>().CurrentLevelPerson = transform.GetComponent<BuildParamentrs>().CurrentLevelRead;
                    newDybinschik.GetComponent<AI>().transfromCasern = GetComponent<BuildParamentrs>().transform;
                    newDybinschik.GetComponent<AI>().FirePlace = GetComponent<BuildParamentrs>().FireObject;
                    newDybinschik.GetComponent<AI>().Target = GetComponent<BuildParamentrs>().FireObject.GetComponent<BuildParamentrs>().PointsFire[GetComponent<BuildParamentrs>().CountArmyInCasern];
                    newDybinschik.GetComponent<AI>().HomeTarget = GetComponent<BuildParamentrs>().transform;
                    newDybinschik.transform.SetParent(GameObject.Find(NameTerrainBuildAndObstacels).transform);
                    GetComponent<BuildParamentrs>().CountArmyInCasern++;
                    if (!isCreatedBackgroundIconYouArmyDybinschik)
                    {
                        BackgroundCreatedDybinschik = Instantiate(Resources.Load<GameObject>(PathToBackgroundList));
                        BackgroundCreatedDybinschik.transform.SetParent(GameObject.Find(NameGameController).GetComponent<GraphicUI>().PanelArmy.transform.GetChild(BackgroundSearchInPanelArmy).Find(NameScrollViewYouArmyInCasern).GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy));
                        BackgroundCreatedDybinschik.transform.GetChild(BackgroundSearchInPanelArmy).GetComponent<Image>().sprite = iconsCasernArmy[NameDybischink];
                        CurrentCountArmyBuyDybinschikOK = 1;
                        BackgroundCreatedDybinschik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyDybinschikOK;
                        isCreatedBackgroundIconYouArmyDybinschik = true;
                    }
                    else
                    {
                        CurrentCountArmyBuyDybinschikOK++;
                        BackgroundCreatedDybinschik.transform.GetChild(BackgroundSearchInPanelArmy).GetChild(BackgroundSearchInPanelArmy).GetComponent<Text>().text = "x" + CurrentCountArmyBuyDybinschikOK;
                    }
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value = 0;
                    TimerRespawnDybinschikDown = TimerRespawnDybinschik;
                }
            }
        } 
    }


    /// <summary>
    /// Метод вращающий здание на 90 градусов.
    /// </summary>
    /// <param name="Rotate">На вход подаётся число вращения строения. Если оно больше 0,то вращаем вправо,иначе влево.</param>
    public void RotateBuild(int RotateView)
    {
        GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true,0.5f);
        if (RotateView > 0)
        {
            gameObject.transform.Rotate(Vector3.up, RightRotateView);
            GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true);
        }
        else
        {
            gameObject.transform.Rotate(Vector3.up, LeftRotateView);
            GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true);
        }
    }
    /// <summary>
    /// Метод начинающий строительство выбранного строения.
    /// </summary>
    /// <param name="shop">На вход подаётся переменная определяющая, покупку строения в магазине или как улучшение постройки.</param>
    public void CreateBuild(bool shop)
    {
        if(typeTimer == typeTimeOne && !BattleBuild)
        {
            if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountFreeBuilders > 0)
            {
                if(typeBuild == TypeBuild.Burn && GameObject.Find(NameGameController).GetComponent<TraningGameScene>().isTraning)
                {
                    GameObject.Find(NameGameController).GetComponent<TraningGameScene>().isOffingTraning = true;
                    GameObject.Find(NameGameController).GetComponent<TraningGameScene>().SetActiveObjectSirius();
                }
                GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true, 0.45f);
                this.shop = shop; // Присваиваем текущую булевскую переменную shop для дальнейшей проверки, куплено ли это строение в магазине, или оно улучшается.
                if (shop)
                {
                    //Вызываем метод для проставления констант времени строительства,а также констант здоровья стойкости времени возрождения строения и других параметров текущего строения(Покупка в магазине с первым уровнем).
                    BuildConstSetup(СurrentLevel, typeBuild, typeTimer);
                }
                else
                {
                    //Вызываем метод для проставления констант времени строительства текущего строения(Улучшение постройки).
                    BuildConstSetup(СurrentLevel + 1, typeBuild, typeTimer);
                }
                //Спавним эффект дыма на позиции текущего строения
                CreateSmokeEffect();
                //Включаем забор строительства
                gameObject.transform.Find(NameBedding).Find(NameFenceBuild).GetComponent<MeshRenderer>().enabled = !Buidling;
                //Включаем иконку
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = Buidling;

                if (typeBuild != TypeBuild.Fence)
                    //Вызываем метод призыва случайного строителя.
                    CallRandomBuilder();
                else if (typeBuild == TypeBuild.Fence && СurrentLevel != 1)
                    //Вызываем метод призыва случайного строителя.
                    CallRandomBuilder();
                BuildingSuccess = false; // Строительство не будет завершено.
                Buidling = true; // Начинаем строительство текущего здания.
                                 // Включаем ScrollBar процесса строительства текущего здания.
                UpdatePreviousPos(); // Обновляем предыдущую позицию.
            }
            else if (typeTimer == typeTimeOne)
                GameObject.Find(NameGameController).GetComponent<GraphicUI>().DebugMessageScreen(conteinerLanguage.MessageNoBuildersRU);
        }
        else
        {
            this.shop = shop; // Присваиваем текущую булевскую переменную shop для дальнейшей проверки, куплено ли это строение в магазине, или оно улучшается.
            if (shop)
            {
                //Вызываем метод для проставления констант времени строительства,а также констант здоровья стойкости времени возрождения строения и других параметров текущего строения(Покупка в магазине с первым уровнем).
                BuildConstSetup(СurrentLevel, typeBuild, typeTimer);
            }
            else
            {
                //Вызываем метод для проставления констант времени строительства текущего строения(Улучшение постройки).
                BuildConstSetup(СurrentLevel + 1, typeBuild, typeTimer);
            }
        }
       
    }

    private void CreateSmokeEffect()
    {
        //Спавним на месте здания эффект дыма.
        SmokeEffect = Instantiate(Resources.Load<GameObject>(PatchToSmokeEffect));
        SmokeEffect.transform.position = gameObject.transform.Find(NameBedding).position;
    }

    void CreateAudioClipDestoryBuild()
    {
        int RandomNumberSound = Random.Range(MinSoundDestroyBuild, MaxSoundDestroyBuild);
        GameObject audioDestory = new GameObject();
        audioDestory.AddComponent<AudioSource>();
        audioDestory.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(PathToDestorySounds + RandomNumberSound);
        //Тут добавить настройку звука по усмотрению.
        audioDestory.GetComponent<AudioSource>().Play();
        Destroy(audioDestory, audioDestory.GetComponent<AudioSource>().clip.length);
    }
    void CreateAudioClipDamageBuild(int TypeSound)
    {
        int RandomNumberSound = 0;
        GameObject audioDamage = new GameObject();
        audioDamage.AddComponent<AudioSource>();
        if(TypeSound == 0)
        {
           RandomNumberSound = Random.Range(MinSoundDamageBuild, MaxSoundDamageBuild);
           audioDamage.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(PathToDamageSounds + RandomNumberSound);
        }
        else
        {
            RandomNumberSound = Random.Range(MinSoundDamageKopeischikBuild, MaxSoundKopeischikBuild);
            audioDamage.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(PathToDamageSoundKopeischik + RandomNumberSound);
        } 
        //Тут добавить настройку звука по усмотрению.
        audioDamage.GetComponent<AudioSource>().Play();
        Destroy(audioDamage, audioDamage.GetComponent<AudioSource>().clip.length);
    }
    /// <summary>
    /// Метод уничтожающий здание с игровой сцены.
    /// </summary>
    public void DestroyBuild()
    {
        GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true);
        Destroy(Parent);

    }
    /// <summary>
    /// Метод занимающийся, расчётом времени строительства текущего здания.
    /// </summary>
    void TimeBuidling()
    {
        //Увеличиваем текущее значение значение постройки по времени к милисекундах.
        gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value+= Time.deltaTime + ReductionTime;
        //Вызываем метод печати времени строительства строения на экран.
        PrintTextBuildingTimer(days, hours, mins, seconds,ConstLanguage.ru_RU);
        //Вызываем метод занимающийся определением того,строит ли строитель,чтобы константно ускорить время строительства текущего строения.
        CalledBuilderReductionTimeCheck();
        //Работаем со временем строительства здания
        if (seconds > 0)
        {
            seconds -= Time.deltaTime + ReductionTime; // Отнимаем секунды в соотсветствии с правилами игры ,если строитель подошёл и начал строить, то стройка пойдет быстрее.(В зависимости уровня строителя)
        }
        else if (seconds <= 0 && mins > 0)
        {
            mins--;
            if(CurrentDiamondForSpeeding > 1)
            {
                CurrentDiamondForSpeeding--;
                if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == transform)
                    GameObject.Find(NameGameController).GetComponent<GraphicUI>().UpdateCountDiamondForSpeedingBuilding();
            }
            
            seconds = 59;
        } else if (seconds <= 0 && mins <= 0 && hours > 0)
        {
            hours--;
            mins = 59;
            seconds = 59;
        } else if (seconds <= 0 && mins <= 0 && hours <= 0 && days > 0)
        {
            days--;
            hours = 59;
            mins = 59;
            seconds = 59;
        }
        else if(seconds <= 0 && mins <= 0 && hours <= 0 && days <= 0)
        {
            ButtonsObject = tempTypeButtonsForObjects; // Возвращаем предыдущие кнопки,которые были.
            if (SmokeEffect != null) // Если эффект дыма, обнаружен и его объект не пуст,то
            Destroy(SmokeEffect); // Удаляем эффект дыма.
            //Выключаем забор строительства
            gameObject.transform.Find(NameBedding).Find(NameFenceBuild).GetComponent<MeshRenderer>().enabled = !Buidling;
            if (!shop) // Если текущее строение улучшается,то
            {
                СurrentLevel++; // Текущий уровень текущего строения увеличивается на единицу.
                if (typeBuild != TypeBuild.Fence)
                    ModelChanged(СurrentLevel); // Изменяем модель меша текущего строения ,на модель меша с новым следующим уровнем.
            }
            else if(shop && typeBuild == TypeBuild.Fence) // Иначе ,если мы купили забор в магазине и это забор,то
                SpawnNewFence();
            
            //Приравниваем текущее значение постройки к 0 т.к строительство завершено.
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().value = 0;
            if (typeBuild == TypeBuild.BuilderHome) // Если производилось улучшение дома строителя,то
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 1; // То увеличиваем переменную максимальное количество строителей на 1.
            if(typeBuild != TypeBuild.Fence)
            {
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountFreeBuilders++; // Освобождаем строителя от работы и увеличиваем число свободных строителей на 1.
                if(CalledBuilder != null)
                {
                    CalledBuilder.GetComponent<AI>().modePerson = modeToHome; // Отправляем призванного строителя домой.
                    CalledBuilder = null; // Призванный строитель больше нам не нужен.
                }
                
            }
            Buidling = false; // Заканчиваем строительство.
            BuildingSuccess = true; // Здание построенно.
            if (shop) // Если здание было куплено в магазине ,то делаем его не купленным для дальнейшего улучшения.
                shop = false;
            if (typeBuild == TypeBuild.BuilderHome)// Если тип строения является дом строителя и он не улучшается и не строиться,то
            {
                if (СurrentLevel == 1)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 2; // То прибавляем переменную максимальное количество строителей на 2
                else if (СurrentLevel == 2)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 3; // То прибавляем переменную максимальное количество строителей на 3
                else if (СurrentLevel == 3)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountMaxBuilders += 4; // То прибавляем переменную максимальное количество строителей на 4
            }
            if (!GameObject.Find(NameGameController).GetComponent<TraningGameScene>().isTraning)
            {
                if(typeBuild != TypeBuild.Fence)
                {
                    isBuidlingXP = true;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = isBuidlingXP;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = Resources.Load<Sprite>(PathToXPBuildSuccess);
                }
                else
                {
                    if (СurrentLevel > 1)
                    {
                        isBuidlingXP = true;
                        gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = isBuidlingXP;
                        gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().sprite = Resources.Load<Sprite>(PathToXPBuildSuccess);
                    }
                    else
                        gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = false;
                }
                
            } 
            //Выключаем ScrollBar времени до конца строительства текущего строения.
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).gameObject.SetActive(Buidling);
            if (TEST_CheckBuildDebug) //Если отладка строительства включена, то
            Debug.Log(MessageCurrentBuildingSuccessTEST_CheckBuildDebug); // Выводим сообщение об этом.
        }

    }
    /// <summary>
    /// Метод, занимающийся спавном следующего забора.
    /// </summary>
    void SpawnNewFence()
    {
        GameObject.Find(NameGameController).GetComponent<GraphicUI>().PickUp(true);
        GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().OnPickableTransformDeselected(transform);
        GameObject newPoint = new GameObject();
        newPoint.name = ObstacelsSpawn.NameAndTagGeneratePoint + " " + (ObstacelsSpawn.CountIPoint + 1);
        newPoint.tag = TagPointFence;
        ObstacelsSpawn.CountIPoint++;
        newPoint.transform.SetParent(GameObject.Find(NameTerrainBuildAndObstacels).transform);
        GameObject newBuidling = Instantiate(Resources.Load<GameObject>(PathToObjectsBuild + TypeBuild.Fence.ToString()));
        newBuidling.transform.position = PointForNextFence.position;
        newBuidling.transform.rotation = transform.rotation;
        newBuidling.GetComponent<BuildParamentrs>().shop = true;
        newBuidling.transform.SetParent(newPoint.transform);
        GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform = newBuidling.transform;
        GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().OnPickableTransformSeleceted(newBuidling.transform);
    }
    /// <summary>
    /// Метод занимающийся отбавлением времени ReductionTime у казармы.
    /// </summary>
    void ReductionTimeInCasern()
    {
        if (GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.activeSelf)
        {
            if(TimerReductionIsSec > 9)
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.transform.GetChild(IndexSpawnBuilderPoint).GetChild(ButtonInformation).GetComponent<Text>().text = string.Format("{0}:{1}", Mathf.RoundToInt(TimerReductionIsMins), Mathf.RoundToInt(TimerReductionIsSec));
            else
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.transform.GetChild(IndexSpawnBuilderPoint).GetChild(ButtonInformation).GetComponent<Text>().text = string.Format("{0}:0{1}", Mathf.RoundToInt(TimerReductionIsMins), Mathf.RoundToInt(TimerReductionIsSec));
        }
            
        if (TimerReductionIsSec > 0)
            TimerReductionIsSec -= Time.deltaTime;
        else if(TimerReductionIsSec <= 0)
        {
            if(TimerReductionIsMins > 0)
            {
                TimerReductionIsMins--;
                TimerReductionIsSec = 59f;
            }
            else
            {
                isReductionInConteriersArmys = false;
                ArbeitButtonsAndUIPanelCurrentBuild();
                TimerReductionIsMins = DefaultConstCharacterHaractiristicks.CasernSpeedingTraninngArmy;
                TimerReductionIsSec = 0.0f;
            }

        }
        
    }
    /// <summary>
    /// Метод занимающийся проверкой, на сколько секунд будет сокращаться работа строительства очередного текущего строения.
    /// </summary>
    void CalledBuilderReductionTimeCheck()
    {
        if(CalledBuilder != null) // Если текущий строитель был призван,то
        if (CalledBuilder.GetComponent<AI>().NextPointBuild) // Если строитель пришёл к точке и работает,то
        {
            if (CalledBuilder.GetComponent<AI>().CurrentLevelPerson == 1) // Если уровень строителя первый,то
                ReductionTime = secondsBuildingSpeedLvL1;
            else if (CalledBuilder.GetComponent<AI>().CurrentLevelPerson == 2) // Если уровень строителя второй,то
                ReductionTime = secondsBuildingSpeedLvL2;
            else if (CalledBuilder.GetComponent<AI>().CurrentLevelPerson == 3) // Если уровень строителя третий,то
                ReductionTime = secondsBuildingSpeedLvL3;
        }
        else // Иначе ,если строитель идёт к точке работы,то
            ReductionTime = 0.0f; // время строительства текущего строения увеличивается.
    }
    /// <summary>
    /// Метод печатающий время в UI -> Text и выводящий его на экран.
    /// </summary>
    /// <param name="days">На вход подаётся количество дней, в которых будет длиться строительство текущего здания.</param>
    /// <param name="hours">На вход подаётся количество часов, в которых будет длиться строительство текущего здания.</param>
    /// <param name="mins">На вход подаётся количество минут, в которых будет длиться строительство текущего здания.</param>
    /// <param name="seconds">На вход подаётся количество секунд, в которых будет длиться строительство текущего здания.</param>
    /// <param name="typeLanguage">На вход подаётся тип языка, на котором в данный момент запущена игра.</param>
    void PrintTextBuildingTimer(float days, float hours, float mins, float seconds,int typeLanguage)
    {
        const int ChildenUIScrollBarAndTimeText = 3; // Задаём константу объекта ChildenUIScrollBar для нахождения Slider'a для его заполнения и также самого текста.
        //Константы задающие значение индексов из массива определения времени строительства текущего здания.
        const int IndexDayElementInConstString = 0, IndexHoursElementInConstString = 1, IndexMinsElementInConstString = 2, IndexSecondsElementInConstString = 3;
        if (days > 0 && hours > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(days) + conteinerLanguage.NameReductionTime_RU[IndexDayElementInConstString] + Mathf.RoundToInt(hours) + conteinerLanguage.NameReductionTime_RU[IndexHoursElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(days > 0 && mins > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(days) + conteinerLanguage.NameReductionTime_RU[IndexDayElementInConstString] + Mathf.RoundToInt(mins) + conteinerLanguage.NameReductionTime_RU[IndexMinsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(days > 0 && seconds > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(days) + conteinerLanguage.NameReductionTime_RU[IndexDayElementInConstString] + Mathf.RoundToInt(seconds) + conteinerLanguage.NameReductionTime_RU[IndexSecondsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(hours > 0 && mins > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(hours) + conteinerLanguage.NameReductionTime_RU[IndexHoursElementInConstString] + Mathf.RoundToInt(mins) + conteinerLanguage.NameReductionTime_RU[IndexMinsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(hours > 0 && seconds > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(hours) + conteinerLanguage.NameReductionTime_RU[IndexHoursElementInConstString] + Mathf.RoundToInt(seconds) + conteinerLanguage.NameReductionTime_RU[IndexSecondsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(mins > 0 && seconds > 0)
        {
            if (conteinerLanguage == null)
                conteinerLanguage = new ConteinerLanguage();
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(mins) + conteinerLanguage.NameReductionTime_RU[IndexMinsElementInConstString] + Mathf.RoundToInt(seconds) + conteinerLanguage.NameReductionTime_RU[IndexSecondsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }else if(days == 0 && hours == 0 && mins == 0 && seconds > 0)
        {
            if (typeLanguage == ConstLanguage.ru_RU)
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenUIScrollBarAndTimeText).GetChild(ChildenUIScrollBarAndTimeText).GetComponent<Text>().text = Mathf.RoundToInt(seconds) + conteinerLanguage.NameReductionTime_RU[IndexSecondsElementInConstString];
            else if (typeLanguage == ConstLanguage.us_US)
                Debug.LogWarning("Английский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.uk_UK)
                Debug.LogWarning("Украинский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.po_PO)
                Debug.LogWarning("Польский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.fr_FR)
                Debug.LogWarning("Француский язык ещё не допилин братан!");
            else if (typeLanguage == ConstLanguage.Esp_ESP)
                Debug.LogWarning("Испанский язык ещё не допилин братан!");
            else
                Debug.LogError("Язык был определён не верно!");
        }
            
    }
    /// <summary>
    /// Метод ,занимающийся сбором ресурсов(еды,золота) строением ,того или иного типа.
    /// </summary>
    /// <param name="typeBuild">На вход подаётся тип строения ,которое собирает ресурсы.</param>
    void ResourcesPickUp(TypeButtonsForObjects typeBuild)
    {
        if(typeBuild == TypeButtonsForObjects.Barn) // Если наше текущее строение это амбар,то
        {
            if (CurrentProduceFoodBarn >= ConstCountSpawnButtonProduceFood) // Если количество выработанной еды больше или равно ConstCountSpawnButtonProduce,то
            {
                //Ищем на текущем строении кнопку сбора пищи и включаем её.
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = true;
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = true;
            }
            else // Иначе выключаем кнопку сбора пищи
            {
                if (!isBuidlingXP)
                {
                    //Ищем на текущем строении кнопку сбора пищи и выключаем её.
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = false;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = false;
                }else
                {
                    //Ищем на текущем строении кнопку сбора пищи и включаем её.
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = true;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = true;
                }
                
            }
            if (CurrentProduceFoodBarn > 0) // Если текущее количество выработанной еды больше 0,то
                //Делаем кнопку Interactible = true активной ,чтобы пользователь мог собрать ресурсы
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.GetComponent<Button>().interactable = true;
            else // Иначе кнопка не активна(так как нечего собирать)
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.GetComponent<Button>().interactable = false;
            //Если текущее строение выбранно и оно является амбаром,то 
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == transform)
            {
                //Очищаем все предыдущие события кнопки.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.GetComponent<Button>().onClick.RemoveAllListeners();
                //Уставливаем кнопки сборки ресурсов событие OnClick PickableResources
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.GetComponent<Button>().onClick.AddListener(() => PickableResources());
            }

            if (SpawnResources > 0) // Если переменная выработки ресурсов больше 0 ,то
                SpawnResources -= Time.deltaTime;// Отнимаем данную переменную.
            else if(SpawnResources <= 0) // Иначе если, переменная выработки ресурсов меньше или равна 0,то
            {
                if(GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountFood < GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountFood)// Если текущее количество выработанных ресурсов не превышает максимально доступного места,то
                {
                    //Вызываем отключение появления текста переполнено
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(TextFull).GetComponent<Text>().enabled = false;
                    //Прибавляем к общему количеству выработанных ресурсов 1 и умножаем на CurrentMultiPliderFoodPickUpBarn.
                    CurrentProduceFoodBarn += 1 * CurrentTimeFoodBuild;
                    //Возвращаем время выработки ресурсов назад.
                    SpawnResources = CurrentTimeFoodBuild;
                }
                else // Иначе
                    //Вызываем появление текста переполнено
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(TextFull).GetComponent<Text>().enabled = true;
                
               
            }
        }
        if(typeBuild == TypeButtonsForObjects.Mine)
        {
            if (CurrentProduceGoldMine >= ConstCountSpawnButtonProduceGold) // Если количество выработанной еды больше или равно ConstCountSpawnButtonProduce,то
            {
                //Ищем на текущем строении кнопку сбора пищи и включаем её.
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = true;
                gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = true;
            }
            else // Иначе выключаем кнопку сбора пищи
            {
                if (!isBuidlingXP)
                {
                    //Ищем на текущем строении кнопку сбора пищи и выключаем её.
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = false;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = false;
                }
                else
                {
                    //Ищем на текущем строении кнопку сбора пищи и включаем её.
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Image>().enabled = true;
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(PickUpFoodAndGold).GetComponent<Button>().enabled = true;
                }
            }
            if (CurrentProduceGoldMine > 0) // Если текущее количество выработанной еды больше 0,то
                //Делаем кнопку Interactible = true активной ,чтобы пользователь мог собрать ресурсы
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.GetComponent<Button>().interactable = true;
            else // Иначе кнопка не активна(так как нечего собирать)
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.GetComponent<Button>().interactable = false;
            //Если текущее строение выбранно и оно является амбаром,то 
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == transform)
            {
                //Очищаем все предыдущие события кнопки.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.GetComponent<Button>().onClick.RemoveAllListeners();
                //Уставливаем кнопки сборки ресурсов событие OnClick PickableResources
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.GetComponent<Button>().onClick.AddListener(() => PickableResources());
            }

            if (SpawnResources > 0) // Если переменная выработки ресурсов больше 0 ,то
                SpawnResources -= Time.deltaTime;// Отнимаем данную переменную.
            else if(SpawnResources <= 0) // Иначе если, переменная выработки ресурсов меньше или равна 0,то
            {
                if(GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney < GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney)// Если текущее количество выработанных ресурсов не превышает максимально доступного места,то
                {
                    //Вызываем отключение появления текста переполнено
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(TextFull).GetComponent<Text>().enabled = false;
                    //Прибавляем к общему количеству выработанных ресурсов 1 и умножаем на CurrentMultiPliderGoldPickUpMine.
                    CurrentProduceGoldMine += 1 * CurrentTimeGoldBuild;
                    //Возвращаем время выработки ресурсов назад.
                    SpawnResources = CurrentTimeGoldBuild;
                }
                else// Иначе
                    //Вызываем появление текста переполнено
                    gameObject.transform.Find(NameModel).transform.Find(UICanvas).GetChild(TextFull).GetComponent<Text>().enabled = true;


            }
        }
    }
    /// <summary>
    /// Метод изменяющий имя текущего строения, при запуске игры.
    /// </summary>
    /// <param name="indexName">На вход подаётся индекс имени текущего строения, который определяется при запуске игры, исходя из типа текущего строения.</param>
    /// <param name="typeLanguage">На вход подаётся тип языка, на котором в данный момент запущена игра.</param>
    void NameChanged(int indexName,int typeLanguage)
    {
        if (typeLanguage == ConstLanguage.ru_RU)
             gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenNameUIText).GetComponent<Text>().text = conteinerLanguage.NamesBuilds_RU[indexName];
        else if (typeLanguage == ConstLanguage.us_US)
             Debug.LogWarning("Английский язык ещё не допилин братан!");
        else if (typeLanguage == ConstLanguage.uk_UK)
             Debug.LogWarning("Украинский язык ещё не допилин братан!");
        else if (typeLanguage == ConstLanguage.po_PO)
             Debug.LogWarning("Польский язык ещё не допилин братан!");
        else if (typeLanguage == ConstLanguage.fr_FR)
             Debug.LogWarning("Француский язык ещё не допилин братан!");
        else if (typeLanguage == ConstLanguage.Esp_ESP)
             Debug.LogWarning("Испанский язык ещё не допилин братан!");
        else
             Debug.LogError("Язык был определён не верно!");
    }
    /// <summary>
    /// Метод занимающий установлением значения уровня в UI -> Text текущего строения.
    /// </summary>
    /// <param name="BuildCurrentLevel">На вход подаётся текущее изменённое улучшенное значение уровня текущего строения.</param>
    /// <param name="typeLanguage">На вход подаётся тип языка, на котором в данный момент запущена игра.</param>
    void LvLInstall(int BuildCurrentLevel,int typeLanguage)
    {
        //Здесь происходит смена текста уровня текущего строения.
        if (conteinerLanguage != null)
            gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenLvLUIText).GetComponent<Text>().text = conteinerLanguage.NameReductionLevel[typeLanguage] + BuildCurrentLevel;
        else
            conteinerLanguage = new ConteinerLanguage();
    }
    /// <summary>
    /// Метод занимающийся призывом случайного строителя ,исходя из строений имеющих тип дом строителя.
    /// </summary>
    void CallRandomBuilder()
    {
         try
         {
           //В начале займёмся подсчётом количества домов строителей.
            BuildParamentrs[] Buildings = GameObject.FindObjectsOfType<BuildParamentrs>(); // Находим все строения на базе игрока.
            int CountBuildersHomes = 0; // Количество домов строителей на базе игрока.
            int j = 0; // Текущий дом строителя, который будет добавляться в массив строений домов строителей.
            for (int i = 0; i < Buildings.Length; i++) // Запускаем цикл поиска количества домов строителей.
                if (Buildings[i].typeBuild == TypeBuild.BuilderHome) // Если тип текущего строения равен типу дом строителя, то
                    CountBuildersHomes++; // Прибавляем количество домов строителей.
            Debug.Log(MessageCountBuilingHomesSuccess + CountBuildersHomes); // Вызывем конструктор Debug для показа сообщения, о том, что был проведён успешный расчёт количества домов строителей на базе игрока.
            //Теперь создаём массив строении с типом дом строителя.
            BuildParamentrs[] BuildingHomes = new BuildParamentrs[CountBuildersHomes];
            //Заполняем его циклом проверяющим является ли текущее строение по Buildings[i] типом дом строителя и если да, то добавляем его в массив BuildingHomes
            for (int i = 0; i < Buildings.Length; i++)
                if (Buildings[i].typeBuild == TypeBuild.BuilderHome)
                {
                    BuildingHomes[j] = Buildings[i];
                    j++;
                }
                    
            //Выбираем рандомно какой дом строителя будем тревожить, чтобы вызвать от туда строителя
            int randomBuildingHomeWaring = Random.Range(0, CountBuildersHomes);
            //Вызываем строителя из случайного дома строителя.
            BuildingHomes[randomBuildingHomeWaring].CallBuilderSpawn(gameObject.transform);
            CalledBuilder = BuildingHomes[randomBuildingHomeWaring].CalledBuilder; // Запонимаем строителя, которого мы призвали на работу, чтобы позже его вернуть обратно домой.
            HomeTargetPointBuilder = CalledBuilder.GetComponent<AI>().HomeTarget;
            Debug.Log(MessageCallBuilderSuccess); //  Вызывем конструктор Debug для показа сообщения, о том, что был проведён успешный вызов строителя из случайного дома строителя.
        }
        catch (System.Exception)
        {
            //Вызываем конструктор Debug для показа сообщения, о том, что не удалось провести расчёт количества домов строителей на базе игрока.
            Debug.LogError(MessageCountBuildingHomesFailed);
            //Вызывем конструктор Debug для показа сообщения, о том, что был проведён не удачный вызов строителя из случайного дома строителя.
            Debug.LogError(MessageCallBuilderFailed);
            if(CalledBuilder != null) // Если бесполезный призыв строителя ,всё таки состоялся,то
            Destroy(CalledBuilder); // Уничтожаем призывного строителя,так как произошла ошибка.
        }

    }
    /// <summary>
    /// Метод занимающийся, спавном строителя из вызываемого дома.
    /// </summary>
    /// <param name="Target">На вход подаётся цель ,к которой будет следовать строитель.</param>
    public void CallBuilderSpawn(Transform Target)
    {
        CalledBuilder = Instantiate(Resources.Load<GameObject>(PathToBuilderPerson)); // Спавним персонажа строитель как отдельный объект.
        CalledBuilder.gameObject.name = NameBuilder;
        CalledBuilder.GetComponent<NavMeshAgent>().Warp(new Vector3(gameObject.transform.Find(NameModel).GetChild(IndexSpawnBuilderPoint).position.x,2.44f, gameObject.transform.Find(NameModel).GetChild(IndexSpawnBuilderPoint).position.z)); // Устанавливаем спавн строителя на вызвываем доме строителя.
        CalledBuilder.GetComponent<AI>().CurrentLevelPerson = gameObject.GetComponent<BuildParamentrs>().CurrentLevelRead; // Устанавливаем строителю уровень дома строителя.
        CalledBuilder.GetComponent<AI>().modePerson = modeToBuilding; // Устанавливаем режим строителя, как идёт работать(строить)
        CalledBuilder.GetComponent<AI>().CurrentLevelPerson = СurrentLevel; // Задём ему уровень в соответстии с уровнем призыва строения.
        CalledBuilder.GetComponent<AI>().Target = Target; // Устанавливаем цель строительства текущему строителю.
        CalledBuilder.GetComponent<AI>().HomeTarget = gameObject.transform.Find(NameBedding).transform; // Устанавливаеи точку дома текущему строителю.И
        GameObject.Find(NameGameController).GetComponent<ResourcesController>().CountFreeBuilders--; // Занимаем одного строителя на работу.
        CalledBuilder.transform.SetParent(GameObject.Find(NameTerrainBuildAndObstacels).transform);
    }
    /// <summary>
    /// Метод ,занимающийся сбором ресурсов с текущего строения
    /// </summary>
    public void PickableResources()
    {
        if (ButtonsObject == TypeButtonsForObjects.Barn) // Если текущее строения является амбаром, то
        {
            if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountFood < GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountFood) // Если полоска ресурсов не переполнена,то
            {
                //Ищем объект GameController ,чтобы прибавить переменную CurrentCountFood на количество CurrentProduceFoodBarn.
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountFood += CurrentProduceFoodBarn;
                //Обнуляем переменную CurrentProduceFoodBarn так как мы всё собрали.
                CurrentProduceFoodBarn = 0.0f;
            }
            else // Иначе вызываем метод печати сообщение о невозможности сбора ресурсов ,так как складывать их некуда!
                GameObject.Find(NameGameController).GetComponent<GraphicUI>().DebugMessageScreen(conteinerLanguage.MessageNoPlace);
        }
        if(ButtonsObject == TypeButtonsForObjects.Mine)
        {
            if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney < GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney) // Если полоска ресурсов не переполнена,то
            {
                //Ищем объект GameController ,чтобы прибавить переменную CurrentCountFood на количество CurrentProduceFoodBarn.
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney += CurrentProduceGoldMine;
                //Обнуляем переменную CurrentProduceFoodBarn так как мы всё собрали.
                CurrentProduceGoldMine = 0.0f;
            }
            else // Иначе вызываем метод печати сообщение о невозможности сбора ресурсов ,так как складывать их некуда!
                GameObject.Find(NameGameController).GetComponent<GraphicUI>().DebugMessageScreen(conteinerLanguage.MessageNoPlace);
            
        }
    }
    /// <summary>
    /// Метод занимающийся установкой констант времени строительства для текущего строения.
    /// </summary>
    /// <param name="BuildCurrentLevel">На вход подаётся текущий или следующий уровень текущго строения. Для установки констаного времени его строительства.</param>
    /// <param name="typeBuild">На вход подаётся тип текущего строения.</param>
    /// <param name="typeTime">На вход подаётся тип времени если 0 - то постройка стройться мгновенно 1 - за определённое время.</param>
    void BuildConstSetup(int BuildCurrentLevel,TypeBuild typeBuild,int typeTime)
    {
        if(BuildCurrentLevel == 1)
        {
            if(typeBuild == TypeBuild.Fire)
            {
                if(typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 10; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.FireBrockenHealthLvL;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.FireBrockenArmor;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.FireBrockenTimeRespawn;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.FireBrockenTimeRespawn;
            }
            if (typeBuild == TypeBuild.Guidhall)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GuildhallHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GuildhallArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GuildhallTimeRespawnLvL1;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GuildhallTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Burn)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 30; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BarnMoneyDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BarnHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BarnArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BarnTimeRespawnLvL1;
                CurrentTimeFoodBuild = ConstTimeDoubleCharacterRistick.TimeArbeitFoodInMinutLvL1;
                MaxCurrentTimeFoodBuild = ConstTimeDoubleCharacterRistick.MaxTimeArbeitFoodInMinut;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BarnTimeRespawnLvL3;
                MaxCapacityBarn = DefaultConstCharacterHaractiristicks.BarnMaxCapacityLvL1;
                if (!BattleBuild)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountFood += MaxCapacityBarn;
            }
            if(typeBuild == TypeBuild.BuilderHome)
            {
                if (typeTime == 1) { days = 0; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BuilderHomeDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BuilderHomeHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BuilderHomeArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BuilderHomeTimeRespawnLvL1;
                CurrentTimeBuilderHomeBuild = ConstTimeDoubleCharacterRistick.TimeBuilderPropLvL1;
                MaxCurrentTimeBUilderHomeBuild = ConstTimeDoubleCharacterRistick.MaxTimeBuilderProp;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL3;
            }
            if(typeBuild == TypeBuild.Fence)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.FenceBrockenHealthLvL;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.FenceBrockenArmor;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.FenceBrockenTimeRespawn;
            }
            if(typeBuild == TypeBuild.GoldenVoxel)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 15; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.GoldenVoxelDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelHealthlLvl1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelTimeRespawnLvL1;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelTimeRespawnLvL3;
                MaxCapacityGoldenVoxel = DefaultConstCharacterHaractiristicks.GoldenVoxelCapacityLvL1;
                if(!BattleBuild)
                GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney += MaxCapacityGoldenVoxel;
            }
            if (typeBuild == TypeBuild.Mine)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 15; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.MineDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.MineHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.MineArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL1;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL3;
                CurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.TimeDropGoldLvL1;
                MaxCurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.MaxTimeDropGold;
            }
            if (typeBuild == TypeBuild.Casern)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.CasernDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.CasernHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.CasernArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.CasernTimeRespawnLvL1;
                CurrentTimeTraningArmyBuild = ConstTimeDoubleCharacterRistick.TimeTraningArmyLvL1;
                MaxCurrentTimeTraningArmyBuild = ConstTimeDoubleCharacterRistick.MaxTimeTraningArmy;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.CasernTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Turret)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TurretDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TurretHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TurretArmorLvL1;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.TurretTimeRespawnLvL1;
                CurrentTimeTurretReloadBuild = ConstTimeDoubleCharacterRistick.TimeTurretTimeReloadLvL1;
                CurrentDamageTurrentBuild = ConstTimeDoubleCharacterRistick.DamageTurretLvL1;
                MaxCurrentTimeTurretReloadBuild = ConstTimeDoubleCharacterRistick.MaxTimeTurretReload;
                MaxCurrentDamageTurretBuild = ConstTimeDoubleCharacterRistick.MaxDamagerTurret;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.TurretTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.HatchThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 5; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.HatchThonsDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.HatchThonsHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.HatchThonsArmorLvL1;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL3;
                CurrentTimeReloadHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL1;
                CurrentDamageHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL1;
                MaxCurrentDamageHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL1;
            }
            if (typeBuild == TypeBuild.Thons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 0; seconds = 5; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.ThonsDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.ThonsHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.ThonsArmorLvL1;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL3;
                CurrentTimeReloadThonsBuild = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL3;
                MaxTimeReloadThons = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL1;
                CurrentDamageThonsBuild = ConstTimeDoubleCharacterRistick.ThonsDamageLvL1;
                MaxCurrentDamageThons = ConstTimeDoubleCharacterRistick.ThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL1;
            }
            if (typeBuild == TypeBuild.TreeThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 15; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TreeThonsDiamondSpeedLvL1;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TreeThonsHealthLvL1;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TreeThonsArmorLvL1;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL3;
                CurrentTimeReloadTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL3;
                CurrentDamageTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL1;
                MaxTimeReloadTreeThons = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL1;
                MaxCurrentDamageTurretBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL1;
            }
            if(typeBuild == TypeBuild.BiggerStone)
            {
                if (typeTime == 1) { days = 0; hours = 1; mins = 5; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.BiggerStoneDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }

            }
            if(typeBuild == TypeBuild.BigStone)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 30; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.BigStoneDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }

            }
            if(typeBuild == TypeBuild.SmallStone)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 15; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.SmallStoneDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
            }
            if (typeBuild == TypeBuild.SimpleStone)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.SimpleStoneDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
            }
            if (typeBuild == TypeBuild.BigTree)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 30; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.BigTreeDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
            }
            if (typeBuild == TypeBuild.SmallTree)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 15; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.SmallTreeDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
            }
            if (typeBuild == TypeBuild.SimpleTree)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 59; CurrentDiamondForSpeeding = ObstaclesDiamondSpeeding.SimpleTreeDiamondSpeeding; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
            }
        }
        else if(BuildCurrentLevel == 2)
        {
            if(typeBuild == TypeBuild.Guidhall)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 30; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.GuildhallDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GuildhallHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GuildhallArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GuildhallTimeRespawnLvL2;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GuildhallTimeRespawnLvL3;

            }
            if (typeBuild == TypeBuild.Burn)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BarnMoneyDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BarnHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BarnArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BarnTimeRespawnLvL2;
                CurrentTimeFoodBuild = ConstTimeDoubleCharacterRistick.TimeArbeitFoodInMinutLvL2;
                MaxCurrentTimeFoodBuild = ConstTimeDoubleCharacterRistick.MaxTimeArbeitFoodInMinut;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BarnTimeRespawnLvL3;
                MaxCapacityBarn = DefaultConstCharacterHaractiristicks.BarnMaxCapacityLvL2;
                if (!BattleBuild)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountFood += MaxCapacityBarn;
            }
            if (typeBuild == TypeBuild.BuilderHome)
            {
                if (typeTime == 1) { days = 1; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BuilderHomeDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BuilderHomeHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BuilderHomeArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BuilderHomeTimeRespawnLvL2;
                CurrentTimeBuilderHomeBuild = ConstTimeDoubleCharacterRistick.TimeBuilderPropLvL2;
                MaxCurrentTimeBUilderHomeBuild = ConstTimeDoubleCharacterRistick.MaxTimeBuilderProp;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BuilderHomeTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Fence)
            {
                if (typeTime == 1) { days = 0; hours = 2; mins = 1; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.FenceBrockenDiamondLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.FenceBrockenHealthLvL * 2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.FenceBrockenArmor * 2;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.FenceBrockenTimeRespawn;
                
            }
            if (typeBuild == TypeBuild.GoldenVoxel)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.GoldenVoxelDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GoldenVoxeHealthlLvl2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelTimeRespawnLvL2;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelTimeRespawnLvL3;
                MaxCapacityGoldenVoxel = DefaultConstCharacterHaractiristicks.GoldenVoxelCapacityLvL2;
                if(!BattleBuild)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney += MaxCapacityGoldenVoxel;
            }
            if (typeBuild == TypeBuild.Mine)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.MineDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.MineHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.MineArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL2;
                CurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.TimeDropGoldLvL2;
                MaxCurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.MaxTimeDropGold;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Casern)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 30; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.CasernDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.CasernHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.CasernArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.CasernTimeRespawnLvL2;
                CurrentTimeTraningArmyBuild = ConstTimeDoubleCharacterRistick.TimeTraningArmyLvL2;
                MaxCurrentTimeTraningArmyBuild = ConstTimeDoubleCharacterRistick.MaxTimeTraningArmy;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.CasernTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Turret)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 30; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TurretDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TurretHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TurretArmorLvL2;
                CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.TurretTimeRespawnLvL2;
                CurrentTimeTurretReloadBuild = ConstTimeDoubleCharacterRistick.TimeTurretTimeReloadLvL2;
                CurrentDamageTurrentBuild = ConstTimeDoubleCharacterRistick.DamageTurretLvL2;
                MaxCurrentTimeTurretReloadBuild = ConstTimeDoubleCharacterRistick.MaxTimeTurretReload;
                MaxCurrentDamageTurretBuild = ConstTimeDoubleCharacterRistick.MaxDamagerTurret;
                MaxTimeRespawnBuild = DefaultConstCharacterHaractiristicks.TurretTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.HatchThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 1; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.HatchThonsDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.HatchThonsHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.HatchThonsArmorLvL2;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL3;
                CurrentTimeReloadHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL2;
                CurrentDamageHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL2;
                MaxCurrentDamageHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL2;
            }
            if (typeBuild == TypeBuild.Thons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 1; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.ThonsDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.ThonsHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.ThonsArmorLvL2;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL3;
                CurrentTimeReloadThonsBuild = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL2;
                CurrentDamageThonsBuild = ConstTimeDoubleCharacterRistick.ThonsDamageLvL2;
                MaxCurrentDamageThons = ConstTimeDoubleCharacterRistick.ThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL2;
            }
            if (typeBuild == TypeBuild.TreeThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 15; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TreeThonsDiamondSpeedLvL2;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TreeThonsHealthLvL2;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TreeThonsArmorLvL2;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL3;
                CurrentTimeReloadTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL2;
                CurrentDamageTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL2;
                MaxCurrentDamageTurretBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL2;
            }
        }
        else if(BuildCurrentLevel == 3)
        {
            if (typeBuild == TypeBuild.Guidhall)
            {
                if (typeTime == 1) { days = 2; hours = 1; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.GuildhallDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GuildhallHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GuildhallArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GuildhallTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Burn)
            {
                if (typeTime == 1) { days = 0; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BarnMoneyDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BarnHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BarnArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BarnTimeRespawnLvL3;
                MaxCurrentTimeFoodBuild = CurrentTimeFoodBuild = ConstTimeDoubleCharacterRistick.MaxTimeArbeitFoodInMinut;
                MaxCapacityBarn = DefaultConstCharacterHaractiristicks.BarnMaxCapacityLvL3;
                if(!BattleBuild)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountFood += MaxCapacityBarn;
            }
            if (typeBuild == TypeBuild.BuilderHome)
            {
                if (typeTime == 1) { days = 5; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.BuilderHomeMoneyLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.BuilderHomeHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.BuilderHomeArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.BuilderHomeTimeRespawnLvL3;
                MaxCurrentTimeBUilderHomeBuild = CurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.MaxTimeBuilderProp;
            }
            if (typeBuild == TypeBuild.Fence)
            {
                if (typeTime == 1) { days = 0; hours = 5; mins = 0; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.FenceBrockenDiamondLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.FenceBrockenHealthLvL * 3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.FenceBrockenArmor * 3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.FenceBrockenTimeRespawn;

            }
            if (typeBuild == TypeBuild.GoldenVoxel)
            {
                if (typeTime == 1) { days = 0; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.GoldenVoxelDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.GoldenVoxeHealthlLvl3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.GoldenVoxelTimeRespawnLvL3;
                MaxCapacityGoldenVoxel = DefaultConstCharacterHaractiristicks.GoldenVoxelCapacityLvL3;
                if (!BattleBuild)
                    GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney += MaxCapacityGoldenVoxel;
            }
            if (typeBuild == TypeBuild.Mine)
            {
                if (typeTime == 1) { days = 0; hours = 5; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.MineDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.MineHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.MineArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.MineTimeRespawnLvL3;
                MaxCurrentTimeGoldBuild = CurrentTimeGoldBuild = ConstTimeDoubleCharacterRistick.MaxTimeDropGold;
            }
            if (typeBuild == TypeBuild.Casern)
            {
                if (typeTime == 1) { days = 0; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.CasernDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.CasernHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.CasernArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.CasernTimeRespawnLvL3;
                MaxCurrentTimeTraningArmyBuild =  CurrentTimeTraningArmyBuild = ConstTimeDoubleCharacterRistick.MaxTimeTraningArmy;
            }
            if (typeBuild == TypeBuild.Turret)
            {
                if (typeTime == 1) { days = 0; hours = 23; mins = 59; seconds = 59; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TurretDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TurretHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TurretArmorLvL3;
                MaxTimeRespawnBuild = CurrentTimeRespawnBuild = DefaultConstCharacterHaractiristicks.TurretTimeRespawnLvL3;
                MaxCurrentTimeTurretReloadBuild = CurrentTimeTurretReloadBuild = ConstTimeDoubleCharacterRistick.MaxTimeTurretReload;
                MaxCurrentDamageTurretBuild = CurrentDamageTurrentBuild = ConstTimeDoubleCharacterRistick.MaxDamagerTurret;

            }
            if (typeBuild == TypeBuild.HatchThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.HatchThonsDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.HatchThonsHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.HatchThonsArmorLvL3;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL3;
                CurrentTimeReloadHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsTimeReloadLvL3;
                CurrentDamageHatchThonsBuild = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL3;
                MaxCurrentDamageHatchThons = ConstTimeDoubleCharacterRistick.HatchThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.HatchThonsTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.Thons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 5; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.ThonsDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.ThonsHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.ThonsArmorLvL3;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL3;
                CurrentTimeReloadThonsBuild = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.ThonsTimeReloadLvL3;
                CurrentDamageThonsBuild = ConstTimeDoubleCharacterRistick.ThonsDamageLvL3;
                MaxCurrentDamageThons = ConstTimeDoubleCharacterRistick.ThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.ThonsTimeRespawnLvL3;
            }
            if (typeBuild == TypeBuild.TreeThons)
            {
                if (typeTime == 1) { days = 0; hours = 0; mins = 15; seconds = 0; }
                else { days = 0; hours = 0; mins = 0; seconds = 0; }
                CurrentDiamondForSpeeding = DefaultConstCharacterHaractiristicks.TreeThonsDiamondSpeedLvL3;
                CurrentHealthBuild = MaxHealthBuild = DefaultConstCharacterHaractiristicks.TreeThonsHealthLvL3;
                CurrentArmorBuild = MaxArmorBuild = DefaultConstCharacterHaractiristicks.TreeThonsArmorLvL3;
                CurrentTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL3;
                CurrentTimeReloadTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL3;
                MaxTimeReloadHatchThons = ConstTimeDoubleCharacterRistick.TreeThonsTimeReloadLvL3;
                CurrentDamageTreeThonsBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL3;
                MaxCurrentDamageTurretBuild = ConstTimeDoubleCharacterRistick.TreeThonsDamageLvL3;
                MaxTimeRespawnBuild = ConstTimeDoubleCharacterRistick.TreeThonsTimeRespawnLvL3;
            }
        }
        // Вызываем метод смены максимального значения Scrollbar у текущего сторения для корректного отображения его заполнения.
        ScrollbarMaxValueChanged(0); 
    }
    /// <summary>
    /// Метод, занимающийся мгновенной сменой уровня текущего строения.
    /// </summary>
    /// <param name="LvL">На вход подаётся уровень строения на который требуется сменить строение.</param>
    public void LvLChanged(int LvL)
    {
        СurrentLevel = LvL;
        typeTimer = typeTimeNull;
        CreateBuild(true);
    }
    /// <summary>
    /// Метод занимающийся изменением переменной MaxValue у ScrollBar текущего строения.
    /// </summary>
    /// <param name="i">На вход подётся переключатель для отображения времени 0 - строительство 1 - тренировка войск прачников 2 - тренировка войск копейщиков 3 - тренировка войск дубинщиков.</param>
    public void ScrollbarMaxValueChanged(int i)
    {
        const int ScrollBarTimeBuild = 3; // Задаём константу объекта ScrollBarTimeBuild для нахождения ScrollBar непосредненно самого MaxValue из ScrollBar.
        float maxValueBuildingInSeconds = 0.0f;
        if (i == 0)
            //Высчитываем максимальное значение времени постройки в секундах.
            maxValueBuildingInSeconds = (days * OneDayInSeconds) + (hours * OneHourInSeconds) + (mins * OneMinutInSecods) + seconds;
        else if(i == 1)
            maxValueBuildingInSeconds = ConstArmyBuys.TimerRespawnStonenschik;
        else if(i == 2)
            maxValueBuildingInSeconds = ConstArmyBuys.TimerRespawnKopeischik;
        else if(i == 3)
            maxValueBuildingInSeconds = ConstArmyBuys.TimerRespawnDybinschik;
        //Присваиваем ScrollBar максимальное значения для кооректного его заполнения.
        gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ScrollBarTimeBuild).GetComponent<Slider>().maxValue = maxValueBuildingInSeconds;
    }
    /// <summary>
    /// Метод изменяющий модель текущего здания при переходе на другой уровень или при откладке.
    /// </summary>
    /// <param name="BuildСurrentLevel">На вход подаётся текущий или новый изменённый повышенный уровень здания.</param>
    void ModelChanged(int BuildСurrentLevel)
    {
        if(typeBuild != TypeBuild.GoldenVoxel) // Если текущая модель не является GoldenVoxel, то
        {
            if (BuildСurrentLevel != 0 && BuildСurrentLevel < 4) // Если уровень модели текущего строения , не равен и не больше четырёх(т.к моделей более нет)
            {
                if (typeBuild != TypeBuild.Fence && typeBuild != TypeBuild.Mine && typeBuild != TypeBuild.Fire && typeBuild != TypeBuild.GoldenVoxel && typeBuild != TypeBuild.HatchThons && typeBuild != TypeBuild.Thons && typeBuild != TypeBuild.TreeThons)
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[BuildСurrentLevel - 1]; // Изменяем модель на модель след. уровня.
                else
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[modelBuildIsNull];
            }
            //Cчитываем размеры, нового текущего строения
            Bounds bounds = gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh.bounds;
            GetComponent<BoxCollider>().size = bounds.size;
            GetComponent<BoxCollider>().center = new Vector3(0, 0.75f, 0);
            if (GetComponent<NavMeshObstacle>())
            {
                GetComponent<NavMeshObstacle>().size = GetComponent<BoxCollider>().size;
                GetComponent<NavMeshObstacle>().center = GetComponent<BoxCollider>().center;
            }
            gameObject.transform.Find(NameBedding).transform.localScale = new Vector3(GetComponent<BoxCollider>().size.x / 10, GetComponent<BoxCollider>().size.y, GetComponent<BoxCollider>().size.z / 10);
            PreviousLevelDebug = BuildСurrentLevel;
        }
        else if(typeBuild == TypeBuild.GoldenVoxel && !BattleBuild)  //Иначе если это модель GoldenVoxel,то
        {
            float maxMoney = GameObject.Find(NameGameController).GetComponent<ResourcesController>().maxCountMoney; // Считаем текущее количество денег у игрока.
            float partMoney = maxMoney / GoldenVoxelModelsCount; // Делим количество денег на контастнту GoldenVoxelModelsCount - это константа определеяет количество моделей GoldenVoxel в нашем репертуаре.
            float multiOne = partMoney * 1; // Low - модель GoldenVoxel;
            float multiTwo = partMoney * 2; // Medium - модель GoldenVoxel;
            float multiFull = partMoney * 4; // Full - модель GoldenVoxel;
            if(typeTimer == typeTimeOne && !BattleBuild)
            {
                if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney <= 0)// Если текущее количество денег равно 0 ,то
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[0]; // тогда устанавливаем модель GoldenVoxel - Null
                if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney > multiOne && GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney < multiTwo && GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney < multiFull) //Иначе если текущее количество денег больше или равно multiOne,то
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[1]; // тогда устанавливаем модель GoldenVoxel - Low
                if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney > multiTwo && GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney < multiFull) //Иначе если текущее количество денег больше или равно multiTwo,то
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[2]; // тогда устанавливаем модель GoldenVoxel - Medium
                if (GameObject.Find(NameGameController).GetComponent<ResourcesController>().CurrentCountMoney >= multiFull) //Иначе если текущее количество денег больше или равно multiFull,то
                    gameObject.transform.Find(NameModel).GetComponent<MeshFilter>().mesh = modelsBuild[3]; // тогда устанавливаем модель GoldenVoxel - Full
            }
           
        }
        

    }
    /// <summary>
    /// Метод занимающийся работой с UI и кнопками текущего строения.
    /// </summary>
    public void ArbeitButtonsAndUIPanelCurrentBuild()
    {
        //Отключаем или включаем панель управления текущим сторением(Уровень название повороты строительство) Если выбрано вкл иначе выкл.
        if(typeTimer == typeTimeOne && !BattleBuild)
        {
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform != null) // Если выбрано, хоть какое-либо строение,то
            {
                ButtonsOnOff(); // Вызываем вспомогательный метод определния кнопок внизу экрана.

                //Включаем панель управления на текущем выбранном строении.
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenNameUIText).gameObject.SetActive(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == gameObject.transform);
                if (ButtonsObject != TypeButtonsForObjects.Obstalces && tempTypeButtonsForObjects != TypeButtonsForObjects.Obstalces)
                {
                    gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenLvLUIText).gameObject.SetActive(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == gameObject.transform);
                    //Включаем или выключаем панель строительства если вы в режиме отладки или постройка куплена в магаизне и мы не начали строительство,то true иначе false.
                    gameObject.transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).gameObject.SetActive(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform == gameObject.transform && (TEST_CheckBuildDebug || shop) && !BuildingSuccess && !Buidling);
                }

            }
            else
            {
                //Отключаем UI на текущем строении.
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenNameUIText).gameObject.SetActive(false);
                gameObject.transform.Find(NameModel).Find(UICanvas).GetChild(ChildenLvLUIText).gameObject.SetActive(false);
                gameObject.transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).gameObject.SetActive(false);
                //Отключаем все кнопки внизу экрана, так как ничего не выбрано.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false);
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false);
            }
        }
    }
       
    /// <summary>
    /// Метод занимающийся включение и отключением кнопок внизу экрана в зависимости от типа строения.
    /// </summary>
    void ButtonsOnOff()
    {
        if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().BuildingSuccess) // Если текущее выбранное строение построенно,то
        {
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Obstalces)// Если текущее выбранное строение является препятствием,то
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(false); // Отключаем кнопку информация
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(false); // Отключаем кнопку улучшения
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Отключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(true); // Включаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
            }
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Casern)// Если текущее выбранное строение является казармой,то
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(true); // Включаем кнопку информация
                if(СurrentLevel < 3)
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = true; // Включаем возможость улучшать строение.
                }
                else
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = false; // Отключаем возможость улучшать строение.
                }
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Выключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(true); // Включаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.GetComponent<Button>().interactable = (FireObject != null); // Активируем кнопку тренировать войска в случае если точка сбора выбрана.
                if(!isReductionInConteriersArmys)
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.transform.GetChild(IndexSpawnBuilderPoint).GetChild(ButtonInformation).GetComponent<Text>().text = DefaultConstCharacterHaractiristicks.CasernSpeedingTraninngArmy.ToString();
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(true); // Включаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.GetComponent<Button>().interactable = (FireObject != null && !isReductionInConteriersArmys); // Активируем кнопку  кнопку быстро тренировать войска в случае если точка сбора выбрана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(true); // Включаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
            }
            if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Default) // Если текущее выбранное строение является обычным,то
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(true); // Включаем кнопку информация
                if (СurrentLevel < 3)
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = true; // Включаем  возможость улучшать строение.
                }
                else
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = false; // Отключаем возможость улучшать строение.
                }
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Выключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
            }
            if(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Barn) // Если текущее выбранное строение является амбаром,то
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(true); // Включаем кнопку информация
                if (СurrentLevel < 3)
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = true; // Включаем  возможость улучшать строение.
                }
                else
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = false; // Отключаем возможость улучшать строение.
                }
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Выключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(true); // Включаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
            }
            if(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Mine)// Если текущее выбранное строение является шахтой,то
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(true); // Включаем кнопку информация
                if (СurrentLevel < 3)
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = true; // Включаем возможость улучшать строение.
                }
                else
                {
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(true); // Включаем кнопку улучшения
                    GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.GetComponent<Button>().interactable = false; // Отключаем возможость улучшать строение.
                }
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Выключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Включаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(true); // Отключаем кнопку сбора золота с шахты.
            }
            if(GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Information)
            {
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(true); // Включаем кнопку информация
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(false); // Отключаем кнопку улучшения
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Отключаем кнопку ускорения процесса строения.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
                GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
            }
        }
        else if (GameObject.Find(NameGameController).GetComponent<BuildSelectedController>().selectedPickableTransform.GetComponent<BuildParamentrs>().Buidling)
        {
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(false); // Отключаем кнопку информация
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(false); // Отключаем кнопку улучшения
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(true); // включаем кнопку ускорения процесса строения.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
        }
        else 
        {
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonInformation).gameObject.SetActive(false); // Отключаем кнопку информация
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonUpgrade).gameObject.SetActive(false); // Отключаем кнопку улучшения
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingBuild).gameObject.SetActive(false); // Отключаем кнопку ускорения процесса строения.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonTraningArmy).gameObject.SetActive(false); // Отключаем кнопку тренировать войска.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSpeedingTraningArmy).gameObject.SetActive(false); // Отключаем кнопку быстро тренировать войска.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonSelectSpawnPointArmy).gameObject.SetActive(false); // Отключаем кнопку выбора костра для спавна войск.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonCreateClan).gameObject.SetActive(false); // Отключаем кнопку создания клана.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonDeleteObstacle).gameObject.SetActive(false); // Отключаем кнопку уничтожения препятствия.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpFood).gameObject.SetActive(false); // Отключаем кнопку сбора еды с амбара.
            GameObject.Find(UICanvasInScreen).transform.Find(UIButtonsForObjects).transform.GetChild(ButtonPickUpGold).gameObject.SetActive(false); // Отключаем кнопку сбора золота с шахты.
        }   
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == NameTagStonenschik || other.tag == NameTagKopeischik || other.tag == NameTagDybinschik)
        {
            if (other.GetComponent<AI>().isAgry)
            {
                if (typeBuild == TypeBuild.HatchThons)
                {
                    if (CurrentTimeReloadHatchThonsBuild > 0)
                        CurrentTimeReloadHatchThonsBuild -= Time.deltaTime;
                    else
                    {
                        other.GetComponent<AI>().DamageUnit(CurrentDamageHatchThonsBuild);
                        CurrentTimeReloadHatchThonsBuild = MaxTimeReloadHatchThons;
                        CreateAudioClipDamageBuild(1);
                    }
                }
                else if (typeBuild == TypeBuild.Thons)
                {
                    if(CurrentTimeReloadThonsBuild > 0)
                        CurrentTimeReloadThonsBuild -= Time.deltaTime;
                    else
                    {
                        other.GetComponent<AI>().DamageUnit(CurrentDamageThonsBuild);
                        CurrentTimeReloadThonsBuild = MaxTimeReloadThons;
                        CreateAudioClipDamageBuild(1);
                    }
                }
                else if (typeBuild == TypeBuild.TreeThons)
                {
                    if (CurrentTimeReloadTreeThonsBuild > 0)
                        CurrentTimeReloadTreeThonsBuild -= Time.deltaTime;
                    else
                    {
                        other.GetComponent<AI>().DamageUnit(CurrentDamageTreeThonsBuild);
                        CurrentTimeReloadTreeThonsBuild = MaxTimeReloadTreeThons;
                        CreateAudioClipDamageBuild(1);
                    }
                    
                }
                else if (typeBuild == TypeBuild.Turret)
                {
                    if (CurrentTimeTurretReloadBuild > 0)
                        CurrentTimeTurretReloadBuild -= Time.deltaTime;
                    else
                    {
                        GameObject kopo = Instantiate(Resources.Load<GameObject>(NameOnlineObjectDropsKopo));
                        kopo.transform.position = PointSpawnTurrentObject.position;
                        kopo.GetComponent<ForceObjects>().isEnemy = true;
                        kopo.GetComponent<ForceObjects>().Damage = CurrentDamageTurrentBuild;
                        kopo.GetComponent<ForceObjects>().Target = other.transform;
                        other.GetComponent<AI>().DamageUnit(CurrentDamageTurrentBuild);
                        CurrentTimeTurretReloadBuild = MaxCurrentTimeTurretReloadBuild;
                        CreateAudioClipDamageBuild(1);
                    }
                    
                }
            }
        }
        if (other.gameObject.GetComponent<BuildParamentrs>() != null) // Если был найден коллайдер,то
        if (other.gameObject.GetComponent<BuildParamentrs>().ButtonsObject == TypeButtonsForObjects.Obstalces && ButtonsObject == TypeButtonsForObjects.Obstalces) // Если препятствие, пересекается с другим препятствием,то
            Destroy(Parent); // Удаляем одно из препятствий.
        if (other.tag != NameTagStonenschik && other.tag != NameTagKopeischik && other.tag != NameTagDybinschik && other.tag != TagBotRegister && other.tag != TagFence && !BattleBuild && other.tag != TagBotNotRegister)
        {
            otherSettings = other.gameObject;
            //Вызываем метод занимающийся отключением и включением кнопки принятия строительства текущего строения.
            PermissionBuild(false);
        }
            
    }
    public void OnTriggerExit(Collider other)
    {
            //Вызываем метод занимающийся отключением и включением кнопки принятия строительства текущего строения.
            PermissionBuild(true);
    }
    /// <summary>
    /// Метод занимающийся отключением или включением кнопки принятия строительства текущего сторения, а так же окрашивающий Bedding в красный цвет в случае ,если строительство запрешено.
    /// </summary>
    /// <param name="permission">На вход подаётся разрешение о строительстве текущего строения.</param>
    public void PermissionBuild(bool permission)
    {
        this.Permission = permission;
        gameObject.transform.Find(NameModel).Find(UICanvas).Find(UIPanelUseBuild).Find(UISuccessInstallButton).GetComponent<Button>().interactable = permission;
        if(typeBuild != TypeBuild.Fence)
        {
            if (!permission)
                foreach (var itemRenderer in gameObject.transform.Find(NameBedding).GetComponentsInChildren<Renderer>())
                    itemRenderer.material.color = Color.red;
            else
                foreach (var itemRenderer in gameObject.transform.Find(NameBedding).GetComponentsInChildren<Renderer>())
                    itemRenderer.material.color = Color.green;
        }
        else
        {
            if (!permission)
                foreach (var itemRenderer in gameObject.transform.Find(NameModel).GetComponentsInChildren<Renderer>())
                    itemRenderer.material.color = Color.red;
            else
                foreach (var itemRenderer in gameObject.transform.Find(NameModel).GetComponentsInChildren<Renderer>())
                    itemRenderer.material.color = Color.white;
        }
        
    }


}


