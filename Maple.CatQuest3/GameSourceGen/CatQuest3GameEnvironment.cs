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


        public bool InGame()
        {
            return this.Ptr_Contexts;
        }
        public void ThrowIfNotInGame()
        {
            if (!this.InGame())
            {
                GameException.Throw("game is error");
            }
            
        }

        public bool IsLoaded()
        {
            var gameStateContext = this.Ptr_GameStateContext;
            if (gameStateContext)
            {
                return gameStateContext.GET_IS_IN_GAME();
            }
            return default;
        }
        public void ThrowIfNotLoaded()
        {
            if (IsLoaded() == false)
            {
                GameException.Throw("game is not loaded");
            }
        }
    }
}
