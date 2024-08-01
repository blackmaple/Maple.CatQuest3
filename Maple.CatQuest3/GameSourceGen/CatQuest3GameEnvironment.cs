using Maple.CatQuest3.GameModel.Data;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using System.Reflection.Emit;

namespace Maple.CatQuest3.GameSourceGen
{
    internal class CatQuest3GameEnvironment
    {
        public CatQuest3GameEnvironment(CatQuest3GameContext @this)
        {
            this.CatQuest3GameContext = @this;
            var contexts = @this.Contexts.SHARED_INSTANCE;
            if (contexts)
            {
                this.Ptr_GameContext = contexts.GAME;
                this.Ptr_GameStateContext = contexts.GAME_STATE;
                this.Ptr_Contexts = contexts;
            }
            this.Ptr_EquipmentDatabase = @this.EquipmentDatabase._INSTANCE;
            this.Ptr_ShipBlueprintDatabase = @this.ShipBlueprintDatabase._INSTANCE;
            this.Ptr_SpellConfigDatabase = @this.SpellConfigDatabase._INSTANCE;
        }
        public CatQuest3GameContext CatQuest3GameContext { get; }
        public Contexts.Ptr_Contexts Ptr_Contexts { get; }
        public GameContext.Ptr_GameContext Ptr_GameContext { get; }
        public GameStateContext.Ptr_GameStateContext Ptr_GameStateContext { get; }


        public EquipmentDatabase.Ptr_EquipmentDatabase Ptr_EquipmentDatabase { get; }
        public UnlockedEquipmentListComponent.Ptr_UnlockedEquipmentListComponent Ptr_UnlockedEquipmentListComponent => Ptr_GameContext.GET_UNLOCKED_EQUIPMENT_LIST();


        public ShipBlueprintDatabase.Ptr_ShipBlueprintDatabase Ptr_ShipBlueprintDatabase { get; }
        public UnlockedShipBlueprintsComponent.Ptr_UnlockedShipBlueprintsComponent Ptr_UnlockedShipBlueprintsComponent => Ptr_GameContext.GET_UNLOCKED_SHIP_BLUEPRINTS();
        public SpellConfigDatabase.Ptr_SpellConfigDatabase Ptr_SpellConfigDatabase { get; }
        public UnlockedSpellTableComponent.Ptr_UnlockedSpellTableComponent Ptr_UnlockedSpellTableComponent => Ptr_GameContext.GET_UNLOCKED_SPELL_TABLE();
        public UnlockedShipSpellTableComponent.Ptr_UnlockedShipSpellTableComponent Ptr_UnlockedShipSpellTableComponent => Ptr_GameContext.GET_UNLOCKED_SHIP_SPELL_TABLE();
        public bool IsLoaded()
        {
            return this.Ptr_GameContext && false == this.Ptr_GameContext.GET_IS_REMOVE_PLAYER_EVENT();
        }
        public bool ThrowIfNotLoaded()
        {
            if (IsLoaded())
            {
                return true;
            }
            return GameException.ThrowIfNotLoaded<bool>();

        }


        public nint CreateAddEquipmentCommand(nint data, System.Int32 level, out System.Int32 prevLevel, out System.Int32 newLevel)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_EQUIPMENT_COMMAND(this.Ptr_GameContext, data, level, out prevLevel, out newLevel);
        }
        public nint CreateAddNewShipSpellCommand(nint data, out nint newSpellConfig, out System.Int32 prevLevel, out System.Int32 newLevel, out System.Boolean success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_NEW_SHIP_SPELL_COMMAND(this.Ptr_GameContext, data, out newSpellConfig, out prevLevel, out newLevel, out success);
        }
        public nint CreateAddNewSpellCommand(nint data, out nint newSpellConfig, out System.Boolean success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_NEW_SPELL_COMMAND(this.Ptr_GameContext, data, out newSpellConfig, out success);
        }
        public nint CreateAddShipBlueprintCommand(nint data, out System.Boolean success)
        {
            return GameContextExtensions.Ptr_GameContextExtensions.CREATE_ADD_SHIP_BLUEPRINT_COMMAND(this.Ptr_GameContext, data, out success);
        }

    }
}
