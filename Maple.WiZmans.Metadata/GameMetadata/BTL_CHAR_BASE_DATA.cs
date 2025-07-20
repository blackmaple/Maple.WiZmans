namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."BTL_CHAR_BASE_DATA"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BTL_CHAR_BASE_DATA>, Ptr_BTL_CHAR_BASE_DATA>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "BTL_CHAR_BASE_DATA", "BTL_CHAR_BASE_DATA")]
    public partial class BTL_CHAR_BASE_DATA
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BTL_CHAR_BASE_DATA(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BTL_CHAR_BASE_DATA(System.IntPtr ptr) => new Ptr_BTL_CHAR_BASE_DATA(ptr);
            public static implicit operator System.IntPtr(Ptr_BTL_CHAR_BASE_DATA ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BTL_CHAR_BASE_DATA ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BTL_CHAR_BASE_DATA"]
        /// </summary>
        partial struct Ptr_BTL_CHAR_BASE_DATA
        {
            /// <summary>
            /// 0x10 System.Int32 Size
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Size", "System.Int32")]
            public partial System.Int32 SIZE { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 ResNo
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ResNo", "System.Int32")]
            public partial System.Int32 RES_NO { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 LV
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LV", "System.Int32")]
            public partial System.Int32 LV { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 Element
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Element", "System.Int32")]
            public partial System.Int32 ELEMENT { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 MaxHp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxHp", "System.Int32")]
            public partial System.Int32 MAX_HP { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 MaxSp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxSp", "System.Int32")]
            public partial System.Int32 MAX_SP { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int16 Atk
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Atk", "System.Int16")]
            public partial System.Int16 ATK { get; set; } 
*/

            /// <summary>
            /// 0x2A System.Int16 Def
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Def", "System.Int16")]
            public partial System.Int16 DEF { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int16 MagicAtk
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MagicAtk", "System.Int16")]
            public partial System.Int16 MAGIC_ATK { get; set; } 
*/

            /// <summary>
            /// 0x2E System.Int16 MagicDef
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MagicDef", "System.Int16")]
            public partial System.Int16 MAGIC_DEF { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int16 Tec
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Tec", "System.Int16")]
            public partial System.Int16 TEC { get; set; } 
*/

            /// <summary>
            /// 0x32 System.Int16 Agi
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Agi", "System.Int16")]
            public partial System.Int16 AGI { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] Resist
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Resist", "System.Int32[]")]
            public partial nint RESIST { get; set; } 
*/

            /// <summary>
            /// 0x40 E_BTL_SKILL_DATA[] SkillData
            /// class ["Assembly-CSharp.dll".""."E_BTL_SKILL_DATA[]"]
            /// </summary>
            /// <returns>class E_BTL_SKILL_DATA[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillData", "E_BTL_SKILL_DATA[]")]
            public partial nint SKILL_DATA { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 AINo
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AINo", "System.Int32")]
            public partial System.Int32 AI_NO { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 Gold
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Gold", "System.Int32")]
            public partial System.Int32 GOLD { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 Exp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Exp", "System.Int32")]
            public partial System.Int32 EXP { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 AnimaDropVal
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AnimaDropVal", "System.Int32")]
            public partial System.Int32 ANIMA_DROP_VAL { get; set; } 
*/

            /// <summary>
            /// 0x58 E_BTL_DROP_DATA[] DropData
            /// class ["Assembly-CSharp.dll".""."E_BTL_DROP_DATA[]"]
            /// </summary>
            /// <returns>class E_BTL_DROP_DATA[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropData", "E_BTL_DROP_DATA[]")]
            public partial nint DROP_DATA { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 Houkai
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Houkai", "System.Int32")]
            public partial System.Int32 HOUKAI { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 ZukanId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ZukanId", "System.Int32")]
            public partial System.Int32 ZUKAN_ID { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 OfsPosX
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OfsPosX", "System.Int32")]
            public partial System.Int32 OFS_POS_X { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Int32 OfsPosY
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OfsPosY", "System.Int32")]
            public partial System.Int32 OFS_POS_Y { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int16 CursorOfsPosX
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CursorOfsPosX", "System.Int16")]
            public partial System.Int16 CURSOR_OFS_POS_X { get; set; } 
*/

            /// <summary>
            /// 0x72 System.Int16 CursorOfsPosY
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CursorOfsPosY", "System.Int16")]
            public partial System.Int16 CURSOR_OFS_POS_Y { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int16 BossDeadFg
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BossDeadFg", "System.Int16")]
            public partial System.Int16 BOSS_DEAD_FG { get; set; } 
*/

            /// <summary>
            /// 0x76 System.Int16 Dummy
            /// struct ["mscorlib.dll"."System"."Int16"]
            /// </summary>
            /// <returns>struct System.Int16</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Dummy", "System.Int16")]
            public partial System.Int16 DUMMY { get; set; } 
*/

            /// <summary>
            /// 0x78 E_BTL_ANIM_SE_DATA[] AnimSeData
            /// class ["Assembly-CSharp.dll".""."E_BTL_ANIM_SE_DATA[]"]
            /// </summary>
            /// <returns>class E_BTL_ANIM_SE_DATA[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AnimSeData", "E_BTL_ANIM_SE_DATA[]")]
            public partial nint ANIM_SE_DATA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BTL_CHAR_BASE_DATA"]
        /// </summary>
        partial struct Ptr_BTL_CHAR_BASE_DATA
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR(); 
*/
        }
    }
}