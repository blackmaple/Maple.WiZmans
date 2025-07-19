using Maple.MonoGameAssistant.Core;

namespace Maple.WiZmans.Metadata
{
    /// <summary>
    /// static class ["Assembly-CSharp.dll".""."ResLoad"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ResLoad>, Ptr_ResLoad>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ResLoad", "ResLoad")]
    public partial class ResLoad
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ResLoad(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ResLoad(System.IntPtr ptr) => new Ptr_ResLoad(ptr);
            public static implicit operator System.IntPtr(Ptr_ResLoad ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ResLoad ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// static class ["Assembly-CSharp.dll".""."ResLoad"]
        /// </summary>
        partial struct Ptr_ResLoad
        {
            /// <summary>
            /// 0x0 RES_CTRL_DATA[] s_ResCtrlData
            /// class ["Assembly-CSharp.dll".""."RES_CTRL_DATA[]"]
            /// </summary>
            /// <returns>class RES_CTRL_DATA[]</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("s_ResCtrlData", "RES_CTRL_DATA[]")]
            public static partial PMonoArray<RES_CTRL_DATA.Ptr_RES_CTRL_DATA> S_RES_CTRL_DATA { get; set; }

        }

        /// <summary>
        /// static class ["Assembly-CSharp.dll".""."ResLoad"]
        /// </summary>
        partial struct Ptr_ResLoad
        {
            /// <summary>
            /// static  System.Boolean _CheckNo(System.Int32 ResNo)
            /// </summary>
            /// <param name = "ResNo">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("_CheckNo", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean _CHECK_NO(System.Int32 ResNo); 
*/
            /// <summary>
            /// static  System.Boolean _isLoad(RES_CTRL_DATA pCtrl)
            /// </summary>
            /// <param name = "pCtrl">class RES_CTRL_DATA</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("_isLoad", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("RES_CTRL_DATA", 0)]
            public static partial System.Boolean _IS_LOAD(nint pCtrl); 
*/
            /// <summary>
            /// static  System.Void _Load(System.Int32 _index, RES_CTRL_DATA pCtrl)
            /// </summary>
            /// <param name = "_index">struct System.Int32</param>
            /// <param name = "pCtrl">class RES_CTRL_DATA</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("_Load", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("RES_CTRL_DATA", 1)]
            public static partial void _LOAD(System.Int32 _index, nint pCtrl); 
*/
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void CreateTable(System.Int32 _index, System.Byte[] _srcBuffer, TBB_OBJECT& _dstBuffer)
            /// </summary>
            /// <param name = "_index">struct System.Int32</param>
            /// <param name = "_srcBuffer">class System.Byte[]</param>
            /// <param name = "_dstBuffer">class TBB_OBJECT&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateTable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("TBB_OBJECT&", 2)]
            public static partial void CREATE_TABLE(System.Int32 _index, nint _srcBuffer, nint _dstBuffer); 
*/
            /// <summary>
            /// static  System.Boolean DeleteResource(System.Int32 ResNo)
            /// </summary>
            /// <param name = "ResNo">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeleteResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean DELETE_RESOURCE(System.Int32 ResNo); 
*/
            /// <summary>
            /// static  TBB_OBJECT GetResourcePointer_FromResourceNo(System.Int32 _ResNo)
            /// </summary>
            /// <param name = "_ResNo">struct System.Int32</param>
            /// <returns>class TBB_OBJECT</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetResourcePointer_FromResourceNo", "TBB_OBJECT", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint GET_RESOURCE_POINTER_FROM_RESOURCE_NO(System.Int32 _ResNo); 
*/
            /// <summary>
            /// static  System.Object[] GetTbl_FromResNo(System.Int32 TbbResNo, System.Int32 TblNo)
            /// </summary>
            /// <param name = "TbbResNo">struct System.Int32</param>
            /// <param name = "TblNo">struct System.Int32</param>
            /// <returns>class System.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTbl_FromResNo", "System.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint GET_TBL_FROM_RES_NO(System.Int32 TbbResNo, System.Int32 TblNo); 
*/
            /// <summary>
            /// static  System.Boolean IsResourceLoad(System.Int32 _resNo)
            /// </summary>
            /// <param name = "_resNo">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsResourceLoad", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean IS_RESOURCE_LOAD(System.Int32 _resNo); 
*/
            /// <summary>
            /// static  System.Void LoadTables()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadTables", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void LOAD_TABLES(); 
*/
            /// <summary>
            /// static  System.Boolean RequestLoadResource(System.Int32 _resNo)
            /// </summary>
            /// <param name = "_resNo">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RequestLoadResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean REQUEST_LOAD_RESOURCE(System.Int32 _resNo); 
*/
            /// <summary>
            /// static  System.Boolean RequestLoadStayPermResource()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RequestLoadStayPermResource", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean REQUEST_LOAD_STAY_PERM_RESOURCE(); 
*/
        }
    }
}