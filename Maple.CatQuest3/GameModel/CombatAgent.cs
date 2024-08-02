
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
    /// class ["ProjectStar".""."CombatAgent"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000088U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [67, 111, 109, 98, 97, 116, 65, 103, 101, 110, 116])]


    // class 0x8 ValueGauge health
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"health", "HEALTH")]

    // class 0xC CombatAgent.CombatStats stats
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"stats", "STATS")]

    // class 0x10 AdvancedStats advancedStats
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"advancedStats", "ADVANCED_STATS")]

    // class 0x14 CombatParameterModifiers modifiers
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"modifiers", "MODIFIERS")]

    // class 0x18 CombatRelaysContainer combatRelays
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"combatRelays", "COMBAT_RELAYS")]
    public partial class CombatAgent
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "CombatAgent";
        //public static byte[] Static_ClassName { get; } = [67, 111, 109, 98, 97, 116, 65, 103, 101, 110, 116];

        //public const uint Const_TypeToken = 0x02000088U;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_CombatAgent(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_CombatAgent(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_CombatAgent obj) => obj._ptr;
            public static implicit operator bool(Ptr_CombatAgent obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."CombatAgent"]
    /// </summary>
    public partial class CombatAgent
    {



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
        ///  extern void .CTOR ();


        /// <summary>
        ///   GameEntity CreateCombatAgentHealthUpdatedEvent()
        /// </summary>
        /// <returns>class GameEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateCombatAgentHealthUpdatedEvent")]
        ///  extern nint CREATE_COMBAT_AGENT_HEALTH_UPDATED_EVENT ();


        /// <summary>
        ///   System.Void Init(System.Int32 hp, System.Int32 mana, System.Int32 str, System.Int32 def, System.Int32 magic)
        /// </summary>
        /// <param name="hp">struct System.Int32</param>
        /// <param name="mana">struct System.Int32</param>
        /// <param name="str">struct System.Int32</param>
        /// <param name="def">struct System.Int32</param>
        /// <param name="magic">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Init")]
        ///  extern void INIT (System.Int32 hp, System.Int32 mana, System.Int32 str, System.Int32 def, System.Int32 magic);


        /// <summary>
        ///   System.Void InitStats()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InitStats")]
        ///  extern void INIT_STATS ();



        /// <summary>
        ///   System.Void Heal(CombatEvent combatEvent)
        /// </summary>
        /// <param name="combatEvent">class CombatEvent</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Heal", Search = typeof(Search_CombatAgent))]
        ///  extern void HEAL_00 (nint combatEvent);


        /// <summary>
        ///   System.Void Heal(System.Int32 healAmount)
        /// </summary>
        /// <param name="healAmount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Heal", Search = typeof(Search_CombatAgent))]
        ///  extern void HEAL_01 (System.Int32 healAmount);


        /// <summary>
        ///   System.Void TakeDamage(CombatEvent combatEvent)
        /// </summary>
        /// <param name="combatEvent">class CombatEvent</param>
        /// <returns>struct System.Void</returns>
        ///[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeDamage", CallConvs = [typeof(CallConvCdecl)])]
        ///extern void TAKE_DAMAGE_00(nint combatEvent);


        /// <summary>
        ///   System.Void TakeDamage(System.Int32 damage)
        /// </summary>
        /// <param name="damage">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TakeDamage", CallConvs = [typeof(CallConvCdecl)], Search = typeof(Search_CombatAgent))]
        extern void TAKE_DAMAGE_01(System.Int32 damage);


        public static partial class Search_CombatAgent
        {
            /// 
            ///     

            /// <summary>
            ///   System.Void Heal(CombatEvent combatEvent)
            /// </summary>
            /// public static bool HEAL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Heal", "CombatEvent");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Heal(System.Int32 healAmount)
            /// </summary>
            /// public static bool HEAL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Heal", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void TakeDamage(CombatEvent combatEvent)
            /// </summary>
            /// public static bool TAKE_DAMAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeDamage", "CombatEvent");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void TakeDamage(System.Int32 damage)
            /// </summary>
            public static bool TAKE_DAMAGE_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TakeDamage", "System.Int32");
            ///     
            ///  
            /// 
            /// 
        }

    }


}