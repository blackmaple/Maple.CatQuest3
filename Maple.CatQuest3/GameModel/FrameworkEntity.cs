
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
    /// class ["ProjectStar".""."FrameworkEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// [IDestroyedEntity]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000632U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [70, 114, 97, 109, 101, 119, 111, 114, 107, 69, 110, 116, 105, 116, 121])]

    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]

    //  class static GameOverComponent gameOverComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"gameOverComponent", "GAME_OVER_COMPONENT", true)]

    //  class static SceneCommandOwner sceneCommandOwnerComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"sceneCommandOwnerComponent", "SCENE_COMMAND_OWNER_COMPONENT", true)]

    //  class static StartGameCommandComponent startGameCommandComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"startGameCommandComponent", "START_GAME_COMMAND_COMPONENT", true)]

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
    public partial class FrameworkEntity
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "FrameworkEntity";
        //public static byte[] Static_ClassName { get; } = [70, 114, 97, 109, 101, 119, 111, 114, 107, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x02000632U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_FrameworkEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_FrameworkEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_FrameworkEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_FrameworkEntity obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."FrameworkEntity"]
    /// </summary>
    public partial class FrameworkEntity
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
        ///   System.Void AddChangeSceneCommand(ChangeSceneInfo newInfo)
        /// </summary>
        /// <param name="newInfo">class ChangeSceneInfo</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddChangeSceneCommand")]
        ///  extern void ADD_CHANGE_SCENE_COMMAND (nint newInfo);


        /// <summary>
        ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
        ///  extern void ADD_COMPONENT (System.Int32 index, nint component);


        /// <summary>
        ///   System.Void AddFileSystem(Gentlebros.Framework.FileSystem.IFileSystem newValue)
        /// </summary>
        /// <param name="newValue">interface Gentlebros.Framework.FileSystem.IFileSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFileSystem")]
        ///  extern void ADD_FILE_SYSTEM (nint newValue);


        /// <summary>
        ///   System.Void AddParticleSystem(ParticleSystemBehaviour newParticleSystemBehaviour)
        /// </summary>
        /// <param name="newParticleSystemBehaviour">class ParticleSystemBehaviour</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddParticleSystem")]
        ///  extern void ADD_PARTICLE_SYSTEM (nint newParticleSystemBehaviour);


        /// <summary>
        ///   System.Void AddParticleSystemCommand(ParticleSystemKey[] newTargetParticles)
        /// </summary>
        /// <param name="newTargetParticles">class ParticleSystemKey[]</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddParticleSystemCommand")]
        ///  extern void ADD_PARTICLE_SYSTEM_COMMAND (nint newTargetParticles);


        /// <summary>
        ///   System.Void AddSceneChangeStatus(SceneChangeStatus newStatus)
        /// </summary>
        /// <param name="newStatus">enum SceneChangeStatus</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneChangeStatus")]
        ///  extern void ADD_SCENE_CHANGE_STATUS (SceneChangeStatus newStatus);


        /// <summary>
        ///   System.Void AddSceneCommand(SceneCommand newCommandType, SceneData newSceneData, System.Action newOnOperationCompletedCallback)
        /// </summary>
        /// <param name="newCommandType">enum SceneCommand</param>
        /// <param name="newSceneData">class SceneData</param>
        /// <param name="newOnOperationCompletedCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneCommand")]
        ///  extern void ADD_SCENE_COMMAND (SceneCommand newCommandType, nint newSceneData, nint newOnOperationCompletedCallback);


        /// <summary>
        ///   System.Void AddSceneManagementServiceOwner(Sigtrap.Relays.Relay newAllLoadingCompleted, Sigtrap.Relays.Relay newAllUnloadingCompleted)
        /// </summary>
        /// <param name="newAllLoadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <param name="newAllUnloadingCompleted">class Sigtrap.Relays.Relay</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneManagementServiceOwner")]
        ///  extern void ADD_SCENE_MANAGEMENT_SERVICE_OWNER (nint newAllLoadingCompleted, nint newAllUnloadingCompleted);


        /// <summary>
        ///   System.Void AddSceneType(SceneType newValue)
        /// </summary>
        /// <param name="newValue">enum SceneType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneType")]
        ///  extern void ADD_SCENE_TYPE (SceneType newValue);


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
        ///   ChangeSceneCommandComponent get_changeSceneCommand()
        /// </summary>
        /// <returns>class ChangeSceneCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_changeSceneCommand")]
        ///  extern nint GET_CHANGE_SCENE_COMMAND ();


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
        ///   FileSystemComponent get_fileSystem()
        /// </summary>
        /// <returns>class FileSystemComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fileSystem")]
        ///  extern nint GET_FILE_SYSTEM ();


        /// <summary>
        ///   FrameworkDestroyedListenerComponent get_frameworkDestroyedListener()
        /// </summary>
        /// <returns>class FrameworkDestroyedListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_frameworkDestroyedListener")]
        ///  extern nint GET_FRAMEWORK_DESTROYED_LISTENER ();


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
        ///   System.Boolean get_hasFrameworkDestroyedListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasFrameworkDestroyedListener")]
        ///  extern System.Boolean GET_HAS_FRAMEWORK_DESTROYED_LISTENER ();


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
        ///   System.Boolean get_hasSceneChangeStatusListener()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneChangeStatusListener")]
        ///  extern System.Boolean GET_HAS_SCENE_CHANGE_STATUS_LISTENER ();


        /// <summary>
        ///   System.Boolean get_hasSceneCommand()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSceneCommand")]
        ///  extern System.Boolean GET_HAS_SCENE_COMMAND ();


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
        ///   System.Int32 get_retainCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
        ///  extern System.Int32 GET_RETAIN_COUNT ();


        /// <summary>
        ///   SceneChangeStatusComponent get_sceneChangeStatus()
        /// </summary>
        /// <returns>class SceneChangeStatusComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneChangeStatus")]
        ///  extern nint GET_SCENE_CHANGE_STATUS ();


        /// <summary>
        ///   SceneChangeStatusListenerComponent get_sceneChangeStatusListener()
        /// </summary>
        /// <returns>class SceneChangeStatusListenerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneChangeStatusListener")]
        ///  extern nint GET_SCENE_CHANGE_STATUS_LISTENER ();


        /// <summary>
        ///   SceneCommandComponent get_sceneCommand()
        /// </summary>
        /// <returns>class SceneCommandComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneCommand")]
        ///  extern nint GET_SCENE_COMMAND ();


        /// <summary>
        ///   SceneManagementServiceOwner get_sceneManagementServiceOwner()
        /// </summary>
        /// <returns>class SceneManagementServiceOwner</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneManagementServiceOwner")]
        ///  extern nint GET_SCENE_MANAGEMENT_SERVICE_OWNER ();


        /// <summary>
        ///   SceneTypeComponent get_sceneType()
        /// </summary>
        /// <returns>class SceneTypeComponent</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_sceneType", CallConvs = [typeof(CallConvCdecl)])]
        extern SceneTypeComponent.Ptr_SceneTypeComponent GET_SCENE_TYPE();


        /// <summary>
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


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
        ///   System.Void RemoveChangeSceneCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveChangeSceneCommand")]
        ///  extern void REMOVE_CHANGE_SCENE_COMMAND ();


        /// <summary>
        ///   System.Void RemoveComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
        ///  extern void REMOVE_COMPONENT (System.Int32 index);


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
        ///   System.Void RemoveSceneCommand()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneCommand")]
        ///  extern void REMOVE_SCENE_COMMAND ();


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
        ///   System.Void ReplaceFileSystem(Gentlebros.Framework.FileSystem.IFileSystem newValue)
        /// </summary>
        /// <param name="newValue">interface Gentlebros.Framework.FileSystem.IFileSystem</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFileSystem")]
        ///  extern void REPLACE_FILE_SYSTEM (nint newValue);


        /// <summary>
        ///   System.Void ReplaceFrameworkDestroyedListener(System.Collections.Generic.List<IFrameworkDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IFrameworkDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceFrameworkDestroyedListener")]
        ///  extern void REPLACE_FRAMEWORK_DESTROYED_LISTENER (nint newValue);


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
        ///   System.Void ReplaceSceneChangeStatusListener(System.Collections.Generic.List<ISceneChangeStatusListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ISceneChangeStatusListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneChangeStatusListener")]
        ///  extern void REPLACE_SCENE_CHANGE_STATUS_LISTENER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceSceneCommand(SceneCommand newCommandType, SceneData newSceneData, System.Action newOnOperationCompletedCallback)
        /// </summary>
        /// <param name="newCommandType">enum SceneCommand</param>
        /// <param name="newSceneData">class SceneData</param>
        /// <param name="newOnOperationCompletedCallback">class System.Action</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSceneCommand")]
        ///  extern void REPLACE_SCENE_COMMAND (SceneCommand newCommandType, nint newSceneData, nint newOnOperationCompletedCallback);


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
        ///   System.Void Retain(System.Object owner)
        /// </summary>
        /// <param name="owner">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
        ///  extern void RETAIN (nint owner);


        /// <summary>
        ///   System.Void set_isDestroyed(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
        ///  extern void SET_IS_DESTROYED (System.Boolean value);


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
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_FrameworkEntity))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_FrameworkEntity))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void AddFrameworkDestroyedListener(System.Collections.Generic.List<IFrameworkDestroyedListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<IFrameworkDestroyedListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFrameworkDestroyedListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void ADD_FRAMEWORK_DESTROYED_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddFrameworkDestroyedListener(IFrameworkDestroyedListener value)
        /// </summary>
        /// <param name="value">interface IFrameworkDestroyedListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddFrameworkDestroyedListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void ADD_FRAMEWORK_DESTROYED_LISTENER_01 (nint value);


        /// <summary>
        ///   System.Void AddSceneChangeStatusListener(System.Collections.Generic.List<ISceneChangeStatusListener> newValue)
        /// </summary>
        /// <param name="newValue">class System.Collections.Generic.List<ISceneChangeStatusListener></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneChangeStatusListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void ADD_SCENE_CHANGE_STATUS_LISTENER_00 (nint newValue);


        /// <summary>
        ///   System.Void AddSceneChangeStatusListener(ISceneChangeStatusListener value)
        /// </summary>
        /// <param name="value">interface ISceneChangeStatusListener</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSceneChangeStatusListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void ADD_SCENE_CHANGE_STATUS_LISTENER_01 (nint value);


        /// <summary>
        ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>interface Entitas.IComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_FrameworkEntity))]
        ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);


        /// <summary>
        ///   T CreateComponent(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_FrameworkEntity))]
        ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);


        /// <summary>
        ///   System.Void RemoveFrameworkDestroyedListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFrameworkDestroyedListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void REMOVE_FRAMEWORK_DESTROYED_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveFrameworkDestroyedListener(IFrameworkDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface IFrameworkDestroyedListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveFrameworkDestroyedListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void REMOVE_FRAMEWORK_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// <summary>
        ///   System.Void RemoveSceneChangeStatusListener()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneChangeStatusListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void REMOVE_SCENE_CHANGE_STATUS_LISTENER_00 ();


        /// <summary>
        ///   System.Void RemoveSceneChangeStatusListener(ISceneChangeStatusListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// <param name="value">interface ISceneChangeStatusListener</param>
        /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSceneChangeStatusListener", Search = typeof(Search_FrameworkEntity))]
        ///  extern void REMOVE_SCENE_CHANGE_STATUS_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);


        /// public static partial class Search_FrameworkEntity
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
        ///   System.Void AddFrameworkDestroyedListener(System.Collections.Generic.List<IFrameworkDestroyedListener> newValue)
        /// </summary>
        /// public static bool ADD_FRAMEWORK_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddFrameworkDestroyedListener", "System.Collections.Generic.List<IFrameworkDestroyedListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddFrameworkDestroyedListener(IFrameworkDestroyedListener value)
        /// </summary>
        /// public static bool ADD_FRAMEWORK_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddFrameworkDestroyedListener", "IFrameworkDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddSceneChangeStatusListener(System.Collections.Generic.List<ISceneChangeStatusListener> newValue)
        /// </summary>
        /// public static bool ADD_SCENE_CHANGE_STATUS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddSceneChangeStatusListener", "System.Collections.Generic.List<ISceneChangeStatusListener>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void AddSceneChangeStatusListener(ISceneChangeStatusListener value)
        /// </summary>
        /// public static bool ADD_SCENE_CHANGE_STATUS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddSceneChangeStatusListener", "ISceneChangeStatusListener");
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
        ///   System.Void RemoveFrameworkDestroyedListener()
        /// </summary>
        /// public static bool REMOVE_FRAMEWORK_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveFrameworkDestroyedListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveFrameworkDestroyedListener(IFrameworkDestroyedListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_FRAMEWORK_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveFrameworkDestroyedListener", "IFrameworkDestroyedListener", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveSceneChangeStatusListener()
        /// </summary>
        /// public static bool REMOVE_SCENE_CHANGE_STATUS_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveSceneChangeStatusListener");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RemoveSceneChangeStatusListener(ISceneChangeStatusListener value, System.Boolean removeComponentWhenEmpty)
        /// </summary>
        /// public static bool REMOVE_SCENE_CHANGE_STATUS_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveSceneChangeStatusListener", "ISceneChangeStatusListener", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}