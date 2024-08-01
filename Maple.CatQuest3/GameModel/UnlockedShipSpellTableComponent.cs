
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
    /// class ["ProjectStar".""."UnlockedShipSpellTableComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200039DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [85, 110, 108, 111, 99, 107, 101, 100, 83, 104, 105, 112, 83, 112, 101, 108, 108, 84, 97, 98, 108, 101, 67, 111, 109, 112, 111, 110, 101, 110, 116])]
    
                
    // class 0x8 ShipSpellCollection value
      [MonoCollectorSearchFieldAttribute(typeof(ShipSpellCollection.Ptr_ShipSpellCollection),"value", "VALUE")]
    public partial class UnlockedShipSpellTableComponent
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "UnlockedShipSpellTableComponent";
        //public static byte[] Static_ClassName { get; } = [85, 110, 108, 111, 99, 107, 101, 100, 83, 104, 105, 112, 83, 112, 101, 108, 108, 84, 97, 98, 108, 101, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x0200039DU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UnlockedShipSpellTableComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UnlockedShipSpellTableComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UnlockedShipSpellTableComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_UnlockedShipSpellTableComponent obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."UnlockedShipSpellTableComponent"]
        /// </summary>
        public partial class UnlockedShipSpellTableComponent
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();
            
            

            
            /// public static partial class Search_UnlockedShipSpellTableComponent
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}