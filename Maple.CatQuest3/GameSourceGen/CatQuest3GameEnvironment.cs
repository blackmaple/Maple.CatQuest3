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
        }

        public Contexts.Ptr_Contexts Ptr_Contexts { get; }
        public GameContext.Ptr_GameContext Ptr_GameContext { get; }
        public GameStateContext.Ptr_GameStateContext Ptr_GameStateContext { get; }





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
