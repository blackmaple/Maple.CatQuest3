
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
    /// class ["ProjectStar".""."MapIconComponent"]
    /// [System.Object]
    /// [Entitas.IComponent]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200078DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [77, 97, 112, 73, 99, 111, 110, 67, 111, 109, 112, 111, 110, 101, 110, 116])]


    // class 0x8 MapIcon value
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"value", "VALUE")]

    // class 0xC GameEntity worldEntityLink
      [MonoCollectorSearchFieldAttribute(typeof(GameEntity.Ptr_GameEntity),"worldEntityLink", "WORLD_ENTITY_LINK")]

    // class 0x10 UnityEngine.Collider worldCollider
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"worldCollider", "WORLD_COLLIDER")]

    // enum 0x14 MapIconType mapIconType
    [MonoCollectorSearchFieldAttribute(typeof(MapIconType), "mapIconType", "MAP_ICON_TYPE")]
    public partial class MapIconComponent
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MapIconComponent";
        //public static byte[] Static_ClassName { get; } = [77, 97, 112, 73, 99, 111, 110, 67, 111, 109, 112, 111, 110, 101, 110, 116];

        //public const uint Const_TypeToken = 0x0200078DU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MapIconComponent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MapIconComponent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MapIconComponent obj) => obj._ptr;
            public static implicit operator bool(Ptr_MapIconComponent obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."MapIconComponent"]
    /// </summary>
    public partial class MapIconComponent
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_MapIconComponent
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}