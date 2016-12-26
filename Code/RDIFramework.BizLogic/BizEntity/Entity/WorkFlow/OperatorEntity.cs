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
    /// OperatorEntity
    /// 处理者
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
    public partial class OperatorEntity : BaseEntity
    {
        /// <summary>
        /// 处理者主键
        /// </summary>
        public String OperatorId { get; set; }

        /// <summary>
        /// 流程模版主键
        /// </summary>
        public String WorkFlowId { get; set; }

        /// <summary>
        /// 所属流程任务、节点主键
        /// </summary>
        public String WorkTaskId { get; set; }
        /// <summary>
        /// 处理类型：
        ///  1当前处理者
        ///  2某一任务处理者
        /// 支持在当前任务中选定某一任务处理者。   
        /// </summary>
        public int? NextType { get; set; }

        /// <summary>
        /// 处理者类型
        /// </summary>
        public int? OperType { get; set; }

        /// <summary>
        /// 处理者内容，一个任务节点可以有多个处理者。根据OperType不同该字段的值代表不同的含义，例如Opertype=1时，此处代表组织机构的编号。
        /// 当Type==4时，此处保存为表达式的用来显示表达式   
        /// </summary>
        public String OperContent { get; set; }

        /// <summary>
        /// 与处理者类型的关系
        /// </summary>
        public int? Relation { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 处理者的名称、姓名、部门或角色
        /// </summary>
        public String OperDisplay { get; set; }

        /// <summary>
        /// 包含还是排除该处理者
        /// </summary>
        public int? InorExclude { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public OperatorEntity()
        {
            this.NextType = null;
            this.OperType = null;
            this.Relation = null;
            this.InorExclude = 1;
        }

        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow">数据行</param>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            this.OperatorId = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldOperatorId]);
            this.WorkFlowId = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldWorkFlowId]);
            this.WorkTaskId = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldWorkTaskId]);
            this.NextType = BusinessLogic.ConvertToNullableInt(dataRow[OperatorTable.FieldNextType]);
            this.OperType = BusinessLogic.ConvertToNullableInt(dataRow[OperatorTable.FieldOperType]);
            this.OperContent = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldOperContent]);
            this.Relation = BusinessLogic.ConvertToNullableInt(dataRow[OperatorTable.FieldRelation]);
            this.Description = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldDescription]);
            this.OperDisplay = BusinessLogic.ConvertToString(dataRow[OperatorTable.FieldOperDisplay]);
            this.InorExclude = BusinessLogic.ConvertToNullableInt(dataRow[OperatorTable.FieldInorExclude]);
            return this;
        }
    }
}
