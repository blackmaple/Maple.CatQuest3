
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
    /// class ["ProjectStar".""."LevelValueGauge"]
    /// [ValueGauge]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x020000EBU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [76, 101, 118, 101, 108, 86, 97, 108, 117, 101, 71, 97, 117, 103, 101])]
    
                
    // class 0x8 Sigtrap.Relays.Relay<System.Int32,System.Int32> onValueChangedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onValueChangedEvent", "ON_VALUE_CHANGED_EVENT")]
            
    // class 0xC Sigtrap.Relays.Relay<System.Int32> onMaxValueChangedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onMaxValueChangedEvent", "ON_MAX_VALUE_CHANGED_EVENT")]
            
    // struct 0x10 System.Int32 _currValue
      [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_currValue", "_CURR_VALUE")]
            
    // struct 0x14 System.Int32 _maxValue
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_maxValue", "_MAX_VALUE")]
            
    // struct 0x18 System.Boolean <autoCapMaxValue>k__BackingField
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"<autoCapMaxValue>k__BackingField", "AUTO_CAP_MAX_VALUE")]
    public partial class LevelValueGauge
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "LevelValueGauge";
        //public static byte[] Static_ClassName { get; } = [76, 101, 118, 101, 108, 86, 97, 108, 117, 101, 71, 97, 117, 103, 101];

        //public const uint Const_TypeToken = 0x020000EBU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_LevelValueGauge(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_LevelValueGauge(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_LevelValueGauge obj) => obj._ptr;
            public static implicit operator bool(Ptr_LevelValueGauge obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."LevelValueGauge"]
        /// </summary>
        public partial class LevelValueGauge
        { 

            
            
            /// <summary>
            ///   System.Void CopyValues(ValueGauge other)
            /// </summary>
            /// <param name="other">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CopyValues")]
            ///  extern void COPY_VALUES (nint other);

            
            /// <summary>
            ///   System.Boolean get_capped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_capped")]
            ///  extern System.Boolean GET_CAPPED ();

            
            /// <summary>
            ///   System.Int32 get_CappedCurrLevel()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_CappedCurrLevel")]
            ///  extern System.Int32 GET_CAPPED_CURR_LEVEL ();

            
            /// <summary>
            ///   System.Int32 get_currValue()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_currValue")]
            ///  extern System.Int32 GET_CURR_VALUE ();

            
            /// <summary>
            ///   System.Int32 get_maxValue()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_maxValue")]
            ///  extern System.Int32 GET_MAX_VALUE ();

            
            /// <summary>
            ///   System.Boolean get_valueIsMaxed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_valueIsMaxed")]
            ///  extern System.Boolean GET_VALUE_IS_MAXED ();

            
            /// <summary>
            /// static  System.Int32 op_Implicit(ValueGauge valueGauge)
            /// </summary>
            /// <param name="valueGauge">class ValueGauge</param>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
            /// static extern System.Int32 OP_IMPLICIT (nint valueGauge);

            
            /// <summary>
            ///   System.Void set_currValue(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_currValue")]
            ///  extern void SET_CURR_VALUE (System.Int32 value);

            
            /// <summary>
            ///   System.Void set_maxValue(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_maxValue")]
            ///  extern void SET_MAX_VALUE (System.Int32 value);

            
            /// <summary>
            ///   System.Void SilentSetCurr(System.Int32 currVal)
            /// </summary>
            /// <param name="currVal">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SilentSetCurr")]
            ///  extern void SILENT_SET_CURR (System.Int32 currVal);

            
            /// <summary>
            ///   System.Void SilentSetMax(System.Int32 maxVal)
            /// </summary>
            /// <param name="maxVal">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SilentSetMax")]
            ///  extern void SILENT_SET_MAX (System.Int32 maxVal);

            
            /// <summary>
            ///   System.Void SilentSetValues(System.Int32 currVal, System.Int32 maxVal)
            /// </summary>
            /// <param name="currVal">struct System.Int32</param>
            /// <param name="maxVal">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SilentSetValues")]
            ///  extern void SILENT_SET_VALUES (System.Int32 currVal, System.Int32 maxVal);
            
            
            
            /// <summary>
            ///   System.Void .ctor(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_00 (System.Int32 value);

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 curr, System.Int32 max)
            /// </summary>
            /// <param name="curr">struct System.Int32</param>
            /// <param name="max">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_01 (System.Int32 curr, System.Int32 max);

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 value)
            /// </summary>
            /// <param name="value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_03 (System.Int32 value);

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 curr, System.Int32 max)
            /// </summary>
            /// <param name="curr">struct System.Int32</param>
            /// <param name="max">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_04 (System.Int32 curr, System.Int32 max);

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 curr, System.Int32 max, System.Boolean autoCapValue)
            /// </summary>
            /// <param name="curr">struct System.Int32</param>
            /// <param name="max">struct System.Int32</param>
            /// <param name="autoCapValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_05 (System.Int32 curr, System.Int32 max, System.Boolean autoCapValue);

            
            /// <summary>
            ///   System.Void .ctor(ValueGauge other)
            /// </summary>
            /// <param name="other">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_LevelValueGauge))]
            ///  extern void .CTOR_06 (nint other);

            
            /// <summary>
            ///   System.Boolean get_autoCapMaxValue()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_autoCapMaxValue", Search = typeof(Search_LevelValueGauge))]
            ///  extern System.Boolean GET_AUTO_CAP_MAX_VALUE_00 ();

            
            /// <summary>
            ///   System.Boolean get_autoCapMaxValue()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_autoCapMaxValue", Search = typeof(Search_LevelValueGauge))]
            ///  extern System.Boolean GET_AUTO_CAP_MAX_VALUE_01 ();

            
            /// <summary>
            ///   System.Void set_autoCapMaxValue(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_autoCapMaxValue", Search = typeof(Search_LevelValueGauge))]
            ///  extern void SET_AUTO_CAP_MAX_VALUE_00 (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_autoCapMaxValue(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_autoCapMaxValue", Search = typeof(Search_LevelValueGauge))]
            ///  extern void SET_AUTO_CAP_MAX_VALUE_01 (System.Boolean value);

            
            /// public static partial class Search_LevelValueGauge
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 value)
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 curr, System.Int32 max)
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor()
                    /// </summary>
                    /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 value)
                    /// </summary>
                    /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 curr, System.Int32 max)
                    /// </summary>
                    /// public static bool .CTOR_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 curr, System.Int32 max, System.Boolean autoCapValue)
                    /// </summary>
                    /// public static bool .CTOR_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "System.Int32", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(ValueGauge other)
                    /// </summary>
                    /// public static bool .CTOR_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "ValueGauge");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean get_autoCapMaxValue()
                    /// </summary>
                    /// public static bool GET_AUTO_CAP_MAX_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_autoCapMaxValue");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean get_autoCapMaxValue()
                    /// </summary>
                    /// public static bool GET_AUTO_CAP_MAX_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "get_autoCapMaxValue");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void set_autoCapMaxValue(System.Boolean value)
                    /// </summary>
                    /// public static bool SET_AUTO_CAP_MAX_VALUE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_autoCapMaxValue", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void set_autoCapMaxValue(System.Boolean value)
                    /// </summary>
                    /// public static bool SET_AUTO_CAP_MAX_VALUE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "set_autoCapMaxValue", "System.Boolean");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}