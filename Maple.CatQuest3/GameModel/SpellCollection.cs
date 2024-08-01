
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
    /// class ["ProjectStar".""."SpellCollection"]
    /// [System.Collections.ObjectModel.KeyedCollection<System.String,Spell>]=>[System.Collections.ObjectModel.Collection<Spell>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020003A0U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [83, 112, 101, 108, 108, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110])]
    
                
    // interface 0x8 System.Collections.Generic.IList<Spell> items
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"items", "ITEMS")]
            
    // interface 0xC System.Collections.Generic.IEqualityComparer<System.String> comparer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"comparer", "COMPARER")]
            
    // class 0x10 System.Collections.Generic.Dictionary<System.String,Spell> dict
      [MonoCollectorSearchFieldAttribute(typeof(PMonoDictionary_x86<PMonoString,Spell.Ptr_Spell>),"dict", "DICT")]
            
    // struct 0x14 System.Int32 keyCount
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"keyCount", "KEY_COUNT")]
            
    // struct 0x18 System.Int32 threshold
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"threshold", "THRESHOLD")]
    public partial class SpellCollection
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "SpellCollection";
        //public static byte[] Static_ClassName { get; } = [83, 112, 101, 108, 108, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x020003A0U;



                    
        /// <summary>
        /// struct System.Int32 defaultThreshold "0"
        /// </summary>
        /// public const System.Int32 DEFAULT_THRESHOLD=>"0";
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_SpellCollection(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_SpellCollection(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_SpellCollection obj) => obj._ptr;
            public static implicit operator bool(Ptr_SpellCollection obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."SpellCollection"]
        /// </summary>
        public partial class SpellCollection
        { 

            
            
            /// <summary>
            ///   System.Void Add(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add")]
            ///  extern void ADD (nint item);

            
            /// <summary>
            ///   System.Void AddKey(System.String key, Spell item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddKey")]
            ///  extern void ADD_KEY (nint key, nint item);

            
            /// <summary>
            ///   System.Void ChangeItemKey(Spell item, System.String newKey)
            /// </summary>
            /// <param name="item">class Spell</param>
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
            ///   System.Boolean ContainsItem(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ContainsItem")]
            ///  extern System.Boolean CONTAINS_ITEM (nint item);

            
            /// <summary>
            ///   System.Void CopyTo(Spell[] array, System.Int32 index)
            /// </summary>
            /// <param name="array">class Spell[]</param>
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
            ///   System.Collections.Generic.IDictionary<System.String,Spell> get_Dictionary()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IDictionary<System.String,Spell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Dictionary")]
            ///  extern nint GET_DICTIONARY ();

            
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<Spell> GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<Spell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
            ///  extern nint GET_ENUMERATOR ();

            
            /// <summary>
            ///   System.Int32 IndexOf(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf")]
            ///  extern System.Int32 INDEX_OF (nint item);

            
            /// <summary>
            ///   System.Void Insert(System.Int32 index, Spell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class Spell</param>
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
            ///   System.Void set_Item(System.Int32 index, Spell value)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="value">class Spell</param>
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
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IList<Spell> list)
            /// </summary>
            /// <param name="list">interface System.Collections.Generic.IList<Spell></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_02 (nint list);

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_03 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer)
            /// </summary>
            /// <param name="comparer">interface System.Collections.Generic.IEqualityComparer<System.String></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_04 (nint comparer);

            
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEqualityComparer<System.String> comparer, System.Int32 dictionaryCreationThreshold)
            /// </summary>
            /// <param name="comparer">interface System.Collections.Generic.IEqualityComparer<System.String></param>
            /// <param name="dictionaryCreationThreshold">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_SpellCollection))]
            ///  extern void .CTOR_05 (nint comparer, System.Int32 dictionaryCreationThreshold);

            
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearItems", Search = typeof(Search_SpellCollection))]
            ///  extern void CLEAR_ITEMS_00 ();

            
            /// <summary>
            ///   System.Void ClearItems()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearItems", Search = typeof(Search_SpellCollection))]
            ///  extern void CLEAR_ITEMS_01 ();

            
            /// <summary>
            ///   System.Boolean Contains(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean CONTAINS_00 (nint item);

            
            /// <summary>
            ///   System.Boolean Contains(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean CONTAINS_01 (nint key);

            
            /// <summary>
            ///   Spell get_Item(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>class Spell</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_ITEM_00 (System.Int32 index);

            
            /// <summary>
            ///   Spell get_Item(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>class Spell</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Item", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_ITEM_01 (nint key);

            
            /// <summary>
            ///   System.Collections.Generic.IList<Spell> get_Items()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<Spell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Items", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_ITEMS_00 ();

            
            /// <summary>
            ///   System.Collections.Generic.List<Spell> get_Items()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Spell></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_Items", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_ITEMS_01 ();

            
            /// <summary>
            ///   System.String GetKeyForItem(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetKeyForItem", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_KEY_FOR_ITEM_00 (nint item);

            
            /// <summary>
            ///  abstract System.String GetKeyForItem(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetKeyForItem", Search = typeof(Search_SpellCollection))]
            ///  extern nint GET_KEY_FOR_ITEM_01 (nint item);

            
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, Spell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_SpellCollection))]
            ///  extern void INSERT_ITEM_00 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Void InsertItem(System.Int32 index, Spell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InsertItem", Search = typeof(Search_SpellCollection))]
            ///  extern void INSERT_ITEM_01 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Boolean Remove(Spell item)
            /// </summary>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean REMOVE_00 (nint item);

            
            /// <summary>
            ///   System.Boolean Remove(System.String key)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean REMOVE_01 (nint key);

            
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem", Search = typeof(Search_SpellCollection))]
            ///  extern void REMOVE_ITEM_00 (System.Int32 index);

            
            /// <summary>
            ///   System.Void RemoveItem(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveItem", Search = typeof(Search_SpellCollection))]
            ///  extern void REMOVE_ITEM_01 (System.Int32 index);

            
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, Spell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItem", Search = typeof(Search_SpellCollection))]
            ///  extern void SET_ITEM_00 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Void SetItem(System.Int32 index, Spell item)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="item">class Spell</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetItem", Search = typeof(Search_SpellCollection))]
            ///  extern void SET_ITEM_01 (System.Int32 index, nint item);

            
            /// <summary>
            ///   System.Boolean TryGetValue(System.String key, Spell& item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class Spell&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean TRY_GET_VALUE_00 (nint key, nint item);

            
            /// <summary>
            ///   System.Boolean TryGetValue(System.String key, Spell& item)
            /// </summary>
            /// <param name="key">class System.String</param>
            /// <param name="item">class Spell&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetValue", Search = typeof(Search_SpellCollection))]
            ///  extern System.Boolean TRY_GET_VALUE_01 (nint key, nint item);

            
            /// public static partial class Search_SpellCollection
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
                    ///   System.Void .ctor(System.Collections.Generic.IList<Spell> list)
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Collections.Generic.IList<Spell>");
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
                    ///   System.Boolean Contains(Spell item)
                    /// </summary>
                    /// public static bool CONTAINS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "Spell");
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
                    ///   Spell get_Item(System.Int32 index)
                    /// </summary>
                    /// public static bool GET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Spell get_Item(System.String key)
                    /// </summary>
                    /// public static bool GET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Item", "System.String");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.Generic.IList<Spell> get_Items()
                    /// </summary>
                    /// public static bool GET_ITEMS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Items");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.Generic.List<Spell> get_Items()
                    /// </summary>
                    /// public static bool GET_ITEMS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_Items");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetKeyForItem(Spell item)
                    /// </summary>
                    /// public static bool GET_KEY_FOR_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetKeyForItem", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetKeyForItem(Spell item)
                    /// </summary>
                    /// public static bool GET_KEY_FOR_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetKeyForItem", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void InsertItem(System.Int32 index, Spell item)
                    /// </summary>
                    /// public static bool INSERT_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void InsertItem(System.Int32 index, Spell item)
                    /// </summary>
                    /// public static bool INSERT_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InsertItem", "System.Int32", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Remove(Spell item)
                    /// </summary>
                    /// public static bool REMOVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Remove", "Spell");
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
                    ///   System.Void SetItem(System.Int32 index, Spell item)
                    /// </summary>
                    /// public static bool SET_ITEM_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetItem", "System.Int32", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void SetItem(System.Int32 index, Spell item)
                    /// </summary>
                    /// public static bool SET_ITEM_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetItem", "System.Int32", "Spell");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetValue(System.String key, Spell& item)
                    /// </summary>
                    /// public static bool TRY_GET_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetValue", "System.String", "Spell&");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean TryGetValue(System.String key, Spell& item)
                    /// </summary>
                    /// public static bool TRY_GET_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetValue", "System.String", "Spell&");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}