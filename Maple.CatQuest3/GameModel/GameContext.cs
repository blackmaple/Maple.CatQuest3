
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{
    
    
    /// <summary>
    /// class ["ProjectStar".""."GameContext"]
    /// [Entitas.Context<GameEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000638U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116])]
    
                
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
            
    // class 0x24 System.Func<GameEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]
            
    // class 0x28 System.Collections.Generic.HashSet<GameEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]
            
    // class 0x2C System.Collections.Generic.Stack<GameEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]
            
    // class 0x30 System.Collections.Generic.HashSet<GameEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]
            
    // class 0x34 System.Collections.Generic.Dictionary<Entitas.IMatcher<GameEntity>,Entitas.IGroup<GameEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]
            
    // class 0x38 System.Collections.Generic.List<Entitas.IGroup<GameEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]
            
    // class 0x3C DesperateDevs.Caching.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<GameEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]
            
    // class 0x40 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]
            
    // class 0x44 GameEntity[] _entitiesCache
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
    public partial class GameContext
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameContext";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x02000638U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameContext obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."GameContext"]
        /// </summary>
        public partial class GameContext
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
            ///   GameEntity CreateEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
            ///  extern nint CREATE_ENTITY ();

            
            /// <summary>
            ///   System.Void DestroyAllEntities()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
            ///  extern void DESTROY_ALL_ENTITIES ();

            
            /// <summary>
            ///   ActiveScreenEffectPlayerComponent get_activeScreenEffectPlayer()
            /// </summary>
            /// <returns>class ActiveScreenEffectPlayerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activeScreenEffectPlayer")]
            ///  extern nint GET_ACTIVE_SCREEN_EFFECT_PLAYER ();

            
            /// <summary>
            ///   GameEntity get_activeScreenEffectPlayerEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_activeScreenEffectPlayerEntity")]
            ///  extern nint GET_ACTIVE_SCREEN_EFFECT_PLAYER_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_addPlayerEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_addPlayerEventEntity")]
            ///  extern nint GET_ADD_PLAYER_EVENT_ENTITY ();

            
            /// <summary>
            ///   AwardedQuestItemsComponent get_awardedQuestItems()
            /// </summary>
            /// <returns>class AwardedQuestItemsComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_awardedQuestItems")]
            ///  extern nint GET_AWARDED_QUEST_ITEMS ();

            
            /// <summary>
            ///   GameEntity get_awardedQuestItemsEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_awardedQuestItemsEntity")]
            ///  extern nint GET_AWARDED_QUEST_ITEMS_ENTITY ();

            
            /// <summary>
            ///   ChestInteractorComponent get_chestInteractor()
            /// </summary>
            /// <returns>class ChestInteractorComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestInteractor")]
            ///  extern nint GET_CHEST_INTERACTOR ();

            
            /// <summary>
            ///   GameEntity get_chestInteractorEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_chestInteractorEntity")]
            ///  extern nint GET_CHEST_INTERACTOR_ENTITY ();

            
            /// <summary>
            ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
            /// </summary>
            /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
            ///  extern nint GET_COMPONENT_POOLS ();

            
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
            ///   GameEntity get_cutSceneFastForwardBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cutSceneFastForwardBlockedEntity")]
            ///  extern nint GET_CUT_SCENE_FAST_FORWARD_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_cutSceneFastForwardEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cutSceneFastForwardEntity")]
            ///  extern nint GET_CUT_SCENE_FAST_FORWARD_ENTITY ();

            
            /// <summary>
            ///   CutsceneOwnerComponent get_cutsceneOwner()
            /// </summary>
            /// <returns>class CutsceneOwnerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cutsceneOwner")]
            ///  extern nint GET_CUTSCENE_OWNER ();

            
            /// <summary>
            ///   GameEntity get_cutsceneOwnerEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cutsceneOwnerEntity")]
            ///  extern nint GET_CUTSCENE_OWNER_ENTITY ();

            
            /// <summary>
            ///   DockRepairOccupantsUpdatedEvent get_dockRepairOccupantsUpdatedEvent()
            /// </summary>
            /// <returns>class DockRepairOccupantsUpdatedEvent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dockRepairOccupantsUpdatedEvent")]
            ///  extern nint GET_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();

            
            /// <summary>
            ///   GameEntity get_dockRepairOccupantsUpdatedEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dockRepairOccupantsUpdatedEventEntity")]
            ///  extern nint GET_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_equipmentUpgradeShopInteractableEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equipmentUpgradeShopInteractableEntity")]
            ///  extern nint GET_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE_ENTITY ();

            
            /// <summary>
            ///   EquippedPlayerShipSpellsComponent get_equippedPlayerShipSpells()
            /// </summary>
            /// <returns>class EquippedPlayerShipSpellsComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedPlayerShipSpells")]
            ///  extern nint GET_EQUIPPED_PLAYER_SHIP_SPELLS ();

            
            /// <summary>
            ///   GameEntity get_equippedPlayerShipSpellsEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedPlayerShipSpellsEntity")]
            ///  extern nint GET_EQUIPPED_PLAYER_SHIP_SPELLS_ENTITY ();

            
            /// <summary>
            ///   EquippedShipBlueprintsComponent get_equippedShipBlueprints()
            /// </summary>
            /// <returns>class EquippedShipBlueprintsComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedShipBlueprints")]
            ///  extern nint GET_EQUIPPED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   GameEntity get_equippedShipBlueprintsEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_equippedShipBlueprintsEntity")]
            ///  extern nint GET_EQUIPPED_SHIP_BLUEPRINTS_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_floatBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_floatBlockedEntity")]
            ///  extern nint GET_FLOAT_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   GameDifficultyComponent get_gameDifficulty()
            /// </summary>
            /// <returns>class GameDifficultyComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficulty")]
            ///  extern nint GET_GAME_DIFFICULTY ();

            
            /// <summary>
            ///   GameDifficultyDamageModifierComponent get_gameDifficultyDamageModifier()
            /// </summary>
            /// <returns>class GameDifficultyDamageModifierComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyDamageModifier")]
            ///  extern nint GET_GAME_DIFFICULTY_DAMAGE_MODIFIER ();

            
            /// <summary>
            ///   GameEntity get_gameDifficultyDamageModifierEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyDamageModifierEntity")]
            ///  extern nint GET_GAME_DIFFICULTY_DAMAGE_MODIFIER_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_gameDifficultyEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyEntity")]
            ///  extern nint GET_GAME_DIFFICULTY_ENTITY ();

            
            /// <summary>
            ///   GameDifficultyHeathModifierComponent get_gameDifficultyHeathModifier()
            /// </summary>
            /// <returns>class GameDifficultyHeathModifierComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyHeathModifier")]
            ///  extern nint GET_GAME_DIFFICULTY_HEATH_MODIFIER ();

            
            /// <summary>
            ///   GameEntity get_gameDifficultyHeathModifierEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameDifficultyHeathModifierEntity")]
            ///  extern nint GET_GAME_DIFFICULTY_HEATH_MODIFIER_ENTITY ();

            
            /// <summary>
            ///   GameOverEventComponent get_gameOverEvent()
            /// </summary>
            /// <returns>class GameOverEventComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverEvent")]
            ///  extern nint GET_GAME_OVER_EVENT ();

            
            /// <summary>
            ///   GameEntity get_gameOverEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverEventEntity")]
            ///  extern nint GET_GAME_OVER_EVENT_ENTITY ();

            
            /// <summary>
            ///   GameOverNoSaveOverrideComponent get_gameOverNoSaveOverride()
            /// </summary>
            /// <returns>class GameOverNoSaveOverrideComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverNoSaveOverride")]
            ///  extern nint GET_GAME_OVER_NO_SAVE_OVERRIDE ();

            
            /// <summary>
            ///   GameEntity get_gameOverNoSaveOverrideEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverNoSaveOverrideEntity")]
            ///  extern nint GET_GAME_OVER_NO_SAVE_OVERRIDE_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_globalInteractBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_globalInteractBlockedEntity")]
            ///  extern nint GET_GLOBAL_INTERACT_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   System.Boolean get_hasActiveScreenEffectPlayer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasActiveScreenEffectPlayer")]
            ///  extern System.Boolean GET_HAS_ACTIVE_SCREEN_EFFECT_PLAYER ();

            
            /// <summary>
            ///   System.Boolean get_hasAwardedQuestItems()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasAwardedQuestItems")]
            ///  extern System.Boolean GET_HAS_AWARDED_QUEST_ITEMS ();

            
            /// <summary>
            ///   System.Boolean get_hasChestInteractor()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChestInteractor")]
            ///  extern System.Boolean GET_HAS_CHEST_INTERACTOR ();

            
            /// <summary>
            ///   System.Boolean get_hasCutsceneOwner()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCutsceneOwner")]
            ///  extern System.Boolean GET_HAS_CUTSCENE_OWNER ();

            
            /// <summary>
            ///   System.Boolean get_hasDockRepairOccupantsUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasDockRepairOccupantsUpdatedEvent")]
            ///  extern System.Boolean GET_HAS_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_hasEquippedPlayerShipSpells()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedPlayerShipSpells")]
            ///  extern System.Boolean GET_HAS_EQUIPPED_PLAYER_SHIP_SPELLS ();

            
            /// <summary>
            ///   System.Boolean get_hasEquippedShipBlueprints()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasEquippedShipBlueprints")]
            ///  extern System.Boolean GET_HAS_EQUIPPED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   System.Boolean get_hasGameDifficulty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficulty")]
            ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY ();

            
            /// <summary>
            ///   System.Boolean get_hasGameDifficultyDamageModifier()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficultyDamageModifier")]
            ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY_DAMAGE_MODIFIER ();

            
            /// <summary>
            ///   System.Boolean get_hasGameDifficultyHeathModifier()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameDifficultyHeathModifier")]
            ///  extern System.Boolean GET_HAS_GAME_DIFFICULTY_HEATH_MODIFIER ();

            
            /// <summary>
            ///   System.Boolean get_hasGameOverEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameOverEvent")]
            ///  extern System.Boolean GET_HAS_GAME_OVER_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_hasGameOverNoSaveOverride()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameOverNoSaveOverride")]
            ///  extern System.Boolean GET_HAS_GAME_OVER_NO_SAVE_OVERRIDE ();

            
            /// <summary>
            ///   System.Boolean get_hasInfinityTowerTimer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInfinityTowerTimer")]
            ///  extern System.Boolean GET_HAS_INFINITY_TOWER_TIMER ();

            
            /// <summary>
            ///   System.Boolean get_hasInventoryCommand()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInventoryCommand")]
            ///  extern System.Boolean GET_HAS_INVENTORY_COMMAND ();

            
            /// <summary>
            ///   System.Boolean get_hasInvisibleWall()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInvisibleWall")]
            ///  extern System.Boolean GET_HAS_INVISIBLE_WALL ();

            
            /// <summary>
            ///   System.Boolean get_hasLatestInfinityTowerClearedWave()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLatestInfinityTowerClearedWave")]
            ///  extern System.Boolean GET_HAS_LATEST_INFINITY_TOWER_CLEARED_WAVE ();

            
            /// <summary>
            ///   System.Boolean get_hasObjectiveInteractor()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasObjectiveInteractor")]
            ///  extern System.Boolean GET_HAS_OBJECTIVE_INTERACTOR ();

            
            /// <summary>
            ///   System.Boolean get_hasOverrideCharacterGender()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOverrideCharacterGender")]
            ///  extern System.Boolean GET_HAS_OVERRIDE_CHARACTER_GENDER ();

            
            /// <summary>
            ///   System.Boolean get_hasPlayerKilledSource()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPlayerKilledSource")]
            ///  extern System.Boolean GET_HAS_PLAYER_KILLED_SOURCE ();

            
            /// <summary>
            ///   System.Boolean get_hasPoolStatusTable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPoolStatusTable")]
            ///  extern System.Boolean GET_HAS_POOL_STATUS_TABLE ();

            
            /// <summary>
            ///   System.Boolean get_hasPromptRemovePlayerEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPromptRemovePlayerEvent")]
            ///  extern System.Boolean GET_HAS_PROMPT_REMOVE_PLAYER_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_hasSecondPlayer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSecondPlayer")]
            ///  extern System.Boolean GET_HAS_SECOND_PLAYER ();

            
            /// <summary>
            ///   System.Boolean get_hasSelectedTavernTalesData()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSelectedTavernTalesData")]
            ///  extern System.Boolean GET_HAS_SELECTED_TAVERN_TALES_DATA ();

            
            /// <summary>
            ///   System.Boolean get_hasShipBlueprintEffects()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBlueprintEffects")]
            ///  extern System.Boolean GET_HAS_SHIP_BLUEPRINT_EFFECTS ();

            
            /// <summary>
            ///   System.Boolean get_hasShipBlueprintsRefreshedEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipBlueprintsRefreshedEvent")]
            ///  extern System.Boolean GET_HAS_SHIP_BLUEPRINTS_REFRESHED_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_hasShipEnterCamFocusRuntimeScreenEffect()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipEnterCamFocusRuntimeScreenEffect")]
            ///  extern System.Boolean GET_HAS_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();

            
            /// <summary>
            ///   System.Boolean get_hasShipPassengerUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipPassengerUpdatedEvent")]
            ///  extern System.Boolean GET_HAS_SHIP_PASSENGER_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_hasShipSpecialAttackConfig()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasShipSpecialAttackConfig")]
            ///  extern System.Boolean GET_HAS_SHIP_SPECIAL_ATTACK_CONFIG ();

            
            /// <summary>
            ///   System.Boolean get_hasStarGuideManager()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasStarGuideManager")]
            ///  extern System.Boolean GET_HAS_STAR_GUIDE_MANAGER ();

            
            /// <summary>
            ///   System.Boolean get_hasTerrainExploredCellsTable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTerrainExploredCellsTable")]
            ///  extern System.Boolean GET_HAS_TERRAIN_EXPLORED_CELLS_TABLE ();

            
            /// <summary>
            ///   System.Boolean get_hasUnlockedEquipmentList()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedEquipmentList")]
            ///  extern System.Boolean GET_HAS_UNLOCKED_EQUIPMENT_LIST ();

            
            /// <summary>
            ///   System.Boolean get_hasUnlockedShipBlueprints()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedShipBlueprints")]
            ///  extern System.Boolean GET_HAS_UNLOCKED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   System.Boolean get_hasUnlockedShipSpellTable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedShipSpellTable")]
            ///  extern System.Boolean GET_HAS_UNLOCKED_SHIP_SPELL_TABLE ();

            
            /// <summary>
            ///   System.Boolean get_hasUnlockedSpellTable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnlockedSpellTable")]
            ///  extern System.Boolean GET_HAS_UNLOCKED_SPELL_TABLE ();

            
            /// <summary>
            ///   GameEntity get_inCutsceneEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inCutsceneEntity")]
            ///  extern nint GET_IN_CUTSCENE_ENTITY ();

            
            /// <summary>
            ///   InfinityTowerTimerComponent get_infinityTowerTimer()
            /// </summary>
            /// <returns>class InfinityTowerTimerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerTimer")]
            ///  extern nint GET_INFINITY_TOWER_TIMER ();

            
            /// <summary>
            ///   GameEntity get_infinityTowerTimerEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_infinityTowerTimerEntity")]
            ///  extern nint GET_INFINITY_TOWER_TIMER_ENTITY ();

            
            /// <summary>
            ///   InventoryCommandComponent get_inventoryCommand()
            /// </summary>
            /// <returns>class InventoryCommandComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryCommand")]
            ///  extern nint GET_INVENTORY_COMMAND ();

            
            /// <summary>
            ///   GameEntity get_inventoryCommandEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inventoryCommandEntity")]
            ///  extern nint GET_INVENTORY_COMMAND_ENTITY ();

            
            /// <summary>
            ///   InvisibleWallComponent get_invisibleWall()
            /// </summary>
            /// <returns>class InvisibleWallComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_invisibleWall")]
            ///  extern nint GET_INVISIBLE_WALL ();

            
            /// <summary>
            ///   GameEntity get_invisibleWallEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_invisibleWallEntity")]
            ///  extern nint GET_INVISIBLE_WALL_ENTITY ();

            
            /// <summary>
            ///   System.Boolean get_isAddPlayerEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isAddPlayerEvent")]
            ///  extern System.Boolean GET_IS_ADD_PLAYER_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_isCutSceneFastForward()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCutSceneFastForward")]
            ///  extern System.Boolean GET_IS_CUT_SCENE_FAST_FORWARD ();

            
            /// <summary>
            ///   System.Boolean get_isCutSceneFastForwardBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCutSceneFastForwardBlocked")]
            ///  extern System.Boolean GET_IS_CUT_SCENE_FAST_FORWARD_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isEquipmentUpgradeShopInteractable()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEquipmentUpgradeShopInteractable")]
            ///  extern System.Boolean GET_IS_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE ();

            
            /// <summary>
            ///   System.Boolean get_isFloatBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFloatBlocked")]
            ///  extern System.Boolean GET_IS_FLOAT_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isGlobalInteractBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isGlobalInteractBlocked")]
            ///  extern System.Boolean GET_IS_GLOBAL_INTERACT_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isInCutscene()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInCutscene")]
            ///  extern System.Boolean GET_IS_IN_CUTSCENE ();

            
            /// <summary>
            ///   System.Boolean get_isPlayerShip()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerShip")]
            ///  extern System.Boolean GET_IS_PLAYER_SHIP ();

            
            /// <summary>
            ///   System.Boolean get_isPlayerShipHealthUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isPlayerShipHealthUpdatedEvent")]
            ///  extern System.Boolean GET_IS_PLAYER_SHIP_HEALTH_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_isRemovePlayerEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRemovePlayerEvent")]
            ///  extern System.Boolean GET_IS_REMOVE_PLAYER_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_isShipEnterBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipEnterBlocked")]
            ///  extern System.Boolean GET_IS_SHIP_ENTER_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isShipInteriorEnterEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipInteriorEnterEvent")]
            ///  extern System.Boolean GET_IS_SHIP_INTERIOR_ENTER_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_isShipSpecialAmmoCapacityUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isShipSpecialAmmoCapacityUpdatedEvent")]
            ///  extern System.Boolean GET_IS_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Boolean get_isSideScrollingMode()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSideScrollingMode")]
            ///  extern System.Boolean GET_IS_SIDE_SCROLLING_MODE ();

            
            /// <summary>
            ///   System.Boolean get_isSpellCastBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpellCastBlocked")]
            ///  extern System.Boolean GET_IS_SPELL_CAST_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isSpirit()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpirit")]
            ///  extern System.Boolean GET_IS_SPIRIT ();

            
            /// <summary>
            ///   System.Boolean get_isSwapWeaponBlocked()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSwapWeaponBlocked")]
            ///  extern System.Boolean GET_IS_SWAP_WEAPON_BLOCKED ();

            
            /// <summary>
            ///   System.Boolean get_isTargetGroup()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isTargetGroup")]
            ///  extern System.Boolean GET_IS_TARGET_GROUP ();

            
            /// <summary>
            ///   LatestInfinityTowerClearedWaveComponent get_latestInfinityTowerClearedWave()
            /// </summary>
            /// <returns>class LatestInfinityTowerClearedWaveComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_latestInfinityTowerClearedWave")]
            ///  extern nint GET_LATEST_INFINITY_TOWER_CLEARED_WAVE ();

            
            /// <summary>
            ///   GameEntity get_latestInfinityTowerClearedWaveEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_latestInfinityTowerClearedWaveEntity")]
            ///  extern nint GET_LATEST_INFINITY_TOWER_CLEARED_WAVE_ENTITY ();

            
            /// <summary>
            ///   ObjectiveInteractorComponent get_objectiveInteractor()
            /// </summary>
            /// <returns>class ObjectiveInteractorComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_objectiveInteractor")]
            ///  extern nint GET_OBJECTIVE_INTERACTOR ();

            
            /// <summary>
            ///   GameEntity get_objectiveInteractorEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_objectiveInteractorEntity")]
            ///  extern nint GET_OBJECTIVE_INTERACTOR_ENTITY ();

            
            /// <summary>
            ///   OverrideCharacterGenderComponent get_overrideCharacterGender()
            /// </summary>
            /// <returns>class OverrideCharacterGenderComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideCharacterGender")]
            ///  extern nint GET_OVERRIDE_CHARACTER_GENDER ();

            
            /// <summary>
            ///   GameEntity get_overrideCharacterGenderEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideCharacterGenderEntity")]
            ///  extern nint GET_OVERRIDE_CHARACTER_GENDER_ENTITY ();

            
            /// <summary>
            ///   PlayerKilledSourceComponent get_playerKilledSource()
            /// </summary>
            /// <returns>class PlayerKilledSourceComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerKilledSource")]
            ///  extern nint GET_PLAYER_KILLED_SOURCE ();

            
            /// <summary>
            ///   GameEntity get_playerKilledSourceEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerKilledSourceEntity")]
            ///  extern nint GET_PLAYER_KILLED_SOURCE_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_playerShipEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerShipEntity")]
            ///  extern nint GET_PLAYER_SHIP_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_playerShipHealthUpdatedEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playerShipHealthUpdatedEventEntity")]
            ///  extern nint GET_PLAYER_SHIP_HEALTH_UPDATED_EVENT_ENTITY ();

            
            /// <summary>
            ///   PoolStatusTableComponent get_poolStatusTable()
            /// </summary>
            /// <returns>class PoolStatusTableComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_poolStatusTable")]
            ///  extern nint GET_POOL_STATUS_TABLE ();

            
            /// <summary>
            ///   GameEntity get_poolStatusTableEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_poolStatusTableEntity")]
            ///  extern nint GET_POOL_STATUS_TABLE_ENTITY ();

            
            /// <summary>
            ///   PromptRemovePlayerEventComponent get_promptRemovePlayerEvent()
            /// </summary>
            /// <returns>class PromptRemovePlayerEventComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_promptRemovePlayerEvent")]
            ///  extern nint GET_PROMPT_REMOVE_PLAYER_EVENT ();

            
            /// <summary>
            ///   GameEntity get_promptRemovePlayerEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_promptRemovePlayerEventEntity")]
            ///  extern nint GET_PROMPT_REMOVE_PLAYER_EVENT_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_removePlayerEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_removePlayerEventEntity")]
            ///  extern nint GET_REMOVE_PLAYER_EVENT_ENTITY ();

            
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
            ///   SecondPlayerComponent get_secondPlayer()
            /// </summary>
            /// <returns>class SecondPlayerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_secondPlayer")]
            ///  extern nint GET_SECOND_PLAYER ();

            
            /// <summary>
            ///   GameEntity get_secondPlayerEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_secondPlayerEntity")]
            ///  extern nint GET_SECOND_PLAYER_ENTITY ();

            
            /// <summary>
            ///   SelectedTavernTalesDataComponent get_selectedTavernTalesData()
            /// </summary>
            /// <returns>class SelectedTavernTalesDataComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectedTavernTalesData")]
            ///  extern nint GET_SELECTED_TAVERN_TALES_DATA ();

            
            /// <summary>
            ///   GameEntity get_selectedTavernTalesDataEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_selectedTavernTalesDataEntity")]
            ///  extern nint GET_SELECTED_TAVERN_TALES_DATA_ENTITY ();

            
            /// <summary>
            ///   ShipBlueprintEffectsComponent get_shipBlueprintEffects()
            /// </summary>
            /// <returns>class ShipBlueprintEffectsComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintEffects")]
            ///  extern nint GET_SHIP_BLUEPRINT_EFFECTS ();

            
            /// <summary>
            ///   GameEntity get_shipBlueprintEffectsEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintEffectsEntity")]
            ///  extern nint GET_SHIP_BLUEPRINT_EFFECTS_ENTITY ();

            
            /// <summary>
            ///   ShipBlueprintsRefreshedEventComponent get_shipBlueprintsRefreshedEvent()
            /// </summary>
            /// <returns>class ShipBlueprintsRefreshedEventComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintsRefreshedEvent")]
            ///  extern nint GET_SHIP_BLUEPRINTS_REFRESHED_EVENT ();

            
            /// <summary>
            ///   GameEntity get_shipBlueprintsRefreshedEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipBlueprintsRefreshedEventEntity")]
            ///  extern nint GET_SHIP_BLUEPRINTS_REFRESHED_EVENT_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_shipEnterBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipEnterBlockedEntity")]
            ///  extern nint GET_SHIP_ENTER_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   ShipEnterCamFocusRuntimeScreenEffectComponent get_shipEnterCamFocusRuntimeScreenEffect()
            /// </summary>
            /// <returns>class ShipEnterCamFocusRuntimeScreenEffectComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipEnterCamFocusRuntimeScreenEffect")]
            ///  extern nint GET_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();

            
            /// <summary>
            ///   GameEntity get_shipEnterCamFocusRuntimeScreenEffectEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipEnterCamFocusRuntimeScreenEffectEntity")]
            ///  extern nint GET_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_shipInteriorEnterEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipInteriorEnterEventEntity")]
            ///  extern nint GET_SHIP_INTERIOR_ENTER_EVENT_ENTITY ();

            
            /// <summary>
            ///   ShipPassengerUpdatedEventComponent get_shipPassengerUpdatedEvent()
            /// </summary>
            /// <returns>class ShipPassengerUpdatedEventComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipPassengerUpdatedEvent")]
            ///  extern nint GET_SHIP_PASSENGER_UPDATED_EVENT ();

            
            /// <summary>
            ///   GameEntity get_shipPassengerUpdatedEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipPassengerUpdatedEventEntity")]
            ///  extern nint GET_SHIP_PASSENGER_UPDATED_EVENT_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_shipSpecialAmmoCapacityUpdatedEventEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipSpecialAmmoCapacityUpdatedEventEntity")]
            ///  extern nint GET_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT_ENTITY ();

            
            /// <summary>
            ///   ShipSpecialAttackConfigComponent get_shipSpecialAttackConfig()
            /// </summary>
            /// <returns>class ShipSpecialAttackConfigComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipSpecialAttackConfig")]
            ///  extern nint GET_SHIP_SPECIAL_ATTACK_CONFIG ();

            
            /// <summary>
            ///   GameEntity get_shipSpecialAttackConfigEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_shipSpecialAttackConfigEntity")]
            ///  extern nint GET_SHIP_SPECIAL_ATTACK_CONFIG_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_sideScrollingModeEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sideScrollingModeEntity")]
            ///  extern nint GET_SIDE_SCROLLING_MODE_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_spellCastBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellCastBlockedEntity")]
            ///  extern nint GET_SPELL_CAST_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_spiritEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spiritEntity")]
            ///  extern nint GET_SPIRIT_ENTITY ();

            
            /// <summary>
            ///   StarGuideManagerComponent get_starGuideManager()
            /// </summary>
            /// <returns>class StarGuideManagerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_starGuideManager")]
            ///  extern nint GET_STAR_GUIDE_MANAGER ();

            
            /// <summary>
            ///   GameEntity get_starGuideManagerEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_starGuideManagerEntity")]
            ///  extern nint GET_STAR_GUIDE_MANAGER_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_swapWeaponBlockedEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_swapWeaponBlockedEntity")]
            ///  extern nint GET_SWAP_WEAPON_BLOCKED_ENTITY ();

            
            /// <summary>
            ///   GameEntity get_targetGroupEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetGroupEntity")]
            ///  extern nint GET_TARGET_GROUP_ENTITY ();

            
            /// <summary>
            ///   TerrainExploredCellsTableComponent get_terrainExploredCellsTable()
            /// </summary>
            /// <returns>class TerrainExploredCellsTableComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_terrainExploredCellsTable")]
            ///  extern nint GET_TERRAIN_EXPLORED_CELLS_TABLE ();

            
            /// <summary>
            ///   GameEntity get_terrainExploredCellsTableEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_terrainExploredCellsTableEntity")]
            ///  extern nint GET_TERRAIN_EXPLORED_CELLS_TABLE_ENTITY ();

            
            /// <summary>
            ///   System.Int32 get_totalComponents()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
            ///  extern System.Int32 GET_TOTAL_COMPONENTS ();

            
            /// <summary>
            ///   UnlockedEquipmentListComponent get_unlockedEquipmentList()
            /// </summary>
            /// <returns>class UnlockedEquipmentListComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedEquipmentList")]
            ///  extern nint GET_UNLOCKED_EQUIPMENT_LIST ();

            
            /// <summary>
            ///   GameEntity get_unlockedEquipmentListEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedEquipmentListEntity")]
            ///  extern nint GET_UNLOCKED_EQUIPMENT_LIST_ENTITY ();

            
            /// <summary>
            ///   UnlockedShipBlueprintsComponent get_unlockedShipBlueprints()
            /// </summary>
            /// <returns>class UnlockedShipBlueprintsComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipBlueprints")]
            ///  extern nint GET_UNLOCKED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   GameEntity get_unlockedShipBlueprintsEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipBlueprintsEntity")]
            ///  extern nint GET_UNLOCKED_SHIP_BLUEPRINTS_ENTITY ();

            
            /// <summary>
            ///   UnlockedShipSpellTableComponent get_unlockedShipSpellTable()
            /// </summary>
            /// <returns>class UnlockedShipSpellTableComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipSpellTable")]
            ///  extern nint GET_UNLOCKED_SHIP_SPELL_TABLE ();

            
            /// <summary>
            ///   GameEntity get_unlockedShipSpellTableEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedShipSpellTableEntity")]
            ///  extern nint GET_UNLOCKED_SHIP_SPELL_TABLE_ENTITY ();

            
            /// <summary>
            ///   UnlockedSpellTableComponent get_unlockedSpellTable()
            /// </summary>
            /// <returns>class UnlockedSpellTableComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedSpellTable")]
            ///  extern nint GET_UNLOCKED_SPELL_TABLE ();

            
            /// <summary>
            ///   GameEntity get_unlockedSpellTableEntity()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unlockedSpellTableEntity")]
            ///  extern nint GET_UNLOCKED_SPELL_TABLE_ENTITY ();

            
            /// <summary>
            ///   GameEntity[] GetEntities()
            /// </summary>
            /// <returns>class GameEntity[]</returns>
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
            ///   Entitas.IGroup<GameEntity> GetGroup(Entitas.IMatcher<GameEntity> matcher)
            /// </summary>
            /// <param name="matcher">interface Entitas.IMatcher<GameEntity></param>
            /// <returns>interface Entitas.IGroup<GameEntity></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
            ///  extern nint GET_GROUP (nint matcher);

            
            /// <summary>
            ///   System.Boolean HasEntity(GameEntity entity)
            /// </summary>
            /// <param name="entity">class GameEntity</param>
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
            ///   System.Void RemoveActiveScreenEffectPlayer()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveActiveScreenEffectPlayer")]
            ///  extern void REMOVE_ACTIVE_SCREEN_EFFECT_PLAYER ();

            
            /// <summary>
            ///   System.Void RemoveAllEventHandlers()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllEventHandlers")]
            ///  extern void REMOVE_ALL_EVENT_HANDLERS ();

            
            /// <summary>
            ///   System.Void RemoveAwardedQuestItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAwardedQuestItems")]
            ///  extern void REMOVE_AWARDED_QUEST_ITEMS ();

            
            /// <summary>
            ///   System.Void RemoveChestInteractor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChestInteractor")]
            ///  extern void REMOVE_CHEST_INTERACTOR ();

            
            /// <summary>
            ///   System.Void RemoveCutsceneOwner()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCutsceneOwner")]
            ///  extern void REMOVE_CUTSCENE_OWNER ();

            
            /// <summary>
            ///   System.Void RemoveDockRepairOccupantsUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveDockRepairOccupantsUpdatedEvent")]
            ///  extern void REMOVE_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Void RemoveEquippedPlayerShipSpells()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedPlayerShipSpells")]
            ///  extern void REMOVE_EQUIPPED_PLAYER_SHIP_SPELLS ();

            
            /// <summary>
            ///   System.Void RemoveEquippedShipBlueprints()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveEquippedShipBlueprints")]
            ///  extern void REMOVE_EQUIPPED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   System.Void RemoveGameDifficulty()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficulty")]
            ///  extern void REMOVE_GAME_DIFFICULTY ();

            
            /// <summary>
            ///   System.Void RemoveGameDifficultyDamageModifier()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficultyDamageModifier")]
            ///  extern void REMOVE_GAME_DIFFICULTY_DAMAGE_MODIFIER ();

            
            /// <summary>
            ///   System.Void RemoveGameDifficultyHeathModifier()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameDifficultyHeathModifier")]
            ///  extern void REMOVE_GAME_DIFFICULTY_HEATH_MODIFIER ();

            
            /// <summary>
            ///   System.Void RemoveGameOverEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameOverEvent")]
            ///  extern void REMOVE_GAME_OVER_EVENT ();

            
            /// <summary>
            ///   System.Void RemoveGameOverNoSaveOverride()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameOverNoSaveOverride")]
            ///  extern void REMOVE_GAME_OVER_NO_SAVE_OVERRIDE ();

            
            /// <summary>
            ///   System.Void RemoveInfinityTowerTimer()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInfinityTowerTimer")]
            ///  extern void REMOVE_INFINITY_TOWER_TIMER ();

            
            /// <summary>
            ///   System.Void RemoveInventoryCommand()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInventoryCommand")]
            ///  extern void REMOVE_INVENTORY_COMMAND ();

            
            /// <summary>
            ///   System.Void RemoveInvisibleWall()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInvisibleWall")]
            ///  extern void REMOVE_INVISIBLE_WALL ();

            
            /// <summary>
            ///   System.Void RemoveLatestInfinityTowerClearedWave()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLatestInfinityTowerClearedWave")]
            ///  extern void REMOVE_LATEST_INFINITY_TOWER_CLEARED_WAVE ();

            
            /// <summary>
            ///   System.Void RemoveObjectiveInteractor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveObjectiveInteractor")]
            ///  extern void REMOVE_OBJECTIVE_INTERACTOR ();

            
            /// <summary>
            ///   System.Void RemoveOverrideCharacterGender()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOverrideCharacterGender")]
            ///  extern void REMOVE_OVERRIDE_CHARACTER_GENDER ();

            
            /// <summary>
            ///   System.Void RemovePlayerKilledSource()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePlayerKilledSource")]
            ///  extern void REMOVE_PLAYER_KILLED_SOURCE ();

            
            /// <summary>
            ///   System.Void RemovePoolStatusTable()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePoolStatusTable")]
            ///  extern void REMOVE_POOL_STATUS_TABLE ();

            
            /// <summary>
            ///   System.Void RemovePromptRemovePlayerEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePromptRemovePlayerEvent")]
            ///  extern void REMOVE_PROMPT_REMOVE_PLAYER_EVENT ();

            
            /// <summary>
            ///   System.Void RemoveSecondPlayer()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSecondPlayer")]
            ///  extern void REMOVE_SECOND_PLAYER ();

            
            /// <summary>
            ///   System.Void RemoveSelectedTavernTalesData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSelectedTavernTalesData")]
            ///  extern void REMOVE_SELECTED_TAVERN_TALES_DATA ();

            
            /// <summary>
            ///   System.Void RemoveShipBlueprintEffects()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBlueprintEffects")]
            ///  extern void REMOVE_SHIP_BLUEPRINT_EFFECTS ();

            
            /// <summary>
            ///   System.Void RemoveShipBlueprintsRefreshedEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipBlueprintsRefreshedEvent")]
            ///  extern void REMOVE_SHIP_BLUEPRINTS_REFRESHED_EVENT ();

            
            /// <summary>
            ///   System.Void RemoveShipEnterCamFocusRuntimeScreenEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipEnterCamFocusRuntimeScreenEffect")]
            ///  extern void REMOVE_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT ();

            
            /// <summary>
            ///   System.Void RemoveShipPassengerUpdatedEvent()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipPassengerUpdatedEvent")]
            ///  extern void REMOVE_SHIP_PASSENGER_UPDATED_EVENT ();

            
            /// <summary>
            ///   System.Void RemoveShipSpecialAttackConfig()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveShipSpecialAttackConfig")]
            ///  extern void REMOVE_SHIP_SPECIAL_ATTACK_CONFIG ();

            
            /// <summary>
            ///   System.Void RemoveStarGuideManager()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveStarGuideManager")]
            ///  extern void REMOVE_STAR_GUIDE_MANAGER ();

            
            /// <summary>
            ///   System.Void RemoveTerrainExploredCellsTable()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTerrainExploredCellsTable")]
            ///  extern void REMOVE_TERRAIN_EXPLORED_CELLS_TABLE ();

            
            /// <summary>
            ///   System.Void RemoveUnlockedEquipmentList()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedEquipmentList")]
            ///  extern void REMOVE_UNLOCKED_EQUIPMENT_LIST ();

            
            /// <summary>
            ///   System.Void RemoveUnlockedShipBlueprints()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedShipBlueprints")]
            ///  extern void REMOVE_UNLOCKED_SHIP_BLUEPRINTS ();

            
            /// <summary>
            ///   System.Void RemoveUnlockedShipSpellTable()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedShipSpellTable")]
            ///  extern void REMOVE_UNLOCKED_SHIP_SPELL_TABLE ();

            
            /// <summary>
            ///   System.Void RemoveUnlockedSpellTable()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnlockedSpellTable")]
            ///  extern void REMOVE_UNLOCKED_SPELL_TABLE ();

            
            /// <summary>
            ///   System.Void ReplaceActiveScreenEffectPlayer(ScreenEffectPlayer newValue)
            /// </summary>
            /// <param name="newValue">class ScreenEffectPlayer</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceActiveScreenEffectPlayer")]
            ///  extern void REPLACE_ACTIVE_SCREEN_EFFECT_PLAYER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceAwardedQuestItems(QuestItemContainer newValue)
            /// </summary>
            /// <param name="newValue">class QuestItemContainer</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceAwardedQuestItems")]
            ///  extern void REPLACE_AWARDED_QUEST_ITEMS (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceChestInteractor(GameEntity newEntity)
            /// </summary>
            /// <param name="newEntity">class GameEntity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChestInteractor")]
            ///  extern void REPLACE_CHEST_INTERACTOR (nint newEntity);

            
            /// <summary>
            ///   System.Void ReplaceCutsceneOwner(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCutsceneOwner")]
            ///  extern void REPLACE_CUTSCENE_OWNER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceDockRepairOccupantsUpdatedEvent(GameEntity newDockRepair)
            /// </summary>
            /// <param name="newDockRepair">class GameEntity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceDockRepairOccupantsUpdatedEvent")]
            ///  extern void REPLACE_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT (nint newDockRepair);

            
            /// <summary>
            ///   System.Void ReplaceEquippedPlayerShipSpells(EquippedSpells newValue)
            /// </summary>
            /// <param name="newValue">class EquippedSpells</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedPlayerShipSpells")]
            ///  extern void REPLACE_EQUIPPED_PLAYER_SHIP_SPELLS (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceEquippedShipBlueprints(ShipBlueprintCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintCollection</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceEquippedShipBlueprints")]
            ///  extern void REPLACE_EQUIPPED_SHIP_BLUEPRINTS (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceGameDifficulty(SaveGameDifficulty newValue)
            /// </summary>
            /// <param name="newValue">enum SaveGameDifficulty</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficulty")]
            ///  extern void REPLACE_GAME_DIFFICULTY (SaveGameDifficulty newValue);

            
            /// <summary>
            ///   System.Void ReplaceGameDifficultyDamageModifier(System.Single newValue)
            /// </summary>
            /// <param name="newValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficultyDamageModifier")]
            ///  extern void REPLACE_GAME_DIFFICULTY_DAMAGE_MODIFIER (System.Single newValue);

            
            /// <summary>
            ///   System.Void ReplaceGameDifficultyHeathModifier(System.Single newValue)
            /// </summary>
            /// <param name="newValue">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameDifficultyHeathModifier")]
            ///  extern void REPLACE_GAME_DIFFICULTY_HEATH_MODIFIER (System.Single newValue);

            
            /// <summary>
            ///   System.Void ReplaceGameOverEvent(System.Single newElapsed)
            /// </summary>
            /// <param name="newElapsed">struct System.Single</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameOverEvent")]
            ///  extern void REPLACE_GAME_OVER_EVENT (System.Single newElapsed);

            
            /// <summary>
            ///   System.Void ReplaceGameOverNoSaveOverride(PortalID newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags)
            /// </summary>
            /// <param name="newTargetPortal">class PortalID</param>
            /// <param name="newGameOverOverrideFlags">enum GameOverOverrideFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameOverNoSaveOverride")]
            ///  extern void REPLACE_GAME_OVER_NO_SAVE_OVERRIDE (nint newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags);

            
            /// <summary>
            ///   System.Void ReplaceInfinityTowerTimer(System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused)
            /// </summary>
            /// <param name="newSecondsRemaining">struct System.Single</param>
            /// <param name="newSecondsTotal">struct System.Single</param>
            /// <param name="newPaused">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInfinityTowerTimer")]
            ///  extern void REPLACE_INFINITY_TOWER_TIMER (System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused);

            
            /// <summary>
            ///   System.Void ReplaceInventoryCommand(InventoryCommand newValue)
            /// </summary>
            /// <param name="newValue">enum InventoryCommand</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInventoryCommand")]
            ///  extern void REPLACE_INVENTORY_COMMAND (InventoryCommand newValue);

            
            /// <summary>
            ///   System.Void ReplaceInvisibleWall(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInvisibleWall")]
            ///  extern void REPLACE_INVISIBLE_WALL (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceLatestInfinityTowerClearedWave(System.Int32 newValue)
            /// </summary>
            /// <param name="newValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLatestInfinityTowerClearedWave")]
            ///  extern void REPLACE_LATEST_INFINITY_TOWER_CLEARED_WAVE (System.Int32 newValue);

            
            /// <summary>
            ///   System.Void ReplaceObjectiveInteractor(GameEntity newValue)
            /// </summary>
            /// <param name="newValue">class GameEntity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceObjectiveInteractor")]
            ///  extern void REPLACE_OBJECTIVE_INTERACTOR (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceOverrideCharacterGender(System.Int32 newPlayerId, CharacterGender newValue)
            /// </summary>
            /// <param name="newPlayerId">struct System.Int32</param>
            /// <param name="newValue">enum CharacterGender</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOverrideCharacterGender")]
            ///  extern void REPLACE_OVERRIDE_CHARACTER_GENDER (System.Int32 newPlayerId, CharacterGender newValue);

            
            /// <summary>
            ///   System.Void ReplacePlayerKilledSource(GameEntity newValue)
            /// </summary>
            /// <param name="newValue">class GameEntity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePlayerKilledSource")]
            ///  extern void REPLACE_PLAYER_KILLED_SOURCE (nint newValue);

            
            /// <summary>
            ///   System.Void ReplacePoolStatusTable(System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePoolStatusTable")]
            ///  extern void REPLACE_POOL_STATUS_TABLE (nint newValue);

            
            /// <summary>
            ///   System.Void ReplacePromptRemovePlayerEvent(System.Int32 newInitiatorPlayerID)
            /// </summary>
            /// <param name="newInitiatorPlayerID">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePromptRemovePlayerEvent")]
            ///  extern void REPLACE_PROMPT_REMOVE_PLAYER_EVENT (System.Int32 newInitiatorPlayerID);

            
            /// <summary>
            ///   System.Void ReplaceSecondPlayer(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSecondPlayer")]
            ///  extern void REPLACE_SECOND_PLAYER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceSelectedTavernTalesData(TavernTalesData newValue)
            /// </summary>
            /// <param name="newValue">class TavernTalesData</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSelectedTavernTalesData")]
            ///  extern void REPLACE_SELECTED_TAVERN_TALES_DATA (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceShipBlueprintEffects(ShipBlueprintEffects newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintEffects</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBlueprintEffects")]
            ///  extern void REPLACE_SHIP_BLUEPRINT_EFFECTS (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceShipBlueprintsRefreshedEvent(ShipBlueprintsRefreshedEvent newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintsRefreshedEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipBlueprintsRefreshedEvent")]
            ///  extern void REPLACE_SHIP_BLUEPRINTS_REFRESHED_EVENT (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceShipEnterCamFocusRuntimeScreenEffect(GenericCamFocus newScreenEffect)
            /// </summary>
            /// <param name="newScreenEffect">class GenericCamFocus</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipEnterCamFocusRuntimeScreenEffect")]
            ///  extern void REPLACE_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT (nint newScreenEffect);

            
            /// <summary>
            ///   System.Void ReplaceShipPassengerUpdatedEvent(GameEntity newShip)
            /// </summary>
            /// <param name="newShip">class GameEntity</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipPassengerUpdatedEvent")]
            ///  extern void REPLACE_SHIP_PASSENGER_UPDATED_EVENT (nint newShip);

            
            /// <summary>
            ///   System.Void ReplaceShipSpecialAttackConfig(ShipCannonAttackConfig newValue)
            /// </summary>
            /// <param name="newValue">class ShipCannonAttackConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceShipSpecialAttackConfig")]
            ///  extern void REPLACE_SHIP_SPECIAL_ATTACK_CONFIG (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceStarGuideManager(StarGuideManagerBehaviour newValue)
            /// </summary>
            /// <param name="newValue">class StarGuideManagerBehaviour</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceStarGuideManager")]
            ///  extern void REPLACE_STAR_GUIDE_MANAGER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceTerrainExploredCellsTable(System.Collections.Generic.HashSet<UnityEngine.Vector3Int> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3Int></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTerrainExploredCellsTable")]
            ///  extern void REPLACE_TERRAIN_EXPLORED_CELLS_TABLE (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceUnlockedEquipmentList(System.Collections.Generic.List<Equipment> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<Equipment></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedEquipmentList")]
            ///  extern void REPLACE_UNLOCKED_EQUIPMENT_LIST (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceUnlockedShipBlueprints(ShipBlueprintCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintCollection</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedShipBlueprints")]
            ///  extern void REPLACE_UNLOCKED_SHIP_BLUEPRINTS (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceUnlockedShipSpellTable(ShipSpellCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipSpellCollection</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedShipSpellTable")]
            ///  extern void REPLACE_UNLOCKED_SHIP_SPELL_TABLE (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceUnlockedSpellTable(SpellCollection newValue)
            /// </summary>
            /// <param name="newValue">class SpellCollection</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnlockedSpellTable")]
            ///  extern void REPLACE_UNLOCKED_SPELL_TABLE (nint newValue);

            
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
            ///   System.Void set_isAddPlayerEvent(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isAddPlayerEvent")]
            ///  extern void SET_IS_ADD_PLAYER_EVENT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isCutSceneFastForward(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCutSceneFastForward")]
            ///  extern void SET_IS_CUT_SCENE_FAST_FORWARD (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isCutSceneFastForwardBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCutSceneFastForwardBlocked")]
            ///  extern void SET_IS_CUT_SCENE_FAST_FORWARD_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isEquipmentUpgradeShopInteractable(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isEquipmentUpgradeShopInteractable")]
            ///  extern void SET_IS_EQUIPMENT_UPGRADE_SHOP_INTERACTABLE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isFloatBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFloatBlocked")]
            ///  extern void SET_IS_FLOAT_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isGlobalInteractBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isGlobalInteractBlocked")]
            ///  extern void SET_IS_GLOBAL_INTERACT_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isInCutscene(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInCutscene")]
            ///  extern void SET_IS_IN_CUTSCENE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isPlayerShip(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerShip")]
            ///  extern void SET_IS_PLAYER_SHIP (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isPlayerShipHealthUpdatedEvent(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isPlayerShipHealthUpdatedEvent")]
            ///  extern void SET_IS_PLAYER_SHIP_HEALTH_UPDATED_EVENT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isRemovePlayerEvent(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRemovePlayerEvent")]
            ///  extern void SET_IS_REMOVE_PLAYER_EVENT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isShipEnterBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipEnterBlocked")]
            ///  extern void SET_IS_SHIP_ENTER_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isShipInteriorEnterEvent(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipInteriorEnterEvent")]
            ///  extern void SET_IS_SHIP_INTERIOR_ENTER_EVENT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isShipSpecialAmmoCapacityUpdatedEvent(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isShipSpecialAmmoCapacityUpdatedEvent")]
            ///  extern void SET_IS_SHIP_SPECIAL_AMMO_CAPACITY_UPDATED_EVENT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isSideScrollingMode(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSideScrollingMode")]
            ///  extern void SET_IS_SIDE_SCROLLING_MODE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isSpellCastBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpellCastBlocked")]
            ///  extern void SET_IS_SPELL_CAST_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isSpirit(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpirit")]
            ///  extern void SET_IS_SPIRIT (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isSwapWeaponBlocked(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSwapWeaponBlocked")]
            ///  extern void SET_IS_SWAP_WEAPON_BLOCKED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isTargetGroup(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isTargetGroup")]
            ///  extern void SET_IS_TARGET_GROUP (System.Boolean value);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GameEntity> entityFactory)
            /// </summary>
            /// <param name="totalComponents">struct System.Int32</param>
            /// <param name="entityFactory">class System.Func<GameEntity></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
            ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GameEntity> entityFactory)
            /// </summary>
            /// <param name="totalComponents">struct System.Int32</param>
            /// <param name="startCreationIndex">struct System.Int32</param>
            /// <param name="contextInfo">class Entitas.ContextInfo</param>
            /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
            /// <param name="entityFactory">class System.Func<GameEntity></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameContext))]
            ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);

            
            /// public static partial class Search_GameContext
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
                    ///   System.Void .ctor(System.Int32 totalComponents, System.Func<GameEntity> entityFactory)
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<GameEntity>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<GameEntity> entityFactory)
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<GameEntity>");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }

        /// <summary>
        /// ["ProjectStar".""."GameContext"]
        /// </summary>
        public partial class GameContext
        { 

            
            
            /// <summary>
            ///   GameEntity SetActiveScreenEffectPlayer(ScreenEffectPlayer newValue)
            /// </summary>
            /// <param name="newValue">class ScreenEffectPlayer</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetActiveScreenEffectPlayer")]
            ///  extern nint SET_ACTIVE_SCREEN_EFFECT_PLAYER (nint newValue);

            
            /// <summary>
            ///   GameEntity SetAwardedQuestItems(QuestItemContainer newValue)
            /// </summary>
            /// <param name="newValue">class QuestItemContainer</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAwardedQuestItems")]
            ///  extern nint SET_AWARDED_QUEST_ITEMS (nint newValue);

            
            /// <summary>
            ///   GameEntity SetChestInteractor(GameEntity newEntity)
            /// </summary>
            /// <param name="newEntity">class GameEntity</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetChestInteractor")]
            ///  extern nint SET_CHEST_INTERACTOR (nint newEntity);

            
            /// <summary>
            ///   GameEntity SetCutsceneOwner(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCutsceneOwner")]
            ///  extern nint SET_CUTSCENE_OWNER (nint newValue);

            
            /// <summary>
            ///   GameEntity SetDockRepairOccupantsUpdatedEvent(GameEntity newDockRepair)
            /// </summary>
            /// <param name="newDockRepair">class GameEntity</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetDockRepairOccupantsUpdatedEvent")]
            ///  extern nint SET_DOCK_REPAIR_OCCUPANTS_UPDATED_EVENT (nint newDockRepair);

            
            /// <summary>
            ///   GameEntity SetEquippedPlayerShipSpells(EquippedSpells newValue)
            /// </summary>
            /// <param name="newValue">class EquippedSpells</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEquippedPlayerShipSpells")]
            ///  extern nint SET_EQUIPPED_PLAYER_SHIP_SPELLS (nint newValue);

            
            /// <summary>
            ///   GameEntity SetEquippedShipBlueprints(ShipBlueprintCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintCollection</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetEquippedShipBlueprints")]
            ///  extern nint SET_EQUIPPED_SHIP_BLUEPRINTS (nint newValue);

            
            /// <summary>
            ///   GameEntity SetGameDifficulty(SaveGameDifficulty newValue)
            /// </summary>
            /// <param name="newValue">enum SaveGameDifficulty</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameDifficulty")]
            ///  extern nint SET_GAME_DIFFICULTY (SaveGameDifficulty newValue);

            
            /// <summary>
            ///   GameEntity SetGameDifficultyDamageModifier(System.Single newValue)
            /// </summary>
            /// <param name="newValue">struct System.Single</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameDifficultyDamageModifier")]
            ///  extern nint SET_GAME_DIFFICULTY_DAMAGE_MODIFIER (System.Single newValue);

            
            /// <summary>
            ///   GameEntity SetGameDifficultyHeathModifier(System.Single newValue)
            /// </summary>
            /// <param name="newValue">struct System.Single</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameDifficultyHeathModifier")]
            ///  extern nint SET_GAME_DIFFICULTY_HEATH_MODIFIER (System.Single newValue);

            
            /// <summary>
            ///   GameEntity SetGameOverEvent(System.Single newElapsed)
            /// </summary>
            /// <param name="newElapsed">struct System.Single</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameOverEvent")]
            ///  extern nint SET_GAME_OVER_EVENT (System.Single newElapsed);

            
            /// <summary>
            ///   GameEntity SetGameOverNoSaveOverride(PortalID newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags)
            /// </summary>
            /// <param name="newTargetPortal">class PortalID</param>
            /// <param name="newGameOverOverrideFlags">enum GameOverOverrideFlags</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGameOverNoSaveOverride")]
            ///  extern nint SET_GAME_OVER_NO_SAVE_OVERRIDE (nint newTargetPortal, GameOverOverrideFlags newGameOverOverrideFlags);

            
            /// <summary>
            ///   GameEntity SetInfinityTowerTimer(System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused)
            /// </summary>
            /// <param name="newSecondsRemaining">struct System.Single</param>
            /// <param name="newSecondsTotal">struct System.Single</param>
            /// <param name="newPaused">struct System.Boolean</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInfinityTowerTimer")]
            ///  extern nint SET_INFINITY_TOWER_TIMER (System.Single newSecondsRemaining, System.Single newSecondsTotal, System.Boolean newPaused);

            
            /// <summary>
            ///   GameEntity SetInventoryCommand(InventoryCommand newValue)
            /// </summary>
            /// <param name="newValue">enum InventoryCommand</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInventoryCommand")]
            ///  extern nint SET_INVENTORY_COMMAND (InventoryCommand newValue);

            
            /// <summary>
            ///   GameEntity SetInvisibleWall(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInvisibleWall")]
            ///  extern nint SET_INVISIBLE_WALL (nint newValue);

            
            /// <summary>
            ///   GameEntity SetLatestInfinityTowerClearedWave(System.Int32 newValue)
            /// </summary>
            /// <param name="newValue">struct System.Int32</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLatestInfinityTowerClearedWave")]
            ///  extern nint SET_LATEST_INFINITY_TOWER_CLEARED_WAVE (System.Int32 newValue);

            
            /// <summary>
            ///   GameEntity SetObjectiveInteractor(GameEntity newValue)
            /// </summary>
            /// <param name="newValue">class GameEntity</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetObjectiveInteractor")]
            ///  extern nint SET_OBJECTIVE_INTERACTOR (nint newValue);

            
            /// <summary>
            ///   GameEntity SetOverrideCharacterGender(System.Int32 newPlayerId, CharacterGender newValue)
            /// </summary>
            /// <param name="newPlayerId">struct System.Int32</param>
            /// <param name="newValue">enum CharacterGender</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetOverrideCharacterGender")]
            ///  extern nint SET_OVERRIDE_CHARACTER_GENDER (System.Int32 newPlayerId, CharacterGender newValue);

            
            /// <summary>
            ///   GameEntity SetPlayerKilledSource(GameEntity newValue)
            /// </summary>
            /// <param name="newValue">class GameEntity</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPlayerKilledSource")]
            ///  extern nint SET_PLAYER_KILLED_SOURCE (nint newValue);

            
            /// <summary>
            ///   GameEntity SetPoolStatusTable(System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.Dictionary<UnityEngine.GameObject,System.Boolean></param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPoolStatusTable")]
            ///  extern nint SET_POOL_STATUS_TABLE (nint newValue);

            
            /// <summary>
            ///   GameEntity SetPromptRemovePlayerEvent(System.Int32 newInitiatorPlayerID)
            /// </summary>
            /// <param name="newInitiatorPlayerID">struct System.Int32</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPromptRemovePlayerEvent")]
            ///  extern nint SET_PROMPT_REMOVE_PLAYER_EVENT (System.Int32 newInitiatorPlayerID);

            
            /// <summary>
            ///   GameEntity SetSecondPlayer(UnityEngine.GameObject newValue)
            /// </summary>
            /// <param name="newValue">class UnityEngine.GameObject</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSecondPlayer")]
            ///  extern nint SET_SECOND_PLAYER (nint newValue);

            
            /// <summary>
            ///   GameEntity SetSelectedTavernTalesData(TavernTalesData newValue)
            /// </summary>
            /// <param name="newValue">class TavernTalesData</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSelectedTavernTalesData")]
            ///  extern nint SET_SELECTED_TAVERN_TALES_DATA (nint newValue);

            
            /// <summary>
            ///   GameEntity SetShipBlueprintEffects(ShipBlueprintEffects newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintEffects</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShipBlueprintEffects")]
            ///  extern nint SET_SHIP_BLUEPRINT_EFFECTS (nint newValue);

            
            /// <summary>
            ///   GameEntity SetShipBlueprintsRefreshedEvent(ShipBlueprintsRefreshedEvent newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintsRefreshedEvent</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShipBlueprintsRefreshedEvent")]
            ///  extern nint SET_SHIP_BLUEPRINTS_REFRESHED_EVENT (nint newValue);

            
            /// <summary>
            ///   GameEntity SetShipEnterCamFocusRuntimeScreenEffect(GenericCamFocus newScreenEffect)
            /// </summary>
            /// <param name="newScreenEffect">class GenericCamFocus</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShipEnterCamFocusRuntimeScreenEffect")]
            ///  extern nint SET_SHIP_ENTER_CAM_FOCUS_RUNTIME_SCREEN_EFFECT (nint newScreenEffect);

            
            /// <summary>
            ///   GameEntity SetShipPassengerUpdatedEvent(GameEntity newShip)
            /// </summary>
            /// <param name="newShip">class GameEntity</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShipPassengerUpdatedEvent")]
            ///  extern nint SET_SHIP_PASSENGER_UPDATED_EVENT (nint newShip);

            
            /// <summary>
            ///   GameEntity SetShipSpecialAttackConfig(ShipCannonAttackConfig newValue)
            /// </summary>
            /// <param name="newValue">class ShipCannonAttackConfig</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetShipSpecialAttackConfig")]
            ///  extern nint SET_SHIP_SPECIAL_ATTACK_CONFIG (nint newValue);

            
            /// <summary>
            ///   GameEntity SetStarGuideManager(StarGuideManagerBehaviour newValue)
            /// </summary>
            /// <param name="newValue">class StarGuideManagerBehaviour</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetStarGuideManager")]
            ///  extern nint SET_STAR_GUIDE_MANAGER (nint newValue);

            
            /// <summary>
            ///   GameEntity SetTerrainExploredCellsTable(System.Collections.Generic.HashSet<UnityEngine.Vector3Int> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3Int></param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTerrainExploredCellsTable")]
            ///  extern nint SET_TERRAIN_EXPLORED_CELLS_TABLE (nint newValue);

            
            /// <summary>
            ///   GameEntity SetUnlockedEquipmentList(System.Collections.Generic.List<Equipment> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<Equipment></param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnlockedEquipmentList")]
            ///  extern nint SET_UNLOCKED_EQUIPMENT_LIST (nint newValue);

            
            /// <summary>
            ///   GameEntity SetUnlockedShipBlueprints(ShipBlueprintCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipBlueprintCollection</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnlockedShipBlueprints")]
            ///  extern nint SET_UNLOCKED_SHIP_BLUEPRINTS (nint newValue);

            
            /// <summary>
            ///   GameEntity SetUnlockedShipSpellTable(ShipSpellCollection newValue)
            /// </summary>
            /// <param name="newValue">class ShipSpellCollection</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnlockedShipSpellTable")]
            ///  extern nint SET_UNLOCKED_SHIP_SPELL_TABLE (nint newValue);

            
            /// <summary>
            ///   GameEntity SetUnlockedSpellTable(SpellCollection newValue)
            /// </summary>
            /// <param name="newValue">class SpellCollection</param>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetUnlockedSpellTable")]
            ///  extern nint SET_UNLOCKED_SPELL_TABLE (nint newValue);

            
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
            
            

            
            /// public static partial class Search_GameContext
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}