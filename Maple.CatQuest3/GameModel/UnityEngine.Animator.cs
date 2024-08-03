
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
    /// class ["UnityEngine.AnimationModule"."UnityEngine"."Animator"]
    /// [UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 65, 110, 105, 109, 97, 116, 105, 111, 110, 77, 111, 100, 117, 108, 101], 0x0200001FU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 65, 110, 105, 109, 97, 116, 105, 111, 110, 77, 111, 100, 117, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [65, 110, 105, 109, 97, 116, 111, 114])]

    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]

    // struct 0x8 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]
    public partial class Animator
    {
        //public const string Const_ImageName = "UnityEngine.AnimationModule";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 65, 110, 105, 109, 97, 116, 105, 111, 110, 77, 111, 100, 117, 108, 101];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Animator";
        //public static byte[] Static_ClassName { get; } = [65, 110, 105, 109, 97, 116, 111, 114];

        //public const uint Const_TypeToken = 0x0200001FU;




        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Animator(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Animator(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Animator obj) => obj._ptr;
            public static implicit operator bool(Ptr_Animator obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["UnityEngine.AnimationModule"."UnityEngine"."Animator"]
    /// </summary>
    public partial class Animator
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        ///   System.Void ApplyBuiltinRootMotion()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ApplyBuiltinRootMotion")]
        ///  extern void APPLY_BUILTIN_ROOT_MOTION ();


        /// <summary>
        ///   System.Void CheckIfInIKPass()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckIfInIKPass")]
        ///  extern void CHECK_IF_IN_IK_PASS ();


        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
        /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);


        /// <summary>
        ///   System.Void ClearInternalControllerPlayable()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ClearInternalControllerPlayable")]
        ///  extern void CLEAR_INTERNAL_CONTROLLER_PLAYABLE ();


        /// <summary>
        /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
        /// </summary>
        /// <param name="lhs">class UnityEngine.Object</param>
        /// <param name="rhs">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareBaseObjects")]
        /// static extern System.Boolean COMPARE_BASE_OBJECTS (nint lhs, nint rhs);


        /// <summary>
        ///   System.Boolean CompareTag(System.String tag)
        /// </summary>
        /// <param name="tag">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CompareTag")]
        ///  extern System.Boolean COMPARE_TAG (nint tag);


        /// <summary>
        /// static  T[] ConvertStateMachineBehaviour(UnityEngine.ScriptableObject[] rawObjects)
        /// </summary>
        /// <param name="rawObjects">class UnityEngine.ScriptableObject[]</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ConvertStateMachineBehaviour")]
        /// static extern nint CONVERT_STATE_MACHINE_BEHAVIOUR (nint rawObjects);


        /// <summary>
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
        /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


        /// <summary>
        /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DoesObjectWithInstanceIDExist")]
        /// static extern System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST (System.Int32 instanceID);


        /// <summary>
        /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
        /// </summary>
        /// <param name="target">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DontDestroyOnLoad")]
        /// static extern void DONT_DESTROY_ON_LOAD (nint target);


        /// <summary>
        ///   System.Void EnsureRunningOnMainThread()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EnsureRunningOnMainThread")]
        ///  extern void ENSURE_RUNNING_ON_MAIN_THREAD ();


        /// <summary>
        ///   System.Boolean Equals(System.Object other)
        /// </summary>
        /// <param name="other">class System.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Equals")]
        ///  extern System.Boolean EQUALS (nint other);


        /// <summary>
        /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectFromInstanceID")]
        /// static extern nint FIND_OBJECT_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeAll")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_ALL (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfTypeIncludingAssets")]
        /// static extern nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindSceneObjectsOfType")]
        /// static extern nint FIND_SCENE_OBJECTS_OF_TYPE (nint type);


        /// <summary>
        /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
        /// </summary>
        /// <param name="instanceID">struct System.Int32</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceLoadFromInstanceID")]
        /// static extern nint FORCE_LOAD_FROM_INSTANCE_ID (System.Int32 instanceID);


        /// <summary>
        ///   System.Void ForceStateNormalizedTime(System.Single normalizedTime)
        /// </summary>
        /// <param name="normalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ForceStateNormalizedTime")]
        ///  extern void FORCE_STATE_NORMALIZED_TIME (System.Single normalizedTime);


        /// <summary>
        ///   System.Boolean get_allowConstantClipSamplingOptimization()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_allowConstantClipSamplingOptimization")]
        ///  extern System.Boolean GET_ALLOW_CONSTANT_CLIP_SAMPLING_OPTIMIZATION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_angularVelocity()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_angularVelocity")]
        ///  extern UnityEngine.Vector3 GET_ANGULAR_VELOCITY ();


        /// <summary>
        ///   System.Void get_angularVelocity_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_angularVelocity_Injected")]
        ///  extern void GET_ANGULAR_VELOCITY_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Boolean get_animatePhysics()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_animatePhysics")]
        ///  extern System.Boolean GET_ANIMATE_PHYSICS ();


        /// <summary>
        ///   System.Boolean get_applyRootMotion()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_applyRootMotion")]
        ///  extern System.Boolean GET_APPLY_ROOT_MOTION ();


        /// <summary>
        ///   UnityEngine.Avatar get_avatar()
        /// </summary>
        /// <returns>class UnityEngine.Avatar</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_avatar")]
        ///  extern nint GET_AVATAR ();


        /// <summary>
        ///   UnityEngine.Transform get_avatarRoot()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_avatarRoot")]
        ///  extern nint GET_AVATAR_ROOT ();


        /// <summary>
        ///   UnityEngine.Vector3 get_bodyPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyPosition")]
        ///  extern UnityEngine.Vector3 GET_BODY_POSITION ();


        /// <summary>
        ///   UnityEngine.Vector3 get_bodyPositionInternal()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyPositionInternal")]
        ///  extern UnityEngine.Vector3 GET_BODY_POSITION_INTERNAL ();


        /// <summary>
        ///   System.Void get_bodyPositionInternal_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyPositionInternal_Injected")]
        ///  extern void GET_BODY_POSITION_INTERNAL_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion get_bodyRotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyRotation")]
        ///  extern UnityEngine.Quaternion GET_BODY_ROTATION ();


        /// <summary>
        ///   UnityEngine.Quaternion get_bodyRotationInternal()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyRotationInternal")]
        ///  extern UnityEngine.Quaternion GET_BODY_ROTATION_INTERNAL ();


        /// <summary>
        ///   System.Void get_bodyRotationInternal_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_bodyRotationInternal_Injected")]
        ///  extern void GET_BODY_ROTATION_INTERNAL_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   UnityEngine.AnimatorCullingMode get_cullingMode()
        /// </summary>
        /// <returns>enum UnityEngine.AnimatorCullingMode</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_cullingMode")]
        ///  extern UnityEngine.AnimatorCullingMode GET_CULLING_MODE ();


        /// <summary>
        ///   UnityEngine.Vector3 get_deltaPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_deltaPosition")]
        ///  extern UnityEngine.Vector3 GET_DELTA_POSITION ();


        /// <summary>
        ///   System.Void get_deltaPosition_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_deltaPosition_Injected")]
        ///  extern void GET_DELTA_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion get_deltaRotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_deltaRotation")]
        ///  extern UnityEngine.Quaternion GET_DELTA_ROTATION ();


        /// <summary>
        ///   System.Void get_deltaRotation_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_deltaRotation_Injected")]
        ///  extern void GET_DELTA_ROTATION_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   System.Boolean get_enabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_enabled")]
        ///  extern System.Boolean GET_ENABLED ();


        /// <summary>
        ///   System.Single get_feetPivotActive()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_feetPivotActive")]
        ///  extern System.Single GET_FEET_PIVOT_ACTIVE ();


        /// <summary>
        ///   System.Boolean get_fireEvents()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_fireEvents")]
        ///  extern System.Boolean GET_FIRE_EVENTS ();


        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
        ///  extern nint GET_GAME_OBJECT ();


        /// <summary>
        ///   System.Single get_gravityWeight()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gravityWeight")]
        ///  extern System.Single GET_GRAVITY_WEIGHT ();


        /// <summary>
        ///   System.Boolean get_hasBoundPlayables()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasBoundPlayables")]
        ///  extern System.Boolean GET_HAS_BOUND_PLAYABLES ();


        /// <summary>
        ///   System.Boolean get_hasRootMotion()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasRootMotion")]
        ///  extern System.Boolean GET_HAS_ROOT_MOTION ();


        /// <summary>
        ///   System.Boolean get_hasTransformHierarchy()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasTransformHierarchy")]
        ///  extern System.Boolean GET_HAS_TRANSFORM_HIERARCHY ();


        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
        ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// <summary>
        ///   System.Single get_humanScale()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_humanScale")]
        ///  extern System.Single GET_HUMAN_SCALE ();


        /// <summary>
        ///   System.Boolean get_isActiveAndEnabled()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isActiveAndEnabled")]
        ///  extern System.Boolean GET_IS_ACTIVE_AND_ENABLED ();


        /// <summary>
        ///   System.Boolean get_isHuman()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isHuman")]
        ///  extern System.Boolean GET_IS_HUMAN ();


        /// <summary>
        ///   System.Boolean get_isInitialized()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInitialized")]
        ///  extern System.Boolean GET_IS_INITIALIZED ();


        /// <summary>
        ///   System.Boolean get_isMatchingTarget()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isMatchingTarget")]
        ///  extern System.Boolean GET_IS_MATCHING_TARGET ();


        /// <summary>
        ///   System.Boolean get_isOptimizable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isOptimizable")]
        ///  extern System.Boolean GET_IS_OPTIMIZABLE ();


        /// <summary>
        ///   System.Boolean get_isRootPositionOrRotationControlledByCurves()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isRootPositionOrRotationControlledByCurves")]
        ///  extern System.Boolean GET_IS_ROOT_POSITION_OR_ROTATION_CONTROLLED_BY_CURVES ();


        /// <summary>
        ///   System.Boolean get_keepAnimatorControllerStateOnDisable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_keepAnimatorControllerStateOnDisable")]
        ///  extern System.Boolean GET_KEEP_ANIMATOR_CONTROLLER_STATE_ON_DISABLE ();


        /// <summary>
        ///   System.Boolean get_keepAnimatorStateOnDisable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_keepAnimatorStateOnDisable")]
        ///  extern System.Boolean GET_KEEP_ANIMATOR_STATE_ON_DISABLE ();


        /// <summary>
        ///   System.Int32 get_layerCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_layerCount")]
        ///  extern System.Int32 GET_LAYER_COUNT ();


        /// <summary>
        ///   System.Boolean get_layersAffectMassCenter()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_layersAffectMassCenter")]
        ///  extern System.Boolean GET_LAYERS_AFFECT_MASS_CENTER ();


        /// <summary>
        ///   System.Single get_leftFeetBottomHeight()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_leftFeetBottomHeight")]
        ///  extern System.Single GET_LEFT_FEET_BOTTOM_HEIGHT ();


        /// <summary>
        ///   System.Boolean get_linearVelocityBlending()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_linearVelocityBlending")]
        ///  extern System.Boolean GET_LINEAR_VELOCITY_BLENDING ();


        /// <summary>
        ///   System.Boolean get_logWarnings()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_logWarnings")]
        ///  extern System.Boolean GET_LOG_WARNINGS ();


        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   System.Int32 get_parameterCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_parameterCount")]
        ///  extern System.Int32 GET_PARAMETER_COUNT ();


        /// <summary>
        ///   UnityEngine.AnimatorControllerParameter[] get_parameters()
        /// </summary>
        /// <returns>class UnityEngine.AnimatorControllerParameter[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_parameters")]
        ///  extern nint GET_PARAMETERS ();


        /// <summary>
        ///   UnityEngine.Vector3 get_pivotPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pivotPosition")]
        ///  extern UnityEngine.Vector3 GET_PIVOT_POSITION ();


        /// <summary>
        ///   System.Void get_pivotPosition_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pivotPosition_Injected")]
        ///  extern void GET_PIVOT_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Single get_pivotWeight()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pivotWeight")]
        ///  extern System.Single GET_PIVOT_WEIGHT ();


        /// <summary>
        ///   UnityEngine.Playables.PlayableGraph get_playableGraph()
        /// </summary>
        /// <returns>struct UnityEngine.Playables.PlayableGraph</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playableGraph")]
        ///  extern UnityEngine.Playables.PlayableGraph GET_PLAYABLE_GRAPH ();


        /// <summary>
        ///   System.Single get_playbackTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_playbackTime")]
        ///  extern System.Single GET_PLAYBACK_TIME ();


        /// <summary>
        ///   UnityEngine.AnimatorRecorderMode get_recorderMode()
        /// </summary>
        /// <returns>enum UnityEngine.AnimatorRecorderMode</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_recorderMode")]
        ///  extern UnityEngine.AnimatorRecorderMode GET_RECORDER_MODE ();


        /// <summary>
        ///   System.Single get_recorderStartTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_recorderStartTime")]
        ///  extern System.Single GET_RECORDER_START_TIME ();


        /// <summary>
        ///   System.Single get_recorderStopTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_recorderStopTime")]
        ///  extern System.Single GET_RECORDER_STOP_TIME ();


        /// <summary>
        ///   System.Single get_rightFeetBottomHeight()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rightFeetBottomHeight")]
        ///  extern System.Single GET_RIGHT_FEET_BOTTOM_HEIGHT ();


        /// <summary>
        ///   UnityEngine.Vector3 get_rootPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rootPosition")]
        ///  extern UnityEngine.Vector3 GET_ROOT_POSITION ();


        /// <summary>
        ///   System.Void get_rootPosition_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rootPosition_Injected")]
        ///  extern void GET_ROOT_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion get_rootRotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rootRotation")]
        ///  extern UnityEngine.Quaternion GET_ROOT_ROTATION ();


        /// <summary>
        ///   System.Void get_rootRotation_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rootRotation_Injected")]
        ///  extern void GET_ROOT_ROTATION_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController()
        /// </summary>
        /// <returns>class UnityEngine.RuntimeAnimatorController</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_runtimeAnimatorController")]
        ///  extern nint GET_RUNTIME_ANIMATOR_CONTROLLER ();


        /// <summary>
        ///   System.Single get_speed()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_speed")]
        ///  extern System.Single GET_SPEED ();


        /// <summary>
        ///   System.Boolean get_stabilizeFeet()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_stabilizeFeet")]
        ///  extern System.Boolean GET_STABILIZE_FEET ();


        /// <summary>
        ///   System.Boolean get_supportsOnAnimatorMove()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_supportsOnAnimatorMove")]
        ///  extern System.Boolean GET_SUPPORTS_ON_ANIMATOR_MOVE ();


        /// <summary>
        ///   System.String get_tag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
        ///  extern nint GET_TAG ();


        /// <summary>
        ///   UnityEngine.Vector3 get_targetPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetPosition")]
        ///  extern UnityEngine.Vector3 GET_TARGET_POSITION ();


        /// <summary>
        ///   System.Void get_targetPosition_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetPosition_Injected")]
        ///  extern void GET_TARGET_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion get_targetRotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetRotation")]
        ///  extern UnityEngine.Quaternion GET_TARGET_ROTATION ();


        /// <summary>
        ///   System.Void get_targetRotation_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_targetRotation_Injected")]
        ///  extern void GET_TARGET_ROTATION_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   UnityEngine.Transform get_transform()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
        ///  extern nint GET_TRANSFORM ();


        /// <summary>
        ///   UnityEngine.AnimatorUpdateMode get_updateMode()
        /// </summary>
        /// <returns>enum UnityEngine.AnimatorUpdateMode</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_updateMode")]
        ///  extern UnityEngine.AnimatorUpdateMode GET_UPDATE_MODE ();


        /// <summary>
        ///   UnityEngine.Vector3 get_velocity()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_velocity")]
        ///  extern UnityEngine.Vector3 GET_VELOCITY ();


        /// <summary>
        ///   System.Void get_velocity_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_velocity_Injected")]
        ///  extern void GET_VELOCITY_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Boolean get_writeDefaultValuesOnDisable()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_writeDefaultValuesOnDisable")]
        ///  extern System.Boolean GET_WRITE_DEFAULT_VALUES_ON_DISABLE ();


        /// <summary>
        ///   System.Int32 GetAnimatorClipInfoCount(System.Int32 layerIndex, System.Boolean current)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="current">struct System.Boolean</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorClipInfoCount")]
        ///  extern System.Int32 GET_ANIMATOR_CLIP_INFO_COUNT (System.Int32 layerIndex, System.Boolean current);


        /// <summary>
        ///   System.Void GetAnimatorClipInfoInternal(System.Int32 layerIndex, System.Boolean isCurrent, System.Object clips)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="isCurrent">struct System.Boolean</param>
        /// <param name="clips">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorClipInfoInternal")]
        ///  extern void GET_ANIMATOR_CLIP_INFO_INTERNAL (System.Int32 layerIndex, System.Boolean isCurrent, nint clips);


        /// <summary>
        ///   System.Void GetAnimatorStateInfo(System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="stateInfoIndex">enum UnityEngine.StateInfoIndex</param>
        /// <param name="info">struct UnityEngine.AnimatorStateInfo&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorStateInfo")]
        ///  extern void GET_ANIMATOR_STATE_INFO (System.Int32 layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, UnityEngine.AnimatorStateInfo& info);


        /// <summary>
        ///   System.String GetAnimatorStateName(System.Int32 layerIndex, System.Boolean current)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="current">struct System.Boolean</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorStateName")]
        ///  extern nint GET_ANIMATOR_STATE_NAME (System.Int32 layerIndex, System.Boolean current);


        /// <summary>
        ///   UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId)
        /// </summary>
        /// <param name="humanBoneId">enum UnityEngine.HumanBodyBones</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBoneTransform")]
        ///  extern nint GET_BONE_TRANSFORM (UnityEngine.HumanBodyBones humanBoneId);


        /// <summary>
        ///   UnityEngine.Transform GetBoneTransformInternal(System.Int32 humanBoneId)
        /// </summary>
        /// <param name="humanBoneId">struct System.Int32</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBoneTransformInternal")]
        ///  extern nint GET_BONE_TRANSFORM_INTERNAL (System.Int32 humanBoneId);


        /// <summary>
        ///   System.Boolean GetBoolID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBoolID")]
        ///  extern System.Boolean GET_BOOL_ID (System.Int32 id);


        /// <summary>
        ///   System.Boolean GetBoolString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBoolString")]
        ///  extern System.Boolean GET_BOOL_STRING (nint name);


        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


        /// <summary>
        ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="oneFurtherThanResultValue">struct System.IntPtr</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentFastPath")]
        ///  extern void GET_COMPONENT_FAST_PATH (nint type, System.IntPtr oneFurtherThanResultValue);


        /// <summary>
        ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
        /// </summary>
        /// <param name="searchType">abstract class System.Type</param>
        /// <param name="resultList">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsForListInternal")]
        ///  extern void GET_COMPONENTS_FOR_LIST_INTERNAL (nint searchType, nint resultList);


        /// <summary>
        ///   System.Int32 GetCurrentAnimatorClipInfoCount(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentAnimatorClipInfoCount")]
        ///  extern System.Int32 GET_CURRENT_ANIMATOR_CLIP_INFO_COUNT (System.Int32 layerIndex);


        /// <summary>
        ///   UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct UnityEngine.AnimatorStateInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentAnimatorStateInfo")]
        ///  extern UnityEngine.AnimatorStateInfo GET_CURRENT_ANIMATOR_STATE_INFO (System.Int32 layerIndex);


        /// <summary>
        ///   System.Void GetCurrentGraph(UnityEngine.Playables.PlayableGraph& graph)
        /// </summary>
        /// <param name="graph">struct UnityEngine.Playables.PlayableGraph&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentGraph")]
        ///  extern void GET_CURRENT_GRAPH (UnityEngine.Playables.PlayableGraph& graph);


        /// <summary>
        ///   System.String GetCurrentStateName(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentStateName")]
        ///  extern nint GET_CURRENT_STATE_NAME (System.Int32 layerIndex);


        /// <summary>
        ///   System.Single GetFloatID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFloatID")]
        ///  extern System.Single GET_FLOAT_ID (System.Int32 id);


        /// <summary>
        ///   System.Single GetFloatString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFloatString")]
        ///  extern System.Single GET_FLOAT_STRING (nint name);


        /// <summary>
        ///   UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalPosition")]
        ///  extern UnityEngine.Vector3 GET_GOAL_POSITION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Void GetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalPosition_Injected")]
        ///  extern void GET_GOAL_POSITION_INJECTED (UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalRotation")]
        ///  extern UnityEngine.Quaternion GET_GOAL_ROTATION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Void GetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalRotation_Injected")]
        ///  extern void GET_GOAL_ROTATION_INJECTED (UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& ret);


        /// <summary>
        ///   System.Single GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalWeightPosition")]
        ///  extern System.Single GET_GOAL_WEIGHT_POSITION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Single GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGoalWeightRotation")]
        ///  extern System.Single GET_GOAL_WEIGHT_ROTATION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHintPosition")]
        ///  extern UnityEngine.Vector3 GET_HINT_POSITION (UnityEngine.AvatarIKHint hint);


        /// <summary>
        ///   System.Void GetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHintPosition_Injected")]
        ///  extern void GET_HINT_POSITION_INJECTED (UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Single GetHintWeightPosition(UnityEngine.AvatarIKHint hint)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHintWeightPosition")]
        ///  extern System.Single GET_HINT_WEIGHT_POSITION (UnityEngine.AvatarIKHint hint);


        /// <summary>
        ///   UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKHintPosition")]
        ///  extern UnityEngine.Vector3 GET_IK_HINT_POSITION (UnityEngine.AvatarIKHint hint);


        /// <summary>
        ///   System.Single GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKHintPositionWeight")]
        ///  extern System.Single GET_IK_HINT_POSITION_WEIGHT (UnityEngine.AvatarIKHint hint);


        /// <summary>
        ///   UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKPosition")]
        ///  extern UnityEngine.Vector3 GET_IK_POSITION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Single GetIKPositionWeight(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKPositionWeight")]
        ///  extern System.Single GET_IK_POSITION_WEIGHT (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKRotation")]
        ///  extern UnityEngine.Quaternion GET_IK_ROTATION (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Single GetIKRotationWeight(UnityEngine.AvatarIKGoal goal)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIKRotationWeight")]
        ///  extern System.Single GET_IK_ROTATION_WEIGHT (UnityEngine.AvatarIKGoal goal);


        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
        ///  extern System.Int32 GET_INSTANCE_ID ();


        /// <summary>
        ///   System.Int32 GetIntegerID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIntegerID")]
        ///  extern System.Int32 GET_INTEGER_ID (System.Int32 id);


        /// <summary>
        ///   System.Int32 GetIntegerString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetIntegerString")]
        ///  extern System.Int32 GET_INTEGER_STRING (nint name);


        /// <summary>
        ///   System.Int32 GetLayerIndex(System.String layerName)
        /// </summary>
        /// <param name="layerName">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLayerIndex")]
        ///  extern System.Int32 GET_LAYER_INDEX (nint layerName);


        /// <summary>
        ///   System.String GetLayerName(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLayerName")]
        ///  extern nint GET_LAYER_NAME (System.Int32 layerIndex);


        /// <summary>
        ///   System.Single GetLayerWeight(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLayerWeight")]
        ///  extern System.Single GET_LAYER_WEIGHT (System.Int32 layerIndex);


        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint obj);


        /// <summary>
        ///   System.Int32 GetNextAnimatorClipInfoCount(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextAnimatorClipInfoCount")]
        ///  extern System.Int32 GET_NEXT_ANIMATOR_CLIP_INFO_COUNT (System.Int32 layerIndex);


        /// <summary>
        ///   UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct UnityEngine.AnimatorStateInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextAnimatorStateInfo")]
        ///  extern UnityEngine.AnimatorStateInfo GET_NEXT_ANIMATOR_STATE_INFO (System.Int32 layerIndex);


        /// <summary>
        ///   System.String GetNextStateName(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextStateName")]
        ///  extern nint GET_NEXT_STATE_NAME (System.Int32 layerIndex);


        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
        /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// <summary>
        ///   UnityEngine.AnimatorControllerParameter GetParameter(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class UnityEngine.AnimatorControllerParameter</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetParameter")]
        ///  extern nint GET_PARAMETER (System.Int32 index);


        /// <summary>
        ///   UnityEngine.AnimatorControllerParameter GetParameterInternal(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class UnityEngine.AnimatorControllerParameter</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetParameterInternal")]
        ///  extern nint GET_PARAMETER_INTERNAL (System.Int32 index);


        /// <summary>
        ///   System.Single GetRecorderStartTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRecorderStartTime")]
        ///  extern System.Single GET_RECORDER_START_TIME ();


        /// <summary>
        ///   System.Single GetRecorderStopTime()
        /// </summary>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRecorderStopTime")]
        ///  extern System.Single GET_RECORDER_STOP_TIME ();


        /// <summary>
        ///   System.String GetStats()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetStats")]
        ///  extern nint GET_STATS ();


        /// <summary>
        ///   System.Boolean HasState(System.Int32 layerIndex, System.Int32 stateID)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="stateID">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasState")]
        ///  extern System.Boolean HAS_STATE (System.Int32 layerIndex, System.Int32 stateID);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingle")]
        /// static extern nint INTERNAL_CLONE_SINGLE (nint data);


        /// <summary>
        /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_CloneSingleWithParent")]
        /// static extern nint INTERNAL_CLONE_SINGLE_WITH_PARENT (nint data, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE (nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingle_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_INJECTED (nint data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3</param>
        /// <param name="rot">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT (nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);


        /// <summary>
        /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
        /// </summary>
        /// <param name="data">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="pos">struct UnityEngine.Vector3&</param>
        /// <param name="rot">struct UnityEngine.Quaternion&</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_InstantiateSingleWithParent_Injected")]
        /// static extern nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED (nint data, nint parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot);


        /// <summary>
        ///   UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.ScriptableObject[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalGetBehaviours")]
        ///  extern nint INTERNAL_GET_BEHAVIOURS (nint type);


        /// <summary>
        ///   UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(System.Int32 fullPathHash, System.Int32 layerIndex, System.Type type)
        /// </summary>
        /// <param name="fullPathHash">struct System.Int32</param>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.ScriptableObject[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalGetBehavioursByKey")]
        ///  extern nint INTERNAL_GET_BEHAVIOURS_BY_KEY (System.Int32 fullPathHash, System.Int32 layerIndex, nint type);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Animator))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Animator))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Animator))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Animator))]
        ///  extern void .CTOR_03 ();


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Animator))]
        ///  extern void BROADCAST_MESSAGE_00 (nint methodName, nint parameter, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Animator))]
        ///  extern void BROADCAST_MESSAGE_01 (nint methodName, nint parameter);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Animator))]
        ///  extern void BROADCAST_MESSAGE_02 (nint methodName);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Animator))]
        ///  extern void BROADCAST_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTimeOffset">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_00 (nint stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset);


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_01 (nint stateName, System.Single normalizedTransitionDuration, System.Int32 layer);


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_02 (nint stateName, System.Single normalizedTransitionDuration);


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTimeOffset">struct System.Single</param>
        /// <param name="normalizedTransitionTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_03 (nint stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime);


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTimeOffset">struct System.Single</param>
        /// <param name="normalizedTransitionTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_04 (System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime);


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTimeOffset">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_05 (System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset);


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_06 (System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer);


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="normalizedTransitionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFade", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_07 (System.Int32 stateHashName, System.Single normalizedTransitionDuration);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_00 (nint stateName, System.Single fixedTransitionDuration);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_01 (nint stateName, System.Single fixedTransitionDuration, System.Int32 layer);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTimeOffset">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_02 (nint stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTimeOffset">struct System.Single</param>
        /// <param name="normalizedTransitionTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_03 (nint stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTimeOffset">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_04 (System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_05 (System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_06 (System.Int32 stateHashName, System.Single fixedTransitionDuration);


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// <param name="stateHashName">struct System.Int32</param>
        /// <param name="fixedTransitionDuration">struct System.Single</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTimeOffset">struct System.Single</param>
        /// <param name="normalizedTransitionTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CrossFadeInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void CROSS_FADE_IN_FIXED_TIME_07 (System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_Animator))]
        /// static extern void DESTROY_OBJECT_01 (nint obj);


        /// <summary>
        ///   System.Void EvaluateController()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EvaluateController", Search = typeof(Search_Animator))]
        ///  extern void EVALUATE_CONTROLLER_00 ();


        /// <summary>
        ///   System.Void EvaluateController(System.Single deltaTime)
        /// </summary>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("EvaluateController", Search = typeof(Search_Animator))]
        ///  extern void EVALUATE_CONTROLLER_01 (System.Single deltaTime);


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Animator))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="info">struct UnityEngine.AnimatorTransitionInfo&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorTransitionInfo", Search = typeof(Search_Animator))]
        ///  extern void GET_ANIMATOR_TRANSITION_INFO_00 (System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info);


        /// <summary>
        ///   UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct UnityEngine.AnimatorTransitionInfo</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAnimatorTransitionInfo", Search = typeof(Search_Animator))]
        ///  extern UnityEngine.AnimatorTransitionInfo GET_ANIMATOR_TRANSITION_INFO_01 (System.Int32 layerIndex);


        /// <summary>
        ///   UnityEngine.ScriptableObject GetBehaviour(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.ScriptableObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBehaviour", Search = typeof(Search_Animator))]
        ///  extern nint GET_BEHAVIOUR_00 (nint type);


        /// <summary>
        ///   T GetBehaviour()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBehaviour", Search = typeof(Search_Animator))]
        ///  extern nint GET_BEHAVIOUR_01 ();


        /// <summary>
        ///   T[] GetBehaviours()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBehaviours", Search = typeof(Search_Animator))]
        ///  extern nint GET_BEHAVIOURS_00 ();


        /// <summary>
        ///   UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex)
        /// </summary>
        /// <param name="fullPathHash">struct System.Int32</param>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class UnityEngine.StateMachineBehaviour[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBehaviours", Search = typeof(Search_Animator))]
        ///  extern nint GET_BEHAVIOURS_01 (System.Int32 fullPathHash, System.Int32 layerIndex);


        /// <summary>
        ///   System.Boolean GetBool(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBool", Search = typeof(Search_Animator))]
        ///  extern System.Boolean GET_BOOL_00 (nint name);


        /// <summary>
        ///   System.Boolean GetBool(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetBool", Search = typeof(Search_Animator))]
        ///  extern System.Boolean GET_BOOL_01 (System.Int32 id);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.String type)
        /// </summary>
        /// <param name="type">class System.String</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_02 (nint type);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENT_IN_PARENT_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_00 (nint type);


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Animator))]
        ///  extern void GET_COMPONENTS_01 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Animator))]
        ///  extern void GET_COMPONENTS_02 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_04 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Animator))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_05 (nint results);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Animator))]
        ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Animator))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();


        /// <summary>
        ///   UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class UnityEngine.AnimatorClipInfo[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentAnimatorClipInfo", Search = typeof(Search_Animator))]
        ///  extern nint GET_CURRENT_ANIMATOR_CLIP_INFO_00 (System.Int32 layerIndex);


        /// <summary>
        ///   System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="clips">class System.Collections.Generic.List<UnityEngine.AnimatorClipInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentAnimatorClipInfo", Search = typeof(Search_Animator))]
        ///  extern void GET_CURRENT_ANIMATOR_CLIP_INFO_01 (System.Int32 layerIndex, nint clips);


        /// <summary>
        ///   System.Single GetFloat(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFloat", Search = typeof(Search_Animator))]
        ///  extern System.Single GET_FLOAT_00 (nint name);


        /// <summary>
        ///   System.Single GetFloat(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Single</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetFloat", Search = typeof(Search_Animator))]
        ///  extern System.Single GET_FLOAT_01 (System.Int32 id);


        /// <summary>
        ///   System.Int32 GetInteger(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInteger", Search = typeof(Search_Animator))]
        ///  extern System.Int32 GET_INTEGER_00 (nint name);


        /// <summary>
        ///   System.Int32 GetInteger(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInteger", Search = typeof(Search_Animator))]
        ///  extern System.Int32 GET_INTEGER_01 (System.Int32 id);


        /// <summary>
        ///   UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>class UnityEngine.AnimatorClipInfo[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextAnimatorClipInfo", Search = typeof(Search_Animator))]
        ///  extern nint GET_NEXT_ANIMATOR_CLIP_INFO_00 (System.Int32 layerIndex);


        /// <summary>
        ///   System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="clips">class System.Collections.Generic.List<UnityEngine.AnimatorClipInfo></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetNextAnimatorClipInfo", Search = typeof(Search_Animator))]
        ///  extern void GET_NEXT_ANIMATOR_CLIP_INFO_01 (System.Int32 layerIndex, nint clips);


        /// <summary>
        ///   UnityEngine.Quaternion GetQuaternion(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetQuaternion", Search = typeof(Search_Animator))]
        ///  extern UnityEngine.Quaternion GET_QUATERNION_00 (nint name);


        /// <summary>
        ///   UnityEngine.Quaternion GetQuaternion(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetQuaternion", Search = typeof(Search_Animator))]
        ///  extern UnityEngine.Quaternion GET_QUATERNION_01 (System.Int32 id);


        /// <summary>
        ///   UnityEngine.Vector3 GetVector(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetVector", Search = typeof(Search_Animator))]
        ///  extern UnityEngine.Vector3 GET_VECTOR_00 (nint name);


        /// <summary>
        ///   UnityEngine.Vector3 GetVector(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetVector", Search = typeof(Search_Animator))]
        ///  extern UnityEngine.Vector3 GET_VECTOR_01 (System.Int32 id);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_05 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Animator))]
        /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);


        /// public static partial class Search_Animator
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
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// public static bool .CTOR_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "System.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// public static bool BROADCAST_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "BroadcastMessage", "System.String", "UnityEngine.SendMessageOptions");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
        /// </summary>
        /// public static bool CROSS_FADE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.String", "System.Single", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// public static bool CROSS_FADE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.String", "System.Single", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration)
        /// </summary>
        /// public static bool CROSS_FADE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.String", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.String stateName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// public static bool CROSS_FADE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.String", "System.Single", "System.Int32", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// public static bool CROSS_FADE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.Int32", "System.Single", "System.Int32", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer, System.Single normalizedTimeOffset)
        /// </summary>
        /// public static bool CROSS_FADE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.Int32", "System.Single", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// public static bool CROSS_FADE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.Int32", "System.Single", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFade(System.Int32 stateHashName, System.Single normalizedTransitionDuration)
        /// </summary>
        /// public static bool CROSS_FADE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFade", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.String", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.String", "System.Single", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.String", "System.Single", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.String stateName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.String", "System.Single", "System.Int32", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.Int32", "System.Single", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.Int32", "System.Single", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.Int32", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void CrossFadeInFixedTime(System.Int32 stateHashName, System.Single fixedTransitionDuration, System.Int32 layer, System.Single fixedTimeOffset, System.Single normalizedTransitionTime)
        /// </summary>
        /// public static bool CROSS_FADE_IN_FIXED_TIME_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CrossFadeInFixedTime", "System.Int32", "System.Single", "System.Int32", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// public static bool DESTROY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Destroy", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// public static bool DESTROY_IMMEDIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_IMMEDIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyImmediate", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// public static bool DESTROY_OBJECT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// public static bool DESTROY_OBJECT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "DestroyObject", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void EvaluateController()
        /// </summary>
        /// public static bool EVALUATE_CONTROLLER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EvaluateController");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void EvaluateController(System.Single deltaTime)
        /// </summary>
        /// public static bool EVALUATE_CONTROLLER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "EvaluateController", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_ANY_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindAnyObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// public static bool FIND_FIRST_OBJECT_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindFirstObjectByType", "System.Type", "UnityEngine.FindObjectsInactive");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECT_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectOfType", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "System.Type", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// public static bool FIND_OBJECTS_BY_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsByType", "UnityEngine.FindObjectsInactive", "UnityEngine.FindObjectsSortMode");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// public static bool FIND_OBJECTS_OF_TYPE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "FindObjectsOfType", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetAnimatorTransitionInfo(System.Int32 layerIndex, UnityEngine.AnimatorTransitionInfo& info)
        /// </summary>
        /// public static bool GET_ANIMATOR_TRANSITION_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetAnimatorTransitionInfo", "System.Int32", "UnityEngine.AnimatorTransitionInfo&");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(System.Int32 layerIndex)
        /// </summary>
        /// public static bool GET_ANIMATOR_TRANSITION_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetAnimatorTransitionInfo", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.ScriptableObject GetBehaviour(System.Type type)
        /// </summary>
        /// public static bool GET_BEHAVIOUR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBehaviour", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetBehaviour()
        /// </summary>
        /// public static bool GET_BEHAVIOUR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBehaviour");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetBehaviours()
        /// </summary>
        /// public static bool GET_BEHAVIOURS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBehaviours");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.StateMachineBehaviour[] GetBehaviours(System.Int32 fullPathHash, System.Int32 layerIndex)
        /// </summary>
        /// public static bool GET_BEHAVIOURS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBehaviours", "System.Int32", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean GetBool(System.String name)
        /// </summary>
        /// public static bool GET_BOOL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBool", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Boolean GetBool(System.Int32 id)
        /// </summary>
        /// public static bool GET_BOOL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetBool", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// public static bool GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// public static bool GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.String type)
        /// </summary>
        /// public static bool GET_COMPONENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponent", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// public static bool GET_COMPONENT_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInChildren");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// public static bool GET_COMPONENT_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentInParent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// public static bool GET_COMPONENTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Type", "System.Collections.Generic.List<UnityEngine.Component>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// public static bool GET_COMPONENTS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponents");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Boolean", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_CHILDREN_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInChildren", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Type");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent", "System.Boolean", "System.Collections.Generic.List<T>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// public static bool GET_COMPONENTS_IN_PARENT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetComponentsInParent");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(System.Int32 layerIndex)
        /// </summary>
        /// public static bool GET_CURRENT_ANIMATOR_CLIP_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetCurrentAnimatorClipInfo", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetCurrentAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
        /// </summary>
        /// public static bool GET_CURRENT_ANIMATOR_CLIP_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetCurrentAnimatorClipInfo", "System.Int32", "System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single GetFloat(System.String name)
        /// </summary>
        /// public static bool GET_FLOAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloat", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Single GetFloat(System.Int32 id)
        /// </summary>
        /// public static bool GET_FLOAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetFloat", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInteger(System.String name)
        /// </summary>
        /// public static bool GET_INTEGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInteger", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Int32 GetInteger(System.Int32 id)
        /// </summary>
        /// public static bool GET_INTEGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetInteger", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(System.Int32 layerIndex)
        /// </summary>
        /// public static bool GET_NEXT_ANIMATOR_CLIP_INFO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetNextAnimatorClipInfo", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void GetNextAnimatorClipInfo(System.Int32 layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips)
        /// </summary>
        /// public static bool GET_NEXT_ANIMATOR_CLIP_INFO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetNextAnimatorClipInfo", "System.Int32", "System.Collections.Generic.List<UnityEngine.AnimatorClipInfo>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Quaternion GetQuaternion(System.String name)
        /// </summary>
        /// public static bool GET_QUATERNION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetQuaternion", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Quaternion GetQuaternion(System.Int32 id)
        /// </summary>
        /// public static bool GET_QUATERNION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetQuaternion", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 GetVector(System.String name)
        /// </summary>
        /// public static bool GET_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVector", "System.String");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 GetVector(System.Int32 id)
        /// </summary>
        /// public static bool GET_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetVector", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// public static bool INSTANTIATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// public static bool INSTANTIATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// public static bool INSTANTIATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "UnityEngine.Object", "UnityEngine.Transform", "System.Boolean");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// public static bool INSTANTIATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// public static bool INSTANTIATE_06 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_07 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// public static bool INSTANTIATE_08 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// public static bool INSTANTIATE_09 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Instantiate", "T", "UnityEngine.Transform", "System.Boolean");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["UnityEngine.AnimationModule"."UnityEngine"."Animator"]
    /// </summary>
    public partial class Animator
    {



        /// <summary>
        ///   System.Boolean IsBoneTransform(UnityEngine.Transform transform)
        /// </summary>
        /// <param name="transform">class UnityEngine.Transform</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsBoneTransform")]
        ///  extern System.Boolean IS_BONE_TRANSFORM (nint transform);


        /// <summary>
        ///   System.Boolean IsControlled(UnityEngine.Transform transform)
        /// </summary>
        /// <param name="transform">class UnityEngine.Transform</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsControlled")]
        ///  extern System.Boolean IS_CONTROLLED (nint transform);


        /// <summary>
        ///   System.Boolean IsInIKPass()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInIKPass")]
        ///  extern System.Boolean IS_IN_IK_PASS ();


        /// <summary>
        ///   System.Boolean IsInTransition(System.Int32 layerIndex)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsInTransition")]
        ///  extern System.Boolean IS_IN_TRANSITION (System.Int32 layerIndex);


        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
        /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// <summary>
        ///   System.Boolean IsParameterControlledByCurveID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsParameterControlledByCurveID")]
        ///  extern System.Boolean IS_PARAMETER_CONTROLLED_BY_CURVE_ID (System.Int32 id);


        /// <summary>
        ///   System.Boolean IsParameterControlledByCurveString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsParameterControlledByCurveString")]
        ///  extern System.Boolean IS_PARAMETER_CONTROLLED_BY_CURVE_STRING (nint name);


        /// <summary>
        /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsPersistent")]
        /// static extern System.Boolean IS_PERSISTENT (nint obj);


        /// <summary>
        ///   System.Void MarkDirty()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MarkDirty")]
        ///  extern void MARK_DIRTY ();


        /// <summary>
        ///   System.Void MatchTarget_Injected(UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
        /// </summary>
        /// <param name="matchPosition">struct UnityEngine.Vector3&</param>
        /// <param name="matchRotation">struct UnityEngine.Quaternion&</param>
        /// <param name="targetBodyPart">struct System.Int32</param>
        /// <param name="weightMask">struct UnityEngine.MatchTargetWeightMask&</param>
        /// <param name="startNormalizedTime">struct System.Single</param>
        /// <param name="targetNormalizedTime">struct System.Single</param>
        /// <param name="completeMatch">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MatchTarget_Injected")]
        ///  extern void MATCH_TARGET_INJECTED (UnityEngine.Vector3& matchPosition, UnityEngine.Quaternion& matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask& weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch);


        /// <summary>
        ///   System.Void OnCullingModeChanged()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnCullingModeChanged")]
        ///  extern void ON_CULLING_MODE_CHANGED ();


        /// <summary>
        ///   System.Void OnUpdateModeChanged()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnUpdateModeChanged")]
        ///  extern void ON_UPDATE_MODE_CHANGED ();


        /// <summary>
        /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Equality")]
        /// static extern System.Boolean OP_EQUALITY (nint x, nint y);


        /// <summary>
        /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
        /// </summary>
        /// <param name="exists">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Implicit")]
        /// static extern System.Boolean OP_IMPLICIT (nint exists);


        /// <summary>
        /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
        /// </summary>
        /// <param name="x">class UnityEngine.Object</param>
        /// <param name="y">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("op_Inequality")]
        /// static extern System.Boolean OP_INEQUALITY (nint x, nint y);


        /// <summary>
        ///   System.Void ResetTriggerID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetTriggerID")]
        ///  extern void RESET_TRIGGER_ID (System.Int32 id);


        /// <summary>
        ///   System.Void ResetTriggerString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetTriggerString")]
        ///  extern void RESET_TRIGGER_STRING (nint name);


        /// <summary>
        ///   System.String ResolveHash(System.Int32 hash)
        /// </summary>
        /// <param name="hash">struct System.Int32</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResolveHash")]
        ///  extern nint RESOLVE_HASH (System.Int32 hash);


        /// <summary>
        ///   System.Void set_allowConstantClipSamplingOptimization(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_allowConstantClipSamplingOptimization")]
        ///  extern void SET_ALLOW_CONSTANT_CLIP_SAMPLING_OPTIMIZATION (System.Boolean value);


        /// <summary>
        ///   System.Void set_animatePhysics(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_animatePhysics")]
        ///  extern void SET_ANIMATE_PHYSICS (System.Boolean value);


        /// <summary>
        ///   System.Void set_applyRootMotion(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_applyRootMotion")]
        ///  extern void SET_APPLY_ROOT_MOTION (System.Boolean value);


        /// <summary>
        ///   System.Void set_avatar(UnityEngine.Avatar value)
        /// </summary>
        /// <param name="value">class UnityEngine.Avatar</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_avatar")]
        ///  extern void SET_AVATAR (nint value);


        /// <summary>
        ///   System.Void set_bodyPosition(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyPosition")]
        ///  extern void SET_BODY_POSITION (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_bodyPositionInternal(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyPositionInternal")]
        ///  extern void SET_BODY_POSITION_INTERNAL (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_bodyPositionInternal_Injected(UnityEngine.Vector3& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyPositionInternal_Injected")]
        ///  extern void SET_BODY_POSITION_INTERNAL_INJECTED (UnityEngine.Vector3& value);


        /// <summary>
        ///   System.Void set_bodyRotation(UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyRotation")]
        ///  extern void SET_BODY_ROTATION (UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void set_bodyRotationInternal(UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyRotationInternal")]
        ///  extern void SET_BODY_ROTATION_INTERNAL (UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void set_bodyRotationInternal_Injected(UnityEngine.Quaternion& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_bodyRotationInternal_Injected")]
        ///  extern void SET_BODY_ROTATION_INTERNAL_INJECTED (UnityEngine.Quaternion& value);


        /// <summary>
        ///   System.Void set_cullingMode(UnityEngine.AnimatorCullingMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.AnimatorCullingMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_cullingMode")]
        ///  extern void SET_CULLING_MODE (UnityEngine.AnimatorCullingMode value);


        /// <summary>
        ///   System.Void set_enabled(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_enabled")]
        ///  extern void SET_ENABLED (System.Boolean value);


        /// <summary>
        ///   System.Void set_feetPivotActive(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_feetPivotActive")]
        ///  extern void SET_FEET_PIVOT_ACTIVE (System.Single value);


        /// <summary>
        ///   System.Void set_fireEvents(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_fireEvents")]
        ///  extern void SET_FIRE_EVENTS (System.Boolean value);


        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
        ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// <summary>
        ///   System.Void set_keepAnimatorControllerStateOnDisable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_keepAnimatorControllerStateOnDisable")]
        ///  extern void SET_KEEP_ANIMATOR_CONTROLLER_STATE_ON_DISABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_keepAnimatorStateOnDisable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_keepAnimatorStateOnDisable")]
        ///  extern void SET_KEEP_ANIMATOR_STATE_ON_DISABLE (System.Boolean value);


        /// <summary>
        ///   System.Void set_layersAffectMassCenter(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_layersAffectMassCenter")]
        ///  extern void SET_LAYERS_AFFECT_MASS_CENTER (System.Boolean value);


        /// <summary>
        ///   System.Void set_linearVelocityBlending(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_linearVelocityBlending")]
        ///  extern void SET_LINEAR_VELOCITY_BLENDING (System.Boolean value);


        /// <summary>
        ///   System.Void set_logWarnings(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_logWarnings")]
        ///  extern void SET_LOG_WARNINGS (System.Boolean value);


        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_playbackTime(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_playbackTime")]
        ///  extern void SET_PLAYBACK_TIME (System.Single value);


        /// <summary>
        ///   System.Void set_recorderStartTime(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_recorderStartTime")]
        ///  extern void SET_RECORDER_START_TIME (System.Single value);


        /// <summary>
        ///   System.Void set_recorderStopTime(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_recorderStopTime")]
        ///  extern void SET_RECORDER_STOP_TIME (System.Single value);


        /// <summary>
        ///   System.Void set_rootPosition(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rootPosition")]
        ///  extern void SET_ROOT_POSITION (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_rootPosition_Injected(UnityEngine.Vector3& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rootPosition_Injected")]
        ///  extern void SET_ROOT_POSITION_INJECTED (UnityEngine.Vector3& value);


        /// <summary>
        ///   System.Void set_rootRotation(UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rootRotation")]
        ///  extern void SET_ROOT_ROTATION (UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void set_rootRotation_Injected(UnityEngine.Quaternion& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rootRotation_Injected")]
        ///  extern void SET_ROOT_ROTATION_INJECTED (UnityEngine.Quaternion& value);


        /// <summary>
        ///   System.Void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value)
        /// </summary>
        /// <param name="value">class UnityEngine.RuntimeAnimatorController</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_runtimeAnimatorController")]
        ///  extern void SET_RUNTIME_ANIMATOR_CONTROLLER (nint value);


        /// <summary>
        ///   System.Void set_speed(System.Single value)
        /// </summary>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_speed")]
        ///  extern void SET_SPEED (System.Single value);


        /// <summary>
        ///   System.Void set_stabilizeFeet(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_stabilizeFeet")]
        ///  extern void SET_STABILIZE_FEET (System.Boolean value);


        /// <summary>
        ///   System.Void set_tag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
        ///  extern void SET_TAG (nint value);


        /// <summary>
        ///   System.Void set_updateMode(UnityEngine.AnimatorUpdateMode value)
        /// </summary>
        /// <param name="value">enum UnityEngine.AnimatorUpdateMode</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_updateMode")]
        ///  extern void SET_UPDATE_MODE (UnityEngine.AnimatorUpdateMode value);


        /// <summary>
        ///   System.Void set_writeDefaultValuesOnDisable(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_writeDefaultValuesOnDisable")]
        ///  extern void SET_WRITE_DEFAULT_VALUES_ON_DISABLE (System.Boolean value);


        /// <summary>
        ///   System.Void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="humanBoneId">enum UnityEngine.HumanBodyBones</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBoneLocalRotation")]
        ///  extern void SET_BONE_LOCAL_ROTATION (UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation);


        /// <summary>
        ///   System.Void SetBoneLocalRotationInternal(System.Int32 humanBoneId, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="humanBoneId">struct System.Int32</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBoneLocalRotationInternal")]
        ///  extern void SET_BONE_LOCAL_ROTATION_INTERNAL (System.Int32 humanBoneId, UnityEngine.Quaternion rotation);


        /// <summary>
        ///   System.Void SetBoneLocalRotationInternal_Injected(System.Int32 humanBoneId, UnityEngine.Quaternion& rotation)
        /// </summary>
        /// <param name="humanBoneId">struct System.Int32</param>
        /// <param name="rotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBoneLocalRotationInternal_Injected")]
        ///  extern void SET_BONE_LOCAL_ROTATION_INTERNAL_INJECTED (System.Int32 humanBoneId, UnityEngine.Quaternion& rotation);


        /// <summary>
        ///   System.Void SetBoolID(System.Int32 id, System.Boolean value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBoolID")]
        ///  extern void SET_BOOL_ID (System.Int32 id, System.Boolean value);


        /// <summary>
        ///   System.Void SetBoolString(System.String name, System.Boolean value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBoolString")]
        ///  extern void SET_BOOL_STRING (nint name, System.Boolean value);


        /// <summary>
        ///   System.Void SetFloatID(System.Int32 id, System.Single value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloatID")]
        ///  extern void SET_FLOAT_ID (System.Int32 id, System.Single value);


        /// <summary>
        ///   System.Void SetFloatIDDamp(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <param name="dampTime">struct System.Single</param>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloatIDDamp")]
        ///  extern void SET_FLOAT_ID_DAMP (System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime);


        /// <summary>
        ///   System.Void SetFloatString(System.String name, System.Single value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloatString")]
        ///  extern void SET_FLOAT_STRING (nint name, System.Single value);


        /// <summary>
        ///   System.Void SetFloatStringDamp(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Single</param>
        /// <param name="dampTime">struct System.Single</param>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloatStringDamp")]
        ///  extern void SET_FLOAT_STRING_DAMP (nint name, System.Single value, System.Single dampTime, System.Single deltaTime);


        /// <summary>
        ///   System.Void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalPosition")]
        ///  extern void SET_GOAL_POSITION (UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);


        /// <summary>
        ///   System.Void SetGoalPosition_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalPosition">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalPosition_Injected")]
        ///  extern void SET_GOAL_POSITION_INJECTED (UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3& goalPosition);


        /// <summary>
        ///   System.Void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalRotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalRotation")]
        ///  extern void SET_GOAL_ROTATION (UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);


        /// <summary>
        ///   System.Void SetGoalRotation_Injected(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalRotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalRotation_Injected")]
        ///  extern void SET_GOAL_ROTATION_INJECTED (UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion& goalRotation);


        /// <summary>
        ///   System.Void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, System.Single value)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalWeightPosition")]
        ///  extern void SET_GOAL_WEIGHT_POSITION (UnityEngine.AvatarIKGoal goal, System.Single value);


        /// <summary>
        ///   System.Void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, System.Single value)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetGoalWeightRotation")]
        ///  extern void SET_GOAL_WEIGHT_ROTATION (UnityEngine.AvatarIKGoal goal, System.Single value);


        /// <summary>
        ///   System.Void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="hintPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHintPosition")]
        ///  extern void SET_HINT_POSITION (UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);


        /// <summary>
        ///   System.Void SetHintPosition_Injected(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="hintPosition">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHintPosition_Injected")]
        ///  extern void SET_HINT_POSITION_INJECTED (UnityEngine.AvatarIKHint hint, UnityEngine.Vector3& hintPosition);


        /// <summary>
        ///   System.Void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, System.Single value)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetHintWeightPosition")]
        ///  extern void SET_HINT_WEIGHT_POSITION (UnityEngine.AvatarIKHint hint, System.Single value);


        /// <summary>
        ///   System.Void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="hintPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKHintPosition")]
        ///  extern void SET_IK_HINT_POSITION (UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);


        /// <summary>
        ///   System.Void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, System.Single value)
        /// </summary>
        /// <param name="hint">enum UnityEngine.AvatarIKHint</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKHintPositionWeight")]
        ///  extern void SET_IK_HINT_POSITION_WEIGHT (UnityEngine.AvatarIKHint hint, System.Single value);


        /// <summary>
        ///   System.Void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKPosition")]
        ///  extern void SET_IK_POSITION (UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);


        /// <summary>
        ///   System.Void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKPositionWeight")]
        ///  extern void SET_IK_POSITION_WEIGHT (UnityEngine.AvatarIKGoal goal, System.Single value);


        /// <summary>
        ///   System.Void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="goalRotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKRotation")]
        ///  extern void SET_IK_ROTATION (UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);


        /// <summary>
        ///   System.Void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, System.Single value)
        /// </summary>
        /// <param name="goal">enum UnityEngine.AvatarIKGoal</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIKRotationWeight")]
        ///  extern void SET_IK_ROTATION_WEIGHT (UnityEngine.AvatarIKGoal goal, System.Single value);


        /// <summary>
        ///   System.Void SetIntegerID(System.Int32 id, System.Int32 value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIntegerID")]
        ///  extern void SET_INTEGER_ID (System.Int32 id, System.Int32 value);


        /// <summary>
        ///   System.Void SetIntegerString(System.String name, System.Int32 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetIntegerString")]
        ///  extern void SET_INTEGER_STRING (nint name, System.Int32 value);


        /// <summary>
        ///   System.Void SetLayerWeight(System.Int32 layerIndex, System.Single weight)
        /// </summary>
        /// <param name="layerIndex">struct System.Int32</param>
        /// <param name="weight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLayerWeight")]
        ///  extern void SET_LAYER_WEIGHT (System.Int32 layerIndex, System.Single weight);


        /// <summary>
        ///   System.Void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition)
        /// </summary>
        /// <param name="lookAtPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtPosition")]
        ///  extern void SET_LOOK_AT_POSITION (UnityEngine.Vector3 lookAtPosition);


        /// <summary>
        ///   System.Void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition)
        /// </summary>
        /// <param name="lookAtPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtPositionInternal")]
        ///  extern void SET_LOOK_AT_POSITION_INTERNAL (UnityEngine.Vector3 lookAtPosition);


        /// <summary>
        ///   System.Void SetLookAtPositionInternal_Injected(UnityEngine.Vector3& lookAtPosition)
        /// </summary>
        /// <param name="lookAtPosition">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtPositionInternal_Injected")]
        ///  extern void SET_LOOK_AT_POSITION_INTERNAL_INJECTED (UnityEngine.Vector3& lookAtPosition);


        /// <summary>
        ///   System.Void SetLookAtWeightInternal(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <param name="bodyWeight">struct System.Single</param>
        /// <param name="headWeight">struct System.Single</param>
        /// <param name="eyesWeight">struct System.Single</param>
        /// <param name="clampWeight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeightInternal")]
        ///  extern void SET_LOOK_AT_WEIGHT_INTERNAL (System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight);


        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


        /// <summary>
        ///   System.Void SetTarget(UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime)
        /// </summary>
        /// <param name="targetIndex">enum UnityEngine.AvatarTarget</param>
        /// <param name="targetNormalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTarget")]
        ///  extern void SET_TARGET (UnityEngine.AvatarTarget targetIndex, System.Single targetNormalizedTime);


        /// <summary>
        ///   System.Void SetTriggerID(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTriggerID")]
        ///  extern void SET_TRIGGER_ID (System.Int32 id);


        /// <summary>
        ///   System.Void SetTriggerString(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTriggerString")]
        ///  extern void SET_TRIGGER_STRING (nint name);


        /// <summary>
        ///   System.Void StartPlayback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartPlayback")]
        ///  extern void START_PLAYBACK ();


        /// <summary>
        ///   System.Void StartRecording(System.Int32 frameCount)
        /// </summary>
        /// <param name="frameCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StartRecording")]
        ///  extern void START_RECORDING (System.Int32 frameCount);


        /// <summary>
        ///   System.Void StopPlayback()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopPlayback")]
        ///  extern void STOP_PLAYBACK ();


        /// <summary>
        ///   System.Void StopRecording()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StopRecording")]
        ///  extern void STOP_RECORDING ();


        /// <summary>
        /// static  System.Int32 StringToHash(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("StringToHash")]
        /// static extern System.Int32 STRING_TO_HASH (nint name);


        /// <summary>
        ///   System.Void Update(System.Single deltaTime)
        /// </summary>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Update")]
        ///  extern void UPDATE (System.Single deltaTime);


        /// <summary>
        ///   System.Void WriteDefaultPose()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WriteDefaultPose")]
        ///  extern void WRITE_DEFAULT_POSE ();


        /// <summary>
        ///   System.Void WriteDefaultValues()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("WriteDefaultValues")]
        ///  extern void WRITE_DEFAULT_VALUES ();



        /// <summary>
        ///   System.Void InterruptMatchTarget()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InterruptMatchTarget", Search = typeof(Search_Animator))]
        ///  extern void INTERRUPT_MATCH_TARGET_00 ();


        /// <summary>
        ///   System.Void InterruptMatchTarget(System.Boolean completeMatch)
        /// </summary>
        /// <param name="completeMatch">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InterruptMatchTarget", Search = typeof(Search_Animator))]
        ///  extern void INTERRUPT_MATCH_TARGET_01 (System.Boolean completeMatch);


        /// <summary>
        ///   System.Boolean IsParameterControlledByCurve(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsParameterControlledByCurve", Search = typeof(Search_Animator))]
        ///  extern System.Boolean IS_PARAMETER_CONTROLLED_BY_CURVE_00 (nint name);


        /// <summary>
        ///   System.Boolean IsParameterControlledByCurve(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsParameterControlledByCurve", Search = typeof(Search_Animator))]
        ///  extern System.Boolean IS_PARAMETER_CONTROLLED_BY_CURVE_01 (System.Int32 id);


        /// <summary>
        ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
        /// </summary>
        /// <param name="matchPosition">struct UnityEngine.Vector3</param>
        /// <param name="matchRotation">struct UnityEngine.Quaternion</param>
        /// <param name="targetBodyPart">struct System.Int32</param>
        /// <param name="weightMask">struct UnityEngine.MatchTargetWeightMask</param>
        /// <param name="startNormalizedTime">struct System.Single</param>
        /// <param name="targetNormalizedTime">struct System.Single</param>
        /// <param name="completeMatch">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MatchTarget", Search = typeof(Search_Animator))]
        ///  extern void MATCH_TARGET_00 (UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch);


        /// <summary>
        ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime)
        /// </summary>
        /// <param name="matchPosition">struct UnityEngine.Vector3</param>
        /// <param name="matchRotation">struct UnityEngine.Quaternion</param>
        /// <param name="targetBodyPart">enum UnityEngine.AvatarTarget</param>
        /// <param name="weightMask">struct UnityEngine.MatchTargetWeightMask</param>
        /// <param name="startNormalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MatchTarget", Search = typeof(Search_Animator))]
        ///  extern void MATCH_TARGET_01 (UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime);


        /// <summary>
        ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime)
        /// </summary>
        /// <param name="matchPosition">struct UnityEngine.Vector3</param>
        /// <param name="matchRotation">struct UnityEngine.Quaternion</param>
        /// <param name="targetBodyPart">enum UnityEngine.AvatarTarget</param>
        /// <param name="weightMask">struct UnityEngine.MatchTargetWeightMask</param>
        /// <param name="startNormalizedTime">struct System.Single</param>
        /// <param name="targetNormalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MatchTarget", Search = typeof(Search_Animator))]
        ///  extern void MATCH_TARGET_02 (UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime);


        /// <summary>
        ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
        /// </summary>
        /// <param name="matchPosition">struct UnityEngine.Vector3</param>
        /// <param name="matchRotation">struct UnityEngine.Quaternion</param>
        /// <param name="targetBodyPart">enum UnityEngine.AvatarTarget</param>
        /// <param name="weightMask">struct UnityEngine.MatchTargetWeightMask</param>
        /// <param name="startNormalizedTime">struct System.Single</param>
        /// <param name="targetNormalizedTime">struct System.Single</param>
        /// <param name="completeMatch">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MatchTarget", Search = typeof(Search_Animator))]
        ///  extern void MATCH_TARGET_03 (UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch);


        /// <summary>
        ///   System.Void Play(System.String stateName, System.Int32 layer)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", Search = typeof(Search_Animator))]
        ///  extern void PLAY_00 (nint stateName, System.Int32 layer);


        /// <summary>
        ///   System.Void Play(System.String stateName)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", Search = typeof(Search_Animator))]
        ///  extern void PLAY_01 (nint stateName);


        /// <summary>
        ///   System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", Search = typeof(Search_Animator))]
        ///  extern void PLAY_02 (nint stateName, System.Int32 layer, System.Single normalizedTime);


        /// <summary>
        ///   System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="normalizedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", CallConvs = [typeof(CallConvCdecl)], Search = typeof(Search_Animator))]
        extern void PLAY_03(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime);


        /// <summary>
        ///   System.Void Play(System.Int32 stateNameHash, System.Int32 layer)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", Search = typeof(Search_Animator))]
        ///  extern void PLAY_04 (System.Int32 stateNameHash, System.Int32 layer);


        /// <summary>
        ///   System.Void Play(System.Int32 stateNameHash)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Play", Search = typeof(Search_Animator))]
        ///  extern void PLAY_05 (System.Int32 stateNameHash);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.String stateName, System.Int32 layer)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_00 (nint stateName, System.Int32 layer);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.String stateName)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_01 (nint stateName);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime)
        /// </summary>
        /// <param name="stateName">class System.String</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_02 (nint stateName, System.Int32 layer, System.Single fixedTime);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <param name="layer">struct System.Int32</param>
        /// <param name="fixedTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_03 (System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <param name="layer">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_04 (System.Int32 stateNameHash, System.Int32 layer);


        /// <summary>
        ///   System.Void PlayInFixedTime(System.Int32 stateNameHash)
        /// </summary>
        /// <param name="stateNameHash">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("PlayInFixedTime", Search = typeof(Search_Animator))]
        ///  extern void PLAY_IN_FIXED_TIME_05 (System.Int32 stateNameHash);


        /// <summary>
        ///   System.Void Rebind()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rebind", Search = typeof(Search_Animator))]
        ///  extern void REBIND_00 ();


        /// <summary>
        ///   System.Void Rebind(System.Boolean writeDefaultValues)
        /// </summary>
        /// <param name="writeDefaultValues">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rebind", Search = typeof(Search_Animator))]
        ///  extern void REBIND_01 (System.Boolean writeDefaultValues);


        /// <summary>
        ///   System.Void ResetTrigger(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetTrigger", Search = typeof(Search_Animator))]
        ///  extern void RESET_TRIGGER_00 (nint name);


        /// <summary>
        ///   System.Void ResetTrigger(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ResetTrigger", Search = typeof(Search_Animator))]
        ///  extern void RESET_TRIGGER_01 (System.Int32 id);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_01 (nint methodName);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_02 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_UPWARDS_00 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_UPWARDS_01 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_UPWARDS_02 (nint methodName);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Animator))]
        ///  extern void SEND_MESSAGE_UPWARDS_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SetBool(System.String name, System.Boolean value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBool", Search = typeof(Search_Animator))]
        ///  extern void SET_BOOL_00 (nint name, System.Boolean value);


        /// <summary>
        ///   System.Void SetBool(System.Int32 id, System.Boolean value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetBool", Search = typeof(Search_Animator))]
        ///  extern void SET_BOOL_01 (System.Int32 id, System.Boolean value);


        /// <summary>
        ///   System.Void SetFloat(System.String name, System.Single value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloat", Search = typeof(Search_Animator))]
        ///  extern void SET_FLOAT_00 (nint name, System.Single value);


        /// <summary>
        ///   System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Single</param>
        /// <param name="dampTime">struct System.Single</param>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloat", Search = typeof(Search_Animator))]
        ///  extern void SET_FLOAT_01 (nint name, System.Single value, System.Single dampTime, System.Single deltaTime);


        /// <summary>
        ///   System.Void SetFloat(System.Int32 id, System.Single value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloat", Search = typeof(Search_Animator))]
        ///  extern void SET_FLOAT_02 (System.Int32 id, System.Single value);


        /// <summary>
        ///   System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Single</param>
        /// <param name="dampTime">struct System.Single</param>
        /// <param name="deltaTime">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetFloat", Search = typeof(Search_Animator))]
        ///  extern void SET_FLOAT_03 (System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime);


        /// <summary>
        ///   System.Void SetInteger(System.String name, System.Int32 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInteger", Search = typeof(Search_Animator))]
        ///  extern void SET_INTEGER_00 (nint name, System.Int32 value);


        /// <summary>
        ///   System.Void SetInteger(System.Int32 id, System.Int32 value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetInteger", Search = typeof(Search_Animator))]
        ///  extern void SET_INTEGER_01 (System.Int32 id, System.Int32 value);


        /// <summary>
        ///   System.Void SetLookAtWeight(System.Single weight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeight", Search = typeof(Search_Animator))]
        ///  extern void SET_LOOK_AT_WEIGHT_00 (System.Single weight);


        /// <summary>
        ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <param name="bodyWeight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeight", Search = typeof(Search_Animator))]
        ///  extern void SET_LOOK_AT_WEIGHT_01 (System.Single weight, System.Single bodyWeight);


        /// <summary>
        ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <param name="bodyWeight">struct System.Single</param>
        /// <param name="headWeight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeight", Search = typeof(Search_Animator))]
        ///  extern void SET_LOOK_AT_WEIGHT_02 (System.Single weight, System.Single bodyWeight, System.Single headWeight);


        /// <summary>
        ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <param name="bodyWeight">struct System.Single</param>
        /// <param name="headWeight">struct System.Single</param>
        /// <param name="eyesWeight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeight", Search = typeof(Search_Animator))]
        ///  extern void SET_LOOK_AT_WEIGHT_03 (System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight);


        /// <summary>
        ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
        /// </summary>
        /// <param name="weight">struct System.Single</param>
        /// <param name="bodyWeight">struct System.Single</param>
        /// <param name="headWeight">struct System.Single</param>
        /// <param name="eyesWeight">struct System.Single</param>
        /// <param name="clampWeight">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLookAtWeight", Search = typeof(Search_Animator))]
        ///  extern void SET_LOOK_AT_WEIGHT_04 (System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight);


        /// <summary>
        ///   System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetQuaternion", Search = typeof(Search_Animator))]
        ///  extern void SET_QUATERNION_00 (nint name, UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetQuaternion", Search = typeof(Search_Animator))]
        ///  extern void SET_QUATERNION_01 (System.Int32 id, UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void SetTrigger(System.String name)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTrigger", Search = typeof(Search_Animator))]
        ///  extern void SET_TRIGGER_00 (nint name);


        /// <summary>
        ///   System.Void SetTrigger(System.Int32 id)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetTrigger", CallConvs = [typeof(CallConvCdecl)], Search = typeof(Search_Animator))]
        extern void SET_TRIGGER_01(System.Int32 id);


        /// <summary>
        ///   System.Void SetVector(System.String name, UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="name">class System.String</param>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVector", Search = typeof(Search_Animator))]
        ///  extern void SET_VECTOR_00 (nint name, UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="id">struct System.Int32</param>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetVector", Search = typeof(Search_Animator))]
        ///  extern void SET_VECTOR_01 (System.Int32 id, UnityEngine.Vector3 value);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_Animator))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_Animator))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="component">class UnityEngine.Component&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_Animator))]
        ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// <param name="component">class T&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_Animator))]
        ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);


        public static partial class Search_Animator
        {
            /// 
            ///     

            /// <summary>
            ///   System.Void InterruptMatchTarget()
            /// </summary>
            /// public static bool INTERRUPT_MATCH_TARGET_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InterruptMatchTarget");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void InterruptMatchTarget(System.Boolean completeMatch)
            /// </summary>
            /// public static bool INTERRUPT_MATCH_TARGET_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InterruptMatchTarget", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean IsParameterControlledByCurve(System.String name)
            /// </summary>
            /// public static bool IS_PARAMETER_CONTROLLED_BY_CURVE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsParameterControlledByCurve", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean IsParameterControlledByCurve(System.Int32 id)
            /// </summary>
            /// public static bool IS_PARAMETER_CONTROLLED_BY_CURVE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsParameterControlledByCurve", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, System.Int32 targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
            /// </summary>
            /// public static bool MATCH_TARGET_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MatchTarget", "UnityEngine.Vector3", "UnityEngine.Quaternion", "System.Int32", "UnityEngine.MatchTargetWeightMask", "System.Single", "System.Single", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime)
            /// </summary>
            /// public static bool MATCH_TARGET_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MatchTarget", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.AvatarTarget", "UnityEngine.MatchTargetWeightMask", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime)
            /// </summary>
            /// public static bool MATCH_TARGET_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MatchTarget", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.AvatarTarget", "UnityEngine.MatchTargetWeightMask", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, System.Single startNormalizedTime, System.Single targetNormalizedTime, System.Boolean completeMatch)
            /// </summary>
            /// public static bool MATCH_TARGET_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "MatchTarget", "UnityEngine.Vector3", "UnityEngine.Quaternion", "UnityEngine.AvatarTarget", "UnityEngine.MatchTargetWeightMask", "System.Single", "System.Single", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.String stateName, System.Int32 layer)
            /// </summary>
            /// public static bool PLAY_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.String", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.String stateName)
            /// </summary>
            /// public static bool PLAY_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.String stateName, System.Int32 layer, System.Single normalizedTime)
            /// </summary>
            /// public static bool PLAY_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.String", "System.Int32", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.Int32 stateNameHash, System.Int32 layer, System.Single normalizedTime)
            /// </summary>
            public static bool PLAY_03(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.Int32", "System.Int32", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.Int32 stateNameHash, System.Int32 layer)
            /// </summary>
            /// public static bool PLAY_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Play(System.Int32 stateNameHash)
            /// </summary>
            /// public static bool PLAY_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Play", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.String stateName, System.Int32 layer)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.String", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.String stateName)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.String stateName, System.Int32 layer, System.Single fixedTime)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.String", "System.Int32", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer, System.Single fixedTime)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.Int32", "System.Int32", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.Int32 stateNameHash, System.Int32 layer)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void PlayInFixedTime(System.Int32 stateNameHash)
            /// </summary>
            /// public static bool PLAY_IN_FIXED_TIME_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "PlayInFixedTime", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Rebind()
            /// </summary>
            /// public static bool REBIND_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rebind");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void Rebind(System.Boolean writeDefaultValues)
            /// </summary>
            /// public static bool REBIND_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rebind", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ResetTrigger(System.String name)
            /// </summary>
            /// public static bool RESET_TRIGGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ResetTrigger", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void ResetTrigger(System.Int32 id)
            /// </summary>
            /// public static bool RESET_TRIGGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ResetTrigger", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value)
            /// </summary>
            /// public static bool SEND_MESSAGE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessage(System.String methodName)
            /// </summary>
            /// public static bool SEND_MESSAGE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// public static bool SEND_MESSAGE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// public static bool SEND_MESSAGE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessage", "System.String", "UnityEngine.SendMessageOptions");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// public static bool SEND_MESSAGE_UPWARDS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object", "UnityEngine.SendMessageOptions");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
            /// </summary>
            /// public static bool SEND_MESSAGE_UPWARDS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "System.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName)
            /// </summary>
            /// public static bool SEND_MESSAGE_UPWARDS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
            /// </summary>
            /// public static bool SEND_MESSAGE_UPWARDS_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SendMessageUpwards", "System.String", "UnityEngine.SendMessageOptions");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetBool(System.String name, System.Boolean value)
            /// </summary>
            /// public static bool SET_BOOL_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBool", "System.String", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetBool(System.Int32 id, System.Boolean value)
            /// </summary>
            /// public static bool SET_BOOL_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetBool", "System.Int32", "System.Boolean");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetFloat(System.String name, System.Single value)
            /// </summary>
            /// public static bool SET_FLOAT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.String", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetFloat(System.String name, System.Single value, System.Single dampTime, System.Single deltaTime)
            /// </summary>
            /// public static bool SET_FLOAT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.String", "System.Single", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetFloat(System.Int32 id, System.Single value)
            /// </summary>
            /// public static bool SET_FLOAT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.Int32", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetFloat(System.Int32 id, System.Single value, System.Single dampTime, System.Single deltaTime)
            /// </summary>
            /// public static bool SET_FLOAT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetFloat", "System.Int32", "System.Single", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetInteger(System.String name, System.Int32 value)
            /// </summary>
            /// public static bool SET_INTEGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetInteger", "System.String", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetInteger(System.Int32 id, System.Int32 value)
            /// </summary>
            /// public static bool SET_INTEGER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetInteger", "System.Int32", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLookAtWeight(System.Single weight)
            /// </summary>
            /// public static bool SET_LOOK_AT_WEIGHT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLookAtWeight", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight)
            /// </summary>
            /// public static bool SET_LOOK_AT_WEIGHT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLookAtWeight", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight)
            /// </summary>
            /// public static bool SET_LOOK_AT_WEIGHT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLookAtWeight", "System.Single", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight)
            /// </summary>
            /// public static bool SET_LOOK_AT_WEIGHT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLookAtWeight", "System.Single", "System.Single", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetLookAtWeight(System.Single weight, System.Single bodyWeight, System.Single headWeight, System.Single eyesWeight, System.Single clampWeight)
            /// </summary>
            /// public static bool SET_LOOK_AT_WEIGHT_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetLookAtWeight", "System.Single", "System.Single", "System.Single", "System.Single", "System.Single");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetQuaternion(System.String name, UnityEngine.Quaternion value)
            /// </summary>
            /// public static bool SET_QUATERNION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetQuaternion", "System.String", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetQuaternion(System.Int32 id, UnityEngine.Quaternion value)
            /// </summary>
            /// public static bool SET_QUATERNION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetQuaternion", "System.Int32", "UnityEngine.Quaternion");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetTrigger(System.String name)
            /// </summary>
            /// public static bool SET_TRIGGER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTrigger", "System.String");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetTrigger(System.Int32 id)
            /// </summary>
            public static bool SET_TRIGGER_01(Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                => Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetTrigger", "System.Int32");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetVector(System.String name, UnityEngine.Vector3 value)
            /// </summary>
            /// public static bool SET_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVector", "System.String", "UnityEngine.Vector3");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Void SetVector(System.Int32 id, UnityEngine.Vector3 value)
            /// </summary>
            /// public static bool SET_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetVector", "System.Int32", "UnityEngine.Vector3");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// public static bool TO_STRING_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString");
            ///     
            ///  
            /// 


            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// public static bool TO_STRING_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ToString", "UnityEngine.Object");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// public static bool TRY_GET_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "System.Type", "UnityEngine.Component&");
            ///     
            ///  
            /// 


            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// public static bool TRY_GET_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
            ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TryGetComponent", "T&");
            ///     
            ///  
            /// 
            /// 
        }

    }


}