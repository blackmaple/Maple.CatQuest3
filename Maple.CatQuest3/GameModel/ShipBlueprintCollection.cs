
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
    /// class ["ProjectStar".""."ShipBlueprintCollection"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200039CU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [83, 104, 105, 112, 66, 108, 117, 101, 112, 114, 105, 110, 116, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110])]
    
                
    // class 0x8 Sigtrap.Relays.Relay<ShipBlueprint> AddedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"AddedEvent", "ADDED_EVENT")]
            
    // class 0xC Sigtrap.Relays.Relay<ShipBlueprint> RemovedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"RemovedEvent", "REMOVED_EVENT")]
            
    // class 0x10 System.Collections.Generic.List<ShipBlueprint> collection
     [MonoCollectorSearchFieldAttribute(typeof(PMonoList_x86<ShipBlueprint.Ptr_ShipBlueprint>),"collection", "COLLECTION")]
    public partial class ShipBlueprintCollection
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ShipBlueprintCollection";
        //public static byte[] Static_ClassName { get; } = [83, 104, 105, 112, 66, 108, 117, 101, 112, 114, 105, 110, 116, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110];

        //public const uint Const_TypeToken = 0x0200039CU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ShipBlueprintCollection(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ShipBlueprintCollection(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ShipBlueprintCollection obj) => obj._ptr;
            public static implicit operator bool(Ptr_ShipBlueprintCollection obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."ShipBlueprintCollection"]
        /// </summary>
        public partial class ShipBlueprintCollection
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
            ///  extern void CLEAR ();

            
            /// <summary>
            ///   ShipBlueprint FindItem(System.String Guid)
            /// </summary>
            /// <param name="Guid">class System.String</param>
            /// <returns>class ShipBlueprint</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindItem")]
            ///  extern nint FIND_ITEM (nint Guid);

            
            /// <summary>
            ///   System.Collections.Generic.IEnumerable<ShipBlueprint> GetCollection()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerable<ShipBlueprint></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCollection")]
            ///  extern nint GET_COLLECTION ();

            
            /// <summary>
            ///   System.Int32 IndexOf(ShipBlueprint blueprint)
            /// </summary>
            /// <param name="blueprint">class ShipBlueprint</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IndexOf")]
            ///  extern System.Int32 INDEX_OF (nint blueprint);

            
            /// <summary>
            ///   System.Boolean Remove(ShipBlueprint blueprint)
            /// </summary>
            /// <param name="blueprint">class ShipBlueprint</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Remove")]
            ///  extern System.Boolean REMOVE (nint blueprint);
            
            
            
            /// <summary>
            ///   System.Boolean Add(ShipBlueprint blueprint)
            /// </summary>
            /// <param name="blueprint">class ShipBlueprint</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_ShipBlueprintCollection))]
            ///  extern System.Boolean ADD_00 (nint blueprint);

            
            /// <summary>
            ///   System.Boolean Add(ShipBlueprintItemData itemData, System.Int32 level)
            /// </summary>
            /// <param name="itemData">class ShipBlueprintItemData</param>
            /// <param name="level">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Add", Search = typeof(Search_ShipBlueprintCollection))]
            ///  extern System.Boolean ADD_01 (nint itemData, System.Int32 level);

            
            /// <summary>
            ///   System.Boolean Contains(ShipBlueprintItemData itemData)
            /// </summary>
            /// <param name="itemData">class ShipBlueprintItemData</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_ShipBlueprintCollection))]
            ///  extern System.Boolean CONTAINS_00 (nint itemData);

            
            /// <summary>
            ///   System.Boolean Contains(ShipBlueprint blueprint)
            /// </summary>
            /// <param name="blueprint">class ShipBlueprint</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Contains", Search = typeof(Search_ShipBlueprintCollection))]
            ///  extern System.Boolean CONTAINS_01 (nint blueprint);

            
            /// public static partial class Search_ShipBlueprintCollection
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Boolean Add(ShipBlueprint blueprint)
                    /// </summary>
                    /// public static bool ADD_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "ShipBlueprint");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Add(ShipBlueprintItemData itemData, System.Int32 level)
                    /// </summary>
                    /// public static bool ADD_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Add", "ShipBlueprintItemData", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Contains(ShipBlueprintItemData itemData)
                    /// </summary>
                    /// public static bool CONTAINS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "ShipBlueprintItemData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean Contains(ShipBlueprint blueprint)
                    /// </summary>
                    /// public static bool CONTAINS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Contains", "ShipBlueprint");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}