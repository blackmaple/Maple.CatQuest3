
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
    /// class ["ProjectStar".""."WorldEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// [IDestroyedEntity]=>[IInactiveEntity]=>[ISpawnerOverrideDurationEntity]=>[ISpawnTableItemEntity]=>[ITimerCallbackEntity]=>[ITimerEntity]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200065EU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [87, 111, 114, 108, 100, 69, 110, 116, 105, 116, 121])]

    //  class static ActivateSpawnerComponent activateSpawnerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"activateSpawnerComponent", "ACTIVATE_SPAWNER_COMPONENT", true)]

    //  class static BlockSceneZoneDetectionComponent blockSceneZoneDetectionComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"blockSceneZoneDetectionComponent", "BLOCK_SCENE_ZONE_DETECTION_COMPONENT", true)]

    //  class static CanRespawn canRespawnComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"canRespawnComponent", "CAN_RESPAWN_COMPONENT", true)]

    //  class static CreateOverworldCommandComponent createOverworldCommandComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"createOverworldCommandComponent", "CREATE_OVERWORLD_COMMAND_COMPONENT", true)]

    //  class static DespawnSceneCommandComponent despawnSceneCommandComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"despawnSceneCommandComponent", "DESPAWN_SCENE_COMMAND_COMPONENT", true)]

    //  class static DespawnSceneCompletedEventComponent despawnSceneCompletedEventComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"despawnSceneCompletedEventComponent", "DESPAWN_SCENE_COMPLETED_EVENT_COMPONENT", true)]

    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]

    //  class static DestroyOverworldCommandComponent destroyOverworldCommandComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyOverworldCommandComponent", "DESTROY_OVERWORLD_COMMAND_COMPONENT", true)]

    //  class static FirstInitComponent firstInitComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"firstInitComponent", "FIRST_INIT_COMPONENT", true)]

    //  class static InactiveComponent inactiveComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inactiveComponent", "INACTIVE_COMPONENT", true)]

    //  class static InfinitySpawner infinitySpawnerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"infinitySpawnerComponent", "INFINITY_SPAWNER_COMPONENT", true)]

    //  class static QuestSpawner questSpawnerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"questSpawnerComponent", "QUEST_SPAWNER_COMPONENT", true)]

    //  class static RespawnInternalPortalComponent respawnInternalPortalComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"respawnInternalPortalComponent", "RESPAWN_INTERNAL_PORTAL_COMPONENT", true)]

    //  class static RespawnSceneCommandComponent respawnSceneCommandComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"respawnSceneCommandComponent", "RESPAWN_SCENE_COMMAND_COMPONENT", true)]

    //  class static Spawned spawnedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"spawnedComponent", "SPAWNED_COMPONENT", true)]

    //  class static ToDeactivateComponent toDeactivateComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"toDeactivateComponent", "TO_DEACTIVATE_COMPONENT", true)]

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
    public partial class WorldEntity
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "WorldEntity";
        //public static byte[] Static_ClassName { get; } = [87, 111, 114, 108, 100, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x0200065EU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_WorldEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_WorldEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_WorldEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_WorldEntity obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."WorldEntity"]
    /// </summary>
    public partial class WorldEntity
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
        ///   System.Void AddChangeSceneZoneVisualCommand(SceneZoneVisualsData newReplacement, System.Single newBlendDuration)
        /// </summary>
        /// <param name="newReplacement">class SceneZoneVisualsData</param>
        /// <param name="newBlendDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChangeSceneZoneVisualCommand")]
        ///  extern void ADD_CHANGE_SCENE_ZONE_VISUAL_COMMAND (nint newReplacement, System.Single newBlendDuration);


        /// <summary>
        ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
        ///  extern void ADD_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void AddCurrentAdjustTrigger(AdjustTrigger newValue)
        /// </summary>
        /// <param name="newValue">class AdjustTrigger</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentAdjustTrigger")]
        ///  extern void ADD_CURRENT_ADJUST_TRIGGER (nint newValue);


        /// <summary>
        ///   System.Void AddCurrentSceneZoneVisual(SceneZoneVisualsData newData)
        /// </summary>
        /// <param name="newData">class SceneZoneVisualsData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentSceneZoneVisual")]
        ///  extern void ADD_CURRENT_SCENE_ZONE_VISUAL (nint newData);


        /// <summary>
        ///   System.Void AddCurrentUnitVisualDataOverrideOwner(GameEntity newValue)
        /// </summary>
        /// <param name="newValue">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentUnitVisualDataOverrideOwner")]
        ///  extern void ADD_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER (nint newValue);


        /// <summary>
        ///   System.Void AddCurrentZone(ZoneType newZone)
        /// </summary>
        /// <param name="newZone">enum ZoneType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCurrentZone")]
        ///  extern void ADD_CURRENT_ZONE (ZoneType newZone);


        /// <summary>
        ///   System.Void AddFogMultiplier(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFogMultiplier")]
        ///  extern void ADD_FOG_MULTIPLIER (System.Single newValue);


        /// <summary>
        ///   System.Void AddGenericSpawner(GenericSpawner newSpawner)
        /// </summary>
        /// <param name="newSpawner">abstract class GenericSpawner</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGenericSpawner")]
        ///  extern void ADD_GENERIC_SPAWNER (nint newSpawner);


        /// <summary>
        ///   System.Void AddGenericSpawnerEventHolder(GenericSpawnerRelay newRelayObj)
        /// </summary>
        /// <param name="newRelayObj">class GenericSpawnerRelay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGenericSpawnerEventHolder")]
        ///  extern void ADD_GENERIC_SPAWNER_EVENT_HOLDER (nint newRelayObj);


        /// <summary>
        ///   System.Void AddGrid(WorldGrid newValue)
        /// </summary>
        /// <param name="newValue">class WorldGrid</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGrid")]
        ///  extern void ADD_GRID (nint newValue);


        /// <summary>
        ///   System.Void AddMainOverworld(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMainOverworld")]
        ///  extern void ADD_MAIN_OVERWORLD (nint newValue);


        /// <summary>
        ///   System.Void AddMapIconWorldExploredTable(System.Collections.Generic.HashSet<UnityEngine.Vector3> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.HashSet<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapIconWorldExploredTable")]
        ///  extern void ADD_MAP_ICON_WORLD_EXPLORED_TABLE (nint newValue);


        /// <summary>
        ///   System.Void AddMapUIWorldSceneController(MapUIWorldSceneController newValue)
        /// </summary>
        /// <param name="newValue">class MapUIWorldSceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddMapUIWorldSceneController")]
        ///  extern void ADD_MAP_UI_WORLD_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void AddOverrideSceneZoneVisualBlendDuration(System.Single newDuration)
        /// </summary>
        /// <param name="newDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddOverrideSceneZoneVisualBlendDuration")]
        ///  extern void ADD_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION (System.Single newDuration);


        /// <summary>
        ///   System.Void AddRespawnList(System.Collections.Generic.List<System.Single> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddRespawnList")]
        ///  extern void ADD_RESPAWN_LIST (nint newValue);


        /// <summary>
        ///   System.Void AddSceneController(SceneController newValue)
        /// </summary>
        /// <param name="newValue">class SceneController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneController")]
        ///  extern void ADD_SCENE_CONTROLLER (nint newValue);


        /// <summary>
        ///   System.Void AddSceneZoneVisualReplacementData(SceneZoneVisualsData newValue)
        /// </summary>
        /// <param name="newValue">class SceneZoneVisualsData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneZoneVisualReplacementData")]
        ///  extern void ADD_SCENE_ZONE_VISUAL_REPLACEMENT_DATA (nint newValue);


        /// <summary>
        ///   System.Void AddSpawnedEnemies(System.Collections.Generic.List<UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnedEnemies")]
        ///  extern void ADD_SPAWNED_ENEMIES (nint newValue);


        /// <summary>
        ///   System.Void AddSpawnerCallback(Sigtrap.Relays.Relay<System.Collections.Generic.List<UnityEngine.GameObject>> newOnSpawnComplete, Sigtrap.Relays.Relay newOnWaveClear, Sigtrap.Relays.Relay newOnDespawnComplete, Sigtrap.Relays.Relay newCheckAllKilled, Sigtrap.Relays.Relay newOnAllKilled)
        /// </summary>
        /// <param name="newOnSpawnComplete">class Sigtrap.Relays.Relay<System.Collections.Generic.List<UnityEngine.GameObject>></param>
        /// <param name="newOnWaveClear">class Sigtrap.Relays.Relay</param>
        /// <param name="newOnDespawnComplete">class Sigtrap.Relays.Relay</param>
        /// <param name="newCheckAllKilled">class Sigtrap.Relays.Relay</param>
        /// <param name="newOnAllKilled">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnerCallback")]
        ///  extern void ADD_SPAWNER_CALLBACK (nint newOnSpawnComplete, nint newOnWaveClear, nint newOnDespawnComplete, nint newCheckAllKilled, nint newOnAllKilled);


        /// <summary>
        ///   System.Void AddSpawnerCurrentCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnerCurrentCount")]
        ///  extern void ADD_SPAWNER_CURRENT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void AddSpawnerOverrideDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnerOverrideDuration")]
        ///  extern void ADD_SPAWNER_OVERRIDE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void AddSpawnLocation(SpawnLocation newValue)
        /// </summary>
        /// <param name="newValue">enum SpawnLocation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnLocation")]
        ///  extern void ADD_SPAWN_LOCATION (SpawnLocation newValue);


        /// <summary>
        ///   System.Void AddSpawnTableItem(SpawnTableItem newValue)
        /// </summary>
        /// <param name="newValue">class SpawnTableItem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnTableItem")]
        ///  extern void ADD_SPAWN_TABLE_ITEM (nint newValue);


        /// <summary>
        ///   System.Void AddSpawnType(SpawnType newValue)
        /// </summary>
        /// <param name="newValue">enum SpawnType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpawnType")]
        ///  extern void ADD_SPAWN_TYPE (SpawnType newValue);


        /// <summary>
        ///   System.Void AddTilemapGrid(UnityEngine.Grid newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Grid</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTilemapGrid")]
        ///  extern void ADD_TILEMAP_GRID (nint newValue);


        /// <summary>
        ///   System.Void AddTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimer")]
        ///  extern void ADD_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void AddTimerCallback(System.Collections.Generic.List<TimerCallbackInfo> newInfoTable)
        /// </summary>
        /// <param name="newInfoTable">class System.Collections.Generic.List<TimerCallbackInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddTimerCallback")]
        ///  extern void ADD_TIMER_CALLBACK (nint newInfoTable);


        /// <summary>
        ///   System.Void AddUnitSpawner(UnitSpawner newSpawner, System.Int32 newSpawnCount, System.Single newSpawnTimer)
        /// </summary>
        /// <param name="newSpawner">class UnitSpawner</param>
        /// <param name="newSpawnCount">struct System.Int32</param>
        /// <param name="newSpawnTimer">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddUnitSpawner")]
        ///  extern void ADD_UNIT_SPAWNER (nint newSpawner, System.Int32 newSpawnCount, System.Single newSpawnTimer);


        /// <summary>
        ///   System.Void AddWaveClearGiveKey(KeyData newValue)
        /// </summary>
        /// <param name="newValue">class KeyData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWaveClearGiveKey")]
        ///  extern void ADD_WAVE_CLEAR_GIVE_KEY (nint newValue);


        /// <summary>
        ///   System.Void AddWaypoint(System.Collections.Generic.List<UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWaypoint")]
        ///  extern void ADD_WAYPOINT (nint newValue);


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
        ///   ChangeSceneZoneVisualCommandComponent get_changeSceneZoneVisualCommand()
        /// </summary>
        /// <returns>class ChangeSceneZoneVisualCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneZoneVisualCommand")]
        ///  extern nint GET_CHANGE_SCENE_ZONE_VISUAL_COMMAND ();


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
        ///   System.Int32 get_creationIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creationIndex")]
        ///  extern System.Int32 GET_CREATION_INDEX ();


        /// <summary>
        ///   CurrentAdjustTriggerComponent get_currentAdjustTrigger()
        /// </summary>
        /// <returns>class CurrentAdjustTriggerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentAdjustTrigger")]
        ///  extern nint GET_CURRENT_ADJUST_TRIGGER ();


        /// <summary>
        ///   CurrentSceneZoneVisualComponent get_currentSceneZoneVisual()
        /// </summary>
        /// <returns>class CurrentSceneZoneVisualComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentSceneZoneVisual")]
        ///  extern nint GET_CURRENT_SCENE_ZONE_VISUAL ();


        /// <summary>
        ///   CurrentUnitVisualDataOverrideOwnerComponent get_currentUnitVisualDataOverrideOwner()
        /// </summary>
        /// <returns>class CurrentUnitVisualDataOverrideOwnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentUnitVisualDataOverrideOwner")]
        ///  extern nint GET_CURRENT_UNIT_VISUAL_DATA_OVERRIDE_OWNER ();


        /// <summary>
        ///   CurrentZoneComponent get_currentZone()
        /// </summary>
        /// <returns>class CurrentZoneComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currentZone", CallConvs = [typeof(CallConvCdecl)])]
        extern CurrentZoneComponent.Ptr_CurrentZoneComponent GET_CURRENT_ZONE();


        /// <summary>
        ///   FogMultiplierComponent get_fogMultiplier()
        /// </summary>
        /// <returns>class FogMultiplierComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fogMultiplier")]
        ///  extern nint GET_FOG_MULTIPLIER ();


        /// <summary>
        ///   GenericSpawnerComponent get_genericSpawner()
        /// </summary>
        /// <returns>class GenericSpawnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_genericSpawner")]
        ///  extern nint GET_GENERIC_SPAWNER ();


        /// <summary>
        ///   GenericSpawnerEventHolderComponent get_genericSpawnerEventHolder()
        /// </summary>
        /// <returns>class GenericSpawnerEventHolderComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_genericSpawnerEventHolder")]
        ///  extern nint GET_GENERIC_SPAWNER_EVENT_HOLDER ();


        /// <summary>
        ///   GridComponent get_grid()
        /// </summary>
        /// <returns>class GridComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_grid")]
        ///  extern nint GET_GRID ();


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
        ///   System.Boolean get_hasGenericSpawner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGenericSpawner")]
        ///  extern System.Boolean GET_HAS_GENERIC_SPAWNER ();


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
        ///   System.Boolean get_hasRespawnList()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRespawnList")]
        ///  extern System.Boolean GET_HAS_RESPAWN_LIST ();


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
        ///   System.Boolean get_hasSpawnedEnemies()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnedEnemies")]
        ///  extern System.Boolean GET_HAS_SPAWNED_ENEMIES ();


        /// <summary>
        ///   System.Boolean get_hasSpawnerCallback()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnerCallback")]
        ///  extern System.Boolean GET_HAS_SPAWNER_CALLBACK ();


        /// <summary>
        ///   System.Boolean get_hasSpawnerCurrentCount()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnerCurrentCount")]
        ///  extern System.Boolean GET_HAS_SPAWNER_CURRENT_COUNT ();


        /// <summary>
        ///   System.Boolean get_hasSpawnerOverrideDuration()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnerOverrideDuration")]
        ///  extern System.Boolean GET_HAS_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   System.Boolean get_hasSpawnLocation()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnLocation")]
        ///  extern System.Boolean GET_HAS_SPAWN_LOCATION ();


        /// <summary>
        ///   System.Boolean get_hasSpawnTableItem()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnTableItem")]
        ///  extern System.Boolean GET_HAS_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   System.Boolean get_hasSpawnType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpawnType")]
        ///  extern System.Boolean GET_HAS_SPAWN_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasTilemapGrid()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTilemapGrid")]
        ///  extern System.Boolean GET_HAS_TILEMAP_GRID ();


        /// <summary>
        ///   System.Boolean get_hasTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimer")]
        ///  extern System.Boolean GET_HAS_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasTimerCallback()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTimerCallback")]
        ///  extern System.Boolean GET_HAS_TIMER_CALLBACK ();


        /// <summary>
        ///   System.Boolean get_hasUnitSpawner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasUnitSpawner")]
        ///  extern System.Boolean GET_HAS_UNIT_SPAWNER ();


        /// <summary>
        ///   System.Boolean get_hasWaveClearGiveKey()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWaveClearGiveKey")]
        ///  extern System.Boolean GET_HAS_WAVE_CLEAR_GIVE_KEY ();


        /// <summary>
        ///   System.Boolean get_hasWaypoint()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWaypoint")]
        ///  extern System.Boolean GET_HAS_WAYPOINT ();


        /// <summary>
        ///   System.Boolean get_hasWorldDestroyedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasWorldDestroyedListener")]
        ///  extern System.Boolean GET_HAS_WORLD_DESTROYED_LISTENER ();


        /// <summary>
        ///   System.Boolean get_isActivateSpawner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActivateSpawner")]
        ///  extern System.Boolean GET_IS_ACTIVATE_SPAWNER ();


        /// <summary>
        ///   System.Boolean get_isBlockSceneZoneDetection()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isBlockSceneZoneDetection")]
        ///  extern System.Boolean GET_IS_BLOCK_SCENE_ZONE_DETECTION ();


        /// <summary>
        ///   System.Boolean get_isCanRespawn()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCanRespawn")]
        ///  extern System.Boolean GET_IS_CAN_RESPAWN ();


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
        ///   System.Boolean get_isDestroyed()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyed")]
        ///  extern System.Boolean GET_IS_DESTROYED ();


        /// <summary>
        ///   System.Boolean get_isDestroyOverworldCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyOverworldCommand")]
        ///  extern System.Boolean GET_IS_DESTROY_OVERWORLD_COMMAND ();


        /// <summary>
        ///   System.Boolean get_isEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnabled")]
        ///  extern System.Boolean GET_IS_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isFirstInit()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isFirstInit")]
        ///  extern System.Boolean GET_IS_FIRST_INIT ();


        /// <summary>
        ///   System.Boolean get_isInactive()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInactive")]
        ///  extern System.Boolean GET_IS_INACTIVE ();


        /// <summary>
        ///   System.Boolean get_isInfinitySpawner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInfinitySpawner")]
        ///  extern System.Boolean GET_IS_INFINITY_SPAWNER ();


        /// <summary>
        ///   System.Boolean get_isQuestSpawner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isQuestSpawner")]
        ///  extern System.Boolean GET_IS_QUEST_SPAWNER ();


        /// <summary>
        ///   System.Boolean get_isRespawnInternalPortal()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRespawnInternalPortal")]
        ///  extern System.Boolean GET_IS_RESPAWN_INTERNAL_PORTAL ();


        /// <summary>
        ///   System.Boolean get_isRespawnSceneCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRespawnSceneCommand")]
        ///  extern System.Boolean GET_IS_RESPAWN_SCENE_COMMAND ();


        /// <summary>
        ///   System.Boolean get_isSpawned()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSpawned")]
        ///  extern System.Boolean GET_IS_SPAWNED ();


        /// <summary>
        ///   System.Boolean get_isToDeactivate()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isToDeactivate")]
        ///  extern System.Boolean GET_IS_TO_DEACTIVATE ();


        /// <summary>
        ///   MainOverworldComponent get_mainOverworld()
        /// </summary>
        /// <returns>class MainOverworldComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mainOverworld")]
        ///  extern nint GET_MAIN_OVERWORLD ();


        /// <summary>
        ///   MapIconWorldExploredTableComponent get_mapIconWorldExploredTable()
        /// </summary>
        /// <returns>class MapIconWorldExploredTableComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapIconWorldExploredTable")]
        ///  extern nint GET_MAP_ICON_WORLD_EXPLORED_TABLE ();


        /// <summary>
        ///   MapUIWorldSceneControllerComponent get_mapUIWorldSceneController()
        /// </summary>
        /// <returns>class MapUIWorldSceneControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_mapUIWorldSceneController")]
        ///  extern nint GET_MAP_UI_WORLD_SCENE_CONTROLLER ();


        /// <summary>
        ///   OverrideSceneZoneVisualBlendDurationComponent get_overrideSceneZoneVisualBlendDuration()
        /// </summary>
        /// <returns>class OverrideSceneZoneVisualBlendDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_overrideSceneZoneVisualBlendDuration")]
        ///  extern nint GET_OVERRIDE_SCENE_ZONE_VISUAL_BLEND_DURATION ();


        /// <summary>
        ///   RespawnList get_respawnList()
        /// </summary>
        /// <returns>class RespawnList</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_respawnList")]
        ///  extern nint GET_RESPAWN_LIST ();


        /// <summary>
        ///   System.Int32 get_retainCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
        ///  extern System.Int32 GET_RETAIN_COUNT ();


        /// <summary>
        ///   SceneControllerComponent get_sceneController()
        /// </summary>
        /// <returns>class SceneControllerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneController")]
        ///  extern nint GET_SCENE_CONTROLLER ();


        /// <summary>
        ///   SceneZoneVisualReplacementDataComponent get_sceneZoneVisualReplacementData()
        /// </summary>
        /// <returns>class SceneZoneVisualReplacementDataComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneZoneVisualReplacementData")]
        ///  extern nint GET_SCENE_ZONE_VISUAL_REPLACEMENT_DATA ();


        /// <summary>
        ///   SpawnedEnemiesComponent get_spawnedEnemies()
        /// </summary>
        /// <returns>class SpawnedEnemiesComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnedEnemies")]
        ///  extern nint GET_SPAWNED_ENEMIES ();


        /// <summary>
        ///   SpawnerCallbackComponent get_spawnerCallback()
        /// </summary>
        /// <returns>class SpawnerCallbackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnerCallback")]
        ///  extern nint GET_SPAWNER_CALLBACK ();


        /// <summary>
        ///   SpawnerCurrentCountComponent get_spawnerCurrentCount()
        /// </summary>
        /// <returns>class SpawnerCurrentCountComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnerCurrentCount")]
        ///  extern nint GET_SPAWNER_CURRENT_COUNT ();


        /// <summary>
        ///   SpawnerOverrideDurationComponent get_spawnerOverrideDuration()
        /// </summary>
        /// <returns>class SpawnerOverrideDurationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnerOverrideDuration")]
        ///  extern nint GET_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   SpawnLocationComponent get_spawnLocation()
        /// </summary>
        /// <returns>class SpawnLocationComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnLocation")]
        ///  extern nint GET_SPAWN_LOCATION ();


        /// <summary>
        ///   SpawnTableItemComponent get_spawnTableItem()
        /// </summary>
        /// <returns>class SpawnTableItemComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnTableItem")]
        ///  extern nint GET_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   SpawnTypeComponent get_spawnType()
        /// </summary>
        /// <returns>class SpawnTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spawnType")]
        ///  extern nint GET_SPAWN_TYPE ();


        /// <summary>
        ///   TilemapGridComponent get_tilemapGrid()
        /// </summary>
        /// <returns>class TilemapGridComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tilemapGrid")]
        ///  extern nint GET_TILEMAP_GRID ();


        /// <summary>
        ///   TimerComponent get_timer()
        /// </summary>
        /// <returns>class TimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timer")]
        ///  extern nint GET_TIMER ();


        /// <summary>
        ///   TimerCallbackComponent get_timerCallback()
        /// </summary>
        /// <returns>class TimerCallbackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_timerCallback")]
        ///  extern nint GET_TIMER_CALLBACK ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   UnitSpawnerComponent get_unitSpawner()
        /// </summary>
        /// <returns>class UnitSpawnerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_unitSpawner")]
        ///  extern nint GET_UNIT_SPAWNER ();


        /// <summary>
        ///   WaveClearGiveKey get_waveClearGiveKey()
        /// </summary>
        /// <returns>class WaveClearGiveKey</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_waveClearGiveKey")]
        ///  extern nint GET_WAVE_CLEAR_GIVE_KEY ();


        /// <summary>
        ///   WaypointComponent get_waypoint()
        /// </summary>
        /// <returns>class WaypointComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_waypoint")]
        ///  extern nint GET_WAYPOINT ();


        /// <summary>
        ///   WorldDestroyedListenerComponent get_worldDestroyedListener()
        /// </summary>
        /// <returns>class WorldDestroyedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldDestroyedListener")]
        ///  extern nint GET_WORLD_DESTROYED_LISTENER ();


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
        ///   System.Void RemoveChangeSceneZoneVisualCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChangeSceneZoneVisualCommand")]
        ///  extern void REMOVE_CHANGE_SCENE_ZONE_VISUAL_COMMAND ();


        /// <summary>
        ///   System.Void RemoveComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
        ///  extern void REMOVE_COMPONENT (System.Int32 index);


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
        ///   System.Void RemoveGenericSpawner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGenericSpawner")]
        ///  extern void REMOVE_GENERIC_SPAWNER ();


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
        ///   System.Void RemoveRespawnList()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveRespawnList")]
        ///  extern void REMOVE_RESPAWN_LIST ();


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
        ///   System.Void RemoveSpawnedEnemies()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnedEnemies")]
        ///  extern void REMOVE_SPAWNED_ENEMIES ();


        /// <summary>
        ///   System.Void RemoveSpawnerCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnerCallback")]
        ///  extern void REMOVE_SPAWNER_CALLBACK ();


        /// <summary>
        ///   System.Void RemoveSpawnerCurrentCount()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnerCurrentCount")]
        ///  extern void REMOVE_SPAWNER_CURRENT_COUNT ();


        /// <summary>
        ///   System.Void RemoveSpawnerOverrideDuration()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnerOverrideDuration")]
        ///  extern void REMOVE_SPAWNER_OVERRIDE_DURATION ();


        /// <summary>
        ///   System.Void RemoveSpawnLocation()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnLocation")]
        ///  extern void REMOVE_SPAWN_LOCATION ();


        /// <summary>
        ///   System.Void RemoveSpawnTableItem()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnTableItem")]
        ///  extern void REMOVE_SPAWN_TABLE_ITEM ();


        /// <summary>
        ///   System.Void RemoveSpawnType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpawnType")]
        ///  extern void REMOVE_SPAWN_TYPE ();


        /// <summary>
        ///   System.Void RemoveTilemapGrid()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTilemapGrid")]
        ///  extern void REMOVE_TILEMAP_GRID ();


        /// <summary>
        ///   System.Void RemoveTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimer")]
        ///  extern void REMOVE_TIMER ();


        /// <summary>
        ///   System.Void RemoveTimerCallback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveTimerCallback")]
        ///  extern void REMOVE_TIMER_CALLBACK ();


        /// <summary>
        ///   System.Void RemoveUnitSpawner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveUnitSpawner")]
        ///  extern void REMOVE_UNIT_SPAWNER ();


        /// <summary>
        ///   System.Void RemoveWaveClearGiveKey()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWaveClearGiveKey")]
        ///  extern void REMOVE_WAVE_CLEAR_GIVE_KEY ();


        /// <summary>
        ///   System.Void RemoveWaypoint()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWaypoint")]
        ///  extern void REMOVE_WAYPOINT ();


        /// <summary>
        ///   System.Void ReplaceChangeSceneZoneVisualCommand(SceneZoneVisualsData newReplacement, System.Single newBlendDuration)
        /// </summary>
        /// <param name="newReplacement">class SceneZoneVisualsData</param>
        /// <param name="newBlendDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChangeSceneZoneVisualCommand")]
        ///  extern void REPLACE_CHANGE_SCENE_ZONE_VISUAL_COMMAND (nint newReplacement, System.Single newBlendDuration);


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
        ///   System.Void ReplaceGenericSpawner(GenericSpawner newSpawner)
        /// </summary>
        /// <param name="newSpawner">abstract class GenericSpawner</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGenericSpawner")]
        ///  extern void REPLACE_GENERIC_SPAWNER (nint newSpawner);


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
        ///   System.Void ReplaceRespawnList(System.Collections.Generic.List<System.Single> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<System.Single></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceRespawnList")]
        ///  extern void REPLACE_RESPAWN_LIST (nint newValue);


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
        ///   System.Void ReplaceSpawnedEnemies(System.Collections.Generic.List<UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnedEnemies")]
        ///  extern void REPLACE_SPAWNED_ENEMIES (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnerCallback(Sigtrap.Relays.Relay<System.Collections.Generic.List<UnityEngine.GameObject>> newOnSpawnComplete, Sigtrap.Relays.Relay newOnWaveClear, Sigtrap.Relays.Relay newOnDespawnComplete, Sigtrap.Relays.Relay newCheckAllKilled, Sigtrap.Relays.Relay newOnAllKilled)
        /// </summary>
        /// <param name="newOnSpawnComplete">class Sigtrap.Relays.Relay<System.Collections.Generic.List<UnityEngine.GameObject>></param>
        /// <param name="newOnWaveClear">class Sigtrap.Relays.Relay</param>
        /// <param name="newOnDespawnComplete">class Sigtrap.Relays.Relay</param>
        /// <param name="newCheckAllKilled">class Sigtrap.Relays.Relay</param>
        /// <param name="newOnAllKilled">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnerCallback")]
        ///  extern void REPLACE_SPAWNER_CALLBACK (nint newOnSpawnComplete, nint newOnWaveClear, nint newOnDespawnComplete, nint newCheckAllKilled, nint newOnAllKilled);


        /// <summary>
        ///   System.Void ReplaceSpawnerCurrentCount(System.Int32 newValue)
        /// </summary>
        /// <param name="newValue">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnerCurrentCount")]
        ///  extern void REPLACE_SPAWNER_CURRENT_COUNT (System.Int32 newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnerOverrideDuration(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnerOverrideDuration")]
        ///  extern void REPLACE_SPAWNER_OVERRIDE_DURATION (System.Single newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnLocation(SpawnLocation newValue)
        /// </summary>
        /// <param name="newValue">enum SpawnLocation</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnLocation")]
        ///  extern void REPLACE_SPAWN_LOCATION (SpawnLocation newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnTableItem(SpawnTableItem newValue)
        /// </summary>
        /// <param name="newValue">class SpawnTableItem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnTableItem")]
        ///  extern void REPLACE_SPAWN_TABLE_ITEM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSpawnType(SpawnType newValue)
        /// </summary>
        /// <param name="newValue">enum SpawnType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpawnType")]
        ///  extern void REPLACE_SPAWN_TYPE (SpawnType newValue);


        /// <summary>
        ///   System.Void ReplaceTilemapGrid(UnityEngine.Grid newValue)
        /// </summary>
        /// <param name="newValue">class UnityEngine.Grid</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTilemapGrid")]
        ///  extern void REPLACE_TILEMAP_GRID (nint newValue);


        /// <summary>
        ///   System.Void ReplaceTimer(System.Single newElapsed)
        /// </summary>
        /// <param name="newElapsed">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimer")]
        ///  extern void REPLACE_TIMER (System.Single newElapsed);


        /// <summary>
        ///   System.Void ReplaceTimerCallback(System.Collections.Generic.List<TimerCallbackInfo> newInfoTable)
        /// </summary>
        /// <param name="newInfoTable">class System.Collections.Generic.List<TimerCallbackInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceTimerCallback")]
        ///  extern void REPLACE_TIMER_CALLBACK (nint newInfoTable);


        /// <summary>
        ///   System.Void ReplaceUnitSpawner(UnitSpawner newSpawner, System.Int32 newSpawnCount, System.Single newSpawnTimer)
        /// </summary>
        /// <param name="newSpawner">class UnitSpawner</param>
        /// <param name="newSpawnCount">struct System.Int32</param>
        /// <param name="newSpawnTimer">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceUnitSpawner")]
        ///  extern void REPLACE_UNIT_SPAWNER (nint newSpawner, System.Int32 newSpawnCount, System.Single newSpawnTimer);


        /// <summary>
        ///   System.Void ReplaceWaveClearGiveKey(KeyData newValue)
        /// </summary>
        /// <param name="newValue">class KeyData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWaveClearGiveKey")]
        ///  extern void REPLACE_WAVE_CLEAR_GIVE_KEY (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWaypoint(System.Collections.Generic.List<UnityEngine.GameObject> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<UnityEngine.GameObject></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWaypoint")]
        ///  extern void REPLACE_WAYPOINT (nint newValue);


        /// <summary>
        ///   System.Void ReplaceWorldDestroyedListener(System.Collections.Generic.List<IWorldDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IWorldDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceWorldDestroyedListener")]
        ///  extern void REPLACE_WORLD_DESTROYED_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void Retain(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
        ///  extern void RETAIN (nint owner);


        /// <summary>
        ///   System.Void set_isActivateSpawner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isActivateSpawner")]
        ///  extern void SET_IS_ACTIVATE_SPAWNER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isBlockSceneZoneDetection(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isBlockSceneZoneDetection")]
        ///  extern void SET_IS_BLOCK_SCENE_ZONE_DETECTION (System.Boolean value);


        /// <summary>
        ///   System.Void set_isCanRespawn(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCanRespawn")]
        ///  extern void SET_IS_CAN_RESPAWN (System.Boolean value);


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
        ///   System.Void set_isDestroyed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
        ///  extern void SET_IS_DESTROYED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isDestroyOverworldCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyOverworldCommand")]
        ///  extern void SET_IS_DESTROY_OVERWORLD_COMMAND (System.Boolean value);


        /// <summary>
        ///   System.Void set_isFirstInit(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isFirstInit")]
        ///  extern void SET_IS_FIRST_INIT (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInactive(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInactive")]
        ///  extern void SET_IS_INACTIVE (System.Boolean value);


        /// <summary>
        ///   System.Void set_isInfinitySpawner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInfinitySpawner")]
        ///  extern void SET_IS_INFINITY_SPAWNER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isQuestSpawner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isQuestSpawner")]
        ///  extern void SET_IS_QUEST_SPAWNER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRespawnInternalPortal(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRespawnInternalPortal")]
        ///  extern void SET_IS_RESPAWN_INTERNAL_PORTAL (System.Boolean value);


        /// <summary>
        ///   System.Void set_isRespawnSceneCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isRespawnSceneCommand")]
        ///  extern void SET_IS_RESPAWN_SCENE_COMMAND (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSpawned(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSpawned")]
        ///  extern void SET_IS_SPAWNED (System.Boolean value);


        /// <summary>
        ///   System.Void set_isToDeactivate(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isToDeactivate")]
        ///  extern void SET_IS_TO_DEACTIVATE (System.Boolean value);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_WorldEntity))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_WorldEntity))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void AddWorldDestroyedListener(System.Collections.Generic.List<IWorldDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IWorldDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDestroyedListener", Search = typeof(Search_WorldEntity))]
        ///  extern void ADD_WORLD_DESTROYED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddWorldDestroyedListener(IWorldDestroyedListener value)
        /// </summary>
        /// <param name="value">interface IWorldDestroyedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddWorldDestroyedListener", Search = typeof(Search_WorldEntity))]
        ///  extern void ADD_WORLD_DESTROYED_LISTENER_01 (nint value);


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_WorldEntity))]
        ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_WorldEntity))]
        ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveWorldDestroyedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDestroyedListener", Search = typeof(Search_WorldEntity))]
        ///  extern void REMOVE_WORLD_DESTROYED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveWorldDestroyedListener(IWorldDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IWorldDestroyedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveWorldDestroyedListener", Search = typeof(Search_WorldEntity))]
        ///  extern void REMOVE_WORLD_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_WorldEntity
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
        ///   System.Void AddWorldDestroyedListener(System.Collections.Generic.List<IWorldDestroyedListener> newValue)
        /// </summary>
        /// public static bool ADD_WORLD_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddWorldDestroyedListener", "System.Collections.Generic.List<IWorldDestroyedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddWorldDestroyedListener(IWorldDestroyedListener value)
        /// </summary>
        /// public static bool ADD_WORLD_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddWorldDestroyedListener", "IWorldDestroyedListener");
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


        /// <summary>
        ///   System.Void RemoveWorldDestroyedListener()
        /// </summary>
        /// public static bool REMOVE_WORLD_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveWorldDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveWorldDestroyedListener(IWorldDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_WORLD_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveWorldDestroyedListener", "IWorldDestroyedListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}