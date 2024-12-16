
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// class ["ProjectStar".""."RestTriggeredEventHandler"]
    /// [System.Object]
    /// [Entitas.IExecuteSystem]=>[Entitas.ISystem]=>[Entitas.ICleanupSystem]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020004D2U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [82, 101, 115, 116, 84, 114, 105, 103, 103, 101, 114, 101, 100, 69, 118, 101, 110, 116, 72, 97, 110, 100, 108, 101, 114])]


    // interface 0x8 Entitas.IGroup<GameEntity> entities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"entities", "ENTITIES")]

    // interface 0xC Entitas.IGroup<GameEntity> playerEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"playerEntities", "PLAYER_ENTITIES")]

    // interface 0x10 Entitas.IGroup<GameEntity> enemyEntities
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"enemyEntities", "ENEMY_ENTITIES")]

    // class 0x14 GameContext context
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"context", "CONTEXT")]
    public partial class RestTriggeredEventHandler
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "RestTriggeredEventHandler";
        //public static byte[] Static_ClassName { get; } = [82, 101, 115, 116, 84, 114, 105, 103, 103, 101, 114, 101, 100, 69, 118, 101, 110, 116, 72, 97, 110, 100, 108, 101, 114];

        //public const uint Const_TypeToken = 0x020004D2U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_RestTriggeredEventHandler(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_RestTriggeredEventHandler(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_RestTriggeredEventHandler obj) => obj._ptr;
            public static implicit operator bool(Ptr_RestTriggeredEventHandler obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."RestTriggeredEventHandler"]
    /// </summary>
    public partial class RestTriggeredEventHandler
    {



        /// <summary>
        ///   System.Void .ctor(Contexts contexts)
        /// </summary>
        /// <param name="contexts">class Contexts</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR (nint contexts);


        /// <summary>
        ///   System.Void Cleanup()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Cleanup")]
        ///  extern void CLEANUP ();


        /// <summary>
        ///   System.Void Execute()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Execute")]
        ///  extern void EXECUTE ();


        /// <summary>
        /// static  System.Void HealPlayerToMax(GameEntity playerEntity, GameContext context, System.Boolean tintPlayer, System.Boolean showHealText)
        /// </summary>
        /// <param name="playerEntity">class GameEntity</param>
        /// <param name="context">class GameContext</param>
        /// <param name="tintPlayer">struct System.Boolean</param>
        /// <param name="showHealText">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HealPlayerToMax", CallConvs = [typeof(CallConvCdecl)])]
        static extern void HEAL_PLAYER_TO_MAX(nint playerEntity, nint context, System.Boolean tintPlayer, System.Boolean showHealText);




        /// public static partial class Search_RestTriggeredEventHandler
        /// {
        /// 
        ///     
        /// 
        /// }

    }


}