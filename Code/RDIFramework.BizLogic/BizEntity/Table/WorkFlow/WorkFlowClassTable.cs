﻿#region RDIFramework.NET-generated
//------------------------------------------------------------------------------
//     RDIFramework.NET（.NET快速信息化系统开发、整合框架）是基于.NET的快速信息化系统开发、整合框架，给用户和开发者最佳的.Net框架部署方案。
//     RDIFramework.NET平台包含基础公共类库、强大的权限控制、模块分配、数据字典、自动升级、各商业级控件库、工作流平台、代码生成器、开发辅助
//工具等，应用系统的各个业务功能子系统，在系统体系结构设计的过程中被设计成各个原子功能模块，各个子功能模块按照业务功能组织成单独的程序集文
//件，各子系统开发完成后，由RDIFramework.NET平台进行统一的集成部署。
//
//	框架官网：http://www.rdiframework.net/
//	框架博客：http://blog.rdiframework.net/
//	交流QQ：406590790 
//	邮件交流：406590790@qq.com
//	其他博客：
//    http://www.cnblogs.com/huyong 
//    http://blog.csdn.net/chinahuyong
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由RDIFramework.NET平台代码生成工具自动生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
#endregion

using System;

namespace RDIFramework.BizLogic
{
    /// <summary>
    /// WorkFlowClassTable
    /// 
    /// 
    /// 修改纪录
    /// 
    /// 2014-06-03 版本：1.0 EricHu 创建主键。
    /// 
    /// 版本：1.0
    /// 
    /// <author>
    /// <name>EricHu</name>
    /// <date>2014-06-03</date>
    /// </author>
    /// </summary>
    public partial class WorkFlowClassTable
    {
        ///<summary>
        /// 表名称
        ///</summary>
        [NonSerialized]
        public static string TableName = "WORKFLOWCLASS";

        ///<summary>
        /// 主键
        ///</summary>
        [NonSerialized]
        public static string FieldWFClassId = "WFCLASSID";

        ///<summary>
        /// 分类名称
        ///</summary>
        [NonSerialized]
        public static string FieldCaption = "CAPTION";

        ///<summary>
        /// 父分类ID
        ///</summary>
        [NonSerialized]
        public static string FieldFatherId = "FATHERID";

        ///<summary>
        /// 描述
        ///</summary>
        [NonSerialized]
        public static string FieldDescription = "DESCRIPTION";

        ///<summary>
        /// 分类的级别
        ///</summary>
        [NonSerialized]
        public static string FieldClLevel = "CLLEVEL";

        ///<summary>
        /// 分类管理对应的界面URL
        ///</summary>
        [NonSerialized]
        public static string FieldClMgrUrl = "CLMGRURL";
    }
}
