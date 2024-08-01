using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.Logging;
using Maple.MonoGameAssistant.Core;
using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;


namespace Maple.CatQuest3.GameSourceGen
{
    internal static class CatQuest3GameContextExtensions
    {
        #region Test
        public static void Output(this CatQuest3GameContext @this)
        {
            var database = @this.SpellConfigDatabase._INSTANCE;
            foreach (var item in database.CONTENT_TABLE.Values)
            {
               var classInfo= @this.RuntimeContext.GetMonoClassInfoDTO(item.MonoClass);
                @this.Logger.LogInformation("classinfo:{class}", classInfo.FullName);
            }
            //var database = @this.EquipmentDatabase._INSTANCE;
            //if (database)
            //{
            //    if (database.CONTENT_TABLE)
            //    {
            //        @this.Logger.LogInformation("keyData");
            //        var keydata = database.CONTENT_TABLE.Keys;
            //        @this.Logger.LogInformation("keyData1");
            //        foreach (var item in keydata)
            //        {
            //            @this.Logger.LogInformation("keyData:{k}", item.ToString());
            //        }

            //        @this.Logger.LogInformation("valueData");
            //        var valData = database.CONTENT_TABLE.Values;
            //        foreach (var item in valData)
            //        {


            //            item.GET_DESCRIPTION(out var desc, 1, out var num);
            //            var descfmt = LocalizationTools.Ptr_LocalizationTools.TRANSLATE_OR_DEFAULT_00(desc.Item1, desc.Item2);
            //            var itemDesc = string.Format(descfmt.ToString()!, num.ToString());
            //            var itemName = LocalizationTools.Ptr_LocalizationTools.TRANSLATE_OR_DEFAULT_00(item.ITEM_NAME_TERM, item.ITEM_NAME);
            //            @this.Logger.LogInformation("valueData:{valueData}|{guid}|{name}|{desc}",
            //                item.ToString(),
            //                item.GUID.ToString(),
            //                 itemDesc,
            //                 itemName.ToString());
            //        }

            //        @this.Logger.LogInformation("_dict");
            //        var dicVal = database.CONTENT_TABLE.Dict.AsRefArray();
            //        foreach (var dic in dicVal)
            //        {
            //            var item = dic.Value;
            //            @this.Logger.LogInformation("_dict:{_dict}|{guid}|{name}|{desc}",
            //            item.ToString(),
            //            item.GUID.ToString(),
            //            item.ITEM_NAME.ToString(),
            //            item.ITEM_DESCRIPTION_TERM.ToString());
            //        }
            //    }
            //}
        }
        #endregion

        #region language
        static PMonoString GetLocalName(PMonoString pNameTrm, PMonoString pName)
        {
            return LocalizationTools.Ptr_LocalizationTools.TRANSLATE_OR_DEFAULT_00(pNameTrm, pName);
        }
        static string? GetLocalDesc(PMonoString pNameTrm, PMonoString pName, int num)
        {
            var fmt = GetLocalName(pNameTrm, pName);
            return string.Format(fmt.ToString()!, num.ToString());
        }
        #endregion

        #region GameEnvironment

        public static CatQuest3GameEnvironment GetGameEnvironment(this CatQuest3GameContext @this)
        {
            return new CatQuest3GameEnvironment(@this);
        }
        #endregion

        #region Currency

