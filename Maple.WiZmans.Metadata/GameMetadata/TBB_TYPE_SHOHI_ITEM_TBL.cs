namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SHOHI_ITEM_TBL"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TBB_TYPE_SHOHI_ITEM_TBL>, Ptr_TBB_TYPE_SHOHI_ITEM_TBL>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TBB_TYPE_SHOHI_ITEM_TBL", "TBB_TYPE_SHOHI_ITEM_TBL")]
    public partial class TBB_TYPE_SHOHI_ITEM_TBL
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TBB_TYPE_SHOHI_ITEM_TBL(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TBB_TYPE_SHOHI_ITEM_TBL(System.IntPtr ptr) => new Ptr_TBB_TYPE_SHOHI_ITEM_TBL(ptr);
            public static implicit operator System.IntPtr(Ptr_TBB_TYPE_SHOHI_ITEM_TBL ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TBB_TYPE_SHOHI_ITEM_TBL ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SHOHI_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_SHOHI_ITEM_TBL
        {
            /// <summary>
            /// 0x10 E_SHOHI_ITEM_KIND e_kind
            /// enum ["Assembly-CSharp.dll".""."E_SHOHI_ITEM_KIND"]
            /// </summary>
            /// <returns>enum E_SHOHI_ITEM_KIND</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("e_kind", "E_SHOHI_ITEM_KIND")]
            public partial E_SHOHI_ITEM_KIND E_KIND { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 animeId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("animeId", "System.Int32")]
            public partial System.Int32 ANIME_ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 calcForm
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("calcForm", "System.Int32")]
            public partial System.Int32 CALC_FORM { get; set; } 
*/

            /// <summary>
            /// 0x1C System.Int32 elementId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("elementId", "System.Int32")]
            public partial System.Int32 ELEMENT_ID { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32 atkVal
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("atkVal", "System.Int32")]
            public partial System.Int32 ATK_VAL { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Int32 range
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("range", "System.Int32")]
            public partial System.Int32 RANGE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 waitTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("waitTime", "System.Int32")]
            public partial System.Int32 WAIT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 isChainPossible
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("isChainPossible", "System.Int32")]
            public partial System.Int32 IS_CHAIN_POSSIBLE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 chainRiseVal
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chainRiseVal", "System.Int32")]
            public partial System.Int32 CHAIN_RISE_VAL { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] sell_price
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sell_price", "System.Int32[]")]
            public partial nint SELL_PRICE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 sellFg
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sellFg", "System.Int32")]
            public partial System.Int32 SELL_FG { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 rarelity
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("rarelity", "System.Int32")]
            public partial System.Int32 RARELITY { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 sort_id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("sort_id", "System.Int32")]
            public partial System.Int32 SORT_ID { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 dataUseFg
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("dataUseFg", "System.Int32")]
            public partial System.Int32 DATA_USE_FG { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 addStat
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("addStat", "System.Int32")]
            public partial System.Int32 ADD_STAT { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 directId
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("directId", "System.Int32")]
            public partial System.Int32 DIRECT_ID { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SHOHI_ITEM_TBL"]
        /// </summary>
        partial struct Ptr_TBB_TYPE_SHOHI_ITEM_TBL
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