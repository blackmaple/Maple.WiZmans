namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_OBJECT"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_OBJECT>, Ptr_TBB_OBJECT>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_OBJECT", "TBB_OBJECT")]
    public partial class TBB_OBJECT
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_OBJECT(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_OBJECT(System.IntPtr ptr) => new Ptr_TBB_OBJECT(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_OBJECT ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_OBJECT ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_OBJECT"]
        /// </summary>
        partial struct Ptr_TBB_OBJECT
        {
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_OBJECT"]
        /// </summary>
        partial struct Ptr_TBB_OBJECT
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
            ///   System.Object[] GetTableData(System.Int32 _index)
            /// </summary>
            /// <param name = "_index">struct System.Int32</param>
            /// <returns>class System.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTableData", "System.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_TABLE_DATA(System.Int32 _index); 
*/
        }
    }
}