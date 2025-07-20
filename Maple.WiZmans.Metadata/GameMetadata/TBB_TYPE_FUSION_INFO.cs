namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_FUSION_INFO"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_FUSION_INFO>, Ptr_TBB_TYPE_FUSION_INFO>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_FUSION_INFO", "TBB_TYPE_FUSION_INFO")]
    public partial class TBB_TYPE_FUSION_INFO
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_FUSION_INFO(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_FUSION_INFO(System.IntPtr ptr) => new Ptr_TBB_TYPE_FUSION_INFO(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_FUSION_INFO ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_FUSION_INFO ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_FUSION_INFO"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_FUSION_INFO
        {
            /// <summary>
            /// 0x10 System.Int32 modelId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("modelId", "System.Int32")]
            public partial System.Int32 MODEL_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 fusionKekkaId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fusionKekkaId", "System.Int32")]
            public partial System.Int32 FUSION_KEKKA_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 elementId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementId", "System.Int32")]
            public partial System.Int32 ELEMENT_ID { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 hp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp", "System.Int32")]
            public partial System.Int32 HP { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 sp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sp", "System.Int32")]
            public partial System.Int32 SP { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 phyAtk
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyAtk", "System.Int32")]
            public partial System.Int32 PHY_ATK { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 phyDef
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyDef", "System.Int32")]
            public partial System.Int32 PHY_DEF { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 magAtk
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magAtk", "System.Int32")]
            public partial System.Int32 MAG_ATK { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 magDef
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magDef", "System.Int32")]
            public partial System.Int32 MAG_DEF { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 evd
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("evd", "System.Int32")]
            public partial System.Int32 EVD { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 agi
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("agi", "System.Int32")]
            public partial System.Int32 AGI { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32[] elementResist
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementResist", "System.Int32[]")]
            public partial nint ELEMENT_RESIST { get; set; } 
*/

            /// <summary>
            /// 0x48 BAD_STATUS_VALUE badStatusResist
            /// struct ["Assembly-CSharp.dll".""."BAD_STATUS_VALUE"]
            /// </summary>
            /// <returns>struct BAD_STATUS_VALUE</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("badStatusResist", "BAD_STATUS_VALUE")]
            public partial BAD_STATUS_VALUE BAD_STATUS_RESIST { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 target_percent
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("target_percent", "System.Int32")]
            public partial System.Int32 TARGET_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 normalAtk
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("normalAtk", "System.Int32")]
            public partial System.Int32 NORMAL_ATK { get; set; } 
*/

            /// <summary>
            /// 0x80 SKILL_ID[] skill
            /// class ["Assembly-CSharp.dll".""."SKILL_ID[]"]
            /// </summary>
            /// <returns>class SKILL_ID[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skill", "SKILL_ID[]")]
            public partial nint SKILL { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 elementManageId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementManageId", "System.Int32")]
            public partial System.Int32 ELEMENT_MANAGE_ID { get; set; } 
*/

            /// <summary>
            /// 0x8C System.Int32 soulId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("soulId", "System.Int32")]
            public partial System.Int32 SOUL_ID { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 itemId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("itemId", "System.Int32")]
            public partial System.Int32 ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0x94 System.Int32 kakuritsu
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("kakuritsu", "System.Int32")]
            public partial System.Int32 KAKURITSU { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Int32 phyAtk_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyAtk_bonus", "System.Int32")]
            public partial System.Int32 PHY_ATK_BONUS { get; set; } 
*/

            /// <summary>
            /// 0x9C System.Int32 phyDef_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("phyDef_bonus", "System.Int32")]
            public partial System.Int32 PHY_DEF_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 magAtk_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magAtk_bonus", "System.Int32")]
            public partial System.Int32 MAG_ATK_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xA4 System.Int32 magDef_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magDef_bonus", "System.Int32")]
            public partial System.Int32 MAG_DEF_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 evd_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("evd_bonus", "System.Int32")]
            public partial System.Int32 EVD_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xAC System.Int32 agi_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("agi_bonus", "System.Int32")]
            public partial System.Int32 AGI_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 hp_bonus
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hp_bonus", "System.Int32")]
            public partial System.Int32 HP_BONUS { get; set; } 
*/

            /// <summary>
            /// 0xB4 UnityEngine.Vector2Int drawOffset
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector2Int"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector2Int</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("drawOffset", "UnityEngine.Vector2Int")]
            public partial UnityEngine.Vector2Int DRAW_OFFSET { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_FUSION_INFO"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_FUSION_INFO
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