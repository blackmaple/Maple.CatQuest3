
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
    /// class ["ProjectStar".""."WorldContext"]
    /// [Entitas.Context<WorldEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000660U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [87, 111, 114, 108, 100, 67, 111, 110, 116, 101, 120, 116])]


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

    // class 0x24 System.Func<WorldEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]

    // class 0x28 System.Collections.Generic.HashSet<WorldEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]

    // class 0x2C System.Collections.Generic.Stack<WorldEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]

    // class 0x30 System.Collections.Generic.HashSet<WorldEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]

    // class 0x34 System.Collections.Generic.Dictionary<Entitas.IMatcher<WorldEntity>,Entitas.IGroup<WorldEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]

    // class 0x38 System.Collections.Generic.List<Entitas.IGroup<WorldEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]

    // class 0x3C DesperateDevs.Caching.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<WorldEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]

    // class 0x40 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]

    // class 0x44 WorldEntity[] _entitiesCache
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
    public partial class WorldContext
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "WorldContext";
        //public static byte[] Static_ClassName { get; } = [87, 111, 114, 108, 100, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x02000660U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_WorldContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_WorldContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_WorldContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_WorldContext obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."WorldContext"]
    /// </summary>
    public partial class WorldContext
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
        ///   WorldEntity CreateEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
        ///  extern nint CREATE_ENTITY ();


        /// <summary>
        ///   System.Void DestroyAllEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
        ///  extern void DESTROY_ALL_ENTITIES ();


        /// <summary>
        ///   WorldEntity get_blockSceneZoneDetectionEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_blockSceneZoneDetectionEntity")]
        ///  extern nint GET_BLOCK_SCENE_ZONE_DETECTION_ENTITY ();


        /// <summary>
        ///   ChangeSceneZoneVisualCommandComponent get_changeSceneZoneVisualCommand()
        /// </summary>
        /// <returns>class ChangeSceneZoneVisualCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneZoneVisualCommand")]
        ///  extern nint GET_CHANGE_SCENE_ZONE_VISUAL_COMMAND ();


        /// <summary>
        ///   WorldEntity get_changeSceneZoneVisualCommandEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneZoneVisualCommandEntity")]
        ///  extern nint GET_CHANGE_SCENE_ZONE_VISUAL_COMMAND_ENTITY ();


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
        ///   WorldEntity get_createOverworldCommandEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_createOverworldCommandEntity")]
        ///  extern nint GET_CREATE_OVERWORLD_COMMAND_ENTITY ();


        /// <summary>
        ///   CurrentAdjustTriggerComponent get_currentAdjustTrigger()
        /// </summary>
        /// <returns>class CurrentAdjustTriggerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentAdjustTrigger")]
        ///  extern nint GET_CURRENT_ADJUST_TRIGGER ();


        /// <summary>
        ///   WorldEntity get_currentAdjustTriggerEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentAdjustTriggerEntity")]
        ///  extern nint GET_CURRENT_ADJUST_TRIGGER_ENTITY ();


        /// <summary>
        ///   CurrentSceneZoneVisualComponent get_currentSceneZoneVisual()
        /// </summary>
        /// <returns>class CurrentSceneZoneVisualComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentSceneZoneVisual")]
        ///  extern nint GET_CURRENT_SCENE_ZONE_VISUAL ();


        /// <summary>
        ///   WorldEntity get_currentSceneZoneVisualEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentSceneZoneVisualEntity")]
        ///  extern nint GET_CURRENT_SCENE_ZONE_VISUAL_ENTITY ();


        /// <summary>
        ///   CurrentUnitVisualDataOverrideOwnerComponent get_currentUnitVisualDataOverrideOwner()
        /// </summary>
        /// <returns>class CurrentUnitVisualDataOverrideOwnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentUnitVisualDataOverrideOwner")]
        ///  extern nint GET_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER ();


        /// <summary>
        ///   WorldEntity get_currentUnitVisualDataOverrideOwnerEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentUnitVisualDataOverrideOwnerEntity")]
        ///  extern nint GET_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER_ENTITY ();


        /// <summary>
        ///   CurrentZoneComponent get_currentZone()
        /// </summary>
        /// <returns>class CurrentZoneComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentZone")]
        ///  extern nint GET_CURRENT_ZONE ();


        /// <summary>
        ///   WorldEntity get_currentZoneEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentZoneEntity", CallConvs = [typeof(CallConvCdecl)])]
        extern WorldEntity.Ptr_WorldEntity GET_CURRENT_ZONE_ENTITY();


        /// <summary>
        ///   WorldEntity get_despawnSceneCommandEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_despawnSceneCommandEntity")]
        ///  extern nint GET_DESPAWN_SCENE_COMMAND_ENTITY ();


        /// <summary>
        ///   WorldEntity get_despawnSceneCompletedEventEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_despawnSceneCompletedEventEntity")]
        ///  extern nint GET_DESPAWN_SCENE_COMPLETED_EVENT_ENTITY ();


        /// <summary>
        ///   WorldEntity get_destroyOverworldCommandEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_destroyOverworldCommandEntity")]
        ///  extern nint GET_DESTROY_OVERWORLD_COMMAND_ENTITY ();


        /// <summary>
        ///   FogMultiplierComponent get_fogMultiplier()
        /// </summary>
        /// <returns>class FogMultiplierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fogMultiplier")]
        ///  extern nint GET_FOG_MULTIPLIER ();


        /// <summary>
        ///   WorldEntity get_fogMultiplierEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fogMultiplierEntity")]
        ///  extern nint GET_FOG_MULTIPLIER_ENTITY ();


        /// <summary>
        ///   GenericSpawnerEventHolderComponent get_genericSpawnerEventHolder()
        /// </summary>
        /// <returns>class GenericSpawnerEventHolderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_genericSpawnerEventHolder")]
        ///  extern nint GET_GENERIC_SPAWNER_EVENT_HOLDER ();


        /// <summary>
        ///   WorldEntity get_genericSpawnerEventHolderEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_genericSpawnerEventHolderEntity")]
        ///  extern nint GET_GENERIC_SPAWNER_EVENT_HOLDER_ENTITY ();


        /// <summary>
        ///   GridComponent get_grid()
        /// </summary>
        /// <returns>class GridComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_grid")]
        ///  extern nint GET_GRID ();


        /// <summary>
        ///   WorldEntity get_gridEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gridEntity")]
        ///  extern nint GET_GRID_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasChangeSceneZoneVisualCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChangeSceneZoneVisualCommand")]
        ///  extern System.Boolean GET_HAS_CHANGE_SCENE_ZONE_VISUAL_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasCurrentAdjustTrigger()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentAdjustTrigger")]
        ///  extern System.Boolean GET_HAS_CURRENT_ADJUST_TRIGGER ();


        /// <summary>
        ///   System.Boolean get_hasCurrentSceneZoneVisual()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentSceneZoneVisual")]
        ///  extern System.Boolean GET_HAS_CURRENT_SCENE_ZONE_VISUAL ();


        /// <summary>
        ///   System.Boolean get_hasCurrentUnitVisualDataOverrideOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentUnitVisualDataOverrideOwner")]
        ///  extern System.Boolean GET_HAS_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER ();


        /// <summary>
        ///   System.Boolean get_hasCurrentZone()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCurrentZone")]
        ///  extern System.Boolean GET_HAS_CURRENT_ZONE ();


        /// <summary>
        ///   System.Boolean get_hasFogMultiplier()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFogMultiplier")]
        ///  extern System.Boolean GET_HAS_FOG_MULTIPLIER ();


        /// <summary>
        ///   System.Boolean get_hasGenericSpawnerEventHolder()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGenericSpawnerEventHolder")]
        ///  extern System.Boolean GET_HAS_GENERIC_SPAWNER_EVENT_HOLDER ();


        /// <summary>
        ///   System.Boolean get_hasGrid()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGrid")]
        ///  extern System.Boolean GET_HAS_GRID ();


        /// <summary>
        ///   System.Boolean get_hasMainOverworld()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMainOverworld")]
        ///  extern System.Boolean GET_HAS_MAIN_OVERWORLD ();


        /// <summary>
        ///   System.Boolean get_hasMapIconWorldExploredTable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapIconWorldExploredTable")]
        ///  extern System.Boolean GET_HAS_MAP_ICON_WORLD_EXPLORED_TABLE ();


        /// <summary>
        ///   System.Boolean get_hasMapUIWorldSceneController()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasMapUIWorldSceneController")]
        ///  extern System.Boolean GET_HAS_MAP_UI_WORLD_SCENE_CONTROLLER ();


        /// <summary>
        ///   System.Boolean get_hasOverrideSceneZoneVisualBlendDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasOverrideSceneZoneVisualBlendDuration")]
        ///  extern System.Boolean GET_HAS_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasSceneController()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneController")]
        ///  extern System.Boolean GET_HAS_SCENE_CONTROLLER ();


        /// <summary>
        ///   System.Boolean get_hasSceneZoneVisualReplacementData()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneZoneVisualReplacementData")]
        ///  extern System.Boolean GET_HAS_SCENE_ZONE_VISUAL_REPLACEMENT_DATA ();


        /// <summary>
        ///   System.Boolean get_hasTilemapGrid()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTilemapGrid")]
        ///  extern System.Boolean GET_HAS_TILEMAP_GRID ();


        /// <summary>
        ///   System.Boolean get_isBlockSceneZoneDetection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isBlockSceneZoneDetection")]
        ///  extern System.Boolean GET_IS_BLOCK_SCENE_ZONE_DETECTION ();


        /// <summary>
        ///   System.Boolean get_isCreateOverworldCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCreateOverworldCommand")]
        ///  extern System.Boolean GET_IS_CREATE_OVERWORLD_COMMAND ();


        /// <summary>
        ///   System.Boolean get_isDespawnSceneCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDespawnSceneCommand")]
        ///  extern System.Boolean GET_IS_DESPAWN_SCENE_COMMAND ();


        /// <summary>
        ///   System.Boolean get_isDespawnSceneCompletedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDespawnSceneCompletedEvent")]
        ///  extern System.Boolean GET_IS_DESPAWN_SCENE_COMPLETED_EVENT ();


        /// <summary>
        ///   System.Boolean get_isDestroyOverworldCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyOverworldCommand")]
        ///  extern System.Boolean GET_IS_DESTROY_OVERWORLD_COMMAND ();


        /// <summary>
        ///   System.Boolean get_isRespawnSceneCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRespawnSceneCommand")]
        ///  extern System.Boolean GET_IS_RESPAWN_SCENE_COMMAND ();


        /// <summary>
        ///   MainOverworldComponent get_mainOverworld()
        /// </summary>
        /// <returns>class MainOverworldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainOverworld")]
        ///  extern nint GET_MAIN_OVERWORLD ();


        /// <summary>
        ///   WorldEntity get_mainOverworldEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainOverworldEntity")]
        ///  extern nint GET_MAIN_OVERWORLD_ENTITY ();


        /// <summary>
        ///   MapIconWorldExploredTableComponent get_mapIconWorldExploredTable()
        /// </summary>
        /// <returns>class MapIconWorldExploredTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconWorldExploredTable")]
        ///  extern nint GET_MAP_ICON_WORLD_EXPLORED_TABLE ();


        /// <summary>
        ///   WorldEntity get_mapIconWorldExploredTableEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconWorldExploredTableEntity")]
        ///  extern nint GET_MAP_ICON_WORLD_EXPLORED_TABLE_ENTITY ();


        /// <summary>
        ///   MapUIWorldSceneControllerComponent get_mapUIWorldSceneController()
        /// </summary>
        /// <returns>class MapUIWorldSceneControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUIWorldSceneController")]
        ///  extern nint GET_MAP_UI_WORLD_SCENE_CONTROLLER ();


        /// <summary>
        ///   WorldEntity get_mapUIWorldSceneControllerEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUIWorldSceneControllerEntity")]
        ///  extern nint GET_MAP_UI_WORLD_SCENE_CONTROLLER_ENTITY ();


        /// <summary>
        ///   OverrideSceneZoneVisualBlendDurationComponent get_overrideSceneZoneVisualBlendDuration()
        /// </summary>
        /// <returns>class OverrideSceneZoneVisualBlendDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideSceneZoneVisualBlendDuration")]
        ///  extern nint GET_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION ();


        /// <summary>
        ///   WorldEntity get_overrideSceneZoneVisualBlendDurationEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideSceneZoneVisualBlendDurationEntity")]
        ///  extern nint GET_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION_ENTITY ();


        /// <summary>
        ///   WorldEntity get_respawnSceneCommandEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_respawnSceneCommandEntity")]
        ///  extern nint GET_RESPAWN_SCENE_COMMAND_ENTITY ();


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
        ///   SceneControllerComponent get_sceneController()
        /// </summary>
        /// <returns>class SceneControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneController")]
        ///  extern nint GET_SCENE_CONTROLLER ();


        /// <summary>
        ///   WorldEntity get_sceneControllerEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneControllerEntity")]
        ///  extern nint GET_SCENE_CONTROLLER_ENTITY ();


        /// <summary>
        ///   SceneZoneVisualReplacementDataComponent get_sceneZoneVisualReplacementData()
        /// </summary>
        /// <returns>class SceneZoneVisualReplacementDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneZoneVisualReplacementData")]
        ///  extern nint GET_SCENE_ZONE_VISUAL_REPLACEMENT_DATA ();


        /// <summary>
        ///   WorldEntity get_sceneZoneVisualReplacementDataEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneZoneVisualReplacementDataEntity")]
        ///  extern nint GET_SCENE_ZONE_VISUAL_REPLACEMENT_DATA_ENTITY ();


        /// <summary>
        ///   TilemapGridComponent get_tilemapGrid()
        /// </summary>
        /// <returns>class TilemapGridComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tilemapGrid")]
        ///  extern nint GET_TILEMAP_GRID ();


        /// <summary>
        ///   WorldEntity get_tilemapGridEntity()
        /// </summary>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tilemapGridEntity")]
        ///  extern nint GET_TILEMAP_GRID_ENTITY ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   WorldEntity[] GetEntities()
        /// </summary>
        /// <returns>class WorldEntity[]</returns>
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
        ///   Entitas.IGroup<WorldEntity> GetGroup(Entitas.IMatcher<WorldEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<WorldEntity></param>
        /// <returns>interface Entitas.IGroup<WorldEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
        ///  extern nint GET_GROUP (nint matcher);


        /// <summary>
        ///   System.Boolean HasEntity(WorldEntity entity)
        /// </summary>
        /// <param name="entity">class WorldEntity</param>
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
        ///   System.Void RemoveChangeSceneZoneVisualCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChangeSceneZoneVisualCommand")]
        ///  extern void REMOVE_CHANGE_SCENE_ZONE_VISUAL_COMMAND ();


        /// <summary>
        ///   System.Void RemoveCurrentAdjustTrigger()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentAdjustTrigger")]
        ///  extern void REMOVE_CURRENT_ADJUST_TRIGGER ();


        /// <summary>
        ///   System.Void RemoveCurrentSceneZoneVisual()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentSceneZoneVisual")]
        ///  extern void REMOVE_CURRENT_SCENE_ZONE_VISUAL ();


        /// <summary>
        ///   System.Void RemoveCurrentUnitVisualDataOverrideOwner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentUnitVisualDataOverrideOwner")]
        ///  extern void REMOVE_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER ();


        /// <summary>
        ///   System.Void RemoveCurrentZone()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCurrentZone")]
        ///  extern void REMOVE_CURRENT_ZONE ();


        /// <summary>
        ///   System.Void RemoveFogMultiplier()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFogMultiplier")]
        ///  extern void REMOVE_FOG_MULTIPLIER ();


        /// <summary>
        ///   System.Void RemoveGenericSpawnerEventHolder()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGenericSpawnerEventHolder")]
        ///  extern void REMOVE_GENERIC_SPAWNER_EVENT_HOLDER ();


        /// <summary>
        ///   System.Void RemoveGrid()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGrid")]
        ///  extern void REMOVE_GRID ();


        /// <summary>
        ///   System.Void RemoveMainOverworld()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMainOverworld")]
        ///  extern void REMOVE_MAIN_OVERWORLD ();


        /// <summary>
        ///   System.Void RemoveMapIconWorldExploredTable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapIconWorldExploredTable")]
        ///  extern void REMOVE_MAP_ICON_WORLD_EXPLORED_TABLE ();


        /// <summary>
        ///   System.Void RemoveMapUIWorldSceneController()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveMapUIWorldSceneController")]
        ///  extern void REMOVE_MAP_UI_WORLD_SCENE_CONTROLLER ();


        /// <summary>
        ///   System.Void RemoveOverrideSceneZoneVisualBlendDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveOverrideSceneZoneVisualBlendDuration")]
        ///  extern void REMOVE_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION ();


        /// <summary>
        ///   System.Void RemoveSceneController()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneController")]
        ///  extern void REMOVE_SCENE_CONTROLLER ();


        /// <summary>
        ///   System.Void RemoveSceneZoneVisualReplacementData()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneZoneVisualReplacementData")]
        ///  extern void REMOVE_SCENE_ZONE_VISUAL_REPLACEMENT_DATA ();


        /// <summary>
        ///   System.Void RemoveTilemapGrid()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTilemapGrid")]
        ///  extern void REMOVE_TILEMAP_GRID ();


        /// <summary>
        ///   System.Void ReplaceChangeSceneZoneVisualCommand(SceneZoneVisualsData newReplacement, System.Single newBlendDuration)
        /// </summary>
        /// <param name="newReplacement">class SceneZoneVisualsData</param>
        /// <param name="newBlendDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChangeSceneZoneVisualCommand")]
        ///  extern void REPLACE_CHANGE_SCENE_ZONE_VISUAL_COMMAND (nint newReplacement, System.Single newBlendDuration);


        /// <summary>
        ///   System.Void ReplaceCurrentAdjustTrigger(AdjustTrigger newValue)
        /// </summary>
        /// <param name="newValue">class AdjustTrigger</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentAdjustTrigger")]
        ///  extern void REPLACE_CURRENT_ADJUST_TRIGGER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCurrentSceneZoneVisual(SceneZoneVisualsData newData)
        /// </summary>
        /// <param name="newData">class SceneZoneVisualsData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentSceneZoneVisual")]
        ///  extern void REPLACE_CURRENT_SCENE_ZONE_VISUAL (nint newData);


        /// <summary>
        ///   System.Void ReplaceCurrentUnitVisualDataOverrideOwner(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentUnitVisualDataOverrideOwner")]
        ///  extern void REPLACE_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceCurrentZone(ZoneType newZone)
        /// </summary>
        /// <param name="newZone">enum ZoneType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCurrentZone")]
        ///  extern void REPLACE_CURRENT_ZONE (ZoneType newZone);


        /// <summary>
        ///   System.Void ReplaceFogMultiplier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFogMultiplier")]
        ///  extern void REPLACE_FOG_MULTIPLIER (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceGenericSpawnerEventHolder(GenericSpawnerRelay newRelayObj)
        /// </summary>
        /// <param name="newRelayObj">class GenericSpawnerRelay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGenericSpawnerEventHolder")]
        ///  extern void REPLACE_GENERIC_SPAWNER_EVENT_HOLDER (nint newRelayObj);


        /// <summary>
        ///   System.Void ReplaceGrid(WorldGrid newValue)
        /// </summary>
        /// <param name="newValue">class WorldGrid</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGrid")]
        ///  extern void REPLACE_GRID (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMainOverworld(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMainOverworld")]
        ///  extern void REPLACE_MAIN_OVERWORLD (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapIconWorldExploredTable(System.Collections.Generic.HashSet<UnityEngine.Vector3> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapIconWorldExploredTable")]
        ///  extern void REPLACE_MAP_ICON_WORLD_EXPLORED_TABLE (nint newValue);


        /// <summary>
        ///   System.Void ReplaceMapUIWorldSceneController(MapUIWorldSceneController newValue)
        /// </summary>
        /// <param name="newValue">class MapUIWorldSceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceMapUIWorldSceneController")]
        ///  extern void REPLACE_MAP_UI_WORLD_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceOverrideSceneZoneVisualBlendDuration(System.Single newDuration)
        /// </summary>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceOverrideSceneZoneVisualBlendDuration")]
        ///  extern void REPLACE_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION (System.Single newDuration);


        /// <summary>
        ///   System.Void ReplaceSceneController(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneController")]
        ///  extern void REPLACE_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSceneZoneVisualReplacementData(SceneZoneVisualsData newValue)
        /// </summary>
        /// <param name="newValue">class SceneZoneVisualsData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneZoneVisualReplacementData")]
        ///  extern void REPLACE_SCENE_ZONE_VISUAL_REPLACEMENT_DATA (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTilemapGrid(UnityEngine.Grid newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Grid</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTilemapGrid")]
        ///  extern void REPLACE_TILEMAP_GRID (nint newValue);


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
        ///   System.Void set_isBlockSceneZoneDetection(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isBlockSceneZoneDetection")]
        ///  extern void SET_IS_BLOCK_SCENE_ZONE_DETECTION (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCreateOverworldCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCreateOverworldCommand")]
        ///  extern void SET_IS_CREATE_OVERWORLD_COMMAND (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDespawnSceneCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDespawnSceneCommand")]
        ///  extern void SET_IS_DESPAWN_SCENE_COMMAND (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDespawnSceneCompletedEvent(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDespawnSceneCompletedEvent")]
        ///  extern void SET_IS_DESPAWN_SCENE_COMPLETED_EVENT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDestroyOverworldCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyOverworldCommand")]
        ///  extern void SET_IS_DESTROY_OVERWORLD_COMMAND (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRespawnSceneCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRespawnSceneCommand")]
        ///  extern void SET_IS_RESPAWN_SCENE_COMMAND (System.Boolean value);


        /// <summary>
        ///   WorldEntity SetChangeSceneZoneVisualCommand(SceneZoneVisualsData newReplacement, System.Single newBlendDuration)
        /// </summary>
        /// <param name="newReplacement">class SceneZoneVisualsData</param>
        /// <param name="newBlendDuration">struct System.Single</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetChangeSceneZoneVisualCommand")]
        ///  extern nint SET_CHANGE_SCENE_ZONE_VISUAL_COMMAND (nint newReplacement, System.Single newBlendDuration);


        /// <summary>
        ///   WorldEntity SetCurrentAdjustTrigger(AdjustTrigger newValue)
        /// </summary>
        /// <param name="newValue">class AdjustTrigger</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCurrentAdjustTrigger")]
        ///  extern nint SET_CURRENT_ADJUST_TRIGGER (nint newValue);


        /// <summary>
        ///   WorldEntity SetCurrentSceneZoneVisual(SceneZoneVisualsData newData)
        /// </summary>
        /// <param name="newData">class SceneZoneVisualsData</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCurrentSceneZoneVisual")]
        ///  extern nint SET_CURRENT_SCENE_ZONE_VISUAL (nint newData);


        /// <summary>
        ///   WorldEntity SetCurrentUnitVisualDataOverrideOwner(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCurrentUnitVisualDataOverrideOwner")]
        ///  extern nint SET_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER (nint newValue);


        /// <summary>
        ///   WorldEntity SetCurrentZone(ZoneType newZone)
        /// </summary>
        /// <param name="newZone">enum ZoneType</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCurrentZone")]
        ///  extern nint SET_CURRENT_ZONE (ZoneType newZone);


        /// <summary>
        ///   WorldEntity SetFogMultiplier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFogMultiplier")]
        ///  extern nint SET_FOG_MULTIPLIER (System.Single newValue);


        /// <summary>
        ///   WorldEntity SetGenericSpawnerEventHolder(GenericSpawnerRelay newRelayObj)
        /// </summary>
        /// <param name="newRelayObj">class GenericSpawnerRelay</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGenericSpawnerEventHolder")]
        ///  extern nint SET_GENERIC_SPAWNER_EVENT_HOLDER (nint newRelayObj);


        /// <summary>
        ///   WorldEntity SetGrid(WorldGrid newValue)
        /// </summary>
        /// <param name="newValue">class WorldGrid</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGrid")]
        ///  extern nint SET_GRID (nint newValue);


        /// <summary>
        ///   WorldEntity SetMainOverworld(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMainOverworld")]
        ///  extern nint SET_MAIN_OVERWORLD (nint newValue);


        /// <summary>
        ///   WorldEntity SetMapIconWorldExploredTable(System.Collections.Generic.HashSet<UnityEngine.Vector3> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3></param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapIconWorldExploredTable")]
        ///  extern nint SET_MAP_ICON_WORLD_EXPLORED_TABLE (nint newValue);


        /// <summary>
        ///   WorldEntity SetMapUIWorldSceneController(MapUIWorldSceneController newValue)
        /// </summary>
        /// <param name="newValue">class MapUIWorldSceneController</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetMapUIWorldSceneController")]
        ///  extern nint SET_MAP_UI_WORLD_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   WorldEntity SetOverrideSceneZoneVisualBlendDuration(System.Single newDuration)
        /// </summary>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetOverrideSceneZoneVisualBlendDuration")]
        ///  extern nint SET_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION (System.Single newDuration);


        /// <summary>
        ///   WorldEntity SetSceneController(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSceneController")]
        ///  extern nint SET_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   WorldEntity SetSceneZoneVisualReplacementData(SceneZoneVisualsData newValue)
        /// </summary>
        /// <param name="newValue">class SceneZoneVisualsData</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSceneZoneVisualReplacementData")]
        ///  extern nint SET_SCENE_ZONE_VISUAL_REPLACEMENT_DATA (nint newValue);


        /// <summary>
        ///   WorldEntity SetTilemapGrid(UnityEngine.Grid newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Grid</param>
        /// <returns>class WorldEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTilemapGrid")]
        ///  extern nint SET_TILEMAP_GRID (nint newValue);


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



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_WorldContext))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<WorldEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="entityFactory">class System.Func<WorldEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_WorldContext))]
        ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<WorldEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="startCreationIndex">struct System.Int32</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
        /// <param name="entityFactory">class System.Func<WorldEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_WorldContext))]
        ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);


        /// public static partial class Search_WorldContext
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
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<WorldEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<WorldEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<WorldEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<WorldEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}