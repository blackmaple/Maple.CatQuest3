
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.RawDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3
{


    /// <summary>
    /// class ["UnityEngine.CoreModule"."UnityEngine"."Transform"]
    /// [UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// [System.Collections.IEnumerable]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101], 0x02000299U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101], [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101], [84, 114, 97, 110, 115, 102, 111, 114, 109])]

    //  struct static System.Int32 OffsetOfInstanceIDInCPlusPlusObject
    //  [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"OffsetOfInstanceIDInCPlusPlusObject", "OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT", true)]

    // struct 0x8 System.IntPtr m_CachedPtr
    // [MonoCollectorSearchFieldAttribute(typeof(System.IntPtr),"m_CachedPtr", "M_CACHED_PTR")]
    public partial class Transform
    {
        //public const string Const_ImageName = "UnityEngine.CoreModule";
        //public static byte[] Static_ImageName { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101, 46, 67, 111, 114, 101, 77, 111, 100, 117, 108, 101];

        //public const string Const_Namespace = "UnityEngine";
        //public static byte[] Static_Namespace { get; } = [85, 110, 105, 116, 121, 69, 110, 103, 105, 110, 101];

        //public const string Const_ClassName = "Transform";
        //public static byte[] Static_ClassName { get; } = [84, 114, 97, 110, 115, 102, 111, 114, 109];

        //public const uint Const_TypeToken = 0x02000299U;




        /// <summary>
        /// class System.String objectIsNullMessage "The Object you want to instantiate is null."
        /// </summary>
        /// public const nint OBJECT_IS_NULL_MESSAGE=>"The Object you want to instantiate is null.";

        /// <summary>
        /// class System.String cloneDestroyedMessage "Instantiate failed because the clone was destroyed during creati"
        /// </summary>
        /// public const nint CLONE_DESTROYED_MESSAGE=>"Instantiate failed because the clone was destroyed during creati";




        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Transform(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Transform(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Transform obj) => obj._ptr;
            public static implicit operator bool(Ptr_Transform obj) => obj.Valid();

            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule"."UnityEngine"."Transform"]
    /// </summary>
    public partial class Transform
    {



        /// <summary>
        /// static  System.Void .cctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
        /// static extern void .CCTOR ();


        /// <summary>
        /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
        /// </summary>
        /// <param name="arg">class System.Object</param>
        /// <param name="message">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckNullArgument")]
        /// static extern void CHECK_NULL_ARGUMENT (nint arg, nint message);


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
        /// static  System.Boolean CurrentThreadIsMainThread()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CurrentThreadIsMainThread")]
        /// static extern System.Boolean CURRENT_THREAD_IS_MAIN_THREAD ();


        /// <summary>
        ///   System.Void DetachChildren()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DetachChildren")]
        ///  extern void DETACH_CHILDREN ();


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
        ///   UnityEngine.Transform Find(System.String n)
        /// </summary>
        /// <param name="n">class System.String</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Find")]
        ///  extern nint FIND (nint n);


        /// <summary>
        ///   UnityEngine.Transform FindChild(System.String n)
        /// </summary>
        /// <param name="n">class System.String</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindChild")]
        ///  extern nint FIND_CHILD (nint n);


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
        /// static  UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, System.String path, System.Boolean isActiveOnly)
        /// </summary>
        /// <param name="transform">class UnityEngine.Transform</param>
        /// <param name="path">class System.String</param>
        /// <param name="isActiveOnly">struct System.Boolean</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindRelativeTransformWithPath")]
        /// static extern nint FIND_RELATIVE_TRANSFORM_WITH_PATH (nint transform, nint path, System.Boolean isActiveOnly);


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
        ///   System.Int32 get_childCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_childCount")]
        ///  extern System.Int32 GET_CHILD_COUNT ();


        /// <summary>
        ///   System.Boolean get_constrainProportionsScale()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_constrainProportionsScale")]
        ///  extern System.Boolean GET_CONSTRAIN_PROPORTIONS_SCALE ();


        /// <summary>
        ///   UnityEngine.Vector3 get_eulerAngles()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_eulerAngles")]
        ///  extern UnityEngine.Vector3 GET_EULER_ANGLES ();


        /// <summary>
        ///   UnityEngine.Vector3 get_forward()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_forward")]
        ///  extern UnityEngine.Vector3 GET_FORWARD ();


        /// <summary>
        ///   UnityEngine.GameObject get_gameObject()
        /// </summary>
        /// <returns>class UnityEngine.GameObject</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameObject")]
        ///  extern nint GET_GAME_OBJECT ();


        /// <summary>
        ///   System.Boolean get_hasChanged()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasChanged")]
        ///  extern System.Boolean GET_HAS_CHANGED ();


        /// <summary>
        ///   UnityEngine.HideFlags get_hideFlags()
        /// </summary>
        /// <returns>enum UnityEngine.HideFlags</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hideFlags")]
        ///  extern UnityEngine.HideFlags GET_HIDE_FLAGS ();


        /// <summary>
        ///   System.Int32 get_hierarchyCapacity()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hierarchyCapacity")]
        ///  extern System.Int32 GET_HIERARCHY_CAPACITY ();


        /// <summary>
        ///   System.Int32 get_hierarchyCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hierarchyCount")]
        ///  extern System.Int32 GET_HIERARCHY_COUNT ();


        /// <summary>
        ///   UnityEngine.Vector3 get_localEulerAngles()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localEulerAngles")]
        ///  extern UnityEngine.Vector3 GET_LOCAL_EULER_ANGLES ();


        /// <summary>
        ///   UnityEngine.Vector3 get_localPosition()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localPosition")]
        ///  extern UnityEngine.Vector3 GET_LOCAL_POSITION ();


        /// <summary>
        ///   System.Void get_localPosition_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localPosition_Injected")]
        ///  extern void GET_LOCAL_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Quaternion get_localRotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localRotation")]
        ///  extern UnityEngine.Quaternion GET_LOCAL_ROTATION ();


        /// <summary>
        ///   System.Void get_localRotation_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localRotation_Injected")]
        ///  extern void GET_LOCAL_ROTATION_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   UnityEngine.Vector3 get_localScale()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localScale")]
        ///  extern UnityEngine.Vector3 GET_LOCAL_SCALE ();


        /// <summary>
        ///   System.Void get_localScale_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localScale_Injected")]
        ///  extern void GET_LOCAL_SCALE_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Matrix4x4 get_localToWorldMatrix()
        /// </summary>
        /// <returns>struct UnityEngine.Matrix4x4</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localToWorldMatrix")]
        ///  extern UnityEngine.Matrix4x4 GET_LOCAL_TO_WORLD_MATRIX ();


        /// <summary>
        ///   System.Void get_localToWorldMatrix_Injected(UnityEngine.Matrix4x4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Matrix4x4&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_localToWorldMatrix_Injected")]
        ///  extern void GET_LOCAL_TO_WORLD_MATRIX_INJECTED (UnityEngine.Matrix4x4& ret);


        /// <summary>
        ///   UnityEngine.Vector3 get_lossyScale()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lossyScale")]
        ///  extern UnityEngine.Vector3 GET_LOSSY_SCALE ();


        /// <summary>
        ///   System.Void get_lossyScale_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lossyScale_Injected")]
        ///  extern void GET_LOSSY_SCALE_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.String get_name()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_name")]
        ///  extern nint GET_NAME ();


        /// <summary>
        ///   UnityEngine.Transform get_parent()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_parent")]
        ///  extern nint GET_PARENT ();


        /// <summary>
        ///   UnityEngine.Transform get_parentInternal()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_parentInternal")]
        ///  extern nint GET_PARENT_INTERNAL ();


        /// <summary>
        ///   UnityEngine.Vector3 get_position()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_position", CallConvs = [typeof(CallConvCdecl)])]
        extern void GET_POSITION(out REF_MONO_VECTOR3 data);


        /// <summary>
        ///   System.Void get_position_Injected(UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_position_Injected")]
        ///  extern void GET_POSITION_INJECTED (UnityEngine.Vector3& ret);


        /// <summary>
        ///   UnityEngine.Vector3 get_right()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_right")]
        ///  extern UnityEngine.Vector3 GET_RIGHT ();


        /// <summary>
        ///   UnityEngine.Transform get_root()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_root")]
        ///  extern nint GET_ROOT ();


        /// <summary>
        ///   UnityEngine.Quaternion get_rotation()
        /// </summary>
        /// <returns>struct UnityEngine.Quaternion</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rotation")]
        ///  extern UnityEngine.Quaternion GET_ROTATION ();


        /// <summary>
        ///   System.Void get_rotation_Injected(UnityEngine.Quaternion& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rotation_Injected")]
        ///  extern void GET_ROTATION_INJECTED (UnityEngine.Quaternion& ret);


        /// <summary>
        ///   UnityEngine.RotationOrder get_rotationOrder()
        /// </summary>
        /// <returns>enum UnityEngine.RotationOrder</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_rotationOrder")]
        ///  extern UnityEngine.RotationOrder GET_ROTATION_ORDER ();


        /// <summary>
        ///   System.String get_tag()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_tag")]
        ///  extern nint GET_TAG ();


        /// <summary>
        ///   UnityEngine.Transform get_transform()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_transform")]
        ///  extern nint GET_TRANSFORM ();


        /// <summary>
        ///   UnityEngine.Vector3 get_up()
        /// </summary>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_up")]
        ///  extern UnityEngine.Vector3 GET_UP ();


        /// <summary>
        ///   UnityEngine.Matrix4x4 get_worldToLocalMatrix()
        /// </summary>
        /// <returns>struct UnityEngine.Matrix4x4</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldToLocalMatrix")]
        ///  extern UnityEngine.Matrix4x4 GET_WORLD_TO_LOCAL_MATRIX ();


        /// <summary>
        ///   System.Void get_worldToLocalMatrix_Injected(UnityEngine.Matrix4x4& ret)
        /// </summary>
        /// <param name="ret">struct UnityEngine.Matrix4x4&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_worldToLocalMatrix_Injected")]
        ///  extern void GET_WORLD_TO_LOCAL_MATRIX_INJECTED (UnityEngine.Matrix4x4& ret);


        /// <summary>
        ///   System.IntPtr GetCachedPtr()
        /// </summary>
        /// <returns>struct System.IntPtr</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCachedPtr")]
        ///  extern System.IntPtr GET_CACHED_PTR ();


        /// <summary>
        ///   UnityEngine.Transform GetChild(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetChild")]
        ///  extern nint GET_CHILD (System.Int32 index);


        /// <summary>
        ///   System.Int32 GetChildCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetChildCount")]
        ///  extern System.Int32 GET_CHILD_COUNT ();


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
        ///   System.Collections.IEnumerator GetEnumerator()
        /// </summary>
        /// <returns>interface System.Collections.IEnumerator</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetEnumerator")]
        ///  extern nint GET_ENUMERATOR ();


        /// <summary>
        ///   System.Int32 GetHashCode()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetHashCode")]
        ///  extern System.Int32 GET_HASH_CODE ();


        /// <summary>
        ///   System.Int32 GetInstanceID()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetInstanceID")]
        ///  extern System.Int32 GET_INSTANCE_ID ();


        /// <summary>
        ///   UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order)
        /// </summary>
        /// <param name="order">enum UnityEngine.RotationOrder</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalEulerAngles")]
        ///  extern UnityEngine.Vector3 GET_LOCAL_EULER_ANGLES (UnityEngine.RotationOrder order);


        /// <summary>
        ///   System.Void GetLocalEulerAngles_Injected(UnityEngine.RotationOrder order, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="order">enum UnityEngine.RotationOrder</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalEulerAngles_Injected")]
        ///  extern void GET_LOCAL_EULER_ANGLES_INJECTED (UnityEngine.RotationOrder order, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Void GetLocalPositionAndRotation(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation)
        /// </summary>
        /// <param name="localPosition">struct UnityEngine.Vector3&</param>
        /// <param name="localRotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetLocalPositionAndRotation")]
        ///  extern void GET_LOCAL_POSITION_AND_ROTATION (UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation);


        /// <summary>
        /// static  System.String GetName(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetName")]
        /// static extern nint GET_NAME (nint obj);


        /// <summary>
        /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetOffsetOfInstanceIDInCPlusPlusObject")]
        /// static extern System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT ();


        /// <summary>
        ///   UnityEngine.Transform GetParent()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetParent")]
        ///  extern nint GET_PARENT ();


        /// <summary>
        ///   System.Void GetPositionAndRotation(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3&</param>
        /// <param name="rotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPositionAndRotation")]
        ///  extern void GET_POSITION_AND_ROTATION (UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation);


        /// <summary>
        ///   UnityEngine.Transform GetRoot()
        /// </summary>
        /// <returns>class UnityEngine.Transform</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRoot")]
        ///  extern nint GET_ROOT ();


        /// <summary>
        ///   System.Int32 GetRotationOrderInternal()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetRotationOrderInternal")]
        ///  extern System.Int32 GET_ROTATION_ORDER_INTERNAL ();


        /// <summary>
        ///   System.Int32 GetSiblingIndex()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSiblingIndex")]
        ///  extern System.Int32 GET_SIBLING_INDEX ();


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
        ///   System.Int32 internal_getHierarchyCapacity()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("internal_getHierarchyCapacity")]
        ///  extern System.Int32 INTERNAL_GET_HIERARCHY_CAPACITY ();


        /// <summary>
        ///   System.Int32 internal_getHierarchyCount()
        /// </summary>
        /// <returns>struct System.Int32</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("internal_getHierarchyCount")]
        ///  extern System.Int32 INTERNAL_GET_HIERARCHY_COUNT ();


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
        ///   System.Void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp)
        /// </summary>
        /// <param name="worldPosition">struct UnityEngine.Vector3</param>
        /// <param name="worldUp">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_LookAt")]
        ///  extern void INTERNAL_LOOK_AT (UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);


        /// <summary>
        ///   System.Void Internal_LookAt_Injected(UnityEngine.Vector3& worldPosition, UnityEngine.Vector3& worldUp)
        /// </summary>
        /// <param name="worldPosition">struct UnityEngine.Vector3&</param>
        /// <param name="worldUp">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Internal_LookAt_Injected")]
        ///  extern void INTERNAL_LOOK_AT_INJECTED (UnityEngine.Vector3& worldPosition, UnityEngine.Vector3& worldUp);


        /// <summary>
        ///   System.Void internal_setHierarchyCapacity(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("internal_setHierarchyCapacity")]
        ///  extern void INTERNAL_SET_HIERARCHY_CAPACITY (System.Int32 value);


        /// <summary>
        ///   System.Void InverseTransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="direction">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirection_Injected")]
        ///  extern void INVERSE_TRANSFORM_DIRECTION_INJECTED (UnityEngine.Vector3& direction, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Void InverseTransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoint_Injected")]
        ///  extern void INVERSE_TRANSFORM_POINT_INJECTED (UnityEngine.Vector3& position, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Void InverseTransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="vector">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVector_Injected")]
        ///  extern void INVERSE_TRANSFORM_VECTOR_INJECTED (UnityEngine.Vector3& vector, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Boolean IsChildOf(UnityEngine.Transform parent)
        /// </summary>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsChildOf")]
        ///  extern System.Boolean IS_CHILD_OF (nint parent);


        /// <summary>
        ///   System.Boolean IsConstrainProportionsScale()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsConstrainProportionsScale")]
        ///  extern System.Boolean IS_CONSTRAIN_PROPORTIONS_SCALE ();


        /// <summary>
        /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
        /// </summary>
        /// <param name="o">class UnityEngine.Object</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNativeObjectAlive")]
        /// static extern System.Boolean IS_NATIVE_OBJECT_ALIVE (nint o);


        /// <summary>
        ///   System.Boolean IsNonUniformScaleTransform()
        /// </summary>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsNonUniformScaleTransform")]
        ///  extern System.Boolean IS_NON_UNIFORM_SCALE_TRANSFORM ();


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
        ///   System.Void MoveAfterSibling(UnityEngine.Transform transform, System.Boolean notifyEditorAndMarkDirty)
        /// </summary>
        /// <param name="transform">class UnityEngine.Transform</param>
        /// <param name="notifyEditorAndMarkDirty">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("MoveAfterSibling")]
        ///  extern void MOVE_AFTER_SIBLING (nint transform, System.Boolean notifyEditorAndMarkDirty);


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
        ///   System.Void RotateAround_Injected(UnityEngine.Vector3& axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3&</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAround_Injected")]
        ///  extern void ROTATE_AROUND_INJECTED (UnityEngine.Vector3& axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAroundInternal(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAroundInternal")]
        ///  extern void ROTATE_AROUND_INTERNAL (UnityEngine.Vector3 axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAroundInternal_Injected(UnityEngine.Vector3& axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3&</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAroundInternal_Injected")]
        ///  extern void ROTATE_AROUND_INTERNAL_INJECTED (UnityEngine.Vector3& axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAroundLocal(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAroundLocal")]
        ///  extern void ROTATE_AROUND_LOCAL (UnityEngine.Vector3 axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAroundLocal_Injected(UnityEngine.Vector3& axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3&</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAroundLocal_Injected")]
        ///  extern void ROTATE_AROUND_LOCAL_INJECTED (UnityEngine.Vector3& axis, System.Single angle);


        /// <summary>
        ///   System.Void SendTransformChangedScale()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendTransformChangedScale")]
        ///  extern void SEND_TRANSFORM_CHANGED_SCALE ();


        /// <summary>
        ///   System.Void set_constrainProportionsScale(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_constrainProportionsScale")]
        ///  extern void SET_CONSTRAIN_PROPORTIONS_SCALE (System.Boolean value);


        /// <summary>
        ///   System.Void set_eulerAngles(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_eulerAngles")]
        ///  extern void SET_EULER_ANGLES (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_forward(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_forward")]
        ///  extern void SET_FORWARD (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_hasChanged(System.Boolean value)
        /// </summary>
        /// <param name="value">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hasChanged")]
        ///  extern void SET_HAS_CHANGED (System.Boolean value);


        /// <summary>
        ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
        /// </summary>
        /// <param name="value">enum UnityEngine.HideFlags</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hideFlags")]
        ///  extern void SET_HIDE_FLAGS (UnityEngine.HideFlags value);


        /// <summary>
        ///   System.Void set_hierarchyCapacity(System.Int32 value)
        /// </summary>
        /// <param name="value">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_hierarchyCapacity")]
        ///  extern void SET_HIERARCHY_CAPACITY (System.Int32 value);


        /// <summary>
        ///   System.Void set_localEulerAngles(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localEulerAngles")]
        ///  extern void SET_LOCAL_EULER_ANGLES (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_localPosition(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localPosition")]
        ///  extern void SET_LOCAL_POSITION (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_localPosition_Injected(UnityEngine.Vector3& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localPosition_Injected")]
        ///  extern void SET_LOCAL_POSITION_INJECTED (UnityEngine.Vector3& value);


        /// <summary>
        ///   System.Void set_localRotation(UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localRotation")]
        ///  extern void SET_LOCAL_ROTATION (UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void set_localRotation_Injected(UnityEngine.Quaternion& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localRotation_Injected")]
        ///  extern void SET_LOCAL_ROTATION_INJECTED (UnityEngine.Quaternion& value);


        /// <summary>
        ///   System.Void set_localScale(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localScale")]
        ///  extern void SET_LOCAL_SCALE (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_localScale_Injected(UnityEngine.Vector3& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_localScale_Injected")]
        ///  extern void SET_LOCAL_SCALE_INJECTED (UnityEngine.Vector3& value);


        /// <summary>
        ///   System.Void set_name(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_name")]
        ///  extern void SET_NAME (nint value);


        /// <summary>
        ///   System.Void set_parent(UnityEngine.Transform value)
        /// </summary>
        /// <param name="value">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_parent")]
        ///  extern void SET_PARENT (nint value);


        /// <summary>
        ///   System.Void set_parentInternal(UnityEngine.Transform value)
        /// </summary>
        /// <param name="value">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_parentInternal")]
        ///  extern void SET_PARENT_INTERNAL (nint value);


        /// <summary>
        ///   System.Void set_position(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_position")]
        ///  extern void SET_POSITION (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_position_Injected(UnityEngine.Vector3& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_position_Injected")]
        ///  extern void SET_POSITION_INJECTED (UnityEngine.Vector3& value);


        /// <summary>
        ///   System.Void set_right(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_right")]
        ///  extern void SET_RIGHT (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void set_rotation(UnityEngine.Quaternion value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rotation")]
        ///  extern void SET_ROTATION (UnityEngine.Quaternion value);


        /// <summary>
        ///   System.Void set_rotation_Injected(UnityEngine.Quaternion& value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rotation_Injected")]
        ///  extern void SET_ROTATION_INJECTED (UnityEngine.Quaternion& value);


        /// <summary>
        ///   System.Void set_rotationOrder(UnityEngine.RotationOrder value)
        /// </summary>
        /// <param name="value">enum UnityEngine.RotationOrder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_rotationOrder")]
        ///  extern void SET_ROTATION_ORDER (UnityEngine.RotationOrder value);


        /// <summary>
        ///   System.Void set_tag(System.String value)
        /// </summary>
        /// <param name="value">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_tag")]
        ///  extern void SET_TAG (nint value);


        /// <summary>
        ///   System.Void set_up(UnityEngine.Vector3 value)
        /// </summary>
        /// <param name="value">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_up")]
        ///  extern void SET_UP (UnityEngine.Vector3 value);


        /// <summary>
        ///   System.Void SetAsFirstSibling()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAsFirstSibling")]
        ///  extern void SET_AS_FIRST_SIBLING ();


        /// <summary>
        ///   System.Void SetAsLastSibling()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetAsLastSibling")]
        ///  extern void SET_AS_LAST_SIBLING ();


        /// <summary>
        ///   System.Void SetConstrainProportionsScale(System.Boolean isLinked)
        /// </summary>
        /// <param name="isLinked">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetConstrainProportionsScale")]
        ///  extern void SET_CONSTRAIN_PROPORTIONS_SCALE (System.Boolean isLinked);


        /// <summary>
        ///   System.Void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order)
        /// </summary>
        /// <param name="euler">struct UnityEngine.Vector3</param>
        /// <param name="order">enum UnityEngine.RotationOrder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalEulerAngles")]
        ///  extern void SET_LOCAL_EULER_ANGLES (UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);


        /// <summary>
        ///   System.Void SetLocalEulerAngles_Injected(UnityEngine.Vector3& euler, UnityEngine.RotationOrder order)
        /// </summary>
        /// <param name="euler">struct UnityEngine.Vector3&</param>
        /// <param name="order">enum UnityEngine.RotationOrder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalEulerAngles_Injected")]
        ///  extern void SET_LOCAL_EULER_ANGLES_INJECTED (UnityEngine.Vector3& euler, UnityEngine.RotationOrder order);


        /// <summary>
        ///   System.Void SetLocalEulerHint(UnityEngine.Vector3 euler)
        /// </summary>
        /// <param name="euler">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalEulerHint")]
        ///  extern void SET_LOCAL_EULER_HINT (UnityEngine.Vector3 euler);


        /// <summary>
        ///   System.Void SetLocalEulerHint_Injected(UnityEngine.Vector3& euler)
        /// </summary>
        /// <param name="euler">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalEulerHint_Injected")]
        ///  extern void SET_LOCAL_EULER_HINT_INJECTED (UnityEngine.Vector3& euler);


        /// <summary>
        ///   System.Void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation)
        /// </summary>
        /// <param name="localPosition">struct UnityEngine.Vector3</param>
        /// <param name="localRotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalPositionAndRotation")]
        ///  extern void SET_LOCAL_POSITION_AND_ROTATION (UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation);


        /// <summary>
        ///   System.Void SetLocalPositionAndRotation_Injected(UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation)
        /// </summary>
        /// <param name="localPosition">struct UnityEngine.Vector3&</param>
        /// <param name="localRotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetLocalPositionAndRotation_Injected")]
        ///  extern void SET_LOCAL_POSITION_AND_ROTATION_INJECTED (UnityEngine.Vector3& localPosition, UnityEngine.Quaternion& localRotation);


        /// <summary>
        /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="name">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetName")]
        /// static extern void SET_NAME (nint obj, nint name);


        /// <summary>
        ///   System.Void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPositionAndRotation")]
        ///  extern void SET_POSITION_AND_ROTATION (UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        ///   System.Void SetPositionAndRotation_Injected(UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3&</param>
        /// <param name="rotation">struct UnityEngine.Quaternion&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetPositionAndRotation_Injected")]
        ///  extern void SET_POSITION_AND_ROTATION_INJECTED (UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation);


        /// <summary>
        ///   System.Void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder)
        /// </summary>
        /// <param name="rotationOrder">enum UnityEngine.RotationOrder</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetRotationOrderInternal")]
        ///  extern void SET_ROTATION_ORDER_INTERNAL (UnityEngine.RotationOrder rotationOrder);


        /// <summary>
        ///   System.Void SetSiblingIndex(System.Int32 index)
        /// </summary>
        /// <param name="index">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSiblingIndex")]
        ///  extern void SET_SIBLING_INDEX (System.Int32 index);


        /// <summary>
        ///   System.Void TransformDirection_Injected(UnityEngine.Vector3& direction, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="direction">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirection_Injected")]
        ///  extern void TRANSFORM_DIRECTION_INJECTED (UnityEngine.Vector3& direction, UnityEngine.Vector3& ret);


        /// <summary>
        ///   System.Void TransformPoint_Injected(UnityEngine.Vector3& position, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoint_Injected")]
        ///  extern void TRANSFORM_POINT_INJECTED (UnityEngine.Vector3& position, UnityEngine.Vector3& ret);



        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Transform))]
        ///  extern void .CTOR_00 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Transform))]
        ///  extern void .CTOR_01 ();


        /// <summary>
        ///   System.Void .ctor()
        /// </summary>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Transform))]
        ///  extern void .CTOR_02 ();


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Transform))]
        ///  extern void BROADCAST_MESSAGE_00 (nint methodName, nint parameter, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, System.Object parameter)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="parameter">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Transform))]
        ///  extern void BROADCAST_MESSAGE_01 (nint methodName, nint parameter);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Transform))]
        ///  extern void BROADCAST_MESSAGE_02 (nint methodName);


        /// <summary>
        ///   System.Void BroadcastMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("BroadcastMessage", Search = typeof(Search_Transform))]
        ///  extern void BROADCAST_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void Destroy(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="allowDestroyingAssets">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_IMMEDIATE_00 (nint obj, System.Boolean allowDestroyingAssets);


        /// <summary>
        /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyImmediate", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_IMMEDIATE_01 (nint obj);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <param name="t">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_OBJECT_00 (nint obj, System.Single t);


        /// <summary>
        /// static  System.Void DestroyObject(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("DestroyObject", Search = typeof(Search_Transform))]
        /// static extern void DESTROY_OBJECT_01 (nint obj);


        /// <summary>
        /// static  T FindAnyObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindAnyObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_ANY_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindFirstObjectByType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_00 ();


        /// <summary>
        /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_01 (UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindFirstObjectByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_FIRST_OBJECT_BY_TYPE_03 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive);


        /// <summary>
        /// static  T FindObjectOfType()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECT_OF_TYPE_00 ();


        /// <summary>
        /// static  T FindObjectOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECT_OF_TYPE_01 (System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECT_OF_TYPE_02 (nint type);


        /// <summary>
        /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECT_OF_TYPE_03 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_00 (nint type, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_01 (nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_02 (UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
        /// </summary>
        /// <param name="findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
        /// <param name="sortMode">enum UnityEngine.FindObjectsSortMode</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsByType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_BY_TYPE_03 (UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_00 (nint type);


        /// <summary>
        /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_01 (nint type, System.Boolean includeInactive);


        /// <summary>
        /// static  T[] FindObjectsOfType()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_02 ();


        /// <summary>
        /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("FindObjectsOfType", Search = typeof(Search_Transform))]
        /// static extern nint FIND_OBJECTS_OF_TYPE_03 (System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_00 (nint type);


        /// <summary>
        ///   T GetComponent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_01 ();


        /// <summary>
        ///   UnityEngine.Component GetComponent(System.String type)
        /// </summary>
        /// <param name="type">class System.String</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_02 (nint type);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T GetComponentInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInChildren()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_CHILDREN_03 ();


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component GetComponentInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T GetComponentInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   T GetComponentInParent()
        /// </summary>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENT_IN_PARENT_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponents(System.Type type)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_00 (nint type);


        /// <summary>
        ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="results">class System.Collections.Generic.List<UnityEngine.Component></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Transform))]
        ///  extern void GET_COMPONENTS_01 (nint type, nint results);


        /// <summary>
        ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Transform))]
        ///  extern void GET_COMPONENTS_02 (nint results);


        /// <summary>
        ///   T[] GetComponents()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_03 ();


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInChildren(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="result">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_03 (System.Boolean includeInactive, nint result);


        /// <summary>
        ///   T[] GetComponentsInChildren()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_CHILDREN_04 ();


        /// <summary>
        ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInChildren", Search = typeof(Search_Transform))]
        ///  extern void GET_COMPONENTS_IN_CHILDREN_05 (nint results);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t, System.Boolean includeInactive)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_00 (nint t, System.Boolean includeInactive);


        /// <summary>
        ///   UnityEngine.Component[] GetComponentsInParent(System.Type t)
        /// </summary>
        /// <param name="t">abstract class System.Type</param>
        /// <returns>class UnityEngine.Component[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_01 (nint t);


        /// <summary>
        ///   T[] GetComponentsInParent(System.Boolean includeInactive)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_02 (System.Boolean includeInactive);


        /// <summary>
        ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
        /// </summary>
        /// <param name="includeInactive">struct System.Boolean</param>
        /// <param name="results">class System.Collections.Generic.List<T></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Transform))]
        ///  extern void GET_COMPONENTS_IN_PARENT_03 (System.Boolean includeInactive, nint results);


        /// <summary>
        ///   T[] GetComponentsInParent()
        /// </summary>
        /// <returns>class T[]</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentsInParent", Search = typeof(Search_Transform))]
        ///  extern nint GET_COMPONENTS_IN_PARENT_04 ();


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_00 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_01 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_02 (nint original);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_03 (nint original, nint parent);


        /// <summary>
        /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
        /// </summary>
        /// <param name="original">class UnityEngine.Object</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="instantiateInWorldSpace">struct System.Boolean</param>
        /// <returns>class UnityEngine.Object</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_04 (nint original, nint parent, System.Boolean instantiateInWorldSpace);


        /// <summary>
        /// static  T Instantiate(T original)
        /// </summary>
        /// <param name="original">class T</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_05 (nint original);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_06 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <param name="rotation">struct UnityEngine.Quaternion</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_07 (nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_08 (nint original, nint parent);


        /// <summary>
        /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="original">class T</param>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>class T</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Instantiate", Search = typeof(Search_Transform))]
        /// static extern nint INSTANTIATE_09 (nint original, nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction)
        /// </summary>
        /// <param name="direction">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirection", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_DIRECTION_00 (UnityEngine.Vector3 direction);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformDirection(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirection", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_DIRECTION_01 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void InverseTransformDirections(UnityEngine.Vector3* directions, System.Int32 count, UnityEngine.Vector3* transformedDirections, System.Int32 transformedCount)
        /// </summary>
        /// <param name="directions">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedDirections">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirections", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_DIRECTIONS_00 (nint directions, System.Int32 count, nint transformedDirections, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void InverseTransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections)
        /// </summary>
        /// <param name="directions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedDirections">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirections", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_DIRECTIONS_01 (System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);


        /// <summary>
        ///   System.Void InverseTransformDirections(System.Span<UnityEngine.Vector3> directions)
        /// </summary>
        /// <param name="directions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformDirections", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_DIRECTIONS_02 (System.Span<UnityEngine.Vector3> directions);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoint", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_POINT_00 (UnityEngine.Vector3 position);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformPoint(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoint", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_POINT_01 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void InverseTransformPoints(UnityEngine.Vector3* positions, System.Int32 count, UnityEngine.Vector3* transformedPositions, System.Int32 transformedCount)
        /// </summary>
        /// <param name="positions">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedPositions">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoints", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_POINTS_00 (nint positions, System.Int32 count, nint transformedPositions, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void InverseTransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions)
        /// </summary>
        /// <param name="positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedPositions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoints", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_POINTS_01 (System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);


        /// <summary>
        ///   System.Void InverseTransformPoints(System.Span<UnityEngine.Vector3> positions)
        /// </summary>
        /// <param name="positions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformPoints", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_POINTS_02 (System.Span<UnityEngine.Vector3> positions);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector)
        /// </summary>
        /// <param name="vector">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVector", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_VECTOR_00 (UnityEngine.Vector3 vector);


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformVector(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVector", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 INVERSE_TRANSFORM_VECTOR_01 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void InverseTransformVectors(UnityEngine.Vector3* vectors, System.Int32 count, UnityEngine.Vector3* transformedVectors, System.Int32 transformedCount)
        /// </summary>
        /// <param name="vectors">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedVectors">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVectors", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_VECTORS_00 (nint vectors, System.Int32 count, nint transformedVectors, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void InverseTransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors)
        /// </summary>
        /// <param name="vectors">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedVectors">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVectors", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_VECTORS_01 (System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);


        /// <summary>
        ///   System.Void InverseTransformVectors(System.Span<UnityEngine.Vector3> vectors)
        /// </summary>
        /// <param name="vectors">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InverseTransformVectors", Search = typeof(Search_Transform))]
        ///  extern void INVERSE_TRANSFORM_VECTORS_02 (System.Span<UnityEngine.Vector3> vectors);


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp)
        /// </summary>
        /// <param name="target">class UnityEngine.Transform</param>
        /// <param name="worldUp">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LookAt", Search = typeof(Search_Transform))]
        ///  extern void LOOK_AT_00 (nint target, UnityEngine.Vector3 worldUp);


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Transform target)
        /// </summary>
        /// <param name="target">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LookAt", Search = typeof(Search_Transform))]
        ///  extern void LOOK_AT_01 (nint target);


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp)
        /// </summary>
        /// <param name="worldPosition">struct UnityEngine.Vector3</param>
        /// <param name="worldUp">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LookAt", Search = typeof(Search_Transform))]
        ///  extern void LOOK_AT_02 (UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Vector3 worldPosition)
        /// </summary>
        /// <param name="worldPosition">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LookAt", Search = typeof(Search_Transform))]
        ///  extern void LOOK_AT_03 (UnityEngine.Vector3 worldPosition);


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo)
        /// </summary>
        /// <param name="eulers">struct UnityEngine.Vector3</param>
        /// <param name="relativeTo">enum UnityEngine.Space</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_00 (UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 eulers)
        /// </summary>
        /// <param name="eulers">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_01 (UnityEngine.Vector3 eulers);


        /// <summary>
        ///   System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle, UnityEngine.Space relativeTo)
        /// </summary>
        /// <param name="xAngle">struct System.Single</param>
        /// <param name="yAngle">struct System.Single</param>
        /// <param name="zAngle">struct System.Single</param>
        /// <param name="relativeTo">enum UnityEngine.Space</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_02 (System.Single xAngle, System.Single yAngle, System.Single zAngle, UnityEngine.Space relativeTo);


        /// <summary>
        ///   System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle)
        /// </summary>
        /// <param name="xAngle">struct System.Single</param>
        /// <param name="yAngle">struct System.Single</param>
        /// <param name="zAngle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_03 (System.Single xAngle, System.Single yAngle, System.Single zAngle);


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle, UnityEngine.Space relativeTo)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <param name="relativeTo">enum UnityEngine.Space</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_04 (UnityEngine.Vector3 axis, System.Single angle, UnityEngine.Space relativeTo);


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Rotate", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_05 (UnityEngine.Vector3 axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// <param name="point">struct UnityEngine.Vector3</param>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAround", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_AROUND_00 (UnityEngine.Vector3 point, UnityEngine.Vector3 axis, System.Single angle);


        /// <summary>
        ///   System.Void RotateAround(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// <param name="axis">struct UnityEngine.Vector3</param>
        /// <param name="angle">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RotateAround", Search = typeof(Search_Transform))]
        ///  extern void ROTATE_AROUND_01 (UnityEngine.Vector3 axis, System.Single angle);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_00 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_01 (nint methodName);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_02 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessage(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessage", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_UPWARDS_00 (nint methodName, nint value, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, System.Object value)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="value">class System.Object</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_UPWARDS_01 (nint methodName, nint value);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_UPWARDS_02 (nint methodName);


        /// <summary>
        ///   System.Void SendMessageUpwards(System.String methodName, UnityEngine.SendMessageOptions options)
        /// </summary>
        /// <param name="methodName">class System.String</param>
        /// <param name="options">enum UnityEngine.SendMessageOptions</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SendMessageUpwards", Search = typeof(Search_Transform))]
        ///  extern void SEND_MESSAGE_UPWARDS_03 (nint methodName, UnityEngine.SendMessageOptions options);


        /// <summary>
        ///   System.Void SetParent(UnityEngine.Transform p)
        /// </summary>
        /// <param name="p">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetParent", Search = typeof(Search_Transform))]
        ///  extern void SET_PARENT_00 (nint p);


        /// <summary>
        ///   System.Void SetParent(UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// <param name="parent">class UnityEngine.Transform</param>
        /// <param name="worldPositionStays">struct System.Boolean</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetParent", Search = typeof(Search_Transform))]
        ///  extern void SET_PARENT_01 (nint parent, System.Boolean worldPositionStays);


        /// <summary>
        ///   System.String ToString()
        /// </summary>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_Transform))]
        ///  extern nint TO_STRING_00 ();


        /// <summary>
        /// static  System.String ToString(UnityEngine.Object obj)
        /// </summary>
        /// <param name="obj">class UnityEngine.Object</param>
        /// <returns>class System.String</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString", Search = typeof(Search_Transform))]
        /// static extern nint TO_STRING_01 (nint obj);


        /// <summary>
        ///   UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction)
        /// </summary>
        /// <param name="direction">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirection", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_DIRECTION_00 (UnityEngine.Vector3 direction);


        /// <summary>
        ///   UnityEngine.Vector3 TransformDirection(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirection", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_DIRECTION_01 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void TransformDirections(UnityEngine.Vector3* directions, System.Int32 count, UnityEngine.Vector3* transformedDirections, System.Int32 transformedCount)
        /// </summary>
        /// <param name="directions">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedDirections">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirections", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_DIRECTIONS_00 (nint directions, System.Int32 count, nint transformedDirections, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void TransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections)
        /// </summary>
        /// <param name="directions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedDirections">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirections", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_DIRECTIONS_01 (System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);


        /// <summary>
        ///   System.Void TransformDirections(System.Span<UnityEngine.Vector3> directions)
        /// </summary>
        /// <param name="directions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformDirections", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_DIRECTIONS_02 (System.Span<UnityEngine.Vector3> directions);


        /// <summary>
        ///   UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position)
        /// </summary>
        /// <param name="position">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoint", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_POINT_00 (UnityEngine.Vector3 position);


        /// <summary>
        ///   UnityEngine.Vector3 TransformPoint(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoint", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_POINT_01 (System.Single x, System.Single y, System.Single z);


        /// public static partial class Search_Transform
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


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_DIRECTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformDirection", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformDirection(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_DIRECTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformDirection", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformDirections(UnityEngine.Vector3* directions, System.Int32 count, UnityEngine.Vector3* transformedDirections, System.Int32 transformedCount)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_DIRECTIONS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformDirections", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_DIRECTIONS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformDirections", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformDirections(System.Span<UnityEngine.Vector3> directions)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_DIRECTIONS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformDirections", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_POINT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformPoint", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformPoint(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_POINT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformPoint", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformPoints(UnityEngine.Vector3* positions, System.Int32 count, UnityEngine.Vector3* transformedPositions, System.Int32 transformedCount)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_POINTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformPoints", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_POINTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformPoints", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformPoints(System.Span<UnityEngine.Vector3> positions)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_POINTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformPoints", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformVector", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 InverseTransformVector(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformVector", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformVectors(UnityEngine.Vector3* vectors, System.Int32 count, UnityEngine.Vector3* transformedVectors, System.Int32 transformedCount)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_VECTORS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformVectors", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_VECTORS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformVectors", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void InverseTransformVectors(System.Span<UnityEngine.Vector3> vectors)
        /// </summary>
        /// public static bool INVERSE_TRANSFORM_VECTORS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "InverseTransformVectors", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp)
        /// </summary>
        /// public static bool LOOK_AT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LookAt", "UnityEngine.Transform", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Transform target)
        /// </summary>
        /// public static bool LOOK_AT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LookAt", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp)
        /// </summary>
        /// public static bool LOOK_AT_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LookAt", "UnityEngine.Vector3", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void LookAt(UnityEngine.Vector3 worldPosition)
        /// </summary>
        /// public static bool LOOK_AT_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "LookAt", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo)
        /// </summary>
        /// public static bool ROTATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "UnityEngine.Vector3", "UnityEngine.Space");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 eulers)
        /// </summary>
        /// public static bool ROTATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle, UnityEngine.Space relativeTo)
        /// </summary>
        /// public static bool ROTATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "System.Single", "System.Single", "System.Single", "UnityEngine.Space");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(System.Single xAngle, System.Single yAngle, System.Single zAngle)
        /// </summary>
        /// public static bool ROTATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle, UnityEngine.Space relativeTo)
        /// </summary>
        /// public static bool ROTATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "UnityEngine.Vector3", "System.Single", "UnityEngine.Space");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Rotate(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// public static bool ROTATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Rotate", "UnityEngine.Vector3", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// public static bool ROTATE_AROUND_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RotateAround", "UnityEngine.Vector3", "UnityEngine.Vector3", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void RotateAround(UnityEngine.Vector3 axis, System.Single angle)
        /// </summary>
        /// public static bool ROTATE_AROUND_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RotateAround", "UnityEngine.Vector3", "System.Single");
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
        ///   System.Void SetParent(UnityEngine.Transform p)
        /// </summary>
        /// public static bool SET_PARENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetParent", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void SetParent(UnityEngine.Transform parent, System.Boolean worldPositionStays)
        /// </summary>
        /// public static bool SET_PARENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "SetParent", "UnityEngine.Transform", "System.Boolean");
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
        ///   UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction)
        /// </summary>
        /// public static bool TRANSFORM_DIRECTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformDirection", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 TransformDirection(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool TRANSFORM_DIRECTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformDirection", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformDirections(UnityEngine.Vector3* directions, System.Int32 count, UnityEngine.Vector3* transformedDirections, System.Int32 transformedCount)
        /// </summary>
        /// public static bool TRANSFORM_DIRECTIONS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformDirections", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections)
        /// </summary>
        /// public static bool TRANSFORM_DIRECTIONS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformDirections", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformDirections(System.Span<UnityEngine.Vector3> directions)
        /// </summary>
        /// public static bool TRANSFORM_DIRECTIONS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformDirections", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position)
        /// </summary>
        /// public static bool TRANSFORM_POINT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformPoint", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 TransformPoint(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool TRANSFORM_POINT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformPoint", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 
        /// 
        /// }

    }

    /// <summary>
    /// ["UnityEngine.CoreModule"."UnityEngine"."Transform"]
    /// </summary>
    public partial class Transform
    {



        /// <summary>
        ///   System.Void TransformVector_Injected(UnityEngine.Vector3& vector, UnityEngine.Vector3& ret)
        /// </summary>
        /// <param name="vector">struct UnityEngine.Vector3&</param>
        /// <param name="ret">struct UnityEngine.Vector3&</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVector_Injected")]
        ///  extern void TRANSFORM_VECTOR_INJECTED (UnityEngine.Vector3& vector, UnityEngine.Vector3& ret);



        /// <summary>
        ///   System.Void TransformPoints(UnityEngine.Vector3* positions, System.Int32 count, UnityEngine.Vector3* transformedPositions, System.Int32 transformedCount)
        /// </summary>
        /// <param name="positions">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedPositions">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoints", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_POINTS_00 (nint positions, System.Int32 count, nint transformedPositions, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void TransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions)
        /// </summary>
        /// <param name="positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedPositions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoints", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_POINTS_01 (System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);


        /// <summary>
        ///   System.Void TransformPoints(System.Span<UnityEngine.Vector3> positions)
        /// </summary>
        /// <param name="positions">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformPoints", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_POINTS_02 (System.Span<UnityEngine.Vector3> positions);


        /// <summary>
        ///   UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector)
        /// </summary>
        /// <param name="vector">struct UnityEngine.Vector3</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVector", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_VECTOR_00 (UnityEngine.Vector3 vector);


        /// <summary>
        ///   UnityEngine.Vector3 TransformVector(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct UnityEngine.Vector3</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVector", Search = typeof(Search_Transform))]
        ///  extern UnityEngine.Vector3 TRANSFORM_VECTOR_01 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void TransformVectors(UnityEngine.Vector3* vectors, System.Int32 count, UnityEngine.Vector3* transformedVectors, System.Int32 transformedCount)
        /// </summary>
        /// <param name="vectors">class UnityEngine.Vector3*</param>
        /// <param name="count">struct System.Int32</param>
        /// <param name="transformedVectors">class UnityEngine.Vector3*</param>
        /// <param name="transformedCount">struct System.Int32</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVectors", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_VECTORS_00 (nint vectors, System.Int32 count, nint transformedVectors, System.Int32 transformedCount);


        /// <summary>
        ///   System.Void TransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors)
        /// </summary>
        /// <param name="vectors">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
        /// <param name="transformedVectors">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVectors", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_VECTORS_01 (System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);


        /// <summary>
        ///   System.Void TransformVectors(System.Span<UnityEngine.Vector3> vectors)
        /// </summary>
        /// <param name="vectors">struct System.Span<UnityEngine.Vector3></param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TransformVectors", Search = typeof(Search_Transform))]
        ///  extern void TRANSFORM_VECTORS_02 (System.Span<UnityEngine.Vector3> vectors);


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo)
        /// </summary>
        /// <param name="translation">struct UnityEngine.Vector3</param>
        /// <param name="relativeTo">enum UnityEngine.Space</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_00 (UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation)
        /// </summary>
        /// <param name="translation">struct UnityEngine.Vector3</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_01 (UnityEngine.Vector3 translation);


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Space relativeTo)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <param name="relativeTo">enum UnityEngine.Space</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_02 (System.Single x, System.Single y, System.Single z, UnityEngine.Space relativeTo);


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_03 (System.Single x, System.Single y, System.Single z);


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo)
        /// </summary>
        /// <param name="translation">struct UnityEngine.Vector3</param>
        /// <param name="relativeTo">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_04 (UnityEngine.Vector3 translation, nint relativeTo);


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Transform relativeTo)
        /// </summary>
        /// <param name="x">struct System.Single</param>
        /// <param name="y">struct System.Single</param>
        /// <param name="z">struct System.Single</param>
        /// <param name="relativeTo">class UnityEngine.Transform</param>
        /// <returns>struct System.Void</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Translate", Search = typeof(Search_Transform))]
        ///  extern void TRANSLATE_05 (System.Single x, System.Single y, System.Single z, nint relativeTo);


        /// <summary>
        ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
        /// </summary>
        /// <param name="type">abstract class System.Type</param>
        /// <param name="component">class UnityEngine.Component&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_Transform))]
        ///  extern System.Boolean TRY_GET_COMPONENT_00 (nint type, nint component);


        /// <summary>
        ///   System.Boolean TryGetComponent(T& component)
        /// </summary>
        /// <param name="component">class T&</param>
        /// <returns>struct System.Boolean</returns>
        /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetComponent", Search = typeof(Search_Transform))]
        ///  extern System.Boolean TRY_GET_COMPONENT_01 (nint component);


        /// public static partial class Search_Transform
        /// {
        /// 
        ///     

        /// <summary>
        ///   System.Void TransformPoints(UnityEngine.Vector3* positions, System.Int32 count, UnityEngine.Vector3* transformedPositions, System.Int32 transformedCount)
        /// </summary>
        /// public static bool TRANSFORM_POINTS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformPoints", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions)
        /// </summary>
        /// public static bool TRANSFORM_POINTS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformPoints", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformPoints(System.Span<UnityEngine.Vector3> positions)
        /// </summary>
        /// public static bool TRANSFORM_POINTS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformPoints", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector)
        /// </summary>
        /// public static bool TRANSFORM_VECTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformVector", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   UnityEngine.Vector3 TransformVector(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool TRANSFORM_VECTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformVector", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformVectors(UnityEngine.Vector3* vectors, System.Int32 count, UnityEngine.Vector3* transformedVectors, System.Int32 transformedCount)
        /// </summary>
        /// public static bool TRANSFORM_VECTORS_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformVectors", "UnityEngine.Vector3*", "System.Int32", "UnityEngine.Vector3*", "System.Int32");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors)
        /// </summary>
        /// public static bool TRANSFORM_VECTORS_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformVectors", "System.ReadOnlySpan<UnityEngine.Vector3>", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void TransformVectors(System.Span<UnityEngine.Vector3> vectors)
        /// </summary>
        /// public static bool TRANSFORM_VECTORS_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "TransformVectors", "System.Span<UnityEngine.Vector3>");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo)
        /// </summary>
        /// public static bool TRANSLATE_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "UnityEngine.Vector3", "UnityEngine.Space");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation)
        /// </summary>
        /// public static bool TRANSLATE_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "UnityEngine.Vector3");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Space relativeTo)
        /// </summary>
        /// public static bool TRANSLATE_02 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "System.Single", "System.Single", "System.Single", "UnityEngine.Space");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z)
        /// </summary>
        /// public static bool TRANSLATE_03 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "System.Single", "System.Single", "System.Single");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo)
        /// </summary>
        /// public static bool TRANSLATE_04 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "UnityEngine.Vector3", "UnityEngine.Transform");
        ///     
        ///  
        /// 


        /// <summary>
        ///   System.Void Translate(System.Single x, System.Single y, System.Single z, UnityEngine.Transform relativeTo)
        /// </summary>
        /// public static bool TRANSLATE_05 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
        ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "Translate", "System.Single", "System.Single", "System.Single", "UnityEngine.Transform");
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
        /// }

    }


}