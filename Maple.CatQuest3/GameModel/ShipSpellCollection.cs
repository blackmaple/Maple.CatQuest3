
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
    /// class ["ProjectStar".""."ShipSpellCollection"]
    /// [System.Collections.ObjectModel.KeyedCollection<System.String,ShipSpell>]=>[System.Collections.ObjectModel.Collection<ShipSpell>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200039EU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [83, 104, 105, 112, 83, 112, 101, 108, 108, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110])]
    
                
    // interface 0x8 System.Collections.Generic.IList<ShipSpell> items
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"items", "ITEMS")]
            
    // interface 0xC System.Collections.Generic.IEqualityComparer<System.String> comparer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"comparer", "COMPARER")]
            
    // class 0x10 System.Collections.Generic.Dictionary<System.String,ShipSpell> dict
      [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_x86<PMonoString, ShipSpell.Ptr_ShipSpell>),"dict", "DICT")]
            
    // struct 0x14 System.Int32 keyCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"keyCount", "KEY_COUNT")]
            
    // struct 0x18 System.Int32 threshold
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"threshold", "THRESHOLD")]
    public partial class ShipSpellCollection
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ShipSpellCollection";
        //public static byte[] Static_ClassName { get; } = [83, 104, 105, 112, 83, 112, 101, 108, 108, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x0200039EU;



                    
        /// <summary>
        /// struct System.Int32 defaultThreshold "0"
        /// </summary>
        /// public const System.Int32 DEFAULT_THRESHOLD=>"0";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ShipSpellCollection(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ShipSpellCollection(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ShipSpellCollection obj) => obj._ptr;
            public static implicit operator bool(Ptr_ShipSpellCollection obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."ShipSpellCollection"]
        /// </summary>
        public partial class ShipSpellCollection
        { 

            
            
            /// <summary>
            ///   System.Void Add(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add")]
            ///  extern void ADD (nint item);

            
            /// <summary>
            ///   System.Void AddKey(System.String key, ShipSpell item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKey")]
            ///  extern void ADD_KEY (nint key, nint item);

            
            /// <summary>
            ///   System.Void ChangeItemKey(ShipSpell item, System.String newKey)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <param name="newKey">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ChangeItemKey")]
            ///  extern void CHANGE_ITEM_KEY (nint item, nint newKey);

            
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
            ///  extern void CLEAR ();

            
            /// <summary>
            ///   System.Boolean ContainsItem(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsItem")]
            ///  extern System.Boolean CONTAINS_ITEM (nint item);

            
            /// <summary>
            ///   System.Void CopyTo(ShipSpell[] array, System.Int32 index)
            /// </summary>
            /// <param name="array">class ShipSpell[]</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyTo")]
            ///  extern void COPY_TO (nint array, System.Int32 index);

            
            /// <summary>
            ///   System.Void CreateDictionary()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateDictionary")]
            ///  extern void CREATE_DICTIONARY ();

            
            /// <summary>
            ///   System.Collections.Generic.IEqualityComparer<System.String> get_Comparer()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEqualityComparer<System.String></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Comparer")]
            ///  extern nint GET_COMPARER ();

            
            /// <summary>
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Count")]
            ///  extern System.Int32 GET_COUNT ();

            
            /// <summary>
            ///   System.Collections.Generic.IDictionary<System.String,ShipSpell> get_Dictionary()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IDictionary<System.String,ShipSpell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Dictionary")]
            ///  extern nint GET_DICTIONARY ();

            
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<ShipSpell> GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<ShipSpell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
            ///  extern nint GET_ENUMERATOR ();

            
            /// <summary>
            ///   System.Int32 IndexOf(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf")]
            ///  extern System.Int32 INDEX_OF (nint item);

            
            /// <summary>
            ///   System.Void Insert(System.Int32 index, ShipSpell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Insert")]
            ///  extern void INSERT (System.Int32 index, nint item);

            
            /// <summary>
            /// static  System.Boolean IsCompatibleObject(System.Object value)
            /// </summary>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsCompatibleObject")]
            /// static extern System.Boolean IS_COMPATIBLE_OBJECT (nint value);

            
            /// <summary>
            ///   System.Void RemoveAt(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAt")]
            ///  extern void REMOVE_AT (System.Int32 index);

            
            /// <summary>
            ///   System.Void RemoveKey(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveKey")]
            ///  extern void REMOVE_KEY (nint key);

            
            /// <summary>
            ///   System.Void set_Item(System.Int32 index, ShipSpell value)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="value">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_Item")]
            ///  extern void SET_ITEM (System.Int32 index, nint value);

            
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.Generic.ICollection<T>.get_IsReadOnly")]
            ///  extern System.Boolean SYSTEM.COLLECTIONS.GENERIC.I_COLLECTION<T>.GET_IS_READ_ONLY ();

            
            /// <summary>
            ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 index)
            /// </summary>
            /// <param name="array">abstract class System.Array</param>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.CopyTo")]
            ///  extern void SYSTEM.COLLECTIONS.I_COLLECTION.COPY_TO (nint array, System.Int32 index);

            
            /// <summary>
            ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_IsSynchronized")]
            ///  extern System.Boolean SYSTEM.COLLECTIONS.I_COLLECTION.GET_IS_SYNCHRONIZED ();

            
            /// <summary>
            ///   System.Object System.Collections.ICollection.get_SyncRoot()
            /// </summary>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.ICollection.get_SyncRoot")]
            ///  extern nint SYSTEM.COLLECTIONS.I_COLLECTION.GET_SYNC_ROOT ();

            
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IEnumerable.GetEnumerator")]
            ///  extern nint SYSTEM.COLLECTIONS.I_ENUMERABLE.GET_ENUMERATOR ();

            
            /// <summary>
            ///   System.Int32 System.Collections.IList.Add(System.Object value)
            /// </summary>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Add")]
            ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.ADD (nint value);

            
            /// <summary>
            ///   System.Boolean System.Collections.IList.Contains(System.Object value)
            /// </summary>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Contains")]
            ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.CONTAINS (nint value);

            
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsFixedSize")]
            ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_FIXED_SIZE ();

            
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_IsReadOnly")]
            ///  extern System.Boolean SYSTEM.COLLECTIONS.I_LIST.GET_IS_READ_ONLY ();

            
            /// <summary>
            ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>class System.Object</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.get_Item")]
            ///  extern nint SYSTEM.COLLECTIONS.I_LIST.GET_ITEM (System.Int32 index);

            
            /// <summary>
            ///   System.Int32 System.Collections.IList.IndexOf(System.Object value)
            /// </summary>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.IndexOf")]
            ///  extern System.Int32 SYSTEM.COLLECTIONS.I_LIST.INDEX_OF (nint value);

            
            /// <summary>
            ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Insert")]
            ///  extern void SYSTEM.COLLECTIONS.I_LIST.INSERT (System.Int32 index, nint value);

            
            /// <summary>
            ///   System.Void System.Collections.IList.Remove(System.Object value)
            /// </summary>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.Remove")]
            ///  extern void SYSTEM.COLLECTIONS.I_LIST.REMOVE (nint value);

            
            /// <summary>
            ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="value">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("System.Collections.IList.set_Item")]
            ///  extern void SYSTEM.COLLECTIONS.I_LIST.SET_ITEM (System.Int32 index, nint value);
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IList<ShipSpell> list)
            /// </summary>
            /// <param name="list">interface System.Collections.Generic.IList<ShipSpell></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_02 (nint list);

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_03 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer)
            /// </summary>
            /// <param name="comparer">interface System.Collections.Generic.IEqualityComparer<System.String></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_04 (nint comparer);

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer, System.Int32 dictionaryCreationThreshold)
            /// </summary>
            /// <param name="comparer">interface System.Collections.Generic.IEqualityComparer<System.String></param>
            /// <param name="dictionaryCreationThreshold">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void .CTOR_05 (nint comparer, System.Int32 dictionaryCreationThreshold);

            
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearItems", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void CLEAR_ITEMS_00 ();

            
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearItems", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void CLEAR_ITEMS_01 ();

            
            /// <summary>
            ///   System.Boolean Contains(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean CONTAINS_00 (nint item);

            
            /// <summary>
            ///   System.Boolean Contains(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean CONTAINS_01 (nint key);

            
            /// <summary>
            ///   ShipSpell get_Item(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>class ShipSpell</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_ITEM_00 (System.Int32 index);

            
            /// <summary>
            ///   ShipSpell get_Item(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>class ShipSpell</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_ITEM_01 (nint key);

            
            /// <summary>
            ///   System.Collections.Generic.IList<ShipSpell> get_Items()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<ShipSpell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Items", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_ITEMS_00 ();

            
            /// <summary>
            ///   System.Collections.Generic.List<ShipSpell> get_Items()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ShipSpell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Items", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_ITEMS_01 ();

            
            /// <summary>
            ///   System.String GetKeyForItem(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetKeyForItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_KEY_FOR_ITEM_00 (nint item);

            
            /// <summary>
            ///  abstract System.String GetKeyForItem(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetKeyForItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern nint GET_KEY_FOR_ITEM_01 (nint item);

            
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, ShipSpell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void INSERT_ITEM_00 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, ShipSpell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void INSERT_ITEM_01 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Boolean Remove(ShipSpell item)
            /// </summary>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean REMOVE_00 (nint item);

            
            /// <summary>
            ///   System.Boolean Remove(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean REMOVE_01 (nint key);

            
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void REMOVE_ITEM_00 (System.Int32 index);

            
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void REMOVE_ITEM_01 (System.Int32 index);

            
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, ShipSpell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void SET_ITEM_00 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, ShipSpell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class ShipSpell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItem", Search = typeof(Search_ShipSpellCollection))]
            ///  extern void SET_ITEM_01 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Boolean TryGetValue(System.String key, ShipSpell& item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class ShipSpell&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean TRY_GET_VALUE_00 (nint key, nint item);

            
            /// <summary>
            ///   System.Boolean TryGetValue(System.String key, ShipSpell& item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class ShipSpell&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue", Search = typeof(Search_ShipSpellCollection))]
            ///  extern System.Boolean TRY_GET_VALUE_01 (nint key, nint item);

            
            /// public static partial class Search_ShipSpellCollection
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
                    ///   System.Void .ctor(System.Collections.Generic.IList<ShipSpell> list)
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Collections.Generic.IList<ShipSpell>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer)
                    /// </summary>
                    /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Collections.Generic.IEqualityComparer<System.String>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer, System.Int32 dictionaryCreationThreshold)
                    /// </summary>
                    /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Collections.Generic.IEqualityComparer<System.String>", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ClearItems()
                    /// </summary>
                    /// public static bool CLEAR_ITEMS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ClearItems");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ClearItems()
                    /// </summary>
                    /// public static bool CLEAR_ITEMS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ClearItems");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Contains(ShipSpell item)
                    /// </summary>
                    /// public static bool CONTAINS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Contains(System.String key)
                    /// </summary>
                    /// public static bool CONTAINS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   ShipSpell get_Item(System.Int32 index)
                    /// </summary>
                    /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   ShipSpell get_Item(System.String key)
                    /// </summary>
                    /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.Generic.IList<ShipSpell> get_Items()
                    /// </summary>
                    /// public static bool GET_ITEMS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Items");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.Generic.List<ShipSpell> get_Items()
                    /// </summary>
                    /// public static bool GET_ITEMS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Items");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetKeyForItem(ShipSpell item)
                    /// </summary>
                    /// public static bool GET_KEY_FOR_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetKeyForItem", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetKeyForItem(ShipSpell item)
                    /// </summary>
                    /// public static bool GET_KEY_FOR_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetKeyForItem", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void InsertItem(System.Int32 index, ShipSpell item)
                    /// </summary>
                    /// public static bool INSERT_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void InsertItem(System.Int32 index, ShipSpell item)
                    /// </summary>
                    /// public static bool INSERT_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Remove(ShipSpell item)
                    /// </summary>
                    /// public static bool REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Remove(System.String key)
                    /// </summary>
                    /// public static bool REMOVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveItem(System.Int32 index)
                    /// </summary>
                    /// public static bool REMOVE_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveItem", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveItem(System.Int32 index)
                    /// </summary>
                    /// public static bool REMOVE_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveItem", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetItem(System.Int32 index, ShipSpell item)
                    /// </summary>
                    /// public static bool SET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetItem", "System.Int32", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetItem(System.Int32 index, ShipSpell item)
                    /// </summary>
                    /// public static bool SET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetItem", "System.Int32", "ShipSpell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetValue(System.String key, ShipSpell& item)
                    /// </summary>
                    /// public static bool TRY_GET_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetValue", "System.String", "ShipSpell&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetValue(System.String key, ShipSpell& item)
                    /// </summary>
                    /// public static bool TRY_GET_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetValue", "System.String", "ShipSpell&");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}