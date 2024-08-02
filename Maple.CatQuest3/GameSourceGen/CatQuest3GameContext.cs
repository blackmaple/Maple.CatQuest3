using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;

namespace Maple.CatQuest3.GameSourceGen
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
    internal partial class CatQuest3GameContext
    {
        //public CatQuest3GameContext(MonoRuntimeContext monoRuntimeContext, ILogger logger) : base(monoRuntimeContext, EnumMonoCollectorTypeVersion.APP, logger, "20")
        //{
        //}
    }
}
