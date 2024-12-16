
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
    /// class ["ProjectStar".""."UnlockedEquipmentListComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000399U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [85, 110, 108, 111, 99, 107, 101, 100, 69, 113, 117, 105, 112, 109, 101, 110, 116, 76, 105, 115, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116])]
    
                
    // class 0x8 System.Collections.Generic.List<Equipment> value
      [MonoCollectorSearchFieldAttribute(typeof(PMonoList_x86<Equipment.Ptr_Equipment>),"value", "VALUE")]
    public partial class UnlockedEquipmentListComponent
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "UnlockedEquipmentListComponent";
        //public static byte[] Static_ClassName { get; } = [85, 110, 108, 111, 99, 107, 101, 100, 69, 113, 117, 105, 112, 109, 101, 110, 116, 76, 105, 115, 116, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x02000399U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_UnlockedEquipmentListComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_UnlockedEquipmentListComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_UnlockedEquipmentListComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_UnlockedEquipmentListComponent obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."UnlockedEquipmentListComponent"]
        /// </summary>
        public partial class UnlockedEquipmentListComponent
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();
            
            

            
            /// public static partial class Search_UnlockedEquipmentListComponent
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}