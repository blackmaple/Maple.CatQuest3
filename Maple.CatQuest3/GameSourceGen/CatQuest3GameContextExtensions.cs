﻿using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Logger;
using Microsoft.Extensions.Logging;


namespace Maple.CatQuest3.GameSourceGen
{
    internal static class CatQuest3GameContextExtensions
    {
        #region Test
        public static void Output(this CatQuest3GameContext @this)
        {
           var database= @this.EquipmentDatabase._INSTANCE;
            if(database)
            {
                if (database.CONTENT_TABLE)
                {
                    @this.Logger.LogInformation("keyData");
                    var keydata = database.CONTENT_TABLE.AsRef().keyData;
                    foreach (var item in keydata)
                    {
                        @this.Logger.LogInformation("keyData:{k}",item.ToString());
                    }

                    @this.Logger.LogInformation("valueData");
                    var valData = database.CONTENT_TABLE.AsRef().valueData;
                    foreach (var item in valData)
                    {
                        @this.Logger.LogInformation("valueData:{valueData}|{guid}|{name}|{desc}", 
                            item.ToString(),
                            item.GUID.ToString(),
                            item.ITEM_NAME.ToString(),
                            item.ITEM_DESCRIPTION_TERM.ToString());

                    }

                    @this.Logger.LogInformation("_dict");
                    var dicVal = database.CONTENT_TABLE.AsRef()._dict.AsRefArray();
                    foreach (var dic in dicVal)
                    {
                        var item = dic.Value;
                        @this.Logger.LogInformation("_dict:{_dict}|{guid}|{name}|{desc}",
                        item.ToString(),
                        item.GUID.ToString(),
                        item.ITEM_NAME.ToString(),
                        item.ITEM_DESCRIPTION_TERM.ToString());
                    }
                }
            }
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
            var count =  (Enum.TryParse<EnumGameCurrencyType>(gameCurrency.CurrencyObject, out var currencyType), currencyType) switch
            {
                (true, EnumGameCurrencyType.Gold) => gameEnvironment.SetGold(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Crystal) => gameEnvironment.SetCrystal(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Experience) => gameEnvironment.SetExperience(gameCurrency.IntValue),
                _ => GameException.Throw<int>($"NOT FOUND {gameCurrency.CurrencyObject}")
            };
            return new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = count.ToString() };
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


}
