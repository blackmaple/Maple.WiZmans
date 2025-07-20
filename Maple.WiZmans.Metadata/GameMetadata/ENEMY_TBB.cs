namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ENEMY_TBB"]
    /// [TBB_OBJECT]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ENEMY_TBB>, Ptr_ENEMY_TBB>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ENEMY_TBB", "ENEMY_TBB")]
    public partial class ENEMY_TBB
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ENEMY_TBB(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ENEMY_TBB(System.IntPtr ptr) => new Ptr_ENEMY_TBB(ptr);
            public static implicit operator System.IntPtr(Ptr_ENEMY_TBB ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ENEMY_TBB ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ENEMY_TBB"]
        /// </summary>
        partial struct Ptr_ENEMY_TBB
        {
            /// <summary>
            /// 0x10 TBB_TYPE_ENEMY_TBL[] Enemy
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_ENEMY_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_ENEMY_TBL[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Enemy", "TBB_TYPE_ENEMY_TBL[]")]
            public partial nint ENEMY { get; set; } 
*/

            /// <summary>
            /// 0x18 BTL_CHAR_BASE_DATA[] Table
            /// class ["Assembly-CSharp.dll".""."BTL_CHAR_BASE_DATA[]"]
            /// </summary>
            /// <returns>class BTL_CHAR_BASE_DATA[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Table", "BTL_CHAR_BASE_DATA[]")]
            public partial nint TABLE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ENEMY_TBB"]
        /// </summary>
        partial struct Ptr_ENEMY_TBB
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

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_OBJECT"]
        /// </summary>
        partial struct Ptr_ENEMY_TBB
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