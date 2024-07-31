using Maple.CatQuest3.GameModel.Data;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;

namespace Maple.CatQuest3.GameSourceGen
{
    internal class CatQuest3GameEnvironment
    {
        public CatQuest3GameEnvironment(CatQuest3GameContext @this)
        {
            var contexts = @this.Contexts.SHARED_INSTANCE;
            if (contexts)
            {
                this.Ptr_GameContext = contexts.GAME;
                this.Ptr_GameStateContext = contexts.GAME_STATE;
                this.Ptr_Contexts = contexts;
            }
            this.Ptr_EquipmentDatabase = @this.EquipmentDatabase._INSTANCE;
            this.Ptr_ShipBlueprintDatabase = @this.ShipBlueprintDatabase._INSTANCE;
        }

        public Contexts.Ptr_Contexts Ptr_Contexts { get; }
        public GameContext.Ptr_GameContext Ptr_GameContext { get; }
        public GameStateContext.Ptr_GameStateContext Ptr_GameStateContext { get; }


        public EquipmentDatabase.Ptr_EquipmentDatabase Ptr_EquipmentDatabase { get; }
        public UnlockedEquipmentListComponent.Ptr_UnlockedEquipmentListComponent Ptr_UnlockedEquipmentListComponent => Ptr_GameContext.GET_UNLOCKED_EQUIPMENT_LIST();


        public ShipBlueprintDatabase.Ptr_ShipBlueprintDatabase Ptr_ShipBlueprintDatabase { get; }
        public UnlockedShipBlueprintsComponent.Ptr_UnlockedShipBlueprintsComponent Ptr_UnlockedShipBlueprintsComponent=> Ptr_GameContext.GET_UNLOCKED_SHIP_BLUEPRINTS();

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


    }
}
