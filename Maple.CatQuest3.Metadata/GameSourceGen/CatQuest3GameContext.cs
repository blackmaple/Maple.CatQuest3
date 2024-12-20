﻿using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;

namespace Maple.CatQuest3.Metadata.GameSourceGen
{

    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]


    [MonoCollectorType(typeof(Contexts))]
    [MonoCollectorType(typeof(GameContext))]
    [MonoCollectorType(typeof(GameStateContext))]
    [MonoCollectorType(typeof(GameMatcher))]

    [MonoCollectorType(typeof(GUIContext))]
    [MonoCollectorType(typeof(MessagePanelComponent))]
    [MonoCollectorType(typeof(MessagePanel))]
    [MonoCollectorType(typeof(MessageUIInfo))]
    [MonoCollectorType(typeof(Line))]

    [MonoCollectorType(typeof(GUIEntity))]
    [MonoCollectorType(typeof(UIPanelDisplayStatusComponent))]

    [MonoCollectorType(typeof(GameEntity))]
    [MonoCollectorType(typeof(CombatAgentComponent))]
    [MonoCollectorType(typeof(CombatAgent))]
    [MonoCollectorType(typeof(AnimatorComponent))]
    [MonoCollectorType(typeof(Animator))]
    [MonoCollectorType(typeof(AnimatorHash))]



    [MonoCollectorType(typeof(GoldComponent))]
    [MonoCollectorType(typeof(ExperienceComponent))]
    [MonoCollectorType(typeof(CrystalComponent))]
    [MonoCollectorType(typeof(ValueGauge))]
    [MonoCollectorType(typeof(LevelValueGauge))]

    [MonoCollectorType(typeof(ShipBlueprintDatabase))]
    [MonoCollectorType(typeof(ShipBlueprintItemData))]
    [MonoCollectorType(typeof(UnlockedShipBlueprintsComponent))]
    [MonoCollectorType(typeof(ShipBlueprintCollection))]
    [MonoCollectorType(typeof(ShipBlueprint))]


    [MonoCollectorType(typeof(SpellConfigDatabase))]
    [MonoCollectorType(typeof(SpellConfigBase))]

    [MonoCollectorType(typeof(SpellConfig))]
    [MonoCollectorType(typeof(SpellLevelConfig))]

    [MonoCollectorType(typeof(ShipSpellConfig))]
    [MonoCollectorType(typeof(ShipCannonAttackConfig))]


    [MonoCollectorType(typeof(UnlockedShipSpellTableComponent))]
    [MonoCollectorType(typeof(ShipSpellCollection))]
    [MonoCollectorType(typeof(ShipSpell))]

    [MonoCollectorType(typeof(UnlockedSpellTableComponent))]
    [MonoCollectorType(typeof(SpellCollection))]
    [MonoCollectorType(typeof(Spell))]


    [MonoCollectorType(typeof(EquipmentDatabase))]
    [MonoCollectorType(typeof(EquipmentItemData))]
    [MonoCollectorType(typeof(UnlockedEquipmentListComponent))]
    [MonoCollectorType(typeof(Equipment))]





    [MonoCollectorType(typeof(GameContextExtensions))]
    [MonoCollectorType(typeof(LocalizationTools))]


    [MonoCollectorType(typeof(ContextsExtensions))]
    [MonoCollectorType(typeof(ControllerManager))]

    [MonoCollectorType(typeof(InputContext))]
    [MonoCollectorType(typeof(InputContextExtensions))]

    [MonoCollectorType(typeof(RestTriggeredEventHandler))]

    [MonoCollectorType(typeof(GameplayHelper))]
    [MonoCollectorType(typeof(GunReloadHandler))]

    [MonoCollectorType(typeof(TransformComponent))]
    [MonoCollectorType(typeof(Transform))]
    [MonoCollectorType(typeof(CombatTextDatabase))]

    [MonoCollectorType(typeof(FrameworkContext))]

    [MonoCollectorType(typeof(WorldContext))]
    [MonoCollectorType(typeof(WorldEntity))]
    [MonoCollectorType(typeof(CurrentZoneComponent))]

    //image
    [MonoCollectorType(typeof(SkinInfoData))]
    [MonoCollectorType(typeof(ExpSkinInfo))]
    [MonoCollectorType(typeof(GoldSkinInfo))]
    [MonoCollectorType(typeof(MagicCrystalSkinInfo))]

    [MonoCollectorType(typeof(MapIconDisplayLinkComponent))]
    [MonoCollectorType(typeof(ChestComponent))]
    [MonoCollectorType(typeof(ChestBehaviour))]
    [MonoCollectorType(typeof(GUIMatcher))]
    [MonoCollectorType(typeof(MapIconComponent))]



    public partial class CatQuest3GameContext
    {
        //public CatQuest3GameContext(MonoRuntimeContext monoRuntimeContext, ILogger logger) : base(monoRuntimeContext, EnumMonoCollectorTypeVersion.APP, logger, "20")
        //{
        //}
    }
}
