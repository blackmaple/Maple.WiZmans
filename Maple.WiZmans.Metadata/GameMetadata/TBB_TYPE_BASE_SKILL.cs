namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_BASE_SKILL>, Ptr_TBB_TYPE_BASE_SKILL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_BASE_SKILL", "TBB_TYPE_BASE_SKILL")]
    public partial class TBB_TYPE_BASE_SKILL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_BASE_SKILL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_BASE_SKILL(System.IntPtr ptr) => new Ptr_TBB_TYPE_BASE_SKILL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_BASE_SKILL ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_TBB_TYPE_BASE_SKILL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_BASE_SKILL
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            //public partial System.Int32 ID { get; }


            /// <summary>
            /// 0x14 E_SKILL_HAVE_FUL_KIND haveful_kind
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_HAVE_FUL_KIND"]
            /// </summary>
            /// <returns>enum E_SKILL_HAVE_FUL_KIND</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveful_kind", "E_SKILL_HAVE_FUL_KIND")]
            //public partial E_SKILL_HAVE_FUL_KIND HAVEFUL_KIND { get; }


            /// <summary>
            /// 0x18 E_SKILL_ICON_CATEGORY icon_category
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_ICON_CATEGORY"]
            /// </summary>
            /// <returns>enum E_SKILL_ICON_CATEGORY</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon_category", "E_SKILL_ICON_CATEGORY")]
            //public partial E_SKILL_ICON_CATEGORY ICON_CATEGORY { get; }


            /// <summary>
            /// 0x1C System.Int32 effectTblId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("effectTblId", "System.Int32")]
           public partial System.Int32 EFFECT_TBL_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 value
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("value", "System.Int32")]
           public partial System.Int32 VALUE { get; set; } 
*/

            /// <summary>
            /// 0x24 E_SKILL_ADD_KIND addKind
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_ADD_KIND"]
            /// </summary>
            /// <returns>enum E_SKILL_ADD_KIND</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("addKind", "E_SKILL_ADD_KIND")]
           public partial E_SKILL_ADD_KIND ADD_KIND { get; set; } 
*/

            /// <summary>
            /// 0x28 E_SKILL_WHO_KIND whoKind
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_WHO_KIND"]
            /// </summary>
            /// <returns>enum E_SKILL_WHO_KIND</returns>

            //[Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("whoKind", "E_SKILL_WHO_KIND")]
            //public partial E_SKILL_WHO_KIND WHO_KIND { get; }

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_BASE_SKILL
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