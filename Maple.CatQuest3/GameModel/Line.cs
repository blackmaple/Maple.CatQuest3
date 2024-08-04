
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
    /// class ["ProjectStar".""."Line"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000894U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [76, 105, 110, 101])]


    // class 0x8 System.String content
    [MonoCollectorSearchFieldAttribute(typeof(PMonoString), "content", "CONTENT", IsReadOnly = false)]

    // class 0xC HutongGames.PlayMaker.FsmString[] parameters
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"parameters", "PARAMETERS")]

    // class 0x10 System.String translateID
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"translateID", "TRANSLATE_ID")]

    // struct 0x14 System.Single duration
    // [MonoCollectorSearchFieldAttribute(typeof(System.Single),"duration", "DURATION")]

    // struct 0x18 System.Boolean textVibrationEffect
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"textVibrationEffect", "TEXT_VIBRATION_EFFECT")]
    public partial class Line
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Line";
        //public static byte[] Static_ClassName { get; } = [76, 105, 110, 101];

        //public const uint Const_TypeToken = 0x02000894U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Line(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Line(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Line obj) => obj._ptr;
            public static implicit operator bool(Ptr_Line obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."Line"]
    /// </summary>
    public partial class Line
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_Line
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}