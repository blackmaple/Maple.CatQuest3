
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
    /// class ["ProjectStar".""."Equipment"]
    /// [InventoryItemBase]=>[System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], 0x02000698U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114], [], [69, 113, 117, 105, 112, 109, 101, 110, 116])]
    
                
    // class 0x8 LevelValueGauge level
      [MonoCollectorSearchFieldAttribute(typeof(LevelValueGauge.Ptr_LevelValueGauge),"level", "LEVEL")]
            
    // class 0xC Sigtrap.Relays.Relay<InventoryItemBase,System.Int32> onUpgradedEvent
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"onUpgradedEvent", "ON_UPGRADED_EVENT")]
            
    // class 0x10 ProjectStar.Data.EquipmentItemData itemData
      [MonoCollectorSearchFieldAttribute(typeof(EquipmentItemData.Ptr_EquipmentItemData),"itemData", "ITEM_DATA")]
    public partial class Equipment
    { 
        //public const string Const_ImageName = "ProjectStar";
        //public static byte[] Static_ImageName { get; } = [80, 114, 111, 106, 101, 99, 116, 83, 116, 97, 114];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "Equipment";
        //public static byte[] Static_ClassName { get; } = [69, 113, 117, 105, 112, 109, 101, 110, 116];

        //public const uint Const_TypeToken = 0x02000698U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_Equipment(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_Equipment(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_Equipment obj) => obj._ptr;
            public static implicit operator bool(Ptr_Equipment obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["ProjectStar".""."Equipment"]
        /// </summary>
        public partial class Equipment
        { 

            
            
            /// <summary>
            ///   System.Boolean CanAffordUpgradeAtLevel(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanAffordUpgradeAtLevel")]
            ///  extern System.Boolean CAN_AFFORD_UPGRADE_AT_LEVEL (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.Boolean CanUncapLevel()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanUncapLevel")]
            ///  extern System.Boolean CAN_UNCAP_LEVEL ();

            
            /// <summary>
            ///   System.Boolean CheckForAbilityChanges(System.Int32 newLevel)
            /// </summary>
            /// <param name="newLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CheckForAbilityChanges")]
            ///  extern System.Boolean CHECK_FOR_ABILITY_CHANGES (System.Int32 newLevel);

            
            /// <summary>
            ///   System.Int32 get_attack()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_attack")]
            ///  extern System.Int32 GET_ATTACK ();

            
            /// <summary>
            ///   System.Int32 get_defence()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_defence")]
            ///  extern System.Int32 GET_DEFENCE ();

            
            /// <summary>
            ///   System.Int32 get_health()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_health")]
            ///  extern System.Int32 GET_HEALTH ();

            
            /// <summary>
            ///   System.Int32 get_magic()
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_magic")]
            ///  extern System.Int32 GET_MAGIC ();

            
            /// <summary>
            ///   System.Collections.Generic.IList<LevelableEquipmentAbilityData> GetAbilities()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<LevelableEquipmentAbilityData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAbilities")]
            ///  extern nint GET_ABILITIES ();

            
            /// <summary>
            ///   System.Collections.Generic.IList<LevelableEquipmentAbilityData> GetAbilitiesWhere(System.Predicate<LevelableEquipmentAbilityData> predicate)
            /// </summary>
            /// <param name="predicate">class System.Predicate<LevelableEquipmentAbilityData></param>
            /// <returns>interface System.Collections.Generic.IList<LevelableEquipmentAbilityData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAbilitiesWhere")]
            ///  extern nint GET_ABILITIES_WHERE (nint predicate);

            
            /// <summary>
            ///   System.Collections.Generic.IList<LevelableEquipmentAbilityData> GetAllAbilityLevels()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<LevelableEquipmentAbilityData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetAllAbilityLevels")]
            ///  extern nint GET_ALL_ABILITY_LEVELS ();

            
            /// <summary>
            ///   System.Collections.Generic.IList<LevelableEquipmentAbilityData> GetCurrentlyEquippedAbilities()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IList<LevelableEquipmentAbilityData></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetCurrentlyEquippedAbilities")]
            ///  extern nint GET_CURRENTLY_EQUIPPED_ABILITIES ();

            
            /// <summary>
            ///   System.Boolean TryGetNextAbilityThresholdLevel(System.Int32& nextThreshold)
            /// </summary>
            /// <param name="nextThreshold">struct System.Int32&</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("TryGetNextAbilityThresholdLevel")]
            ///  extern System.Boolean TRY_GET_NEXT_ABILITY_THRESHOLD_LEVEL (System.Int32& nextThreshold);
            
            
            
            /// <summary>
            ///   System.Void .ctor(ProjectStar.Data.EquipmentItemData itemData, System.Int32 level)
            /// </summary>
            /// <param name="itemData">class ProjectStar.Data.EquipmentItemData</param>
            /// <param name="level">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Equipment))]
            ///  extern void .CTOR_00 (nint itemData, System.Int32 level);

            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor", Search = typeof(Search_Equipment))]
            ///  extern void .CTOR_01 ();

            
            /// <summary>
            ///   System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanBeUpgradedTo", Search = typeof(Search_Equipment))]
            ///  extern System.Boolean CAN_BE_UPGRADED_TO_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///  abstract System.Boolean CanBeUpgradedTo(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("CanBeUpgradedTo", Search = typeof(Search_Equipment))]
            ///  extern System.Boolean CAN_BE_UPGRADED_TO_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.String GetGUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGUID", Search = typeof(Search_Equipment))]
            ///  extern nint GET_GUID_00 ();

            
            /// <summary>
            ///  abstract System.String GetGUID()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetGUID", Search = typeof(Search_Equipment))]
            ///  extern nint GET_GUID_01 ();

            
            /// <summary>
            ///   System.String GetItemDescription(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemDescription", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_DESCRIPTION_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///  abstract System.String GetItemDescription(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemDescription", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_DESCRIPTION_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.String GetItemName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemName", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_NAME_00 ();

            
            /// <summary>
            ///  abstract System.String GetItemName()
            /// </summary>
            /// <returns>class System.String</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemName", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_NAME_01 ();

            
            /// <summary>
            ///   UnityEngine.Sprite GetItemUIIcon()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUIIcon", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_UI_ICON_00 ();

            
            /// <summary>
            ///  abstract UnityEngine.Sprite GetItemUIIcon()
            /// </summary>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUIIcon", Search = typeof(Search_Equipment))]
            ///  extern nint GET_ITEM_UI_ICON_01 ();

            
            /// <summary>
            ///   System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
            /// </summary>
            /// <param name="goldCost">struct System.Int32&</param>
            /// <param name="secondaryCost">struct System.Int32&</param>
            /// <param name="levelDiff">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUpgradeCost", Search = typeof(Search_Equipment))]
            ///  extern void GET_ITEM_UPGRADE_COST_00 (System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff);

            
            /// <summary>
            ///  abstract System.Void GetItemUpgradeCost(System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff)
            /// </summary>
            /// <param name="goldCost">struct System.Int32&</param>
            /// <param name="secondaryCost">struct System.Int32&</param>
            /// <param name="levelDiff">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetItemUpgradeCost", Search = typeof(Search_Equipment))]
            ///  extern void GET_ITEM_UPGRADE_COST_01 (System.Int32& goldCost, System.Int32& secondaryCost, System.Int32 levelDiff);

            
            /// <summary>
            ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPreviewItemUIIcon", Search = typeof(Search_Equipment))]
            ///  extern nint GET_PREVIEW_ITEM_UI_ICON_00 (System.Int32 previewLevel);

            
            /// <summary>
            ///   UnityEngine.Sprite GetPreviewItemUIIcon(System.Int32 previewLevel)
            /// </summary>
            /// <param name="previewLevel">struct System.Int32</param>
            /// <returns>class UnityEngine.Sprite</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("GetPreviewItemUIIcon", Search = typeof(Search_Equipment))]
            ///  extern nint GET_PREVIEW_ITEM_UI_ICON_01 (System.Int32 previewLevel);

            
            /// <summary>
            ///   System.Boolean IsEquipped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEquipped", Search = typeof(Search_Equipment))]
            ///  extern System.Boolean IS_EQUIPPED_00 ();

            
            /// <summary>
            ///  abstract System.Boolean IsEquipped()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("IsEquipped", Search = typeof(Search_Equipment))]
            ///  extern System.Boolean IS_EQUIPPED_01 ();

            
            /// <summary>
            ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
            /// </summary>
            /// <param name="targetLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ProcessUpgradeConfirmation", Search = typeof(Search_Equipment))]
            ///  extern void PROCESS_UPGRADE_CONFIRMATION_00 (System.Int32 targetLevel);

            
            /// <summary>
            ///   System.Void ProcessUpgradeConfirmation(System.Int32 targetLevel)
            /// </summary>
            /// <param name="targetLevel">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("ProcessUpgradeConfirmation", Search = typeof(Search_Equipment))]
            ///  extern void PROCESS_UPGRADE_CONFIRMATION_01 (System.Int32 targetLevel);

            
            /// public static partial class Search_Equipment
            /// {
            /// 
            ///     
                    
                    /// <summary>
                    ///   System.Void .ctor(ProjectStar.Data.EquipmentItemData itemData, System.Int32 level)
                    /// </summary>
                    /// public static bool .CTOR_00 (Maple.MonoGameAssistant.Model.MonoMethodInfoDTO monoMethodInfoDTO)
                    ///     =>  Maple.MonoGameAssistant.MonoCollector.MonoCollectorExtensions.SearchMonoMethodInfo(monoMethodInfoDTO, ".ctor", "ProjectStar.Data.EquipmentItemData", "System.Int32");
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