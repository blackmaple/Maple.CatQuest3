using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;


namespace Maple.CatQuest3.GameSourceGen
{
    internal static class CatQuest3GameContextExtensions
    {
        #region Init Game data
        static GroupGeneric? GroupGeneric { set; get; }
        static GroupGeneric? GUIGroupGeneric { set; get; }

        public static GroupGeneric.Ptr_GroupGeneric GetGroup(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameMatcher.Ptr_GameMatcher matcher)
        {
            var groupObject = gameEnvironment.Ptr_GameContext.GET_GROUP(matcher);
            if (GroupGeneric is null)
            {
                var classInfo = @this.RuntimeContext.GetMonoCollectorClassInfo(groupObject.MonoClass);
                GroupGeneric = new GroupGeneric(@this, classInfo);
            }
            return GroupGeneric.IsFrom(groupObject);

        }
        public static GroupGeneric.Ptr_GroupGeneric GetCombatGroup(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {
            var matcher = GameMatcher.Ptr_GameMatcher.GET_COMBAT_AGENT();
            return @this.GetGroup(gameEnvironment, matcher);
        }
        public static GroupGeneric.Ptr_GroupGeneric GetChestGroup(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {
            var matcher = GameMatcher.Ptr_GameMatcher.GET_CHEST();
            return @this.GetGroup(gameEnvironment, matcher);
        }
        public static GroupGeneric.Ptr_GroupGeneric GetMapIconGroup(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment)
        {
            var matcher = GUIMatcher.Ptr_GUIMatcher.GET_MAP_ICON();
            var groupObject = gameEnvironment.Ptr_GUIContext.GET_GROUP(matcher);
            if (GUIGroupGeneric is null)
            {
                var classInfo = @this.RuntimeContext.GetMonoCollectorClassInfo(groupObject.MonoClass);
                GUIGroupGeneric = new GroupGeneric(@this, classInfo);
            }
            return GUIGroupGeneric.IsFrom(groupObject);
        }


        public static IEnumerable<GameImageData> LoadGameImageData(this CatQuest3GameContext @this)
        {
            var skillInfo = @this.SkinInfoData._INSTANCE;
            var goldInfo = skillInfo.GOLD_SKIN_INFO;
            var expInfo = skillInfo.EXP_SKIN_INFO;
            var magic = skillInfo.MAGIC_CRYSTAL_SKIN_INFO;

            if (goldInfo)
            {
                yield return new GameImageData()
                {
                    ObjectId = EnumGameCurrencyType.Gold.ToString(),
                    Category = EnumGameCurrencyType.Gold.ToString(),
                    Ptr_Sprite = goldInfo.MAIN
                };
            }
            if (expInfo)
            {
                yield return new GameImageData()
                {
                    ObjectId = EnumGameCurrencyType.Exp.ToString(),
                    Category = EnumGameCurrencyType.Exp.ToString(),
                    Ptr_Sprite = expInfo.MAIN
                };
            }
            if (magic)
            {
                yield return new GameImageData()
                {
                    ObjectId = EnumGameCurrencyType.Crystal.ToString(),
                    Category = EnumGameCurrencyType.Crystal.ToString(),
                    Ptr_Sprite = magic.MAIN
                };
            }


            var equipmentTable = @this.EquipmentDatabase._INSTANCE.CONTENT_TABLE;
            foreach (var item in equipmentTable.Values)
            {
                var guid = item.GUID.ToString();
                if (false == string.IsNullOrEmpty(guid))
                {
                    yield return new GameImageData()
                    {
                        Category = EnumGameInventoryType.Equipment.ToString(),
                        ObjectId = guid,
                        Ptr_Sprite = item.GET_UI_ICON_SPRITE(int.MaxValue)
                    };

                }

            }


            var shipBulepriteTable = @this.ShipBlueprintDatabase._INSTANCE.CONTENT_TABLE;
            foreach (var item in shipBulepriteTable.Values)
            {
                var guid = item.GUID.ToString();
                if (false == string.IsNullOrEmpty(guid))
                {
                    yield return new GameImageData()
                    {
                        Category = EnumGameInventoryType.ShipBlueprint.ToString(),
                        ObjectId = guid,
                        Ptr_Sprite = item.GET_UI_ICON_SPRITE(int.MaxValue)
                    };

                }

            }

            var database = @this.SpellConfigDatabase._INSTANCE.CONTENT_TABLE;
            foreach (var item in database.Values)
            {
                var spellConfig = @this.SpellConfig.IsFrom(item);
                if (spellConfig)
                {
                    var guid = spellConfig.GUID.ToString();
                    if (string.IsNullOrEmpty(guid) == false)
                    {
                        var skills = spellConfig.SPELL_LEVELS.AsReadOnlySpan();
                        if (skills.IsEmpty == false)
                        {
                            var level = skills[^1];
                            yield return new GameImageData()
                            {
                                Category = EnumGameInventoryType.Spell.ToString(),
                                ObjectId = guid,
                                Ptr_Sprite = level.UI_SPRITE
                            };

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
                            var skills = shipSpellConfig.ATTACK_CONFIG_LEVELS.AsReadOnlySpan();
                            if (skills.IsEmpty == false)
                            {
                                var level = skills[^1];
                                yield return new GameImageData()
                                {
                                    Category = EnumGameInventoryType.ShipSpell.ToString(),
                                    ObjectId = guid,
                                    Ptr_Sprite = level.UI_SPRITE
                                };

                            }
                        }

                    }

                }
            }

        }
        public static IEnumerable<UnitySpriteImageData> GetListUnitySpriteImageData(this CatQuest3GameContext @this, UnityEngineContext unityEngine, GameImageData[] spriteDatas)
        {
            foreach (var spriteData in spriteDatas)
            {
                if (false == spriteData.Ptr_Sprite.Valid())
                {
                    continue;
                }


                var pIconData = unityEngine.ReadSprite2Png2(spriteData.Ptr_Sprite);
                if (pIconData.Valid())
                {

                    yield return new UnitySpriteImageData()
                    {
                        Category = spriteData.Category,
                        Name = spriteData.ObjectId,
                        ImageData = pIconData,
                    };
                }
            }
        }
        #endregion

        #region Test
        public static void Output(this CatQuest3GameContext @this)
        {
            return;
            using (@this.Logger.Running())
            {
                var gameEnvironment = @this.GetGameEnvironment();
                var guiEntityGroup = @this.GetMapIconGroup(gameEnvironment);
                var guiEntities = guiEntityGroup.GUIEntity.AsRefArray();
                foreach (var guiEntitySlot in guiEntities)
                {
                    @this.Logger.LogInformation("1");
                    var guiEntity = guiEntitySlot.Value;
                    @this.Logger.LogInformation("2");

                    var mapIcon = guiEntity.GET_MAP_ICON();
                    @this.Logger.LogInformation("3");

                    var world = mapIcon.WORLD_ENTITY_LINK;
                    @this.Logger.LogInformation("4");

                    if (world)
                    {
                        @this.Logger.LogInformation("5");
                        var t = world.GET_TRANSFORM();
                        @this.Logger.LogInformation("6");
                        if (t && t.VALUE)
                        {
                            @this.Logger.LogInformation("7");
                            if (world.GET_HAS_CHEST())
                            {
                                @this.Logger.LogInformation("8");
                                world.GET_TRANSFORM().VALUE.GET_POSITION(out var p);
                                @this.Logger.LogInformation("chest:{x}/{y}/{z}", p.x, p.y, p.z);
                            }
                        }
                    }
                    //if (mapIcon.MAP_ICON_TYPE == MapIconType.Chest)
                    //{

                    //    world.GET_TRANSFORM().VALUE.GET_POSITION(out var p);
                    //    @this.Logger.LogInformation("map:{x}/{y}/{z}", p.x, p.y, p.z);
                    //}


                }
            }
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
                 new GameCurrencyDisplayDTO(){ ObjectId = EnumGameCurrencyType.Exp.ToString(), DisplayName=EnumGameCurrencyType.Exp.ToString(), DisplayCategory = EnumGameCurrencyType.Exp.ToString(), DisplayDesc = EnumGameCurrencyType.Exp.ToString()}
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
                (true, EnumGameCurrencyType.Exp) => new GameCurrencyInfoDTO() { ObjectId = gameCurrency.CurrencyObject, DisplayValue = gameEnvironment.GetExperience().ToString() },
                _ => GameException.Throw<GameCurrencyInfoDTO>($"NOT FOUND {gameCurrency.CurrencyObject}")
            };
        }
        public static GameCurrencyInfoDTO UpdateGameCurrencyInfo(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, GameCurrencyModifyDTO gameCurrency)
        {
            var count = (Enum.TryParse<EnumGameCurrencyType>(gameCurrency.CurrencyObject, out var currencyType), currencyType) switch
            {
                (true, EnumGameCurrencyType.Gold) => gameEnvironment.SetGold(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Crystal) => gameEnvironment.SetCrystal(gameCurrency.IntValue),
                (true, EnumGameCurrencyType.Exp) => gameEnvironment.SetExperience(gameCurrency.IntValue),
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
                        var skills = spellConfig.SPELL_LEVELS.AsReadOnlySpan();
                        if (skills.IsEmpty == false)
                        {
                            //获取最后一个
                            var level = skills[^1];
                            var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
                            var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

                            yield return new GameInventoryDisplayDTO() { ObjectId = guid, DisplayName = name.ToString(), DisplayDesc = desc.ToString(), DisplayCategory = EnumGameInventoryType.Spell.ToString(), };

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
                            var skills = shipSpellConfig.ATTACK_CONFIG_LEVELS.AsReadOnlySpan();
                            if (false == skills.IsEmpty)
                            {
                                //获取最后一个
                                var level = skills[^1];
                                var name = GetLocalName(level.SPELL_NAME_TERM, level.SPELL_NAME);
                                var desc = GetLocalName(level.SPELL_DESCRIPTION_TERM, level.SPELL_DESCRIPTION);

                                yield return new GameInventoryDisplayDTO() { ObjectId = guid, DisplayName = name.ToString(), DisplayDesc = desc.ToString(), DisplayCategory = EnumGameInventoryType.ShipSpell.ToString(), };
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
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Kill_All.ToString(), DisplayName="全图秒杀(F11)" ,DisplayDesc="范围:当前地图的怪物//注意:可能卡剧情?(禁止大地图使用)",UIType = (int)EnumGameSwitchUIType.Button ,},
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Kill_Combat.ToString() ,DisplayName="战斗秒杀(F12)",DisplayDesc="范围:当前战斗的怪物",UIType = (int)EnumGameSwitchUIType.Button },
                    new GameSwitchDisplayDTO(){ObjectId = EnumGameSwitchDisplay.Heal.ToString() ,DisplayName="状态恢复(F9)",DisplayDesc="回复HP/MP/弹药",UIType = (int)EnumGameSwitchUIType.Button },

                ];
        }

        public static void GameKillMonster(this CatQuest3GameContext @this, CatQuest3GameEnvironment gameEnvironment, bool combatMode = false)
        {
            //var b = gameEnvironment.TryGetZoneType(out var zoneType);
            //@this.Logger.LogInformation("get:{get}/s=>{s}", b, zoneType);

            var combatGroup = @this.GetCombatGroup(gameEnvironment);
            var entities = combatGroup.GameEntity.AsRefArray();
            foreach (var entityObj in entities)
            {
                var entity = entityObj.Value;

                //战斗中的秒杀
                if (combatMode)
                {
                    if (entity.GET_IS_IN_COMBAT_MODE() == false)
                    {
                        continue;
                    }
                }
                else
                {
                    if (!gameEnvironment.TryGetZoneType(out var zoneType))
                    {
                        continue;
                    }
                    if (zoneType == ZoneType.Overworld)
                    {
                        continue;
                    }
                }


                var character = entity.GET_IS_PLAYER_CHARACTER();
                var playership = entity.GET_IS_PLAYER_SHIP();
                var monster = entity.GET_IS_MONSTER();
                var ship = entity.GET_IS_SHIP();
                var ncp = entity.GET_IS_NPC();
                if (character || playership)
                {
                    entity.GET_TRANSFORM().VALUE.GET_POSITION(out var position);
                    gameEnvironment.CreateSpawnTextEvent(position, "c# coooooooool");
                }
                else if (!ncp && (monster || ship))
                {


                    entity.GET_TRANSFORM().VALUE.GET_POSITION(out var position);
                    gameEnvironment.CreateSpawnTextEvent_Kill(position, "kill");
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
                    player.GET_TRANSFORM().VALUE.GET_POSITION(out var position);
                    gameEnvironment.CreateSpawnTextEvent_Heal(position, "c# gives you power");


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
        Exp = 3,
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

    public class GameImageData
    {
        public required string Category { set; get; }
        public required string ObjectId { set; get; }
        public Sprite.Ptr_Sprite Ptr_Sprite { set; get; }


    }
}
