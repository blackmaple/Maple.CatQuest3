
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
    /// class ["ProjectStar".""."GunReloadHandler"]
    /// [Entitas.ReactiveSystem<GameEntity>]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000491U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 117, 110, 82, 101, 108, 111, 97, 100, 72, 97, 110, 100, 108, 101, 114])]


    // interface 0x8 Entitas.ICollector<GameEntity> _collector
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_collector", "_COLLECTOR")]

    // class 0xC System.Collections.Generic.List<GameEntity> _buffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_buffer", "_BUFFER")]

    // class 0x10 System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]
    public partial class GunReloadHandler
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GunReloadHandler";
        //public static byte[] Static_ClassName { get; } = [71, 117, 110, 82, 101, 108, 111, 97, 100, 72, 97, 110, 100, 108, 101, 114];

        //public const uint Const_TypeToken = 0x02000491U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GunReloadHandler(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GunReloadHandler(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GunReloadHandler obj) => obj._ptr;
            public static implicit operator bool(Ptr_GunReloadHandler obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."GunReloadHandler"]
    /// </summary>
    public partial class GunReloadHandler
    {



        /// <summary>
        ///   System.Void Activate()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Activate")]
        ///  extern void ACTIVATE ();


        /// <summary>
        ///   System.Void Clear()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Clear")]
        ///  extern void CLEAR ();


        /// <summary>
        ///   System.Void Deactivate()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Deactivate")]
        ///  extern void DEACTIVATE ();


        /// <summary>
        ///   System.Void Finalize()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Finalize")]
        ///  extern void FINALIZE ();


        /// <summary>
        /// static  System.Void ForceReload(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceReload", CallConvs = [typeof(CallConvCdecl)])]
        static extern void FORCE_RELOAD(nint entity);


        /// <summary>
        ///   System.Void OnGunClipReloaded(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnGunClipReloaded")]
        ///  extern void ON_GUN_CLIP_RELOADED (nint entity);


        /// <summary>
        ///   System.Void ReplenishBullet(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplenishBullet")]
        ///  extern void REPLENISH_BULLET (nint entity);


        /// <summary>
        /// static  System.Void ReplenishClip(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplenishClip")]
        /// static extern void REPLENISH_CLIP (nint entity);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
        ///  extern nint TO_STRING ();



        /// <summary>
        ///   System.Void .ctor(Contexts contexts)
        /// </summary>
        /// <param name="contexts">class Contexts</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GunReloadHandler))]
        ///  extern void .CTOR_00 (nint contexts);


        /// <summary>
        ///   System.Void .ctor(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// <param name="context">interface Entitas.IContext<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GunReloadHandler))]
        ///  extern void .CTOR_01 (nint context);


        /// <summary>
        ///   System.Void .ctor(Entitas.ICollector<GameEntity> collector)
        /// </summary>
        /// <param name="collector">interface Entitas.ICollector<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GunReloadHandler))]
        ///  extern void .CTOR_02 (nint collector);


        /// <summary>
        ///   System.Void Execute(System.Collections.Generic.List<GameEntity> entities)
        /// </summary>
        /// <param name="entities">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Execute", Search = typeof(Search_GunReloadHandler))]
        ///  extern void EXECUTE_00 (nint entities);


        /// <summary>
        ///  abstract System.Void Execute(System.Collections.Generic.List<GameEntity> entities)
        /// </summary>
        /// <param name="entities">class System.Collections.Generic.List<GameEntity></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Execute", Search = typeof(Search_GunReloadHandler))]
        ///  extern void EXECUTE_01 (nint entities);


        /// <summary>
        ///   System.Void Execute()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Execute", Search = typeof(Search_GunReloadHandler))]
        ///  extern void EXECUTE_02 ();


        /// <summary>
        ///   System.Boolean Filter(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Filter", Search = typeof(Search_GunReloadHandler))]
        ///  extern System.Boolean FILTER_00 (nint entity);


        /// <summary>
        ///  abstract System.Boolean Filter(GameEntity entity)
        /// </summary>
        /// <param name="entity">class GameEntity</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Filter", Search = typeof(Search_GunReloadHandler))]
        ///  extern System.Boolean FILTER_01 (nint entity);


        /// <summary>
        ///   Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// <param name="context">interface Entitas.IContext<GameEntity></param>
        /// <returns>interface Entitas.ICollector<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTrigger", Search = typeof(Search_GunReloadHandler))]
        ///  extern nint GET_TRIGGER_00 (nint context);


        /// <summary>
        ///  abstract Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// <param name="context">interface Entitas.IContext<GameEntity></param>
        /// <returns>interface Entitas.ICollector<GameEntity></returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetTrigger", Search = typeof(Search_GunReloadHandler))]
        ///  extern nint GET_TRIGGER_01 (nint context);


        /// public static partial class Search_GunReloadHandler
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void .ctor(Contexts contexts)
        /// </summary>
        /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Contexts");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Entitas.IContext<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor(Entitas.ICollector<GameEntity> collector)
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "Entitas.ICollector<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Execute(System.Collections.Generic.List<GameEntity> entities)
        /// </summary>
        /// public static bool EXECUTE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Execute", "System.Collections.Generic.List<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract System.Void Execute(System.Collections.Generic.List<GameEntity> entities)
        /// </summary>
        /// public static bool EXECUTE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Execute", "System.Collections.Generic.List<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Execute()
        /// </summary>
        /// public static bool EXECUTE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Execute");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean Filter(GameEntity entity)
        /// </summary>
        /// public static bool FILTER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Filter", "GameEntity");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract System.Boolean Filter(GameEntity entity)
        /// </summary>
        /// public static bool FILTER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Filter", "GameEntity");
        ///     
        ///  
        /// 


        /// <summary>
        ///   Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// public static bool GET_TRIGGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTrigger", "Entitas.IContext<GameEntity>");
        ///     
        ///  
        /// 


        /// <summary>
        ///  abstract Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context)
        /// </summary>
        /// public static bool GET_TRIGGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetTrigger", "Entitas.IContext<GameEntity>");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}