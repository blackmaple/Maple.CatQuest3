using Maple.CatQuest3.GameSourceGen;
using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.CatQuest3.GameService
{
    internal class CatQuest3GameWebApi() : GameWebApi<CatQuest3GameWebApi, CatQuest3GameService, CatQuest3GameContext>("Cat Quest 3//QQ Group:41426227", "https://qm.qq.com/q/oamayysmNa")
    {

        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            Maple.MonoGameAssistant.DllExportTmp.DllExport.LoadApis();
            Initializer(12000);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, [MarshalAs(UnmanagedType.U4)] EnumReasonForCall ul_reason_for_call, nint lpReserved)
        {
            switch (ul_reason_for_call)
            {
                case EnumReasonForCall.DLL_PROCESS_ATTACH:
                    {
                        break;
                    }
                case EnumReasonForCall.DLL_THREAD_ATTACH:
                case EnumReasonForCall.DLL_THREAD_DETACH:
                case EnumReasonForCall.DLL_PROCESS_DETACH:
                    {
                        break;
                    }

            }
            return true;
        }


    }
}
