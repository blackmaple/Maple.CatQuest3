using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollector;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Microsoft.Extensions.Logging;

namespace Maple.CatQuest3.GameSourceGen
{

    [MonoCollectorOptions(
typeof(MonoCollectorContext),
typeof(MonoCollectorMember),
typeof(MonoRuntimeContext),
typeof(MonoCollectorClassInfo)
)]
    internal partial class CatQuest3GameContext
    {
        public CatQuest3GameContext(MonoRuntimeContext monoRuntimeContext, ILogger logger) : base(monoRuntimeContext, EnumMonoCollectorTypeVersion.APP, logger, "20")
        {
        }
    }

}
