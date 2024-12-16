using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using System.Runtime.CompilerServices;

namespace Maple.CatQuest3.Metadata.GameSourceGen
{
    public class CatQuest3GameEnvironment
    {
        public CatQuest3GameEnvironment(CatQuest3GameContext @this)
        {
            CatQuest3GameContext = @this;
            var contexts = @this.Contexts.SHARED_INSTANCE;
            if (contexts)
            {
                Ptr_GameContext = contexts.GAME;
                Ptr_GameStateContext = contexts.GAME_STATE;
                Ptr_GUIContext = contexts.G_UI;
                Ptr_InputContext = contexts.INPUT;
                Ptr_FrameworkContext = contexts.FRAMEWORK;
                Ptr_WorldContext = contexts.WORLD;





                //last set
                Ptr_Contexts = contexts;

            }
            Ptr_EquipmentDatabase = @this.EquipmentDatabase._INSTANCE;
            Ptr_ShipBlueprintDatabase = @this.ShipBlueprintDatabase._INSTANCE;
            Ptr_SpellConfigDatabase = @this.SpellConfigDatabase._INSTANCE;
            Ptr_ControllerManager = @this.ControllerManager._INSTANCE;
            Ptr_CombatTextDatabase = @this.CombatTextDatabase._INSTANCE;
        }
        public CatQuest3GameContext CatQuest3GameContext { get; }

        #region Contexts

        public Contexts.Ptr_Contexts Ptr_Contexts { get; }
        public GameContext.Ptr_GameContext Ptr_GameContext { get; }
        public GameStateContext.Ptr_GameStateContext Ptr_GameStateContext { get; }
        public GUIContext.Ptr_GUIContext Ptr_GUIContext { get; }
        public FrameworkContext.Ptr_FrameworkContext Ptr_FrameworkContext { get; }
        public WorldContext.Ptr_WorldContext Ptr_WorldContext { get; }
        public InputContext.Ptr_InputContext Ptr_InputContext { get; }
        #endregion

        #region Res
        public CombatTextDatabase.Ptr_CombatTextDatabase Ptr_CombatTextDatabase { get; }

        public ControllerManager.Ptr_ControllerManager Ptr_ControllerManager { get; }


        public EquipmentDatabase.Ptr_EquipmentDatabase Ptr_EquipmentDatabase { get; }
        public UnlockedEquipmentListComponent.Ptr_UnlockedEquipmentListComponent Ptr_UnlockedEquipmentListComponent => Ptr_GameContext.GET_UNLOCKED_EQUIPMENT_LIST();

        public ShipBlueprintDatabase.Ptr_ShipBlueprintDatabase Ptr_ShipBlueprintDatabase { get; }
        public UnlockedShipBlueprintsComponent.Ptr_UnlockedShipBlueprintsComponent Ptr_UnlockedShipBlueprintsComponent => Ptr_GameContext.GET_UNLOCKED_SHIP_BLUEPRINTS();
        public SpellConfigDatabase.Ptr_SpellConfigDatabase Ptr_SpellConfigDatabase { get; }
        public UnlockedSpellTableComponent.Ptr_UnlockedSpellTableComponent Ptr_UnlockedSpellTableComponent => Ptr_GameContext.GET_UNLOCKED_SPELL_TABLE();
        public UnlockedShipSpellTableComponent.Ptr_UnlockedShipSpellTableComponent Ptr_UnlockedShipSpellTableComponent => Ptr_GameContext.GET_UNLOCKED_SHIP_SPELL_TABLE();

        #endregion


        public bool TryGetZoneType(out ZoneType zoneType)
        {
            Unsafe.SkipInit(out zoneType);

            var worldEntity = Ptr_WorldContext.GET_CURRENT_ZONE_ENTITY();
            if (worldEntity)
            {
                var currentZoneComponent = worldEntity.GET_CURRENT_ZONE();
                zoneType = currentZoneComponent.ZONE;
                return true;
            }

            return false;

        }

