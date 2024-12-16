
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
    /// class ["ProjectStar".""."ShipSpell"]
    /// [SpellBase]=>[InventoryItemBase]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x0200069EU)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [83, 104, 105, 112, 83, 112, 101, 108, 108])]
    
                
    // class 0x8 LevelValueGauge level
     [MonoCollectorSearchFieldAttribute(typeof(LevelValueGauge.Ptr_LevelValueGauge),"level", "LEVEL")]
            
    // class 0xC Sigtrap.Relays.Relay<InventoryItemBase,System.Int32> onUpgradedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onUpgradedEvent", "ON_UPGRADED_EVENT")]
            
    // abstract class 0x10 SpellConfigBase spellConfig
      [MonoCollectorSearchFieldAttribute(typeof(SpellConfigBase.Ptr_SpellConfigBase),"spellConfig", "SPELL_CONFIG")]
    public partial class ShipSpell
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "ShipSpell";
        //public static byte[] Static_ClassName { get; } = [83, 104, 105, 112, 83, 112, 101, 108, 108];

        //public const uint Const_TypeToken = 0x0200069EU;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_ShipSpell(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_ShipSpell(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_ShipSpell obj) => obj._ptr;
            public static implicit operator bool(Ptr_ShipSpell obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."ShipSpell"]
        /// </summary>
        public partial class ShipSpell
        { 

            
            
            /// <summary>
            ///   System.Boolean CanAffordUpgradeAtLevel(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanAffordUpgradeAtLevel")]
            ///  extern System.Boolean CAN_AFFORD_UPGRADE_AT_LEVEL (System.Int32 previewLevel);

            
            /// <summary>
            ///   SpellLevelConfigBase get_spellLevelConfig()
            /// </summary>
            /// <returns>abstract class SpellLevelConfigBase</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_spellLevelConfig")]
            ///  extern nint GET_SPELL_LEVEL_CONFIG ();

            
            /// <summary>
            ///   System.Single GetCurrLevelAttackStatMultiplier(AttackStatFlags attackStatFlag)
            /// </summary>
            /// <param name="attackStatFlag">enum AttackStatFlags</param>
            /// <returns>struct System.Single</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrLevelAttackStatMultiplier")]
            ///  extern System.Single GET_CURR_LEVEL_ATTACK_STAT_MULTIPLIER (AttackStatFlags attackStatFlag);

            
            /// <summary>
            ///   System.Boolean LevelUp()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("LevelUp")]
            ///  extern System.Boolean LEVEL_UP ();

            
            /// <summary>
            ///   System.Boolean SetSpellLevel(System.Int32 spellLevel)
            /// </summary>
            /// <param name="spellLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("SetSpellLevel")]
            ///  extern System.Boolean SET_SPELL_LEVEL (System.Int32 spellLevel);
            
            
            
            /// <summary>
            ///   System.Void .ctor(System.Int32 levelValue, SpellConfigBase spellConfigValue)
            /// </summary>
            /// <param name="levelValue">struct System.Int32</param>
            /// <param name="spellConfigValue">abstract class SpellConfigBase</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpell))]
            ///  extern void .CTOR_00 (System.Int32 levelValue, nint spellConfigValue);

            
            /// <summary>
            ///   System.Void .ctor(System.Int32 levelValue, SpellConfigBase spellConfigValue)
            /// </summary>
            /// <param name="levelValue">struct System.Int32</param>
            /// <param name="spellConfigValue">abstract class SpellConfigBase</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpell))]
            ///  extern void .CTOR_01 (System.Int32 levelValue, nint spellConfigValue);

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_ShipSpell))]
            ///  extern void .CTOR_02 ();

            
            /// <summary>
            ///   System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanBeUpgradedTo", Search = typeof(Search_ShipSpell))]
            ///  extern System.Boolean CAN_BE_UPGRADED_TO_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///  abstract System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanBeUpgradedTo", Search = typeof(Search_ShipSpell))]
            ///  extern System.Boolean CAN_BE_UPGRADED_TO_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.String GetGUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGUID", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_GUID_00 ();

            
            /// <summary>
            ///  abstract System.String GetGUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGUID", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_GUID_01 ();

            
            /// <summary>
            ///   System.String GetItemDescription(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemDescription", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_DESCRIPTION_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///  abstract System.String GetItemDescription(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemDescription", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_DESCRIPTION_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.String GetItemName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemName", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_NAME_00 ();

            
            /// <summary>
            ///  abstract System.String GetItemName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemName", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_NAME_01 ();

            
            /// <summary>
            ///   UnityEngine.Sprite GetItemUIIcon()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUIIcon", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_UI_ICON_00 ();

            
            /// <summary>
            ///  abstract UnityEngine.Sprite GetItemUIIcon()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUIIcon", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_ITEM_UI_ICON_01 ();

            
            /// <summary>
            ///   System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
            /// </summary>
            /// <param name="goldCost">struct System.Int32&</param>
            /// <param name="secondaryCost">struct System.Int32&</param>
            /// <param name="levelDiff">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUpgradeCost", Search = typeof(Search_ShipSpell))]
            ///  extern void GET_ITEM_UPGRADE_COST_00 (System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff);

            
            /// <summary>
            ///  abstract System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
            /// </summary>
            /// <param name="goldCost">struct System.Int32&</param>
            /// <param name="secondaryCost">struct System.Int32&</param>
            /// <param name="levelDiff">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUpgradeCost", Search = typeof(Search_ShipSpell))]
            ///  extern void GET_ITEM_UPGRADE_COST_01 (System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff);

            
            /// <summary>
            ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPreviewItemUIIcon", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_PREVIEW_ITEM_UI_ICON_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPreviewItemUIIcon", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_PREVIEW_ITEM_UI_ICON_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   GameEntity GetSpellOwner()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpellOwner", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_SPELL_OWNER_00 ();

            
            /// <summary>
            ///  abstract GameEntity GetSpellOwner()
            /// </summary>
            /// <returns>class GameEntity</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpellOwner", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_SPELL_OWNER_01 ();

            
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String,System.Int32> GetSpellSaveData()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpellSaveData", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_SPELL_SAVE_DATA_00 ();

            
            /// <summary>
            ///  abstract System.Collections.Generic.Dictionary<System.String,System.Int32> GetSpellSaveData()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,System.Int32></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetSpellSaveData", Search = typeof(Search_ShipSpell))]
            ///  extern nint GET_SPELL_SAVE_DATA_01 ();

            
            /// <summary>
            ///   System.Boolean IsEquipped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEquipped", Search = typeof(Search_ShipSpell))]
            ///  extern System.Boolean IS_EQUIPPED_00 ();

            
            /// <summary>
            ///  abstract System.Boolean IsEquipped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEquipped", Search = typeof(Search_ShipSpell))]
            ///  extern System.Boolean IS_EQUIPPED_01 ();

            
            /// <summary>
            ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
            /// </summary>
            /// <param name="targetLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ProcessUpgradeConfirmation", Search = typeof(Search_ShipSpell))]
            ///  extern void PROCESS_UPGRADE_CONFIRMATION_00 (System.Int32 targetLevel);

            
            /// <summary>
            ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
            /// </summary>
            /// <param name="targetLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ProcessUpgradeConfirmation", Search = typeof(Search_ShipSpell))]
            ///  extern void PROCESS_UPGRADE_CONFIRMATION_01 (System.Int32 targetLevel);

            
            /// public static partial class Search_ShipSpell
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 levelValue, SpellConfigBase spellConfigValue)
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "SpellConfigBase");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void .ctor(System.Int32 levelValue, SpellConfigBase spellConfigValue)
                    /// </summary>
                    /// public static bool .CTOR_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "System.Int32", "SpellConfigBase");
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
                    ///   System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool CAN_BE_UPGRADED_TO_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanBeUpgradedTo", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool CAN_BE_UPGRADED_TO_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "CanBeUpgradedTo", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetGUID()
                    /// </summary>
                    /// public static bool GET_GUID_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetGUID");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetGUID()
                    /// </summary>
                    /// public static bool GET_GUID_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetGUID");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetItemDescription(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool GET_ITEM_DESCRIPTION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemDescription", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetItemDescription(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool GET_ITEM_DESCRIPTION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemDescription", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.String GetItemName()
                    /// </summary>
                    /// public static bool GET_ITEM_NAME_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemName");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.String GetItemName()
                    /// </summary>
                    /// public static bool GET_ITEM_NAME_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemName");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Sprite GetItemUIIcon()
                    /// </summary>
                    /// public static bool GET_ITEM_UI_ICON_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemUIIcon");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract UnityEngine.Sprite GetItemUIIcon()
                    /// </summary>
                    /// public static bool GET_ITEM_UI_ICON_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemUIIcon");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
                    /// </summary>
                    /// public static bool GET_ITEM_UPGRADE_COST_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemUpgradeCost", "System.Int32&", "System.Int32&", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
                    /// </summary>
                    /// public static bool GET_ITEM_UPGRADE_COST_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetItemUpgradeCost", "System.Int32&", "System.Int32&", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool GET_PREVIEW_ITEM_UI_ICON_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPreviewItemUIIcon", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
                    /// </summary>
                    /// public static bool GET_PREVIEW_ITEM_UI_ICON_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetPreviewItemUIIcon", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   GameEntity GetSpellOwner()
                    /// </summary>
                    /// public static bool GET_SPELL_OWNER_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSpellOwner");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract GameEntity GetSpellOwner()
                    /// </summary>
                    /// public static bool GET_SPELL_OWNER_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSpellOwner");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Collections.Generic.Dictionary<System.String,System.Int32> GetSpellSaveData()
                    /// </summary>
                    /// public static bool GET_SPELL_SAVE_DATA_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSpellSaveData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Collections.Generic.Dictionary<System.String,System.Int32> GetSpellSaveData()
                    /// </summary>
                    /// public static bool GET_SPELL_SAVE_DATA_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "GetSpellSaveData");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Boolean IsEquipped()
                    /// </summary>
                    /// public static bool IS_EQUIPPED_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsEquipped");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///  abstract System.Boolean IsEquipped()
                    /// </summary>
                    /// public static bool IS_EQUIPPED_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "IsEquipped");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
                    /// </summary>
                    /// public static bool PROCESS_UPGRADE_CONFIRMATION_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ProcessUpgradeConfirmation", "System.Int32");
                    ///     
                    ///  
                    /// 

                    
                    /// <summary>
                    ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
                    /// </summary>
                    /// public static bool PROCESS_UPGRADE_CONFIRMATION_01 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, "ProcessUpgradeConfirmation", "System.Int32");
                    ///     
                    ///  
                    /// 
            /// 
            /// }

        }


}