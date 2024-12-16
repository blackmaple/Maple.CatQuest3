
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
    /// class ["ProjectStar".""."UIPanelDisplayStatusComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020007C1U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [85, 73, 80, 97, 110, 101, 108, 68, 105, 115, 112, 108, 97, 121, 83, 116, 97, 116, 117, 115, 67, 111, 109, 112, 111, 110, 101, 110, 116])]
    
                
    // struct 0x8 System.Boolean isShowing
      [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"isShowing", "IS_SHOWING")]
    public partial class UIPanelDisplayStatusComponent
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "UIPanelDisplayStatusComponent";
        //public static byte[] Static_ClassName { get; } = [85, 73, 80, 97, 110, 101, 108, 68, 105, 115, 112, 108, 97, 121, 83, 116, 97, 116, 117, 115, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x020007C1U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UIPanelDisplayStatusComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UIPanelDisplayStatusComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UIPanelDisplayStatusComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_UIPanelDisplayStatusComponent obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."UIPanelDisplayStatusComponent"]
        /// </summary>
        public partial class UIPanelDisplayStatusComponent
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();
            
            

            
            /// public static partial class Search_UIPanelDisplayStatusComponent
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}