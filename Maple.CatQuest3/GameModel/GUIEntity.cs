
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
    /// class ["ProjectStar".""."GUIEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// [ICombatLogEntity]=>[IDestroyedEntity]=>[IGameEntityIdEntity]=>[IInactiveEntity]=>[IPositionAttachEntity]=>[ITimerEntity]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000649U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 85, 73, 69, 110, 116, 105, 116, 121])]

    //  class static AttackTellCanvasComponent attackTellCanvasComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"attackTellCanvasComponent", "ATTACK_TELL_CANVAS_COMPONENT", true)]

    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]

    //  class static HasOverlappingNavigationTrackersComponent hasOverlappingNavigationTrackersComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"hasOverlappingNavigationTrackersComponent", "HAS_OVERLAPPING_NAVIGATION_TRACKERS_COMPONENT", true)]

    //  class static HealthBarCanvasComponent healthBarCanvasComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"healthBarCanvasComponent", "HEALTH_BAR_CANVAS_COMPONENT", true)]

    //  class static HideMessagePromptComponent hideMessagePromptComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"hideMessagePromptComponent", "HIDE_MESSAGE_PROMPT_COMPONENT", true)]

    //  class static InactiveComponent inactiveComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inactiveComponent", "INACTIVE_COMPONENT", true)]

    //  class static LevelUpWorldUISplashComponent levelUpWorldUISplashComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"levelUpWorldUISplashComponent", "LEVEL_UP_WORLD_UI_SPLASH_COMPONENT", true)]

    //  class static MapInteractionControllerDetectedComponent mapInteractionControllerDetectedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"mapInteractionControllerDetectedComponent", "MAP_INTERACTION_CONTROLLER_DETECTED_COMPONENT", true)]

    //  class static MapPanelInteractableFocusZoneTouchActiveComponent mapPanelInteractableFocusZoneTouchActiveComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"mapPanelInteractableFocusZoneTouchActiveComponent", "MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE_COMPONENT", true)]

    //  class static MapUIRestoringConfinerComponent mapUIRestoringConfinerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"mapUIRestoringConfinerComponent", "MAP_UI_RESTORING_CONFINER_COMPONENT", true)]

    //  class static PlayerIndicatorComponent playerIndicatorComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"playerIndicatorComponent", "PLAYER_INDICATOR_COMPONENT", true)]

    //  class static ScreenEffectCanvasComponent screenEffectCanvasComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"screenEffectCanvasComponent", "SCREEN_EFFECT_CANVAS_COMPONENT", true)]

    //  class static ShipInteriorPromptComponent shipInteriorPromptComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"shipInteriorPromptComponent", "SHIP_INTERIOR_PROMPT_COMPONENT", true)]

    //  class static ShowPlayerShipUIEventComponent showPlayerShipUIEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"showPlayerShipUIEventComponent", "SHOW_PLAYER_SHIP_UI_EVENT_COMPONENT", true)]

    //  class static SinglePlayerUIInteractionModeComponent singlePlayerUIInteractionModeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"singlePlayerUIInteractionModeComponent", "SINGLE_PLAYER_UI_INTERACTION_MODE_COMPONENT", true)]

    //  class static UICommandOwner uICommandOwnerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uICommandOwnerComponent", "U_I_COMMAND_OWNER_COMPONENT", true)]

    //  class static UIEquipmentUpgradeLevelUpEventComponent uIEquipmentUpgradeLevelUpEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uIEquipmentUpgradeLevelUpEventComponent", "U_I_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT_COMPONENT", true)]

    //  class static UIEquipmentUpgradeLockBreakLevelUpEventComponent uIEquipmentUpgradeLockBreakLevelUpEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uIEquipmentUpgradeLockBreakLevelUpEventComponent", "U_I_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT_COMPONENT", true)]

    //  class static UIInputBlockedComponent uIInputBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uIInputBlockedComponent", "U_I_INPUT_BLOCKED_COMPONENT", true)]

    //  class static UIInputMouseBlockedComponent uIInputMouseBlockedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uIInputMouseBlockedComponent", "U_I_INPUT_MOUSE_BLOCKED_COMPONENT", true)]

    //  class static UIMouseInteractionModeComponent uIMouseInteractionModeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"uIMouseInteractionModeComponent", "U_I_MOUSE_INTERACTION_MODE_COMPONENT", true)]

    //  class static WorldAnchorComponent worldAnchorComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"worldAnchorComponent", "WORLD_ANCHOR_COMPONENT", true)]

    //  class static WorldCanvasOrientateCamComponent worldCanvasOrientateCamComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"worldCanvasOrientateCamComponent", "WORLD_CANVAS_ORIENTATE_CAM_COMPONENT", true)]

    // class 0x8 Entitas.EntityComponentChanged OnComponentAdded
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentAdded", "ON_COMPONENT_ADDED")]

    // class 0xC Entitas.EntityComponentChanged OnComponentRemoved
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentRemoved", "ON_COMPONENT_REMOVED")]

    // class 0x10 Entitas.EntityComponentReplaced OnComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentReplaced", "ON_COMPONENT_REPLACED")]

    // class 0x14 Entitas.EntityEvent OnEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityReleased", "ON_ENTITY_RELEASED")]

    // class 0x18 Entitas.EntityEvent OnDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDestroyEntity", "ON_DESTROY_ENTITY")]

    // class 0x1C System.Collections.Generic.List<Entitas.IComponent> _componentBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentBuffer", "_COMPONENT_BUFFER")]

    // class 0x20 System.Collections.Generic.List<System.Int32> _indexBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_indexBuffer", "_INDEX_BUFFER")]

    // class 0x24 Entitas.IComponent[] _components
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_components", "_COMPONENTS")]

    // class 0x28 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]

    // class 0x2C Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]

    // interface 0x30 Entitas.IAERC _aerc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aerc", "_AERC")]

    // class 0x34 Entitas.IComponent[] _componentsCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentsCache", "_COMPONENTS_CACHE")]

    // class 0x38 System.Int32[] _componentIndicesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentIndicesCache", "_COMPONENT_INDICES_CACHE")]

    // class 0x3C System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]

    // class 0x40 System.Text.StringBuilder _toStringBuilder
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringBuilder", "_TO_STRING_BUILDER")]

    // struct 0x44 System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]

    // struct 0x48 System.Boolean _isEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_isEnabled", "_IS_ENABLED")]

    // struct 0x4C System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]
    public partial class GUIEntity
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GUIEntity";
        //public static byte[] Static_ClassName { get; } = [71, 85, 73, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x02000649U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GUIEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GUIEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GUIEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_GUIEntity obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIEntity"]
    /// </summary>
    public partial class GUIEntity
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void add_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentAdded")]
        ///  extern void ADD_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentRemoved")]
        ///  extern void ADD_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void add_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentReplaced")]
        ///  extern void ADD_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void add_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDestroyEntity")]
        ///  extern void ADD_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void add_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityReleased")]
        ///  extern void ADD_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void AddAttachedCombatAgent(CombatAgent newValue)
        /// </summary>
        /// <param name="newValue">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttachedCombatAgent")]
        ///  extern void ADD_ATTACHED_COMBAT_AGENT (nint newValue);


        /// <summary>
        ///   System.Void AddAttachOwnerEntity(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddAttachOwnerEntity")]
        ///  extern void ADD_ATTACH_OWNER_ENTITY (nint newValue);


        /// <summary>
        ///   System.Void AddButtonHeldFill(UnityEngine.GameObject newTargetUI, System.Int32 newButtonTriggerID)
        /// </summary>
        /// <param name="newTargetUI">class UnityEngine.GameObject</param>
        /// <param name="newButtonTriggerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddButtonHeldFill")]
        ///  extern void ADD_BUTTON_HELD_FILL (nint newTargetUI, System.Int32 newButtonTriggerID);


        /// <summary>
        ///   System.Void AddCallToActionPreorderPanel(UICallToActionScreenController newValue)
        /// </summary>
        /// <param name="newValue">class UICallToActionScreenController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCallToActionPreorderPanel")]
        ///  extern void ADD_CALL_TO_ACTION_PREORDER_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddCameraPresetScaleDisplayRoot(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCameraPresetScaleDisplayRoot")]
        ///  extern void ADD_CAMERA_PRESET_SCALE_DISPLAY_ROOT (nint newValue);


        /// <summary>
        ///   System.Void AddCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCanvas")]
        ///  extern void ADD_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddChestTitlePanel(ChestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class ChestTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChestTitlePanel")]
        ///  extern void ADD_CHEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddCombatLog(CombatLog newValue)
        /// </summary>
        /// <param name="newValue">class CombatLog</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCombatLog")]
        ///  extern void ADD_COMBAT_LOG (nint newValue);


        /// <summary>
        ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
        ///  extern void ADD_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void AddConfirmationPanel(ConfirmationPanel newValue)
        /// </summary>
        /// <param name="newValue">class ConfirmationPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddConfirmationPanel")]
        ///  extern void ADD_CONFIRMATION_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddCreditsPanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCreditsPanel")]
        ///  extern void ADD_CREDITS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddCrystalUI(CrystalUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class CrystalUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCrystalUI")]
        ///  extern void ADD_CRYSTAL_UI (nint newValue);


        /// <summary>
        ///   System.Void AddDenyInteractionUI(DenyInteractionUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class DenyInteractionUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDenyInteractionUI")]
        ///  extern void ADD_DENY_INTERACTION_UI (nint newValue);


        /// <summary>
        ///   System.Void AddDialogueChoice(DialogueChoiceType newValue)
        /// </summary>
        /// <param name="newValue">enum DialogueChoiceType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDialogueChoice")]
        ///  extern void ADD_DIALOGUE_CHOICE (DialogueChoiceType newValue);


        /// <summary>
        ///   System.Void AddDungeonCompletePanel(DungeonCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class DungeonCompletePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddDungeonCompletePanel")]
        ///  extern void ADD_DUNGEON_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddEndGameSplashPanel(EndGameSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class EndGameSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEndGameSplashPanel")]
        ///  extern void ADD_END_GAME_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddEquipmentAwardPanel(EquipmentAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class EquipmentAwardPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEquipmentAwardPanel")]
        ///  extern void ADD_EQUIPMENT_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddExpBarUI(ExpBarUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ExpBarUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExpBarUI")]
        ///  extern void ADD_EXP_BAR_UI (nint newValue);


        /// <summary>
        ///   System.Void AddFullScreenDialogueFocusPanel(FullScreenDialogueFocusPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenDialogueFocusPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFullScreenDialogueFocusPanel")]
        ///  extern void ADD_FULL_SCREEN_DIALOGUE_FOCUS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddFullScreenImageSplashPanel(FullScreenImageSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenImageSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFullScreenImageSplashPanel")]
        ///  extern void ADD_FULL_SCREEN_IMAGE_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddFullScreenTextSplashPanel(FullScreenTextSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenTextSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFullScreenTextSplashPanel")]
        ///  extern void ADD_FULL_SCREEN_TEXT_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddGameEntityId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameEntityId")]
        ///  extern void ADD_GAME_ENTITY_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddGameEntityRef(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameEntityRef")]
        ///  extern void ADD_GAME_ENTITY_REF (nint newValue);


        /// <summary>
        ///   System.Void AddGameOverPanel(GameOverPanel newValue)
        /// </summary>
        /// <param name="newValue">class GameOverPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameOverPanel")]
        ///  extern void ADD_GAME_OVER_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddGoldUI(GoldUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class GoldUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGoldUI")]
        ///  extern void ADD_GOLD_UI (nint newValue);


        /// <summary>
        ///   System.Void AddGunAmmoUI(GunAmmoUI newValue, GameEntity newGunOwner)
        /// </summary>
        /// <param name="newValue">class GunAmmoUI</param>
        /// <param name="newGunOwner">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGunAmmoUI")]
        ///  extern void ADD_GUN_AMMO_UI (nint newValue, nint newGunOwner);


        /// <summary>
        ///   System.Void AddHealthBarView(ProjectStar.HealthBarView newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.HealthBarView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddHealthBarView")]
        ///  extern void ADD_HEALTH_BAR_VIEW (nint newValue);


        /// <summary>
        ///   System.Void AddInfinityTowerProgressPanel(InfinityTowerProgressPanel newValue)
        /// </summary>
        /// <param name="newValue">class InfinityTowerProgressPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInfinityTowerProgressPanel")]
        ///  extern void ADD_INFINITY_TOWER_PROGRESS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddInstanceTitlePanel(InstanceTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class InstanceTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInstanceTitlePanel")]
        ///  extern void ADD_INSTANCE_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddInventoryItemPreviewState(GenericTabType newTabType, GenericTabType newSubCategoryTabType, System.String newGUID)
        /// </summary>
        /// <param name="newTabType">enum GenericTabType</param>
        /// <param name="newSubCategoryTabType">enum GenericTabType</param>
        /// <param name="newGUID">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryItemPreviewState")]
        ///  extern void ADD_INVENTORY_ITEM_PREVIEW_STATE (GenericTabType newTabType, GenericTabType newSubCategoryTabType, nint newGUID);


        /// <summary>
        ///   System.Void AddInventoryPanel(UIInventoryPanel newValue)
        /// </summary>
        /// <param name="newValue">class UIInventoryPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryPanel")]
        ///  extern void ADD_INVENTORY_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddInventoryPickupUIController(InventoryPickupUIController newValue)
        /// </summary>
        /// <param name="newValue">class InventoryPickupUIController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryPickupUIController")]
        ///  extern void ADD_INVENTORY_PICKUP_UI_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void AddInventoryUser(System.Int32 newPlayerID)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddInventoryUser")]
        ///  extern void ADD_INVENTORY_USER (System.Int32 newPlayerID);


        /// <summary>
        ///   System.Void AddLanguagePanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLanguagePanel")]
        ///  extern void ADD_LANGUAGE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddLastSelectedUIButtonInfo(System.Int32 newPlayerID, UIButton newValue)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newValue">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastSelectedUIButtonInfo")]
        ///  extern void ADD_LAST_SELECTED_UI_BUTTON_INFO (System.Int32 newPlayerID, nint newValue);


        /// <summary>
        ///   System.Void AddLevelUpPanel(LevelUpPanel newValue)
        /// </summary>
        /// <param name="newValue">class LevelUpPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLevelUpPanel")]
        ///  extern void ADD_LEVEL_UP_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddMapIcon(MapIcon newValue, MapIconType newMapIconType, GameEntity newWorldEntityLink, UnityEngine.Collider newWorldCollider)
        /// </summary>
        /// <param name="newValue">class MapIcon</param>
        /// <param name="newMapIconType">enum MapIconType</param>
        /// <param name="newWorldEntityLink">class GameEntity</param>
        /// <param name="newWorldCollider">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapIcon")]
        ///  extern void ADD_MAP_ICON (nint newValue, MapIconType newMapIconType, nint newWorldEntityLink, nint newWorldCollider);


        /// <summary>
        ///   System.Void AddMapIconCanvas(UnityEngine.Canvas newCanvas, UnityEngine.UI.CanvasScaler newCanvasScaler)
        /// </summary>
        /// <param name="newCanvas">class UnityEngine.Canvas</param>
        /// <param name="newCanvasScaler">class UnityEngine.UI.CanvasScaler</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapIconCanvas")]
        ///  extern void ADD_MAP_ICON_CANVAS (nint newCanvas, nint newCanvasScaler);


        /// <summary>
        ///   System.Void AddMapInteractionMode(MapInteractionMode newValue)
        /// </summary>
        /// <param name="newValue">enum MapInteractionMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapInteractionMode")]
        ///  extern void ADD_MAP_INTERACTION_MODE (MapInteractionMode newValue);


        /// <summary>
        ///   System.Void AddMapMarkerWorldScreenEdgeIndicator(MapScreenEdgeIndicator newValue)
        /// </summary>
        /// <param name="newValue">class MapScreenEdgeIndicator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapMarkerWorldScreenEdgeIndicator")]
        ///  extern void ADD_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR (nint newValue);


        /// <summary>
        ///   System.Void AddMapPanel(MapPanel newValue)
        /// </summary>
        /// <param name="newValue">class MapPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapPanel")]
        ///  extern void ADD_MAP_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddMapUICenterCrosshair(MapUICenterCrosshair newValue)
        /// </summary>
        /// <param name="newValue">class MapUICenterCrosshair</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapUICenterCrosshair")]
        ///  extern void ADD_MAP_UI_CENTER_CROSSHAIR (nint newValue);


        /// <summary>
        ///   System.Void AddMessagePanel(MessagePanel newValue)
        /// </summary>
        /// <param name="newValue">class MessagePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMessagePanel")]
        ///  extern void ADD_MESSAGE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddMessagePanelPromptPlayersConnectionState(MessagePanelPromptPlayersConnectionState newValue)
        /// </summary>
        /// <param name="newValue">enum MessagePanelPromptPlayersConnectionState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMessagePanelPromptPlayersConnectionState")]
        ///  extern void ADD_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE (MessagePanelPromptPlayersConnectionState newValue);


        /// <summary>
        ///   System.Void AddMessagePrompt(System.String newMessageContent)
        /// </summary>
        /// <param name="newMessageContent">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMessagePrompt")]
        ///  extern void ADD_MESSAGE_PROMPT (nint newMessageContent);


        /// <summary>
        ///   System.Void AddMouseSelectedUIButton(UIButton newValue)
        /// </summary>
        /// <param name="newValue">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMouseSelectedUIButton")]
        ///  extern void ADD_MOUSE_SELECTED_UI_BUTTON (nint newValue);


        /// <summary>
        ///   System.Void AddOptionsPanel(OptionsControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class OptionsControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOptionsPanel")]
        ///  extern void ADD_OPTIONS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerHealthHUD(ProjectStar.PlayerHealthHUD newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.PlayerHealthHUD</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerHealthHUD")]
        ///  extern void ADD_PLAYER_HEALTH_HUD (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerHUD(PlayerUICanvasBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerUICanvasBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerHUD")]
        ///  extern void ADD_PLAYER_HUD (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerPromptHUD(PlayerPromptHUD newValue)
        /// </summary>
        /// <param name="newValue">class PlayerPromptHUD</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerPromptHUD")]
        ///  extern void ADD_PLAYER_PROMPT_HUD (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerScreenEdgeIndicator(PlayerScreenEdgeIndicator newValue, System.Int32 newOwnerPlayerID)
        /// </summary>
        /// <param name="newValue">class PlayerScreenEdgeIndicator</param>
        /// <param name="newOwnerPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerScreenEdgeIndicator")]
        ///  extern void ADD_PLAYER_SCREEN_EDGE_INDICATOR (nint newValue, System.Int32 newOwnerPlayerID);


        /// <summary>
        ///   System.Void AddPlayerShipHealthUI(PlayerShipHealthUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerShipHealthUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerShipHealthUI")]
        ///  extern void ADD_PLAYER_SHIP_HEALTH_UI (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirm(System.Int32 newPlayerID, UIButton newButton, System.Boolean newIsMouseInput, System.Boolean newDenied)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <param name="newDenied">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirm")]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM (System.Int32 newPlayerID, nint newButton, System.Boolean newIsMouseInput, System.Boolean newDenied);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmHeld(System.Int32 newPlayerID, UIButton newButton)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirmHeld")]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD (System.Int32 newPlayerID, nint newButton);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelection(System.Int32 newPlayerID, UIButton newButton, System.Boolean newIsMouseInput)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelection")]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECTION (System.Int32 newPlayerID, nint newButton, System.Boolean newIsMouseInput);


        /// <summary>
        ///   System.Void AddPositionAttach(UnityEngine.Transform newTarget, UnityEngine.Vector3 newOffset)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newOffset">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPositionAttach")]
        ///  extern void ADD_POSITION_ATTACH (nint newTarget, UnityEngine.Vector3 newOffset);


        /// <summary>
        ///   System.Void AddQuestCompletePanel(QuestCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestCompletePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddQuestCompletePanel")]
        ///  extern void ADD_QUEST_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddQuestItemAwardPanel(QuestItemAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestItemAwardPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddQuestItemAwardPanel")]
        ///  extern void ADD_QUEST_ITEM_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddQuestTitlePanel(QuestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddQuestTitlePanel")]
        ///  extern void ADD_QUEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddRectTransform(UnityEngine.RectTransform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.RectTransform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRectTransform")]
        ///  extern void ADD_RECT_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void AddReviveBar(ProjectStar.HealthBarView newHealthBarView)
        /// </summary>
        /// <param name="newHealthBarView">class ProjectStar.HealthBarView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddReviveBar")]
        ///  extern void ADD_REVIVE_BAR (nint newHealthBarView);


        /// <summary>
        ///   System.Void AddSaveLoadPanel(SaveLoadPanel newValue)
        /// </summary>
        /// <param name="newValue">class SaveLoadPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSaveLoadPanel")]
        ///  extern void ADD_SAVE_LOAD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddSaveNotifierHUD(SaveNotifierHUDBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class SaveNotifierHUDBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSaveNotifierHUD")]
        ///  extern void ADD_SAVE_NOTIFIER_HUD (nint newValue);


        /// <summary>
        ///   System.Void AddScaleCache(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddScaleCache")]
        ///  extern void ADD_SCALE_CACHE (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void AddScreenDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddScreenDialogueCanvas")]
        ///  extern void ADD_SCREEN_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddSelectionConfirmHeldTickCompleteEvent(UIButton newTargetBtn)
        /// </summary>
        /// <param name="newTargetBtn">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSelectionConfirmHeldTickCompleteEvent")]
        ///  extern void ADD_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT (nint newTargetBtn);


        /// <summary>
        ///   System.Void AddSplashTitleBackground(TitleBackgroundReference newValue)
        /// </summary>
        /// <param name="newValue">class TitleBackgroundReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSplashTitleBackground")]
        ///  extern void ADD_SPLASH_TITLE_BACKGROUND (nint newValue);


        /// <summary>
        ///   System.Void AddTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimer")]
        ///  extern void ADD_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void AddToggleInventoryCommand(System.Int32 newPlayerID, GenericTabType newDirectTypeEntry)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newDirectTypeEntry">enum GenericTabType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddToggleInventoryCommand")]
        ///  extern void ADD_TOGGLE_INVENTORY_COMMAND (System.Int32 newPlayerID, GenericTabType newDirectTypeEntry);


        /// <summary>
        ///   System.Void AddTutorialPanel(TutorialPanel newValue)
        /// </summary>
        /// <param name="newValue">class TutorialPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTutorialPanel")]
        ///  extern void ADD_TUTORIAL_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddUIButtonHeldConfirmedNormalizedSample(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIButtonHeldConfirmedNormalizedSample")]
        ///  extern void ADD_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE (System.Single newValue);


        /// <summary>
        ///   System.Void AddUIButtonLegend(UIButtonLegend newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonLegend</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIButtonLegend")]
        ///  extern void ADD_UI_BUTTON_LEGEND (nint newValue);


        /// <summary>
        ///   System.Void AddUIButtonMouseEvents(UIButtonMouseEventRelays newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonMouseEventRelays</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIButtonMouseEvents")]
        ///  extern void ADD_UI_BUTTON_MOUSE_EVENTS (nint newValue);


        /// <summary>
        ///   System.Void AddUICommand(System.Boolean newNegativeInput, System.Int32 newInputTypeID, GameEntity newPlayer, System.Boolean newIsMouseInput, System.Boolean newRepeating)
        /// </summary>
        /// <param name="newNegativeInput">struct System.Boolean</param>
        /// <param name="newInputTypeID">struct System.Int32</param>
        /// <param name="newPlayer">class GameEntity</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <param name="newRepeating">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommand")]
        ///  extern void ADD_UI_COMMAND (System.Boolean newNegativeInput, System.Int32 newInputTypeID, nint newPlayer, System.Boolean newIsMouseInput, System.Boolean newRepeating);


        /// <summary>
        ///   System.Void AddUICommandRelayEvent(UICommandRelayEvent newValue)
        /// </summary>
        /// <param name="newValue">class UICommandRelayEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandRelayEvent")]
        ///  extern void ADD_UI_COMMAND_RELAY_EVENT (nint newValue);


        /// <summary>
        ///   System.Void AddUICommandReleased(System.Int32 newInputTypeID, GameEntity newPlayer, System.Boolean newIsMouseInput)
        /// </summary>
        /// <param name="newInputTypeID">struct System.Int32</param>
        /// <param name="newPlayer">class GameEntity</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandReleased")]
        ///  extern void ADD_UI_COMMAND_RELEASED (System.Int32 newInputTypeID, nint newPlayer, System.Boolean newIsMouseInput);


        /// <summary>
        ///   System.Void AddUIControllerPanelExitEvent(UIControllerPanel newPanel)
        /// </summary>
        /// <param name="newPanel">class UIControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIControllerPanelExitEvent")]
        ///  extern void ADD_UI_CONTROLLER_PANEL_EXIT_EVENT (nint newPanel);


        /// <summary>
        ///   System.Void AddUIInventoryPanelCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIInventoryPanelCanvas")]
        ///  extern void ADD_UI_INVENTORY_PANEL_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddUIInventoryTabLink(UITabBtn newTabBtn)
        /// </summary>
        /// <param name="newTabBtn">class UITabBtn</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIInventoryTabLink")]
        ///  extern void ADD_UI_INVENTORY_TAB_LINK (nint newTabBtn);


        /// <summary>
        ///   System.Void AddUIIsAnimatingPanel(UIInventorySubPanel newValue)
        /// </summary>
        /// <param name="newValue">class UIInventorySubPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIIsAnimatingPanel")]
        ///  extern void ADD_UI_IS_ANIMATING_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddUIPanelBaseView(UIPanelBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelBaseView")]
        ///  extern void ADD_UI_PANEL_BASE_VIEW (nint newValue);


        /// <summary>
        ///   System.Void AddUIPanelDisplayStatus(System.Boolean newIsShowing)
        /// </summary>
        /// <param name="newIsShowing">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelDisplayStatus")]
        ///  extern void ADD_UI_PANEL_DISPLAY_STATUS (System.Boolean newIsShowing);


        /// <summary>
        ///   System.Void AddUIPanelFixed(UIPanelFixedType newPanelType, UIPanelFixedData newPanel)
        /// </summary>
        /// <param name="newPanelType">enum UIPanelFixedType</param>
        /// <param name="newPanel">class UIPanelFixedData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelFixed")]
        ///  extern void ADD_UI_PANEL_FIXED (UIPanelFixedType newPanelType, nint newPanel);


        /// <summary>
        ///   System.Void AddUIPanelRootCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelRootCanvas")]
        ///  extern void ADD_UI_PANEL_ROOT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddUIPanelShowInputState(InputState newState, UIPanelBase newPanel)
        /// </summary>
        /// <param name="newState">enum InputState</param>
        /// <param name="newPanel">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelShowInputState")]
        ///  extern void ADD_UI_PANEL_SHOW_INPUT_STATE (InputState newState, nint newPanel);


        /// <summary>
        ///   System.Void AddUIPanelUnderlayMask(UIPanelUnderlayMask newMask)
        /// </summary>
        /// <param name="newMask">class UIPanelUnderlayMask</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelUnderlayMask")]
        ///  extern void ADD_UI_PANEL_UNDERLAY_MASK (nint newMask);


        /// <summary>
        ///   System.Void AddUITabBtn(UITabBtn newValue)
        /// </summary>
        /// <param name="newValue">class UITabBtn</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUITabBtn")]
        ///  extern void ADD_UI_TAB_BTN (nint newValue);


        /// <summary>
        ///   System.Void AddUITooltip(UITooltip newValue, System.Int32 newPlayerID)
        /// </summary>
        /// <param name="newValue">class UITooltip</param>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUITooltip")]
        ///  extern void ADD_UI_TOOLTIP (nint newValue, System.Int32 newPlayerID);


        /// <summary>
        ///   System.Void AddUpgradePanel(UpgradePanel newValue, UpgradePanel.UpgradePanelType newUpgradePanelType)
        /// </summary>
        /// <param name="newValue">class UpgradePanel</param>
        /// <param name="newUpgradePanelType">enum UpgradePanel.UpgradePanelType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUpgradePanel")]
        ///  extern void ADD_UPGRADE_PANEL (nint newValue, UpgradePanel.UpgradePanelType newUpgradePanelType);


        /// <summary>
        ///   System.Void AddVideoSubtitles(VideoSubtitlesBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class VideoSubtitlesBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddVideoSubtitles")]
        ///  extern void ADD_VIDEO_SUBTITLES (nint newValue);


        /// <summary>
        ///   System.Void AddWorldDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDialogueCanvas")]
        ///  extern void ADD_WORLD_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddWorldDialogueFocusPanel(WorldDialogueFocusPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldDialogueFocusPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDialogueFocusPanel")]
        ///  extern void ADD_WORLD_DIALOGUE_FOCUS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddWorldDialogueMessageQueue(GameEntity newSpeakerEntity, WorldDialoguePanel newDialoguePanel, DialogueInfo newNextMessage, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newSpeakerEntity">class GameEntity</param>
        /// <param name="newDialoguePanel">class WorldDialoguePanel</param>
        /// <param name="newNextMessage">class DialogueInfo</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDialogueMessageQueue")]
        ///  extern void ADD_WORLD_DIALOGUE_MESSAGE_QUEUE (nint newSpeakerEntity, nint newDialoguePanel, nint newNextMessage, nint newCompleteCallback);


        /// <summary>
        ///   System.Void AddWorldDialoguePanel(WorldDialoguePanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldDialoguePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDialoguePanel")]
        ///  extern void ADD_WORLD_DIALOGUE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddWorldEmojiPanel(WorldEmojiPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldEmojiPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldEmojiPanel")]
        ///  extern void ADD_WORLD_EMOJI_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddWorldPuzzlePieceUI(WorldPuzzlePieceUI newValue)
        /// </summary>
        /// <param name="newValue">class WorldPuzzlePieceUI</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldPuzzlePieceUI")]
        ///  extern void ADD_WORLD_PUZZLE_PIECE_UI (nint newValue);


        /// <summary>
        ///   System.Void AddWorldPuzzlePieceUIOwner(GameEntity newPuzzleAnswerEntity, GameEntity newPuzzlePieceEntity)
        /// </summary>
        /// <param name="newPuzzleAnswerEntity">class GameEntity</param>
        /// <param name="newPuzzlePieceEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldPuzzlePieceUIOwner")]
        ///  extern void ADD_WORLD_PUZZLE_PIECE_UI_OWNER (nint newPuzzleAnswerEntity, nint newPuzzlePieceEntity);


        /// <summary>
        ///   System.Void AddWorldTextCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldTextCanvas")]
        ///  extern void ADD_WORLD_TEXT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void AddWorldTextSplashPanel(WorldUITextSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldUITextSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldTextSplashPanel")]
        ///  extern void ADD_WORLD_TEXT_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void AddWorldUIButtonView(WorldUIButton newValue)
        /// </summary>
        /// <param name="newValue">class WorldUIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldUIButtonView")]
        ///  extern void ADD_WORLD_UI_BUTTON_VIEW (nint newValue);


        /// <summary>
        ///   Entitas.ContextInfo createDefaultContextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
        ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();


        /// <summary>
        ///   System.Void Destroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy")]
        ///  extern void DESTROY ();


        /// <summary>
        ///   Entitas.IAERC get_aerc()
        /// </summary>
        /// <returns>interface Entitas.IAERC</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aerc")]
        ///  extern nint GET_AERC ();


        /// <summary>
        ///   AttachedCombatAgentComponent get_attachedCombatAgent()
        /// </summary>
        /// <returns>class AttachedCombatAgentComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attachedCombatAgent")]
        ///  extern nint GET_ATTACHED_COMBAT_AGENT ();


        /// <summary>
        ///   AttachOwnerEntityComponent get_attachOwnerEntity()
        /// </summary>
        /// <returns>class AttachOwnerEntityComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attachOwnerEntity")]
        ///  extern nint GET_ATTACH_OWNER_ENTITY ();


        /// <summary>
        ///   ButtonHeldFillComponent get_buttonHeldFill()
        /// </summary>
        /// <returns>class ButtonHeldFillComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_buttonHeldFill")]
        ///  extern nint GET_BUTTON_HELD_FILL ();


        /// <summary>
        ///   CallToActionPreorderPanelComponent get_callToActionPreorderPanel()
        /// </summary>
        /// <returns>class CallToActionPreorderPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_callToActionPreorderPanel")]
        ///  extern nint GET_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   CameraPresetScaleDisplayRootComponent get_cameraPresetScaleDisplayRoot()
        /// </summary>
        /// <returns>class CameraPresetScaleDisplayRootComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cameraPresetScaleDisplayRoot")]
        ///  extern nint GET_CAMERA_PRESET_SCALE_DISPLAY_ROOT ();


        /// <summary>
        ///   CanvasComponent get_canvas()
        /// </summary>
        /// <returns>class CanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_canvas")]
        ///  extern nint GET_CANVAS ();


        /// <summary>
        ///   ChestTitlePanelComponent get_chestTitlePanel()
        /// </summary>
        /// <returns>class ChestTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestTitlePanel")]
        ///  extern nint GET_CHEST_TITLE_PANEL ();


        /// <summary>
        ///   CombatLogComponent get_combatLog()
        /// </summary>
        /// <returns>class CombatLogComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_combatLog")]
        ///  extern nint GET_COMBAT_LOG ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
        /// </summary>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
        ///  extern nint GET_COMPONENT_POOLS ();


        /// <summary>
        ///   ConfirmationPanelComponent get_confirmationPanel()
        /// </summary>
        /// <returns>class ConfirmationPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_confirmationPanel")]
        ///  extern nint GET_CONFIRMATION_PANEL ();


        /// <summary>
        ///   Entitas.ContextInfo get_contextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
        ///  extern nint GET_CONTEXT_INFO ();


        /// <summary>
        ///   System.Int32 get_creationIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creationIndex")]
        ///  extern System.Int32 GET_CREATION_INDEX ();


        /// <summary>
        ///   CreditsPanelComponent get_creditsPanel()
        /// </summary>
        /// <returns>class CreditsPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creditsPanel")]
        ///  extern nint GET_CREDITS_PANEL ();


        /// <summary>
        ///   CrystalUIComponent get_crystalUI()
        /// </summary>
        /// <returns>class CrystalUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_crystalUI")]
        ///  extern nint GET_CRYSTAL_UI ();


        /// <summary>
        ///   DenyInteractionUIComponent get_denyInteractionUI()
        /// </summary>
        /// <returns>class DenyInteractionUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_denyInteractionUI")]
        ///  extern nint GET_DENY_INTERACTION_UI ();


        /// <summary>
        ///   DialogueChoiceComponent get_dialogueChoice()
        /// </summary>
        /// <returns>class DialogueChoiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dialogueChoice")]
        ///  extern nint GET_DIALOGUE_CHOICE ();


        /// <summary>
        ///   DungeonCompletePanelComponent get_dungeonCompletePanel()
        /// </summary>
        /// <returns>class DungeonCompletePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dungeonCompletePanel")]
        ///  extern nint GET_DUNGEON_COMPLETE_PANEL ();


        /// <summary>
        ///   EndGameSplashPanelComponent get_endGameSplashPanel()
        /// </summary>
        /// <returns>class EndGameSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_endGameSplashPanel")]
        ///  extern nint GET_END_GAME_SPLASH_PANEL ();


        /// <summary>
        ///   EquipmentAwardPanelComponent get_equipmentAwardPanel()
        /// </summary>
        /// <returns>class EquipmentAwardPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentAwardPanel")]
        ///  extern nint GET_EQUIPMENT_AWARD_PANEL ();


        /// <summary>
        ///   ExpBarUIComponent get_expBarUI()
        /// </summary>
        /// <returns>class ExpBarUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_expBarUI")]
        ///  extern nint GET_EXP_BAR_UI ();


        /// <summary>
        ///   FullScreenDialogueFocusPanelComponent get_fullScreenDialogueFocusPanel()
        /// </summary>
        /// <returns>class FullScreenDialogueFocusPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenDialogueFocusPanel")]
        ///  extern nint GET_FULL_SCREEN_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   FullScreenImageSplashPanelComponent get_fullScreenImageSplashPanel()
        /// </summary>
        /// <returns>class FullScreenImageSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenImageSplashPanel")]
        ///  extern nint GET_FULL_SCREEN_IMAGE_SPLASH_PANEL ();


        /// <summary>
        ///   FullScreenTextSplashPanelComponent get_fullScreenTextSplashPanel()
        /// </summary>
        /// <returns>class FullScreenTextSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenTextSplashPanel")]
        ///  extern nint GET_FULL_SCREEN_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   GameEntityIdComponent get_gameEntityId()
        /// </summary>
        /// <returns>class GameEntityIdComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameEntityId")]
        ///  extern nint GET_GAME_ENTITY_ID ();


        /// <summary>
        ///   GameEntityRefComponent get_gameEntityRef()
        /// </summary>
        /// <returns>class GameEntityRefComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameEntityRef")]
        ///  extern nint GET_GAME_ENTITY_REF ();


        /// <summary>
        ///   GameOverPanelComponent get_gameOverPanel()
        /// </summary>
        /// <returns>class GameOverPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverPanel")]
        ///  extern nint GET_GAME_OVER_PANEL ();


        /// <summary>
        ///   GoldUIComponent get_goldUI()
        /// </summary>
        /// <returns>class GoldUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_goldUI")]
        ///  extern nint GET_GOLD_UI ();


        /// <summary>
        ///   GUIDestroyedListenerComponent get_gUIDestroyedListener()
        /// </summary>
        /// <returns>class GUIDestroyedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gUIDestroyedListener")]
        ///  extern nint GET_G_UI_DESTROYED_LISTENER ();


        /// <summary>
        ///   GunAmmoUIComponent get_gunAmmoUI()
        /// </summary>
        /// <returns>class GunAmmoUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gunAmmoUI")]
        ///  extern nint GET_GUN_AMMO_UI ();


        /// <summary>
        ///   System.Boolean get_hasAttachedCombatAgent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttachedCombatAgent")]
        ///  extern System.Boolean GET_HAS_ATTACHED_COMBAT_AGENT ();


        /// <summary>
        ///   System.Boolean get_hasAttachOwnerEntity()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAttachOwnerEntity")]
        ///  extern System.Boolean GET_HAS_ATTACH_OWNER_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasButtonHeldFill()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasButtonHeldFill")]
        ///  extern System.Boolean GET_HAS_BUTTON_HELD_FILL ();


        /// <summary>
        ///   System.Boolean get_hasCallToActionPreorderPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCallToActionPreorderPanel")]
        ///  extern System.Boolean GET_HAS_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasCameraPresetScaleDisplayRoot()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCameraPresetScaleDisplayRoot")]
        ///  extern System.Boolean GET_HAS_CAMERA_PRESET_SCALE_DISPLAY_ROOT ();


        /// <summary>
        ///   System.Boolean get_hasCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCanvas")]
        ///  extern System.Boolean GET_HAS_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasChestTitlePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChestTitlePanel")]
        ///  extern System.Boolean GET_HAS_CHEST_TITLE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasCombatLog()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCombatLog")]
        ///  extern System.Boolean GET_HAS_COMBAT_LOG ();


        /// <summary>
        ///   System.Boolean get_hasConfirmationPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasConfirmationPanel")]
        ///  extern System.Boolean GET_HAS_CONFIRMATION_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasCreditsPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCreditsPanel")]
        ///  extern System.Boolean GET_HAS_CREDITS_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasCrystalUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCrystalUI")]
        ///  extern System.Boolean GET_HAS_CRYSTAL_UI ();


        /// <summary>
        ///   System.Boolean get_hasDenyInteractionUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDenyInteractionUI")]
        ///  extern System.Boolean GET_HAS_DENY_INTERACTION_UI ();


        /// <summary>
        ///   System.Boolean get_hasDialogueChoice()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDialogueChoice")]
        ///  extern System.Boolean GET_HAS_DIALOGUE_CHOICE ();


        /// <summary>
        ///   System.Boolean get_hasDungeonCompletePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDungeonCompletePanel")]
        ///  extern System.Boolean GET_HAS_DUNGEON_COMPLETE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasEndGameSplashPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEndGameSplashPanel")]
        ///  extern System.Boolean GET_HAS_END_GAME_SPLASH_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasEquipmentAwardPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquipmentAwardPanel")]
        ///  extern System.Boolean GET_HAS_EQUIPMENT_AWARD_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasExpBarUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasExpBarUI")]
        ///  extern System.Boolean GET_HAS_EXP_BAR_UI ();


        /// <summary>
        ///   System.Boolean get_hasFullScreenDialogueFocusPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFullScreenDialogueFocusPanel")]
        ///  extern System.Boolean GET_HAS_FULL_SCREEN_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasFullScreenImageSplashPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFullScreenImageSplashPanel")]
        ///  extern System.Boolean GET_HAS_FULL_SCREEN_IMAGE_SPLASH_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasFullScreenTextSplashPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFullScreenTextSplashPanel")]
        ///  extern System.Boolean GET_HAS_FULL_SCREEN_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasGameEntityId()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameEntityId")]
        ///  extern System.Boolean GET_HAS_GAME_ENTITY_ID ();


        /// <summary>
        ///   System.Boolean get_hasGameEntityRef()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameEntityRef")]
        ///  extern System.Boolean GET_HAS_GAME_ENTITY_REF ();


        /// <summary>
        ///   System.Boolean get_hasGameOverPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameOverPanel")]
        ///  extern System.Boolean GET_HAS_GAME_OVER_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasGoldUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGoldUI")]
        ///  extern System.Boolean GET_HAS_GOLD_UI ();


        /// <summary>
        ///   System.Boolean get_hasGUIDestroyedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGUIDestroyedListener")]
        ///  extern System.Boolean GET_HAS_GUI_DESTROYED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasGunAmmoUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGunAmmoUI")]
        ///  extern System.Boolean GET_HAS_GUN_AMMO_UI ();


        /// <summary>
        ///   System.Boolean get_hasHealthBarView()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasHealthBarView")]
        ///  extern System.Boolean GET_HAS_HEALTH_BAR_VIEW ();


        /// <summary>
        ///   System.Boolean get_hasInfinityTowerProgressPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInfinityTowerProgressPanel")]
        ///  extern System.Boolean GET_HAS_INFINITY_TOWER_PROGRESS_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasInstanceTitlePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInstanceTitlePanel")]
        ///  extern System.Boolean GET_HAS_INSTANCE_TITLE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasInventoryItemPreviewState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryItemPreviewState")]
        ///  extern System.Boolean GET_HAS_INVENTORY_ITEM_PREVIEW_STATE ();


        /// <summary>
        ///   System.Boolean get_hasInventoryPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryPanel")]
        ///  extern System.Boolean GET_HAS_INVENTORY_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasInventoryPickupUIController()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryPickupUIController")]
        ///  extern System.Boolean GET_HAS_INVENTORY_PICKUP_UI_CONTROLLER ();


        /// <summary>
        ///   System.Boolean get_hasInventoryUser()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryUser")]
        ///  extern System.Boolean GET_HAS_INVENTORY_USER ();


        /// <summary>
        ///   System.Boolean get_hasLanguagePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLanguagePanel")]
        ///  extern System.Boolean GET_HAS_LANGUAGE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasLastSelectedUIButtonInfo()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastSelectedUIButtonInfo")]
        ///  extern System.Boolean GET_HAS_LAST_SELECTED_UI_BUTTON_INFO ();


        /// <summary>
        ///   System.Boolean get_hasLevelUpPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLevelUpPanel")]
        ///  extern System.Boolean GET_HAS_LEVEL_UP_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasMapIcon()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapIcon")]
        ///  extern System.Boolean GET_HAS_MAP_ICON ();


        /// <summary>
        ///   System.Boolean get_hasMapIconCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapIconCanvas")]
        ///  extern System.Boolean GET_HAS_MAP_ICON_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasMapInteractionMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapInteractionMode")]
        ///  extern System.Boolean GET_HAS_MAP_INTERACTION_MODE ();


        /// <summary>
        ///   System.Boolean get_hasMapMarkerWorldScreenEdgeIndicator()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapMarkerWorldScreenEdgeIndicator")]
        ///  extern System.Boolean GET_HAS_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   System.Boolean get_hasMapPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapPanel")]
        ///  extern System.Boolean GET_HAS_MAP_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasMapUICenterCrosshair()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapUICenterCrosshair")]
        ///  extern System.Boolean GET_HAS_MAP_UI_CENTER_CROSSHAIR ();


        /// <summary>
        ///   System.Boolean get_hasMessagePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMessagePanel")]
        ///  extern System.Boolean GET_HAS_MESSAGE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasMessagePanelPromptPlayersConnectionState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMessagePanelPromptPlayersConnectionState")]
        ///  extern System.Boolean GET_HAS_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE ();


        /// <summary>
        ///   System.Boolean get_hasMessagePrompt()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMessagePrompt")]
        ///  extern System.Boolean GET_HAS_MESSAGE_PROMPT ();


        /// <summary>
        ///   System.Boolean get_hasMouseSelectedUIButton()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMouseSelectedUIButton")]
        ///  extern System.Boolean GET_HAS_MOUSE_SELECTED_UI_BUTTON ();


        /// <summary>
        ///   System.Boolean get_hasOptionsPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOptionsPanel")]
        ///  extern System.Boolean GET_HAS_OPTIONS_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasPlayerHealthHUD()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerHealthHUD")]
        ///  extern System.Boolean GET_HAS_PLAYER_HEALTH_HUD ();


        /// <summary>
        ///   System.Boolean get_hasPlayerHUD()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerHUD")]
        ///  extern System.Boolean GET_HAS_PLAYER_HUD ();


        /// <summary>
        ///   System.Boolean get_hasPlayerPromptHUD()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerPromptHUD")]
        ///  extern System.Boolean GET_HAS_PLAYER_PROMPT_HUD ();


        /// <summary>
        ///   System.Boolean get_hasPlayerScreenEdgeIndicator()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerScreenEdgeIndicator")]
        ///  extern System.Boolean GET_HAS_PLAYER_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   System.Boolean get_hasPlayerShipHealthUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerShipHealthUI")]
        ///  extern System.Boolean GET_HAS_PLAYER_SHIP_HEALTH_UI ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelectConfirm()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelectConfirm")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECT_CONFIRM ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelectConfirmHeld()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelectConfirmHeld")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelectConfirmHeldListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelectConfirmHeldListener")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelectConfirmListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelectConfirmListener")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelection")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECTION ();


        /// <summary>
        ///   System.Boolean get_hasPlayerUIButtonSelectionListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerUIButtonSelectionListener")]
        ///  extern System.Boolean GET_HAS_PLAYER_UI_BUTTON_SELECTION_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasPositionAttach()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPositionAttach")]
        ///  extern System.Boolean GET_HAS_POSITION_ATTACH ();


        /// <summary>
        ///   System.Boolean get_hasQuestCompletePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasQuestCompletePanel")]
        ///  extern System.Boolean GET_HAS_QUEST_COMPLETE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasQuestItemAwardPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasQuestItemAwardPanel")]
        ///  extern System.Boolean GET_HAS_QUEST_ITEM_AWARD_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasQuestTitlePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasQuestTitlePanel")]
        ///  extern System.Boolean GET_HAS_QUEST_TITLE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasRectTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRectTransform")]
        ///  extern System.Boolean GET_HAS_RECT_TRANSFORM ();


        /// <summary>
        ///   System.Boolean get_hasReviveBar()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasReviveBar")]
        ///  extern System.Boolean GET_HAS_REVIVE_BAR ();


        /// <summary>
        ///   System.Boolean get_hasSaveLoadPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSaveLoadPanel")]
        ///  extern System.Boolean GET_HAS_SAVE_LOAD_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasSaveNotifierHUD()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSaveNotifierHUD")]
        ///  extern System.Boolean GET_HAS_SAVE_NOTIFIER_HUD ();


        /// <summary>
        ///   System.Boolean get_hasScaleCache()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasScaleCache")]
        ///  extern System.Boolean GET_HAS_SCALE_CACHE ();


        /// <summary>
        ///   System.Boolean get_hasScreenDialogueCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasScreenDialogueCanvas")]
        ///  extern System.Boolean GET_HAS_SCREEN_DIALOGUE_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasSelectionConfirmHeldTickCompleteEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSelectionConfirmHeldTickCompleteEvent")]
        ///  extern System.Boolean GET_HAS_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasSplashTitleBackground()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSplashTitleBackground")]
        ///  extern System.Boolean GET_HAS_SPLASH_TITLE_BACKGROUND ();


        /// <summary>
        ///   System.Boolean get_hasTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimer")]
        ///  extern System.Boolean GET_HAS_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasToggleInventoryCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasToggleInventoryCommand")]
        ///  extern System.Boolean GET_HAS_TOGGLE_INVENTORY_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasTutorialPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTutorialPanel")]
        ///  extern System.Boolean GET_HAS_TUTORIAL_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasUIButtonHeldConfirmedNormalizedSample()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIButtonHeldConfirmedNormalizedSample")]
        ///  extern System.Boolean GET_HAS_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE ();


        /// <summary>
        ///   System.Boolean get_hasUIButtonHeldConfirmedNormalizedSampleListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIButtonHeldConfirmedNormalizedSampleListener")]
        ///  extern System.Boolean GET_HAS_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasUIButtonLegend()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIButtonLegend")]
        ///  extern System.Boolean GET_HAS_UI_BUTTON_LEGEND ();


        /// <summary>
        ///   System.Boolean get_hasUIButtonMouseEvents()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIButtonMouseEvents")]
        ///  extern System.Boolean GET_HAS_UI_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   System.Boolean get_hasUICommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommand")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasUICommandListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommandListener")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasUICommandRelayEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommandRelayEvent")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND_RELAY_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasUICommandReleased()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommandReleased")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND_RELEASED ();


        /// <summary>
        ///   System.Boolean get_hasUICommandReleasedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommandReleasedListener")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND_RELEASED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasUIControllerPanelExitEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIControllerPanelExitEvent")]
        ///  extern System.Boolean GET_HAS_UI_CONTROLLER_PANEL_EXIT_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasUIInventoryPanelCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIInventoryPanelCanvas")]
        ///  extern System.Boolean GET_HAS_UI_INVENTORY_PANEL_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasUIInventoryTabLink()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIInventoryTabLink")]
        ///  extern System.Boolean GET_HAS_UI_INVENTORY_TAB_LINK ();


        /// <summary>
        ///   System.Boolean get_hasUIInventoryTabLinkListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIInventoryTabLinkListener")]
        ///  extern System.Boolean GET_HAS_UI_INVENTORY_TAB_LINK_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasUIIsAnimatingPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIIsAnimatingPanel")]
        ///  extern System.Boolean GET_HAS_UI_IS_ANIMATING_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelBaseView()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelBaseView")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_BASE_VIEW ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelDisplayStatus()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelDisplayStatus")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_DISPLAY_STATUS ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelDisplayStatusListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelDisplayStatusListener")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_DISPLAY_STATUS_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelFixed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelFixed")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_FIXED ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelRootCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelRootCanvas")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelShowInputState()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelShowInputState")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_SHOW_INPUT_STATE ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelUnderlayMask()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelUnderlayMask")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_UNDERLAY_MASK ();


        /// <summary>
        ///   System.Boolean get_hasUITabBtn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUITabBtn")]
        ///  extern System.Boolean GET_HAS_UI_TAB_BTN ();


        /// <summary>
        ///   System.Boolean get_hasUITooltip()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUITooltip")]
        ///  extern System.Boolean GET_HAS_UI_TOOLTIP ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GUIEntity))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GUIEntity))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void AddGUIDestroyedListener(System.Collections.Generic.List<IGUIDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGUIDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGUIDestroyedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_GUI_DESTROYED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddGUIDestroyedListener(IGUIDestroyedListener value)
        /// </summary>
        /// <param name="value">interface IGUIDestroyedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGUIDestroyedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_GUI_DESTROYED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmHeldListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirmHeldListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmHeldListener(IPlayerUIButtonSelectConfirmHeldListener value)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectConfirmHeldListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirmHeldListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirmListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmListener(IPlayerUIButtonSelectConfirmListener value)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectConfirmListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectConfirmListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectionListener(System.Collections.Generic.List<IPlayerUIButtonSelectionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectionListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECTION_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectionListener(IPlayerUIButtonSelectionListener value)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectionListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPlayerUIButtonSelectionListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_PLAYER_UI_BUTTON_SELECTION_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddUIButtonHeldConfirmedNormalizedSampleListener(System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIButtonHeldConfirmedNormalizedSampleListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUIButtonHeldConfirmedNormalizedSampleListener(IUIButtonHeldConfirmedNormalizedSampleListener value)
        /// </summary>
        /// <param name="value">interface IUIButtonHeldConfirmedNormalizedSampleListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIButtonHeldConfirmedNormalizedSampleListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddUICommandListener(System.Collections.Generic.List<IUICommandListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUICommandListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_COMMAND_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUICommandListener(IUICommandListener value)
        /// </summary>
        /// <param name="value">interface IUICommandListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_COMMAND_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddUICommandReleasedListener(System.Collections.Generic.List<IUICommandReleasedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUICommandReleasedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandReleasedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_COMMAND_RELEASED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUICommandReleasedListener(IUICommandReleasedListener value)
        /// </summary>
        /// <param name="value">interface IUICommandReleasedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUICommandReleasedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_COMMAND_RELEASED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddUIInventoryTabLinkListener(System.Collections.Generic.List<IUIInventoryTabLinkListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIInventoryTabLinkListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIInventoryTabLinkListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_INVENTORY_TAB_LINK_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUIInventoryTabLinkListener(IUIInventoryTabLinkListener value)
        /// </summary>
        /// <param name="value">interface IUIInventoryTabLinkListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIInventoryTabLinkListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_INVENTORY_TAB_LINK_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddUIPanelDisplayStatusListener(System.Collections.Generic.List<IUIPanelDisplayStatusListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIPanelDisplayStatusListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelDisplayStatusListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_PANEL_DISPLAY_STATUS_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddUIPanelDisplayStatusListener(IUIPanelDisplayStatusListener value)
        /// </summary>
        /// <param name="value">interface IUIPanelDisplayStatusListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUIPanelDisplayStatusListener", Search = typeof(Search_GUIEntity))]
        ///  extern void ADD_UI_PANEL_DISPLAY_STATUS_LISTENER_01 (nint value);


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GUIEntity))]
        ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GUIEntity))]
        ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);


        /// public static partial class Search_GUIEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGUIDestroyedListener(System.Collections.Generic.List<IGUIDestroyedListener> newValue)
        /// </summary>
        /// public static bool ADD_GUI_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGUIDestroyedListener", "System.Collections.Generic.List<IGUIDestroyedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddGUIDestroyedListener(IGUIDestroyedListener value)
        /// </summary>
        /// public static bool ADD_GUI_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGUIDestroyedListener", "IGUIDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmHeldListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener> newValue)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectConfirmHeldListener", "System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmHeldListener(IPlayerUIButtonSelectConfirmHeldListener value)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectConfirmHeldListener", "IPlayerUIButtonSelectConfirmHeldListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener> newValue)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectConfirmListener", "System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectConfirmListener(IPlayerUIButtonSelectConfirmListener value)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectConfirmListener", "IPlayerUIButtonSelectConfirmListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectionListener(System.Collections.Generic.List<IPlayerUIButtonSelectionListener> newValue)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECTION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectionListener", "System.Collections.Generic.List<IPlayerUIButtonSelectionListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddPlayerUIButtonSelectionListener(IPlayerUIButtonSelectionListener value)
        /// </summary>
        /// public static bool ADD_PLAYER_UI_BUTTON_SELECTION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddPlayerUIButtonSelectionListener", "IPlayerUIButtonSelectionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIButtonHeldConfirmedNormalizedSampleListener(System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener> newValue)
        /// </summary>
        /// public static bool ADD_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIButtonHeldConfirmedNormalizedSampleListener", "System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIButtonHeldConfirmedNormalizedSampleListener(IUIButtonHeldConfirmedNormalizedSampleListener value)
        /// </summary>
        /// public static bool ADD_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIButtonHeldConfirmedNormalizedSampleListener", "IUIButtonHeldConfirmedNormalizedSampleListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUICommandListener(System.Collections.Generic.List<IUICommandListener> newValue)
        /// </summary>
        /// public static bool ADD_UI_COMMAND_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUICommandListener", "System.Collections.Generic.List<IUICommandListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUICommandListener(IUICommandListener value)
        /// </summary>
        /// public static bool ADD_UI_COMMAND_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUICommandListener", "IUICommandListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUICommandReleasedListener(System.Collections.Generic.List<IUICommandReleasedListener> newValue)
        /// </summary>
        /// public static bool ADD_UI_COMMAND_RELEASED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUICommandReleasedListener", "System.Collections.Generic.List<IUICommandReleasedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUICommandReleasedListener(IUICommandReleasedListener value)
        /// </summary>
        /// public static bool ADD_UI_COMMAND_RELEASED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUICommandReleasedListener", "IUICommandReleasedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIInventoryTabLinkListener(System.Collections.Generic.List<IUIInventoryTabLinkListener> newValue)
        /// </summary>
        /// public static bool ADD_UI_INVENTORY_TAB_LINK_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIInventoryTabLinkListener", "System.Collections.Generic.List<IUIInventoryTabLinkListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIInventoryTabLinkListener(IUIInventoryTabLinkListener value)
        /// </summary>
        /// public static bool ADD_UI_INVENTORY_TAB_LINK_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIInventoryTabLinkListener", "IUIInventoryTabLinkListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIPanelDisplayStatusListener(System.Collections.Generic.List<IUIPanelDisplayStatusListener> newValue)
        /// </summary>
        /// public static bool ADD_UI_PANEL_DISPLAY_STATUS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIPanelDisplayStatusListener", "System.Collections.Generic.List<IUIPanelDisplayStatusListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddUIPanelDisplayStatusListener(IUIPanelDisplayStatusListener value)
        /// </summary>
        /// public static bool ADD_UI_PANEL_DISPLAY_STATUS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddUIPanelDisplayStatusListener", "IUIPanelDisplayStatusListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// public static bool CREATE_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// public static bool CREATE_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIEntity"]
    /// </summary>
    public partial class GUIEntity
    {



        /// <summary>
        ///   System.Boolean get_hasUpgradePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUpgradePanel")]
        ///  extern System.Boolean GET_HAS_UPGRADE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasVideoSubtitles()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasVideoSubtitles")]
        ///  extern System.Boolean GET_HAS_VIDEO_SUBTITLES ();


        /// <summary>
        ///   System.Boolean get_hasWorldDialogueCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldDialogueCanvas")]
        ///  extern System.Boolean GET_HAS_WORLD_DIALOGUE_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasWorldDialogueFocusPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldDialogueFocusPanel")]
        ///  extern System.Boolean GET_HAS_WORLD_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasWorldDialogueMessageQueue()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldDialogueMessageQueue")]
        ///  extern System.Boolean GET_HAS_WORLD_DIALOGUE_MESSAGE_QUEUE ();


        /// <summary>
        ///   System.Boolean get_hasWorldDialoguePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldDialoguePanel")]
        ///  extern System.Boolean GET_HAS_WORLD_DIALOGUE_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasWorldEmojiPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldEmojiPanel")]
        ///  extern System.Boolean GET_HAS_WORLD_EMOJI_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasWorldPuzzlePieceUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldPuzzlePieceUI")]
        ///  extern System.Boolean GET_HAS_WORLD_PUZZLE_PIECE_UI ();


        /// <summary>
        ///   System.Boolean get_hasWorldPuzzlePieceUIOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldPuzzlePieceUIOwner")]
        ///  extern System.Boolean GET_HAS_WORLD_PUZZLE_PIECE_UI_OWNER ();


        /// <summary>
        ///   System.Boolean get_hasWorldTextCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldTextCanvas")]
        ///  extern System.Boolean GET_HAS_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasWorldTextSplashPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldTextSplashPanel")]
        ///  extern System.Boolean GET_HAS_WORLD_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasWorldUIButtonView()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldUIButtonView")]
        ///  extern System.Boolean GET_HAS_WORLD_UI_BUTTON_VIEW ();


        /// <summary>
        ///   HealthBarViewComponent get_healthBarView()
        /// </summary>
        /// <returns>class HealthBarViewComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healthBarView")]
        ///  extern nint GET_HEALTH_BAR_VIEW ();


        /// <summary>
        ///   InfinityTowerProgressPanelComponent get_infinityTowerProgressPanel()
        /// </summary>
        /// <returns>class InfinityTowerProgressPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerProgressPanel")]
        ///  extern nint GET_INFINITY_TOWER_PROGRESS_PANEL ();


        /// <summary>
        ///   InstanceTitlePanelComponent get_instanceTitlePanel()
        /// </summary>
        /// <returns>class InstanceTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_instanceTitlePanel")]
        ///  extern nint GET_INSTANCE_TITLE_PANEL ();


        /// <summary>
        ///   InventoryItemPreviewStateComponent get_inventoryItemPreviewState()
        /// </summary>
        /// <returns>class InventoryItemPreviewStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryItemPreviewState")]
        ///  extern nint GET_INVENTORY_ITEM_PREVIEW_STATE ();


        /// <summary>
        ///   InventoryPanelComponent get_inventoryPanel()
        /// </summary>
        /// <returns>class InventoryPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPanel")]
        ///  extern nint GET_INVENTORY_PANEL ();


        /// <summary>
        ///   InventoryPickupUIControllerComponent get_inventoryPickupUIController()
        /// </summary>
        /// <returns>class InventoryPickupUIControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPickupUIController")]
        ///  extern nint GET_INVENTORY_PICKUP_UI_CONTROLLER ();


        /// <summary>
        ///   InventoryUserComponent get_inventoryUser()
        /// </summary>
        /// <returns>class InventoryUserComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryUser")]
        ///  extern nint GET_INVENTORY_USER ();


        /// <summary>
        ///   System.Boolean get_isAttackTellCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAttackTellCanvas")]
        ///  extern System.Boolean GET_IS_ATTACK_TELL_CANVAS ();


        /// <summary>
        ///   System.Boolean get_isDestroyed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyed")]
        ///  extern System.Boolean GET_IS_DESTROYED ();


        /// <summary>
        ///   System.Boolean get_isEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnabled")]
        ///  extern System.Boolean GET_IS_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isHasOverlappingNavigationTrackers()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHasOverlappingNavigationTrackers")]
        ///  extern System.Boolean GET_IS_HAS_OVERLAPPING_NAVIGATION_TRACKERS ();


        /// <summary>
        ///   System.Boolean get_isHealthBarCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHealthBarCanvas")]
        ///  extern System.Boolean GET_IS_HEALTH_BAR_CANVAS ();


        /// <summary>
        ///   System.Boolean get_isHideMessagePrompt()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHideMessagePrompt")]
        ///  extern System.Boolean GET_IS_HIDE_MESSAGE_PROMPT ();


        /// <summary>
        ///   System.Boolean get_isInactive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInactive")]
        ///  extern System.Boolean GET_IS_INACTIVE ();


        /// <summary>
        ///   System.Boolean get_isLevelUpWorldUISplash()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isLevelUpWorldUISplash")]
        ///  extern System.Boolean GET_IS_LEVEL_UP_WORLD_UI_SPLASH ();


        /// <summary>
        ///   System.Boolean get_isMapInteractionControllerDetected()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMapInteractionControllerDetected")]
        ///  extern System.Boolean GET_IS_MAP_INTERACTION_CONTROLLER_DETECTED ();


        /// <summary>
        ///   System.Boolean get_isMapPanelInteractableFocusZoneTouchActive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMapPanelInteractableFocusZoneTouchActive")]
        ///  extern System.Boolean GET_IS_MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE ();


        /// <summary>
        ///   System.Boolean get_isMapUIRestoringConfiner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMapUIRestoringConfiner")]
        ///  extern System.Boolean GET_IS_MAP_UI_RESTORING_CONFINER ();


        /// <summary>
        ///   System.Boolean get_isPlayerIndicator()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerIndicator")]
        ///  extern System.Boolean GET_IS_PLAYER_INDICATOR ();


        /// <summary>
        ///   System.Boolean get_isScreenEffectCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isScreenEffectCanvas")]
        ///  extern System.Boolean GET_IS_SCREEN_EFFECT_CANVAS ();


        /// <summary>
        ///   System.Boolean get_isShipInteriorPrompt()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipInteriorPrompt")]
        ///  extern System.Boolean GET_IS_SHIP_INTERIOR_PROMPT ();


        /// <summary>
        ///   System.Boolean get_isShowPlayerShipUIEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShowPlayerShipUIEvent")]
        ///  extern System.Boolean GET_IS_SHOW_PLAYER_SHIP_UI_EVENT ();


        /// <summary>
        ///   System.Boolean get_isSinglePlayerUIInteractionMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSinglePlayerUIInteractionMode")]
        ///  extern System.Boolean GET_IS_SINGLE_PLAYER_UI_INTERACTION_MODE ();


        /// <summary>
        ///   System.Boolean get_isUICommandOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUICommandOwner")]
        ///  extern System.Boolean GET_IS_UI_COMMAND_OWNER ();


        /// <summary>
        ///   System.Boolean get_isUIEquipmentUpgradeLevelUpEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUIEquipmentUpgradeLevelUpEvent")]
        ///  extern System.Boolean GET_IS_UI_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT ();


        /// <summary>
        ///   System.Boolean get_isUIEquipmentUpgradeLockBreakLevelUpEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUIEquipmentUpgradeLockBreakLevelUpEvent")]
        ///  extern System.Boolean GET_IS_UI_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT ();


        /// <summary>
        ///   System.Boolean get_isUIInputBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUIInputBlocked")]
        ///  extern System.Boolean GET_IS_UI_INPUT_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isUIInputMouseBlocked()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUIInputMouseBlocked")]
        ///  extern System.Boolean GET_IS_UI_INPUT_MOUSE_BLOCKED ();


        /// <summary>
        ///   System.Boolean get_isUIMouseInteractionMode()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isUIMouseInteractionMode")]
        ///  extern System.Boolean GET_IS_UI_MOUSE_INTERACTION_MODE ();


        /// <summary>
        ///   System.Boolean get_isWorldAnchor()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isWorldAnchor")]
        ///  extern System.Boolean GET_IS_WORLD_ANCHOR ();


        /// <summary>
        ///   System.Boolean get_isWorldCanvasOrientateCam()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isWorldCanvasOrientateCam")]
        ///  extern System.Boolean GET_IS_WORLD_CANVAS_ORIENTATE_CAM ();


        /// <summary>
        ///   LanguagePanelComponent get_languagePanel()
        /// </summary>
        /// <returns>class LanguagePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_languagePanel")]
        ///  extern nint GET_LANGUAGE_PANEL ();


        /// <summary>
        ///   LastSelectedUIButtonInfoComponent get_lastSelectedUIButtonInfo()
        /// </summary>
        /// <returns>class LastSelectedUIButtonInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastSelectedUIButtonInfo")]
        ///  extern nint GET_LAST_SELECTED_UI_BUTTON_INFO ();


        /// <summary>
        ///   LevelUpPanelComponent get_levelUpPanel()
        /// </summary>
        /// <returns>class LevelUpPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_levelUpPanel")]
        ///  extern nint GET_LEVEL_UP_PANEL ();


        /// <summary>
        ///   MapIconComponent get_mapIcon()
        /// </summary>
        /// <returns>class MapIconComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIcon")]
        ///  extern nint GET_MAP_ICON ();


        /// <summary>
        ///   MapIconCanvasComponent get_mapIconCanvas()
        /// </summary>
        /// <returns>class MapIconCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconCanvas")]
        ///  extern nint GET_MAP_ICON_CANVAS ();


        /// <summary>
        ///   MapInteractionModeComponent get_mapInteractionMode()
        /// </summary>
        /// <returns>class MapInteractionModeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapInteractionMode")]
        ///  extern nint GET_MAP_INTERACTION_MODE ();


        /// <summary>
        ///   MapMarkerWorldScreenEdgeIndicatorComponent get_mapMarkerWorldScreenEdgeIndicator()
        /// </summary>
        /// <returns>class MapMarkerWorldScreenEdgeIndicatorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapMarkerWorldScreenEdgeIndicator")]
        ///  extern nint GET_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   MapPanelComponent get_mapPanel()
        /// </summary>
        /// <returns>class MapPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapPanel")]
        ///  extern nint GET_MAP_PANEL ();


        /// <summary>
        ///   MapUICenterCrosshairComponent get_mapUICenterCrosshair()
        /// </summary>
        /// <returns>class MapUICenterCrosshairComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUICenterCrosshair")]
        ///  extern nint GET_MAP_UI_CENTER_CROSSHAIR ();


        /// <summary>
        ///   MessagePanelComponent get_messagePanel()
        /// </summary>
        /// <returns>class MessagePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanel")]
        ///  extern nint GET_MESSAGE_PANEL ();


        /// <summary>
        ///   MessagePanelPromptPlayersConnectionStateComponent get_messagePanelPromptPlayersConnectionState()
        /// </summary>
        /// <returns>class MessagePanelPromptPlayersConnectionStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanelPromptPlayersConnectionState")]
        ///  extern nint GET_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE ();


        /// <summary>
        ///   MessagePromptComponent get_messagePrompt()
        /// </summary>
        /// <returns>class MessagePromptComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePrompt")]
        ///  extern nint GET_MESSAGE_PROMPT ();


        /// <summary>
        ///   MouseSelectedUIButtonComponent get_mouseSelectedUIButton()
        /// </summary>
        /// <returns>class MouseSelectedUIButtonComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mouseSelectedUIButton")]
        ///  extern nint GET_MOUSE_SELECTED_UI_BUTTON ();


        /// <summary>
        ///   OptionsPanelComponent get_optionsPanel()
        /// </summary>
        /// <returns>class OptionsPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_optionsPanel")]
        ///  extern nint GET_OPTIONS_PANEL ();


        /// <summary>
        ///   PlayerHealthHUDComponent get_playerHealthHUD()
        /// </summary>
        /// <returns>class PlayerHealthHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerHealthHUD")]
        ///  extern nint GET_PLAYER_HEALTH_HUD ();


        /// <summary>
        ///   PlayerHUDComponent get_playerHUD()
        /// </summary>
        /// <returns>class PlayerHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerHUD")]
        ///  extern nint GET_PLAYER_HUD ();


        /// <summary>
        ///   PlayerPromptHUDComponent get_playerPromptHUD()
        /// </summary>
        /// <returns>class PlayerPromptHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerPromptHUD")]
        ///  extern nint GET_PLAYER_PROMPT_HUD ();


        /// <summary>
        ///   PlayerScreenEdgeIndicatorComponent get_playerScreenEdgeIndicator()
        /// </summary>
        /// <returns>class PlayerScreenEdgeIndicatorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerScreenEdgeIndicator")]
        ///  extern nint GET_PLAYER_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   PlayerShipHealthUIComponent get_playerShipHealthUI()
        /// </summary>
        /// <returns>class PlayerShipHealthUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerShipHealthUI")]
        ///  extern nint GET_PLAYER_SHIP_HEALTH_UI ();


        /// <summary>
        ///   PlayerUIButtonSelectConfirmComponent get_playerUIButtonSelectConfirm()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectConfirmComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelectConfirm")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM ();


        /// <summary>
        ///   PlayerUIButtonSelectConfirmHeldComponent get_playerUIButtonSelectConfirmHeld()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectConfirmHeldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelectConfirmHeld")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD ();


        /// <summary>
        ///   PlayerUIButtonSelectConfirmHeldListenerComponent get_playerUIButtonSelectConfirmHeldListener()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectConfirmHeldListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelectConfirmHeldListener")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER ();


        /// <summary>
        ///   PlayerUIButtonSelectConfirmListenerComponent get_playerUIButtonSelectConfirmListener()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectConfirmListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelectConfirmListener")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER ();


        /// <summary>
        ///   PlayerUIButtonSelectionComponent get_playerUIButtonSelection()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectionComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelection")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECTION ();


        /// <summary>
        ///   PlayerUIButtonSelectionListenerComponent get_playerUIButtonSelectionListener()
        /// </summary>
        /// <returns>class PlayerUIButtonSelectionListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerUIButtonSelectionListener")]
        ///  extern nint GET_PLAYER_UI_BUTTON_SELECTION_LISTENER ();


        /// <summary>
        ///   PositionAttachComponent get_positionAttach()
        /// </summary>
        /// <returns>class PositionAttachComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_positionAttach")]
        ///  extern nint GET_POSITION_ATTACH ();


        /// <summary>
        ///   QuestCompletePanelComponent get_questCompletePanel()
        /// </summary>
        /// <returns>class QuestCompletePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questCompletePanel")]
        ///  extern nint GET_QUEST_COMPLETE_PANEL ();


        /// <summary>
        ///   QuestItemAwardPanelComponent get_questItemAwardPanel()
        /// </summary>
        /// <returns>class QuestItemAwardPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questItemAwardPanel")]
        ///  extern nint GET_QUEST_ITEM_AWARD_PANEL ();


        /// <summary>
        ///   QuestTitlePanelComponent get_questTitlePanel()
        /// </summary>
        /// <returns>class QuestTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questTitlePanel")]
        ///  extern nint GET_QUEST_TITLE_PANEL ();


        /// <summary>
        ///   RectTransformComponent get_rectTransform()
        /// </summary>
        /// <returns>class RectTransformComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rectTransform")]
        ///  extern nint GET_RECT_TRANSFORM ();


        /// <summary>
        ///   System.Int32 get_retainCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
        ///  extern System.Int32 GET_RETAIN_COUNT ();


        /// <summary>
        ///   ReviveBarComponent get_reviveBar()
        /// </summary>
        /// <returns>class ReviveBarComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reviveBar")]
        ///  extern nint GET_REVIVE_BAR ();


        /// <summary>
        ///   SaveLoadPanelComponent get_saveLoadPanel()
        /// </summary>
        /// <returns>class SaveLoadPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveLoadPanel")]
        ///  extern nint GET_SAVE_LOAD_PANEL ();


        /// <summary>
        ///   SaveNotifierHUDComponent get_saveNotifierHUD()
        /// </summary>
        /// <returns>class SaveNotifierHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveNotifierHUD")]
        ///  extern nint GET_SAVE_NOTIFIER_HUD ();


        /// <summary>
        ///   ScaleCacheComponent get_scaleCache()
        /// </summary>
        /// <returns>class ScaleCacheComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_scaleCache")]
        ///  extern nint GET_SCALE_CACHE ();


        /// <summary>
        ///   ScreenDialogueCanvasComponent get_screenDialogueCanvas()
        /// </summary>
        /// <returns>class ScreenDialogueCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenDialogueCanvas")]
        ///  extern nint GET_SCREEN_DIALOGUE_CANVAS ();


        /// <summary>
        ///   SelectionConfirmHeldTickCompleteEventComponent get_selectionConfirmHeldTickCompleteEvent()
        /// </summary>
        /// <returns>class SelectionConfirmHeldTickCompleteEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectionConfirmHeldTickCompleteEvent")]
        ///  extern nint GET_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT ();


        /// <summary>
        ///   SplashTitleBackgroundComponent get_splashTitleBackground()
        /// </summary>
        /// <returns>class SplashTitleBackgroundComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_splashTitleBackground")]
        ///  extern nint GET_SPLASH_TITLE_BACKGROUND ();


        /// <summary>
        ///   TimerComponent get_timer()
        /// </summary>
        /// <returns>class TimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timer")]
        ///  extern nint GET_TIMER ();


        /// <summary>
        ///   ToggleInventoryCommandComponent get_toggleInventoryCommand()
        /// </summary>
        /// <returns>class ToggleInventoryCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_toggleInventoryCommand")]
        ///  extern nint GET_TOGGLE_INVENTORY_COMMAND ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   TutorialPanelComponent get_tutorialPanel()
        /// </summary>
        /// <returns>class TutorialPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tutorialPanel")]
        ///  extern nint GET_TUTORIAL_PANEL ();


        /// <summary>
        ///   UIButtonHeldConfirmedNormalizedSampleComponent get_uIButtonHeldConfirmedNormalizedSample()
        /// </summary>
        /// <returns>class UIButtonHeldConfirmedNormalizedSampleComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonHeldConfirmedNormalizedSample")]
        ///  extern nint GET_U_I_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE ();


        /// <summary>
        ///   UIButtonHeldConfirmedNormalizedSampleListenerComponent get_uIButtonHeldConfirmedNormalizedSampleListener()
        /// </summary>
        /// <returns>class UIButtonHeldConfirmedNormalizedSampleListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonHeldConfirmedNormalizedSampleListener")]
        ///  extern nint GET_U_I_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER ();


        /// <summary>
        ///   UIButtonLegendComponent get_uIButtonLegend()
        /// </summary>
        /// <returns>class UIButtonLegendComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonLegend")]
        ///  extern nint GET_U_I_BUTTON_LEGEND ();


        /// <summary>
        ///   UIButtonMouseEventsComponent get_uIButtonMouseEvents()
        /// </summary>
        /// <returns>class UIButtonMouseEventsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonMouseEvents")]
        ///  extern nint GET_U_I_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   UICommandComponent get_uICommand()
        /// </summary>
        /// <returns>class UICommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommand")]
        ///  extern nint GET_U_I_COMMAND ();


        /// <summary>
        ///   UICommandListenerComponent get_uICommandListener()
        /// </summary>
        /// <returns>class UICommandListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandListener")]
        ///  extern nint GET_U_I_COMMAND_LISTENER ();


        /// <summary>
        ///   UICommandRelayEventComponent get_uICommandRelayEvent()
        /// </summary>
        /// <returns>class UICommandRelayEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandRelayEvent")]
        ///  extern nint GET_U_I_COMMAND_RELAY_EVENT ();


        /// <summary>
        ///   UICommandReleasedComponent get_uICommandReleased()
        /// </summary>
        /// <returns>class UICommandReleasedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandReleased")]
        ///  extern nint GET_U_I_COMMAND_RELEASED ();


        /// <summary>
        ///   UICommandReleasedListenerComponent get_uICommandReleasedListener()
        /// </summary>
        /// <returns>class UICommandReleasedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandReleasedListener")]
        ///  extern nint GET_U_I_COMMAND_RELEASED_LISTENER ();


        /// <summary>
        ///   UIControllerPanelExitEventComponent get_uIControllerPanelExitEvent()
        /// </summary>
        /// <returns>class UIControllerPanelExitEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIControllerPanelExitEvent")]
        ///  extern nint GET_U_I_CONTROLLER_PANEL_EXIT_EVENT ();


        /// <summary>
        ///   UIInventoryPanelCanvasComponent get_uIInventoryPanelCanvas()
        /// </summary>
        /// <returns>class UIInventoryPanelCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryPanelCanvas")]
        ///  extern nint GET_U_I_INVENTORY_PANEL_CANVAS ();


        /// <summary>
        ///   UIInventoryTabLink get_uIInventoryTabLink()
        /// </summary>
        /// <returns>class UIInventoryTabLink</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryTabLink")]
        ///  extern nint GET_U_I_INVENTORY_TAB_LINK ();


        /// <summary>
        ///   UIInventoryTabLinkListenerComponent get_uIInventoryTabLinkListener()
        /// </summary>
        /// <returns>class UIInventoryTabLinkListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryTabLinkListener")]
        ///  extern nint GET_U_I_INVENTORY_TAB_LINK_LISTENER ();


        /// <summary>
        ///   UIIsAnimatingPanelComponent get_uIIsAnimatingPanel()
        /// </summary>
        /// <returns>class UIIsAnimatingPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIIsAnimatingPanel")]
        ///  extern nint GET_U_I_IS_ANIMATING_PANEL ();


        /// <summary>
        ///   UIPanelBaseViewComponent get_uIPanelBaseView()
        /// </summary>
        /// <returns>class UIPanelBaseViewComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelBaseView")]
        ///  extern nint GET_U_I_PANEL_BASE_VIEW ();


        /// <summary>
        ///   UIPanelDisplayStatusComponent get_uIPanelDisplayStatus()
        /// </summary>
        /// <returns>class UIPanelDisplayStatusComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelDisplayStatus", CallConvs = [typeof(CallConvCdecl)])]
        extern UIPanelDisplayStatusComponent.Ptr_UIPanelDisplayStatusComponent GET_U_I_PANEL_DISPLAY_STATUS();


        /// <summary>
        ///   UIPanelDisplayStatusListenerComponent get_uIPanelDisplayStatusListener()
        /// </summary>
        /// <returns>class UIPanelDisplayStatusListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelDisplayStatusListener")]
        ///  extern nint GET_U_I_PANEL_DISPLAY_STATUS_LISTENER ();


        /// <summary>
        ///   UIPanelFixedComponent get_uIPanelFixed()
        /// </summary>
        /// <returns>class UIPanelFixedComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelFixed")]
        ///  extern nint GET_U_I_PANEL_FIXED ();


        /// <summary>
        ///   UIPanelRootCanvasComponent get_uIPanelRootCanvas()
        /// </summary>
        /// <returns>class UIPanelRootCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelRootCanvas")]
        ///  extern nint GET_U_I_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   UIPanelShowInputStateComponent get_uIPanelShowInputState()
        /// </summary>
        /// <returns>class UIPanelShowInputStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelShowInputState")]
        ///  extern nint GET_U_I_PANEL_SHOW_INPUT_STATE ();


        /// <summary>
        ///   UIPanelUnderlayMaskComponent get_uIPanelUnderlayMask()
        /// </summary>
        /// <returns>class UIPanelUnderlayMaskComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelUnderlayMask")]
        ///  extern nint GET_U_I_PANEL_UNDERLAY_MASK ();


        /// <summary>
        ///   UITabBtnComponent get_uITabBtn()
        /// </summary>
        /// <returns>class UITabBtnComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uITabBtn")]
        ///  extern nint GET_U_I_TAB_BTN ();


        /// <summary>
        ///   UITooltipComponent get_uITooltip()
        /// </summary>
        /// <returns>class UITooltipComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uITooltip")]
        ///  extern nint GET_U_I_TOOLTIP ();


        /// <summary>
        ///   UpgradePanelComponent get_upgradePanel()
        /// </summary>
        /// <returns>class UpgradePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_upgradePanel")]
        ///  extern nint GET_UPGRADE_PANEL ();


        /// <summary>
        ///   VideoSubtitlesComponent get_videoSubtitles()
        /// </summary>
        /// <returns>class VideoSubtitlesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_videoSubtitles")]
        ///  extern nint GET_VIDEO_SUBTITLES ();


        /// <summary>
        ///   WorldDialogueCanvasComponent get_worldDialogueCanvas()
        /// </summary>
        /// <returns>class WorldDialogueCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialogueCanvas")]
        ///  extern nint GET_WORLD_DIALOGUE_CANVAS ();


        /// <summary>
        ///   WorldDialogueFocusPanelComponent get_worldDialogueFocusPanel()
        /// </summary>
        /// <returns>class WorldDialogueFocusPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialogueFocusPanel")]
        ///  extern nint GET_WORLD_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   WorldDialogueMessageQueueComponent get_worldDialogueMessageQueue()
        /// </summary>
        /// <returns>class WorldDialogueMessageQueueComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialogueMessageQueue")]
        ///  extern nint GET_WORLD_DIALOGUE_MESSAGE_QUEUE ();


        /// <summary>
        ///   WorldDialoguePanelComponent get_worldDialoguePanel()
        /// </summary>
        /// <returns>class WorldDialoguePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialoguePanel")]
        ///  extern nint GET_WORLD_DIALOGUE_PANEL ();


        /// <summary>
        ///   WorldEmojiPanelComponent get_worldEmojiPanel()
        /// </summary>
        /// <returns>class WorldEmojiPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldEmojiPanel")]
        ///  extern nint GET_WORLD_EMOJI_PANEL ();


        /// <summary>
        ///   WorldPuzzlePieceUIComponent get_worldPuzzlePieceUI()
        /// </summary>
        /// <returns>class WorldPuzzlePieceUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldPuzzlePieceUI")]
        ///  extern nint GET_WORLD_PUZZLE_PIECE_UI ();


        /// <summary>
        ///   WorldPuzzlePieceUIOwner get_worldPuzzlePieceUIOwner()
        /// </summary>
        /// <returns>class WorldPuzzlePieceUIOwner</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldPuzzlePieceUIOwner")]
        ///  extern nint GET_WORLD_PUZZLE_PIECE_UI_OWNER ();


        /// <summary>
        ///   WorldTextCanvasComponent get_worldTextCanvas()
        /// </summary>
        /// <returns>class WorldTextCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldTextCanvas")]
        ///  extern nint GET_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   WorldTextSplashPanelComponent get_worldTextSplashPanel()
        /// </summary>
        /// <returns>class WorldTextSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldTextSplashPanel")]
        ///  extern nint GET_WORLD_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   WorldUIButtonViewComponent get_worldUIButtonView()
        /// </summary>
        /// <returns>class WorldUIButtonViewComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldUIButtonView")]
        ///  extern nint GET_WORLD_UI_BUTTON_VIEW ();


        /// <summary>
        ///   Entitas.IComponent GetComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent")]
        ///  extern nint GET_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Int32[] GetComponentIndices()
        /// </summary>
        /// <returns>class System.Int32[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentIndices")]
        ///  extern nint GET_COMPONENT_INDICES ();


        /// <summary>
        ///   System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentPool")]
        ///  extern nint GET_COMPONENT_POOL (System.Int32 index);


        /// <summary>
        ///   Entitas.IComponent[] GetComponents()
        /// </summary>
        /// <returns>class Entitas.IComponent[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents")]
        ///  extern nint GET_COMPONENTS ();


        /// <summary>
        ///   System.Boolean HasAnyComponent(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasAnyComponent")]
        ///  extern System.Boolean HAS_ANY_COMPONENT (nint indices);


        /// <summary>
        ///   System.Boolean HasComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponent")]
        ///  extern System.Boolean HAS_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Boolean HasComponents(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponents")]
        ///  extern System.Boolean HAS_COMPONENTS (nint indices);


        /// <summary>
        ///   System.Void Initialize(System.Int32 creationIndex, System.Int32 totalComponents, System.Collections.Generic.Stack<Entitas.IComponent>[] componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="componentPools">class System.Collections.Generic.Stack<Entitas.IComponent>[]</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aerc">interface Entitas.IAERC</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
        ///  extern void INITIALIZE (System.Int32 creationIndex, System.Int32 totalComponents, nint componentPools, nint contextInfo, nint aerc);


        /// <summary>
        ///   System.Void InternalDestroy()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDestroy")]
        ///  extern void INTERNAL_DESTROY ();


        /// <summary>
        ///   System.Void Reactivate(System.Int32 creationIndex)
        /// </summary>
        /// <param name="creationIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reactivate")]
        ///  extern void REACTIVATE (System.Int32 creationIndex);


        /// <summary>
        ///   System.Void Release(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Release")]
        ///  extern void RELEASE (nint owner);


        /// <summary>
        ///   System.Void remove_OnComponentAdded(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentAdded")]
        ///  extern void REMOVE_ON_COMPONENT_ADDED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentRemoved(Entitas.EntityComponentChanged value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentRemoved")]
        ///  extern void REMOVE_ON_COMPONENT_REMOVED (nint value);


        /// <summary>
        ///   System.Void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value)
        /// </summary>
        /// <param name="value">class Entitas.EntityComponentReplaced</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentReplaced")]
        ///  extern void REMOVE_ON_COMPONENT_REPLACED (nint value);


        /// <summary>
        ///   System.Void remove_OnDestroyEntity(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDestroyEntity")]
        ///  extern void REMOVE_ON_DESTROY_ENTITY (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityReleased(Entitas.EntityEvent value)
        /// </summary>
        /// <param name="value">class Entitas.EntityEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityReleased")]
        ///  extern void REMOVE_ON_ENTITY_RELEASED (nint value);


        /// <summary>
        ///   System.Void RemoveAllComponents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllComponents")]
        ///  extern void REMOVE_ALL_COMPONENTS ();


        /// <summary>
        ///   System.Void RemoveAllOnEntityReleasedHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllOnEntityReleasedHandlers")]
        ///  extern void REMOVE_ALL_ON_ENTITY_RELEASED_HANDLERS ();


        /// <summary>
        ///   System.Void RemoveAttachedCombatAgent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttachedCombatAgent")]
        ///  extern void REMOVE_ATTACHED_COMBAT_AGENT ();


        /// <summary>
        ///   System.Void RemoveAttachOwnerEntity()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAttachOwnerEntity")]
        ///  extern void REMOVE_ATTACH_OWNER_ENTITY ();


        /// <summary>
        ///   System.Void RemoveButtonHeldFill()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveButtonHeldFill")]
        ///  extern void REMOVE_BUTTON_HELD_FILL ();


        /// <summary>
        ///   System.Void RemoveCallToActionPreorderPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCallToActionPreorderPanel")]
        ///  extern void REMOVE_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   System.Void RemoveCameraPresetScaleDisplayRoot()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCameraPresetScaleDisplayRoot")]
        ///  extern void REMOVE_CAMERA_PRESET_SCALE_DISPLAY_ROOT ();


        /// <summary>
        ///   System.Void RemoveCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCanvas")]
        ///  extern void REMOVE_CANVAS ();


        /// <summary>
        ///   System.Void RemoveChestTitlePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChestTitlePanel")]
        ///  extern void REMOVE_CHEST_TITLE_PANEL ();


        /// <summary>
        ///   System.Void RemoveCombatLog()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCombatLog")]
        ///  extern void REMOVE_COMBAT_LOG ();


        /// <summary>
        ///   System.Void RemoveComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
        ///  extern void REMOVE_COMPONENT (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveConfirmationPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveConfirmationPanel")]
        ///  extern void REMOVE_CONFIRMATION_PANEL ();


        /// <summary>
        ///   System.Void RemoveCreditsPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCreditsPanel")]
        ///  extern void REMOVE_CREDITS_PANEL ();


        /// <summary>
        ///   System.Void RemoveCrystalUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCrystalUI")]
        ///  extern void REMOVE_CRYSTAL_UI ();


        /// <summary>
        ///   System.Void RemoveDenyInteractionUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDenyInteractionUI")]
        ///  extern void REMOVE_DENY_INTERACTION_UI ();


        /// <summary>
        ///   System.Void RemoveDialogueChoice()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDialogueChoice")]
        ///  extern void REMOVE_DIALOGUE_CHOICE ();


        /// <summary>
        ///   System.Void RemoveDungeonCompletePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDungeonCompletePanel")]
        ///  extern void REMOVE_DUNGEON_COMPLETE_PANEL ();


        /// <summary>
        ///   System.Void RemoveEndGameSplashPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEndGameSplashPanel")]
        ///  extern void REMOVE_END_GAME_SPLASH_PANEL ();


        /// <summary>
        ///   System.Void RemoveEquipmentAwardPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquipmentAwardPanel")]
        ///  extern void REMOVE_EQUIPMENT_AWARD_PANEL ();


        /// <summary>
        ///   System.Void RemoveExpBarUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveExpBarUI")]
        ///  extern void REMOVE_EXP_BAR_UI ();


        /// <summary>
        ///   System.Void RemoveFullScreenDialogueFocusPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFullScreenDialogueFocusPanel")]
        ///  extern void REMOVE_FULL_SCREEN_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   System.Void RemoveFullScreenImageSplashPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFullScreenImageSplashPanel")]
        ///  extern void REMOVE_FULL_SCREEN_IMAGE_SPLASH_PANEL ();


        /// <summary>
        ///   System.Void RemoveFullScreenTextSplashPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFullScreenTextSplashPanel")]
        ///  extern void REMOVE_FULL_SCREEN_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   System.Void RemoveGameEntityId()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameEntityId")]
        ///  extern void REMOVE_GAME_ENTITY_ID ();


        /// <summary>
        ///   System.Void RemoveGameEntityRef()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameEntityRef")]
        ///  extern void REMOVE_GAME_ENTITY_REF ();


        /// <summary>
        ///   System.Void RemoveGameOverPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameOverPanel")]
        ///  extern void REMOVE_GAME_OVER_PANEL ();


        /// <summary>
        ///   System.Void RemoveGoldUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGoldUI")]
        ///  extern void REMOVE_GOLD_UI ();


        /// <summary>
        ///   System.Void RemoveGunAmmoUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGunAmmoUI")]
        ///  extern void REMOVE_GUN_AMMO_UI ();


        /// <summary>
        ///   System.Void RemoveHealthBarView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveHealthBarView")]
        ///  extern void REMOVE_HEALTH_BAR_VIEW ();


        /// <summary>
        ///   System.Void RemoveInfinityTowerProgressPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInfinityTowerProgressPanel")]
        ///  extern void REMOVE_INFINITY_TOWER_PROGRESS_PANEL ();


        /// <summary>
        ///   System.Void RemoveInstanceTitlePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInstanceTitlePanel")]
        ///  extern void REMOVE_INSTANCE_TITLE_PANEL ();


        /// <summary>
        ///   System.Void RemoveInventoryItemPreviewState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryItemPreviewState")]
        ///  extern void REMOVE_INVENTORY_ITEM_PREVIEW_STATE ();


        /// <summary>
        ///   System.Void RemoveInventoryPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryPanel")]
        ///  extern void REMOVE_INVENTORY_PANEL ();


        /// <summary>
        ///   System.Void RemoveInventoryPickupUIController()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryPickupUIController")]
        ///  extern void REMOVE_INVENTORY_PICKUP_UI_CONTROLLER ();


        /// <summary>
        ///   System.Void RemoveInventoryUser()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryUser")]
        ///  extern void REMOVE_INVENTORY_USER ();


        /// <summary>
        ///   System.Void RemoveLanguagePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLanguagePanel")]
        ///  extern void REMOVE_LANGUAGE_PANEL ();


        /// <summary>
        ///   System.Void RemoveLastSelectedUIButtonInfo()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastSelectedUIButtonInfo")]
        ///  extern void REMOVE_LAST_SELECTED_UI_BUTTON_INFO ();


        /// <summary>
        ///   System.Void RemoveLevelUpPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLevelUpPanel")]
        ///  extern void REMOVE_LEVEL_UP_PANEL ();


        /// <summary>
        ///   System.Void RemoveMapIcon()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapIcon")]
        ///  extern void REMOVE_MAP_ICON ();


        /// <summary>
        ///   System.Void RemoveMapIconCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapIconCanvas")]
        ///  extern void REMOVE_MAP_ICON_CANVAS ();


        /// <summary>
        ///   System.Void RemoveMapInteractionMode()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapInteractionMode")]
        ///  extern void REMOVE_MAP_INTERACTION_MODE ();


        /// <summary>
        ///   System.Void RemoveMapMarkerWorldScreenEdgeIndicator()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapMarkerWorldScreenEdgeIndicator")]
        ///  extern void REMOVE_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   System.Void RemoveMapPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapPanel")]
        ///  extern void REMOVE_MAP_PANEL ();


        /// <summary>
        ///   System.Void RemoveMapUICenterCrosshair()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapUICenterCrosshair")]
        ///  extern void REMOVE_MAP_UI_CENTER_CROSSHAIR ();


        /// <summary>
        ///   System.Void RemoveMessagePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMessagePanel")]
        ///  extern void REMOVE_MESSAGE_PANEL ();


        /// <summary>
        ///   System.Void RemoveMessagePanelPromptPlayersConnectionState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMessagePanelPromptPlayersConnectionState")]
        ///  extern void REMOVE_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE ();


        /// <summary>
        ///   System.Void RemoveMessagePrompt()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMessagePrompt")]
        ///  extern void REMOVE_MESSAGE_PROMPT ();


        /// <summary>
        ///   System.Void RemoveMouseSelectedUIButton()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMouseSelectedUIButton")]
        ///  extern void REMOVE_MOUSE_SELECTED_UI_BUTTON ();


        /// <summary>
        ///   System.Void RemoveOptionsPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOptionsPanel")]
        ///  extern void REMOVE_OPTIONS_PANEL ();


        /// <summary>
        ///   System.Void RemovePlayerHealthHUD()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerHealthHUD")]
        ///  extern void REMOVE_PLAYER_HEALTH_HUD ();


        /// <summary>
        ///   System.Void RemovePlayerHUD()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerHUD")]
        ///  extern void REMOVE_PLAYER_HUD ();


        /// <summary>
        ///   System.Void RemovePlayerPromptHUD()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerPromptHUD")]
        ///  extern void REMOVE_PLAYER_PROMPT_HUD ();


        /// <summary>
        ///   System.Void RemovePlayerScreenEdgeIndicator()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerScreenEdgeIndicator")]
        ///  extern void REMOVE_PLAYER_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   System.Void RemovePlayerShipHealthUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerShipHealthUI")]
        ///  extern void REMOVE_PLAYER_SHIP_HEALTH_UI ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirm()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirm")]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmHeld()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirmHeld")]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelection()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelection")]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECTION ();


        /// <summary>
        ///   System.Void RemovePositionAttach()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePositionAttach")]
        ///  extern void REMOVE_POSITION_ATTACH ();


        /// <summary>
        ///   System.Void RemoveQuestCompletePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveQuestCompletePanel")]
        ///  extern void REMOVE_QUEST_COMPLETE_PANEL ();


        /// <summary>
        ///   System.Void RemoveQuestItemAwardPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveQuestItemAwardPanel")]
        ///  extern void REMOVE_QUEST_ITEM_AWARD_PANEL ();


        /// <summary>
        ///   System.Void RemoveQuestTitlePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveQuestTitlePanel")]
        ///  extern void REMOVE_QUEST_TITLE_PANEL ();


        /// <summary>
        ///   System.Void RemoveRectTransform()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRectTransform")]
        ///  extern void REMOVE_RECT_TRANSFORM ();


        /// <summary>
        ///   System.Void RemoveReviveBar()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveReviveBar")]
        ///  extern void REMOVE_REVIVE_BAR ();


        /// <summary>
        ///   System.Void RemoveSaveLoadPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSaveLoadPanel")]
        ///  extern void REMOVE_SAVE_LOAD_PANEL ();


        /// <summary>
        ///   System.Void RemoveSaveNotifierHUD()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSaveNotifierHUD")]
        ///  extern void REMOVE_SAVE_NOTIFIER_HUD ();


        /// <summary>
        ///   System.Void RemoveScaleCache()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveScaleCache")]
        ///  extern void REMOVE_SCALE_CACHE ();


        /// <summary>
        ///   System.Void RemoveScreenDialogueCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveScreenDialogueCanvas")]
        ///  extern void REMOVE_SCREEN_DIALOGUE_CANVAS ();


        /// <summary>
        ///   System.Void RemoveSelectionConfirmHeldTickCompleteEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelectionConfirmHeldTickCompleteEvent")]
        ///  extern void REMOVE_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT ();


        /// <summary>
        ///   System.Void RemoveSplashTitleBackground()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSplashTitleBackground")]
        ///  extern void REMOVE_SPLASH_TITLE_BACKGROUND ();


        /// <summary>
        ///   System.Void RemoveTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimer")]
        ///  extern void REMOVE_TIMER ();


        /// <summary>
        ///   System.Void RemoveToggleInventoryCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveToggleInventoryCommand")]
        ///  extern void REMOVE_TOGGLE_INVENTORY_COMMAND ();


        /// <summary>
        ///   System.Void RemoveTutorialPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTutorialPanel")]
        ///  extern void REMOVE_TUTORIAL_PANEL ();


        /// <summary>
        ///   System.Void RemoveUIButtonHeldConfirmedNormalizedSample()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonHeldConfirmedNormalizedSample")]
        ///  extern void REMOVE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE ();


        /// <summary>
        ///   System.Void RemoveUIButtonLegend()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonLegend")]
        ///  extern void REMOVE_UI_BUTTON_LEGEND ();


        /// <summary>
        ///   System.Void RemoveUIButtonMouseEvents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonMouseEvents")]
        ///  extern void REMOVE_UI_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   System.Void RemoveUICommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommand")]
        ///  extern void REMOVE_UI_COMMAND ();


        /// <summary>
        ///   System.Void RemoveUICommandRelayEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandRelayEvent")]
        ///  extern void REMOVE_UI_COMMAND_RELAY_EVENT ();


        /// <summary>
        ///   System.Void RemoveUICommandReleased()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandReleased")]
        ///  extern void REMOVE_UI_COMMAND_RELEASED ();


        /// <summary>
        ///   System.Void RemoveUIControllerPanelExitEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIControllerPanelExitEvent")]
        ///  extern void REMOVE_UI_CONTROLLER_PANEL_EXIT_EVENT ();


        /// <summary>
        ///   System.Void RemoveUIInventoryPanelCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIInventoryPanelCanvas")]
        ///  extern void REMOVE_UI_INVENTORY_PANEL_CANVAS ();


        /// <summary>
        ///   System.Void RemoveUIInventoryTabLink()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIInventoryTabLink")]
        ///  extern void REMOVE_UI_INVENTORY_TAB_LINK ();


        /// <summary>
        ///   System.Void RemoveUIIsAnimatingPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIIsAnimatingPanel")]
        ///  extern void REMOVE_UI_IS_ANIMATING_PANEL ();


        /// <summary>
        ///   System.Void RemoveUIPanelBaseView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelBaseView")]
        ///  extern void REMOVE_UI_PANEL_BASE_VIEW ();


        /// <summary>
        ///   System.Void RemoveUIPanelDisplayStatus()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelDisplayStatus")]
        ///  extern void REMOVE_UI_PANEL_DISPLAY_STATUS ();


        /// <summary>
        ///   System.Void RemoveUIPanelFixed()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelFixed")]
        ///  extern void REMOVE_UI_PANEL_FIXED ();


        /// <summary>
        ///   System.Void RemoveUIPanelRootCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelRootCanvas")]
        ///  extern void REMOVE_UI_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   System.Void RemoveUIPanelShowInputState()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelShowInputState")]
        ///  extern void REMOVE_UI_PANEL_SHOW_INPUT_STATE ();


        /// <summary>
        ///   System.Void RemoveUIPanelUnderlayMask()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelUnderlayMask")]
        ///  extern void REMOVE_UI_PANEL_UNDERLAY_MASK ();


        /// <summary>
        ///   System.Void RemoveUITabBtn()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUITabBtn")]
        ///  extern void REMOVE_UI_TAB_BTN ();


        /// <summary>
        ///   System.Void RemoveUITooltip()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUITooltip")]
        ///  extern void REMOVE_UI_TOOLTIP ();


        /// <summary>
        ///   System.Void RemoveUpgradePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUpgradePanel")]
        ///  extern void REMOVE_UPGRADE_PANEL ();


        /// <summary>
        ///   System.Void RemoveVideoSubtitles()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveVideoSubtitles")]
        ///  extern void REMOVE_VIDEO_SUBTITLES ();


        /// <summary>
        ///   System.Void RemoveWorldDialogueCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDialogueCanvas")]
        ///  extern void REMOVE_WORLD_DIALOGUE_CANVAS ();


        /// <summary>
        ///   System.Void RemoveWorldDialogueFocusPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDialogueFocusPanel")]
        ///  extern void REMOVE_WORLD_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   System.Void RemoveWorldDialogueMessageQueue()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDialogueMessageQueue")]
        ///  extern void REMOVE_WORLD_DIALOGUE_MESSAGE_QUEUE ();


        /// <summary>
        ///   System.Void RemoveWorldDialoguePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDialoguePanel")]
        ///  extern void REMOVE_WORLD_DIALOGUE_PANEL ();


        /// <summary>
        ///   System.Void RemoveWorldEmojiPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldEmojiPanel")]
        ///  extern void REMOVE_WORLD_EMOJI_PANEL ();


        /// <summary>
        ///   System.Void RemoveWorldPuzzlePieceUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldPuzzlePieceUI")]
        ///  extern void REMOVE_WORLD_PUZZLE_PIECE_UI ();


        /// <summary>
        ///   System.Void RemoveWorldPuzzlePieceUIOwner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldPuzzlePieceUIOwner")]
        ///  extern void REMOVE_WORLD_PUZZLE_PIECE_UI_OWNER ();


        /// <summary>
        ///   System.Void RemoveWorldTextCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldTextCanvas")]
        ///  extern void REMOVE_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   System.Void RemoveWorldTextSplashPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldTextSplashPanel")]
        ///  extern void REMOVE_WORLD_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   System.Void RemoveWorldUIButtonView()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldUIButtonView")]
        ///  extern void REMOVE_WORLD_UI_BUTTON_VIEW ();



        /// <summary>
        ///   System.Void RemoveGUIDestroyedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGUIDestroyedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_GUI_DESTROYED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveGUIDestroyedListener(IGUIDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IGUIDestroyedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGUIDestroyedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_GUI_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmHeldListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirmHeldListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmHeldListener(IPlayerUIButtonSelectConfirmHeldListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectConfirmHeldListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirmHeldListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirmListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmListener(IPlayerUIButtonSelectConfirmListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectConfirmListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectConfirmListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectionListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectionListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECTION_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectionListener(IPlayerUIButtonSelectionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IPlayerUIButtonSelectionListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerUIButtonSelectionListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_PLAYER_UI_BUTTON_SELECTION_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveUIButtonHeldConfirmedNormalizedSampleListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonHeldConfirmedNormalizedSampleListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUIButtonHeldConfirmedNormalizedSampleListener(IUIButtonHeldConfirmedNormalizedSampleListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUIButtonHeldConfirmedNormalizedSampleListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonHeldConfirmedNormalizedSampleListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveUICommandListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_COMMAND_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUICommandListener(IUICommandListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUICommandListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_COMMAND_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveUICommandReleasedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandReleasedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_COMMAND_RELEASED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUICommandReleasedListener(IUICommandReleasedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUICommandReleasedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandReleasedListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_COMMAND_RELEASED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveUIInventoryTabLinkListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIInventoryTabLinkListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_INVENTORY_TAB_LINK_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUIInventoryTabLinkListener(IUIInventoryTabLinkListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUIInventoryTabLinkListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIInventoryTabLinkListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_INVENTORY_TAB_LINK_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveUIPanelDisplayStatusListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelDisplayStatusListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_PANEL_DISPLAY_STATUS_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveUIPanelDisplayStatusListener(IUIPanelDisplayStatusListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IUIPanelDisplayStatusListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelDisplayStatusListener", Search = typeof(Search_GUIEntity))]
        ///  extern void REMOVE_UI_PANEL_DISPLAY_STATUS_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_GUIEntity
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void RemoveGUIDestroyedListener()
        /// </summary>
        /// public static bool REMOVE_GUI_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGUIDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveGUIDestroyedListener(IGUIDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_GUI_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGUIDestroyedListener", "IGUIDestroyedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmHeldListener()
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectConfirmHeldListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmHeldListener(IPlayerUIButtonSelectConfirmHeldListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectConfirmHeldListener", "IPlayerUIButtonSelectConfirmHeldListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmListener()
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectConfirmListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectConfirmListener(IPlayerUIButtonSelectConfirmListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectConfirmListener", "IPlayerUIButtonSelectConfirmListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectionListener()
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECTION_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectionListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemovePlayerUIButtonSelectionListener(IPlayerUIButtonSelectionListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_PLAYER_UI_BUTTON_SELECTION_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemovePlayerUIButtonSelectionListener", "IPlayerUIButtonSelectionListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIButtonHeldConfirmedNormalizedSampleListener()
        /// </summary>
        /// public static bool REMOVE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIButtonHeldConfirmedNormalizedSampleListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIButtonHeldConfirmedNormalizedSampleListener(IUIButtonHeldConfirmedNormalizedSampleListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIButtonHeldConfirmedNormalizedSampleListener", "IUIButtonHeldConfirmedNormalizedSampleListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUICommandListener()
        /// </summary>
        /// public static bool REMOVE_UI_COMMAND_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUICommandListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUICommandListener(IUICommandListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UI_COMMAND_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUICommandListener", "IUICommandListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUICommandReleasedListener()
        /// </summary>
        /// public static bool REMOVE_UI_COMMAND_RELEASED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUICommandReleasedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUICommandReleasedListener(IUICommandReleasedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UI_COMMAND_RELEASED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUICommandReleasedListener", "IUICommandReleasedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIInventoryTabLinkListener()
        /// </summary>
        /// public static bool REMOVE_UI_INVENTORY_TAB_LINK_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIInventoryTabLinkListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIInventoryTabLinkListener(IUIInventoryTabLinkListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UI_INVENTORY_TAB_LINK_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIInventoryTabLinkListener", "IUIInventoryTabLinkListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIPanelDisplayStatusListener()
        /// </summary>
        /// public static bool REMOVE_UI_PANEL_DISPLAY_STATUS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIPanelDisplayStatusListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveUIPanelDisplayStatusListener(IUIPanelDisplayStatusListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_UI_PANEL_DISPLAY_STATUS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveUIPanelDisplayStatusListener", "IUIPanelDisplayStatusListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIEntity"]
    /// </summary>
    public partial class GUIEntity
    {



        /// <summary>
        ///   System.Void ReplaceAttachedCombatAgent(CombatAgent newValue)
        /// </summary>
        /// <param name="newValue">class CombatAgent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttachedCombatAgent")]
        ///  extern void REPLACE_ATTACHED_COMBAT_AGENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceAttachOwnerEntity(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAttachOwnerEntity")]
        ///  extern void REPLACE_ATTACH_OWNER_ENTITY (nint newValue);


        /// <summary>
        ///   System.Void ReplaceButtonHeldFill(UnityEngine.GameObject newTargetUI, System.Int32 newButtonTriggerID)
        /// </summary>
        /// <param name="newTargetUI">class UnityEngine.GameObject</param>
        /// <param name="newButtonTriggerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceButtonHeldFill")]
        ///  extern void REPLACE_BUTTON_HELD_FILL (nint newTargetUI, System.Int32 newButtonTriggerID);


        /// <summary>
        ///   System.Void ReplaceCallToActionPreorderPanel(UICallToActionScreenController newValue)
        /// </summary>
        /// <param name="newValue">class UICallToActionScreenController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCallToActionPreorderPanel")]
        ///  extern void REPLACE_CALL_TO_ACTION_PREORDER_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCameraPresetScaleDisplayRoot(UnityEngine.Transform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCameraPresetScaleDisplayRoot")]
        ///  extern void REPLACE_CAMERA_PRESET_SCALE_DISPLAY_ROOT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCanvas")]
        ///  extern void REPLACE_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceChestTitlePanel(ChestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class ChestTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChestTitlePanel")]
        ///  extern void REPLACE_CHEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCombatLog(CombatLog newValue)
        /// </summary>
        /// <param name="newValue">class CombatLog</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCombatLog")]
        ///  extern void REPLACE_COMBAT_LOG (nint newValue);


        /// <summary>
        ///   System.Void replaceComponent(System.Int32 index, Entitas.IComponent replacement)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="replacement">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("replaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint replacement);


        /// <summary>
        ///   System.Void ReplaceComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComponent")]
        ///  extern void REPLACE_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void ReplaceConfirmationPanel(ConfirmationPanel newValue)
        /// </summary>
        /// <param name="newValue">class ConfirmationPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceConfirmationPanel")]
        ///  extern void REPLACE_CONFIRMATION_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCreditsPanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCreditsPanel")]
        ///  extern void REPLACE_CREDITS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCrystalUI(CrystalUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class CrystalUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCrystalUI")]
        ///  extern void REPLACE_CRYSTAL_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplaceDenyInteractionUI(DenyInteractionUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class DenyInteractionUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDenyInteractionUI")]
        ///  extern void REPLACE_DENY_INTERACTION_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplaceDialogueChoice(DialogueChoiceType newValue)
        /// </summary>
        /// <param name="newValue">enum DialogueChoiceType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDialogueChoice")]
        ///  extern void REPLACE_DIALOGUE_CHOICE (DialogueChoiceType newValue);


        /// <summary>
        ///   System.Void ReplaceDungeonCompletePanel(DungeonCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class DungeonCompletePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDungeonCompletePanel")]
        ///  extern void REPLACE_DUNGEON_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEndGameSplashPanel(EndGameSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class EndGameSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEndGameSplashPanel")]
        ///  extern void REPLACE_END_GAME_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceEquipmentAwardPanel(EquipmentAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class EquipmentAwardPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquipmentAwardPanel")]
        ///  extern void REPLACE_EQUIPMENT_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceExpBarUI(ExpBarUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ExpBarUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceExpBarUI")]
        ///  extern void REPLACE_EXP_BAR_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplaceFullScreenDialogueFocusPanel(FullScreenDialogueFocusPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenDialogueFocusPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFullScreenDialogueFocusPanel")]
        ///  extern void REPLACE_FULL_SCREEN_DIALOGUE_FOCUS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceFullScreenImageSplashPanel(FullScreenImageSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenImageSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFullScreenImageSplashPanel")]
        ///  extern void REPLACE_FULL_SCREEN_IMAGE_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceFullScreenTextSplashPanel(FullScreenTextSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenTextSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFullScreenTextSplashPanel")]
        ///  extern void REPLACE_FULL_SCREEN_TEXT_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGameEntityId(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameEntityId")]
        ///  extern void REPLACE_GAME_ENTITY_ID (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceGameEntityRef(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameEntityRef")]
        ///  extern void REPLACE_GAME_ENTITY_REF (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGameOverPanel(GameOverPanel newValue)
        /// </summary>
        /// <param name="newValue">class GameOverPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameOverPanel")]
        ///  extern void REPLACE_GAME_OVER_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGoldUI(GoldUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class GoldUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGoldUI")]
        ///  extern void REPLACE_GOLD_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGUIDestroyedListener(System.Collections.Generic.List<IGUIDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IGUIDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGUIDestroyedListener")]
        ///  extern void REPLACE_GUI_DESTROYED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceGunAmmoUI(GunAmmoUI newValue, GameEntity newGunOwner)
        /// </summary>
        /// <param name="newValue">class GunAmmoUI</param>
        /// <param name="newGunOwner">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGunAmmoUI")]
        ///  extern void REPLACE_GUN_AMMO_UI (nint newValue, nint newGunOwner);


        /// <summary>
        ///   System.Void ReplaceHealthBarView(ProjectStar.HealthBarView newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.HealthBarView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceHealthBarView")]
        ///  extern void REPLACE_HEALTH_BAR_VIEW (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInfinityTowerProgressPanel(InfinityTowerProgressPanel newValue)
        /// </summary>
        /// <param name="newValue">class InfinityTowerProgressPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInfinityTowerProgressPanel")]
        ///  extern void REPLACE_INFINITY_TOWER_PROGRESS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInstanceTitlePanel(InstanceTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class InstanceTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInstanceTitlePanel")]
        ///  extern void REPLACE_INSTANCE_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInventoryItemPreviewState(GenericTabType newTabType, GenericTabType newSubCategoryTabType, System.String newGUID)
        /// </summary>
        /// <param name="newTabType">enum GenericTabType</param>
        /// <param name="newSubCategoryTabType">enum GenericTabType</param>
        /// <param name="newGUID">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryItemPreviewState")]
        ///  extern void REPLACE_INVENTORY_ITEM_PREVIEW_STATE (GenericTabType newTabType, GenericTabType newSubCategoryTabType, nint newGUID);


        /// <summary>
        ///   System.Void ReplaceInventoryPanel(UIInventoryPanel newValue)
        /// </summary>
        /// <param name="newValue">class UIInventoryPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryPanel")]
        ///  extern void REPLACE_INVENTORY_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInventoryPickupUIController(InventoryPickupUIController newValue)
        /// </summary>
        /// <param name="newValue">class InventoryPickupUIController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryPickupUIController")]
        ///  extern void REPLACE_INVENTORY_PICKUP_UI_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInventoryUser(System.Int32 newPlayerID)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryUser")]
        ///  extern void REPLACE_INVENTORY_USER (System.Int32 newPlayerID);


        /// <summary>
        ///   System.Void ReplaceLanguagePanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLanguagePanel")]
        ///  extern void REPLACE_LANGUAGE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceLastSelectedUIButtonInfo(System.Int32 newPlayerID, UIButton newValue)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newValue">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastSelectedUIButtonInfo")]
        ///  extern void REPLACE_LAST_SELECTED_UI_BUTTON_INFO (System.Int32 newPlayerID, nint newValue);


        /// <summary>
        ///   System.Void ReplaceLevelUpPanel(LevelUpPanel newValue)
        /// </summary>
        /// <param name="newValue">class LevelUpPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLevelUpPanel")]
        ///  extern void REPLACE_LEVEL_UP_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapIcon(MapIcon newValue, MapIconType newMapIconType, GameEntity newWorldEntityLink, UnityEngine.Collider newWorldCollider)
        /// </summary>
        /// <param name="newValue">class MapIcon</param>
        /// <param name="newMapIconType">enum MapIconType</param>
        /// <param name="newWorldEntityLink">class GameEntity</param>
        /// <param name="newWorldCollider">class UnityEngine.Collider</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapIcon")]
        ///  extern void REPLACE_MAP_ICON (nint newValue, MapIconType newMapIconType, nint newWorldEntityLink, nint newWorldCollider);


        /// <summary>
        ///   System.Void ReplaceMapIconCanvas(UnityEngine.Canvas newCanvas, UnityEngine.UI.CanvasScaler newCanvasScaler)
        /// </summary>
        /// <param name="newCanvas">class UnityEngine.Canvas</param>
        /// <param name="newCanvasScaler">class UnityEngine.UI.CanvasScaler</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapIconCanvas")]
        ///  extern void REPLACE_MAP_ICON_CANVAS (nint newCanvas, nint newCanvasScaler);


        /// <summary>
        ///   System.Void ReplaceMapInteractionMode(MapInteractionMode newValue)
        /// </summary>
        /// <param name="newValue">enum MapInteractionMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapInteractionMode")]
        ///  extern void REPLACE_MAP_INTERACTION_MODE (MapInteractionMode newValue);


        /// <summary>
        ///   System.Void ReplaceMapMarkerWorldScreenEdgeIndicator(MapScreenEdgeIndicator newValue)
        /// </summary>
        /// <param name="newValue">class MapScreenEdgeIndicator</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapMarkerWorldScreenEdgeIndicator")]
        ///  extern void REPLACE_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapPanel(MapPanel newValue)
        /// </summary>
        /// <param name="newValue">class MapPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapPanel")]
        ///  extern void REPLACE_MAP_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapUICenterCrosshair(MapUICenterCrosshair newValue)
        /// </summary>
        /// <param name="newValue">class MapUICenterCrosshair</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapUICenterCrosshair")]
        ///  extern void REPLACE_MAP_UI_CENTER_CROSSHAIR (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMessagePanel(MessagePanel newValue)
        /// </summary>
        /// <param name="newValue">class MessagePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMessagePanel")]
        ///  extern void REPLACE_MESSAGE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMessagePanelPromptPlayersConnectionState(MessagePanelPromptPlayersConnectionState newValue)
        /// </summary>
        /// <param name="newValue">enum MessagePanelPromptPlayersConnectionState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMessagePanelPromptPlayersConnectionState")]
        ///  extern void REPLACE_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE (MessagePanelPromptPlayersConnectionState newValue);


        /// <summary>
        ///   System.Void ReplaceMessagePrompt(System.String newMessageContent)
        /// </summary>
        /// <param name="newMessageContent">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMessagePrompt")]
        ///  extern void REPLACE_MESSAGE_PROMPT (nint newMessageContent);


        /// <summary>
        ///   System.Void ReplaceMouseSelectedUIButton(UIButton newValue)
        /// </summary>
        /// <param name="newValue">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMouseSelectedUIButton")]
        ///  extern void REPLACE_MOUSE_SELECTED_UI_BUTTON (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOptionsPanel(OptionsControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class OptionsControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOptionsPanel")]
        ///  extern void REPLACE_OPTIONS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerHealthHUD(ProjectStar.PlayerHealthHUD newValue)
        /// </summary>
        /// <param name="newValue">class ProjectStar.PlayerHealthHUD</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerHealthHUD")]
        ///  extern void REPLACE_PLAYER_HEALTH_HUD (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerHUD(PlayerUICanvasBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerUICanvasBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerHUD")]
        ///  extern void REPLACE_PLAYER_HUD (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerPromptHUD(PlayerPromptHUD newValue)
        /// </summary>
        /// <param name="newValue">class PlayerPromptHUD</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerPromptHUD")]
        ///  extern void REPLACE_PLAYER_PROMPT_HUD (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerScreenEdgeIndicator(PlayerScreenEdgeIndicator newValue, System.Int32 newOwnerPlayerID)
        /// </summary>
        /// <param name="newValue">class PlayerScreenEdgeIndicator</param>
        /// <param name="newOwnerPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerScreenEdgeIndicator")]
        ///  extern void REPLACE_PLAYER_SCREEN_EDGE_INDICATOR (nint newValue, System.Int32 newOwnerPlayerID);


        /// <summary>
        ///   System.Void ReplacePlayerShipHealthUI(PlayerShipHealthUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerShipHealthUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerShipHealthUI")]
        ///  extern void REPLACE_PLAYER_SHIP_HEALTH_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelectConfirm(System.Int32 newPlayerID, UIButton newButton, System.Boolean newIsMouseInput, System.Boolean newDenied)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <param name="newDenied">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelectConfirm")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECT_CONFIRM (System.Int32 newPlayerID, nint newButton, System.Boolean newIsMouseInput, System.Boolean newDenied);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelectConfirmHeld(System.Int32 newPlayerID, UIButton newButton)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelectConfirmHeld")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD (System.Int32 newPlayerID, nint newButton);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelectConfirmHeldListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectConfirmHeldListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelectConfirmHeldListener")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelectConfirmListener(System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectConfirmListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelectConfirmListener")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelection(System.Int32 newPlayerID, UIButton newButton, System.Boolean newIsMouseInput)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newButton">class UIButton</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelection")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECTION (System.Int32 newPlayerID, nint newButton, System.Boolean newIsMouseInput);


        /// <summary>
        ///   System.Void ReplacePlayerUIButtonSelectionListener(System.Collections.Generic.List<IPlayerUIButtonSelectionListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IPlayerUIButtonSelectionListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerUIButtonSelectionListener")]
        ///  extern void REPLACE_PLAYER_UI_BUTTON_SELECTION_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplacePositionAttach(UnityEngine.Transform newTarget, UnityEngine.Vector3 newOffset)
        /// </summary>
        /// <param name="newTarget">class UnityEngine.Transform</param>
        /// <param name="newOffset">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePositionAttach")]
        ///  extern void REPLACE_POSITION_ATTACH (nint newTarget, UnityEngine.Vector3 newOffset);


        /// <summary>
        ///   System.Void ReplaceQuestCompletePanel(QuestCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestCompletePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceQuestCompletePanel")]
        ///  extern void REPLACE_QUEST_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceQuestItemAwardPanel(QuestItemAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestItemAwardPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceQuestItemAwardPanel")]
        ///  extern void REPLACE_QUEST_ITEM_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceQuestTitlePanel(QuestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceQuestTitlePanel")]
        ///  extern void REPLACE_QUEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceRectTransform(UnityEngine.RectTransform newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.RectTransform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRectTransform")]
        ///  extern void REPLACE_RECT_TRANSFORM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceReviveBar(ProjectStar.HealthBarView newHealthBarView)
        /// </summary>
        /// <param name="newHealthBarView">class ProjectStar.HealthBarView</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceReviveBar")]
        ///  extern void REPLACE_REVIVE_BAR (nint newHealthBarView);


        /// <summary>
        ///   System.Void ReplaceSaveLoadPanel(SaveLoadPanel newValue)
        /// </summary>
        /// <param name="newValue">class SaveLoadPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSaveLoadPanel")]
        ///  extern void REPLACE_SAVE_LOAD_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSaveNotifierHUD(SaveNotifierHUDBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class SaveNotifierHUDBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSaveNotifierHUD")]
        ///  extern void REPLACE_SAVE_NOTIFIER_HUD (nint newValue);


        /// <summary>
        ///   System.Void ReplaceScaleCache(UnityEngine.Vector3 newValue)
        /// </summary>
        /// <param name="newValue">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceScaleCache")]
        ///  extern void REPLACE_SCALE_CACHE (UnityEngine.Vector3 newValue);


        /// <summary>
        ///   System.Void ReplaceScreenDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceScreenDialogueCanvas")]
        ///  extern void REPLACE_SCREEN_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSelectionConfirmHeldTickCompleteEvent(UIButton newTargetBtn)
        /// </summary>
        /// <param name="newTargetBtn">class UIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSelectionConfirmHeldTickCompleteEvent")]
        ///  extern void REPLACE_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT (nint newTargetBtn);


        /// <summary>
        ///   System.Void ReplaceSplashTitleBackground(TitleBackgroundReference newValue)
        /// </summary>
        /// <param name="newValue">class TitleBackgroundReference</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSplashTitleBackground")]
        ///  extern void REPLACE_SPLASH_TITLE_BACKGROUND (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimer")]
        ///  extern void REPLACE_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceToggleInventoryCommand(System.Int32 newPlayerID, GenericTabType newDirectTypeEntry)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newDirectTypeEntry">enum GenericTabType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceToggleInventoryCommand")]
        ///  extern void REPLACE_TOGGLE_INVENTORY_COMMAND (System.Int32 newPlayerID, GenericTabType newDirectTypeEntry);


        /// <summary>
        ///   System.Void ReplaceTutorialPanel(TutorialPanel newValue)
        /// </summary>
        /// <param name="newValue">class TutorialPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTutorialPanel")]
        ///  extern void REPLACE_TUTORIAL_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIButtonHeldConfirmedNormalizedSample(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIButtonHeldConfirmedNormalizedSample")]
        ///  extern void REPLACE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceUIButtonHeldConfirmedNormalizedSampleListener(System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIButtonHeldConfirmedNormalizedSampleListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIButtonHeldConfirmedNormalizedSampleListener")]
        ///  extern void REPLACE_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIButtonLegend(UIButtonLegend newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonLegend</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIButtonLegend")]
        ///  extern void REPLACE_UI_BUTTON_LEGEND (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIButtonMouseEvents(UIButtonMouseEventRelays newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonMouseEventRelays</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIButtonMouseEvents")]
        ///  extern void REPLACE_UI_BUTTON_MOUSE_EVENTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUICommand(System.Boolean newNegativeInput, System.Int32 newInputTypeID, GameEntity newPlayer, System.Boolean newIsMouseInput, System.Boolean newRepeating)
        /// </summary>
        /// <param name="newNegativeInput">struct System.Boolean</param>
        /// <param name="newInputTypeID">struct System.Int32</param>
        /// <param name="newPlayer">class GameEntity</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <param name="newRepeating">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommand")]
        ///  extern void REPLACE_UI_COMMAND (System.Boolean newNegativeInput, System.Int32 newInputTypeID, nint newPlayer, System.Boolean newIsMouseInput, System.Boolean newRepeating);


        /// <summary>
        ///   System.Void ReplaceUICommandListener(System.Collections.Generic.List<IUICommandListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUICommandListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommandListener")]
        ///  extern void REPLACE_UI_COMMAND_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUICommandRelayEvent(UICommandRelayEvent newValue)
        /// </summary>
        /// <param name="newValue">class UICommandRelayEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommandRelayEvent")]
        ///  extern void REPLACE_UI_COMMAND_RELAY_EVENT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUICommandReleased(System.Int32 newInputTypeID, GameEntity newPlayer, System.Boolean newIsMouseInput)
        /// </summary>
        /// <param name="newInputTypeID">struct System.Int32</param>
        /// <param name="newPlayer">class GameEntity</param>
        /// <param name="newIsMouseInput">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommandReleased")]
        ///  extern void REPLACE_UI_COMMAND_RELEASED (System.Int32 newInputTypeID, nint newPlayer, System.Boolean newIsMouseInput);


        /// <summary>
        ///   System.Void ReplaceUICommandReleasedListener(System.Collections.Generic.List<IUICommandReleasedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUICommandReleasedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommandReleasedListener")]
        ///  extern void REPLACE_UI_COMMAND_RELEASED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIControllerPanelExitEvent(UIControllerPanel newPanel)
        /// </summary>
        /// <param name="newPanel">class UIControllerPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIControllerPanelExitEvent")]
        ///  extern void REPLACE_UI_CONTROLLER_PANEL_EXIT_EVENT (nint newPanel);


        /// <summary>
        ///   System.Void ReplaceUIInventoryPanelCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIInventoryPanelCanvas")]
        ///  extern void REPLACE_UI_INVENTORY_PANEL_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIInventoryTabLink(UITabBtn newTabBtn)
        /// </summary>
        /// <param name="newTabBtn">class UITabBtn</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIInventoryTabLink")]
        ///  extern void REPLACE_UI_INVENTORY_TAB_LINK (nint newTabBtn);


        /// <summary>
        ///   System.Void ReplaceUIInventoryTabLinkListener(System.Collections.Generic.List<IUIInventoryTabLinkListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIInventoryTabLinkListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIInventoryTabLinkListener")]
        ///  extern void REPLACE_UI_INVENTORY_TAB_LINK_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIIsAnimatingPanel(UIInventorySubPanel newValue)
        /// </summary>
        /// <param name="newValue">class UIInventorySubPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIIsAnimatingPanel")]
        ///  extern void REPLACE_UI_IS_ANIMATING_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIPanelBaseView(UIPanelBase newValue)
        /// </summary>
        /// <param name="newValue">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelBaseView")]
        ///  extern void REPLACE_UI_PANEL_BASE_VIEW (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIPanelDisplayStatus(System.Boolean newIsShowing)
        /// </summary>
        /// <param name="newIsShowing">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelDisplayStatus")]
        ///  extern void REPLACE_UI_PANEL_DISPLAY_STATUS (System.Boolean newIsShowing);


        /// <summary>
        ///   System.Void ReplaceUIPanelDisplayStatusListener(System.Collections.Generic.List<IUIPanelDisplayStatusListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IUIPanelDisplayStatusListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelDisplayStatusListener")]
        ///  extern void REPLACE_UI_PANEL_DISPLAY_STATUS_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIPanelFixed(UIPanelFixedType newPanelType, UIPanelFixedData newPanel)
        /// </summary>
        /// <param name="newPanelType">enum UIPanelFixedType</param>
        /// <param name="newPanel">class UIPanelFixedData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelFixed")]
        ///  extern void REPLACE_UI_PANEL_FIXED (UIPanelFixedType newPanelType, nint newPanel);


        /// <summary>
        ///   System.Void ReplaceUIPanelRootCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelRootCanvas")]
        ///  extern void REPLACE_UI_PANEL_ROOT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIPanelShowInputState(InputState newState, UIPanelBase newPanel)
        /// </summary>
        /// <param name="newState">enum InputState</param>
        /// <param name="newPanel">abstract class UIPanelBase</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelShowInputState")]
        ///  extern void REPLACE_UI_PANEL_SHOW_INPUT_STATE (InputState newState, nint newPanel);


        /// <summary>
        ///   System.Void ReplaceUIPanelUnderlayMask(UIPanelUnderlayMask newMask)
        /// </summary>
        /// <param name="newMask">class UIPanelUnderlayMask</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelUnderlayMask")]
        ///  extern void REPLACE_UI_PANEL_UNDERLAY_MASK (nint newMask);


        /// <summary>
        ///   System.Void ReplaceUITabBtn(UITabBtn newValue)
        /// </summary>
        /// <param name="newValue">class UITabBtn</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUITabBtn")]
        ///  extern void REPLACE_UI_TAB_BTN (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUITooltip(UITooltip newValue, System.Int32 newPlayerID)
        /// </summary>
        /// <param name="newValue">class UITooltip</param>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUITooltip")]
        ///  extern void REPLACE_UI_TOOLTIP (nint newValue, System.Int32 newPlayerID);


        /// <summary>
        ///   System.Void ReplaceUpgradePanel(UpgradePanel newValue, UpgradePanel.UpgradePanelType newUpgradePanelType)
        /// </summary>
        /// <param name="newValue">class UpgradePanel</param>
        /// <param name="newUpgradePanelType">enum UpgradePanel.UpgradePanelType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUpgradePanel")]
        ///  extern void REPLACE_UPGRADE_PANEL (nint newValue, UpgradePanel.UpgradePanelType newUpgradePanelType);


        /// <summary>
        ///   System.Void ReplaceVideoSubtitles(VideoSubtitlesBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class VideoSubtitlesBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceVideoSubtitles")]
        ///  extern void REPLACE_VIDEO_SUBTITLES (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldDialogueCanvas")]
        ///  extern void REPLACE_WORLD_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldDialogueFocusPanel(WorldDialogueFocusPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldDialogueFocusPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldDialogueFocusPanel")]
        ///  extern void REPLACE_WORLD_DIALOGUE_FOCUS_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldDialogueMessageQueue(GameEntity newSpeakerEntity, WorldDialoguePanel newDialoguePanel, DialogueInfo newNextMessage, System.Action newCompleteCallback)
        /// </summary>
        /// <param name="newSpeakerEntity">class GameEntity</param>
        /// <param name="newDialoguePanel">class WorldDialoguePanel</param>
        /// <param name="newNextMessage">class DialogueInfo</param>
        /// <param name="newCompleteCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldDialogueMessageQueue")]
        ///  extern void REPLACE_WORLD_DIALOGUE_MESSAGE_QUEUE (nint newSpeakerEntity, nint newDialoguePanel, nint newNextMessage, nint newCompleteCallback);


        /// <summary>
        ///   System.Void ReplaceWorldDialoguePanel(WorldDialoguePanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldDialoguePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldDialoguePanel")]
        ///  extern void REPLACE_WORLD_DIALOGUE_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldEmojiPanel(WorldEmojiPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldEmojiPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldEmojiPanel")]
        ///  extern void REPLACE_WORLD_EMOJI_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldPuzzlePieceUI(WorldPuzzlePieceUI newValue)
        /// </summary>
        /// <param name="newValue">class WorldPuzzlePieceUI</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldPuzzlePieceUI")]
        ///  extern void REPLACE_WORLD_PUZZLE_PIECE_UI (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldPuzzlePieceUIOwner(GameEntity newPuzzleAnswerEntity, GameEntity newPuzzlePieceEntity)
        /// </summary>
        /// <param name="newPuzzleAnswerEntity">class GameEntity</param>
        /// <param name="newPuzzlePieceEntity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldPuzzlePieceUIOwner")]
        ///  extern void REPLACE_WORLD_PUZZLE_PIECE_UI_OWNER (nint newPuzzleAnswerEntity, nint newPuzzlePieceEntity);


        /// <summary>
        ///   System.Void ReplaceWorldTextCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldTextCanvas")]
        ///  extern void REPLACE_WORLD_TEXT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldTextSplashPanel(WorldUITextSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class WorldUITextSplashPanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldTextSplashPanel")]
        ///  extern void REPLACE_WORLD_TEXT_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldUIButtonView(WorldUIButton newValue)
        /// </summary>
        /// <param name="newValue">class WorldUIButton</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldUIButtonView")]
        ///  extern void REPLACE_WORLD_UI_BUTTON_VIEW (nint newValue);


        /// <summary>
        ///   System.Void Retain(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
        ///  extern void RETAIN (nint owner);


        /// <summary>
        ///   System.Void set_isAttackTellCanvas(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAttackTellCanvas")]
        ///  extern void SET_IS_ATTACK_TELL_CANVAS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDestroyed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
        ///  extern void SET_IS_DESTROYED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isHasOverlappingNavigationTrackers(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isHasOverlappingNavigationTrackers")]
        ///  extern void SET_IS_HAS_OVERLAPPING_NAVIGATION_TRACKERS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isHealthBarCanvas(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isHealthBarCanvas")]
        ///  extern void SET_IS_HEALTH_BAR_CANVAS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isHideMessagePrompt(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isHideMessagePrompt")]
        ///  extern void SET_IS_HIDE_MESSAGE_PROMPT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInactive(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInactive")]
        ///  extern void SET_IS_INACTIVE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isLevelUpWorldUISplash(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isLevelUpWorldUISplash")]
        ///  extern void SET_IS_LEVEL_UP_WORLD_UI_SPLASH (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMapInteractionControllerDetected(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMapInteractionControllerDetected")]
        ///  extern void SET_IS_MAP_INTERACTION_CONTROLLER_DETECTED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMapPanelInteractableFocusZoneTouchActive(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMapPanelInteractableFocusZoneTouchActive")]
        ///  extern void SET_IS_MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isMapUIRestoringConfiner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isMapUIRestoringConfiner")]
        ///  extern void SET_IS_MAP_UI_RESTORING_CONFINER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isPlayerIndicator(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerIndicator")]
        ///  extern void SET_IS_PLAYER_INDICATOR (System.Boolean value);


        /// <summary>
        ///   System.Void set_isScreenEffectCanvas(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isScreenEffectCanvas")]
        ///  extern void SET_IS_SCREEN_EFFECT_CANVAS (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShipInteriorPrompt(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipInteriorPrompt")]
        ///  extern void SET_IS_SHIP_INTERIOR_PROMPT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isShowPlayerShipUIEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShowPlayerShipUIEvent")]
        ///  extern void SET_IS_SHOW_PLAYER_SHIP_UI_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSinglePlayerUIInteractionMode(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSinglePlayerUIInteractionMode")]
        ///  extern void SET_IS_SINGLE_PLAYER_UI_INTERACTION_MODE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUICommandOwner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUICommandOwner")]
        ///  extern void SET_IS_UI_COMMAND_OWNER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUIEquipmentUpgradeLevelUpEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUIEquipmentUpgradeLevelUpEvent")]
        ///  extern void SET_IS_UI_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUIEquipmentUpgradeLockBreakLevelUpEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUIEquipmentUpgradeLockBreakLevelUpEvent")]
        ///  extern void SET_IS_UI_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUIInputBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUIInputBlocked")]
        ///  extern void SET_IS_UI_INPUT_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUIInputMouseBlocked(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUIInputMouseBlocked")]
        ///  extern void SET_IS_UI_INPUT_MOUSE_BLOCKED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isUIMouseInteractionMode(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isUIMouseInteractionMode")]
        ///  extern void SET_IS_UI_MOUSE_INTERACTION_MODE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isWorldAnchor(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isWorldAnchor")]
        ///  extern void SET_IS_WORLD_ANCHOR (System.Boolean value);


        /// <summary>
        ///   System.Void set_isWorldCanvasOrientateCam(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isWorldCanvasOrientateCam")]
        ///  extern void SET_IS_WORLD_CANVAS_ORIENTATE_CAM (System.Boolean value);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();




        /// public static partial class Search_GUIEntity
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}