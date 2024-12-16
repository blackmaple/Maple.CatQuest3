
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
    /// static class ["ProjectStar".""."ContextsExtensions"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020005BCU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [67, 111, 110, 116, 101, 120, 116, 115, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115])]


    public partial class ContextsExtensions
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ContextsExtensions";
        //public static byte[] Static_ClassName { get; } = [67, 111, 110, 116, 101, 120, 116, 115, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115];

        //public const uint Const_TypeToken = 0x020005BCU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ContextsExtensions(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ContextsExtensions(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ContextsExtensions obj) => obj._ptr;
            public static implicit operator bool(Ptr_ContextsExtensions obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."ContextsExtensions"]
    /// </summary>
    public partial class ContextsExtensions
    {



        /// <summary>
        /// static  System.Collections.Generic.HashSet<AIEntity> GetEntitiesWithAIEntity(AIContext context, AIEntity value)
        /// </summary>
        /// <param name="context">class AIContext</param>
        /// <param name="value">class AIEntity</param>
        /// <returns>class System.Collections.Generic.HashSet<AIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithAIEntity")]
        /// static extern nint GET_ENTITIES_WITH_AI_ENTITY (nint context, nint value);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithInHealRegion(GameContext context, GameEntity healer)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="healer">class GameEntity</param>
        /// <returns>class System.Collections.Generic.HashSet<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithInHealRegion")]
        /// static extern nint GET_ENTITIES_WITH_IN_HEAL_REGION (nint context, nint healer);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithInPotentialHealRegion(GameContext context, GameEntity healer)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="healer">class GameEntity</param>
        /// <returns>class System.Collections.Generic.HashSet<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithInPotentialHealRegion")]
        /// static extern nint GET_ENTITIES_WITH_IN_POTENTIAL_HEAL_REGION (nint context, nint healer);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithInventoryItemPreviewStateSubCategoryTabType(GUIContext context, GenericTabType subCategoryTabType)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="subCategoryTabType">enum GenericTabType</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithInventoryItemPreviewStateSubCategoryTabType")]
        /// static extern nint GET_ENTITIES_WITH_INVENTORY_ITEM_PREVIEW_STATE_SUB_CATEGORY_TAB_TYPE (nint context, GenericTabType subCategoryTabType);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithInventoryItemPreviewStateTabType(GUIContext context, GenericTabType tabType)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="tabType">enum GenericTabType</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithInventoryItemPreviewStateTabType")]
        /// static extern nint GET_ENTITIES_WITH_INVENTORY_ITEM_PREVIEW_STATE_TAB_TYPE (nint context, GenericTabType tabType);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithMapIconMapIconType(GUIContext context, MapIconType mapIconType)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="mapIconType">enum MapIconType</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithMapIconMapIconType")]
        /// static extern nint GET_ENTITIES_WITH_MAP_ICON_MAP_ICON_TYPE (nint context, MapIconType mapIconType);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithPlayerVicinity(GameContext context, GameEntity value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class GameEntity</param>
        /// <returns>class System.Collections.Generic.HashSet<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithPlayerVicinity")]
        /// static extern nint GET_ENTITIES_WITH_PLAYER_VICINITY (nint context, nint value);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithUIPanelDisplayStatus(GUIContext context, System.Boolean isShowing)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="isShowing">struct System.Boolean</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithUIPanelDisplayStatus")]
        /// static extern nint GET_ENTITIES_WITH_UI_PANEL_DISPLAY_STATUS (nint context, System.Boolean isShowing);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithUITooltip(GUIContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithUITooltip")]
        /// static extern nint GET_ENTITIES_WITH_UI_TOOLTIP (nint context, System.Int32 playerID);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithWorldPuzzlePieceUIOwner(GUIContext context, GameEntity puzzleAnswerEntity)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="puzzleAnswerEntity">class GameEntity</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithWorldPuzzlePieceUIOwner")]
        /// static extern nint GET_ENTITIES_WITH_WORLD_PUZZLE_PIECE_UI_OWNER (nint context, nint puzzleAnswerEntity);


        /// <summary>
        /// static  AudioEntity GetEntityWithAudioStack(AudioContext context, System.UInt32 stackID)
        /// </summary>
        /// <param name="context">class AudioContext</param>
        /// <param name="stackID">struct System.UInt32</param>
        /// <returns>class AudioEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithAudioStack")]
        /// static extern nint GET_ENTITY_WITH_AUDIO_STACK (nint context, System.UInt32 stackID);


        /// <summary>
        /// static  InputEntity GetEntityWithCameraPanInputAxis(InputContext context, System.Int32 playerId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithCameraPanInputAxis")]
        /// static extern nint GET_ENTITY_WITH_CAMERA_PAN_INPUT_AXIS (nint context, System.Int32 playerId);


        /// <summary>
        /// static  GameEntity GetEntityWithDialogueSpeaker(GameContext context, IDialogueSpeaker owner)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="owner">interface IDialogueSpeaker</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithDialogueSpeaker")]
        /// static extern nint GET_ENTITY_WITH_DIALOGUE_SPEAKER (nint context, nint owner);


        /// <summary>
        /// static  GameEntity GetEntityWithDockRepairBeacon(GameContext context, GameEntity owner)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="owner">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithDockRepairBeacon")]
        /// static extern nint GET_ENTITY_WITH_DOCK_REPAIR_BEACON (nint context, nint owner);


        /// <summary>
        /// static  GameEntity GetEntityWithEquippedSpells(GameContext context, GameEntity owner)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="owner">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithEquippedSpells")]
        /// static extern nint GET_ENTITY_WITH_EQUIPPED_SPELLS (nint context, nint owner);


        /// <summary>
        /// static  AIEntity GetEntityWithGameEntity(AIContext context, GameEntity value)
        /// </summary>
        /// <param name="context">class AIContext</param>
        /// <param name="value">class GameEntity</param>
        /// <returns>class AIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithGameEntity")]
        /// static extern nint GET_ENTITY_WITH_GAME_ENTITY (nint context, nint value);


        /// <summary>
        /// static  GUIEntity GetEntityWithGunAmmoUI(GUIContext context, GameEntity gunOwner)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="gunOwner">class GameEntity</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithGunAmmoUI")]
        /// static extern nint GET_ENTITY_WITH_GUN_AMMO_UI (nint context, nint gunOwner);


        /// <summary>
        /// static  GameEntity GetEntityWithHitStopEvent(GameContext context, UnityEngine.GameObject target)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="target">class UnityEngine.GameObject</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithHitStopEvent")]
        /// static extern nint GET_ENTITY_WITH_HIT_STOP_EVENT (nint context, nint target);


        /// <summary>
        /// static  InputEntity GetEntityWithInputAxis(InputContext context, System.Int32 playerId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithInputAxis")]
        /// static extern nint GET_ENTITY_WITH_INPUT_AXIS (nint context, System.Int32 playerId);


        /// <summary>
        /// static  GUIEntity GetEntityWithInventoryItemPreviewStateGUID(GUIContext context, System.String GUID)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="GUID">class System.String</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithInventoryItemPreviewStateGUID")]
        /// static extern nint GET_ENTITY_WITH_INVENTORY_ITEM_PREVIEW_STATE_GUID (nint context, nint GUID);


        /// <summary>
        /// static  GameEntity GetEntityWithLifetimeTarget(GameContext context, UnityEngine.GameObject value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class UnityEngine.GameObject</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithLifetimeTarget")]
        /// static extern nint GET_ENTITY_WITH_LIFETIME_TARGET (nint context, nint value);


        /// <summary>
        /// static  GameEntity GetEntityWithLocationData(GameContext context, LocationData locationData)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="locationData">class LocationData</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithLocationData")]
        /// static extern nint GET_ENTITY_WITH_LOCATION_DATA (nint context, nint locationData);


        /// <summary>
        /// static  GameEntity GetEntityWithMapIconDisplayLink(GameContext context, GameEntity owner)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="owner">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMapIconDisplayLink")]
        /// static extern nint GET_ENTITY_WITH_MAP_ICON_DISPLAY_LINK (nint context, nint owner);


        /// <summary>
        /// static  GUIEntity GetEntityWithMapIconWorldCollider(GUIContext context, UnityEngine.Collider worldCollider)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="worldCollider">class UnityEngine.Collider</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMapIconWorldCollider")]
        /// static extern nint GET_ENTITY_WITH_MAP_ICON_WORLD_COLLIDER (nint context, nint worldCollider);


        /// <summary>
        /// static  GameEntity GetEntityWithMapMarkerWorldIndex(GameContext context, System.Int32 index)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMapMarkerWorldIndex")]
        /// static extern nint GET_ENTITY_WITH_MAP_MARKER_WORLD_INDEX (nint context, System.Int32 index);


        /// <summary>
        /// static  InputEntity GetEntityWithMapUIInputAxis(InputContext context, System.Int32 playerId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMapUIInputAxis")]
        /// static extern nint GET_ENTITY_WITH_MAP_UI_INPUT_AXIS (nint context, System.Int32 playerId);


        /// <summary>
        /// static  InputEntity GetEntityWithMapUIInputZoomAxis(InputContext context, System.Int32 playerId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMapUIInputZoomAxis")]
        /// static extern nint GET_ENTITY_WITH_MAP_UI_INPUT_ZOOM_AXIS (nint context, System.Int32 playerId);


        /// <summary>
        /// static  GameEntity GetEntityWithMonsterDetector(GameContext context, MonsterDetectorBehaviour value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class MonsterDetectorBehaviour</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithMonsterDetector")]
        /// static extern nint GET_ENTITY_WITH_MONSTER_DETECTOR (nint context, nint value);


        /// <summary>
        /// static  GameEntity GetEntityWithOverrideCharacterGender(GameContext context, System.Int32 playerId)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithOverrideCharacterGender")]
        /// static extern nint GET_ENTITY_WITH_OVERRIDE_CHARACTER_GENDER (nint context, System.Int32 playerId);


        /// <summary>
        /// static  GameEntity GetEntityWithPlayerId(GameContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPlayerId", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint GET_ENTITY_WITH_PLAYER_ID(GameContext.Ptr_GameContext context, System.Int32 value);


        /// <summary>
        /// static  GameEntity GetEntityWithPlayerSleepingSaveStone(GameContext context, GameEntity player)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="player">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPlayerSleepingSaveStone")]
        /// static extern nint GET_ENTITY_WITH_PLAYER_SLEEPING_SAVE_STONE (nint context, nint player);


        /// <summary>
        /// static  GUIEntity GetEntityWithPlayerUIButtonSelectConfirm(GUIContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPlayerUIButtonSelectConfirm")]
        /// static extern nint GET_ENTITY_WITH_PLAYER_UI_BUTTON_SELECT_CONFIRM (nint context, System.Int32 playerID);


        /// <summary>
        /// static  GUIEntity GetEntityWithPlayerUIButtonSelectConfirmHeld(GUIContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPlayerUIButtonSelectConfirmHeld")]
        /// static extern nint GET_ENTITY_WITH_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD (nint context, System.Int32 playerID);


        /// <summary>
        /// static  GUIEntity GetEntityWithPlayerUIButtonSelection(GUIContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPlayerUIButtonSelection")]
        /// static extern nint GET_ENTITY_WITH_PLAYER_UI_BUTTON_SELECTION (nint context, System.Int32 playerID);


        /// <summary>
        /// static  GameEntity GetEntityWithPuzzleAnswer(GameContext context, PuzzleAnswerData puzzleAnswerData)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="puzzleAnswerData">class PuzzleAnswerData</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPuzzleAnswer")]
        /// static extern nint GET_ENTITY_WITH_PUZZLE_ANSWER (nint context, nint puzzleAnswerData);


        /// <summary>
        /// static  GameEntity GetEntityWithPuzzleLootLocation(GameContext context, PuzzleAnswerData answerData)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="answerData">class PuzzleAnswerData</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPuzzleLootLocation")]
        /// static extern nint GET_ENTITY_WITH_PUZZLE_LOOT_LOCATION (nint context, nint answerData);


        /// <summary>
        /// static  GameEntity GetEntityWithPuzzlePieceID(GameContext context, PuzzlePieceID value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class PuzzlePieceID</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithPuzzlePieceID")]
        /// static extern nint GET_ENTITY_WITH_PUZZLE_PIECE_ID (nint context, nint value);


        /// <summary>
        /// static  GameEntity GetEntityWithReviveBeacon(GameContext context, GameEntity revivableEntity)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="revivableEntity">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithReviveBeacon")]
        /// static extern nint GET_ENTITY_WITH_REVIVE_BEACON (nint context, nint revivableEntity);


        /// <summary>
        /// static  GameEntity GetEntityWithReviveBeaconReference(GameContext context, GameEntity value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class GameEntity</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithReviveBeaconReference")]
        /// static extern nint GET_ENTITY_WITH_REVIVE_BEACON_REFERENCE (nint context, nint value);


        /// <summary>
        /// static  GUIEntity GetEntityWithUIIsAnimatingPanel(GUIContext context, UIInventorySubPanel value)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="value">class UIInventorySubPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithUIIsAnimatingPanel")]
        /// static extern nint GET_ENTITY_WITH_UI_IS_ANIMATING_PANEL (nint context, nint value);


        /// <summary>
        /// static  GUIEntity GetEntityWithUIPanelFixed(GUIContext context, UIPanelFixedType panelType)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="panelType">enum UIPanelFixedType</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithUIPanelFixed")]
        /// static extern nint GET_ENTITY_WITH_UI_PANEL_FIXED (nint context, UIPanelFixedType panelType);


        /// <summary>
        /// static  GUIEntity GetEntityWithUIPanelShowInputState(GUIContext context, UIPanelBase panel)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="panel">abstract class UIPanelBase</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithUIPanelShowInputState")]
        /// static extern nint GET_ENTITY_WITH_UI_PANEL_SHOW_INPUT_STATE (nint context, nint panel);


        /// <summary>
        /// static  GUIEntity GetEntityWithUpgradePanel(GUIContext context, UpgradePanel.UpgradePanelType upgradePanelType)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="upgradePanelType">enum UpgradePanel.UpgradePanelType</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithUpgradePanel")]
        /// static extern nint GET_ENTITY_WITH_UPGRADE_PANEL (nint context, UpgradePanel.UpgradePanelType upgradePanelType);


        /// <summary>
        /// static  GUIEntity GetEntityWithWorldDialogueMessageQueue(GUIContext context, GameEntity speakerEntity)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="speakerEntity">class GameEntity</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithWorldDialogueMessageQueue")]
        /// static extern nint GET_ENTITY_WITH_WORLD_DIALOGUE_MESSAGE_QUEUE (nint context, nint speakerEntity);



        /// <summary>
        /// static  System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithGameEntityId(GameContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.HashSet<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithGameEntityId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITIES_WITH_GAME_ENTITY_ID_00 (nint context, System.Int32 value);


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithGameEntityId(GUIContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class GUIContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.HashSet<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntitiesWithGameEntityId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITIES_WITH_GAME_ENTITY_ID_01 (nint context, System.Int32 value);


        /// <summary>
        /// static  AudioEntity GetEntityWithAudioSourceId(AudioContext context, System.UInt32 value)
        /// </summary>
        /// <param name="context">class AudioContext</param>
        /// <param name="value">struct System.UInt32</param>
        /// <returns>class AudioEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithAudioSourceId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_AUDIO_SOURCE_ID_00 (nint context, System.UInt32 value);


        /// <summary>
        /// static  InputEntity GetEntityWithAudioSourceId(InputContext context, System.UInt32 value)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="value">struct System.UInt32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithAudioSourceId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_AUDIO_SOURCE_ID_01 (nint context, System.UInt32 value);


        /// <summary>
        /// static  CombatEntity GetEntityWithCombatAgent(CombatContext context, CombatAgent value)
        /// </summary>
        /// <param name="context">class CombatContext</param>
        /// <param name="value">class CombatAgent</param>
        /// <returns>class CombatEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithCombatAgent", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_COMBAT_AGENT_00 (nint context, nint value);


        /// <summary>
        /// static  GameEntity GetEntityWithCombatAgent(GameContext context, CombatAgent value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">class CombatAgent</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithCombatAgent", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_COMBAT_AGENT_01 (nint context, nint value);


        /// <summary>
        /// static  GameEntity GetEntityWithId(GameContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_ID_00 (nint context, System.Int32 value);


        /// <summary>
        /// static  AudioEntity GetEntityWithId(AudioContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class AudioContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class AudioEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_ID_01 (nint context, System.Int32 value);


        /// <summary>
        /// static  AIEntity GetEntityWithId(AIContext context, System.Int32 value)
        /// </summary>
        /// <param name="context">class AIContext</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>class AIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithId", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_ID_02 (nint context, System.Int32 value);


        /// <summary>
        /// static  GameEntity GetEntityWithInteractCommandUpdate(GameContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class GameContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithInteractCommandUpdate", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_INTERACT_COMMAND_UPDATE_00 (nint context, System.Int32 playerID);


        /// <summary>
        /// static  InputEntity GetEntityWithInteractCommandUpdate(InputContext context, System.Int32 playerID)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerID">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityWithInteractCommandUpdate", Search = typeof(Search_ContextsExtensions))]
        /// static extern nint GET_ENTITY_WITH_INTERACT_COMMAND_UPDATE_01 (nint context, System.Int32 playerID);


        /// public static partial class Search_ContextsExtensions
        /// {
        /// 
        ///     

        /// <summary>
        /// static  System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithGameEntityId(GameContext context, System.Int32 value)
        /// </summary>
        /// public static bool GET_ENTITIES_WITH_GAME_ENTITY_ID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntitiesWithGameEntityId", "GameContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Collections.Generic.HashSet<GUIEntity> GetEntitiesWithGameEntityId(GUIContext context, System.Int32 value)
        /// </summary>
        /// public static bool GET_ENTITIES_WITH_GAME_ENTITY_ID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntitiesWithGameEntityId", "GUIContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  AudioEntity GetEntityWithAudioSourceId(AudioContext context, System.UInt32 value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_AUDIO_SOURCE_ID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithAudioSourceId", "AudioContext", "System.UInt32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  InputEntity GetEntityWithAudioSourceId(InputContext context, System.UInt32 value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_AUDIO_SOURCE_ID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithAudioSourceId", "InputContext", "System.UInt32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  CombatEntity GetEntityWithCombatAgent(CombatContext context, CombatAgent value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_COMBAT_AGENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithCombatAgent", "CombatContext", "CombatAgent");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity GetEntityWithCombatAgent(GameContext context, CombatAgent value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_COMBAT_AGENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithCombatAgent", "GameContext", "CombatAgent");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity GetEntityWithId(GameContext context, System.Int32 value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_ID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithId", "GameContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  AudioEntity GetEntityWithId(AudioContext context, System.Int32 value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_ID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithId", "AudioContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  AIEntity GetEntityWithId(AIContext context, System.Int32 value)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_ID_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithId", "AIContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  GameEntity GetEntityWithInteractCommandUpdate(GameContext context, System.Int32 playerID)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_INTERACT_COMMAND_UPDATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithInteractCommandUpdate", "GameContext", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  InputEntity GetEntityWithInteractCommandUpdate(InputContext context, System.Int32 playerID)
        /// </summary>
        /// public static bool GET_ENTITY_WITH_INTERACT_COMMAND_UPDATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntityWithInteractCommandUpdate", "InputContext", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}