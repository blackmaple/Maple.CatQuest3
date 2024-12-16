
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
    /// class ["ProjectStar".""."FrameworkContext"]
    /// [Entitas.Context<FrameworkEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000631U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [70, 114, 97, 109, 101, 119, 111, 114, 107, 67, 111, 110, 116, 101, 120, 116])]


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

    // class 0x24 System.Func<FrameworkEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]

    // class 0x28 System.Collections.Generic.HashSet<FrameworkEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]

    // class 0x2C System.Collections.Generic.Stack<FrameworkEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]

    // class 0x30 System.Collections.Generic.HashSet<FrameworkEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]

    // class 0x34 System.Collections.Generic.Dictionary<Entitas.IMatcher<FrameworkEntity>,Entitas.IGroup<FrameworkEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]

    // class 0x38 System.Collections.Generic.List<Entitas.IGroup<FrameworkEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]

    // class 0x3C DesperateDevs.Caching.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<FrameworkEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]

    // class 0x40 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]

    // class 0x44 FrameworkEntity[] _entitiesCache
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
    public partial class FrameworkContext
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "FrameworkContext";
        //public static byte[] Static_ClassName { get; } = [70, 114, 97, 109, 101, 119, 111, 114, 107, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x02000631U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_FrameworkContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_FrameworkContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_FrameworkContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_FrameworkContext obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."FrameworkContext"]
    /// </summary>
    public partial class FrameworkContext
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
        ///   FrameworkEntity CreateEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
        ///  extern nint CREATE_ENTITY ();


        /// <summary>
        ///   System.Void DestroyAllEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
        ///  extern void DESTROY_ALL_ENTITIES ();


        /// <summary>
        ///   ChangeSceneCommandComponent get_changeSceneCommand()
        /// </summary>
        /// <returns>class ChangeSceneCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneCommand")]
        ///  extern nint GET_CHANGE_SCENE_COMMAND ();


        /// <summary>
        ///   FrameworkEntity get_changeSceneCommandEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneCommandEntity")]
        ///  extern nint GET_CHANGE_SCENE_COMMAND_ENTITY ();


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
        ///   FileSystemComponent get_fileSystem()
        /// </summary>
        /// <returns>class FileSystemComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fileSystem")]
        ///  extern nint GET_FILE_SYSTEM ();


        /// <summary>
        ///   FrameworkEntity get_fileSystemEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fileSystemEntity")]
        ///  extern nint GET_FILE_SYSTEM_ENTITY ();


        /// <summary>
        ///   FrameworkEntity get_gameOverEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameOverEntity")]
        ///  extern nint GET_GAME_OVER_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasChangeSceneCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChangeSceneCommand")]
        ///  extern System.Boolean GET_HAS_CHANGE_SCENE_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasFileSystem()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFileSystem")]
        ///  extern System.Boolean GET_HAS_FILE_SYSTEM ();


        /// <summary>
        ///   System.Boolean get_hasParticleSystem()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasParticleSystem")]
        ///  extern System.Boolean GET_HAS_PARTICLE_SYSTEM ();


        /// <summary>
        ///   System.Boolean get_hasParticleSystemCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasParticleSystemCommand")]
        ///  extern System.Boolean GET_HAS_PARTICLE_SYSTEM_COMMAND ();


        /// <summary>
        ///   System.Boolean get_hasSceneChangeStatus()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneChangeStatus")]
        ///  extern System.Boolean GET_HAS_SCENE_CHANGE_STATUS ();


        /// <summary>
        ///   System.Boolean get_hasSceneManagementServiceOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneManagementServiceOwner")]
        ///  extern System.Boolean GET_HAS_SCENE_MANAGEMENT_SERVICE_OWNER ();


        /// <summary>
        ///   System.Boolean get_hasSceneType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneType")]
        ///  extern System.Boolean GET_HAS_SCENE_TYPE ();


        /// <summary>
        ///   System.Boolean get_isGameOver()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isGameOver")]
        ///  extern System.Boolean GET_IS_GAME_OVER ();


        /// <summary>
        ///   System.Boolean get_isSceneCommandOwner()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isSceneCommandOwner")]
        ///  extern System.Boolean GET_IS_SCENE_COMMAND_OWNER ();


        /// <summary>
        ///   System.Boolean get_isStartGameCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isStartGameCommand")]
        ///  extern System.Boolean GET_IS_START_GAME_COMMAND ();


        /// <summary>
        ///   ParticleSystemComponent get_particleSystem()
        /// </summary>
        /// <returns>class ParticleSystemComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_particleSystem")]
        ///  extern nint GET_PARTICLE_SYSTEM ();


        /// <summary>
        ///   ParticleSystemCommandComponent get_particleSystemCommand()
        /// </summary>
        /// <returns>class ParticleSystemCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_particleSystemCommand")]
        ///  extern nint GET_PARTICLE_SYSTEM_COMMAND ();


        /// <summary>
        ///   FrameworkEntity get_particleSystemCommandEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_particleSystemCommandEntity")]
        ///  extern nint GET_PARTICLE_SYSTEM_COMMAND_ENTITY ();


        /// <summary>
        ///   FrameworkEntity get_particleSystemEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_particleSystemEntity")]
        ///  extern nint GET_PARTICLE_SYSTEM_ENTITY ();


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
        ///   SceneChangeStatusComponent get_sceneChangeStatus()
        /// </summary>
        /// <returns>class SceneChangeStatusComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneChangeStatus")]
        ///  extern nint GET_SCENE_CHANGE_STATUS ();


        /// <summary>
        ///   FrameworkEntity get_sceneChangeStatusEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneChangeStatusEntity")]
        ///  extern nint GET_SCENE_CHANGE_STATUS_ENTITY ();


        /// <summary>
        ///   FrameworkEntity get_sceneCommandOwnerEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneCommandOwnerEntity")]
        ///  extern nint GET_SCENE_COMMAND_OWNER_ENTITY ();


        /// <summary>
        ///   SceneManagementServiceOwner get_sceneManagementServiceOwner()
        /// </summary>
        /// <returns>class SceneManagementServiceOwner</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneManagementServiceOwner")]
        ///  extern nint GET_SCENE_MANAGEMENT_SERVICE_OWNER ();


        /// <summary>
        ///   FrameworkEntity get_sceneManagementServiceOwnerEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneManagementServiceOwnerEntity")]
        ///  extern nint GET_SCENE_MANAGEMENT_SERVICE_OWNER_ENTITY ();


        /// <summary>
        ///   SceneTypeComponent get_sceneType()
        /// </summary>
        /// <returns>class SceneTypeComponent</returns>
        //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneType", CallConvs = [typeof(CallConvCdecl)])]
        //extern SceneTypeComponent.Ptr_SceneTypeComponent GET_SCENE_TYPE();


        /// <summary>
        ///   FrameworkEntity get_sceneTypeEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneTypeEntity", CallConvs = [typeof(CallConvCdecl)])]
        extern FrameworkEntity.Ptr_FrameworkEntity GET_SCENE_TYPE_ENTITY();


        /// <summary>
        ///   FrameworkEntity get_startGameCommandEntity()
        /// </summary>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_startGameCommandEntity")]
        ///  extern nint GET_START_GAME_COMMAND_ENTITY ();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   FrameworkEntity[] GetEntities()
        /// </summary>
        /// <returns>class FrameworkEntity[]</returns>
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
        ///   Entitas.IGroup<FrameworkEntity> GetGroup(Entitas.IMatcher<FrameworkEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<FrameworkEntity></param>
        /// <returns>interface Entitas.IGroup<FrameworkEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
        ///  extern nint GET_GROUP (nint matcher);


        /// <summary>
        ///   System.Boolean HasEntity(FrameworkEntity entity)
        /// </summary>
        /// <param name="entity">class FrameworkEntity</param>
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
        ///   System.Void RemoveChangeSceneCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChangeSceneCommand")]
        ///  extern void REMOVE_CHANGE_SCENE_COMMAND ();


        /// <summary>
        ///   System.Void RemoveFileSystem()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFileSystem")]
        ///  extern void REMOVE_FILE_SYSTEM ();


        /// <summary>
        ///   System.Void RemoveParticleSystem()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveParticleSystem")]
        ///  extern void REMOVE_PARTICLE_SYSTEM ();


        /// <summary>
        ///   System.Void RemoveParticleSystemCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveParticleSystemCommand")]
        ///  extern void REMOVE_PARTICLE_SYSTEM_COMMAND ();


        /// <summary>
        ///   System.Void RemoveSceneChangeStatus()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneChangeStatus")]
        ///  extern void REMOVE_SCENE_CHANGE_STATUS ();


        /// <summary>
        ///   System.Void RemoveSceneManagementServiceOwner()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneManagementServiceOwner")]
        ///  extern void REMOVE_SCENE_MANAGEMENT_SERVICE_OWNER ();


        /// <summary>
        ///   System.Void RemoveSceneType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneType")]
        ///  extern void REMOVE_SCENE_TYPE ();


        /// <summary>
        ///   System.Void ReplaceChangeSceneCommand(ChangeSceneInfo newInfo)
        /// </summary>
        /// <param name="newInfo">class ChangeSceneInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceChangeSceneCommand")]
        ///  extern void REPLACE_CHANGE_SCENE_COMMAND (nint newInfo);


        /// <summary>
        ///   System.Void ReplaceFileSystem(Gentlebros.Framework.FileSystem.IFileSystem newValue)
        /// </summary>
        /// <param name="newValue">interface Gentlebros.Framework.FileSystem.IFileSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFileSystem")]
        ///  extern void REPLACE_FILE_SYSTEM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceParticleSystem(ParticleSystemBehaviour newParticleSystemBehaviour)
        /// </summary>
        /// <param name="newParticleSystemBehaviour">class ParticleSystemBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceParticleSystem")]
        ///  extern void REPLACE_PARTICLE_SYSTEM (nint newParticleSystemBehaviour);


        /// <summary>
        ///   System.Void ReplaceParticleSystemCommand(ParticleSystemKey[] newTargetParticles)
        /// </summary>
        /// <param name="newTargetParticles">class ParticleSystemKey[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceParticleSystemCommand")]
        ///  extern void REPLACE_PARTICLE_SYSTEM_COMMAND (nint newTargetParticles);


        /// <summary>
        ///   System.Void ReplaceSceneChangeStatus(SceneChangeStatus newStatus)
        /// </summary>
        /// <param name="newStatus">enum SceneChangeStatus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneChangeStatus")]
        ///  extern void REPLACE_SCENE_CHANGE_STATUS (SceneChangeStatus newStatus);


        /// <summary>
        ///   System.Void ReplaceSceneManagementServiceOwner(Sigtrap.Relays.Relay newAllLoadingCompleted, Sigtrap.Relays.Relay newAllUnloadingCompleted)
        /// </summary>
        /// <param name="newAllLoadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <param name="newAllUnloadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneManagementServiceOwner")]
        ///  extern void REPLACE_SCENE_MANAGEMENT_SERVICE_OWNER (nint newAllLoadingCompleted, nint newAllUnloadingCompleted);


        /// <summary>
        ///   System.Void ReplaceSceneType(SceneType newValue)
        /// </summary>
        /// <param name="newValue">enum SceneType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneType")]
        ///  extern void REPLACE_SCENE_TYPE (SceneType newValue);


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
        ///   System.Void set_isGameOver(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isGameOver")]
        ///  extern void SET_IS_GAME_OVER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isSceneCommandOwner(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isSceneCommandOwner")]
        ///  extern void SET_IS_SCENE_COMMAND_OWNER (System.Boolean value);


        /// <summary>
        ///   System.Void set_isStartGameCommand(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isStartGameCommand")]
        ///  extern void SET_IS_START_GAME_COMMAND (System.Boolean value);


        /// <summary>
        ///   FrameworkEntity SetChangeSceneCommand(ChangeSceneInfo newInfo)
        /// </summary>
        /// <param name="newInfo">class ChangeSceneInfo</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetChangeSceneCommand")]
        ///  extern nint SET_CHANGE_SCENE_COMMAND (nint newInfo);


        /// <summary>
        ///   FrameworkEntity SetFileSystem(Gentlebros.Framework.FileSystem.IFileSystem newValue)
        /// </summary>
        /// <param name="newValue">interface Gentlebros.Framework.FileSystem.IFileSystem</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFileSystem")]
        ///  extern nint SET_FILE_SYSTEM (nint newValue);


        /// <summary>
        ///   FrameworkEntity SetParticleSystem(ParticleSystemBehaviour newParticleSystemBehaviour)
        /// </summary>
        /// <param name="newParticleSystemBehaviour">class ParticleSystemBehaviour</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetParticleSystem")]
        ///  extern nint SET_PARTICLE_SYSTEM (nint newParticleSystemBehaviour);


        /// <summary>
        ///   FrameworkEntity SetParticleSystemCommand(ParticleSystemKey[] newTargetParticles)
        /// </summary>
        /// <param name="newTargetParticles">class ParticleSystemKey[]</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetParticleSystemCommand")]
        ///  extern nint SET_PARTICLE_SYSTEM_COMMAND (nint newTargetParticles);


        /// <summary>
        ///   FrameworkEntity SetSceneChangeStatus(SceneChangeStatus newStatus)
        /// </summary>
        /// <param name="newStatus">enum SceneChangeStatus</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSceneChangeStatus")]
        ///  extern nint SET_SCENE_CHANGE_STATUS (SceneChangeStatus newStatus);


        /// <summary>
        ///   FrameworkEntity SetSceneManagementServiceOwner(Sigtrap.Relays.Relay newAllLoadingCompleted, Sigtrap.Relays.Relay newAllUnloadingCompleted)
        /// </summary>
        /// <param name="newAllLoadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <param name="newAllUnloadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSceneManagementServiceOwner")]
        ///  extern nint SET_SCENE_MANAGEMENT_SERVICE_OWNER (nint newAllLoadingCompleted, nint newAllUnloadingCompleted);


        /// <summary>
        ///   FrameworkEntity SetSceneType(SceneType newValue)
        /// </summary>
        /// <param name="newValue">enum SceneType</param>
        /// <returns>class FrameworkEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSceneType")]
        ///  extern nint SET_SCENE_TYPE (SceneType newValue);


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
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_FrameworkContext))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<FrameworkEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="entityFactory">class System.Func<FrameworkEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_FrameworkContext))]
        ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<FrameworkEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="startCreationIndex">struct System.Int32</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
        /// <param name="entityFactory">class System.Func<FrameworkEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_FrameworkContext))]
        ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);


        /// public static partial class Search_FrameworkContext
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
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<FrameworkEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<FrameworkEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<FrameworkEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<FrameworkEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}