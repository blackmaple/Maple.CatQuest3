
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.RawDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// static class ["ProjectStar".""."GameContextExtensions"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020003B5U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115])]


    public partial class GameContextExtensions
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameContextExtensions";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115];

        //public const uint Const_TypeToken = 0x020003B5U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameContextExtensions(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameContextExtensions(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameContextExtensions obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameContextExtensions obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GameContextExtensions"]
    /// </summary>
    public partial class GameContextExtensions
    {



        /// <summary>
        /// static  System.Void AddScreenEffectPlayerParamCompletionCallback(GameEntity targetEntity, System.Action callback, System.Single param)
        /// </summary>
        /// <param name="targetEntity">class GameEntity</param>
        /// <param name="callback">class System.Action</param>
        /// <param name="param">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddScreenEffectPlayerParamCompletionCallback")]
        /// static extern void ADD_SCREEN_EFFECT_PLAYER_PARAM_COMPLETION_CALLBACK (nint targetEntity, nint callback, System.Single param);


        /// <summary>
        /// static  GameEntity CreateAddEquipmentCommand(GameContext context, ProjectStar.Data.EquipmentItemData data, System.Int32 level, System.Int32& prevLevel, System.Int32& newLevel)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="data">class ProjectStar.Data.EquipmentItemData</param>
        /// <param name="level">struct System.Int32</param>
        /// <param name="prevLevel">struct System.Int32&</param>
        /// <param name="newLevel">struct System.Int32&</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateAddEquipmentCommand", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint CREATE_ADD_EQUIPMENT_COMMAND(GameContext.Ptr_GameContext context, nint data, System.Int32 level, out System.Int32 prevLevel, out System.Int32 newLevel);


        /// <summary>
        /// static  GameEntity CreateAddNewShipSpellCommand(GameContext context, ShipSpellConfig data, SpellLevelConfigBase& newSpellConfig, System.Int32& prevLevel, System.Int32& newLevel, System.Boolean& success)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="data">class ShipSpellConfig</param>
        /// <param name="newSpellConfig">abstract class SpellLevelConfigBase&</param>
        /// <param name="prevLevel">struct System.Int32&</param>
        /// <param name="newLevel">struct System.Int32&</param>
        /// <param name="success">struct System.Boolean&</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateAddNewShipSpellCommand", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint CREATE_ADD_NEW_SHIP_SPELL_COMMAND(GameContext.Ptr_GameContext context, nint data, out nint newSpellConfig, out System.Int32 prevLevel, out System.Int32 newLevel, out System.Boolean success);


        /// <summary>
        /// static  GameEntity CreateAddNewSpellCommand(GameContext context, SpellConfig data, SpellLevelConfigBase& newSpellConfig, System.Boolean& success)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="data">class SpellConfig</param>
        /// <param name="newSpellConfig">abstract class SpellLevelConfigBase&</param>
        /// <param name="success">struct System.Boolean&</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateAddNewSpellCommand", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint CREATE_ADD_NEW_SPELL_COMMAND(GameContext.Ptr_GameContext context, nint data, out nint newSpellConfig, out System.Boolean success);


        /// <summary>
        /// static  GameEntity CreateAddOrLevelUpSpellCommand(GameContext context, SpellConfigBase data, System.Int32& prevLevel, System.Int32& newLevel, SpellLevelConfigBase& newSpellConfig, System.Boolean& success)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="data">abstract class SpellConfigBase</param>
        /// <param name="prevLevel">struct System.Int32&</param>
        /// <param name="newLevel">struct System.Int32&</param>
        /// <param name="newSpellConfig">abstract class SpellLevelConfigBase&</param>
        /// <param name="success">struct System.Boolean&</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateAddOrLevelUpSpellCommand")]
        /// static extern nint CREATE_ADD_OR_LEVEL_UP_SPELL_COMMAND (nint context, nint data, System.Int32& prevLevel, System.Int32& newLevel, nint newSpellConfig, System.Boolean& success);


        /// <summary>
        /// static  GameEntity CreateAddShipBlueprintCommand(GameContext context, ShipBlueprintItemData data, System.Boolean& success)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="data">class ShipBlueprintItemData</param>
        /// <param name="success">struct System.Boolean&</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateAddShipBlueprintCommand", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint CREATE_ADD_SHIP_BLUEPRINT_COMMAND(GameContext.Ptr_GameContext context, nint data, out System.Boolean success);


        /// <summary>
        /// static  GameEntity CreateCollectibleCollectedEvent(GameContext context, UnityEngine.Transform target, System.Int32 value, DamageTextAnimation textData)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="target">class UnityEngine.Transform</param>
        /// <param name="value">struct System.Int32</param>
        /// <param name="textData">class DamageTextAnimation</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateCollectibleCollectedEvent")]
        /// static extern nint CREATE_COLLECTIBLE_COLLECTED_EVENT (nint context, nint target, System.Int32 value, nint textData);


        /// <summary>
        /// static  GameEntity CreateGameOverEvent(GameContext context)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateGameOverEvent")]
        /// static extern nint CREATE_GAME_OVER_EVENT (nint context);


        /// <summary>
        /// static  GameEntity CreateHitStopEvent(GameContext context, UnityEngine.GameObject obj, System.Single duration, UnityEngine.Animation anim)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="obj">class UnityEngine.GameObject</param>
        /// <param name="duration">struct System.Single</param>
        /// <param name="anim">class UnityEngine.Animation</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateHitStopEvent")]
        /// static extern nint CREATE_HIT_STOP_EVENT (nint context, nint obj, System.Single duration, nint anim);


        /// <summary>
        /// static  GameEntity CreateInputStateCommand(GameContext context, InputStateCommand command, System.Nullable<InputState> state)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="command">enum InputStateCommand</param>
        /// <param name="state">struct System.Nullable<InputState></param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInputStateCommand")]
        /// static extern nint CREATE_INPUT_STATE_COMMAND (nint context, InputStateCommand command, System.Nullable<InputState> state);


        /// <summary>
        /// static  GameEntity CreatePromptAddPlayerEvent(GameContext context)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreatePromptAddPlayerEvent")]
        /// static extern nint CREATE_PROMPT_ADD_PLAYER_EVENT (nint context);


        /// <summary>
        /// static  GameEntity CreatePromptRemovePlayerEvent(GameContext context, System.Int32 initiatorPlayerID)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="initiatorPlayerID">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreatePromptRemovePlayerEvent")]
        /// static extern nint CREATE_PROMPT_REMOVE_PLAYER_EVENT (nint context, System.Int32 initiatorPlayerID);


        /// <summary>
        /// static  GameEntity CreateReviveEvent(GameContext context, GameEntity reviveTarget)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="reviveTarget">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateReviveEvent")]
        /// static extern nint CREATE_REVIVE_EVENT (nint context, nint reviveTarget);


        /// <summary>
        /// static  GameEntity CreateScreenEffectEntity(GameContext context, System.String effectName, System.Action callback)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="effectName">class System.String</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateScreenEffectEntity")]
        /// static extern nint CREATE_SCREEN_EFFECT_ENTITY (nint context, nint effectName, nint callback);


        /// <summary>
        /// static  GameEntity CreateShipEnterEvent(GameContext context, GameEntity player, GameEntity ship)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="player">class GameEntity</param>
        /// <param name="ship">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateShipEnterEvent")]
        /// static extern nint CREATE_SHIP_ENTER_EVENT (nint context, nint player, nint ship);


        /// <summary>
        /// static  System.Void CreateShipEnterInteriorEvent(GameContext context, GameEntity player, PlayerShipBehaviour shipBehaviour)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="player">class GameEntity</param>
        /// <param name="shipBehaviour">class PlayerShipBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateShipEnterInteriorEvent")]
        /// static extern void CREATE_SHIP_ENTER_INTERIOR_EVENT (nint context, nint player, nint shipBehaviour);


        /// <summary>
        /// static  GameEntity CreateShipExitEvent(GameContext context, GameEntity player, GameEntity ship)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="player">class GameEntity</param>
        /// <param name="ship">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateShipExitEvent")]
        /// static extern nint CREATE_SHIP_EXIT_EVENT (nint context, nint player, nint ship);


        /// <summary>
        /// static  GameEntity CreateSpawnTextEvent(GameContext context, UnityEngine.Vector3 position, System.String text, CombatTextAnimation animation)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="text">class System.String</param>
        /// <param name="animation">abstract class CombatTextAnimation</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateSpawnTextEvent", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint CREATE_SPAWN_TEXT_EVENT(GameContext.Ptr_GameContext context, REF_MONO_VECTOR3 position, PMonoString text, nint animation);


        /// <summary>
        /// static  GameEntity CreateSpell(GameContext context, CombatAgent sourceAgent, SpellLevelConfig spellLevelConfig, AttackEventInfo attackEventInfo)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="sourceAgent">class CombatAgent</param>
        /// <param name="spellLevelConfig">class SpellLevelConfig</param>
        /// <param name="attackEventInfo">class AttackEventInfo</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateSpell")]
        /// static extern nint CREATE_SPELL (nint context, nint sourceAgent, nint spellLevelConfig, nint attackEventInfo);


        /// <summary>
        /// static  GameEntity CreateVFXFollowParent(GameContext context, UnityEngine.GameObject go, ProjectStar.VFXBehaviour behaviour, VFXSpawnPosition refPoint, GameEntity source, System.Boolean offsetByLocalForward, System.Single localDirectionOffsetDistance)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="go">class UnityEngine.GameObject</param>
        /// <param name="behaviour">class ProjectStar.VFXBehaviour</param>
        /// <param name="refPoint">enum VFXSpawnPosition</param>
        /// <param name="source">class GameEntity</param>
        /// <param name="offsetByLocalForward">struct System.Boolean</param>
        /// <param name="localDirectionOffsetDistance">struct System.Single</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateVFXFollowParent")]
        /// static extern nint CREATE_VFX_FOLLOW_PARENT (nint context, nint go, nint behaviour, VFXSpawnPosition refPoint, nint source, System.Boolean offsetByLocalForward, System.Single localDirectionOffsetDistance);


        /// <summary>
        /// static  Equipment GetEquipment(GameContext context, System.String guid)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="guid">class System.String</param>
        /// <returns>class Equipment</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEquipment")]
        /// static extern nint GET_EQUIPMENT (nint context, nint guid);


        /// <summary>
        /// static  System.Void GetPlayerEquippedStats(GameContext context, System.Int32 playerID, System.Int32& maxHealth, CombatAgent nakedCombatAgent, CombatAgent.CombatStats& stats, System.Boolean clampValues)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <param name="maxHealth">struct System.Int32&</param>
        /// <param name="nakedCombatAgent">class CombatAgent</param>
        /// <param name="stats">class CombatAgent.CombatStats&</param>
        /// <param name="clampValues">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPlayerEquippedStats")]
        /// static extern void GET_PLAYER_EQUIPPED_STATS (nint context, System.Int32 playerID, System.Int32& maxHealth, nint nakedCombatAgent, nint stats, System.Boolean clampValues);


        /// <summary>
        /// static  SpellBase GetPlayerShipSpell(GameContext context, System.String guid)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="guid">class System.String</param>
        /// <returns>abstract class SpellBase</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPlayerShipSpell")]
        /// static extern nint GET_PLAYER_SHIP_SPELL (nint context, nint guid);


        /// <summary>
        /// static  SpellBase GetSpell(GameContext context, System.String guid)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="guid">class System.String</param>
        /// <returns>abstract class SpellBase</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpell")]
        /// static extern nint GET_SPELL (nint context, nint guid);


        /// <summary>
        /// static  System.Boolean IsEnemyAligned(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEnemyAligned")]
        /// static extern System.Boolean IS_ENEMY_ALIGNED (nint entity);


        /// <summary>
        /// static  System.Boolean IsPlayerAligned(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerAligned")]
        /// static extern System.Boolean IS_PLAYER_ALIGNED (nint entity);


        /// <summary>
        /// static  System.Void ModifyGameDifficulty(GameContext context, SaveGameDifficulty difficultyMode)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="difficultyMode">enum SaveGameDifficulty</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ModifyGameDifficulty")]
        /// static extern void MODIFY_GAME_DIFFICULTY (nint context, SaveGameDifficulty difficultyMode);


        /// <summary>
        /// static  GameEntity PopulateAoeEntity(GameContext context, GameEntity aoeEntity, GameEntity sourceEntity, AoeInfo aoeInfo)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="aoeEntity">class GameEntity</param>
        /// <param name="sourceEntity">class GameEntity</param>
        /// <param name="aoeInfo">class AoeInfo</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PopulateAoeEntity")]
        /// static extern nint POPULATE_AOE_ENTITY (nint context, nint aoeEntity, nint sourceEntity, nint aoeInfo);


        /// <summary>
        /// static  GameEntity PopulateProjectileEntity(GameContext context, GameEntity projectileEntity, ProjectileInfo projectileInfo, GameEntity sourceEntity)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="projectileEntity">class GameEntity</param>
        /// <param name="projectileInfo">class ProjectileInfo</param>
        /// <param name="sourceEntity">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PopulateProjectileEntity")]
        /// static extern nint POPULATE_PROJECTILE_ENTITY (nint context, nint projectileEntity, nint projectileInfo, nint sourceEntity);


        /// <summary>
        /// static  System.Void PopulateReviveBeaconEntity(GameContext context, GameEntity reviveBeaconEntity, GameEntity targetEntity)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="reviveBeaconEntity">class GameEntity</param>
        /// <param name="targetEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PopulateReviveBeaconEntity")]
        /// static extern void POPULATE_REVIVE_BEACON_ENTITY (nint context, nint reviveBeaconEntity, nint targetEntity);


        /// <summary>
        /// static  System.Void UpdateMonsterDetected(GameContext context, GameEntity monsterDetector, System.Collections.Generic.IEnumerable<GameEntity> newResults)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="monsterDetector">class GameEntity</param>
        /// <param name="newResults">interface System.Collections.Generic.IEnumerable<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateMonsterDetected")]
        /// static extern void UPDATE_MONSTER_DETECTED (nint context, nint monsterDetector, nint newResults);



        /// <summary>
        /// static  GameEntity CreateCollectibleMagnetEvent(GameContext context, UnityEngine.Transform collectible, UnityEngine.Transform target, CollectibleBase collectibleRef)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="collectible">class UnityEngine.Transform</param>
        /// <param name="target">class UnityEngine.Transform</param>
        /// <param name="collectibleRef">abstract class CollectibleBase</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateCollectibleMagnetEvent", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_COLLECTIBLE_MAGNET_EVENT_00 (nint context, nint collectible, nint target, nint collectibleRef);


        /// <summary>
        /// static  GameEntity CreateCollectibleMagnetEvent(GameContext context, UnityEngine.Transform collectible, UnityEngine.Transform target, CollectibleBase collectibleRef, UnityEngine.Vector3 initialDirection)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="collectible">class UnityEngine.Transform</param>
        /// <param name="target">class UnityEngine.Transform</param>
        /// <param name="collectibleRef">abstract class CollectibleBase</param>
        /// <param name="initialDirection">struct UnityEngine.Vector3</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateCollectibleMagnetEvent", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_COLLECTIBLE_MAGNET_EVENT_01 (nint context, nint collectible, nint target, nint collectibleRef, UnityEngine.Vector3 initialDirection);


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable, System.Int32 lootLevel)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <param name="lootTable">class LootTable</param>
        /// <param name="lootLevel">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateLootDropEvent", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_LOOT_DROP_EVENT_00 (nint context, UnityEngine.Vector3 worldPos, nint lootTable, System.Int32 lootLevel);


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable, System.Int32 quantityMultiplier, System.Int32 valueMultiplier)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <param name="lootTable">class LootTable</param>
        /// <param name="quantityMultiplier">struct System.Int32</param>
        /// <param name="valueMultiplier">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateLootDropEvent", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_LOOT_DROP_EVENT_01 (nint context, UnityEngine.Vector3 worldPos, nint lootTable, System.Int32 quantityMultiplier, System.Int32 valueMultiplier);


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <param name="lootTable">class LootTable</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateLootDropEvent", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_LOOT_DROP_EVENT_02 (nint context, UnityEngine.Vector3 worldPos, nint lootTable);


        /// <summary>
        /// static  GameEntity CreateScreenEffectPlayerEntity(GameContext context, System.String effectPlayerName, System.Action callback)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="effectPlayerName">class System.String</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateScreenEffectPlayerEntity", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_SCREEN_EFFECT_PLAYER_ENTITY_00 (nint context, nint effectPlayerName, nint callback);


        /// <summary>
        /// static  GameEntity CreateScreenEffectPlayerEntity(GameContext context, ScreenEffectPlayer effectPlayer, System.Action callback)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="effectPlayer">class ScreenEffectPlayer</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateScreenEffectPlayerEntity", Search = typeof(Search_GameContextExtensions))]
        /// static extern nint CREATE_SCREEN_EFFECT_PLAYER_ENTITY_01 (nint context, nint effectPlayer, nint callback);


        /// public static partial class Search_GameContextExtensions
        /// {
        /// 
        ///     

        /// <summary>
        /// static  GameEntity CreateCollectibleMagnetEvent(GameContext context, UnityEngine.Transform collectible, UnityEngine.Transform target, CollectibleBase collectibleRef)
        /// </summary>
        /// public static bool CREATE_COLLECTIBLE_MAGNET_EVENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateCollectibleMagnetEvent", "GameContext", "UnityEngine.Transform", "UnityEngine.Transform", "CollectibleBase");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateCollectibleMagnetEvent(GameContext context, UnityEngine.Transform collectible, UnityEngine.Transform target, CollectibleBase collectibleRef, UnityEngine.Vector3 initialDirection)
        /// </summary>
        /// public static bool CREATE_COLLECTIBLE_MAGNET_EVENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateCollectibleMagnetEvent", "GameContext", "UnityEngine.Transform", "UnityEngine.Transform", "CollectibleBase", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable, System.Int32 lootLevel)
        /// </summary>
        /// public static bool CREATE_LOOT_DROP_EVENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateLootDropEvent", "GameContext", "UnityEngine.Vector3", "LootTable", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable, System.Int32 quantityMultiplier, System.Int32 valueMultiplier)
        /// </summary>
        /// public static bool CREATE_LOOT_DROP_EVENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateLootDropEvent", "GameContext", "UnityEngine.Vector3", "LootTable", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateLootDropEvent(GameContext context, UnityEngine.Vector3 worldPos, LootTable lootTable)
        /// </summary>
        /// public static bool CREATE_LOOT_DROP_EVENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateLootDropEvent", "GameContext", "UnityEngine.Vector3", "LootTable");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateScreenEffectPlayerEntity(GameContext context, System.String effectPlayerName, System.Action callback)
        /// </summary>
        /// public static bool CREATE_SCREEN_EFFECT_PLAYER_ENTITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateScreenEffectPlayerEntity", "GameContext", "System.String", "System.Action");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity CreateScreenEffectPlayerEntity(GameContext context, ScreenEffectPlayer effectPlayer, System.Action callback)
        /// </summary>
        /// public static bool CREATE_SCREEN_EFFECT_PLAYER_ENTITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateScreenEffectPlayerEntity", "GameContext", "ScreenEffectPlayer", "System.Action");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}