using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3.GameModel.Data
{

    /// <summary>
    /// class ["ProjectStar".""."ContentDict"]
    /// [UnitySerializedDictionary<System.String,ProjectStar.Data.EquipmentItemData>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000CC5U)]
   // [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [67, 111, 110, 116, 101, 110, 116, 68, 105, 99, 116])]


    // class 0x8 System.Collections.Generic.List<System.String> keyData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"keyData", "KEY_DATA")]

    // class 0xC System.Collections.Generic.List<ProjectStar.Data.EquipmentItemData> valueData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"valueData", "VALUE_DATA")]

    // class 0x10 System.Collections.Generic.Dictionary<System.String,ProjectStar.Data.EquipmentItemData> _dict
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_dict", "_DICT")]
    public partial class EquipmentDatabaseContentDict
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ContentDict";
        //public static byte[] Static_ClassName { get; } = [67, 111, 110, 116, 101, 110, 116, 68, 105, 99, 116];

        //public const uint Const_TypeToken = 0x02000CC5U;



        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit)]
        public readonly unsafe partial struct Ref_ContentDict
        {
            [FieldOffset(0)]
            public readonly REF_MONO_OBJECT _obj;

            [FieldOffset(0x8)]
            public readonly PMonoList_x86<PMonoString> keyData;

            [FieldOffset(0xC)]
            public readonly PMonoList_x86<EquipmentItemData.Ptr_EquipmentItemData> valueData;

            [FieldOffset(0x10)]
            public readonly PMonoDictionary_x86<PMonoString,EquipmentItemData.Ptr_EquipmentItemData> _dict;

        }




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ContentDict(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ContentDict(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ContentDict obj) => obj._ptr;
            public static implicit operator bool(Ptr_ContentDict obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;

            public ref Ref_ContentDict AsRef()
                => ref _ptr.AsRefStruct<Ref_ContentDict>();


        }



    }

    /// <summary>
    /// ["ProjectStar".""."ContentDict"]
    /// </summary>
    public partial class EquipmentDatabaseContentDict
    {



        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
        ///  extern void CLEAR ();


        /// <summary>
        ///   System.Boolean Contains(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains")]
        ///  extern System.Boolean CONTAINS (System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item);


        /// <summary>
        ///   System.Boolean ContainsKey(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsKey")]
        ///  extern System.Boolean CONTAINS_KEY (nint key);


        /// <summary>
        ///   System.Void CopyTo(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>[] array, System.Int32 arrayIndex)
        /// </summary>
        /// <param name="array">class System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>[]</param>
        /// <param name="arrayIndex">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyTo")]
        ///  extern void COPY_TO (nint array, System.Int32 arrayIndex);


        /// <summary>
        ///   System.Int32 get_Count()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Count")]
        ///  extern System.Int32 GET_COUNT ();


        /// <summary>
        ///   System.Boolean get_IsReadOnly()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_IsReadOnly")]
        ///  extern System.Boolean GET_IS_READ_ONLY ();


        /// <summary>
        ///   ProjectStar.Data.EquipmentItemData get_Item(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>class ProjectStar.Data.EquipmentItemData</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
        ///  extern nint GET_ITEM (nint key);


        /// <summary>
        ///   System.Collections.Generic.ICollection<System.String> get_Keys()
        /// </summary>
        /// <returns>interface System.Collections.Generic.ICollection<System.String></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Keys")]
        ///  extern nint GET_KEYS ();


        /// <summary>
        ///   System.Collections.Generic.ICollection<ProjectStar.Data.EquipmentItemData> get_Values()
        /// </summary>
        /// <returns>interface System.Collections.Generic.ICollection<ProjectStar.Data.EquipmentItemData></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Values")]
        ///  extern nint GET_VALUES ();


        /// <summary>
        ///   System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>> GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
        ///  extern nint GET_ENUMERATOR ();


        /// <summary>
        ///   System.Void set_Item(System.String key, ProjectStar.Data.EquipmentItemData value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">class ProjectStar.Data.EquipmentItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
        ///  extern void SET_ITEM (nint key, nint value);


        /// <summary>
        ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IEnumerable.GetEnumerator")]
        ///  extern nint SYSTEM.COLLECTIONS.I_ENUMERABLE.GET_ENUMERATOR ();


        /// <summary>
        ///   System.Boolean TryGetValue(System.String key, ProjectStar.Data.EquipmentItemData& value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">class ProjectStar.Data.EquipmentItemData&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue")]
        ///  extern System.Boolean TRY_GET_VALUE (nint key, nint value);


        /// <summary>
        ///   System.Void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
        ///  extern void UNITY_ENGINE.I_SERIALIZATION_CALLBACK_RECEIVER.ON_AFTER_DESERIALIZE ();


        /// <summary>
        ///   System.Void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize")]
        ///  extern void UNITY_ENGINE.I_SERIALIZATION_CALLBACK_RECEIVER.ON_BEFORE_SERIALIZE ();



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ContentDict))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ContentDict))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void Add(System.String key, ProjectStar.Data.EquipmentItemData value)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <param name="value">class ProjectStar.Data.EquipmentItemData</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_ContentDict))]
        ///  extern void ADD_00 (nint key, nint value);


        /// <summary>
        ///   System.Void Add(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_ContentDict))]
        ///  extern void ADD_01 (System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item);


        /// <summary>
        ///   System.Boolean Remove(System.String key)
        /// </summary>
        /// <param name="key">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_ContentDict))]
        ///  extern System.Boolean REMOVE_00 (nint key);


        /// <summary>
        ///   System.Boolean Remove(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item)
        /// </summary>
        /// <param name="item">struct System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData></param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_ContentDict))]
        ///  extern System.Boolean REMOVE_01 (System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item);


        /// public static partial class Search_ContentDict
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
        ///   System.Void Add(System.String key, ProjectStar.Data.EquipmentItemData value)
        /// </summary>
        /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.String", "ProjectStar.Data.EquipmentItemData");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Add(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item)
        /// </summary>
        /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Remove(System.String key)
        /// </summary>
        /// public static bool REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Remove(System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData> item)
        /// </summary>
        /// public static bool REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "System.Collections.Generic.KeyValuePair<System.String,ProjectStar.Data.EquipmentItemData>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

}
