using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;
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

                if (info.FullName == nameof(TBB_TYPE_ITEM_TBL))
                {
                    foreach (var item in EnumItems(buffer.Ptr))
                    {
                        context.Logger.LogInformation("{cate}:name:{name}/desc:{desc}/index:{index}", item.DisplayCategory, item.DisplayName, item.DisplayDesc, item.Index);
                    }
                }

                if (info.FullName == nameof(SKILL_TBB))
                {
                    foreach (var item in EnumSkills(buffer.Ptr))
                    {
                        context.Logger.LogInformation("{cate}:name:{name}/desc:{desc}/index:{index}", item.DisplayCategory, item.DisplayName, item.DisplayDesc, item.Index);
                    }
                }

                if (info.FullName == nameof(BTL_MAGIC_DATA_TBB))
                {
                    foreach (var item in EnumMagics(buffer.Ptr))
                    {
                        context.Logger.LogInformation("{cate}:name:{name}/desc:{desc}/index:{index}", item.DisplayCategory, item.DisplayName, item.DisplayDesc, item.Index);
                    }
                }
            }
            return new GameResourceCache(context);
        }

        static IEnumerable<GameInventoryDisplayDTOEX> EnumItems(TBB_TYPE_ITEM_TBL.Ptr_TBB_TYPE_ITEM_TBL itemTbl)
        {

            foreach (var item in EnumItemsImp(itemTbl.SHOHI, MessageCategory._ShohiItemName, MessageCategory._ShohiItemSetsuMei))
            {
                yield return item;
            }
            foreach (var item in EnumItemsImp(itemTbl.SOUBI, MessageCategory._SoubiItemName, MessageCategory._SoubiItemSetsuMei))
            {
                yield return item;
            }
            foreach (var item in EnumItemsImp(itemTbl.SOZAI, MessageCategory._SozaiItemName, MessageCategory._SozaiItemSetsuMei))
            {
                yield return item;
            }
            foreach (var item in EnumItemsImp(itemTbl.SPIRIT, MessageCategory._animaItemName, MessageCategory._animaItemSetsuMei))
            {
                yield return item;
            }
            foreach (var item in EnumItemsImp(itemTbl.KITYOHIN, MessageCategory._KichohinItemName, MessageCategory._KichohinItemSetsuMei))
            {
                yield return item;
            }




        }
        static IEnumerable<GameInventoryDisplayDTOEX> EnumItemsImp<T>(PMonoArray<T> values, MessageCategory name, MessageCategory desc)
          where T : unmanaged, IPtrMetadata
        {
            if (values.Valid())
            {
                int index = 0;
                foreach (var item in values)
                {
                    yield return new GameInventoryDisplayDTOEX()
                    {
                        ObjectId = item.Ptr.ToString(),

                        ObjectPointer = item.Ptr,
                        DisplayCategory = name.ToString(),
                        DisplayName = name.T(index),
                        DisplayDesc = desc.T(index),
                        Index = index
                    };
                    ++index;
                }
            }
        }

        static IEnumerable<GameSkillDisplayDTOEX> EnumSkills(SKILL_TBB.Ptr_SKILL_TBB skillTbb)
        {

            foreach (var item in EnumSkillsImp(skillTbb.BASE_SKILL, MessageCategory._BaseSkillName, MessageCategory._SkillDescription))
            {
                yield return item;
            }
            foreach (var item in EnumSkillsImp(skillTbb.ACTIVE_SKILL, MessageCategory._ActiveSkillName, MessageCategory._ActiveSkillDescription))
            {
                yield return item;
            }
            foreach (var item in EnumSkillsImp(skillTbb.PASSIVE_SKILL, MessageCategory._PassiveSkillName, MessageCategory._PassiveSkillDescription))
            {
                yield return item;
            }
            //foreach (var item in EnumSkillsImp(skillTbb.EFFECT_SKILL, MessageCategory._PassiveSkillName, MessageCategory._PassiveSkillDescription))
            //{
            //    yield return item;
            //}
            //foreach (var item in EnumSkillsImp(skillTbb.SHUTOKU_SKILL, MessageCategory._MagicName, MessageCategory._MagicDscription))
            //{
            //    yield return item;
            //}
        }
        static IEnumerable<GameSkillDisplayDTOEX> EnumSkillsImp<T>(PMonoArray<T> values, MessageCategory name, MessageCategory desc)
          where T : unmanaged, IPtrMetadata
        {
            if (values.Valid())
            {
                int index = 0;
                foreach (var item in values)
                {
                    yield return new GameSkillDisplayDTOEX()
                    {
                        ObjectId = item.Ptr.ToString(),

                        ObjectPointer = item.Ptr,
                        DisplayCategory = name.ToString(),
                        DisplayName = name.T(index),
                        DisplayDesc = desc.T(index),
                        Index = index
                    };
                    ++index;
                }
            }
        }


        static IEnumerable<GameSkillDisplayDTOEX> EnumMagics(BTL_MAGIC_DATA_TBB.Ptr_BTL_MAGIC_DATA_TBB magicTbb)
        {
            foreach (var item in EnumSkillsImp(magicTbb.SKILL, MessageCategory._MagicName, MessageCategory._MagicDscription))
            {
                yield return item;
            }
            foreach (var item in EnumSkillsImp(magicTbb.MAGIC, MessageCategory._MagicName, MessageCategory._MagicDscription))
            {
                yield return item;
            }

            foreach (var item in EnumSkillsImp(magicTbb.UNIQUE_ATTACK_PARTY, MessageCategory._UniqueAttackMes, MessageCategory._UniqueAttackMes))
            {
                yield return item;
            }
            foreach (var item in EnumSkillsImp(magicTbb.UNIQUE_ATTACK_ENEMY, MessageCategory._UniqueAttackMes, MessageCategory._UniqueAttackMes))
            {
                yield return item;
            }
            foreach (var item in EnumSkillsImp(magicTbb.UNIQUE_ATTACK_DLC_ENEMY, MessageCategory._UniqueAttackMes, MessageCategory._UniqueAttackMes))
            {
                yield return item;
            }
        }

    }


    public class GameInventoryDisplayDTOEX : GameInventoryDisplayDTO
    {
        public nint ObjectPointer { set; get; }
        public int Index { set; get; }
    }

    public class GameSkillDisplayDTOEX : GameSkillDisplayDTO
    {
        public nint ObjectPointer { set; get; }
        public int Index { set; get; }

    }

    static class MessageManagerExtensions
    {
        public static string? T(this MessageCategory category, int index)
        {
            var ptr_data = MessageManager.Ptr_MessageManager.GET_STRING_DATA(category, index);
            if (ptr_data.IsNotNull())
            {
                return ptr_data.TEXT.ToString();
            }
            return default;
        }
    }
}
