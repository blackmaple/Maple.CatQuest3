
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
    /// class ["ProjectStar".""."InputContext"]
    /// [Entitas.Context<InputEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000653U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [73, 110, 112, 117, 116, 67, 111, 110, 116, 101, 120, 116])]


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

    // class 0x24 System.Func<InputEntity> _entityFactory
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityFactory", "_ENTITY_FACTORY")]

    // class 0x28 System.Collections.Generic.HashSet<InputEntity> _entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entities", "_ENTITIES")]

    // class 0x2C System.Collections.Generic.Stack<InputEntity> _reusableEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_reusableEntities", "_REUSABLE_ENTITIES")]

    // class 0x30 System.Collections.Generic.HashSet<InputEntity> _retainedEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_retainedEntities", "_RETAINED_ENTITIES")]

    // class 0x34 System.Collections.Generic.Dictionary<Entitas.IMatcher<InputEntity>,Entitas.IGroup<InputEntity>> _groups
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groups", "_GROUPS")]

    // class 0x38 System.Collections.Generic.List<Entitas.IGroup<InputEntity>>[] _groupsForIndex
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupsForIndex", "_GROUPS_FOR_INDEX")]

    // class 0x3C DesperateDevs.Caching.ObjectPool<System.Collections.Generic.List<Entitas.GroupChanged<InputEntity>>> _groupChangedListPool
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_groupChangedListPool", "_GROUP_CHANGED_LIST_POOL")]

    // class 0x40 System.Collections.Generic.Dictionary<System.String,Entitas.IEntityIndex> _entityIndices
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entityIndices", "_ENTITY_INDICES")]

    // class 0x44 InputEntity[] _entitiesCache
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
    public partial class InputContext
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "InputContext";
        //public static byte[] Static_ClassName { get; } = [73, 110, 112, 117, 116, 67, 111, 110, 116, 101, 120, 116];

        //public const uint Const_TypeToken = 0x02000653U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InputContext(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InputContext(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InputContext obj) => obj._ptr;
            public static implicit operator bool(Ptr_InputContext obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."InputContext"]
    /// </summary>
    public partial class InputContext
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
        ///   InputEntity CreateEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateEntity")]
        ///  extern nint CREATE_ENTITY ();


        /// <summary>
        ///   System.Void DestroyAllEntities()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyAllEntities")]
        ///  extern void DESTROY_ALL_ENTITIES ();


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
        ///   CursorComponent get_cursor()
        /// </summary>
        /// <returns>class CursorComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cursor")]
        ///  extern nint GET_CURSOR ();


        /// <summary>
        ///   InputEntity get_cursorEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cursorEntity")]
        ///  extern nint GET_CURSOR_ENTITY ();


        /// <summary>
        ///   System.Boolean get_hasCursor()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCursor")]
        ///  extern System.Boolean GET_HAS_CURSOR ();


        /// <summary>
        ///   System.Boolean get_hasInputStack()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputStack")]
        ///  extern System.Boolean GET_HAS_INPUT_STACK ();


        /// <summary>
        ///   System.Boolean get_hasInputStackLastUpdatedTimer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputStackLastUpdatedTimer")]
        ///  extern System.Boolean GET_HAS_INPUT_STACK_LAST_UPDATED_TIMER ();


        /// <summary>
        ///   System.Boolean get_hasInputStackUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputStackUpdatedEvent")]
        ///  extern System.Boolean GET_HAS_INPUT_STACK_UPDATED_EVENT ();


        /// <summary>
        ///   System.Boolean get_hasInputSystemType()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputSystemType")]
        ///  extern System.Boolean GET_HAS_INPUT_SYSTEM_TYPE ();


        /// <summary>
        ///   System.Boolean get_hasInputVibrationContainer()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputVibrationContainer")]
        ///  extern System.Boolean GET_HAS_INPUT_VIBRATION_CONTAINER ();


        /// <summary>
        ///   System.Boolean get_hasInputVibrationSensitivity()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasInputVibrationSensitivity")]
        ///  extern System.Boolean GET_HAS_INPUT_VIBRATION_SENSITIVITY ();


        /// <summary>
        ///   InputStackComponent get_inputStack()
        /// </summary>
        /// <returns>class InputStackComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStack")]
        ///  extern nint GET_INPUT_STACK ();


        /// <summary>
        ///   InputEntity get_inputStackEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStackEntity")]
        ///  extern nint GET_INPUT_STACK_ENTITY ();


        /// <summary>
        ///   InputStackLastUpdatedTimerComponent get_inputStackLastUpdatedTimer()
        /// </summary>
        /// <returns>class InputStackLastUpdatedTimerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStackLastUpdatedTimer")]
        ///  extern nint GET_INPUT_STACK_LAST_UPDATED_TIMER ();


        /// <summary>
        ///   InputEntity get_inputStackLastUpdatedTimerEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStackLastUpdatedTimerEntity")]
        ///  extern nint GET_INPUT_STACK_LAST_UPDATED_TIMER_ENTITY ();


        /// <summary>
        ///   InputStackUpdatedEventComponent get_inputStackUpdatedEvent()
        /// </summary>
        /// <returns>class InputStackUpdatedEventComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStackUpdatedEvent")]
        ///  extern nint GET_INPUT_STACK_UPDATED_EVENT ();


        /// <summary>
        ///   InputEntity get_inputStackUpdatedEventEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputStackUpdatedEventEntity")]
        ///  extern nint GET_INPUT_STACK_UPDATED_EVENT_ENTITY ();


        /// <summary>
        ///   InputSystemTypeComponent get_inputSystemType()
        /// </summary>
        /// <returns>class InputSystemTypeComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputSystemType")]
        ///  extern nint GET_INPUT_SYSTEM_TYPE ();


        /// <summary>
        ///   InputEntity get_inputSystemTypeEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputSystemTypeEntity")]
        ///  extern nint GET_INPUT_SYSTEM_TYPE_ENTITY ();


        /// <summary>
        ///   InputVibrationContainerComponent get_inputVibrationContainer()
        /// </summary>
        /// <returns>class InputVibrationContainerComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputVibrationContainer")]
        ///  extern nint GET_INPUT_VIBRATION_CONTAINER ();


        /// <summary>
        ///   InputEntity get_inputVibrationContainerEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputVibrationContainerEntity")]
        ///  extern nint GET_INPUT_VIBRATION_CONTAINER_ENTITY ();


        /// <summary>
        ///   InputVibrationSensitivityComponent get_inputVibrationSensitivity()
        /// </summary>
        /// <returns>class InputVibrationSensitivityComponent</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputVibrationSensitivity")]
        ///  extern nint GET_INPUT_VIBRATION_SENSITIVITY ();


        /// <summary>
        ///   InputEntity get_inputVibrationSensitivityEntity()
        /// </summary>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_inputVibrationSensitivityEntity")]
        ///  extern nint GET_INPUT_VIBRATION_SENSITIVITY_ENTITY ();


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
        ///   System.Int32 get_totalComponents()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
        ///  extern System.Int32 GET_TOTAL_COMPONENTS ();


        /// <summary>
        ///   InputEntity[] GetEntities()
        /// </summary>
        /// <returns>class InputEntity[]</returns>
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
        ///   Entitas.IGroup<InputEntity> GetGroup(Entitas.IMatcher<InputEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<InputEntity></param>
        /// <returns>interface Entitas.IGroup<InputEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroup")]
        ///  extern nint GET_GROUP (nint matcher);


        /// <summary>
        ///   System.Boolean HasEntity(InputEntity entity)
        /// </summary>
        /// <param name="entity">class InputEntity</param>
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
        ///   System.Void RemoveCursor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCursor")]
        ///  extern void REMOVE_CURSOR ();


        /// <summary>
        ///   System.Void RemoveInputStack()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputStack")]
        ///  extern void REMOVE_INPUT_STACK ();


        /// <summary>
        ///   System.Void RemoveInputStackLastUpdatedTimer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputStackLastUpdatedTimer")]
        ///  extern void REMOVE_INPUT_STACK_LAST_UPDATED_TIMER ();


        /// <summary>
        ///   System.Void RemoveInputStackUpdatedEvent()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputStackUpdatedEvent")]
        ///  extern void REMOVE_INPUT_STACK_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void RemoveInputSystemType()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputSystemType")]
        ///  extern void REMOVE_INPUT_SYSTEM_TYPE ();


        /// <summary>
        ///   System.Void RemoveInputVibrationContainer()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputVibrationContainer")]
        ///  extern void REMOVE_INPUT_VIBRATION_CONTAINER ();


        /// <summary>
        ///   System.Void RemoveInputVibrationSensitivity()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveInputVibrationSensitivity")]
        ///  extern void REMOVE_INPUT_VIBRATION_SENSITIVITY ();


        /// <summary>
        ///   System.Void ReplaceCursor(System.Boolean newEnabled)
        /// </summary>
        /// <param name="newEnabled">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCursor")]
        ///  extern void REPLACE_CURSOR (System.Boolean newEnabled);


        /// <summary>
        ///   System.Void ReplaceInputStack(InputStack newValue)
        /// </summary>
        /// <param name="newValue">class InputStack</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputStack")]
        ///  extern void REPLACE_INPUT_STACK (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInputStackLastUpdatedTimer(System.Single newTimeOfLastUpdate, System.Int32 newFramesSinceLastUpdate)
        /// </summary>
        /// <param name="newTimeOfLastUpdate">struct System.Single</param>
        /// <param name="newFramesSinceLastUpdate">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputStackLastUpdatedTimer")]
        ///  extern void REPLACE_INPUT_STACK_LAST_UPDATED_TIMER (System.Single newTimeOfLastUpdate, System.Int32 newFramesSinceLastUpdate);


        /// <summary>
        ///   System.Void ReplaceInputStackUpdatedEvent(InputState newPrev, InputState newCurr)
        /// </summary>
        /// <param name="newPrev">enum InputState</param>
        /// <param name="newCurr">enum InputState</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputStackUpdatedEvent")]
        ///  extern void REPLACE_INPUT_STACK_UPDATED_EVENT (InputState newPrev, InputState newCurr);


        /// <summary>
        ///   System.Void ReplaceInputSystemType(InputSystemType newValue)
        /// </summary>
        /// <param name="newValue">enum InputSystemType</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputSystemType")]
        ///  extern void REPLACE_INPUT_SYSTEM_TYPE (InputSystemType newValue);


        /// <summary>
        ///   System.Void ReplaceInputVibrationContainer(InputVibrationContainer newValue)
        /// </summary>
        /// <param name="newValue">class InputVibrationContainer</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputVibrationContainer")]
        ///  extern void REPLACE_INPUT_VIBRATION_CONTAINER (nint newValue);


        /// <summary>
        ///   System.Void ReplaceInputVibrationSensitivity(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceInputVibrationSensitivity")]
        ///  extern void REPLACE_INPUT_VIBRATION_SENSITIVITY (System.Single newValue);


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
        ///   InputEntity SetCursor(System.Boolean newEnabled)
        /// </summary>
        /// <param name="newEnabled">struct System.Boolean</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetCursor")]
        ///  extern nint SET_CURSOR (System.Boolean newEnabled);


        /// <summary>
        ///   InputEntity SetInputStack(InputStack newValue)
        /// </summary>
        /// <param name="newValue">class InputStack</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputStack")]
        ///  extern nint SET_INPUT_STACK (nint newValue);


        /// <summary>
        ///   InputEntity SetInputStackLastUpdatedTimer(System.Single newTimeOfLastUpdate, System.Int32 newFramesSinceLastUpdate)
        /// </summary>
        /// <param name="newTimeOfLastUpdate">struct System.Single</param>
        /// <param name="newFramesSinceLastUpdate">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputStackLastUpdatedTimer")]
        ///  extern nint SET_INPUT_STACK_LAST_UPDATED_TIMER (System.Single newTimeOfLastUpdate, System.Int32 newFramesSinceLastUpdate);


        /// <summary>
        ///   InputEntity SetInputStackUpdatedEvent(InputState newPrev, InputState newCurr)
        /// </summary>
        /// <param name="newPrev">enum InputState</param>
        /// <param name="newCurr">enum InputState</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputStackUpdatedEvent")]
        ///  extern nint SET_INPUT_STACK_UPDATED_EVENT (InputState newPrev, InputState newCurr);


        /// <summary>
        ///   InputEntity SetInputSystemType(InputSystemType newValue)
        /// </summary>
        /// <param name="newValue">enum InputSystemType</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputSystemType")]
        ///  extern nint SET_INPUT_SYSTEM_TYPE (InputSystemType newValue);


        /// <summary>
        ///   InputEntity SetInputVibrationContainer(InputVibrationContainer newValue)
        /// </summary>
        /// <param name="newValue">class InputVibrationContainer</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputVibrationContainer")]
        ///  extern nint SET_INPUT_VIBRATION_CONTAINER (nint newValue);


        /// <summary>
        ///   InputEntity SetInputVibrationSensitivity(System.Single newValue)
        /// </summary>
        /// <param name="newValue">struct System.Single</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInputVibrationSensitivity")]
        ///  extern nint SET_INPUT_VIBRATION_SENSITIVITY (System.Single newValue);


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
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_InputContext))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<InputEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="entityFactory">class System.Func<InputEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_InputContext))]
        ///  extern void .CTOR_01 (System.Int32 totalComponents, nint entityFactory);


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<InputEntity> entityFactory)
        /// </summary>
        /// <param name="totalComponents">struct System.Int32</param>
        /// <param name="startCreationIndex">struct System.Int32</param>
        /// <param name="contextInfo">class Entitas.ContextInfo</param>
        /// <param name="aercFactory">class System.Func<Entitas.IEntity,Entitas.IAERC></param>
        /// <param name="entityFactory">class System.Func<InputEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_InputContext))]
        ///  extern void .CTOR_02 (System.Int32 totalComponents, System.Int32 startCreationIndex, nint contextInfo, nint aercFactory, nint entityFactory);


        /// public static partial class Search_InputContext
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
        ///   System.Void .ctor(System.Int32 totalComponents, System.Func<InputEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Func<InputEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(System.Int32 totalComponents, System.Int32 startCreationIndex, Entitas.ContextInfo contextInfo, System.Func<Entitas.IEntity,Entitas.IAERC> aercFactory, System.Func<InputEntity> entityFactory)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "Entitas.ContextInfo", "System.Func<Entitas.IEntity,Entitas.IAERC>", "System.Func<InputEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}