using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3.GameSourceGen
{
    internal class UnityEngineContext_CatQuest3 : UnityEngineContext_MONO
    {
        public UnityEngineContext_CatQuest3(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, logger)
        {
            this.Func_BLIT2 = 0x71120;
            this.Func_ENCODE_TO_PNG = 0x1995E0;
            this.Func_GET_TEXTURE_RECT_INJECTED = 0xE0570;
        }
    }
}
