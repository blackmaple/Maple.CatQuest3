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

namespace Maple.CatQuest3.Metadata.GameSourceGen
{
    public static class UnityEngineContext_CatQuest3
    {



        public static UnityEngineContext Create(this MonoRuntimeContext context, ILogger logger)
        {
            UnityEngineContext_MONO.Func_ENCODE_TO_PNG = 0x1995E0;
            UnityEngineContext_MONO.Func_BLIT2 = 0x71120;
            UnityEngineContext_MONO.Func_READ_PIXELS_IMPL_INJECTED = 0xE1570;
            UnityEngineContext_MONO.Func_GET_TEXTURE_RECT_INJECTED = 0xE0570;

            return new UnityEngineContext_MONO(context, logger);
        }

    }
}
