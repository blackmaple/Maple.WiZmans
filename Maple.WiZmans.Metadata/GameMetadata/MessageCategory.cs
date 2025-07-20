namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// ["Assembly-CSharp.dll".""."MessageCategory"]
    /// </summary>
    public enum MessageCategory : System.Int32
    {
        _NPC = 0x00000000,
        /// <summary>
        /// 消耗道具
        /// </summary>
        _ShohiItemName = 0x00000001,
        /// <summary>
        /// 装备
        /// </summary>
        _SoubiItemName = 0x00000002,
        /// <summary>
        /// 材料
        /// </summary>
        _SozaiItemName = 0x00000003,
        /// <summary>
        /// 灵魂
        /// </summary>
        _animaItemName = 0x00000004,
        /// <summary>
        /// 贵重
        /// </summary>
        _KichohinItemName = 0x00000005,
        /// <summary>
        /// 消耗道具描述
        /// </summary>
        _ShohiItemSetsuMei = 0x00000006,
        /// <summary>
        /// 装备描述
        /// </summary>
        _SoubiItemSetsuMei = 0x00000007,
        /// <summary>
        /// 材料描述
        /// </summary>
        _SozaiItemSetsuMei = 0x00000008,
        /// <summary>
        /// 灵魂描述
        /// </summary>
        _animaItemSetsuMei = 0x00000009,
        /// <summary>
        /// 贵重描述
        /// </summary>
        _KichohinItemSetsuMei = 0x0000000A,

        /// <summary>
        /// 消耗道具描述???
        /// </summary>
        _ShohiItemSetsuMeiCut = 0x0000000B,

        /// <summary>
        /// 炼金术合成生命
        /// </summary>
        _HomunclsName = 0x0000000C,
        /// <summary>
        /// 炼金术合成生命描述
        /// </summary>
        _HomunclsSetsumei = 0x0000000D,
        /// <summary>
        /// 基础技能
        /// </summary>
        _BaseSkillName = 0x0000000E,
        /// <summary>
        /// 被动技能
        /// </summary>
        _PassiveSkillName = 0x0000000F,
        /// <summary>
        /// 主动技能
        /// </summary>
        _ActiveSkillName = 0x00000010,
        /// <summary>
        /// 基础技能描述
        /// </summary>
        _SkillDescription = 0x00000011,
        /// <summary>
        /// 被动技能描述
        /// </summary>
        _PassiveSkillDescription = 0x00000012,
        /// <summary>
        /// 主动技能描述
        /// </summary>
        _ActiveSkillDescription = 0x00000013,
        /// <summary>
        /// 主动技能描述???
        /// </summary>
        _ActiveSkillDescriptionCut = 0x00000014,
        /// <summary>
        /// 独特攻击信息
        /// </summary>
        _UniqueAttackMes = 0x00000015,
        /// <summary>
        /// 魔法
        /// </summary>
        _MagicName = 0x00000016,
        /// <summary>
        /// 魔法描述
        /// </summary>
        _MagicDscription = 0x00000017,
        /// <summary>
        /// 魔法描述???
        /// </summary>
        _MagicDscriptionCut = 0x00000018,
        /// <summary>
        /// 敌人
        /// </summary>
        _EnemyName = 0x00000019,
        /// <summary>
        /// 敌人描述
        /// </summary>
        _EnemyDescription = 0x0000001A,
        /// <summary>
        /// DLC敌人
        /// </summary>
        _DLCEnemyName = 0x0000001B,
        /// <summary>
        /// DLC敌人描述
        /// </summary>
        _DLCEnemyDescription = 0x0000001C,

        _MainStorytName = 0x0000001D,
        _MainStoryDescription = 0x0000001E,
        _SubQuestName = 0x0000001F,
        _SubQuestDescription = 0x00000020,
        _BaseName = 0x00000021,
        _MapName = 0x00000022,
        _MapDescription = 0x00000023,
        _BtlSelMsg = 0x00000024,
        _YesNoWindow = 0x00000025,
        _AlertMessageWindow = 0x00000026,
        _SimpleWindow = 0x00000027,
        _CaseSelectWindow = 0x00000028,
        _CommonSelectWindow = 0x00000029,
        _KeyboardDefName = 0x0000002A,
        _Event_SystemMes = 0x0000002B,
        _Camp = 0x0000002C,
        _Desk = 0x0000002D,
        _SaveLoad = 0x0000002E,
        _ShopMsg = 0x0000002F,
        _ShopSystem = 0x00000030,

        /// <summary>
        /// 融合
        /// </summary>
        _Fusion = 0x00000031,

        _BgmName = 0x00000032,
        _KihonTutorial = 0x00000033,
        _SkillTutorial = 0x00000034,
        _ItemTutorial1 = 0x00000035,
        _ItemTutorial2 = 0x00000036,
        _MenuMes = 0x00000037,
        _Prologue = 0x00000038,
        _Debug = 0x00000039,
        _MAX = 0x0000003A
    }
}