namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL_SHUTOKU_TBL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL>, Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_BASE_SKILL_SHUTOKU_TBL", "TBB_TYPE_BASE_SKILL_SHUTOKU_TBL")]
    public partial class TBB_TYPE_BASE_SKILL_SHUTOKU_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL_SHUTOKU_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL
        {
            /// <summary>
            /// 0x10 E_SKILL_HAVE_FUL_KIND haveful_kind
            /// enum ["Assembly-CSharp.dll".""."E_SKILL_HAVE_FUL_KIND"]
            /// </summary>
            /// <returns>enum E_SKILL_HAVE_FUL_KIND</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("haveful_kind", "E_SKILL_HAVE_FUL_KIND")]
            public partial E_SKILL_HAVE_FUL_KIND HAVEFUL_KIND { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 unlock
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("unlock", "System.Int32")]
            public partial System.Int32 UNLOCK { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 unlockValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("unlockValue", "System.Int32")]
            public partial System.Int32 UNLOCK_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 getValue
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("getValue", "System.Int32")]
            public partial System.Int32 GET_VALUE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 hint
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hint", "System.Int32")]
            public partial System.Int32 HINT { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 description
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("description", "System.Int32")]
            public partial System.Int32 DESCRIPTION { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL_SHUTOKU_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL
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