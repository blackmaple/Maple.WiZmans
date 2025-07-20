using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.WiZmans.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]

    [ContextMemberMetadata<MessageManager>]
    [ContextMemberMetadata<TextData>]

    [ContextMemberMetadata<RES_CTRL_DATA>]
    [ContextMemberMetadata<ResLoad>]
    [ContextMemberMetadata<TBB_OBJECT>]

    [ContextMemberMetadata<SKILL_TBB>]
    [ContextMemberMetadata<TBB_TYPE_BASE_SKILL>]
    [ContextMemberMetadata<TBB_TYPE_ACTIVE_SKILL_TBL>]
    [ContextMemberMetadata<TBB_TYPE_BASE_SKILL_SHUTOKU_TBL>]
    [ContextMemberMetadata<TBB_TYPE_PASSIVE_SKILL_TBL>]
    [ContextMemberMetadata<TBB_TYPE_SKILL_EFFECT_TBL>]

    [ContextMemberMetadata<TBB_TYPE_ITEM_TBL>]
    [ContextMemberMetadata<TBB_TYPE_KICHOHIN_ITEM_TBL>]
    [ContextMemberMetadata<TBB_TYPE_SHOHI_ITEM_TBL>]
    [ContextMemberMetadata<TBB_TYPE_SOUBI_ITEM_TBL>]
    [ContextMemberMetadata<TBB_TYPE_SPIRIT_ITEM_TBL>]
    [ContextMemberMetadata<TBB_TYPE_APL_SOZAI_ITEM_TBL>]



    [ContextMemberMetadata<MAGIC_LV_TBB>]
    [ContextMemberMetadata<TBB_TYPE_MAGIC_LV_TBL>]

    [ContextMemberMetadata<BTL_MAGIC_DATA_TBB>]
    [ContextMemberMetadata<BTL_MAGIC_DATA>]
    [ContextMemberMetadata<TBB_TYPE_UNIQUE_ATTACK_TBL>]

    public partial class GameMetadataContext
    {

    }
}
