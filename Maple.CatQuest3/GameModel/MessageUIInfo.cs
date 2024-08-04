
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
    /// class ["ProjectStar".""."MessageUIInfo"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200089DU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [77, 101, 115, 115, 97, 103, 101, 85, 73, 73, 110, 102, 111])]


    // class 0x8 UnityEngine.Sprite displaySprite
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"displaySprite", "DISPLAY_SPRITE")]

    // class 0xC Line contentMessage
    [MonoCollectorSearchFieldAttribute(typeof(Line.Ptr_Line), "contentMessage", "CONTENT_MESSAGE", IsReadOnly = false)]

    // struct 0x10 System.Boolean showChoicePrompts
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"showChoicePrompts", "SHOW_CHOICE_PROMPTS")]

    // struct 0x11 System.Boolean showOnlyCancelPrompt
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"showOnlyCancelPrompt", "SHOW_ONLY_CANCEL_PROMPT")]

    // struct 0x12 System.Boolean allowMouseInput
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"allowMouseInput", "ALLOW_MOUSE_INPUT")]

    // struct 0x14 System.Int32 initiatorPlayerID
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"initiatorPlayerID", "INITIATOR_PLAYER_ID")]
    public partial class MessageUIInfo
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MessageUIInfo";
        //public static byte[] Static_ClassName { get; } = [77, 101, 115, 115, 97, 103, 101, 85, 73, 73, 110, 102, 111];

        //public const uint Const_TypeToken = 0x0200089DU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MessageUIInfo(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MessageUIInfo(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MessageUIInfo obj) => obj._ptr;
            public static implicit operator bool(Ptr_MessageUIInfo obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."MessageUIInfo"]
    /// </summary>
    public partial class MessageUIInfo
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();




        /// public static partial class Search_MessageUIInfo
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}