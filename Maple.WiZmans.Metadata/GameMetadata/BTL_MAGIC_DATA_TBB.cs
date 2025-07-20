using Maple.MonoGameAssistant.Core;

namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."BTL_MAGIC_DATA_TBB"]
    /// [TBB_OBJECT]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BTL_MAGIC_DATA_TBB>, Ptr_BTL_MAGIC_DATA_TBB>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "BTL_MAGIC_DATA_TBB", "BTL_MAGIC_DATA_TBB")]
    public partial class BTL_MAGIC_DATA_TBB
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BTL_MAGIC_DATA_TBB(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BTL_MAGIC_DATA_TBB(System.IntPtr ptr) => new Ptr_BTL_MAGIC_DATA_TBB(ptr);
            public static implicit operator System.IntPtr(Ptr_BTL_MAGIC_DATA_TBB ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_BTL_MAGIC_DATA_TBB ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BTL_MAGIC_DATA_TBB"]
        /// </summary>
        partial struct Ptr_BTL_MAGIC_DATA_TBB
        {
            /// <summary>
            /// 0x10 BTL_MAGIC_DATA[] Skill
            /// class ["Assembly-CSharp.dll".""."BTL_MAGIC_DATA[]"]
            /// </summary>
            /// <returns>class BTL_MAGIC_DATA[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Skill", "BTL_MAGIC_DATA[]")]
            public partial PMonoArray<BTL_MAGIC_DATA.Ptr_BTL_MAGIC_DATA> SKILL { get; set; } 


            /// <summary>
            /// 0x18 BTL_MAGIC_DATA[] Magic
            /// class ["Assembly-CSharp.dll".""."BTL_MAGIC_DATA[]"]
            /// </summary>
            /// <returns>class BTL_MAGIC_DATA[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Magic", "BTL_MAGIC_DATA[]")]
            public partial PMonoArray<BTL_MAGIC_DATA.Ptr_BTL_MAGIC_DATA> MAGIC { get; set; } 


            /// <summary>
            /// 0x20 TBB_TYPE_UNIQUE_ATTACK_TBL[] UniqueAttack_Party
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_UNIQUE_ATTACK_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_UNIQUE_ATTACK_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UniqueAttack_Party", "TBB_TYPE_UNIQUE_ATTACK_TBL[]")]
            public partial PMonoArray<TBB_TYPE_UNIQUE_ATTACK_TBL.Ptr_TBB_TYPE_UNIQUE_ATTACK_TBL> UNIQUE_ATTACK_PARTY { get; set; } 


            /// <summary>
            /// 0x28 TBB_TYPE_UNIQUE_ATTACK_TBL[] UniqueAttack_Enemy
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_UNIQUE_ATTACK_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_UNIQUE_ATTACK_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UniqueAttack_Enemy", "TBB_TYPE_UNIQUE_ATTACK_TBL[]")]
            public partial PMonoArray<TBB_TYPE_UNIQUE_ATTACK_TBL.Ptr_TBB_TYPE_UNIQUE_ATTACK_TBL> UNIQUE_ATTACK_ENEMY { get; set; } 


            /// <summary>
            /// 0x30 TBB_TYPE_UNIQUE_ATTACK_TBL[] UniqueAttack_DLCEnemy
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_UNIQUE_ATTACK_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_UNIQUE_ATTACK_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UniqueAttack_DLCEnemy", "TBB_TYPE_UNIQUE_ATTACK_TBL[]")]
            public partial PMonoArray<TBB_TYPE_UNIQUE_ATTACK_TBL.Ptr_TBB_TYPE_UNIQUE_ATTACK_TBL> UNIQUE_ATTACK_DLC_ENEMY { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BTL_MAGIC_DATA_TBB"]
        /// </summary>
        partial struct Ptr_BTL_MAGIC_DATA_TBB
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
        partial struct Ptr_BTL_MAGIC_DATA_TBB
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