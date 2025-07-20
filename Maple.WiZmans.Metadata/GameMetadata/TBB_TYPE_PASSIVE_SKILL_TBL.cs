namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_PASSIVE_SKILL_TBL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_PASSIVE_SKILL_TBL>, Ptr_TBB_TYPE_PASSIVE_SKILL_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_PASSIVE_SKILL_TBL", "TBB_TYPE_PASSIVE_SKILL_TBL")]
    public partial class TBB_TYPE_PASSIVE_SKILL_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_PASSIVE_SKILL_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_PASSIVE_SKILL_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_PASSIVE_SKILL_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_PASSIVE_SKILL_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_PASSIVE_SKILL_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_PASSIVE_SKILL_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_PASSIVE_SKILL_TBL
        {
            /// <summary>
            /// 0x10 E_SKILL_ADD_KIND eAddKind
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_ADD_KIND"]
            /// </summary>
            /// <returns>enum E_SKILL_ADD_KIND</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("eAddKind", "E_SKILL_ADD_KIND")]
            public partial E_SKILL_ADD_KIND E_ADD_KIND { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 hp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Int32")]
            public partial System.Int32 HP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 sp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sp", "System.Int32")]
            public partial System.Int32 SP { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 phyAtk
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyAtk", "System.Int32")]
            public partial System.Int32 PHY_ATK { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 phyDef
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyDef", "System.Int32")]
            public partial System.Int32 PHY_DEF { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 magAtk
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magAtk", "System.Int32")]
            public partial System.Int32 MAG_ATK { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 magDef
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magDef", "System.Int32")]
            public partial System.Int32 MAG_DEF { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 tec
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tec", "System.Int32")]
            public partial System.Int32 TEC { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 agi
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("agi", "System.Int32")]
            public partial System.Int32 AGI { get; set; } 
*/

            /// <summary>
            /// 0x34 ELEMENT_VALUE elment_resist
            /// struct ["Assembly-CSharp.dll".""."ELEMENT_VALUE"]
            /// </summary>
            /// <returns>struct ELEMENT_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elment_resist", "ELEMENT_VALUE")]
            public partial ELEMENT_VALUE ELMENT_RESIST { get; set; } 
*/

            /// <summary>
            /// 0x48 ELEMENT_VALUE elment_atkRevise
            /// struct ["Assembly-CSharp.dll".""."ELEMENT_VALUE"]
            /// </summary>
            /// <returns>struct ELEMENT_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elment_atkRevise", "ELEMENT_VALUE")]
            public partial ELEMENT_VALUE ELMENT_ATK_REVISE { get; set; } 
*/

            /// <summary>
            /// 0x5C SKILL_VALUE skill_resist
            /// struct ["Assembly-CSharp.dll".""."SKILL_VALUE"]
            /// </summary>
            /// <returns>struct SKILL_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skill_resist", "SKILL_VALUE")]
            public partial SKILL_VALUE SKILL_RESIST { get; set; } 
*/

            /// <summary>
            /// 0x68 SKILL_VALUE skill_atkRevise
            /// struct ["Assembly-CSharp.dll".""."SKILL_VALUE"]
            /// </summary>
            /// <returns>struct SKILL_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skill_atkRevise", "SKILL_VALUE")]
            public partial SKILL_VALUE SKILL_ATK_REVISE { get; set; } 
*/

            /// <summary>
            /// 0x74 BAD_STATUS_VALUE badStatus_resist
            /// struct ["Assembly-CSharp.dll".""."BAD_STATUS_VALUE"]
            /// </summary>
            /// <returns>struct BAD_STATUS_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("badStatus_resist", "BAD_STATUS_VALUE")]
            public partial BAD_STATUS_VALUE BAD_STATUS_RESIST { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 avoid_percent
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("avoid_percent", "System.Int32")]
            public partial System.Int32 AVOID_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 hit_percent
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hit_percent", "System.Int32")]
            public partial System.Int32 HIT_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 critical_percent
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("critical_percent", "System.Int32")]
            public partial System.Int32 CRITICAL_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Int32 attack_type
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attack_type", "System.Int32")]
            public partial System.Int32 ATTACK_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 attack_element
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attack_element", "System.Int32")]
            public partial System.Int32 ATTACK_ELEMENT { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 specialEffect
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("specialEffect", "System.Int32")]
            public partial System.Int32 SPECIAL_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 specialCompare
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("specialCompare", "System.Int32")]
            public partial System.Int32 SPECIAL_COMPARE { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Int32[] badStatusAdd
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("badStatusAdd", "System.Int32[]")]
            public partial nint BAD_STATUS_ADD { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_PASSIVE_SKILL_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_PASSIVE_SKILL_TBL
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}