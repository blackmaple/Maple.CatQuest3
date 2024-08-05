using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Microsoft.Extensions.Logging;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace Maple.CatQuest3.GameSourceGen
{
    internal static class CatQuest3GameContextExtensions
    {
        static GroupGeneric? GroupGeneric { set; get; }

        public static GroupGeneric.Ptr_GroupGeneric GetCombatGroup(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {

            var matcher = GameMatcher.Ptr_GameMatcher.GET_COMBAT_AGENT();
            var groupObject = gameEnvironment.Ptr_GameContext.GET_GROUP(matcher);
            if (GroupGeneric is null)
            {
                var classInfo = @this.RuntimeContext.GetMonoCollectorClassInfo(groupObject.MonoClass);
                GroupGeneric = new GroupGeneric(@this, classInfo);
            }
            return GroupGeneric.IsFrom(groupObject);
        }

        #region Test
        public static void Output(this CatQuest3GameContext @this)
        {
            var gameEnvironment = @this.GetGameEnvironment();

            //var state = gameEnvironment.GetInputState();
            //@this.Logger.LogInformation("state:{state}", state);
            var playerShip = gameEnvironment.Ptr_GameContext.GET_PLAYER_SHIP_ENTITY();
            if (playerShip)
            {
                GameplayHelper.Ptr_GameplayHelper.HEAL_AND_REVIVE_PLAYER_SHIP();
                GameplayHelper.Ptr_GameplayHelper.REPLENISH_PLAYER_SHIP_AMMO_CLIP_00();

                //var combatInfo = playerShip.GET_COMBAT_AGENT().VALUE;
                //var heathInfo = combatInfo.HEALTH;
                //heathInfo._CURR_VALUE = heathInfo._MAX_VALUE;
                //if (playerShip.GET_HAS_GUN_AMMO())
                //{
                //    var gun = playerShip.GET_GUN_AMMO().VALUE;
                //    gun._CURR_VALUE = gun._MAX_VALUE;
                //}

            }

            var num = gameEnvironment.Ptr_ControllerManager.PLAYER_NUM;
            for (int i = 0; i < num; ++i)
            {
                var player = gameEnvironment.GetEntityWithPlayerId(i);
                if (player)
                {



                    //var id = player.GET_HAS_PLAYER_ID();
                    //@this.Logger.LogInformation("id=>{id}", id.ToString());

                    //var combatInfo = player.GET_COMBAT_AGENT().VALUE;
                    //var heathInfo = combatInfo.HEALTH;
                    //heathInfo._CURR_VALUE = heathInfo._MAX_VALUE;
                    //if (player.GET_HAS_MANA())
                    //{
                    //    var mana = player.GET_MANA().VALUE;
                    //    mana._CURR_VALUE = mana._MAX_VALUE;
                    //}
                    //if (player.GET_HAS_GUN_AMMO())
                    //{
                    //    var gun = player.GET_GUN_AMMO().VALUE;
                    //    gun._CURR_VALUE = gun._MAX_VALUE;
                    //}

                    GunReloadHandler.Ptr_GunReloadHandler.FORCE_RELOAD(player);
                    //player.GET_ANIMATOR().VALUE.RESET_TRIGGER_01(@this.AnimatorHash.JUST_SPAWNED);
                    //player.SET_IS_JUST_SPAWNED(false);

                    RestTriggeredEventHandler.Ptr_RestTriggeredEventHandler.HEAL_PLAYER_TO_MAX(player, gameEnvironment.Ptr_GameContext, true, false);


                    player.GET_TRANSFORM().VALUE.GET_POSITION(out var local);
                    gameEnvironment.CreateSpawnTextEvent(local, "dotnet9 cool");
                }
            }

            //var matcher = GameMatcher.Ptr_GameMatcher.GET_COMBAT_AGENT();
            //var groupObject = gameEnvironment.Ptr_GameContext.GET_GROUP(matcher);

            //var classInfo = @this.RuntimeContext.GetMonoCollectorClassInfo(groupObject.MonoClass);
            //var groupGeneric = new GroupGeneric(@this, classInfo);
            //var ptrGroup = groupGeneric.IsFrom(groupObject);
            ////    var content = ptrGroup.TO_STRING().ToString();
            ////    @this.Logger.LogInformation("c:{c}", content);

            ////        var size = ptrGroup._ENTITIES.Size;
            ////        var arr = ptrGroup._ENTITIES.AsRefArray().Length;
            ////     @this.Logger.LogInformation("size:{c}/arr:{a}", size, arr);
            ////      var count = 0;
            //foreach (var obj in ptrGroup._ENTITIES.AsRefArray())
            //{
            //    var combat = obj.Value;
            //    var character = combat.GET_IS_PLAYER_CHARACTER();
            //    var playership = combat.GET_IS_PLAYER_SHIP();
            //    var monster = combat.GET_IS_MONSTER();
            //    var ship = combat.GET_IS_SHIP();
            //    var ncp = combat.GET_IS_NPC();
            //    @this.Logger.LogInformation("charctert=>{charctert}/playership=>{playership}/=>monster=>{monster}/ship=>{ship}/ncp=>{ncp}",
            //        character, playership, monster, ship, ncp);

            //    if (!character && !playership && !ncp && (monster || ship))
            //    {
            //        //         combat.GET_COMBAT_AGENT().VALUE.TAKE_DAMAGE_01(int.MaxValue);
            //        //         combat.SET_IS_KILLED(true);
            //        //
            //        //         combat.GET_ANIMATOR().VALUE.PLAY_03(@this.AnimatorHash.DIE_STATE, 0, 0f);

            //        //         count++;
            //    }
            //    else if (character || playership)
            //    {



            //    //    RestTriggeredEventHandler.Ptr_RestTriggeredEventHandler.HEAL_PLAYER_TO_MAX(combat, gameEnvironment.Ptr_GameContext, true, true);

            //        //var combatInfo = combat.GET_COMBAT_AGENT().VALUE;
            //        //var maxValue = combatInfo.HEALTH._MAX_VALUE;
            //        //combatInfo.HEAL_01(maxValue);


            //        //    combatInfo.CREATE_COMBAT_AGENT_HEALTH_UPDATED_EVENT();
            //        //combat.REPLACE_TINT(TintType.FLASH, new MonoGameAssistant.RawDotNet.REF_UNITY_COLOR()
            //        //{
            //        //    r = 1F,
            //        //    g = 0.9F,
            //        //    b = 0.9F,
            //        //    a = 1f,
            //        //}, 0.5f);
            //        ////  combat.SET_IS_JUST_SPAWNED(false);

            //        //     RestTriggeredEventHandler.Ptr_RestTriggeredEventHandler.HEAL_PLAYER_TO_MAX(combat, gameEnvironment.Ptr_GameContext, false, false);
            //        //   combat.GET_ANIMATOR().VALUE.SET_TRIGGER_01(@this.AnimatorHash.SLEEP);



            //    }

            //    //if (combat.GET_IS_IN_COMBAT_MODE())
            //    //{
            //    //    combat.GET_COMBAT_AGENT().VALUE.TAKE_DAMAGE_01(int.MaxValue);
            //    //    combat.SET_IS_KILLED(true);
            //    //}
            //}
            ////  gameEnvironment.TryShowMessage($"最强技能C#:帮猫咪秒杀了{count}个倒霉的小可爱");

            //var database = @this.SpellConfigDatabase._INSTANCE.CONTENT_TABLE.Values;
            //foreach (var item in database)
            //{
            //    var spellConfig = @this.SpellConfig.IsFrom(item);
            //    if (spellConfig)
            //    {

            //        foreach (var level in spellConfig.SPELL_LEVELS)
            //        {
            //            var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
            //            var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

            //            @this.Logger.LogInformation("spellConfig=>{name}:{desc}", name.ToString(), desc.ToString());
            //        }
            //    }

            //    var shipSpellConfig = @this.ShipSpellConfig.IsFrom(item);
            //    if (shipSpellConfig)
            //    {
            //        foreach (var level in shipSpellConfig.ATTACK_CONFIG_LEVELS)
            //        {
            //            var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
            //            var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

            //            @this.Logger.LogInformation("ShipSpellConfig=>{name}:{desc}", name.ToString(), desc.ToString());

            //        }
            //    }


            //}



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

            var database = gameEnvironment.Ptr_SpellConfigDatabase.CONTENT_TABLE;
            foreach (var item in database.Values)
            {
                var spellConfig = @this.SpellConfig.IsFrom(item);
                if (spellConfig)
                {
                    var guid = spellConfig.GUID.ToString();
                    if (string.IsNullOrEmpty(guid) == false)
                    {
                        foreach (var level in spellConfig.SPELL_LEVELS)
                        {

                            var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
                            var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

                            yield return new GameInventoryDisplayDTO() { ObjectId = guid, DisplayName = name.ToString(), DisplayDesc = desc.ToString(), DisplayCategory = EnumGameInventoryType.Spell.ToString(), };
                            break;
                        }
                    }

                }
                else
                {
                    var shipSpellConfig = @this.ShipSpellConfig.IsFrom(item);
                    if (shipSpellConfig)
                    {
                        var guid = shipSpellConfig.GUID.ToString();
                        if (string.IsNullOrEmpty(guid) == false)
                        {
                            foreach (var level in shipSpellConfig.ATTACK_CONFIG_LEVELS)
                            {
                                var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
                                var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

                                yield return new GameInventoryDisplayDTO() { ObjectId = guid, DisplayName = name.ToString(), DisplayDesc = desc.ToString(), DisplayCategory = EnumGameInventoryType.ShipSpell.ToString(), };
                                break;
                            }
                        }

                    }

                }


            }

        }

        private static bool FindEquipmentByUnlocked(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out EquipmentItemData.Ptr_EquipmentItemData itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);

            var unlockedData = gameEnvironment.Ptr_UnlockedEquipmentListComponent.VALUE;
            foreach (var unlocked in unlockedData)
            {
                itemData = unlocked.ITEM_DATA;
                if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    level = unlocked.LEVEL._CURR_VALUE;
                    return true;
                }
            }
            return default;
        }
        private static bool FindEquipmentByTable(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out EquipmentItemData.Ptr_EquipmentItemData itemData)
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

        private static bool FindShipBlueprintByUnlocked(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipBlueprintItemData.Ptr_ShipBlueprintItemData itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);

            var unlockedData = gameEnvironment.Ptr_UnlockedShipBlueprintsComponent.VALUE;
            foreach (var unlocked in unlockedData.COLLECTION)
            {
                itemData = unlocked.ITEM_DATA;
                if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                {
                    level = unlocked.LEVEL._CURR_VALUE;
                    return true;
                }
            }
            return default;
        }
        private static bool FindShipBlueprintByTable(this CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipBlueprintItemData.Ptr_ShipBlueprintItemData itemData)
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


        private static bool FindShipSpellByUnlocked(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipSpellConfig.Ptr_ShipSpellConfig itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);
            var unlockedData = gameEnvironment.Ptr_UnlockedShipSpellTableComponent;
            foreach (var item in unlockedData.VALUE.DICT.AsRefArray())
            {
                var config = item.Value;
                itemData = @this.ShipSpellConfig.IsFrom(config.SPELL_CONFIG);
                if (itemData)
                {
                    if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                    {
                        level = config.LEVEL._CURR_VALUE;
                        return true;
                    }
                }
            }
            return default;
        }
        private static bool FindShipSpellByTable(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out ShipSpellConfig.Ptr_ShipSpellConfig itemData)
        {
            Unsafe.SkipInit(out itemData);
            var database = gameEnvironment.Ptr_SpellConfigDatabase.CONTENT_TABLE;
            foreach (var item in database.Values)
            {
                var shipSpellConfig = @this.ShipSpellConfig.IsFrom(item);
                if (shipSpellConfig)
                {
                    if (shipSpellConfig.GUID.AsReadOnlySpan().SequenceEqual(guid))
                    {
                        itemData = shipSpellConfig;
                        return true;
                    }
                }
            }
            return default;
        }

        private static bool FindSpellByUnlocked(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out SpellConfig.Ptr_SpellConfig itemData, out int level)
        {
            Unsafe.SkipInit(out level);
            Unsafe.SkipInit(out itemData);
            var unlockedData = gameEnvironment.Ptr_UnlockedSpellTableComponent;
            foreach (var item in unlockedData.VALUE.DICT.AsRefArray())
            {
                var config = item.Value;
                itemData = @this.SpellConfig.IsFrom(config.SPELL_CONFIG);
                if (itemData)
                {
                    if (itemData.GUID.AsReadOnlySpan().SequenceEqual(guid))
                    {
                        level = config.LEVEL._CURR_VALUE;
                        return true;
                    }
                }
            }
            return default;
        }
        private static bool FindSpellByTable(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, ReadOnlySpan<char> guid, out SpellConfig.Ptr_SpellConfig itemData)
        {
            Unsafe.SkipInit(out itemData);
            var database = gameEnvironment.Ptr_SpellConfigDatabase.CONTENT_TABLE;
            foreach (var item in database.Values)
            {
                var spellConfig = @this.SpellConfig.IsFrom(item);
                if (spellConfig)
                {
                    if (spellConfig.GUID.AsReadOnlySpan().SequenceEqual(guid))
                    {
                        itemData = spellConfig;
                        return true;
                    }
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
            int level;
            if (inventoryCategory == EnumGameInventoryType.Equipment)
            {
                _ = gameEnvironment.FindEquipmentByUnlocked(inventoryObjectDTO.InventoryObject, out var _, out level);
            }
            else if (inventoryCategory == EnumGameInventoryType.ShipBlueprint)
            {
                _ = gameEnvironment.FindShipBlueprintByUnlocked(inventoryObjectDTO.InventoryObject, out var _, out level);
            }
            else if (inventoryCategory == EnumGameInventoryType.ShipSpell)
            {
                _ = @this.FindShipSpellByUnlocked(gameEnvironment, inventoryObjectDTO.InventoryObject, out var _, out level);
            }
            else if (inventoryCategory == EnumGameInventoryType.Spell)
            {
                _ = @this.FindSpellByUnlocked(gameEnvironment, inventoryObjectDTO.InventoryObject, out var _, out level);
            }
            else
            {
                level = 0;
            }
            return new GameInventoryInfoDTO() { ObjectId = inventoryObjectDTO.InventoryObject, DisplayValue = level.ToString() };

        }


        public static GameInventoryInfoDTO UpdateGameInventoryInfo(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameInventoryModifyDTO inventoryModifyDTO)
        {
            if (false == Enum.TryParse<EnumGameInventoryType>(inventoryModifyDTO.InventoryCategory, out var inventoryCategory))
            {
                return GameInventoryModifyDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryModifyDTO.InventoryCategory);
            }
            int level = 0;
            int newLevel = 0;
            var guid = inventoryModifyDTO.InventoryObject;
            if (inventoryCategory == EnumGameInventoryType.Equipment)
            {
                if (false == gameEnvironment.FindEquipmentByTable(guid, out var itemData))
                {
                    return GameInventoryModifyDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryModifyDTO.InventoryCategory);
                }
                if (gameEnvironment.FindEquipmentByUnlocked(guid, out var _, out var oldlevel))
                {
                    level = inventoryModifyDTO.ThrowIfRemove(oldlevel);
                }
                gameEnvironment.CreateAddEquipmentCommand(itemData, level, out var _, out newLevel);
            }
            else if (inventoryCategory == EnumGameInventoryType.ShipBlueprint)
            {
                if (false == gameEnvironment.FindShipBlueprintByTable(guid, out var itemData))
                {
                    return GameInventoryModifyDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryModifyDTO.InventoryCategory);
                }
                if (gameEnvironment.FindShipBlueprintByUnlocked(guid, out var _, out var oldlevel))
                {
                    inventoryModifyDTO.ThrowIfRemove(oldlevel);
                }
                gameEnvironment.CreateAddShipBlueprintCommand(itemData, out var success);
                newLevel = success ? (oldlevel + 1) : oldlevel;

            }
            else if (inventoryCategory == EnumGameInventoryType.ShipSpell)
            {
                if (false == @this.FindShipSpellByTable(gameEnvironment, guid, out var itemData))
                {
                    return GameInventoryModifyDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryModifyDTO.InventoryCategory);
                }
                if (@this.FindShipSpellByUnlocked(gameEnvironment, inventoryModifyDTO.InventoryObject, out _, out var oldlevel))
                {
                    inventoryModifyDTO.ThrowIfRemove(oldlevel);
                }
                gameEnvironment.CreateAddNewShipSpellCommand(itemData, out _, out _, out newLevel, out var success);
                if (success == false)
                {
                    newLevel = oldlevel;
                }

            }
            else if (inventoryCategory == EnumGameInventoryType.Spell)
            {
                if (false == @this.FindSpellByTable(gameEnvironment, guid, out var itemData))
                {
                    return GameInventoryModifyDTO.ThrowNotFound<GameInventoryInfoDTO>(inventoryModifyDTO.InventoryCategory);
                }
                if (@this.FindSpellByUnlocked(gameEnvironment, inventoryModifyDTO.InventoryObject, out var _, out var oldlevel))
                {
                    inventoryModifyDTO.ThrowIfRemove(oldlevel);
                }
                gameEnvironment.CreateAddNewSpellCommand(itemData, out _, out var success);
                newLevel = success ? (oldlevel + 1) : oldlevel;

            }

            return new GameInventoryInfoDTO() { ObjectId = inventoryModifyDTO.InventoryObject, DisplayValue = newLevel.ToString() };


        }
        #endregion


        #region Switch
        public static GameSwitchDisplayDTO[] GetListGameSwitchDisplay(this CatQuest3GameContext @this)
        {
            return [
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Kill_All.ToString(), DisplayName="全图秒杀(F11)" ,DisplayDesc="范围:当前地图的怪物//注意:可能卡剧情?",UIType = (int)EnumGameSwitchUIType.Button ,},
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Kill_Combat.ToString() ,DisplayName="战斗秒杀(F12)",DisplayDesc="范围:当前战斗的怪物",UIType = (int)EnumGameSwitchUIType.Button },
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Heal.ToString() ,DisplayName="状态恢复(F9)",DisplayDesc="回复HP/MP/弹药",UIType = (int)EnumGameSwitchUIType.Button },

                ];
        }

        public static void GameKillMonster(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, bool combatMode = false)
        {
            @this.Logger.LogInformation("s=>{s}", gameEnvironment.GetSceneType());

            var combatGroup = @this.GetCombatGroup(gameEnvironment);
            var entities = combatGroup._ENTITIES.AsRefArray();
            foreach (var entityObj in entities)
            {
                var entity = entityObj.Value;
                var character = entity.GET_IS_PLAYER_CHARACTER();
                var playership = entity.GET_IS_PLAYER_SHIP();
                var monster = entity.GET_IS_MONSTER();
                var ship = entity.GET_IS_SHIP();
                var ncp = entity.GET_IS_NPC();

                if (!character && !playership && !ncp && (monster || ship))
                {
                    if (combatMode)
                    {
                        if (entity.GET_IS_IN_COMBAT_MODE() == false)
                        {
                            break;
                        }
                    }

                    entity.GET_TRANSFORM().VALUE.GET_POSITION(out var position);
                    gameEnvironment.CreateSpawnTextEvent_Kill(position, "Kill");
                    entity.GET_COMBAT_AGENT().VALUE.TAKE_DAMAGE_01(int.MaxValue);
                    entity.SET_IS_KILLED(true);
                    entity.GET_ANIMATOR().VALUE.PLAY_03(@this.AnimatorHash.DIE_STATE, 0, 0f);
                }
            }
        }
        public static void GameHealPlayer(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {
            var playerShip = gameEnvironment.Ptr_GameContext.GET_PLAYER_SHIP_ENTITY();
            if (playerShip)
            {
                GameplayHelper.Ptr_GameplayHelper.HEAL_AND_REVIVE_PLAYER_SHIP();
                GameplayHelper.Ptr_GameplayHelper.REPLENISH_PLAYER_SHIP_AMMO_CLIP_00();
            }

            var num = gameEnvironment.Ptr_ControllerManager.PLAYER_NUM;
            for (int i = 0; i < num; ++i)
            {
                var player = gameEnvironment.GetEntityWithPlayerId(i);
                if (player)
                {
                    GunReloadHandler.Ptr_GunReloadHandler.FORCE_RELOAD(player);
                    RestTriggeredEventHandler.Ptr_RestTriggeredEventHandler.HEAL_PLAYER_TO_MAX(player, gameEnvironment.Ptr_GameContext, true, false);
                }
            }

        }
        public static GameSwitchDisplayDTO UpdateGameSwitchDisplay(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameSwitchModifyDTO switchModifyDTO)
        {
            if (false == Enum.TryParse<EnumGameSwitchDisplay>(switchModifyDTO.SwitchObjectId, out var result))
            {
                return GameException.Throw<GameSwitchDisplayDTO>($"NOT FOUND {switchModifyDTO.SwitchObjectId}");
            }
            if (result == EnumGameSwitchDisplay.Kill_All)
            {
                @this.GameKillMonster(gameEnvironment, false);
            }
            else if (result == EnumGameSwitchDisplay.Kill_Combat)
            {
                @this.GameKillMonster(gameEnvironment, true);
            }
            else if (result == EnumGameSwitchDisplay.Heal)
            {
                @this.GameHealPlayer(gameEnvironment);
            }
            return new GameSwitchDisplayDTO() { ObjectId = switchModifyDTO.SwitchObjectId };
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

    public enum EnumGameSwitchDisplay
    {
        Kill_Combat,
        Kill_All,
        Heal,

    }
}
