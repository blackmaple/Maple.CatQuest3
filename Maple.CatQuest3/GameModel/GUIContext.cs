
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
    /// class ["ProjectStar".""."GUIContext"]
    /// [Entitas.Context<GUIEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200064BU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 85, 73, 67, 111, 110, 116, 101, 120, 116])]


    // class 0x8 Entitas.ContextEntityChanged OnEntityCreated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityCreated", "ON_ENTITY_CREATED")]

    // class 0xC Entitas.ContextEntityChanged OnEntityWillBeDestroyed
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityWillBeDestroyed", "ON_ENTITY_WILL_BE_DESTROYED")]

    // class 0x10 Entitas.ContextEntityChanged OnEntityDestroyed
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityDestroyed", "ON_ENTITY_DESTROYED")]

    // class 0x14 Entitas.ContextGroupChanged OnGroupCreated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnGroupCreated", "ON_GROUP_CREATED")]

    // class 0x18 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]

    // class 0x1C Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]

    // class 0x20 System.Func<Entitas.IEntity,Entitas.IAERC> _aercFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aercFactory", "_AERC_FACTORY")]

    // class 0x24 System.Func<GUIEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]

    // class 0x28 System.Collections.Generic.HashSet<GUIEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]

    // class 0x2C System.Collections.Generic.Stack<GUIEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]

    // class 0x30 System.Collections.Generic.HashSet<GUIEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]

    // class 0x34 System.Collections.Generic.Dictionary<Entitas.IMatcher<GUIEntity>,Entitas.IGroup<GUIEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]

    // class 0x38 System.Collections.Generic.List<Entitas.IGroup<GUIEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]

    // class 0x3C DesperateDevs.Caching.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<GUIEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]

    // class 0x40 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]

    // class 0x44 GUIEntity[] _entitiesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entitiesCache", "_ENTITIES_CACHE")]

    // class 0x48 Entitas.EntityComponentChanged _cachedEntityChanged
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedEntityChanged", "_CACHED_ENTITY_CHANGED")]

    // class 0x4C Entitas.EntityComponentReplaced _cachedComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedComponentReplaced", "_CACHED_COMPONENT_REPLACED")]

    // class 0x50 Entitas.EntityEvent _cachedEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedEntityReleased", "_CACHED_ENTITY_RELEASED")]

    // class 0x54 Entitas.EntityEvent _cachedDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_cachedDestroyEntity", "_CACHED_DESTROY_ENTITY")]

    // struct 0x58 System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]

    // struct 0x5C System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]
    public partial class GUIContext
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GUIContext";
        //public static byte[] Static_ClassName { get; } = [71, 85, 73, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x0200064BU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GUIContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GUIContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GUIContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_GUIContext obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIContext"]
    /// </summary>
    public partial class GUIContext
    {



        /// <summary>
        ///   System.Void add_OnEntityCreated(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityCreated")]
        ///  extern void ADD_ON_ENTITY_CREATED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityDestroyed")]
        ///  extern void ADD_ON_ENTITY_DESTROYED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityWillBeDestroyed")]
        ///  extern void ADD_ON_ENTITY_WILL_BE_DESTROYED (nint value);


        /// <summary>
        ///   System.Void add_OnGroupCreated(Entitas.ContextGroupChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextGroupChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnGroupCreated")]
        ///  extern void ADD_ON_GROUP_CREATED (nint value);


        /// <summary>
        ///   System.Void AddEntityIndex(Entitas.IEntityIndex entityIndex)
        /// </summary>
        /// <param name="entityIndex">interface Entitas.IEntityIndex</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddEntityIndex")]
        ///  extern void ADD_ENTITY_INDEX (nint entityIndex);


        /// <summary>
        ///   System.Void ClearComponentPool(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearComponentPool")]
        ///  extern void CLEAR_COMPONENT_POOL (System.Int32 index);


        /// <summary>
        ///   System.Void ClearComponentPools()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearComponentPools")]
        ///  extern void CLEAR_COMPONENT_POOLS ();


        /// <summary>
        ///   Entitas.ContextInfo createDefaultContextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
        ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();


        /// <summary>
        ///   GUIEntity CreateEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
        ///  extern nint CREATE_ENTITY ();


        /// <summary>
        ///   System.Void DestroyAllEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
        ///  extern void DESTROY_ALL_ENTITIES ();


        /// <summary>
        ///   GUIEntity get_attackTellCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attackTellCanvasEntity")]
        ///  extern nint GET_ATTACK_TELL_CANVAS_ENTITY ();


        /// <summary>
        ///   CallToActionPreorderPanelComponent get_callToActionPreorderPanel()
        /// </summary>
        /// <returns>class CallToActionPreorderPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_callToActionPreorderPanel")]
        ///  extern nint GET_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   GUIEntity get_callToActionPreorderPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_callToActionPreorderPanelEntity")]
        ///  extern nint GET_CALL_TO_ACTION_PREORDER_PANEL_ENTITY ();


        /// <summary>
        ///   ChestTitlePanelComponent get_chestTitlePanel()
        /// </summary>
        /// <returns>class ChestTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestTitlePanel")]
        ///  extern nint GET_CHEST_TITLE_PANEL ();


        /// <summary>
        ///   GUIEntity get_chestTitlePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestTitlePanelEntity")]
        ///  extern nint GET_CHEST_TITLE_PANEL_ENTITY ();


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
        ///   GUIEntity get_confirmationPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_confirmationPanelEntity")]
        ///  extern nint GET_CONFIRMATION_PANEL_ENTITY ();


        /// <summary>
        ///   Entitas.ContextInfo get_contextInfo()
        /// </summary>
        /// <returns>class Entitas.ContextInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
        ///  extern nint GET_CONTEXT_INFO ();


        /// <summary>
        ///   System.Int32 get_count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   CreditsPanelComponent get_creditsPanel()
        /// </summary>
        /// <returns>class CreditsPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creditsPanel")]
        ///  extern nint GET_CREDITS_PANEL ();


        /// <summary>
        ///   GUIEntity get_creditsPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creditsPanelEntity")]
        ///  extern nint GET_CREDITS_PANEL_ENTITY ();


        /// <summary>
        ///   CrystalUIComponent get_crystalUI()
        /// </summary>
        /// <returns>class CrystalUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_crystalUI")]
        ///  extern nint GET_CRYSTAL_UI ();


        /// <summary>
        ///   GUIEntity get_crystalUIEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_crystalUIEntity")]
        ///  extern nint GET_CRYSTAL_UI_ENTITY ();


        /// <summary>
        ///   DialogueChoiceComponent get_dialogueChoice()
        /// </summary>
        /// <returns>class DialogueChoiceComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dialogueChoice")]
        ///  extern nint GET_DIALOGUE_CHOICE ();


        /// <summary>
        ///   GUIEntity get_dialogueChoiceEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dialogueChoiceEntity")]
        ///  extern nint GET_DIALOGUE_CHOICE_ENTITY ();


        /// <summary>
        ///   DungeonCompletePanelComponent get_dungeonCompletePanel()
        /// </summary>
        /// <returns>class DungeonCompletePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dungeonCompletePanel")]
        ///  extern nint GET_DUNGEON_COMPLETE_PANEL ();


        /// <summary>
        ///   GUIEntity get_dungeonCompletePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dungeonCompletePanelEntity")]
        ///  extern nint GET_DUNGEON_COMPLETE_PANEL_ENTITY ();


        /// <summary>
        ///   EndGameSplashPanelComponent get_endGameSplashPanel()
        /// </summary>
        /// <returns>class EndGameSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_endGameSplashPanel")]
        ///  extern nint GET_END_GAME_SPLASH_PANEL ();


        /// <summary>
        ///   GUIEntity get_endGameSplashPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_endGameSplashPanelEntity")]
        ///  extern nint GET_END_GAME_SPLASH_PANEL_ENTITY ();


        /// <summary>
        ///   EquipmentAwardPanelComponent get_equipmentAwardPanel()
        /// </summary>
        /// <returns>class EquipmentAwardPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentAwardPanel")]
        ///  extern nint GET_EQUIPMENT_AWARD_PANEL ();


        /// <summary>
        ///   GUIEntity get_equipmentAwardPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentAwardPanelEntity")]
        ///  extern nint GET_EQUIPMENT_AWARD_PANEL_ENTITY ();


        /// <summary>
        ///   ExpBarUIComponent get_expBarUI()
        /// </summary>
        /// <returns>class ExpBarUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_expBarUI")]
        ///  extern nint GET_EXP_BAR_UI ();


        /// <summary>
        ///   GUIEntity get_expBarUIEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_expBarUIEntity")]
        ///  extern nint GET_EXP_BAR_UI_ENTITY ();


        /// <summary>
        ///   FullScreenDialogueFocusPanelComponent get_fullScreenDialogueFocusPanel()
        /// </summary>
        /// <returns>class FullScreenDialogueFocusPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenDialogueFocusPanel")]
        ///  extern nint GET_FULL_SCREEN_DIALOGUE_FOCUS_PANEL ();


        /// <summary>
        ///   GUIEntity get_fullScreenDialogueFocusPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenDialogueFocusPanelEntity")]
        ///  extern nint GET_FULL_SCREEN_DIALOGUE_FOCUS_PANEL_ENTITY ();


        /// <summary>
        ///   FullScreenImageSplashPanelComponent get_fullScreenImageSplashPanel()
        /// </summary>
        /// <returns>class FullScreenImageSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenImageSplashPanel")]
        ///  extern nint GET_FULL_SCREEN_IMAGE_SPLASH_PANEL ();


        /// <summary>
        ///   GUIEntity get_fullScreenImageSplashPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenImageSplashPanelEntity")]
        ///  extern nint GET_FULL_SCREEN_IMAGE_SPLASH_PANEL_ENTITY ();


        /// <summary>
        ///   FullScreenTextSplashPanelComponent get_fullScreenTextSplashPanel()
        /// </summary>
        /// <returns>class FullScreenTextSplashPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenTextSplashPanel")]
        ///  extern nint GET_FULL_SCREEN_TEXT_SPLASH_PANEL ();


        /// <summary>
        ///   GUIEntity get_fullScreenTextSplashPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fullScreenTextSplashPanelEntity")]
        ///  extern nint GET_FULL_SCREEN_TEXT_SPLASH_PANEL_ENTITY ();


        /// <summary>
        ///   GameOverPanelComponent get_gameOverPanel()
        /// </summary>
        /// <returns>class GameOverPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverPanel")]
        ///  extern nint GET_GAME_OVER_PANEL ();


        /// <summary>
        ///   GUIEntity get_gameOverPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverPanelEntity")]
        ///  extern nint GET_GAME_OVER_PANEL_ENTITY ();


        /// <summary>
        ///   GoldUIComponent get_goldUI()
        /// </summary>
        /// <returns>class GoldUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_goldUI")]
        ///  extern nint GET_GOLD_UI ();


        /// <summary>
        ///   GUIEntity get_goldUIEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_goldUIEntity")]
        ///  extern nint GET_GOLD_UI_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasCallToActionPreorderPanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCallToActionPreorderPanel")]
        ///  extern System.Boolean GET_HAS_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   System.Boolean get_hasChestTitlePanel()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChestTitlePanel")]
        ///  extern System.Boolean GET_HAS_CHEST_TITLE_PANEL ();


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
        ///   GUIEntity get_hasOverlappingNavigationTrackersEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOverlappingNavigationTrackersEntity")]
        ///  extern nint GET_HAS_OVERLAPPING_NAVIGATION_TRACKERS_ENTITY ();


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
        ///   System.Boolean get_hasPlayerShipHealthUI()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerShipHealthUI")]
        ///  extern System.Boolean GET_HAS_PLAYER_SHIP_HEALTH_UI ();


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
        ///   System.Boolean get_hasUIButtonMouseEvents()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIButtonMouseEvents")]
        ///  extern System.Boolean GET_HAS_UI_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   System.Boolean get_hasUICommandRelayEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUICommandRelayEvent")]
        ///  extern System.Boolean GET_HAS_UI_COMMAND_RELAY_EVENT ();


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
        ///   System.Boolean get_hasUIPanelRootCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelRootCanvas")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   System.Boolean get_hasUIPanelUnderlayMask()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUIPanelUnderlayMask")]
        ///  extern System.Boolean GET_HAS_UI_PANEL_UNDERLAY_MASK ();


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
        ///   System.Boolean get_hasWorldTextCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldTextCanvas")]
        ///  extern System.Boolean GET_HAS_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   GUIEntity get_healthBarCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_healthBarCanvasEntity")]
        ///  extern nint GET_HEALTH_BAR_CANVAS_ENTITY ();


        /// <summary>
        ///   InfinityTowerProgressPanelComponent get_infinityTowerProgressPanel()
        /// </summary>
        /// <returns>class InfinityTowerProgressPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerProgressPanel")]
        ///  extern nint GET_INFINITY_TOWER_PROGRESS_PANEL ();


        /// <summary>
        ///   GUIEntity get_infinityTowerProgressPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerProgressPanelEntity")]
        ///  extern nint GET_INFINITY_TOWER_PROGRESS_PANEL_ENTITY ();


        /// <summary>
        ///   InstanceTitlePanelComponent get_instanceTitlePanel()
        /// </summary>
        /// <returns>class InstanceTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_instanceTitlePanel")]
        ///  extern nint GET_INSTANCE_TITLE_PANEL ();


        /// <summary>
        ///   GUIEntity get_instanceTitlePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_instanceTitlePanelEntity")]
        ///  extern nint GET_INSTANCE_TITLE_PANEL_ENTITY ();


        /// <summary>
        ///   InventoryPanelComponent get_inventoryPanel()
        /// </summary>
        /// <returns>class InventoryPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPanel")]
        ///  extern nint GET_INVENTORY_PANEL ();


        /// <summary>
        ///   GUIEntity get_inventoryPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPanelEntity")]
        ///  extern nint GET_INVENTORY_PANEL_ENTITY ();


        /// <summary>
        ///   InventoryPickupUIControllerComponent get_inventoryPickupUIController()
        /// </summary>
        /// <returns>class InventoryPickupUIControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPickupUIController")]
        ///  extern nint GET_INVENTORY_PICKUP_UI_CONTROLLER ();


        /// <summary>
        ///   GUIEntity get_inventoryPickupUIControllerEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryPickupUIControllerEntity")]
        ///  extern nint GET_INVENTORY_PICKUP_UI_CONTROLLER_ENTITY ();


        /// <summary>
        ///   InventoryUserComponent get_inventoryUser()
        /// </summary>
        /// <returns>class InventoryUserComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryUser")]
        ///  extern nint GET_INVENTORY_USER ();


        /// <summary>
        ///   GUIEntity get_inventoryUserEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryUserEntity")]
        ///  extern nint GET_INVENTORY_USER_ENTITY ();


        /// <summary>
        ///   System.Boolean get_isAttackTellCanvas()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAttackTellCanvas")]
        ///  extern System.Boolean GET_IS_ATTACK_TELL_CANVAS ();


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
        ///   LanguagePanelComponent get_languagePanel()
        /// </summary>
        /// <returns>class LanguagePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_languagePanel")]
        ///  extern nint GET_LANGUAGE_PANEL ();


        /// <summary>
        ///   GUIEntity get_languagePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_languagePanelEntity")]
        ///  extern nint GET_LANGUAGE_PANEL_ENTITY ();


        /// <summary>
        ///   LastSelectedUIButtonInfoComponent get_lastSelectedUIButtonInfo()
        /// </summary>
        /// <returns>class LastSelectedUIButtonInfoComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastSelectedUIButtonInfo")]
        ///  extern nint GET_LAST_SELECTED_UI_BUTTON_INFO ();


        /// <summary>
        ///   GUIEntity get_lastSelectedUIButtonInfoEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastSelectedUIButtonInfoEntity")]
        ///  extern nint GET_LAST_SELECTED_UI_BUTTON_INFO_ENTITY ();


        /// <summary>
        ///   LevelUpPanelComponent get_levelUpPanel()
        /// </summary>
        /// <returns>class LevelUpPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_levelUpPanel")]
        ///  extern nint GET_LEVEL_UP_PANEL ();


        /// <summary>
        ///   GUIEntity get_levelUpPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_levelUpPanelEntity")]
        ///  extern nint GET_LEVEL_UP_PANEL_ENTITY ();


        /// <summary>
        ///   MapIconCanvasComponent get_mapIconCanvas()
        /// </summary>
        /// <returns>class MapIconCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconCanvas")]
        ///  extern nint GET_MAP_ICON_CANVAS ();


        /// <summary>
        ///   GUIEntity get_mapIconCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconCanvasEntity")]
        ///  extern nint GET_MAP_ICON_CANVAS_ENTITY ();


        /// <summary>
        ///   GUIEntity get_mapInteractionControllerDetectedEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapInteractionControllerDetectedEntity")]
        ///  extern nint GET_MAP_INTERACTION_CONTROLLER_DETECTED_ENTITY ();


        /// <summary>
        ///   MapInteractionModeComponent get_mapInteractionMode()
        /// </summary>
        /// <returns>class MapInteractionModeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapInteractionMode")]
        ///  extern nint GET_MAP_INTERACTION_MODE ();


        /// <summary>
        ///   GUIEntity get_mapInteractionModeEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapInteractionModeEntity")]
        ///  extern nint GET_MAP_INTERACTION_MODE_ENTITY ();


        /// <summary>
        ///   MapMarkerWorldScreenEdgeIndicatorComponent get_mapMarkerWorldScreenEdgeIndicator()
        /// </summary>
        /// <returns>class MapMarkerWorldScreenEdgeIndicatorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapMarkerWorldScreenEdgeIndicator")]
        ///  extern nint GET_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR ();


        /// <summary>
        ///   GUIEntity get_mapMarkerWorldScreenEdgeIndicatorEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapMarkerWorldScreenEdgeIndicatorEntity")]
        ///  extern nint GET_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR_ENTITY ();


        /// <summary>
        ///   MapPanelComponent get_mapPanel()
        /// </summary>
        /// <returns>class MapPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapPanel")]
        ///  extern nint GET_MAP_PANEL ();


        /// <summary>
        ///   GUIEntity get_mapPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapPanelEntity")]
        ///  extern nint GET_MAP_PANEL_ENTITY ();


        /// <summary>
        ///   GUIEntity get_mapPanelInteractableFocusZoneTouchActiveEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapPanelInteractableFocusZoneTouchActiveEntity")]
        ///  extern nint GET_MAP_PANEL_INTERACTABLE_FOCUS_ZONE_TOUCH_ACTIVE_ENTITY ();


        /// <summary>
        ///   MapUICenterCrosshairComponent get_mapUICenterCrosshair()
        /// </summary>
        /// <returns>class MapUICenterCrosshairComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUICenterCrosshair")]
        ///  extern nint GET_MAP_UI_CENTER_CROSSHAIR ();


        /// <summary>
        ///   GUIEntity get_mapUICenterCrosshairEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUICenterCrosshairEntity")]
        ///  extern nint GET_MAP_UI_CENTER_CROSSHAIR_ENTITY ();


        /// <summary>
        ///   GUIEntity get_mapUIRestoringConfinerEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUIRestoringConfinerEntity")]
        ///  extern nint GET_MAP_UI_RESTORING_CONFINER_ENTITY ();


        /// <summary>
        ///   MessagePanelComponent get_messagePanel()
        /// </summary>
        /// <returns>class MessagePanelComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanel", CallConvs = [typeof(CallConvCdecl)])]
        extern MessagePanelComponent.Ptr_MessagePanelComponent GET_MESSAGE_PANEL();


        /// <summary>
        ///   GUIEntity get_messagePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanelEntity", CallConvs = [typeof(CallConvCdecl)])]
        extern GUIEntity.Ptr_GUIEntity GET_MESSAGE_PANEL_ENTITY();


        /// <summary>
        ///   MessagePanelPromptPlayersConnectionStateComponent get_messagePanelPromptPlayersConnectionState()
        /// </summary>
        /// <returns>class MessagePanelPromptPlayersConnectionStateComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanelPromptPlayersConnectionState")]
        ///  extern nint GET_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE ();


        /// <summary>
        ///   GUIEntity get_messagePanelPromptPlayersConnectionStateEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_messagePanelPromptPlayersConnectionStateEntity")]
        ///  extern nint GET_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE_ENTITY ();


        /// <summary>
        ///   MouseSelectedUIButtonComponent get_mouseSelectedUIButton()
        /// </summary>
        /// <returns>class MouseSelectedUIButtonComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mouseSelectedUIButton")]
        ///  extern nint GET_MOUSE_SELECTED_UI_BUTTON ();


        /// <summary>
        ///   GUIEntity get_mouseSelectedUIButtonEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mouseSelectedUIButtonEntity")]
        ///  extern nint GET_MOUSE_SELECTED_UI_BUTTON_ENTITY ();


        /// <summary>
        ///   OptionsPanelComponent get_optionsPanel()
        /// </summary>
        /// <returns>class OptionsPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_optionsPanel")]
        ///  extern nint GET_OPTIONS_PANEL ();


        /// <summary>
        ///   GUIEntity get_optionsPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_optionsPanelEntity")]
        ///  extern nint GET_OPTIONS_PANEL_ENTITY ();


        /// <summary>
        ///   PlayerHUDComponent get_playerHUD()
        /// </summary>
        /// <returns>class PlayerHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerHUD")]
        ///  extern nint GET_PLAYER_HUD ();


        /// <summary>
        ///   GUIEntity get_playerHUDEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerHUDEntity")]
        ///  extern nint GET_PLAYER_HUD_ENTITY ();


        /// <summary>
        ///   PlayerPromptHUDComponent get_playerPromptHUD()
        /// </summary>
        /// <returns>class PlayerPromptHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerPromptHUD")]
        ///  extern nint GET_PLAYER_PROMPT_HUD ();


        /// <summary>
        ///   GUIEntity get_playerPromptHUDEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerPromptHUDEntity")]
        ///  extern nint GET_PLAYER_PROMPT_HUD_ENTITY ();


        /// <summary>
        ///   PlayerShipHealthUIComponent get_playerShipHealthUI()
        /// </summary>
        /// <returns>class PlayerShipHealthUIComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerShipHealthUI")]
        ///  extern nint GET_PLAYER_SHIP_HEALTH_UI ();


        /// <summary>
        ///   GUIEntity get_playerShipHealthUIEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerShipHealthUIEntity")]
        ///  extern nint GET_PLAYER_SHIP_HEALTH_UI_ENTITY ();


        /// <summary>
        ///   QuestCompletePanelComponent get_questCompletePanel()
        /// </summary>
        /// <returns>class QuestCompletePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questCompletePanel")]
        ///  extern nint GET_QUEST_COMPLETE_PANEL ();


        /// <summary>
        ///   GUIEntity get_questCompletePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questCompletePanelEntity")]
        ///  extern nint GET_QUEST_COMPLETE_PANEL_ENTITY ();


        /// <summary>
        ///   QuestItemAwardPanelComponent get_questItemAwardPanel()
        /// </summary>
        /// <returns>class QuestItemAwardPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questItemAwardPanel")]
        ///  extern nint GET_QUEST_ITEM_AWARD_PANEL ();


        /// <summary>
        ///   GUIEntity get_questItemAwardPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questItemAwardPanelEntity")]
        ///  extern nint GET_QUEST_ITEM_AWARD_PANEL_ENTITY ();


        /// <summary>
        ///   QuestTitlePanelComponent get_questTitlePanel()
        /// </summary>
        /// <returns>class QuestTitlePanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questTitlePanel")]
        ///  extern nint GET_QUEST_TITLE_PANEL ();


        /// <summary>
        ///   GUIEntity get_questTitlePanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questTitlePanelEntity")]
        ///  extern nint GET_QUEST_TITLE_PANEL_ENTITY ();


        /// <summary>
        ///   System.Int32 get_retainedEntitiesCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainedEntitiesCount")]
        ///  extern System.Int32 GET_RETAINED_ENTITIES_COUNT ();


        /// <summary>
        ///   System.Int32 get_reusableEntitiesCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_reusableEntitiesCount")]
        ///  extern System.Int32 GET_REUSABLE_ENTITIES_COUNT ();


        /// <summary>
        ///   SaveLoadPanelComponent get_saveLoadPanel()
        /// </summary>
        /// <returns>class SaveLoadPanelComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveLoadPanel")]
        ///  extern nint GET_SAVE_LOAD_PANEL ();


        /// <summary>
        ///   GUIEntity get_saveLoadPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveLoadPanelEntity")]
        ///  extern nint GET_SAVE_LOAD_PANEL_ENTITY ();


        /// <summary>
        ///   SaveNotifierHUDComponent get_saveNotifierHUD()
        /// </summary>
        /// <returns>class SaveNotifierHUDComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveNotifierHUD")]
        ///  extern nint GET_SAVE_NOTIFIER_HUD ();


        /// <summary>
        ///   GUIEntity get_saveNotifierHUDEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_saveNotifierHUDEntity")]
        ///  extern nint GET_SAVE_NOTIFIER_HUD_ENTITY ();


        /// <summary>
        ///   ScreenDialogueCanvasComponent get_screenDialogueCanvas()
        /// </summary>
        /// <returns>class ScreenDialogueCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenDialogueCanvas")]
        ///  extern nint GET_SCREEN_DIALOGUE_CANVAS ();


        /// <summary>
        ///   GUIEntity get_screenDialogueCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenDialogueCanvasEntity")]
        ///  extern nint GET_SCREEN_DIALOGUE_CANVAS_ENTITY ();


        /// <summary>
        ///   GUIEntity get_screenEffectCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_screenEffectCanvasEntity")]
        ///  extern nint GET_SCREEN_EFFECT_CANVAS_ENTITY ();


        /// <summary>
        ///   SelectionConfirmHeldTickCompleteEventComponent get_selectionConfirmHeldTickCompleteEvent()
        /// </summary>
        /// <returns>class SelectionConfirmHeldTickCompleteEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectionConfirmHeldTickCompleteEvent")]
        ///  extern nint GET_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT ();


        /// <summary>
        ///   GUIEntity get_selectionConfirmHeldTickCompleteEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectionConfirmHeldTickCompleteEventEntity")]
        ///  extern nint GET_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_shipInteriorPromptEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipInteriorPromptEntity")]
        ///  extern nint GET_SHIP_INTERIOR_PROMPT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_showPlayerShipUIEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_showPlayerShipUIEventEntity")]
        ///  extern nint GET_SHOW_PLAYER_SHIP_UI_EVENT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_singlePlayerUIInteractionModeEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_singlePlayerUIInteractionModeEntity")]
        ///  extern nint GET_SINGLE_PLAYER_UI_INTERACTION_MODE_ENTITY ();


        /// <summary>
        ///   SplashTitleBackgroundComponent get_splashTitleBackground()
        /// </summary>
        /// <returns>class SplashTitleBackgroundComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_splashTitleBackground")]
        ///  extern nint GET_SPLASH_TITLE_BACKGROUND ();


        /// <summary>
        ///   GUIEntity get_splashTitleBackgroundEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_splashTitleBackgroundEntity")]
        ///  extern nint GET_SPLASH_TITLE_BACKGROUND_ENTITY ();


        /// <summary>
        ///   ToggleInventoryCommandComponent get_toggleInventoryCommand()
        /// </summary>
        /// <returns>class ToggleInventoryCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_toggleInventoryCommand")]
        ///  extern nint GET_TOGGLE_INVENTORY_COMMAND ();


        /// <summary>
        ///   GUIEntity get_toggleInventoryCommandEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_toggleInventoryCommandEntity")]
        ///  extern nint GET_TOGGLE_INVENTORY_COMMAND_ENTITY ();


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
        ///   GUIEntity get_tutorialPanelEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tutorialPanelEntity")]
        ///  extern nint GET_TUTORIAL_PANEL_ENTITY ();


        /// <summary>
        ///   UIButtonHeldConfirmedNormalizedSampleComponent get_uIButtonHeldConfirmedNormalizedSample()
        /// </summary>
        /// <returns>class UIButtonHeldConfirmedNormalizedSampleComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonHeldConfirmedNormalizedSample")]
        ///  extern nint GET_U_I_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE ();


        /// <summary>
        ///   GUIEntity get_uIButtonHeldConfirmedNormalizedSampleEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonHeldConfirmedNormalizedSampleEntity")]
        ///  extern nint GET_U_I_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE_ENTITY ();


        /// <summary>
        ///   UIButtonMouseEventsComponent get_uIButtonMouseEvents()
        /// </summary>
        /// <returns>class UIButtonMouseEventsComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonMouseEvents")]
        ///  extern nint GET_U_I_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   GUIEntity get_uIButtonMouseEventsEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIButtonMouseEventsEntity")]
        ///  extern nint GET_U_I_BUTTON_MOUSE_EVENTS_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uICommandOwnerEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandOwnerEntity")]
        ///  extern nint GET_U_I_COMMAND_OWNER_ENTITY ();


        /// <summary>
        ///   UICommandRelayEventComponent get_uICommandRelayEvent()
        /// </summary>
        /// <returns>class UICommandRelayEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandRelayEvent")]
        ///  extern nint GET_U_I_COMMAND_RELAY_EVENT ();


        /// <summary>
        ///   GUIEntity get_uICommandRelayEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uICommandRelayEventEntity")]
        ///  extern nint GET_U_I_COMMAND_RELAY_EVENT_ENTITY ();


        /// <summary>
        ///   UIControllerPanelExitEventComponent get_uIControllerPanelExitEvent()
        /// </summary>
        /// <returns>class UIControllerPanelExitEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIControllerPanelExitEvent")]
        ///  extern nint GET_U_I_CONTROLLER_PANEL_EXIT_EVENT ();


        /// <summary>
        ///   GUIEntity get_uIControllerPanelExitEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIControllerPanelExitEventEntity")]
        ///  extern nint GET_U_I_CONTROLLER_PANEL_EXIT_EVENT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uIEquipmentUpgradeLevelUpEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIEquipmentUpgradeLevelUpEventEntity")]
        ///  extern nint GET_U_I_EQUIPMENT_UPGRADE_LEVEL_UP_EVENT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uIEquipmentUpgradeLockBreakLevelUpEventEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIEquipmentUpgradeLockBreakLevelUpEventEntity")]
        ///  extern nint GET_U_I_EQUIPMENT_UPGRADE_LOCK_BREAK_LEVEL_UP_EVENT_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uIInputBlockedEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInputBlockedEntity")]
        ///  extern nint GET_U_I_INPUT_BLOCKED_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uIInputMouseBlockedEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInputMouseBlockedEntity")]
        ///  extern nint GET_U_I_INPUT_MOUSE_BLOCKED_ENTITY ();


        /// <summary>
        ///   UIInventoryPanelCanvasComponent get_uIInventoryPanelCanvas()
        /// </summary>
        /// <returns>class UIInventoryPanelCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryPanelCanvas")]
        ///  extern nint GET_U_I_INVENTORY_PANEL_CANVAS ();


        /// <summary>
        ///   GUIEntity get_uIInventoryPanelCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryPanelCanvasEntity")]
        ///  extern nint GET_U_I_INVENTORY_PANEL_CANVAS_ENTITY ();


        /// <summary>
        ///   UIInventoryTabLink get_uIInventoryTabLink()
        /// </summary>
        /// <returns>class UIInventoryTabLink</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryTabLink")]
        ///  extern nint GET_U_I_INVENTORY_TAB_LINK ();


        /// <summary>
        ///   GUIEntity get_uIInventoryTabLinkEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIInventoryTabLinkEntity")]
        ///  extern nint GET_U_I_INVENTORY_TAB_LINK_ENTITY ();


        /// <summary>
        ///   GUIEntity get_uIMouseInteractionModeEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIMouseInteractionModeEntity")]
        ///  extern nint GET_U_I_MOUSE_INTERACTION_MODE_ENTITY ();


        /// <summary>
        ///   UIPanelRootCanvasComponent get_uIPanelRootCanvas()
        /// </summary>
        /// <returns>class UIPanelRootCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelRootCanvas")]
        ///  extern nint GET_U_I_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   GUIEntity get_uIPanelRootCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelRootCanvasEntity")]
        ///  extern nint GET_U_I_PANEL_ROOT_CANVAS_ENTITY ();


        /// <summary>
        ///   UIPanelUnderlayMaskComponent get_uIPanelUnderlayMask()
        /// </summary>
        /// <returns>class UIPanelUnderlayMaskComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelUnderlayMask")]
        ///  extern nint GET_U_I_PANEL_UNDERLAY_MASK ();


        /// <summary>
        ///   GUIEntity get_uIPanelUnderlayMaskEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_uIPanelUnderlayMaskEntity")]
        ///  extern nint GET_U_I_PANEL_UNDERLAY_MASK_ENTITY ();


        /// <summary>
        ///   VideoSubtitlesComponent get_videoSubtitles()
        /// </summary>
        /// <returns>class VideoSubtitlesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_videoSubtitles")]
        ///  extern nint GET_VIDEO_SUBTITLES ();


        /// <summary>
        ///   GUIEntity get_videoSubtitlesEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_videoSubtitlesEntity")]
        ///  extern nint GET_VIDEO_SUBTITLES_ENTITY ();


        /// <summary>
        ///   GUIEntity get_worldAnchorEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldAnchorEntity")]
        ///  extern nint GET_WORLD_ANCHOR_ENTITY ();


        /// <summary>
        ///   WorldDialogueCanvasComponent get_worldDialogueCanvas()
        /// </summary>
        /// <returns>class WorldDialogueCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialogueCanvas")]
        ///  extern nint GET_WORLD_DIALOGUE_CANVAS ();


        /// <summary>
        ///   GUIEntity get_worldDialogueCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDialogueCanvasEntity")]
        ///  extern nint GET_WORLD_DIALOGUE_CANVAS_ENTITY ();


        /// <summary>
        ///   WorldTextCanvasComponent get_worldTextCanvas()
        /// </summary>
        /// <returns>class WorldTextCanvasComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldTextCanvas")]
        ///  extern nint GET_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   GUIEntity get_worldTextCanvasEntity()
        /// </summary>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldTextCanvasEntity")]
        ///  extern nint GET_WORLD_TEXT_CANVAS_ENTITY ();


        /// <summary>
        ///   GUIEntity[] GetEntities()
        /// </summary>
        /// <returns>class GUIEntity[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntities")]
        ///  extern nint GET_ENTITIES ();


        /// <summary>
        ///   Entitas.IEntityIndex GetEntityIndex(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>interface Entitas.IEntityIndex</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntityIndex")]
        ///  extern nint GET_ENTITY_INDEX (nint name);


        /// <summary>
        ///   Entitas.IGroup<GUIEntity> GetGroup(Entitas.IMatcher<GUIEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<GUIEntity></param>
        /// <returns>interface Entitas.IGroup<GUIEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
        ///  extern nint GET_GROUP (nint matcher);


        /// <summary>
        ///   System.Boolean HasEntity(GUIEntity entity)
        /// </summary>
        /// <param name="entity">class GUIEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasEntity")]
        ///  extern System.Boolean HAS_ENTITY (nint entity);


        /// <summary>
        ///   System.Void onDestroyEntity(Entitas.IEntity entity)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("onDestroyEntity")]
        ///  extern void ON_DESTROY_ENTITY (nint entity);


        /// <summary>
        ///   System.Void onEntityReleased(Entitas.IEntity entity)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("onEntityReleased")]
        ///  extern void ON_ENTITY_RELEASED (nint entity);


        /// <summary>
        ///   System.Void remove_OnEntityCreated(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityCreated")]
        ///  extern void REMOVE_ON_ENTITY_CREATED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityDestroyed")]
        ///  extern void REMOVE_ON_ENTITY_DESTROYED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityWillBeDestroyed(Entitas.ContextEntityChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextEntityChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityWillBeDestroyed")]
        ///  extern void REMOVE_ON_ENTITY_WILL_BE_DESTROYED (nint value);


        /// <summary>
        ///   System.Void remove_OnGroupCreated(Entitas.ContextGroupChanged value)
        /// </summary>
        /// <param name="value">class Entitas.ContextGroupChanged</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnGroupCreated")]
        ///  extern void REMOVE_ON_GROUP_CREATED (nint value);


        /// <summary>
        ///   System.Void RemoveAllEventHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllEventHandlers")]
        ///  extern void REMOVE_ALL_EVENT_HANDLERS ();


        /// <summary>
        ///   System.Void RemoveCallToActionPreorderPanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCallToActionPreorderPanel")]
        ///  extern void REMOVE_CALL_TO_ACTION_PREORDER_PANEL ();


        /// <summary>
        ///   System.Void RemoveChestTitlePanel()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChestTitlePanel")]
        ///  extern void REMOVE_CHEST_TITLE_PANEL ();


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
        ///   System.Void RemoveMapIconCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapIconCanvas")]
        ///  extern void REMOVE_MAP_ICON_CANVAS ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GUIContext))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GUIEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="entityFactory">class System.Func<GUIEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GUIContext))]
        ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GUIEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="startCreationIndex">struct System.Int32</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
        /// <param name="entityFactory">class System.Func<GUIEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GUIContext))]
        ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);


        /// public static partial class Search_GUIContext
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
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GUIEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<GUIEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GUIEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<GUIEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["ProjectStar".""."GUIContext"]
    /// </summary>
    public partial class GUIContext
    {



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
        ///   System.Void RemovePlayerShipHealthUI()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerShipHealthUI")]
        ///  extern void REMOVE_PLAYER_SHIP_HEALTH_UI ();


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
        ///   System.Void RemoveUIButtonMouseEvents()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIButtonMouseEvents")]
        ///  extern void REMOVE_UI_BUTTON_MOUSE_EVENTS ();


        /// <summary>
        ///   System.Void RemoveUICommandRelayEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUICommandRelayEvent")]
        ///  extern void REMOVE_UI_COMMAND_RELAY_EVENT ();


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
        ///   System.Void RemoveUIPanelRootCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelRootCanvas")]
        ///  extern void REMOVE_UI_PANEL_ROOT_CANVAS ();


        /// <summary>
        ///   System.Void RemoveUIPanelUnderlayMask()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUIPanelUnderlayMask")]
        ///  extern void REMOVE_UI_PANEL_UNDERLAY_MASK ();


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
        ///   System.Void RemoveWorldTextCanvas()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldTextCanvas")]
        ///  extern void REMOVE_WORLD_TEXT_CANVAS ();


        /// <summary>
        ///   System.Void ReplaceCallToActionPreorderPanel(UICallToActionScreenController newValue)
        /// </summary>
        /// <param name="newValue">class UICallToActionScreenController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCallToActionPreorderPanel")]
        ///  extern void REPLACE_CALL_TO_ACTION_PREORDER_PANEL (nint newValue);


        /// <summary>
        ///   System.Void ReplaceChestTitlePanel(ChestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class ChestTitlePanel</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChestTitlePanel")]
        ///  extern void REPLACE_CHEST_TITLE_PANEL (nint newValue);


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
        ///   System.Void ReplacePlayerShipHealthUI(PlayerShipHealthUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerShipHealthUIBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerShipHealthUI")]
        ///  extern void REPLACE_PLAYER_SHIP_HEALTH_UI (nint newValue);


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
        ///   System.Void ReplaceUIButtonMouseEvents(UIButtonMouseEventRelays newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonMouseEventRelays</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIButtonMouseEvents")]
        ///  extern void REPLACE_UI_BUTTON_MOUSE_EVENTS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUICommandRelayEvent(UICommandRelayEvent newValue)
        /// </summary>
        /// <param name="newValue">class UICommandRelayEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUICommandRelayEvent")]
        ///  extern void REPLACE_UI_COMMAND_RELAY_EVENT (nint newValue);


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
        ///   System.Void ReplaceUIPanelRootCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelRootCanvas")]
        ///  extern void REPLACE_UI_PANEL_ROOT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void ReplaceUIPanelUnderlayMask(UIPanelUnderlayMask newMask)
        /// </summary>
        /// <param name="newMask">class UIPanelUnderlayMask</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUIPanelUnderlayMask")]
        ///  extern void REPLACE_UI_PANEL_UNDERLAY_MASK (nint newMask);


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
        ///   System.Void ReplaceWorldTextCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldTextCanvas")]
        ///  extern void REPLACE_WORLD_TEXT_CANVAS (nint newValue);


        /// <summary>
        ///   System.Void Reset()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reset")]
        ///  extern void RESET ();


        /// <summary>
        ///   System.Void ResetCreationIndex()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetCreationIndex")]
        ///  extern void RESET_CREATION_INDEX ();


        /// <summary>
        ///   System.Void set_isAttackTellCanvas(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAttackTellCanvas")]
        ///  extern void SET_IS_ATTACK_TELL_CANVAS (System.Boolean value);


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
        ///   GUIEntity SetCallToActionPreorderPanel(UICallToActionScreenController newValue)
        /// </summary>
        /// <param name="newValue">class UICallToActionScreenController</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCallToActionPreorderPanel")]
        ///  extern nint SET_CALL_TO_ACTION_PREORDER_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetChestTitlePanel(ChestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class ChestTitlePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetChestTitlePanel")]
        ///  extern nint SET_CHEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetConfirmationPanel(ConfirmationPanel newValue)
        /// </summary>
        /// <param name="newValue">class ConfirmationPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetConfirmationPanel")]
        ///  extern nint SET_CONFIRMATION_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetCreditsPanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCreditsPanel")]
        ///  extern nint SET_CREDITS_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetCrystalUI(CrystalUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class CrystalUIBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCrystalUI")]
        ///  extern nint SET_CRYSTAL_UI (nint newValue);


        /// <summary>
        ///   GUIEntity SetDialogueChoice(DialogueChoiceType newValue)
        /// </summary>
        /// <param name="newValue">enum DialogueChoiceType</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetDialogueChoice")]
        ///  extern nint SET_DIALOGUE_CHOICE (DialogueChoiceType newValue);


        /// <summary>
        ///   GUIEntity SetDungeonCompletePanel(DungeonCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class DungeonCompletePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetDungeonCompletePanel")]
        ///  extern nint SET_DUNGEON_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetEndGameSplashPanel(EndGameSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class EndGameSplashPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEndGameSplashPanel")]
        ///  extern nint SET_END_GAME_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetEquipmentAwardPanel(EquipmentAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class EquipmentAwardPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEquipmentAwardPanel")]
        ///  extern nint SET_EQUIPMENT_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetExpBarUI(ExpBarUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class ExpBarUIBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetExpBarUI")]
        ///  extern nint SET_EXP_BAR_UI (nint newValue);


        /// <summary>
        ///   GUIEntity SetFullScreenDialogueFocusPanel(FullScreenDialogueFocusPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenDialogueFocusPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFullScreenDialogueFocusPanel")]
        ///  extern nint SET_FULL_SCREEN_DIALOGUE_FOCUS_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetFullScreenImageSplashPanel(FullScreenImageSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenImageSplashPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFullScreenImageSplashPanel")]
        ///  extern nint SET_FULL_SCREEN_IMAGE_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetFullScreenTextSplashPanel(FullScreenTextSplashPanel newValue)
        /// </summary>
        /// <param name="newValue">class FullScreenTextSplashPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFullScreenTextSplashPanel")]
        ///  extern nint SET_FULL_SCREEN_TEXT_SPLASH_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetGameOverPanel(GameOverPanel newValue)
        /// </summary>
        /// <param name="newValue">class GameOverPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameOverPanel")]
        ///  extern nint SET_GAME_OVER_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetGoldUI(GoldUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class GoldUIBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoldUI")]
        ///  extern nint SET_GOLD_UI (nint newValue);


        /// <summary>
        ///   GUIEntity SetInfinityTowerProgressPanel(InfinityTowerProgressPanel newValue)
        /// </summary>
        /// <param name="newValue">class InfinityTowerProgressPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInfinityTowerProgressPanel")]
        ///  extern nint SET_INFINITY_TOWER_PROGRESS_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetInstanceTitlePanel(InstanceTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class InstanceTitlePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInstanceTitlePanel")]
        ///  extern nint SET_INSTANCE_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetInventoryPanel(UIInventoryPanel newValue)
        /// </summary>
        /// <param name="newValue">class UIInventoryPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInventoryPanel")]
        ///  extern nint SET_INVENTORY_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetInventoryPickupUIController(InventoryPickupUIController newValue)
        /// </summary>
        /// <param name="newValue">class InventoryPickupUIController</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInventoryPickupUIController")]
        ///  extern nint SET_INVENTORY_PICKUP_UI_CONTROLLER (nint newValue);


        /// <summary>
        ///   GUIEntity SetInventoryUser(System.Int32 newPlayerID)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInventoryUser")]
        ///  extern nint SET_INVENTORY_USER (System.Int32 newPlayerID);


        /// <summary>
        ///   GUIEntity SetLanguagePanel(LanguageControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class LanguageControllerPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLanguagePanel")]
        ///  extern nint SET_LANGUAGE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetLastSelectedUIButtonInfo(System.Int32 newPlayerID, UIButton newValue)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newValue">class UIButton</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLastSelectedUIButtonInfo")]
        ///  extern nint SET_LAST_SELECTED_UI_BUTTON_INFO (System.Int32 newPlayerID, nint newValue);


        /// <summary>
        ///   GUIEntity SetLevelUpPanel(LevelUpPanel newValue)
        /// </summary>
        /// <param name="newValue">class LevelUpPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLevelUpPanel")]
        ///  extern nint SET_LEVEL_UP_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetMapIconCanvas(UnityEngine.Canvas newCanvas, UnityEngine.UI.CanvasScaler newCanvasScaler)
        /// </summary>
        /// <param name="newCanvas">class UnityEngine.Canvas</param>
        /// <param name="newCanvasScaler">class UnityEngine.UI.CanvasScaler</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapIconCanvas")]
        ///  extern nint SET_MAP_ICON_CANVAS (nint newCanvas, nint newCanvasScaler);


        /// <summary>
        ///   GUIEntity SetMapInteractionMode(MapInteractionMode newValue)
        /// </summary>
        /// <param name="newValue">enum MapInteractionMode</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapInteractionMode")]
        ///  extern nint SET_MAP_INTERACTION_MODE (MapInteractionMode newValue);


        /// <summary>
        ///   GUIEntity SetMapMarkerWorldScreenEdgeIndicator(MapScreenEdgeIndicator newValue)
        /// </summary>
        /// <param name="newValue">class MapScreenEdgeIndicator</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapMarkerWorldScreenEdgeIndicator")]
        ///  extern nint SET_MAP_MARKER_WORLD_SCREEN_EDGE_INDICATOR (nint newValue);


        /// <summary>
        ///   GUIEntity SetMapPanel(MapPanel newValue)
        /// </summary>
        /// <param name="newValue">class MapPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapPanel")]
        ///  extern nint SET_MAP_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetMapUICenterCrosshair(MapUICenterCrosshair newValue)
        /// </summary>
        /// <param name="newValue">class MapUICenterCrosshair</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapUICenterCrosshair")]
        ///  extern nint SET_MAP_UI_CENTER_CROSSHAIR (nint newValue);


        /// <summary>
        ///   GUIEntity SetMessagePanel(MessagePanel newValue)
        /// </summary>
        /// <param name="newValue">class MessagePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMessagePanel")]
        ///  extern nint SET_MESSAGE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetMessagePanelPromptPlayersConnectionState(MessagePanelPromptPlayersConnectionState newValue)
        /// </summary>
        /// <param name="newValue">enum MessagePanelPromptPlayersConnectionState</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMessagePanelPromptPlayersConnectionState")]
        ///  extern nint SET_MESSAGE_PANEL_PROMPT_PLAYERS_CONNECTION_STATE (MessagePanelPromptPlayersConnectionState newValue);


        /// <summary>
        ///   GUIEntity SetMouseSelectedUIButton(UIButton newValue)
        /// </summary>
        /// <param name="newValue">class UIButton</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMouseSelectedUIButton")]
        ///  extern nint SET_MOUSE_SELECTED_UI_BUTTON (nint newValue);


        /// <summary>
        ///   GUIEntity SetOptionsPanel(OptionsControllerPanel newValue)
        /// </summary>
        /// <param name="newValue">class OptionsControllerPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetOptionsPanel")]
        ///  extern nint SET_OPTIONS_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetPlayerHUD(PlayerUICanvasBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerUICanvasBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayerHUD")]
        ///  extern nint SET_PLAYER_HUD (nint newValue);


        /// <summary>
        ///   GUIEntity SetPlayerPromptHUD(PlayerPromptHUD newValue)
        /// </summary>
        /// <param name="newValue">class PlayerPromptHUD</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayerPromptHUD")]
        ///  extern nint SET_PLAYER_PROMPT_HUD (nint newValue);


        /// <summary>
        ///   GUIEntity SetPlayerShipHealthUI(PlayerShipHealthUIBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class PlayerShipHealthUIBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayerShipHealthUI")]
        ///  extern nint SET_PLAYER_SHIP_HEALTH_UI (nint newValue);


        /// <summary>
        ///   GUIEntity SetQuestCompletePanel(QuestCompletePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestCompletePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetQuestCompletePanel")]
        ///  extern nint SET_QUEST_COMPLETE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetQuestItemAwardPanel(QuestItemAwardPanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestItemAwardPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetQuestItemAwardPanel")]
        ///  extern nint SET_QUEST_ITEM_AWARD_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetQuestTitlePanel(QuestTitlePanel newValue)
        /// </summary>
        /// <param name="newValue">class QuestTitlePanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetQuestTitlePanel")]
        ///  extern nint SET_QUEST_TITLE_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetSaveLoadPanel(SaveLoadPanel newValue)
        /// </summary>
        /// <param name="newValue">class SaveLoadPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSaveLoadPanel")]
        ///  extern nint SET_SAVE_LOAD_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetSaveNotifierHUD(SaveNotifierHUDBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class SaveNotifierHUDBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSaveNotifierHUD")]
        ///  extern nint SET_SAVE_NOTIFIER_HUD (nint newValue);


        /// <summary>
        ///   GUIEntity SetScreenDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetScreenDialogueCanvas")]
        ///  extern nint SET_SCREEN_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   GUIEntity SetSelectionConfirmHeldTickCompleteEvent(UIButton newTargetBtn)
        /// </summary>
        /// <param name="newTargetBtn">class UIButton</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSelectionConfirmHeldTickCompleteEvent")]
        ///  extern nint SET_SELECTION_CONFIRM_HELD_TICK_COMPLETE_EVENT (nint newTargetBtn);


        /// <summary>
        ///   GUIEntity SetSplashTitleBackground(TitleBackgroundReference newValue)
        /// </summary>
        /// <param name="newValue">class TitleBackgroundReference</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSplashTitleBackground")]
        ///  extern nint SET_SPLASH_TITLE_BACKGROUND (nint newValue);


        /// <summary>
        ///   GUIEntity SetToggleInventoryCommand(System.Int32 newPlayerID, GenericTabType newDirectTypeEntry)
        /// </summary>
        /// <param name="newPlayerID">struct System.Int32</param>
        /// <param name="newDirectTypeEntry">enum GenericTabType</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetToggleInventoryCommand")]
        ///  extern nint SET_TOGGLE_INVENTORY_COMMAND (System.Int32 newPlayerID, GenericTabType newDirectTypeEntry);


        /// <summary>
        ///   GUIEntity SetTutorialPanel(TutorialPanel newValue)
        /// </summary>
        /// <param name="newValue">class TutorialPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTutorialPanel")]
        ///  extern nint SET_TUTORIAL_PANEL (nint newValue);


        /// <summary>
        ///   GUIEntity SetUIButtonHeldConfirmedNormalizedSample(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIButtonHeldConfirmedNormalizedSample")]
        ///  extern nint SET_UI_BUTTON_HELD_CONFIRMED_NORMALIZED_SAMPLE (System.Single newValue);


        /// <summary>
        ///   GUIEntity SetUIButtonMouseEvents(UIButtonMouseEventRelays newValue)
        /// </summary>
        /// <param name="newValue">class UIButtonMouseEventRelays</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIButtonMouseEvents")]
        ///  extern nint SET_UI_BUTTON_MOUSE_EVENTS (nint newValue);


        /// <summary>
        ///   GUIEntity SetUICommandRelayEvent(UICommandRelayEvent newValue)
        /// </summary>
        /// <param name="newValue">class UICommandRelayEvent</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUICommandRelayEvent")]
        ///  extern nint SET_UI_COMMAND_RELAY_EVENT (nint newValue);


        /// <summary>
        ///   GUIEntity SetUIControllerPanelExitEvent(UIControllerPanel newPanel)
        /// </summary>
        /// <param name="newPanel">class UIControllerPanel</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIControllerPanelExitEvent")]
        ///  extern nint SET_UI_CONTROLLER_PANEL_EXIT_EVENT (nint newPanel);


        /// <summary>
        ///   GUIEntity SetUIInventoryPanelCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIInventoryPanelCanvas")]
        ///  extern nint SET_UI_INVENTORY_PANEL_CANVAS (nint newValue);


        /// <summary>
        ///   GUIEntity SetUIInventoryTabLink(UITabBtn newTabBtn)
        /// </summary>
        /// <param name="newTabBtn">class UITabBtn</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIInventoryTabLink")]
        ///  extern nint SET_UI_INVENTORY_TAB_LINK (nint newTabBtn);


        /// <summary>
        ///   GUIEntity SetUIPanelRootCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIPanelRootCanvas")]
        ///  extern nint SET_UI_PANEL_ROOT_CANVAS (nint newValue);


        /// <summary>
        ///   GUIEntity SetUIPanelUnderlayMask(UIPanelUnderlayMask newMask)
        /// </summary>
        /// <param name="newMask">class UIPanelUnderlayMask</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUIPanelUnderlayMask")]
        ///  extern nint SET_UI_PANEL_UNDERLAY_MASK (nint newMask);


        /// <summary>
        ///   GUIEntity SetVideoSubtitles(VideoSubtitlesBehaviour newValue)
        /// </summary>
        /// <param name="newValue">class VideoSubtitlesBehaviour</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVideoSubtitles")]
        ///  extern nint SET_VIDEO_SUBTITLES (nint newValue);


        /// <summary>
        ///   GUIEntity SetWorldDialogueCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetWorldDialogueCanvas")]
        ///  extern nint SET_WORLD_DIALOGUE_CANVAS (nint newValue);


        /// <summary>
        ///   GUIEntity SetWorldTextCanvas(UnityEngine.Canvas newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Canvas</param>
        /// <returns>class GUIEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetWorldTextCanvas")]
        ///  extern nint SET_WORLD_TEXT_CANVAS (nint newValue);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();


        /// <summary>
        ///   System.Void updateGroupsComponentAddedOrRemoved(Entitas.IEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("updateGroupsComponentAddedOrRemoved")]
        ///  extern void UPDATE_GROUPS_COMPONENT_ADDED_OR_REMOVED (nint entity, System.Int32 index, nint component);


        /// <summary>
        ///   System.Void updateGroupsComponentReplaced(Entitas.IEntity entity, System.Int32 index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent)
        /// </summary>
        /// <param name="entity">interface Entitas.IEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="previousComponent">interface Entitas.IComponent</param>
        /// <param name="newComponent">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("updateGroupsComponentReplaced")]
        ///  extern void UPDATE_GROUPS_COMPONENT_REPLACED (nint entity, System.Int32 index, nint previousComponent, nint newComponent);




        /// public static partial class Search_GUIContext
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}