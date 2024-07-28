
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
    /// class ["ProjectStar".""."GameStateEntity"]
    /// [Entitas.Entity]=>[System.Object]
    /// [IDestroyedEntity]
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000643U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [71, 97, 109, 101, 83, 116, 97, 116, 101, 69, 110, 116, 105, 116, 121])]
                
    //  class static CoOpModeComponent coOpModeComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"coOpModeComponent", "CO_OP_MODE_COMPONENT", true)]
            
    //  class static DestroyedComponent destroyedComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"destroyedComponent", "DESTROYED_COMPONENT", true)]
            
    //  class static InGameComponent inGameComponent
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"inGameComponent", "IN_GAME_COMPONENT", true)]
                
    // class 0x8 Entitas.EntityComponentChanged OnComponentAdded
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentAdded", "ON_COMPONENT_ADDED")]
            
    // class 0xC Entitas.EntityComponentChanged OnComponentRemoved
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentRemoved", "ON_COMPONENT_REMOVED")]
            
    // class 0x10 Entitas.EntityComponentReplaced OnComponentReplaced
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnComponentReplaced", "ON_COMPONENT_REPLACED")]
            
    // class 0x14 Entitas.EntityEvent OnEntityReleased
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnEntityReleased", "ON_ENTITY_RELEASED")]
            
    // class 0x18 Entitas.EntityEvent OnDestroyEntity
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"OnDestroyEntity", "ON_DESTROY_ENTITY")]
            
    // class 0x1C System.Collections.Generic.List<Entitas.IComponent> _componentBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentBuffer", "_COMPONENT_BUFFER")]
            
    // class 0x20 System.Collections.Generic.List<System.Int32> _indexBuffer
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_indexBuffer", "_INDEX_BUFFER")]
            
    // class 0x24 Entitas.IComponent[] _components
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_components", "_COMPONENTS")]
            
    // class 0x28 System.Collections.Generic.Stack<Entitas.IComponent>[] _componentPools
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentPools", "_COMPONENT_POOLS")]
            
    // class 0x2C Entitas.ContextInfo _contextInfo
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_contextInfo", "_CONTEXT_INFO")]
            
    // interface 0x30 Entitas.IAERC _aerc
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_aerc", "_AERC")]
            
    // class 0x34 Entitas.IComponent[] _componentsCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentsCache", "_COMPONENTS_CACHE")]
            
    // class 0x38 System.Int32[] _componentIndicesCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_componentIndicesCache", "_COMPONENT_INDICES_CACHE")]
            
    // class 0x3C System.String _toStringCache
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringCache", "_TO_STRING_CACHE")]
            
    // class 0x40 System.Text.StringBuilder _toStringBuilder
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"_toStringBuilder", "_TO_STRING_BUILDER")]
            
    // struct 0x44 System.Int32 _creationIndex
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_creationIndex", "_CREATION_INDEX")]
            
    // struct 0x48 System.Boolean _isEnabled
    // [MonoCollectorSearchFieldAttribute(typeof(System.Boolean),"_isEnabled", "_IS_ENABLED")]
            
    // struct 0x4C System.Int32 _totalComponents
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"_totalComponents", "_TOTAL_COMPONENTS")]
    public partial class GameStateEntity
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "GameStateEntity";
        //public static byte[] Static_ClassName { get; } = [71, 97, 109, 101, 83, 116, 97, 116, 101, 69, 110, 116, 105, 116, 121];

        //public const uint Const_TypeToken = 0x02000643U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_GameStateEntity(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_GameStateEntity(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_GameStateEntity obj) => obj._ptr;
            public static implicit operator bool(Ptr_GameStateEntity obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."GameStateEntity"]
        /// </summary>
        public partial class GameStateEntity
        { 

            
            
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".cctor")]
            /// static extern void .CCTOR ();

            
            /// <summary>
            ///   System.Void add_OnComponentAdded(Entitas.EntityComponentChanged value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentChanged</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentAdded")]
            ///  extern void ADD_ON_COMPONENT_ADDED (nint value);

            
            /// <summary>
            ///   System.Void add_OnComponentRemoved(Entitas.EntityComponentChanged value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentChanged</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentRemoved")]
            ///  extern void ADD_ON_COMPONENT_REMOVED (nint value);

            
            /// <summary>
            ///   System.Void add_OnComponentReplaced(Entitas.EntityComponentReplaced value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentReplaced</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnComponentReplaced")]
            ///  extern void ADD_ON_COMPONENT_REPLACED (nint value);

            
            /// <summary>
            ///   System.Void add_OnDestroyEntity(Entitas.EntityEvent value)
            /// </summary>
            /// <param name="value">class Entitas.EntityEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnDestroyEntity")]
            ///  extern void ADD_ON_DESTROY_ENTITY (nint value);

            
            /// <summary>
            ///   System.Void add_OnEntityReleased(Entitas.EntityEvent value)
            /// </summary>
            /// <param name="value">class Entitas.EntityEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("add_OnEntityReleased")]
            ///  extern void ADD_ON_ENTITY_RELEASED (nint value);

            
            /// <summary>
            ///   System.Void AddComponent(System.Int32 index, Entitas.IComponent component)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="component">interface Entitas.IComponent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddComponent")]
            ///  extern void ADD_COMPONENT (System.Int32 index, nint component);

            
            /// <summary>
            ///   System.Void AddCrystal(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCrystal")]
            ///  extern void ADD_CRYSTAL (nint newValue);

            
            /// <summary>
            ///   System.Void AddExperience(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExperience")]
            ///  extern void ADD_EXPERIENCE (nint newValue);

            
            /// <summary>
            ///   System.Void AddGold(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGold")]
            ///  extern void ADD_GOLD (nint newValue);

            
            /// <summary>
            ///   System.Void AddLastOverworldPortalLocation(UnityEngine.Vector3 newValue)
            /// </summary>
            /// <param name="newValue">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLastOverworldPortalLocation")]
            ///  extern void ADD_LAST_OVERWORLD_PORTAL_LOCATION (UnityEngine.Vector3 newValue);

            
            /// <summary>
            ///   System.Void AddLevel(System.Int32 newValue)
            /// </summary>
            /// <param name="newValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLevel")]
            ///  extern void ADD_LEVEL (System.Int32 newValue);

            
            /// <summary>
            ///   System.Void AddPause(PauseFlags newFlags)
            /// </summary>
            /// <param name="newFlags">enum PauseFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPause")]
            ///  extern void ADD_PAUSE (PauseFlags newFlags);

            
            /// <summary>
            ///   System.Void AddPauseCommand(PauseCommand newCommand, PauseFlags newFlags)
            /// </summary>
            /// <param name="newCommand">enum PauseCommand</param>
            /// <param name="newFlags">enum PauseFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddPauseCommand")]
            ///  extern void ADD_PAUSE_COMMAND (PauseCommand newCommand, PauseFlags newFlags);

            
            /// <summary>
            ///   System.Void AddQuestFastForwardData(System.Collections.Generic.Dictionary<QuestData,System.Collections.Generic.Dictionary<UnitSpawner,System.Int32>> newFinishedSpawners)
            /// </summary>
            /// <param name="newFinishedSpawners">class System.Collections.Generic.Dictionary<QuestData,System.Collections.Generic.Dictionary<UnitSpawner,System.Int32>></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddQuestFastForwardData")]
            ///  extern void ADD_QUEST_FAST_FORWARD_DATA (nint newFinishedSpawners);

            
            /// <summary>
            ///   System.Void AddSpellItemData(SpellLevelConfig newValue)
            /// </summary>
            /// <param name="newValue">class SpellLevelConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddSpellItemData")]
            ///  extern void ADD_SPELL_ITEM_DATA (nint newValue);

            
            /// <summary>
            ///   Entitas.ContextInfo createDefaultContextInfo()
            /// </summary>
            /// <returns>class Entitas.ContextInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("createDefaultContextInfo")]
            ///  extern nint CREATE_DEFAULT_CONTEXT_INFO ();

            
            /// <summary>
            ///   System.Void Destroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Destroy")]
            ///  extern void DESTROY ();

            
            /// <summary>
            ///   Entitas.IAERC get_aerc()
            /// </summary>
            /// <returns>interface Entitas.IAERC</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_aerc")]
            ///  extern nint GET_AERC ();

            
            /// <summary>
            ///   System.Collections.Generic.Stack<Entitas.IComponent>[] get_componentPools()
            /// </summary>
            /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent>[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_componentPools")]
            ///  extern nint GET_COMPONENT_POOLS ();

            
            /// <summary>
            ///   Entitas.ContextInfo get_contextInfo()
            /// </summary>
            /// <returns>class Entitas.ContextInfo</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_contextInfo")]
            ///  extern nint GET_CONTEXT_INFO ();

            
            /// <summary>
            ///   System.Int32 get_creationIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_creationIndex")]
            ///  extern System.Int32 GET_CREATION_INDEX ();

            
            /// <summary>
            ///   CrystalComponent get_crystal()
            /// </summary>
            /// <returns>class CrystalComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_crystal")]
            ///  extern nint GET_CRYSTAL ();

            
            /// <summary>
            ///   CrystalListenerComponent get_crystalListener()
            /// </summary>
            /// <returns>class CrystalListenerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_crystalListener")]
            ///  extern nint GET_CRYSTAL_LISTENER ();

            
            /// <summary>
            ///   ExperienceComponent get_experience()
            /// </summary>
            /// <returns>class ExperienceComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_experience")]
            ///  extern nint GET_EXPERIENCE ();

            
            /// <summary>
            ///   ExperienceListenerComponent get_experienceListener()
            /// </summary>
            /// <returns>class ExperienceListenerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_experienceListener")]
            ///  extern nint GET_EXPERIENCE_LISTENER ();

            
            /// <summary>
            ///   GameStateDestroyedListenerComponent get_gameStateDestroyedListener()
            /// </summary>
            /// <returns>class GameStateDestroyedListenerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gameStateDestroyedListener")]
            ///  extern nint GET_GAME_STATE_DESTROYED_LISTENER ();

            
            /// <summary>
            ///   GoldComponent get_gold()
            /// </summary>
            /// <returns>class GoldComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_gold")]
            ///  extern nint GET_GOLD ();

            
            /// <summary>
            ///   GoldListenerComponent get_goldListener()
            /// </summary>
            /// <returns>class GoldListenerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_goldListener")]
            ///  extern nint GET_GOLD_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasCrystal()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCrystal")]
            ///  extern System.Boolean GET_HAS_CRYSTAL ();

            
            /// <summary>
            ///   System.Boolean get_hasCrystalListener()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasCrystalListener")]
            ///  extern System.Boolean GET_HAS_CRYSTAL_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasExperience()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasExperience")]
            ///  extern System.Boolean GET_HAS_EXPERIENCE ();

            
            /// <summary>
            ///   System.Boolean get_hasExperienceListener()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasExperienceListener")]
            ///  extern System.Boolean GET_HAS_EXPERIENCE_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasGameStateDestroyedListener()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGameStateDestroyedListener")]
            ///  extern System.Boolean GET_HAS_GAME_STATE_DESTROYED_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasGold()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGold")]
            ///  extern System.Boolean GET_HAS_GOLD ();

            
            /// <summary>
            ///   System.Boolean get_hasGoldListener()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasGoldListener")]
            ///  extern System.Boolean GET_HAS_GOLD_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasLastOverworldPortalLocation()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLastOverworldPortalLocation")]
            ///  extern System.Boolean GET_HAS_LAST_OVERWORLD_PORTAL_LOCATION ();

            
            /// <summary>
            ///   System.Boolean get_hasLevel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLevel")]
            ///  extern System.Boolean GET_HAS_LEVEL ();

            
            /// <summary>
            ///   System.Boolean get_hasLevelListener()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasLevelListener")]
            ///  extern System.Boolean GET_HAS_LEVEL_LISTENER ();

            
            /// <summary>
            ///   System.Boolean get_hasPause()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPause")]
            ///  extern System.Boolean GET_HAS_PAUSE ();

            
            /// <summary>
            ///   System.Boolean get_hasPauseCommand()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasPauseCommand")]
            ///  extern System.Boolean GET_HAS_PAUSE_COMMAND ();

            
            /// <summary>
            ///   System.Boolean get_hasQuestFastForwardData()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasQuestFastForwardData")]
            ///  extern System.Boolean GET_HAS_QUEST_FAST_FORWARD_DATA ();

            
            /// <summary>
            ///   System.Boolean get_hasSpellItemData()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_hasSpellItemData")]
            ///  extern System.Boolean GET_HAS_SPELL_ITEM_DATA ();

            
            /// <summary>
            ///   System.Boolean get_isCoOpMode()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isCoOpMode")]
            ///  extern System.Boolean GET_IS_CO_OP_MODE ();

            
            /// <summary>
            ///   System.Boolean get_isDestroyed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isDestroyed")]
            ///  extern System.Boolean GET_IS_DESTROYED ();

            
            /// <summary>
            ///   System.Boolean get_isEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isEnabled")]
            ///  extern System.Boolean GET_IS_ENABLED ();

            
            /// <summary>
            ///   System.Boolean get_isInGame()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_isInGame")]
            ///  extern System.Boolean GET_IS_IN_GAME ();

            
            /// <summary>
            ///   LastOverworldPortalLocationComponent get_lastOverworldPortalLocation()
            /// </summary>
            /// <returns>class LastOverworldPortalLocationComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_lastOverworldPortalLocation")]
            ///  extern nint GET_LAST_OVERWORLD_PORTAL_LOCATION ();

            
            /// <summary>
            ///   LevelComponent get_level()
            /// </summary>
            /// <returns>class LevelComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_level")]
            ///  extern nint GET_LEVEL ();

            
            /// <summary>
            ///   LevelListenerComponent get_levelListener()
            /// </summary>
            /// <returns>class LevelListenerComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_levelListener")]
            ///  extern nint GET_LEVEL_LISTENER ();

            
            /// <summary>
            ///   PauseComponent get_pause()
            /// </summary>
            /// <returns>class PauseComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pause")]
            ///  extern nint GET_PAUSE ();

            
            /// <summary>
            ///   PauseCommandComponent get_pauseCommand()
            /// </summary>
            /// <returns>class PauseCommandComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_pauseCommand")]
            ///  extern nint GET_PAUSE_COMMAND ();

            
            /// <summary>
            ///   QuestFastForwardDataComponent get_questFastForwardData()
            /// </summary>
            /// <returns>class QuestFastForwardDataComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_questFastForwardData")]
            ///  extern nint GET_QUEST_FAST_FORWARD_DATA ();

            
            /// <summary>
            ///   System.Int32 get_retainCount()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_retainCount")]
            ///  extern System.Int32 GET_RETAIN_COUNT ();

            
            /// <summary>
            ///   SpellItemDataComponent get_spellItemData()
            /// </summary>
            /// <returns>class SpellItemDataComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellItemData")]
            ///  extern nint GET_SPELL_ITEM_DATA ();

            
            /// <summary>
            ///   System.Int32 get_totalComponents()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_totalComponents")]
            ///  extern System.Int32 GET_TOTAL_COMPONENTS ();

            
            /// <summary>
            ///   Entitas.IComponent GetComponent(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>interface Entitas.IComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponent")]
            ///  extern nint GET_COMPONENT (System.Int32 index);

            
            /// <summary>
            ///   System.Int32[] GetComponentIndices()
            /// </summary>
            /// <returns>class System.Int32[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentIndices")]
            ///  extern nint GET_COMPONENT_INDICES ();

            
            /// <summary>
            ///   System.Collections.Generic.Stack<Entitas.IComponent> GetComponentPool(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.Stack<Entitas.IComponent></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponentPool")]
            ///  extern nint GET_COMPONENT_POOL (System.Int32 index);

            
            /// <summary>
            ///   Entitas.IComponent[] GetComponents()
            /// </summary>
            /// <returns>class Entitas.IComponent[]</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetComponents")]
            ///  extern nint GET_COMPONENTS ();

            
            /// <summary>
            ///   System.Boolean HasAnyComponent(System.Int32[] indices)
            /// </summary>
            /// <param name="indices">class System.Int32[]</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasAnyComponent")]
            ///  extern System.Boolean HAS_ANY_COMPONENT (nint indices);

            
            /// <summary>
            ///   System.Boolean HasComponent(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponent")]
            ///  extern System.Boolean HAS_COMPONENT (System.Int32 index);

            
            /// <summary>
            ///   System.Boolean HasComponents(System.Int32[] indices)
            /// </summary>
            /// <param name="indices">class System.Int32[]</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("HasComponents")]
            ///  extern System.Boolean HAS_COMPONENTS (nint indices);

            
            /// <summary>
            ///   System.Void Initialize(System.Int32 creationIndex, System.Int32 totalComponents, System.Collections.Generic.Stack<Entitas.IComponent>[] componentPools, Entitas.ContextInfo contextInfo, Entitas.IAERC aerc)
            /// </summary>
            /// <param name="creationIndex">struct System.Int32</param>
            /// <param name="totalComponents">struct System.Int32</param>
            /// <param name="componentPools">class System.Collections.Generic.Stack<Entitas.IComponent>[]</param>
            /// <param name="contextInfo">class Entitas.ContextInfo</param>
            /// <param name="aerc">interface Entitas.IAERC</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Initialize")]
            ///  extern void INITIALIZE (System.Int32 creationIndex, System.Int32 totalComponents, nint componentPools, nint contextInfo, nint aerc);

            
            /// <summary>
            ///   System.Void InternalDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("InternalDestroy")]
            ///  extern void INTERNAL_DESTROY ();

            
            /// <summary>
            ///   System.Void Reactivate(System.Int32 creationIndex)
            /// </summary>
            /// <param name="creationIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Reactivate")]
            ///  extern void REACTIVATE (System.Int32 creationIndex);

            
            /// <summary>
            ///   System.Void Release(System.Object owner)
            /// </summary>
            /// <param name="owner">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Release")]
            ///  extern void RELEASE (nint owner);

            
            /// <summary>
            ///   System.Void remove_OnComponentAdded(Entitas.EntityComponentChanged value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentChanged</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentAdded")]
            ///  extern void REMOVE_ON_COMPONENT_ADDED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnComponentRemoved(Entitas.EntityComponentChanged value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentChanged</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentRemoved")]
            ///  extern void REMOVE_ON_COMPONENT_REMOVED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnComponentReplaced(Entitas.EntityComponentReplaced value)
            /// </summary>
            /// <param name="value">class Entitas.EntityComponentReplaced</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnComponentReplaced")]
            ///  extern void REMOVE_ON_COMPONENT_REPLACED (nint value);

            
            /// <summary>
            ///   System.Void remove_OnDestroyEntity(Entitas.EntityEvent value)
            /// </summary>
            /// <param name="value">class Entitas.EntityEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnDestroyEntity")]
            ///  extern void REMOVE_ON_DESTROY_ENTITY (nint value);

            
            /// <summary>
            ///   System.Void remove_OnEntityReleased(Entitas.EntityEvent value)
            /// </summary>
            /// <param name="value">class Entitas.EntityEvent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("remove_OnEntityReleased")]
            ///  extern void REMOVE_ON_ENTITY_RELEASED (nint value);

            
            /// <summary>
            ///   System.Void RemoveAllComponents()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllComponents")]
            ///  extern void REMOVE_ALL_COMPONENTS ();

            
            /// <summary>
            ///   System.Void RemoveAllOnEntityReleasedHandlers()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveAllOnEntityReleasedHandlers")]
            ///  extern void REMOVE_ALL_ON_ENTITY_RELEASED_HANDLERS ();

            
            /// <summary>
            ///   System.Void RemoveComponent(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveComponent")]
            ///  extern void REMOVE_COMPONENT (System.Int32 index);

            
            /// <summary>
            ///   System.Void RemoveCrystal()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCrystal")]
            ///  extern void REMOVE_CRYSTAL ();

            
            /// <summary>
            ///   System.Void RemoveExperience()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveExperience")]
            ///  extern void REMOVE_EXPERIENCE ();

            
            /// <summary>
            ///   System.Void RemoveGold()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGold")]
            ///  extern void REMOVE_GOLD ();

            
            /// <summary>
            ///   System.Void RemoveLastOverworldPortalLocation()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLastOverworldPortalLocation")]
            ///  extern void REMOVE_LAST_OVERWORLD_PORTAL_LOCATION ();

            
            /// <summary>
            ///   System.Void RemoveLevel()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLevel")]
            ///  extern void REMOVE_LEVEL ();

            
            /// <summary>
            ///   System.Void RemovePause()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePause")]
            ///  extern void REMOVE_PAUSE ();

            
            /// <summary>
            ///   System.Void RemovePauseCommand()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemovePauseCommand")]
            ///  extern void REMOVE_PAUSE_COMMAND ();

            
            /// <summary>
            ///   System.Void RemoveQuestFastForwardData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveQuestFastForwardData")]
            ///  extern void REMOVE_QUEST_FAST_FORWARD_DATA ();

            
            /// <summary>
            ///   System.Void RemoveSpellItemData()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveSpellItemData")]
            ///  extern void REMOVE_SPELL_ITEM_DATA ();

            
            /// <summary>
            ///   System.Void replaceComponent(System.Int32 index, Entitas.IComponent replacement)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="replacement">interface Entitas.IComponent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("replaceComponent")]
            ///  extern void REPLACE_COMPONENT (System.Int32 index, nint replacement);

            
            /// <summary>
            ///   System.Void ReplaceComponent(System.Int32 index, Entitas.IComponent component)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="component">interface Entitas.IComponent</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceComponent")]
            ///  extern void REPLACE_COMPONENT (System.Int32 index, nint component);

            
            /// <summary>
            ///   System.Void ReplaceCrystal(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCrystal")]
            ///  extern void REPLACE_CRYSTAL (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceCrystalListener(System.Collections.Generic.List<ICrystalListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<ICrystalListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceCrystalListener")]
            ///  extern void REPLACE_CRYSTAL_LISTENER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceExperience(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceExperience")]
            ///  extern void REPLACE_EXPERIENCE (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceExperienceListener(System.Collections.Generic.List<IExperienceListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IExperienceListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceExperienceListener")]
            ///  extern void REPLACE_EXPERIENCE_LISTENER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceGameStateDestroyedListener(System.Collections.Generic.List<IGameStateDestroyedListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IGameStateDestroyedListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGameStateDestroyedListener")]
            ///  extern void REPLACE_GAME_STATE_DESTROYED_LISTENER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceGold(ValueGauge newValue)
            /// </summary>
            /// <param name="newValue">class ValueGauge</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGold")]
            ///  extern void REPLACE_GOLD (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceGoldListener(System.Collections.Generic.List<IGoldListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IGoldListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceGoldListener")]
            ///  extern void REPLACE_GOLD_LISTENER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplaceLastOverworldPortalLocation(UnityEngine.Vector3 newValue)
            /// </summary>
            /// <param name="newValue">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLastOverworldPortalLocation")]
            ///  extern void REPLACE_LAST_OVERWORLD_PORTAL_LOCATION (UnityEngine.Vector3 newValue);

            
            /// <summary>
            ///   System.Void ReplaceLevel(System.Int32 newValue)
            /// </summary>
            /// <param name="newValue">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLevel")]
            ///  extern void REPLACE_LEVEL (System.Int32 newValue);

            
            /// <summary>
            ///   System.Void ReplaceLevelListener(System.Collections.Generic.List<ILevelListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<ILevelListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceLevelListener")]
            ///  extern void REPLACE_LEVEL_LISTENER (nint newValue);

            
            /// <summary>
            ///   System.Void ReplacePause(PauseFlags newFlags)
            /// </summary>
            /// <param name="newFlags">enum PauseFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePause")]
            ///  extern void REPLACE_PAUSE (PauseFlags newFlags);

            
            /// <summary>
            ///   System.Void ReplacePauseCommand(PauseCommand newCommand, PauseFlags newFlags)
            /// </summary>
            /// <param name="newCommand">enum PauseCommand</param>
            /// <param name="newFlags">enum PauseFlags</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplacePauseCommand")]
            ///  extern void REPLACE_PAUSE_COMMAND (PauseCommand newCommand, PauseFlags newFlags);

            
            /// <summary>
            ///   System.Void ReplaceQuestFastForwardData(System.Collections.Generic.Dictionary<QuestData,System.Collections.Generic.Dictionary<UnitSpawner,System.Int32>> newFinishedSpawners)
            /// </summary>
            /// <param name="newFinishedSpawners">class System.Collections.Generic.Dictionary<QuestData,System.Collections.Generic.Dictionary<UnitSpawner,System.Int32>></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceQuestFastForwardData")]
            ///  extern void REPLACE_QUEST_FAST_FORWARD_DATA (nint newFinishedSpawners);

            
            /// <summary>
            ///   System.Void ReplaceSpellItemData(SpellLevelConfig newValue)
            /// </summary>
            /// <param name="newValue">class SpellLevelConfig</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ReplaceSpellItemData")]
            ///  extern void REPLACE_SPELL_ITEM_DATA (nint newValue);

            
            /// <summary>
            ///   System.Void Retain(System.Object owner)
            /// </summary>
            /// <param name="owner">class System.Object</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("Retain")]
            ///  extern void RETAIN (nint owner);

            
            /// <summary>
            ///   System.Void set_isCoOpMode(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isCoOpMode")]
            ///  extern void SET_IS_CO_OP_MODE (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isDestroyed(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isDestroyed")]
            ///  extern void SET_IS_DESTROYED (System.Boolean value);

            
            /// <summary>
            ///   System.Void set_isInGame(System.Boolean value)
            /// </summary>
            /// <param name="value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("set_isInGame")]
            ///  extern void SET_IS_IN_GAME (System.Boolean value);

            
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ToString")]
            ///  extern nint TO_STRING ();
            
            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameStateEntity))]
            ///  extern void .CTOR_00 ();

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_GameStateEntity))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Void AddCrystalListener(System.Collections.Generic.List<ICrystalListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<ICrystalListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCrystalListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_CRYSTAL_LISTENER_00 (nint newValue);

            
            /// <summary>
            ///   System.Void AddCrystalListener(ICrystalListener value)
            /// </summary>
            /// <param name="value">interface ICrystalListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddCrystalListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_CRYSTAL_LISTENER_01 (nint value);

            
            /// <summary>
            ///   System.Void AddExperienceListener(System.Collections.Generic.List<IExperienceListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IExperienceListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExperienceListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_EXPERIENCE_LISTENER_00 (nint newValue);

            
            /// <summary>
            ///   System.Void AddExperienceListener(IExperienceListener value)
            /// </summary>
            /// <param name="value">interface IExperienceListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddExperienceListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_EXPERIENCE_LISTENER_01 (nint value);

            
            /// <summary>
            ///   System.Void AddGameStateDestroyedListener(System.Collections.Generic.List<IGameStateDestroyedListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IGameStateDestroyedListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameStateDestroyedListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_GAME_STATE_DESTROYED_LISTENER_00 (nint newValue);

            
            /// <summary>
            ///   System.Void AddGameStateDestroyedListener(IGameStateDestroyedListener value)
            /// </summary>
            /// <param name="value">interface IGameStateDestroyedListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGameStateDestroyedListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_GAME_STATE_DESTROYED_LISTENER_01 (nint value);

            
            /// <summary>
            ///   System.Void AddGoldListener(System.Collections.Generic.List<IGoldListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<IGoldListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGoldListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_GOLD_LISTENER_00 (nint newValue);

            
            /// <summary>
            ///   System.Void AddGoldListener(IGoldListener value)
            /// </summary>
            /// <param name="value">interface IGoldListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddGoldListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_GOLD_LISTENER_01 (nint value);

            
            /// <summary>
            ///   System.Void AddLevelListener(System.Collections.Generic.List<ILevelListener> newValue)
            /// </summary>
            /// <param name="newValue">class System.Collections.Generic.List<ILevelListener></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLevelListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_LEVEL_LISTENER_00 (nint newValue);

            
            /// <summary>
            ///   System.Void AddLevelListener(ILevelListener value)
            /// </summary>
            /// <param name="value">interface ILevelListener</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("AddLevelListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void ADD_LEVEL_LISTENER_01 (nint value);

            
            /// <summary>
            ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <param name="type">abstract class System.Type</param>
            /// <returns>interface Entitas.IComponent</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameStateEntity))]
            ///  extern nint CREATE_COMPONENT_00 (System.Int32 index, nint type);

            
            /// <summary>
            ///   T CreateComponent(System.Int32 index)
            /// </summary>
            /// <param name="index">struct System.Int32</param>
            /// <returns>class T</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CreateComponent", Search = typeof(Search_GameStateEntity))]
            ///  extern nint CREATE_COMPONENT_01 (System.Int32 index);

            
            /// <summary>
            ///   System.Void RemoveCrystalListener()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCrystalListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_CRYSTAL_LISTENER_00 ();

            
            /// <summary>
            ///   System.Void RemoveCrystalListener(ICrystalListener value, System.Boolean removeComponentWhenEmpty)
            /// </summary>
            /// <param name="value">interface ICrystalListener</param>
            /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveCrystalListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_CRYSTAL_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);

            
            /// <summary>
            ///   System.Void RemoveExperienceListener()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveExperienceListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_EXPERIENCE_LISTENER_00 ();

            
            /// <summary>
            ///   System.Void RemoveExperienceListener(IExperienceListener value, System.Boolean removeComponentWhenEmpty)
            /// </summary>
            /// <param name="value">interface IExperienceListener</param>
            /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveExperienceListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_EXPERIENCE_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);

            
            /// <summary>
            ///   System.Void RemoveGameStateDestroyedListener()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameStateDestroyedListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_GAME_STATE_DESTROYED_LISTENER_00 ();

            
            /// <summary>
            ///   System.Void RemoveGameStateDestroyedListener(IGameStateDestroyedListener value, System.Boolean removeComponentWhenEmpty)
            /// </summary>
            /// <param name="value">interface IGameStateDestroyedListener</param>
            /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGameStateDestroyedListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_GAME_STATE_DESTROYED_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);

            
            /// <summary>
            ///   System.Void RemoveGoldListener()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGoldListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_GOLD_LISTENER_00 ();

            
            /// <summary>
            ///   System.Void RemoveGoldListener(IGoldListener value, System.Boolean removeComponentWhenEmpty)
            /// </summary>
            /// <param name="value">interface IGoldListener</param>
            /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveGoldListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_GOLD_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);

            
            /// <summary>
            ///   System.Void RemoveLevelListener()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLevelListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_LEVEL_LISTENER_00 ();

            
            /// <summary>
            ///   System.Void RemoveLevelListener(ILevelListener value, System.Boolean removeComponentWhenEmpty)
            /// </summary>
            /// <param name="value">interface ILevelListener</param>
            /// <param name="removeComponentWhenEmpty">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("RemoveLevelListener", Search = typeof(Search_GameStateEntity))]
            ///  extern void REMOVE_LEVEL_LISTENER_01 (nint value, System.Boolean removeComponentWhenEmpty);

            
            /// public static partial class Search_GameStateEntity
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
                    ///   System.Void AddCrystalListener(System.Collections.Generic.List<ICrystalListener> newValue)
                    /// </summary>
                    /// public static bool ADD_CRYSTAL_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddCrystalListener", "System.Collections.Generic.List<ICrystalListener>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddCrystalListener(ICrystalListener value)
                    /// </summary>
                    /// public static bool ADD_CRYSTAL_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddCrystalListener", "ICrystalListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddExperienceListener(System.Collections.Generic.List<IExperienceListener> newValue)
                    /// </summary>
                    /// public static bool ADD_EXPERIENCE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExperienceListener", "System.Collections.Generic.List<IExperienceListener>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddExperienceListener(IExperienceListener value)
                    /// </summary>
                    /// public static bool ADD_EXPERIENCE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddExperienceListener", "IExperienceListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddGameStateDestroyedListener(System.Collections.Generic.List<IGameStateDestroyedListener> newValue)
                    /// </summary>
                    /// public static bool ADD_GAME_STATE_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGameStateDestroyedListener", "System.Collections.Generic.List<IGameStateDestroyedListener>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddGameStateDestroyedListener(IGameStateDestroyedListener value)
                    /// </summary>
                    /// public static bool ADD_GAME_STATE_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGameStateDestroyedListener", "IGameStateDestroyedListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddGoldListener(System.Collections.Generic.List<IGoldListener> newValue)
                    /// </summary>
                    /// public static bool ADD_GOLD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGoldListener", "System.Collections.Generic.List<IGoldListener>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddGoldListener(IGoldListener value)
                    /// </summary>
                    /// public static bool ADD_GOLD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddGoldListener", "IGoldListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddLevelListener(System.Collections.Generic.List<ILevelListener> newValue)
                    /// </summary>
                    /// public static bool ADD_LEVEL_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddLevelListener", "System.Collections.Generic.List<ILevelListener>");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void AddLevelListener(ILevelListener value)
                    /// </summary>
                    /// public static bool ADD_LEVEL_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "AddLevelListener", "ILevelListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   Entitas.IComponent CreateComponent(System.Int32 index, System.Type type)
                    /// </summary>
                    /// public static bool CREATE_COMPONENT_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32", "System.Type");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   T CreateComponent(System.Int32 index)
                    /// </summary>
                    /// public static bool CREATE_COMPONENT_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CreateComponent", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveCrystalListener()
                    /// </summary>
                    /// public static bool REMOVE_CRYSTAL_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveCrystalListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveCrystalListener(ICrystalListener value, System.Boolean removeComponentWhenEmpty)
                    /// </summary>
                    /// public static bool REMOVE_CRYSTAL_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveCrystalListener", "ICrystalListener", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveExperienceListener()
                    /// </summary>
                    /// public static bool REMOVE_EXPERIENCE_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveExperienceListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveExperienceListener(IExperienceListener value, System.Boolean removeComponentWhenEmpty)
                    /// </summary>
                    /// public static bool REMOVE_EXPERIENCE_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveExperienceListener", "IExperienceListener", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveGameStateDestroyedListener()
                    /// </summary>
                    /// public static bool REMOVE_GAME_STATE_DESTROYED_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGameStateDestroyedListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveGameStateDestroyedListener(IGameStateDestroyedListener value, System.Boolean removeComponentWhenEmpty)
                    /// </summary>
                    /// public static bool REMOVE_GAME_STATE_DESTROYED_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGameStateDestroyedListener", "IGameStateDestroyedListener", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveGoldListener()
                    /// </summary>
                    /// public static bool REMOVE_GOLD_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGoldListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveGoldListener(IGoldListener value, System.Boolean removeComponentWhenEmpty)
                    /// </summary>
                    /// public static bool REMOVE_GOLD_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveGoldListener", "IGoldListener", "System.Boolean");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveLevelListener()
                    /// </summary>
                    /// public static bool REMOVE_LEVEL_LISTENER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveLevelListener");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void RemoveLevelListener(ILevelListener value, System.Boolean removeComponentWhenEmpty)
                    /// </summary>
                    /// public static bool REMOVE_LEVEL_LISTENER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "RemoveLevelListener", "ILevelListener", "System.Boolean");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}