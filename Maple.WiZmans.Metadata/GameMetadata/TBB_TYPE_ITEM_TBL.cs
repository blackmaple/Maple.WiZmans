using Maple.MonoGameAssistant.Core;

namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_ITEM_TBL"]
    /// [TBB_OBJECT]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_ITEM_TBL>, Ptr_TBB_TYPE_ITEM_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_ITEM_TBL", "TBB_TYPE_ITEM_TBL")]
    public partial class TBB_TYPE_ITEM_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_ITEM_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_ITEM_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_ITEM_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_ITEM_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_ITEM_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_ITEM_TBL
        {
            /// <summary>
            /// 0x10 TBB_TYPE_SHOHI_ITEM_TBL[] Shohi
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SHOHI_ITEM_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_SHOHI_ITEM_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Shohi", "TBB_TYPE_SHOHI_ITEM_TBL[]")]
            public partial PMonoArray<TBB_TYPE_SHOHI_ITEM_TBL.Ptr_TBB_TYPE_SHOHI_ITEM_TBL> SHOHI { get; set; } 


            /// <summary>
            /// 0x18 TBB_TYPE_SOUBI_ITEM_TBL[] Soubi
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SOUBI_ITEM_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_SOUBI_ITEM_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Soubi", "TBB_TYPE_SOUBI_ITEM_TBL[]")]
            public partial PMonoArray<TBB_TYPE_SOUBI_ITEM_TBL.Ptr_TBB_TYPE_SOUBI_ITEM_TBL> SOUBI { get; set; } 


            /// <summary>
            /// 0x20 TBB_TYPE_APL_SOZAI_ITEM_TBL[] Sozai
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_APL_SOZAI_ITEM_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_APL_SOZAI_ITEM_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Sozai", "TBB_TYPE_APL_SOZAI_ITEM_TBL[]")]
            public partial PMonoArray<TBB_TYPE_APL_SOZAI_ITEM_TBL.Ptr_TBB_TYPE_APL_SOZAI_ITEM_TBL> SOZAI { get; set; } 


            /// <summary>
            /// 0x28 TBB_TYPE_SPIRIT_ITEM_TBL[] Spirit
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SPIRIT_ITEM_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_SPIRIT_ITEM_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Spirit", "TBB_TYPE_SPIRIT_ITEM_TBL[]")]
            public partial PMonoArray<TBB_TYPE_SPIRIT_ITEM_TBL.Ptr_TBB_TYPE_SPIRIT_ITEM_TBL> SPIRIT { get; set; } 


            /// <summary>
            /// 0x30 TBB_TYPE_KICHOHIN_ITEM_TBL[] Kityohin
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_KICHOHIN_ITEM_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_KICHOHIN_ITEM_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Kityohin", "TBB_TYPE_KICHOHIN_ITEM_TBL[]")]
            public partial PMonoArray<TBB_TYPE_KICHOHIN_ITEM_TBL.Ptr_TBB_TYPE_KICHOHIN_ITEM_TBL> KITYOHIN { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_ITEM_TBL
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
        partial struct Ptr_TBB_TYPE_ITEM_TBL
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