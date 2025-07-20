namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_KICHOHIN_ITEM_TBL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL>, Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_KICHOHIN_ITEM_TBL", "TBB_TYPE_KICHOHIN_ITEM_TBL")]
    public partial class TBB_TYPE_KICHOHIN_ITEM_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_KICHOHIN_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL
        {
            /// <summary>
            /// 0x10 System.Int32 sort_id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sort_id", "System.Int32")]
            public partial System.Int32 SORT_ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 dataUseFg
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dataUseFg", "System.Int32")]
            public partial System.Int32 DATA_USE_FG { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_KICHOHIN_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL
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