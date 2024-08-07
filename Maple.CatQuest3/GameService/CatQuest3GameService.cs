using Maple.CatQuest3.GameSourceGen;
using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
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



        protected sealed override ValueTask F5_KeyDown()
        {
            return new(this.MonoTaskAsync(p => p.Output()));
        }

        protected sealed override async ValueTask F9_KeyDown()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);

            try
            {
                _ = gameEnvironment.ThrowIfNotLoaded();
                await this.MonoTaskAsync((p, args) => p.GameHealPlayer(args), (gameEnvironment)).ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.ShowMessageAsync(gameEnvironment, ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
        }
        protected sealed override async ValueTask F11_KeyDown()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);

            try
            {
                _ = gameEnvironment.ThrowIfNotLoaded();
                await this.MonoTaskAsync((p, args) => p.GameKillMonster(args, false), (gameEnvironment)).ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.ShowMessageAsync(gameEnvironment, ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
        }
        protected sealed override async ValueTask F12_KeyDown()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);

            try
            {
                _ = gameEnvironment.ThrowIfNotLoaded();
                await this.MonoTaskAsync((p, args) => p.GameKillMonster(args, true), (gameEnvironment)).ConfigureAwait(false);
            }
            catch (GameException ex)
            {
                await this.ShowMessageAsync(gameEnvironment, ex.Message).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                this.Logger.Error(ex);
            }
        }
        #region GameEnvironment
        private Task<CatQuest3GameEnvironment> GetGameEnvironmentAsync()
        {
            return this.MonoTaskAsync(p => p.GetGameEnvironment());
        }
        private async ValueTask<CatQuest3GameEnvironment> GetGameEnvironmentThrowIfErrorAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            if (await this.MonoTaskAsync((p, args) => args.IsLoaded(), (gameEnvironment)).ConfigureAwait(false))
            {
                return gameEnvironment;
            }
            return GameException.ThrowIfNotLoaded<CatQuest3GameEnvironment>();
        }
        private async ValueTask ShowMessageAsync(CatQuest3GameEnvironment gameEnvironment, string? msg)
        {
            await this.MonoTaskAsync((p, args) => args.gameEnvironment.TryShowMessage(args.msg), (gameEnvironment, msg)).ConfigureAwait(false);
        }
        #endregion

        #region WebApi
        public sealed override ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            return base.LoadResourceAsync();
        }

        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            return ValueTask.FromResult(this.GameContext.GetListGameCurrencyDisplay());
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> GetCurrencyInfoAsync(GameCurrencyObjectDTO currencyObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetGameCurrencyInfo(args.gameEnvironment, args.currencyObjectDTO), (gameEnvironment, currencyObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameCurrencyInfoDTO> UpdateCurrencyInfoAsync(GameCurrencyModifyDTO currencyModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateGameCurrencyInfo(args.gameEnvironment, args.currencyModifyDTO), (gameEnvironment, currencyModifyDTO)).ConfigureAwait(false);
        }


        public sealed override async ValueTask<GameInventoryDisplayDTO[]> GetListInventoryDisplayAsync()
        {
            var gameEnvironment = await this.GetGameEnvironmentAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetListGameInventoryDisplay(args).ToArray(), gameEnvironment).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> GetInventoryInfoAsync(GameInventoryObjectDTO inventoryObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.GetGameInventoryInfo(args.gameEnvironment, args.inventoryObjectDTO), (gameEnvironment, inventoryObjectDTO)).ConfigureAwait(false);
        }
        public sealed override async ValueTask<GameInventoryInfoDTO> UpdateInventoryInfoAsync(GameInventoryModifyDTO inventoryObjectDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateGameInventoryInfo(args.gameEnvironment, args.inventoryObjectDTO), (gameEnvironment, inventoryObjectDTO)).ConfigureAwait(false);

        }


        public sealed override ValueTask<GameSwitchDisplayDTO[]> GetListSwitchDisplayAsync()
        {
            return ValueTask.FromResult(this.GameContext.GetListGameSwitchDisplay());
        }
        public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO switchModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateGameSwitchDisplay(gameEnvironment, args), switchModifyDTO).ConfigureAwait(false);

        }
        #endregion
    }
}
