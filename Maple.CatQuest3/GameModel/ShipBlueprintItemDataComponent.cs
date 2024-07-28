
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
    /// class ["ProjectStar".""."ShipBlueprintItemDataComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000538U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [83, 104, 105, 112, 66, 108, 117, 101, 112, 114, 105, 110, 116, 73, 116, 101, 109, 68, 97, 116, 97, 67, 111, 109, 112, 111, 110, 101, 110, 116])]
    
                
    // class 0x8 ShipBlueprintItemData value
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"value", "VALUE")]
    public partial class ShipBlueprintItemDataComponent
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ShipBlueprintItemDataComponent";
        //public static byte[] Static_ClassName { get; } = [83, 104, 105, 112, 66, 108, 117, 101, 112, 114, 105, 110, 116, 73, 116, 101, 109, 68, 97, 116, 97, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x02000538U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ShipBlueprintItemDataComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ShipBlueprintItemDataComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ShipBlueprintItemDataComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_ShipBlueprintItemDataComponent obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."ShipBlueprintItemDataComponent"]
        /// </summary>
        public partial class ShipBlueprintItemDataComponent
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();
            
            

            
            /// public static partial class Search_ShipBlueprintItemDataComponent
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}