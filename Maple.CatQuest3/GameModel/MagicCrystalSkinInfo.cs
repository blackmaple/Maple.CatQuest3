
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{
    
    
    /// <summary>
    /// class ["ProjectStar".""."MagicCrystalSkinInfo"]
    /// [BaseSkinInfo]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020003CFU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [77, 97, 103, 105, 99, 67, 114, 121, 115, 116, 97, 108, 83, 107, 105, 110, 73, 110, 102, 111])]
    
                
    // class 0x8 UnityEngine.Sprite main
      [MonoCollectorSearchFieldAttribute(typeof(Sprite.Ptr_Sprite),"main", "MAIN")]
            
    // class 0xC UnityEngine.Sprite glow
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"glow", "GLOW")]
    public partial class MagicCrystalSkinInfo
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "MagicCrystalSkinInfo";
        //public static byte[] Static_ClassName { get; } = [77, 97, 103, 105, 99, 67, 114, 121, 115, 116, 97, 108, 83, 107, 105, 110, 73, 110, 102, 111];

        //public const uint Const_TypeToken = 0x020003CFU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_MagicCrystalSkinInfo(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_MagicCrystalSkinInfo(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_MagicCrystalSkinInfo obj) => obj._ptr;
            public static implicit operator bool(Ptr_MagicCrystalSkinInfo obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."MagicCrystalSkinInfo"]
        /// </summary>
        public partial class MagicCrystalSkinInfo
        { 

            
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MagicCrystalSkinInfo))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_MagicCrystalSkinInfo))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   UnityEngine.Sprite GetGroundSecondarySprite()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroundSecondarySprite", Search = typeof(Search_MagicCrystalSkinInfo))]
            ///  extern nint GET_GROUND_SECONDARY_SPRITE_00 ();

            
            /// <summary>
            ///  abstract UnityEngine.Sprite GetGroundSecondarySprite()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGroundSecondarySprite", Search = typeof(Search_MagicCrystalSkinInfo))]
            ///  extern nint GET_GROUND_SECONDARY_SPRITE_01 ();

            
            /// public static partial class Search_MagicCrystalSkinInfo
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
                    ///   UnityEngine.Sprite GetGroundSecondarySprite()
                    /// </summary>
                    /// public static bool GET_GROUND_SECONDARY_SPRITE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetGroundSecondarySprite");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract UnityEngine.Sprite GetGroundSecondarySprite()
                    /// </summary>
                    /// public static bool GET_GROUND_SECONDARY_SPRITE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetGroundSecondarySprite");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}