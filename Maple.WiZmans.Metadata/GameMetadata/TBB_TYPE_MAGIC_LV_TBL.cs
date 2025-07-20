namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_MAGIC_LV_TBL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_MAGIC_LV_TBL>, Ptr_TBB_TYPE_MAGIC_LV_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_MAGIC_LV_TBL", "TBB_TYPE_MAGIC_LV_TBL")]
    public partial class TBB_TYPE_MAGIC_LV_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_MAGIC_LV_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_MAGIC_LV_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_MAGIC_LV_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_MAGIC_LV_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_MAGIC_LV_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_MAGIC_LV_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_MAGIC_LV_TBL
        {
            /// <summary>
            /// 0x10 System.Int32 lv
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lv", "System.Int32")]
            public partial System.Int32 LV { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 magicId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("magicId", "System.Int32")]
            public partial System.Int32 MAGIC_ID { get; set; } 
 
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_MAGIC_LV_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_MAGIC_LV_TBL
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