
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
    /// static class ["ProjectStar".""."InputContextExtensions"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200067FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [73, 110, 112, 117, 116, 67, 111, 110, 116, 101, 120, 116, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115])]


    public partial class InputContextExtensions
    {
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "InputContextExtensions";
        //public static byte[] Static_ClassName { get; } = [73, 110, 112, 117, 116, 67, 111, 110, 116, 101, 120, 116, 69, 120, 116, 101, 110, 115, 105, 111, 110, 115];

        //public const uint Const_TypeToken = 0x0200067FU;








        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_InputContextExtensions(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_InputContextExtensions(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_InputContextExtensions obj) => obj._ptr;
            public static implicit operator bool(Ptr_InputContextExtensions obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["ProjectStar".""."InputContextExtensions"]
    /// </summary>
    public partial class InputContextExtensions
    {



        /// <summary>
        /// static  System.Void CreateInputStateCommand(InputContext context, InputStateCommand command, System.Nullable<InputState> state)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="command">enum InputStateCommand</param>
        /// <param name="state">struct System.Nullable<InputState></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateInputStateCommand")]
        /// static extern void CREATE_INPUT_STATE_COMMAND (nint context, InputStateCommand command, System.Nullable<InputState> state);


        /// <summary>
        /// static  InputState GetCurrentInputState(InputContext context)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <returns>enum InputState</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentInputState", CallConvs = [typeof(CallConvCdecl)])]
        static extern InputState GET_CURRENT_INPUT_STATE(nint context);


        /// <summary>
        /// static  System.Void HideCursor(InputContext context)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HideCursor")]
        /// static extern void HIDE_CURSOR (nint context);


        /// <summary>
        /// static  System.Void ShowCursor(InputContext context)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ShowCursor")]
        /// static extern void SHOW_CURSOR (nint context);


        /// <summary>
        /// static  System.Void StopAllVibration(InputContext context, System.Int32 playerId, System.Single fadeDuration, ProjectStar.Haptics.Motor motor)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="fadeDuration">struct System.Single</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllVibration")]
        /// static extern void STOP_ALL_VIBRATION (nint context, System.Int32 playerId, System.Single fadeDuration, ProjectStar.Haptics.Motor motor);


        /// <summary>
        /// static  System.Void StopAllVibrationToAll(InputContext context, System.Single fadeDuration, ProjectStar.Haptics.Motor motor)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="fadeDuration">struct System.Single</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopAllVibrationToAll")]
        /// static extern void STOP_ALL_VIBRATION_TO_ALL (nint context, System.Single fadeDuration, ProjectStar.Haptics.Motor motor);


        /// <summary>
        /// static  System.Void StopVibrationToAll(InputContext context, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="preset">enum VibrationPresetReferences</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopVibrationToAll")]
        /// static extern void STOP_VIBRATION_TO_ALL (nint context, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId);



        /// <summary>
        /// static  InputEntity SetVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="vibrationData">class ProjectStar.Haptics.VibrationData</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern nint SET_VIBRATION_00 (nint context, System.Int32 playerId, nint vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void SetVibration(InputContext context, System.Int32 playerId, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="intensity">struct System.Single</param>
        /// <param name="vibrateDuration">struct System.Single</param>
        /// <param name="fadeInDuration">struct System.Single</param>
        /// <param name="fadeOutDuration">struct System.Single</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern void SET_VIBRATION_01 (nint context, System.Int32 playerId, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void SetVibration(InputContext context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="preset">enum VibrationPresetReferences</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern void SET_VIBRATION_02 (nint context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="intensity">struct System.Single</param>
        /// <param name="vibrateDuration">struct System.Single</param>
        /// <param name="fadeInDuration">struct System.Single</param>
        /// <param name="fadeOutDuration">struct System.Single</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibrationToAll", Search = typeof(Search_InputContextExtensions))]
        /// static extern void SET_VIBRATION_TO_ALL_00 (nint context, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="preset">enum VibrationPresetReferences</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibrationToAll", Search = typeof(Search_InputContextExtensions))]
        /// static extern void SET_VIBRATION_TO_ALL_01 (nint context, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="vibrationData">class ProjectStar.Haptics.VibrationData</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVibrationToAll", Search = typeof(Search_InputContextExtensions))]
        /// static extern void SET_VIBRATION_TO_ALL_02 (nint context, nint vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  InputEntity StopVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="vibrationData">class ProjectStar.Haptics.VibrationData</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>class InputEntity</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern nint STOP_VIBRATION_00 (nint context, System.Int32 playerId, nint vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void StopVibration(InputContext context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="preset">enum VibrationPresetReferences</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern void STOP_VIBRATION_01 (nint context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId);


        /// <summary>
        /// static  System.Void StopVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId, UnityEngine.AudioSource source)
        /// </summary>
        /// <param name="context">class InputContext</param>
        /// <param name="playerId">struct System.Int32</param>
        /// <param name="vibrationData">class ProjectStar.Haptics.VibrationData</param>
        /// <param name="motor">enum ProjectStar.Haptics.Motor</param>
        /// <param name="customId">struct System.Int32</param>
        /// <param name="source">class UnityEngine.AudioSource</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopVibration", Search = typeof(Search_InputContextExtensions))]
        /// static extern void STOP_VIBRATION_02 (nint context, System.Int32 playerId, nint vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId, nint source);


        /// public static partial class Search_InputContextExtensions
        /// {
        /// 
        ///     

        /// <summary>
        /// static  InputEntity SetVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibration", "InputContext", "System.Int32", "ProjectStar.Haptics.VibrationData", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetVibration(InputContext context, System.Int32 playerId, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibration", "InputContext", "System.Int32", "System.Single", "System.Single", "System.Single", "System.Single", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetVibration(InputContext context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibration", "InputContext", "System.Int32", "VibrationPresetReferences", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, System.Single intensity, System.Single vibrateDuration, System.Single fadeInDuration, System.Single fadeOutDuration, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_TO_ALL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibrationToAll", "InputContext", "System.Single", "System.Single", "System.Single", "System.Single", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_TO_ALL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibrationToAll", "InputContext", "VibrationPresetReferences", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void SetVibrationToAll(InputContext context, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool SET_VIBRATION_TO_ALL_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVibrationToAll", "InputContext", "ProjectStar.Haptics.VibrationData", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  InputEntity StopVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool STOP_VIBRATION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopVibration", "InputContext", "System.Int32", "ProjectStar.Haptics.VibrationData", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void StopVibration(InputContext context, System.Int32 playerId, VibrationPresetReferences preset, ProjectStar.Haptics.Motor motor, System.Int32 customId)
        /// </summary>
        /// public static bool STOP_VIBRATION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopVibration", "InputContext", "System.Int32", "VibrationPresetReferences", "ProjectStar.Haptics.Motor", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void StopVibration(InputContext context, System.Int32 playerId, ProjectStar.Haptics.VibrationData vibrationData, ProjectStar.Haptics.Motor motor, System.Int32 customId, UnityEngine.AudioSource source)
        /// </summary>
        /// public static bool STOP_VIBRATION_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "StopVibration", "InputContext", "System.Int32", "ProjectStar.Haptics.VibrationData", "ProjectStar.Haptics.Motor", "System.Int32", "UnityEngine.AudioSource");
        ///     
        ///  
        /// 
        /// 
        /// }

    }


}