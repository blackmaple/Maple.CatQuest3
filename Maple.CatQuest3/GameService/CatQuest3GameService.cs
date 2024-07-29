using Maple.CatQuest3.GameSourceGen;
using Maple.GameContext;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UnityCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3.GameService
{
    internal class CatQuest3GameService(
        ILogger<CatQuest3GameService> logger,
        MonoRuntimeContext runtimeContext,
        MonoGameSettings gameSettings)
        : GameService<CatQuest3GameContext>(logger, runtimeContext, gameSettings)
    {
        protected override CatQuest3GameContext LoadGameContext()
        => CatQuest3GameContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);



        #region GameEnvironment
        private Task<CatQuest3GameEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(p => p.GetGameEnvironment());
        }
        private async ValueTask<CatQuest3GameEnvironment> GetGameEnvironmentThrowIfErrorAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            if (await this.UnityTaskAsync((p, args) => args.IsLoaded(), (gameEnvironment)).ConfigureAwait(false))
            {
                return GameException.Throw<CatQuest3GameEnvironment>("game is not loaded");
            }
            return GameException.Throw<CatQuest3GameEnvironment>("game is not loaded");
        }
        #endregion

        #region WebApi
        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return ValueTask.FromResult(this.GameContext.GetListGameCurrencyDisplay());
        }

        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetGameCurrencyInfo(gameEnvironment, args), currencyObjectDTO).ConfigureAwait(false);
        }

        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateGameCurrencyInfo(gameEnvironment, args), currencyModifyDTO).ConfigureAwait(false);
        }
        #endregion
    }
}
