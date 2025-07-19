using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;
using Microsoft.Extensions.Logging;

namespace Maple.WiZmans.Metadata
{
    public partial class GameResourceCache(GameMetadataContext context)
    {
        public GameMetadataContext Context { get; } = context;
        public ILogger Logger => Context.Logger;


        public static GameResourceCache CreateCache(GameMetadataContext context)
        {
            SpinWait.SpinUntil(() => ResLoad.Ptr_ResLoad.S_RES_CTRL_DATA.Valid());
            foreach (var data in ResLoad.Ptr_ResLoad.S_RES_CTRL_DATA)
            {
                var buffer = data.P_BUFFER;
                if (buffer.IsNull())
                {
                    continue;
                }
                PMonoClass monoClass = context.RuntimeContext.RuntiemProvider.GetMonoClass(buffer.Ptr);
                var info = context.RuntimeContext.GetMonoClassInfoDTO(monoClass);
                context.Logger.LogInformation("class name:{name}", info.FullName);

            }


            return new GameResourceCache(context);
        }

    }
}
