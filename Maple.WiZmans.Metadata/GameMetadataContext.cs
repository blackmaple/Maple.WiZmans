using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.WiZmans.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]


    [ContextMemberMetadata<RES_CTRL_DATA>]
    [ContextMemberMetadata<ResLoad>]
    [ContextMemberMetadata<TBB_OBJECT>]
    public partial class GameMetadataContext
    {

    }
}
