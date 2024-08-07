
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
    /// class ["Entitas"."Entitas"."Group`1"]
    /// [System.Object]
    /// [Entitas.IGroup<TEntity>]=>[Entitas.IGroup]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([69, 110, 116, 105, 116, 97, 115], 0x02000030U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([69, 110, 116, 105, 116, 97, 115], [69, 110, 116, 105, 116, 97, 115], [71, 114, 111, 117, 112, 96, 49])]


    // class 0x8 Entitas.GroupChanged<TEntity> OnEntityAdded
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityAdded", "ON_ENTITY_ADDED")]

    // class 0xC Entitas.GroupChanged<TEntity> OnEntityRemoved
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityRemoved", "ON_ENTITY_REMOVED")]

    // class 0x10 Entitas.GroupUpdated<TEntity> OnEntityUpdated
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityUpdated", "ON_ENTITY_UPDATED")]

    // interface 0x14 Entitas.IMatcher<TEntity> _matcher
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_matcher", "_MATCHER")]

    // class 0x18 System.Collections.Generic.HashSet<TEntity> _entities
    [MonoCollectorSearchFieldAttribute(typeof(PMonoHashSet_x86<GameEntity.Ptr_GameEntity>), "_entities", "GameEntity")]
    [MonoCollectorSearchFieldAttribute(typeof(PMonoHashSet_x86<GUIEntity.Ptr_GUIEntity>), "_entities", "GUIEntity")]

    // class 0x1C TEntity[] _entitiesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_entitiesCache", "_ENTITIES_CACHE")]

    // class 0x20 TEntity _singleEntityCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_singleEntityCache", "_SINGLE_ENTITY_CACHE")]

    // class 0x24 System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]
    public partial class GroupGeneric
    {
        //public const string Const_ImageName = "Entitas";
        //public static byte[] Static_ImageName { get; } = [69, 110, 116, 105, 116, 97, 115];

        //public const string Const_Namespace = "Entitas";
        //public static byte[] Static_Namespace { get; } = [69, 110, 116, 105, 116, 97, 115];

        //public const string Const_ClassName = "Group`1";
        //public static byte[] Static_ClassName { get; } = [71, 114, 111, 117, 112, 96, 49];

        //public const uint Const_TypeToken = 0x02000030U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GroupGeneric(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GroupGeneric(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GroupGeneric obj) => obj._ptr;
            public static implicit operator bool(Ptr_GroupGeneric obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["Entitas"."Entitas"."Group`1"]
    /// </summary>
    public partial class GroupGeneric
    {



        /// <summary>
        ///   System.Void .ctor(Entitas.IMatcher<TEntity> matcher)
        /// </summary>
        /// <param name="matcher">interface Entitas.IMatcher<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint matcher);


        /// <summary>
        ///   System.Void add_OnEntityAdded(Entitas.GroupChanged<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupChanged<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityAdded")]
        ///  extern void ADD_ON_ENTITY_ADDED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityRemoved(Entitas.GroupChanged<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupChanged<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityRemoved")]
        ///  extern void ADD_ON_ENTITY_REMOVED (nint value);


        /// <summary>
        ///   System.Void add_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupUpdated<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityUpdated")]
        ///  extern void ADD_ON_ENTITY_UPDATED (nint value);


        /// <summary>
        ///   System.Void addEntity(TEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("addEntity")]
        ///  extern void ADD_ENTITY (nint entity, System.Int32 index, nint component);


        /// <summary>
        ///   System.Boolean addEntitySilently(TEntity entity)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("addEntitySilently")]
        ///  extern System.Boolean ADD_ENTITY_SILENTLY (nint entity);


        /// <summary>
        ///   System.Collections.Generic.IEnumerable<TEntity> AsEnumerable()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerable<TEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AsEnumerable")]
        ///  extern nint AS_ENUMERABLE ();


        /// <summary>
        ///   System.Boolean ContainsEntity(TEntity entity)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsEntity")]
        ///  extern System.Boolean CONTAINS_ENTITY (nint entity);


        /// <summary>
        ///   System.Int32 get_count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   Entitas.IMatcher<TEntity> get_matcher()
        /// </summary>
        /// <returns>interface Entitas.IMatcher<TEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_matcher")]
        ///  extern nint GET_MATCHER ();


        /// <summary>
        ///   System.Collections.Generic.HashSet.Enumerator<TEntity> GetEnumerator()
        /// </summary>
        /// <returns>struct System.Collections.Generic.HashSet.Enumerator<TEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
        ///  extern System.Collections.Generic.HashSet.Enumerator<TEntity> GET_ENUMERATOR ();


        /// <summary>
        ///   TEntity GetSingleEntity()
        /// </summary>
        /// <returns>class TEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSingleEntity")]
        ///  extern nint GET_SINGLE_ENTITY ();


        /// <summary>
        ///   System.Void HandleEntitySilently(TEntity entity)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HandleEntitySilently")]
        ///  extern void HANDLE_ENTITY_SILENTLY (nint entity);


        /// <summary>
        ///   System.Void remove_OnEntityAdded(Entitas.GroupChanged<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupChanged<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityAdded")]
        ///  extern void REMOVE_ON_ENTITY_ADDED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityRemoved(Entitas.GroupChanged<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupChanged<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityRemoved")]
        ///  extern void REMOVE_ON_ENTITY_REMOVED (nint value);


        /// <summary>
        ///   System.Void remove_OnEntityUpdated(Entitas.GroupUpdated<TEntity> value)
        /// </summary>
        /// <param name="value">class Entitas.GroupUpdated<TEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityUpdated")]
        ///  extern void REMOVE_ON_ENTITY_UPDATED (nint value);


        /// <summary>
        ///   System.Void RemoveAllEventHandlers()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllEventHandlers")]
        ///  extern void REMOVE_ALL_EVENT_HANDLERS ();


        /// <summary>
        ///   System.Void removeEntity(TEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("removeEntity")]
        ///  extern void REMOVE_ENTITY (nint entity, System.Int32 index, nint component);


        /// <summary>
        ///   System.Boolean removeEntitySilently(TEntity entity)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("removeEntitySilently")]
        ///  extern System.Boolean REMOVE_ENTITY_SILENTLY (nint entity);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", CallConvs = [typeof(CallConvCdecl)])]
        extern PMonoString TO_STRING();


        /// <summary>
        ///   System.Void UpdateEntity(TEntity entity, System.Int32 index, Entitas.IComponent previousComponent, Entitas.IComponent newComponent)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="previousComponent">interface Entitas.IComponent</param>
        /// <param name="newComponent">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UpdateEntity")]
        ///  extern void UPDATE_ENTITY (nint entity, System.Int32 index, nint previousComponent, nint newComponent);



        /// <summary>
        ///   TEntity[] GetEntities()
        /// </summary>
        /// <returns>class TEntity[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntities", Search = typeof(Search_GroupGeneric))]
        ///  extern nint GET_ENTITIES_00 ();


        /// <summary>
        ///   System.Collections.Generic.List<TEntity> GetEntities(System.Collections.Generic.List<TEntity> buffer)
        /// </summary>
        /// <param name="buffer">class System.Collections.Generic.List<TEntity></param>
        /// <returns>class System.Collections.Generic.List<TEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEntities", Search = typeof(Search_GroupGeneric))]
        ///  extern nint GET_ENTITIES_01 (nint buffer);


        /// <summary>
        ///   System.Void HandleEntity(TEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <param name="index">struct System.Int32</param>
        /// <param name="component">interface Entitas.IComponent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HandleEntity", Search = typeof(Search_GroupGeneric))]
        ///  extern void HANDLE_ENTITY_00 (nint entity, System.Int32 index, nint component);


        /// <summary>
        ///   Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity)
        /// </summary>
        /// <param name="entity">class TEntity</param>
        /// <returns>class Entitas.GroupChanged<TEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HandleEntity", Search = typeof(Search_GroupGeneric))]
        ///  extern nint HANDLE_ENTITY_01 (nint entity);


        /// public static partial class Search_GroupGeneric
        /// {
        /// 
        ///     

        /// <summary>
        ///   TEntity[] GetEntities()
        /// </summary>
        /// public static bool GET_ENTITIES_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntities");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Collections.Generic.List<TEntity> GetEntities(System.Collections.Generic.List<TEntity> buffer)
        /// </summary>
        /// public static bool GET_ENTITIES_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetEntities", "System.Collections.Generic.List<TEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void HandleEntity(TEntity entity, System.Int32 index, Entitas.IComponent component)
        /// </summary>
        /// public static bool HANDLE_ENTITY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HandleEntity", "TEntity", "System.Int32", "Entitas.IComponent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Entitas.GroupChanged<TEntity> HandleEntity(TEntity entity)
        /// </summary>
        /// public static bool HANDLE_ENTITY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "HandleEntity", "TEntity");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}