        public bool IsLoaded()
        {
            return TryGetZoneType(out _);
        }
        public bool ThrowIfNotLoaded()
        {
            if (IsLoaded())
            {
                return true;
            }
            return GameException.ThrowIfNotLoaded<bool>();

        }


        public nint CreateAddEquipmentCommand(nint data, int level, out int prevLevel, out int newLevel)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_EQUIPMENT_COMMAND(Ptr_GameContext, data, level, out prevLevel, out newLevel);
        }
        public nint CreateAddNewShipSpellCommand(nint data, out nint newSpellConfig, out int prevLevel, out int newLevel, out bool success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_NEW_SHIP_SPELL_COMMAND(Ptr_GameContext, data, out newSpellConfig, out prevLevel, out newLevel, out success);
        }
        public nint CreateAddNewSpellCommand(nint data, out nint newSpellConfig, out bool success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_NEW_SPELL_COMMAND(Ptr_GameContext, data, out newSpellConfig, out success);
        }
        public nint CreateAddShipBlueprintCommand(nint data, out bool success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_SHIP_BLUEPRINT_COMMAND(Ptr_GameContext, data, out success);
        }

        public GameEntity.Ptr_GameEntity GetEntityWithPlayerId(int index)
        {
            return ContextsExtensions.Ptr_ContextsExtensions.GET_ENTITY_WITH_PLAYER_ID(Ptr_GameContext, index);
        }

        public void CreateSpawnTextEvent(in REF_MONO_VECTOR3 position, string msg)
        {
            using var gc_msg = CatQuest3GameContext.T2(msg);
            var saveStoneHealText = Ptr_CombatTextDatabase.SAVE_STONE_HEAL_TEXT;
            GameContextExtensions.Ptr_GameContextExtensions.CREATE_SPAWN_TEXT_EVENT(Ptr_GameContext, position, gc_msg, saveStoneHealText);
        }
        public void CreateSpawnTextEvent_Heal(in REF_MONO_VECTOR3 position, string msg)
        {
            using var gc_msg = CatQuest3GameContext.T2(msg);
            var saveStoneHealText = Ptr_CombatTextDatabase.SAVE_STONE_HEAL_TEXT;
            GameContextExtensions.Ptr_GameContextExtensions.CREATE_SPAWN_TEXT_EVENT(Ptr_GameContext, position, gc_msg, saveStoneHealText);
        }

        public void CreateSpawnTextEvent_Kill(in REF_MONO_VECTOR3 position, string msg)
        {
            using var gc_msg = CatQuest3GameContext.T2(msg);
            var saveStoneHealText = Ptr_CombatTextDatabase.DAMAGE_TAKEN_TEXT_ANIMATION;
            GameContextExtensions.Ptr_GameContextExtensions.CREATE_SPAWN_TEXT_EVENT(Ptr_GameContext, position, gc_msg, saveStoneHealText);
        }

        public bool TryShowMessage(string? str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return default;
            }
            var isShowing = Ptr_GUIContext.GET_MESSAGE_PANEL_ENTITY().GET_U_I_PANEL_DISPLAY_STATUS().IS_SHOWING;
            if (isShowing)
            {
                return default; ;
            }
            var msgPanel = Ptr_GUIContext.GET_MESSAGE_PANEL().VALUE;
            if (msgPanel.Valid() == false)
            {
                return default;
            }
            using var gc_msg = CatQuest3GameContext.T2(str);
            var msg = gc_msg.Target;

            using var gc_line = CatQuest3GameContext.Line.GCNew<Line.Ptr_Line>(true);
            var line = gc_line.Target;
            line.CONTENT = msg;

            using var gc_msgUIInfo = CatQuest3GameContext.MessageUIInfo.GCNew<MessageUIInfo.Ptr_MessageUIInfo>(true);
            var msgUIInfo = gc_msgUIInfo.Target;
            msgUIInfo.CONTENT_MESSAGE = line;

            msgPanel.SHOW_00(msgUIInfo, nint.Zero);
            return true;
        }
    }
}
