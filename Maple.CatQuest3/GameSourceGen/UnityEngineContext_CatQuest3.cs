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
    internal class UnityEngineContext_CatQuest3: UnityEngineContext
    {
        public UnityEngineContext_CatQuest3(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.MONO, logger, "202407222110")
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            //UnityEngine.ImageConversion:EncodeToPNG+43 - E8 684E1278           - call UnityPlayer.dll+1995E0
            //UnityEngine.Graphics:Blit2+4b - E8 78BEFF77           - call UnityPlayer.dll+71120
            //UnityEngine.Sprite:get_rect_Injected+57 - E8 9CFDFE56           - call UnityPlayer.dll+E1570
            //UnityEngine.Sprite:GetTextureRect_Injected+57 - E8 14B10678           - call UnityPlayer.dll+E0570

            this.NativeMethodSetting.LoadNativeMethod_MONO(new UnityNativeMethodOffset() 
            { 
                Func_ENCODE_TO_PNG = 0x1995E0,
                Func_BLIT2 = 0x71120,
                Func_GET_RECT_INJECTED= 0xE1570,
                Func_GET_TEXTURE_RECT_INJECTED = 0xE0570,
            } );

        //    this.Logger.LogInformation("methd:{methd}", this.NativeMethodSetting.DebugOutput());
        }
    }
}