        public static GameCurrencyDisplayDTO[] GetListGameCurrencyDisplay(this CatQuest3GameContext @this)
        {
            return [
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.Gold.ToString(), DisplayName=EnumGameCurrencyType.Gold.ToString(), DisplayCategory = EnumGameCurrencyType.Gold.ToString(), DisplayDesc = EnumGameCurrencyType.Gold.ToString()},
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.Crystal.ToString(), DisplayName=EnumGameCurrencyType.Crystal.ToString(), DisplayCategory = EnumGameCurrencyType.Crystal.ToString(), DisplayDesc = EnumGameCurrencyType.Crystal.ToString()},
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.Experience.ToString(), DisplayName=EnumGameCurrencyType.Experience.ToString(), DisplayCategory = EnumGameCurrencyType.Experience.ToString(), DisplayDesc = EnumGameCurrencyType.Experience.ToString()}
                ];
        }

        private static int GetGold(this CatQuest3GameEnvironment gameEnvironment)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            return gameStateContext.GET_GOLD().VALUE._CURR_VALUE;
        }
        private static int SetGold(this CatQuest3GameEnvironment gameEnvironment, int val)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            var ptr_gold = gameStateContext.GET_GOLD().VALUE;
            ptr_gold._CURR_VALUE = val;
            return val;
        }

        private static int GetCrystal(this CatQuest3GameEnvironment gameEnvironment)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            return gameStateContext.GET_CRYSTAL().VALUE._CURR_VALUE;
        }
        private static int SetCrystal(this CatQuest3GameEnvironment gameEnvironment, int val)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            var ptr_gold = gameStateContext.GET_CRYSTAL().VALUE;
            ptr_gold._CURR_VALUE = val;
            return val;
        }


        private static int GetExperience(this CatQuest3GameEnvironment gameEnvironment)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            return gameStateContext.GET_EXPERIENCE().VALUE._CURR_VALUE;
        }
        private static int SetExperience(this CatQuest3GameEnvironment gameEnvironment, int val)
        {
            var gameStateContext = gameEnvironment.Ptr_GameStateContext;
            var ptr_gold = gameStateContext.GET_EXPERIENCE().VALUE;
            ptr_gold._CURR_VALUE = val;
            return val;
        }

        public static GameCurrencyInfoDTO GetGameCurrencyInfo(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameCurrencyObjectDTO gameCurrency)
        {
            return (Enum.TryParse<EnumGameCurrencyType>(gameCurrency.CurrencyObject, out var currencyType), currencyType) switch
            {
                (true, EnumGameCurrencyType.Gold) => new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = gameEnvironment.GetGold().ToString(), },
                (true, EnumGameCurrencyType.Crystal) => new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = gameEnvironment.GetCrystal().ToString(), },
                (true, EnumGameCurrencyType.Experience) => new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = gameEnvironment.GetExperience().ToString() },
                _ => GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {gameCurrency.CurrencyObject}")
            };
        }
        public static GameCurrencyInfoDTO UpdateGameCurrencyInfo(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameCurrencyModifyDTO gameCurrency)
        {
            var count = (Enum.TryParse<EnumGameCurrencyType>(gameCurrency.CurrencyObject, out var currencyType), currencyType) switch
            {
                (true, EnumGameCurrencyType.Gold) => gameEnvironment.SetGold(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Crystal) => gameEnvironment.SetCrystal(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Experience) => gameEnvironment.SetExperience(gameCurrency.IntValue),
                _ => GameException.Throw<int>($"NOT FOUND {gameCurrency.CurrencyObject}")
            };
            return new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = count.ToString() };
        }
        #endregion

        #region Inventory
        private static GameValueInfoDTO[] GetEquipmentAtt(EquipmentItemData.Ptr_EquipmentItemData itemData)
        {
            return [];
        }
        private static GameValueInfoDTO[] GetShipBlueprintAtt(ShipBlueprintItemData.Ptr_ShipBlueprintItemData itemData)
        {
            return [];
        }
        public static IEnumerable<GameInventoryDisplayDTO> GetListGameInventoryDisplay(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {
            var equipmentTable = gameEnvironment.Ptr_EquipmentDatabase.CONTENT_TABLE;
            foreach (var item in equipmentTable.Values)
            {
                var guid = item.GUID.ToString();
                if (false == string.IsNullOrEmpty(guid))
                {

                    var name = GetLocalName(item.ITEM_NAME_TERM, item.ITEM_NAME);


                    item.GET_DESCRIPTION(out var localDesc, 1, out var num);

                    var desc = GetLocalDesc(localDesc.Item1, localDesc.Item2, num);

                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = guid,
                        DisplayCategory = EnumGameInventoryType.Equipment.ToString(),
                        DisplayName = name.ToString(),
                        DisplayDesc = desc,
                        ItemAttributes = GetEquipmentAtt(item)
                    };
                }

            }


            var shipBulepriteTable = gameEnvironment.Ptr_ShipBlueprintDatabase.CONTENT_TABLE;
            foreach (var item in shipBulepriteTable.Values)
            {
                var guid = item.GUID.ToString();


                if (false == string.IsNullOrEmpty(guid))
                {
                    var name = GetLocalName(item.ITEM_NAME_TERM, item.ITEM_NAME);
                    item.GET_DESCRIPTION(out var localDesc, 1, out var num);
                    var desc = GetLocalDesc(localDesc.Item1, localDesc.Item2, num);
                    yield return new GameInventoryDisplayDTO()
                    {
                        ObjectId = guid,
                        DisplayCategory = EnumGameInventoryType.ShipBlueprint.ToString(),
                        DisplayName = name.ToString(),
                        DisplayDesc = desc,
                        ItemAttributes = GetShipBlueprintAtt(item)
                    };
                }

            }
        }

        public static bool FindEquipmentByUnlocked(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out EquipmentItemData.Ptr_EquipmentItemData itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);

            var lockedData = gameEnvironment.Ptr_UnlockedEquipmentListComponent.VALUE;
            foreach (var locked in lockedData)
            {
                itemData = locked.ITEM_DATA;
                if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    level = locked.LEVEL._CURR_VALUE;
                    return true;
                }
            }
            return default;
        }
        public static bool FindEquipmentByTable(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out EquipmentItemData.Ptr_EquipmentItemData itemData)
        {
            Unsafe.SkipInit(out itemData);
            var itemTable = gameEnvironment.Ptr_EquipmentDatabase.CONTENT_TABLE;
            foreach (var item in itemTable.Values)
            {
                if (item.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    itemData = item;
                    return true;
                }


            }
            return default;

        }

        public static bool FindShipBlueprintByUnlocked(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipBlueprintItemData.Ptr_ShipBlueprintItemData itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);

            var lockedData = gameEnvironment.Ptr_UnlockedShipBlueprintsComponent.VALUE;
            foreach (var locked in lockedData.COLLECTION)
            {
                itemData = locked.ITEM_DATA;
                if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    level = locked.LEVEL._CURR_VALUE;
                    return true;
                }
            }
            return default;
        }
        public static bool FindShipBlueprintByTable(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipBlueprintItemData.Ptr_ShipBlueprintItemData itemData)
        {
            Unsafe.SkipInit(out itemData);
            var itemTable = gameEnvironment.Ptr_ShipBlueprintDatabase.CONTENT_TABLE;
            foreach (var item in itemTable.Values)
            {
                if (item.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    itemData = item;
                    return true;
                }


            }
            return default;

        }

        public static GameInventoryInfoDTO GetGameInventoryInfo(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameInventoryObjectDTO inventoryObjectDTO)
        {
            if (false == Enum.TryParse<EnumGameInventoryType>(inventoryObjectDTO.InventoryCategory, out var inventoryCategory))
            {
                return GameInventoryObjectDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryObjectDTO.InventoryCategory);
            }
            if (inventoryCategory == EnumGameInventoryType.Equipment)
            {
                if (gameEnvironment.FindEquipmentByUnlocked(inventoryObjectDTO.InventoryObject, out var _, out var level))
                {
                    return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = level, };
                }
            }
            else if (inventoryCategory == EnumGameInventoryType.ShipBlueprint)
            {
                if (gameEnvironment.FindShipBlueprintByUnlocked(inventoryObjectDTO.InventoryObject, out var _, out var level))
                {
                    return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, InventoryCount = level, };
                }
            }
            else if (inventoryCategory == EnumGameInventoryType.ShipSpell)
            {

            }
            else if (inventoryCategory == EnumGameInventoryType.Spell)
            {

            }
            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject };

        }
        #endregion
    }

    public enum EnumGameCurrencyType
    {
        None = 0,
        Gold = 1,
        Crystal = 2,
        Experience = 3,
    }

    public enum EnumGameInventoryType
    {
        Equipment,
        ShipBlueprint,
        ShipSpell,
        Spell,
    }

}
