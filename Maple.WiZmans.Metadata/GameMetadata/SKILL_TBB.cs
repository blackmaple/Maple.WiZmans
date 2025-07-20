using Maple.MonoGameAssistant.Core;

namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SKILL_TBB"]
    /// [TBB_OBJECT]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SKILL_TBB>, Ptr_SKILL_TBB>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "SKILL_TBB", "SKILL_TBB")]
    public partial class SKILL_TBB
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SKILL_TBB(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SKILL_TBB(System.IntPtr ptr) => new Ptr_SKILL_TBB(ptr);
            public static implicit operator System.IntPtr(Ptr_SKILL_TBB ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SKILL_TBB ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SKILL_TBB"]
        /// </summary>
        partial struct Ptr_SKILL_TBB
        {
            /// <summary>
            /// 0x10 TBB_TYPE_BASE_SKILL[] BaseSkill
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_BASE_SKILL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BaseSkill", "TBB_TYPE_BASE_SKILL[]")]
            public partial PMonoArray<TBB_TYPE_BASE_SKILL.Ptr_TBB_TYPE_BASE_SKILL> BASE_SKILL { get; set; } 


            /// <summary>
            /// 0x18 TBB_TYPE_PASSIVE_SKILL_TBL[] PassiveSkill
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_PASSIVE_SKILL_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_PASSIVE_SKILL_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PassiveSkill", "TBB_TYPE_PASSIVE_SKILL_TBL[]")]
            public partial PMonoArray<TBB_TYPE_PASSIVE_SKILL_TBL.Ptr_TBB_TYPE_PASSIVE_SKILL_TBL> PASSIVE_SKILL { get; set; } 


            /// <summary>
            /// 0x20 TBB_TYPE_ACTIVE_SKILL_TBL[] ActiveSkill
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_ACTIVE_SKILL_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_ACTIVE_SKILL_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActiveSkill", "TBB_TYPE_ACTIVE_SKILL_TBL[]")]
            public partial PMonoArray<TBB_TYPE_ACTIVE_SKILL_TBL.Ptr_TBB_TYPE_ACTIVE_SKILL_TBL> ACTIVE_SKILL { get; set; } 


            /// <summary>
            /// 0x28 TBB_TYPE_SKILL_EFFECT_TBL[] EffectSkill
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_SKILL_EFFECT_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_SKILL_EFFECT_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectSkill", "TBB_TYPE_SKILL_EFFECT_TBL[]")]
            public partial PMonoArray<TBB_TYPE_SKILL_EFFECT_TBL.Ptr_TBB_TYPE_SKILL_EFFECT_TBL> EFFECT_SKILL { get; set; } 


            /// <summary>
            /// 0x30 TBB_TYPE_BASE_SKILL_SHUTOKU_TBL[] ShutokuSkill
            /// class ["Assembly-CSharp.dll".""."TBB_TYPE_BASE_SKILL_SHUTOKU_TBL[]"]
            /// </summary>
            /// <returns>class TBB_TYPE_BASE_SKILL_SHUTOKU_TBL[]</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ShutokuSkill", "TBB_TYPE_BASE_SKILL_SHUTOKU_TBL[]")]
            public partial PMonoArray<TBB_TYPE_BASE_SKILL_SHUTOKU_TBL.Ptr_TBB_TYPE_BASE_SKILL_SHUTOKU_TBL> SHUTOKU_SKILL { get; set; } 

        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SKILL_TBB"]
        /// </summary>
        partial struct Ptr_SKILL_TBB
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
        partial struct Ptr_SKILL_TBB
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