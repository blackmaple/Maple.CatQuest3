using Maple.CatQuest3.GameSourceGen;
using Maple.GameContext;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
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
        => new(this.RuntimeContext,  Logger);
    }
}
