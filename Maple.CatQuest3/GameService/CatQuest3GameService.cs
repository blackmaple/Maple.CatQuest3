﻿using Maple.CatQuest3.Metadata.GameSourceGen;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.UnityCore;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.CatQuest3.GameService
{


    internal sealed partial class CatQuest3GameService(ILogger<CatQuest3GameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
    : GameContextService<CatQuest3GameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)


    {
        protected override CatQuest3GameContext LoadGameContext()
            => CatQuest3GameContext.LoadGameContext(this.RuntimeContext, MonoGameAssistant.MonoCollectorDataV2.EnumMonoCollectorTypeVersion.APP, Logger);
        protected override UnityEngineContext? LoadUnityEngineContext()
            => UnityEngineContext_CatQuest3.Create(this.RuntimeContext, this.Logger);




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
        private ValueTask<CatQuest3GameEnvironment> GetGameEnvironmentAsync()
        {
            return this.UITaskAsync(p => p.GetGameEnvironment());
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
        public sealed override async ValueTask<GameSessionInfoDTO> LoadResourceAsync()
        {
            if (this.UnityEngineContext is null)
            {
                return GameException.Throw<GameSessionInfoDTO>($"{nameof(UnityEngineContext)} Is Null");
            }
            var datas = await this.MonoTaskAsync(p => p.LoadGameImageData().ToArray()).ConfigureAwait(false);
            var imageDatas = await this.UITaskAsync((p, args) => p.GetListUnitySpriteImageData(args.UnityEngineContext, args.datas).ToArray(), (UnityEngineContext, datas)).ConfigureAwait(false);
            foreach (var image in imageDatas)
            {
                this.GameSettings.WriteImageFile(image.ImageData.AsReadOnlySpan(), image.Category, $"{image.Name}.png");
            }

            return await this.GetSessionInfoAsync().ConfigureAwait(false);
        }

        //private async Task<IEnumerable<object>> UnityTaskAsync(Func<object, object, UnitySpriteImageData[]> value1, (UnityEngineContext UnityEngineContext, GameImageData[] datas) value2)
        //{
        //    throw new NotImplementedException();
        //}

        public sealed override ValueTask<GameCurrencyDisplayDTO[]> GetListCurrencyDisplayAsync()
        {
            var datas = this.Context.GetListGameCurrencyDisplay();
            this.UpdateListGameImage(datas);
            return ValueTask.FromResult(datas);
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
            var datas = await this.MonoTaskAsync((p, args) => p.GetListGameInventoryDisplay(args).ToArray(), gameEnvironment).ConfigureAwait(false);
            this.UpdateListGameImage(datas);
            return datas;
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
            return ValueTask.FromResult(this.Context.GetListGameSwitchDisplay());
        }
        public sealed override async ValueTask<GameSwitchDisplayDTO> UpdateSwitchDisplayAsync(GameSwitchModifyDTO switchModifyDTO)
        {
            var gameEnvironment = await this.GetGameEnvironmentThrowIfErrorAsync().ConfigureAwait(false);
            return await this.MonoTaskAsync((p, args) => p.UpdateGameSwitchDisplay(gameEnvironment, args), switchModifyDTO).ConfigureAwait(false);

        }
        #endregion
    }
}
