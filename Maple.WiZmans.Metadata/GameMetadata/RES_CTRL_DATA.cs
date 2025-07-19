namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."RES_CTRL_DATA"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RES_CTRL_DATA>, Ptr_RES_CTRL_DATA>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "RES_CTRL_DATA", "RES_CTRL_DATA")]
    public partial class RES_CTRL_DATA
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RES_CTRL_DATA(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RES_CTRL_DATA(System.IntPtr ptr) => new Ptr_RES_CTRL_DATA(ptr);
            public static implicit operator System.IntPtr(Ptr_RES_CTRL_DATA ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_RES_CTRL_DATA ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RES_CTRL_DATA"]
        /// </summary>
        partial struct Ptr_RES_CTRL_DATA
        {
            /// <summary>
            /// 0x10 System.String pFileName
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pFileName", "System.String")]
           public partial nint P_FILE_NAME { get; set; } 
*/

            /// <summary>
            /// 0x18 TBB_OBJECT pBuffer
            /// class ["Assembly-CSharp.dll".""."TBB_OBJECT"]
            /// </summary>
            /// <returns>class TBB_OBJECT</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pBuffer", "TBB_OBJECT")]
            public partial TBB_OBJECT.Ptr_TBB_OBJECT P_BUFFER { get; set; }


            /// <summary>
            /// 0x20 System.Boolean IsStayPerm
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsStayPerm", "System.Boolean")]
           public partial System.Boolean IS_STAY_PERM { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RES_CTRL_DATA"]
        /// </summary>
        partial struct Ptr_RES_CTRL_DATA
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
            ///   System.Void .ctor(System.String _pFileName, TBB_OBJECT _pBuffer, System.Boolean _isStayPerm)
            /// </summary>
            /// <param name = "_pFileName">class System.String</param>
            /// <param name = "_pBuffer">class TBB_OBJECT</param>
            /// <param name = "_isStayPerm">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TBB_OBJECT", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CTOR(nint _pFileName, nint _pBuffer, System.Boolean _isStayPerm); 
*/
        }
    }
}