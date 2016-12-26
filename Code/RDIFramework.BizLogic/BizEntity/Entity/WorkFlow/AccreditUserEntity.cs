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
    using RDIFramework.Utilities;

    /// <summary>
    /// AccreditUserEntity
    /// 
    /// 
    /// 修改纪录
    /// 
    /// 2014-06-03 版本：1.0 EricHu 创建主键。
    /// 
    /// 版本：3.0
    /// 
    /// <author>
    /// <name>EricHu</name>
    /// <date>2014-06-03</date>
    /// </author>
    /// </summary>
    [Serializable]
    public partial class AccreditUserEntity : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String AUserId { get; set; }

        /// <summary>
        /// AccreditFromUserId
        /// </summary>
        public String AccreditFromUserId { get; set; }

        /// <summary>
        /// AccreditToUserId
        /// </summary>
        public String AccreditToUserId { get; set; }

        /// <summary>
        /// AccreditDateTime
        /// </summary>
        public DateTime? AccreditDateTime { get; set; }

        /// <summary>
        /// AccreditStatus
        /// </summary>
        public String AccreditStatus { get; set; }
      
        /// <summary>
        /// AcWorkflowId
        /// </summary>
        public String AcWorkflowId { get; set; }
       
        /// <summary>
        /// AcWorktaskId
        /// </summary>
        public String AcWorktaskId { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public AccreditUserEntity()
        {
            this.AccreditDateTime = DateTime.Now;
            this.AccreditStatus = "1";
        }

        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow">数据行</param>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            this.AUserId = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAUserId]);
            this.AccreditFromUserId = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAccreditFromUserId]);
            this.AccreditToUserId = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAccreditToUserId]);
            this.AccreditDateTime = BusinessLogic.ConvertToNullableDateTime(dataRow[AccreditUserTable.FieldAccreditDateTime]);
            this.AccreditStatus = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAccreditStatus]);
            this.AcWorkflowId = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAcWorkflowId]);
            this.AcWorktaskId = BusinessLogic.ConvertToString(dataRow[AccreditUserTable.FieldAcWorktaskId]);
            return this;
        }
    }
}
