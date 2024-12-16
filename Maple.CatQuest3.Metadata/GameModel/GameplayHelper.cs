
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// static class ["ProjectStar".""."GameplayHelper"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020003FBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 112, 108, 97, 121, 72, 101, 108, 112, 101, 114])]


    public partial class GameplayHelper
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameplayHelper";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 112, 108, 97, 121, 72, 101, 108, 112, 101, 114];

        //public const uint Const_TypeToken = 0x020003FBU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameplayHelper(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameplayHelper(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameplayHelper obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameplayHelper obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GameplayHelper"]
    /// </summary>
    public partial class GameplayHelper
    {



        /// <summary>
        /// static  System.Void ApplyBuffTintToTarget(GameEntity target, UnityEngine.Color color)
        /// </summary>
        /// <param name="target">class GameEntity</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyBuffTintToTarget")]
        /// static extern void APPLY_BUFF_TINT_TO_TARGET (nint target, UnityEngine.Color color);


        /// <summary>
        /// static  System.Void AwardQuestItem(QuestItem questItem, System.Action callback)
        /// </summary>
        /// <param name="questItem">class QuestItem</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AwardQuestItem")]
        /// static extern void AWARD_QUEST_ITEM (nint questItem, nint callback);


        /// <summary>
        /// static  System.Void CalculateNewDepth()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CalculateNewDepth")]
        /// static extern void CALCULATE_NEW_DEPTH ();


        /// <summary>
        /// static  ElementalType ConvertFromUnitConfig(Elemental configType)
        /// </summary>
        /// <param name="configType">enum Elemental</param>
        /// <returns>enum ElementalType</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConvertFromUnitConfig")]
        /// static extern ElementalType CONVERT_FROM_UNIT_CONFIG (Elemental configType);


        /// <summary>
        /// static  System.Void CullingFadeIn(UnityEngine.GameObject owner, System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single> table, System.Single duration, System.Action callback)
        /// </summary>
        /// <param name="owner">class UnityEngine.GameObject</param>
        /// <param name="table">class System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single></param>
        /// <param name="duration">struct System.Single</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CullingFadeIn")]
        /// static extern void CULLING_FADE_IN (nint owner, nint table, System.Single duration, nint callback);


        /// <summary>
        /// static  System.Void CullingFadeOut(UnityEngine.GameObject owner, System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single> table, System.Single duration, System.Action callback)
        /// </summary>
        /// <param name="owner">class UnityEngine.GameObject</param>
        /// <param name="table">class System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single></param>
        /// <param name="duration">struct System.Single</param>
        /// <param name="callback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CullingFadeOut")]
        /// static extern void CULLING_FADE_OUT (nint owner, nint table, System.Single duration, nint callback);


        /// <summary>
        /// static  System.Void ForceHideAllPlayerShipUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceHideAllPlayerShipUI")]
        /// static extern void FORCE_HIDE_ALL_PLAYER_SHIP_UI ();


        /// <summary>
        /// static  UnityEngine.Vector3 GetCamPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCamPosition")]
        /// static extern UnityEngine.Vector3 GET_CAM_POSITION ();


        /// <summary>
        /// static  System.Void GetGameTotalChestCompletionInfo(System.Int32& unlockedCount, System.Int32& totalChestCount)
        /// </summary>
        /// <param name="unlockedCount">struct System.Int32&</param>
        /// <param name="totalChestCount">struct System.Int32&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGameTotalChestCompletionInfo")]
        /// static extern void GET_GAME_TOTAL_CHEST_COMPLETION_INFO (System.Int32& unlockedCount, System.Int32& totalChestCount);


        /// <summary>
        /// static  System.Single GetGlobalGoldMultiplier()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGlobalGoldMultiplier")]
        /// static extern System.Single GET_GLOBAL_GOLD_MULTIPLIER ();


        /// <summary>
        /// static  System.Int32 GetInfinityTowerEnemyLevel(System.Int32 waveNum)
        /// </summary>
        /// <param name="waveNum">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInfinityTowerEnemyLevel")]
        /// static extern System.Int32 GET_INFINITY_TOWER_ENEMY_LEVEL (System.Int32 waveNum);


        /// <summary>
        /// static  System.Void GetMapRegionChestCompletionInfo(MapRegion mapRegion, System.Int32& unlockedCount, System.Int32& totalChestCount)
        /// </summary>
        /// <param name="mapRegion">enum MapRegion</param>
        /// <param name="unlockedCount">struct System.Int32&</param>
        /// <param name="totalChestCount">struct System.Int32&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetMapRegionChestCompletionInfo")]
        /// static extern void GET_MAP_REGION_CHEST_COMPLETION_INFO (MapRegion mapRegion, System.Int32& unlockedCount, System.Int32& totalChestCount);


        /// <summary>
        /// static  System.Int32 GetPlayerLevelUnlockedThresholdSlots(System.Int32& nextLockedThresholdLevel, System.Collections.Generic.List<System.Int32> thresholds)
        /// </summary>
        /// <param name="nextLockedThresholdLevel">struct System.Int32&</param>
        /// <param name="thresholds">class System.Collections.Generic.List<System.Int32></param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPlayerLevelUnlockedThresholdSlots")]
        /// static extern System.Int32 GET_PLAYER_LEVEL_UNLOCKED_THRESHOLD_SLOTS (System.Int32& nextLockedThresholdLevel, nint thresholds);


        /// <summary>
        /// static  System.Int32 GetPlayerMaxLevel()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPlayerMaxLevel")]
        /// static extern System.Int32 GET_PLAYER_MAX_LEVEL ();


        /// <summary>
        /// static  UnityEngine.Vector3 GetSpawnPosition(SpawnSourceVfxEffect config, GameEntity e, UnityEngine.Transform& parent)
        /// </summary>
        /// <param name="config">class SpawnSourceVfxEffect</param>
        /// <param name="e">class GameEntity</param>
        /// <param name="parent">class UnityEngine.Transform&</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpawnPosition")]
        /// static extern UnityEngine.Vector3 GET_SPAWN_POSITION (nint config, nint e, nint parent);


        /// <summary>
        /// static  UnityEngine.Vector3 GetValidSpiritPosition(UnityEngine.Vector3 position)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetValidSpiritPosition")]
        /// static extern UnityEngine.Vector3 GET_VALID_SPIRIT_POSITION (UnityEngine.Vector3 position);


        /// <summary>
        /// static  System.Boolean HasMouseInput()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasMouseInput")]
        /// static extern System.Boolean HAS_MOUSE_INPUT ();


        /// <summary>
        /// static  System.Void HealAndRevivePlayerShip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HealAndRevivePlayerShip", CallConvs = [typeof(CallConvCdecl)])]
        static extern void HEAL_AND_REVIVE_PLAYER_SHIP();


        /// <summary>
        /// static  System.Void HideAllPlayerShipUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideAllPlayerShipUI")]
        /// static extern void HIDE_ALL_PLAYER_SHIP_UI ();


        /// <summary>
        /// static  System.Boolean IsAnyPlayerInCombat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsAnyPlayerInCombat")]
        /// static extern System.Boolean IS_ANY_PLAYER_IN_COMBAT ();


        /// <summary>
        /// static  System.Boolean IsGameObjectInDeadPool(UnityEngine.GameObject go)
        /// </summary>
        /// <param name="go">class UnityEngine.GameObject</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsGameObjectInDeadPool")]
        /// static extern System.Boolean IS_GAME_OBJECT_IN_DEAD_POOL (nint go);


        /// <summary>
        /// static  System.Boolean IsInteractableRequiredKeyLocked(InteractableBehaviour interactableBehaviour)
        /// </summary>
        /// <param name="interactableBehaviour">abstract class InteractableBehaviour</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInteractableRequiredKeyLocked")]
        /// static extern System.Boolean IS_INTERACTABLE_REQUIRED_KEY_LOCKED (nint interactableBehaviour);


        /// <summary>
        /// static  System.Boolean IsObjectOutOfViewport(UnityEngine.Vector3 worldPos)
        /// </summary>
        /// <param name="worldPos">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsObjectOutOfViewport")]
        /// static extern System.Boolean IS_OBJECT_OUT_OF_VIEWPORT (UnityEngine.Vector3 worldPos);


        /// <summary>
        /// static  System.Boolean IsPlayerAtMaxLevel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerAtMaxLevel")]
        /// static extern System.Boolean IS_PLAYER_AT_MAX_LEVEL ();


        /// <summary>
        /// static  System.Boolean IsPlayerShipAtMaxHealth()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerShipAtMaxHealth")]
        /// static extern System.Boolean IS_PLAYER_SHIP_AT_MAX_HEALTH ();


        /// <summary>
        /// static  System.Boolean IsPlayerShipAtWarningHealthLevel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerShipAtWarningHealthLevel")]
        /// static extern System.Boolean IS_PLAYER_SHIP_AT_WARNING_HEALTH_LEVEL ();


        /// <summary>
        /// static  System.Boolean IsPlayerShipBeingHealed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerShipBeingHealed")]
        /// static extern System.Boolean IS_PLAYER_SHIP_BEING_HEALED ();


        /// <summary>
        /// static  System.Boolean IsPlayerShipEmpty()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerShipEmpty")]
        /// static extern System.Boolean IS_PLAYER_SHIP_EMPTY ();


        /// <summary>
        /// static  System.Boolean IsPlayerShipInCombat()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPlayerShipInCombat")]
        /// static extern System.Boolean IS_PLAYER_SHIP_IN_COMBAT ();


        /// <summary>
        /// static  System.Boolean IsShipItemSlotsFull()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsShipItemSlotsFull")]
        /// static extern System.Boolean IS_SHIP_ITEM_SLOTS_FULL ();


        /// <summary>
        /// static  System.Void RemoveBuffTintFromTarget(GameEntity target, UnityEngine.Color color)
        /// </summary>
        /// <param name="target">class GameEntity</param>
        /// <param name="color">struct UnityEngine.Color</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveBuffTintFromTarget")]
        /// static extern void REMOVE_BUFF_TINT_FROM_TARGET (nint target, UnityEngine.Color color);


        /// <summary>
        /// static  System.Void ResetCullingFade(System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single> table)
        /// </summary>
        /// <param name="table">class System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetCullingFade")]
        /// static extern void RESET_CULLING_FADE (nint table);


        /// <summary>
        /// static  System.Void ShowAllPlayerShipUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowAllPlayerShipUI")]
        /// static extern void SHOW_ALL_PLAYER_SHIP_UI ();


        /// <summary>
        /// static  System.Void ShowAllThenFadePlayerShipUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowAllThenFadePlayerShipUI")]
        /// static extern void SHOW_ALL_THEN_FADE_PLAYER_SHIP_UI ();


        /// <summary>
        /// static  System.Void ShutdownCullingFade(System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single> table)
        /// </summary>
        /// <param name="table">class System.Collections.Generic.Dictionary<UnityEngine.SpriteRenderer,System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShutdownCullingFade")]
        /// static extern void SHUTDOWN_CULLING_FADE (nint table);


        /// <summary>
        /// static  System.Void TeleportPlayersOutOfCameraView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TeleportPlayersOutOfCameraView")]
        /// static extern void TELEPORT_PLAYERS_OUT_OF_CAMERA_VIEW ();


        /// <summary>
        /// static  System.Void TryReviveAllPlayers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryReviveAllPlayers")]
        /// static extern void TRY_REVIVE_ALL_PLAYERS ();


        /// <summary>
        /// static  System.Void TryReviveAllPlayersImmediate()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryReviveAllPlayersImmediate")]
        /// static extern void TRY_REVIVE_ALL_PLAYERS_IMMEDIATE ();


        /// <summary>
        /// static  System.Void TryReviveTarget(GameEntity target)
        /// </summary>
        /// <param name="target">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryReviveTarget")]
        /// static extern void TRY_REVIVE_TARGET (nint target);


        /// <summary>
        /// static  System.Void TryReviveTargetImmediate(GameEntity target)
        /// </summary>
        /// <param name="target">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryReviveTargetImmediate")]
        /// static extern void TRY_REVIVE_TARGET_IMMEDIATE (nint target);


        /// <summary>
        /// static  System.Void UpdatePlayerModelSize(GameEntity e)
        /// </summary>
        /// <param name="e">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdatePlayerModelSize")]
        /// static extern void UPDATE_PLAYER_MODEL_SIZE (nint e);


        /// <summary>
        /// static  System.Void UpdatePlayerShipAmmoCooldown()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdatePlayerShipAmmoCooldown")]
        /// static extern void UPDATE_PLAYER_SHIP_AMMO_COOLDOWN ();



        /// <summary>
        /// static  System.Single GetEntitySpeedModifier(UnityEngine.GameObject obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.GameObject</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitySpeedModifier", Search = typeof(Search_GameplayHelper))]
        /// static extern System.Single GET_ENTITY_SPEED_MODIFIER_00 (nint obj);


        /// <summary>
        /// static  System.Single GetEntitySpeedModifier(GameEntity e)
        /// </summary>
        /// <param name="e">class GameEntity</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitySpeedModifier", Search = typeof(Search_GameplayHelper))]
        /// static extern System.Single GET_ENTITY_SPEED_MODIFIER_01 (nint e);


        /// <summary>
        /// static  System.Void ReplenishPlayerShipAmmoClip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplenishPlayerShipAmmoClip", CallConvs = [typeof(CallConvCdecl)], Search = typeof(Search_GameplayHelper))]
        static extern void REPLENISH_PLAYER_SHIP_AMMO_CLIP_00();


        /// <summary>
        /// static  System.Void ReplenishPlayerShipAmmoClip(GameEntity shipEntity)
        /// </summary>
        /// <param name="shipEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplenishPlayerShipAmmoClip", Search = typeof(Search_GameplayHelper))]
        /// static extern void REPLENISH_PLAYER_SHIP_AMMO_CLIP_01 (nint shipEntity);


        public static partial class Search_GameplayHelper
        {
            /// 
            ///     

            /// <summary>
            /// static  System.Single GetEntitySpeedModifier(UnityEngine.GameObject obj)
            /// </summary>
            /// public static bool GET_ENTITY_SPEED_MODIFIER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntitySpeedModifier", "UnityEngine.GameObject");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Single GetEntitySpeedModifier(GameEntity e)
            /// </summary>
            /// public static bool GET_ENTITY_SPEED_MODIFIER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntitySpeedModifier", "GameEntity");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void ReplenishPlayerShipAmmoClip()
            /// </summary>
            public static bool REPLENISH_PLAYER_SHIP_AMMO_CLIP_00(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReplenishPlayerShipAmmoClip");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.Void ReplenishPlayerShipAmmoClip(GameEntity shipEntity)
            /// </summary>
            /// public static bool REPLENISH_PLAYER_SHIP_AMMO_CLIP_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ReplenishPlayerShipAmmoClip", "GameEntity");
            ///     
            ///  
            /// 
            /// 
        }

    }


}