
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
    /// class ["ProjectStar".""."GUIMatcher"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200064AU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 85, 73, 77, 97, 116, 99, 104, 101, 114])]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherAttachedCombatAgent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttachedCombatAgent", "_MATCHER_ATTACHED_COMBAT_AGENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherAttachOwnerEntity
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttachOwnerEntity", "_MATCHER_ATTACH_OWNER_ENTITY", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherAttackTellCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherAttackTellCanvas", "_MATCHER_ATTACK_TELL_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherButtonHeldFill
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherButtonHeldFill", "_MATCHER_BUTTON_HELD_FILL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCallToActionPreorderPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCallToActionPreorderPanel", "_MATCHER_CALL_TO_ACTION_PREORDER_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCameraPresetScaleDisplayRoot
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCameraPresetScaleDisplayRoot", "_MATCHER_CAMERA_PRESET_SCALE_DISPLAY_ROOT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCanvas", "_MATCHER_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherChestTitlePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherChestTitlePanel", "_MATCHER_CHEST_TITLE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCombatLog
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCombatLog", "_MATCHER_COMBAT_LOG", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherConfirmationPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherConfirmationPanel", "_MATCHER_CONFIRMATION_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCreditsPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCreditsPanel", "_MATCHER_CREDITS_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherCrystalUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherCrystalUI", "_MATCHER_CRYSTAL_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherDenyInteractionUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDenyInteractionUI", "_MATCHER_DENY_INTERACTION_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherDestroyed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDestroyed", "_MATCHER_DESTROYED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherDialogueChoice
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDialogueChoice", "_MATCHER_DIALOGUE_CHOICE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherDungeonCompletePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherDungeonCompletePanel", "_MATCHER_DUNGEON_COMPLETE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherEndGameSplashPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEndGameSplashPanel", "_MATCHER_END_GAME_SPLASH_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherEquipmentAwardPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherEquipmentAwardPanel", "_MATCHER_EQUIPMENT_AWARD_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherExpBarUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherExpBarUI", "_MATCHER_EXP_BAR_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherFullScreenDialogueFocusPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFullScreenDialogueFocusPanel", "_MATCHER_FULL_SCREEN_DIALOGUE_FOCUS_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherFullScreenImageSplashPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFullScreenImageSplashPanel", "_MATCHER_FULL_SCREEN_IMAGE_SPLASH_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherFullScreenTextSplashPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherFullScreenTextSplashPanel", "_MATCHER_FULL_SCREEN_TEXT_SPLASH_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGameEntityId
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameEntityId", "_MATCHER_GAME_ENTITY_ID", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGameEntityRef
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameEntityRef", "_MATCHER_GAME_ENTITY_REF", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGameOverPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGameOverPanel", "_MATCHER_GAME_OVER_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGoldUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGoldUI", "_MATCHER_GOLD_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGUIDestroyedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGUIDestroyedListener", "_MATCHER_GUI_DESTROYED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherGunAmmoUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherGunAmmoUI", "_MATCHER_GUN_AMMO_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherHasOverlappingNavigationTrackers
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHasOverlappingNavigationTrackers", "_MATCHER_HAS_OVERLAPPING_NAVIGATION_TRACKERS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherHealthBarCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealthBarCanvas", "_MATCHER_HEALTH_BAR_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherHealthBarView
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHealthBarView", "_MATCHER_HEALTH_BAR_VIEW", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherHideMessagePrompt
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherHideMessagePrompt", "_MATCHER_HIDE_MESSAGE_PROMPT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInactive
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInactive", "_MATCHER_INACTIVE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInfinityTowerProgressPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInfinityTowerProgressPanel", "_MATCHER_INFINITY_TOWER_PROGRESS_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInstanceTitlePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInstanceTitlePanel", "_MATCHER_INSTANCE_TITLE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInventoryItemPreviewState
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryItemPreviewState", "_MATCHER_INVENTORY_ITEM_PREVIEW_STATE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInventoryPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryPanel", "_MATCHER_INVENTORY_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInventoryPickupUIController
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryPickupUIController", "_MATCHER_INVENTORY_PICKUP_UI_CONTROLLER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherInventoryUser
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherInventoryUser", "_MATCHER_INVENTORY_USER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherLanguagePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLanguagePanel", "_MATCHER_LANGUAGE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherLastSelectedUIButtonInfo
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLastSelectedUIButtonInfo", "_MATCHER_LAST_SELECTED_UI_BUTTON_INFO", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherLevelUpPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLevelUpPanel", "_MATCHER_LEVEL_UP_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherLevelUpWorldUISplash
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherLevelUpWorldUISplash", "_MATCHER_LEVEL_UP_WORLD_UI_SPLASH", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapIconCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapIconCanvas", "_MATCHER_MAP_ICON_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapIcon
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapIcon", "_MATCHER_MAP_ICON", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapInteractionControllerDetected
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapInteractionControllerDetected", "_MATCHER_MAP_INTERACTION_CONTROLLER_DETECTED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapInteractionMode
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapInteractionMode", "_MATCHER_MAP_INTERACTION_MODE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapMarkerWorldScreenEdgeIndicator
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapMarkerWorldScreenEdgeIndicator", "_MATCHER_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapPanel", "_MATCHER_MAP_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapPanelInteractableFocusZoneTouchActive
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapPanelInteractableFocusZoneTouchActive", "_MATCHER_MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapUICenterCrosshair
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapUICenterCrosshair", "_MATCHER_MAP_UI_CENTER_CROSSHAIR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMapUIRestoringConfiner
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMapUIRestoringConfiner", "_MATCHER_MAP_UI_RESTORING_CONFINER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMessagePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMessagePanel", "_MATCHER_MESSAGE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMessagePanelPromptPlayersConnectionState
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMessagePanelPromptPlayersConnectionState", "_MATCHER_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMessagePrompt
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMessagePrompt", "_MATCHER_MESSAGE_PROMPT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherMouseSelectedUIButton
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherMouseSelectedUIButton", "_MATCHER_MOUSE_SELECTED_UI_BUTTON", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherOptionsPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherOptionsPanel", "_MATCHER_OPTIONS_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerHealthHUD
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerHealthHUD", "_MATCHER_PLAYER_HEALTH_HUD", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerHUD
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerHUD", "_MATCHER_PLAYER_HUD", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerIndicator
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerIndicator", "_MATCHER_PLAYER_INDICATOR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerPromptHUD
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerPromptHUD", "_MATCHER_PLAYER_PROMPT_HUD", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerScreenEdgeIndicator
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerScreenEdgeIndicator", "_MATCHER_PLAYER_SCREEN_EDGE_INDICATOR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerShipHealthUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerShipHealthUI", "_MATCHER_PLAYER_SHIP_HEALTH_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelectConfirm
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelectConfirm", "_MATCHER_PLAYER_UI_BUTTON_SELECT_CONFIRM", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelectConfirmHeld
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelectConfirmHeld", "_MATCHER_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelectConfirmHeldListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelectConfirmHeldListener", "_MATCHER_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelectConfirmListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelectConfirmListener", "_MATCHER_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelection
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelection", "_MATCHER_PLAYER_UI_BUTTON_SELECTION", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPlayerUIButtonSelectionListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPlayerUIButtonSelectionListener", "_MATCHER_PLAYER_UI_BUTTON_SELECTION_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherPositionAttach
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherPositionAttach", "_MATCHER_POSITION_ATTACH", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherQuestCompletePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestCompletePanel", "_MATCHER_QUEST_COMPLETE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherQuestItemAwardPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestItemAwardPanel", "_MATCHER_QUEST_ITEM_AWARD_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherQuestTitlePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherQuestTitlePanel", "_MATCHER_QUEST_TITLE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherRectTransform
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherRectTransform", "_MATCHER_RECT_TRANSFORM", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherReviveBar
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherReviveBar", "_MATCHER_REVIVE_BAR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherSaveLoadPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveLoadPanel", "_MATCHER_SAVE_LOAD_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherSaveNotifierHUD
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSaveNotifierHUD", "_MATCHER_SAVE_NOTIFIER_HUD", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherScaleCache
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherScaleCache", "_MATCHER_SCALE_CACHE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherScreenDialogueCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherScreenDialogueCanvas", "_MATCHER_SCREEN_DIALOGUE_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherScreenEffectCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherScreenEffectCanvas", "_MATCHER_SCREEN_EFFECT_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherSelectionConfirmHeldTickCompleteEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSelectionConfirmHeldTickCompleteEvent", "_MATCHER_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherShipInteriorPrompt
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShipInteriorPrompt", "_MATCHER_SHIP_INTERIOR_PROMPT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherShowPlayerShipUIEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherShowPlayerShipUIEvent", "_MATCHER_SHOW_PLAYER_SHIP_UI_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherSinglePlayerUIInteractionMode
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSinglePlayerUIInteractionMode", "_MATCHER_SINGLE_PLAYER_UI_INTERACTION_MODE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherSplashTitleBackground
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherSplashTitleBackground", "_MATCHER_SPLASH_TITLE_BACKGROUND", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherTimer
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTimer", "_MATCHER_TIMER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherToggleInventoryCommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherToggleInventoryCommand", "_MATCHER_TOGGLE_INVENTORY_COMMAND", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherTutorialPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherTutorialPanel", "_MATCHER_TUTORIAL_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIButtonHeldConfirmedNormalizedSample
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIButtonHeldConfirmedNormalizedSample", "_MATCHER_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIButtonHeldConfirmedNormalizedSampleListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIButtonHeldConfirmedNormalizedSampleListener", "_MATCHER_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIButtonLegend
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIButtonLegend", "_MATCHER_UI_BUTTON_LEGEND", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIButtonMouseEvents
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIButtonMouseEvents", "_MATCHER_UI_BUTTON_MOUSE_EVENTS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommand
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommand", "_MATCHER_UI_COMMAND", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommandListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommandListener", "_MATCHER_UI_COMMAND_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommandOwner
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommandOwner", "_MATCHER_UI_COMMAND_OWNER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommandRelayEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommandRelayEvent", "_MATCHER_UI_COMMAND_RELAY_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommandReleased
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommandReleased", "_MATCHER_UI_COMMAND_RELEASED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUICommandReleasedListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUICommandReleasedListener", "_MATCHER_UI_COMMAND_RELEASED_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIControllerPanelExitEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIControllerPanelExitEvent", "_MATCHER_UI_CONTROLLER_PANEL_EXIT_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIEquipmentUpgradeLevelUpEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIEquipmentUpgradeLevelUpEvent", "_MATCHER_UI_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIEquipmentUpgradeLockBreakLevelUpEvent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIEquipmentUpgradeLockBreakLevelUpEvent", "_MATCHER_UI_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIInputBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIInputBlocked", "_MATCHER_UI_INPUT_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIInputMouseBlocked
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIInputMouseBlocked", "_MATCHER_UI_INPUT_MOUSE_BLOCKED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIInventoryPanelCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIInventoryPanelCanvas", "_MATCHER_UI_INVENTORY_PANEL_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIInventoryTabLink
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIInventoryTabLink", "_MATCHER_UI_INVENTORY_TAB_LINK", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIInventoryTabLinkListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIInventoryTabLinkListener", "_MATCHER_UI_INVENTORY_TAB_LINK_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIIsAnimatingPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIIsAnimatingPanel", "_MATCHER_UI_IS_ANIMATING_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIMouseInteractionMode
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIMouseInteractionMode", "_MATCHER_UI_MOUSE_INTERACTION_MODE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelBaseView
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelBaseView", "_MATCHER_UI_PANEL_BASE_VIEW", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelDisplayStatus
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelDisplayStatus", "_MATCHER_UI_PANEL_DISPLAY_STATUS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelDisplayStatusListener
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelDisplayStatusListener", "_MATCHER_UI_PANEL_DISPLAY_STATUS_LISTENER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelFixed
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelFixed", "_MATCHER_UI_PANEL_FIXED", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelRootCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelRootCanvas", "_MATCHER_UI_PANEL_ROOT_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelShowInputState
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelShowInputState", "_MATCHER_UI_PANEL_SHOW_INPUT_STATE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUIPanelUnderlayMask
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUIPanelUnderlayMask", "_MATCHER_UI_PANEL_UNDERLAY_MASK", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUITabBtn
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUITabBtn", "_MATCHER_UI_TAB_BTN", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUITooltip
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUITooltip", "_MATCHER_UI_TOOLTIP", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherUpgradePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherUpgradePanel", "_MATCHER_UPGRADE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherVideoSubtitles
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherVideoSubtitles", "_MATCHER_VIDEO_SUBTITLES", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldAnchor
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldAnchor", "_MATCHER_WORLD_ANCHOR", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldCanvasOrientateCam
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldCanvasOrientateCam", "_MATCHER_WORLD_CANVAS_ORIENTATE_CAM", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldDialogueCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldDialogueCanvas", "_MATCHER_WORLD_DIALOGUE_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldDialogueFocusPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldDialogueFocusPanel", "_MATCHER_WORLD_DIALOGUE_FOCUS_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldDialogueMessageQueue
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldDialogueMessageQueue", "_MATCHER_WORLD_DIALOGUE_MESSAGE_QUEUE", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldDialoguePanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldDialoguePanel", "_MATCHER_WORLD_DIALOGUE_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldEmojiPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldEmojiPanel", "_MATCHER_WORLD_EMOJI_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldPuzzlePieceUI
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldPuzzlePieceUI", "_MATCHER_WORLD_PUZZLE_PIECE_UI", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldPuzzlePieceUIOwner
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldPuzzlePieceUIOwner", "_MATCHER_WORLD_PUZZLE_PIECE_UI_OWNER", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldTextCanvas
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldTextCanvas", "_MATCHER_WORLD_TEXT_CANVAS", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldTextSplashPanel
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldTextSplashPanel", "_MATCHER_WORLD_TEXT_SPLASH_PANEL", true)]

    //  interface static Entitas.IMatcher<GUIEntity> _matcherWorldUIButtonView
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcherWorldUIButtonView", "_MATCHER_WORLD_UI_BUTTON_VIEW", true)]

    public partial class GUIMatcher
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GUIMatcher";
        //public static byte[] Static_ClassName { get; } = [71, 85, 73, 77, 97, 116, 99, 104, 101, 114];

        //public const uint Const_TypeToken = 0x0200064AU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GUIMatcher(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GUIMatcher(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GUIMatcher obj) => obj._ptr;
            public static implicit operator bool(Ptr_GUIMatcher obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIMatcher"]
    /// </summary>
    public partial class GUIMatcher
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_AttachedCombatAgent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttachedCombatAgent")]
        /// static extern nint GET_ATTACHED_COMBAT_AGENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_AttachOwnerEntity()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttachOwnerEntity")]
        /// static extern nint GET_ATTACH_OWNER_ENTITY ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_AttackTellCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_AttackTellCanvas")]
        /// static extern nint GET_ATTACK_TELL_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ButtonHeldFill()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ButtonHeldFill")]
        /// static extern nint GET_BUTTON_HELD_FILL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_CallToActionPreorderPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CallToActionPreorderPanel")]
        /// static extern nint GET_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_CameraPresetScaleDisplayRoot()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CameraPresetScaleDisplayRoot")]
        /// static extern nint GET_CAMERA_PRESET_SCALE_DISPLAY_ROOT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_Canvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Canvas")]
        /// static extern nint GET_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ChestTitlePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ChestTitlePanel")]
        /// static extern nint GET_CHEST_TITLE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_CombatLog()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CombatLog")]
        /// static extern nint GET_COMBAT_LOG ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ConfirmationPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ConfirmationPanel")]
        /// static extern nint GET_CONFIRMATION_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_CreditsPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CreditsPanel")]
        /// static extern nint GET_CREDITS_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_CrystalUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CrystalUI")]
        /// static extern nint GET_CRYSTAL_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_DenyInteractionUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DenyInteractionUI")]
        /// static extern nint GET_DENY_INTERACTION_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_Destroyed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Destroyed")]
        /// static extern nint GET_DESTROYED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_DialogueChoice()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DialogueChoice")]
        /// static extern nint GET_DIALOGUE_CHOICE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_DungeonCompletePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_DungeonCompletePanel")]
        /// static extern nint GET_DUNGEON_COMPLETE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_EndGameSplashPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EndGameSplashPanel")]
        /// static extern nint GET_END_GAME_SPLASH_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_EquipmentAwardPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_EquipmentAwardPanel")]
        /// static extern nint GET_EQUIPMENT_AWARD_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ExpBarUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ExpBarUI")]
        /// static extern nint GET_EXP_BAR_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_FullScreenDialogueFocusPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FullScreenDialogueFocusPanel")]
        /// static extern nint GET_FULL_SCREEN_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_FullScreenImageSplashPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FullScreenImageSplashPanel")]
        /// static extern nint GET_FULL_SCREEN_IMAGE_SPLASH_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_FullScreenTextSplashPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_FullScreenTextSplashPanel")]
        /// static extern nint GET_FULL_SCREEN_TEXT_SPLASH_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GameEntityId()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameEntityId")]
        /// static extern nint GET_GAME_ENTITY_ID ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GameEntityRef()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameEntityRef")]
        /// static extern nint GET_GAME_ENTITY_REF ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GameOverPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GameOverPanel")]
        /// static extern nint GET_GAME_OVER_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GoldUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GoldUI")]
        /// static extern nint GET_GOLD_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GUIDestroyedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GUIDestroyedListener")]
        /// static extern nint GET_GUI_DESTROYED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_GunAmmoUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_GunAmmoUI")]
        /// static extern nint GET_GUN_AMMO_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_HasOverlappingNavigationTrackers()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HasOverlappingNavigationTrackers")]
        /// static extern nint GET_HAS_OVERLAPPING_NAVIGATION_TRACKERS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_HealthBarCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealthBarCanvas")]
        /// static extern nint GET_HEALTH_BAR_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_HealthBarView()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HealthBarView")]
        /// static extern nint GET_HEALTH_BAR_VIEW ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_HideMessagePrompt()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_HideMessagePrompt")]
        /// static extern nint GET_HIDE_MESSAGE_PROMPT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_Inactive()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Inactive")]
        /// static extern nint GET_INACTIVE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InfinityTowerProgressPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InfinityTowerProgressPanel")]
        /// static extern nint GET_INFINITY_TOWER_PROGRESS_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InstanceTitlePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InstanceTitlePanel")]
        /// static extern nint GET_INSTANCE_TITLE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InventoryItemPreviewState()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryItemPreviewState")]
        /// static extern nint GET_INVENTORY_ITEM_PREVIEW_STATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InventoryPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryPanel")]
        /// static extern nint GET_INVENTORY_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InventoryPickupUIController()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryPickupUIController")]
        /// static extern nint GET_INVENTORY_PICKUP_UI_CONTROLLER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_InventoryUser()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_InventoryUser")]
        /// static extern nint GET_INVENTORY_USER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_LanguagePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LanguagePanel")]
        /// static extern nint GET_LANGUAGE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_LastSelectedUIButtonInfo()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LastSelectedUIButtonInfo")]
        /// static extern nint GET_LAST_SELECTED_UI_BUTTON_INFO ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_LevelUpPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LevelUpPanel")]
        /// static extern nint GET_LEVEL_UP_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_LevelUpWorldUISplash()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_LevelUpWorldUISplash")]
        /// static extern nint GET_LEVEL_UP_WORLD_UI_SPLASH ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapIcon()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapIcon", CallConvs = [typeof(CallConvCdecl)])]
        static extern nint GET_MAP_ICON();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapIconCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapIconCanvas")]
        /// static extern nint GET_MAP_ICON_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapInteractionControllerDetected()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapInteractionControllerDetected")]
        /// static extern nint GET_MAP_INTERACTION_CONTROLLER_DETECTED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapInteractionMode()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapInteractionMode")]
        /// static extern nint GET_MAP_INTERACTION_MODE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapMarkerWorldScreenEdgeIndicator()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapMarkerWorldScreenEdgeIndicator")]
        /// static extern nint GET_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapPanel")]
        /// static extern nint GET_MAP_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapPanelInteractableFocusZoneTouchActive()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapPanelInteractableFocusZoneTouchActive")]
        /// static extern nint GET_MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapUICenterCrosshair()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapUICenterCrosshair")]
        /// static extern nint GET_MAP_UI_CENTER_CROSSHAIR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MapUIRestoringConfiner()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MapUIRestoringConfiner")]
        /// static extern nint GET_MAP_UI_RESTORING_CONFINER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MessagePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MessagePanel")]
        /// static extern nint GET_MESSAGE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MessagePanelPromptPlayersConnectionState()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MessagePanelPromptPlayersConnectionState")]
        /// static extern nint GET_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MessagePrompt()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MessagePrompt")]
        /// static extern nint GET_MESSAGE_PROMPT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_MouseSelectedUIButton()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_MouseSelectedUIButton")]
        /// static extern nint GET_MOUSE_SELECTED_UI_BUTTON ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_OptionsPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_OptionsPanel")]
        /// static extern nint GET_OPTIONS_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerHealthHUD()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerHealthHUD")]
        /// static extern nint GET_PLAYER_HEALTH_HUD ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerHUD()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerHUD")]
        /// static extern nint GET_PLAYER_HUD ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerIndicator()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerIndicator")]
        /// static extern nint GET_PLAYER_INDICATOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerPromptHUD()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerPromptHUD")]
        /// static extern nint GET_PLAYER_PROMPT_HUD ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerScreenEdgeIndicator()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerScreenEdgeIndicator")]
        /// static extern nint GET_PLAYER_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerShipHealthUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerShipHealthUI")]
        /// static extern nint GET_PLAYER_SHIP_HEALTH_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelectConfirm()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelectConfirm")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelectConfirmHeld()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelectConfirmHeld")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelectConfirmHeldListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelectConfirmHeldListener")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_HELD_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelectConfirmListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelectConfirmListener")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECT_CONFIRM_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelection()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelection")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECTION ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PlayerUIButtonSelectionListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PlayerUIButtonSelectionListener")]
        /// static extern nint GET_PLAYER_UI_BUTTON_SELECTION_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_PositionAttach()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_PositionAttach")]
        /// static extern nint GET_POSITION_ATTACH ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_QuestCompletePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestCompletePanel")]
        /// static extern nint GET_QUEST_COMPLETE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_QuestItemAwardPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestItemAwardPanel")]
        /// static extern nint GET_QUEST_ITEM_AWARD_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_QuestTitlePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_QuestTitlePanel")]
        /// static extern nint GET_QUEST_TITLE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_RectTransform()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_RectTransform")]
        /// static extern nint GET_RECT_TRANSFORM ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ReviveBar()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ReviveBar")]
        /// static extern nint GET_REVIVE_BAR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_SaveLoadPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveLoadPanel")]
        /// static extern nint GET_SAVE_LOAD_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_SaveNotifierHUD()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SaveNotifierHUD")]
        /// static extern nint GET_SAVE_NOTIFIER_HUD ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ScaleCache()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ScaleCache")]
        /// static extern nint GET_SCALE_CACHE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ScreenDialogueCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ScreenDialogueCanvas")]
        /// static extern nint GET_SCREEN_DIALOGUE_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ScreenEffectCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ScreenEffectCanvas")]
        /// static extern nint GET_SCREEN_EFFECT_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_SelectionConfirmHeldTickCompleteEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SelectionConfirmHeldTickCompleteEvent")]
        /// static extern nint GET_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ShipInteriorPrompt()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShipInteriorPrompt")]
        /// static extern nint GET_SHIP_INTERIOR_PROMPT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ShowPlayerShipUIEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ShowPlayerShipUIEvent")]
        /// static extern nint GET_SHOW_PLAYER_SHIP_UI_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_SinglePlayerUIInteractionMode()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SinglePlayerUIInteractionMode")]
        /// static extern nint GET_SINGLE_PLAYER_UI_INTERACTION_MODE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_SplashTitleBackground()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_SplashTitleBackground")]
        /// static extern nint GET_SPLASH_TITLE_BACKGROUND ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_Timer()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Timer")]
        /// static extern nint GET_TIMER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_ToggleInventoryCommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_ToggleInventoryCommand")]
        /// static extern nint GET_TOGGLE_INVENTORY_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_TutorialPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_TutorialPanel")]
        /// static extern nint GET_TUTORIAL_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIButtonHeldConfirmedNormalizedSample()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIButtonHeldConfirmedNormalizedSample")]
        /// static extern nint GET_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIButtonHeldConfirmedNormalizedSampleListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIButtonHeldConfirmedNormalizedSampleListener")]
        /// static extern nint GET_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIButtonLegend()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIButtonLegend")]
        /// static extern nint GET_UI_BUTTON_LEGEND ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIButtonMouseEvents()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIButtonMouseEvents")]
        /// static extern nint GET_UI_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommand()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommand")]
        /// static extern nint GET_UI_COMMAND ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommandListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommandListener")]
        /// static extern nint GET_UI_COMMAND_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommandOwner()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommandOwner")]
        /// static extern nint GET_UI_COMMAND_OWNER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommandRelayEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommandRelayEvent")]
        /// static extern nint GET_UI_COMMAND_RELAY_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommandReleased()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommandReleased")]
        /// static extern nint GET_UI_COMMAND_RELEASED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UICommandReleasedListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UICommandReleasedListener")]
        /// static extern nint GET_UI_COMMAND_RELEASED_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIControllerPanelExitEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIControllerPanelExitEvent")]
        /// static extern nint GET_UI_CONTROLLER_PANEL_EXIT_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIEquipmentUpgradeLevelUpEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIEquipmentUpgradeLevelUpEvent")]
        /// static extern nint GET_UI_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIEquipmentUpgradeLockBreakLevelUpEvent()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIEquipmentUpgradeLockBreakLevelUpEvent")]
        /// static extern nint GET_UI_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIInputBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIInputBlocked")]
        /// static extern nint GET_UI_INPUT_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIInputMouseBlocked()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIInputMouseBlocked")]
        /// static extern nint GET_UI_INPUT_MOUSE_BLOCKED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIInventoryPanelCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIInventoryPanelCanvas")]
        /// static extern nint GET_UI_INVENTORY_PANEL_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIInventoryTabLink()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIInventoryTabLink")]
        /// static extern nint GET_UI_INVENTORY_TAB_LINK ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIInventoryTabLinkListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIInventoryTabLinkListener")]
        /// static extern nint GET_UI_INVENTORY_TAB_LINK_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIIsAnimatingPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIIsAnimatingPanel")]
        /// static extern nint GET_UI_IS_ANIMATING_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIMouseInteractionMode()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIMouseInteractionMode")]
        /// static extern nint GET_UI_MOUSE_INTERACTION_MODE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelBaseView()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelBaseView")]
        /// static extern nint GET_UI_PANEL_BASE_VIEW ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelDisplayStatus()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelDisplayStatus")]
        /// static extern nint GET_UI_PANEL_DISPLAY_STATUS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelDisplayStatusListener()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelDisplayStatusListener")]
        /// static extern nint GET_UI_PANEL_DISPLAY_STATUS_LISTENER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelFixed()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelFixed")]
        /// static extern nint GET_UI_PANEL_FIXED ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelRootCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelRootCanvas")]
        /// static extern nint GET_UI_PANEL_ROOT_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelShowInputState()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelShowInputState")]
        /// static extern nint GET_UI_PANEL_SHOW_INPUT_STATE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UIPanelUnderlayMask()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UIPanelUnderlayMask")]
        /// static extern nint GET_UI_PANEL_UNDERLAY_MASK ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UITabBtn()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UITabBtn")]
        /// static extern nint GET_UI_TAB_BTN ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UITooltip()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UITooltip")]
        /// static extern nint GET_UI_TOOLTIP ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_UpgradePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_UpgradePanel")]
        /// static extern nint GET_UPGRADE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_VideoSubtitles()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_VideoSubtitles")]
        /// static extern nint GET_VIDEO_SUBTITLES ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldAnchor()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldAnchor")]
        /// static extern nint GET_WORLD_ANCHOR ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldCanvasOrientateCam()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldCanvasOrientateCam")]
        /// static extern nint GET_WORLD_CANVAS_ORIENTATE_CAM ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldDialogueCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldDialogueCanvas")]
        /// static extern nint GET_WORLD_DIALOGUE_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldDialogueFocusPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldDialogueFocusPanel")]
        /// static extern nint GET_WORLD_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldDialogueMessageQueue()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldDialogueMessageQueue")]
        /// static extern nint GET_WORLD_DIALOGUE_MESSAGE_QUEUE ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldDialoguePanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldDialoguePanel")]
        /// static extern nint GET_WORLD_DIALOGUE_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldEmojiPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldEmojiPanel")]
        /// static extern nint GET_WORLD_EMOJI_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldPuzzlePieceUI()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldPuzzlePieceUI")]
        /// static extern nint GET_WORLD_PUZZLE_PIECE_UI ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldPuzzlePieceUIOwner()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldPuzzlePieceUIOwner")]
        /// static extern nint GET_WORLD_PUZZLE_PIECE_UI_OWNER ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldTextCanvas()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldTextCanvas")]
        /// static extern nint GET_WORLD_TEXT_CANVAS ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldTextSplashPanel()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldTextSplashPanel")]
        /// static extern nint GET_WORLD_TEXT_SPLASH_PANEL ();


        /// <summary>
        /// static  Entitas.IMatcher<GUIEntity> get_WorldUIButtonView()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_WorldUIButtonView")]
        /// static extern nint GET_WORLD_UI_BUTTON_VIEW ();



        /// <summary>
        /// static  Entitas.IAllOfMatcher<GUIEntity> AllOf(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>interface Entitas.IAllOfMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllOf", Search = typeof(Search_GUIMatcher))]
        /// static extern nint ALL_OF_00 (nint indices);


        /// <summary>
        /// static  Entitas.IAllOfMatcher<GUIEntity> AllOf(Entitas.IMatcher<GUIEntity>[] matchers)
        /// </summary>
        /// <param name="matchers">class Entitas.IMatcher<GUIEntity>[]</param>
        /// <returns>interface Entitas.IAllOfMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AllOf", Search = typeof(Search_GUIMatcher))]
        /// static extern nint ALL_OF_01 (nint matchers);


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GUIEntity> AnyOf(System.Int32[] indices)
        /// </summary>
        /// <param name="indices">class System.Int32[]</param>
        /// <returns>interface Entitas.IAnyOfMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_GUIMatcher))]
        /// static extern nint ANY_OF_00 (nint indices);


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GUIEntity> AnyOf(Entitas.IMatcher<GUIEntity>[] matchers)
        /// </summary>
        /// <param name="matchers">class Entitas.IMatcher<GUIEntity>[]</param>
        /// <returns>interface Entitas.IAnyOfMatcher<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AnyOf", Search = typeof(Search_GUIMatcher))]
        /// static extern nint ANY_OF_01 (nint matchers);


        /// public static partial class Search_GUIMatcher
        /// {
        /// 
        ///     

        /// <summary>
        /// static  Entitas.IAllOfMatcher<GUIEntity> AllOf(System.Int32[] indices)
        /// </summary>
        /// public static bool ALL_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AllOf", "System.Int32[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAllOfMatcher<GUIEntity> AllOf(Entitas.IMatcher<GUIEntity>[] matchers)
        /// </summary>
        /// public static bool ALL_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AllOf", "Entitas.IMatcher<GUIEntity>[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GUIEntity> AnyOf(System.Int32[] indices)
        /// </summary>
        /// public static bool ANY_OF_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "System.Int32[]");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  Entitas.IAnyOfMatcher<GUIEntity> AnyOf(Entitas.IMatcher<GUIEntity>[] matchers)
        /// </summary>
        /// public static bool ANY_OF_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AnyOf", "Entitas.IMatcher<GUIEntity>[]");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}