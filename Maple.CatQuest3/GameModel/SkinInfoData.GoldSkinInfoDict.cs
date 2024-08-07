
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
    /// class ["ProjectStar".""."GoldSkinInfoDict"]
    /// [UnitySerializedDictionary<ZoneType,GoldSkinInfo>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000AE9U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 111, 108, 100, 83, 107, 105, 110, 73, 110, 102, 111, 68, 105, 99, 116])]
    
                
    // class 0x8 System.Collections.Generic.List<ZoneType> keyData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"keyData", "KEY_DATA")]
            
    // class 0xC System.Collections.Generic.List<GoldSkinInfo> valueData
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"valueData", "VALUE_DATA")]
            
    // class 0x10 System.Collections.Generic.Dictionary<ZoneType,GoldSkinInfo> _dict
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_dict", "_DICT")]
    public partial class GoldSkinInfoDict
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GoldSkinInfoDict";
        //public static byte[] Static_ClassName { get; } = [71, 111, 108, 100, 83, 107, 105, 110, 73, 110, 102, 111, 68, 105, 99, 116];

        //public const uint Const_TypeToken = 0x02000AE9U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GoldSkinInfoDict(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GoldSkinInfoDict(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GoldSkinInfoDict obj) => obj._ptr;
            public static implicit operator bool(Ptr_GoldSkinInfoDict obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."GoldSkinInfoDict"]
        /// </summary>
        public partial class GoldSkinInfoDict
        { 

            
            
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
            ///  extern void CLEAR ();

            
            /// <summary>
            ///   System.Boolean Contains(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item)
            /// </summary>
            /// <param name="item">struct System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo></param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains")]
            ///  extern System.Boolean CONTAINS (System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item);

            
            /// <summary>
            ///   System.Boolean ContainsKey(ZoneType key)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsKey")]
            ///  extern System.Boolean CONTAINS_KEY (ZoneType key);

            
            /// <summary>
            ///   System.Void CopyTo(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>[] array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name="array">class System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>[]</param>
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
            ///   GoldSkinInfo get_Item(ZoneType key)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <returns>class GoldSkinInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item")]
            ///  extern nint GET_ITEM (ZoneType key);

            
            /// <summary>
            ///   System.Collections.Generic.ICollection<ZoneType> get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<ZoneType></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Keys")]
            ///  extern nint GET_KEYS ();

            
            /// <summary>
            ///   System.Collections.Generic.ICollection<GoldSkinInfo> get_Values()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<GoldSkinInfo></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Values")]
            ///  extern nint GET_VALUES ();

            
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>> GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
            ///  extern nint GET_ENUMERATOR ();

            
            /// <summary>
            ///   System.Void set_Item(ZoneType key, GoldSkinInfo value)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <param name="value">class GoldSkinInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
            ///  extern void SET_ITEM (ZoneType key, nint value);

            
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IEnumerable.GetEnumerator")]
            ///  extern nint SYSTEM.COLLECTIONS.I_ENUMERABLE.GET_ENUMERATOR ();

            
            /// <summary>
            ///   System.Boolean TryGetValue(ZoneType key, GoldSkinInfo& value)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <param name="value">class GoldSkinInfo&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue")]
            ///  extern System.Boolean TRY_GET_VALUE (ZoneType key, nint value);

            
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
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void Add(ZoneType key, GoldSkinInfo value)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <param name="value">class GoldSkinInfo</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern void ADD_00 (ZoneType key, nint value);

            
            /// <summary>
            ///   System.Void Add(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item)
            /// </summary>
            /// <param name="item">struct System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern void ADD_01 (System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item);

            
            /// <summary>
            ///   System.Boolean Remove(ZoneType key)
            /// </summary>
            /// <param name="key">enum ZoneType</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern System.Boolean REMOVE_00 (ZoneType key);

            
            /// <summary>
            ///   System.Boolean Remove(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item)
            /// </summary>
            /// <param name="item">struct System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo></param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_GoldSkinInfoDict))]
            ///  extern System.Boolean REMOVE_01 (System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item);

            
            /// public static partial class Search_GoldSkinInfoDict
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
                    ///   System.Void Add(ZoneType key, GoldSkinInfo value)
                    /// </summary>
                    /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "ZoneType", "GoldSkinInfo");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void Add(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item)
                    /// </summary>
                    /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Remove(ZoneType key)
                    /// </summary>
                    /// public static bool REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "ZoneType");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Remove(System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo> item)
                    /// </summary>
                    /// public static bool REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "System.Collections.Generic.KeyValuePair<ZoneType,GoldSkinInfo>");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}