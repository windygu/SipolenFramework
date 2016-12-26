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
    /// PiTablePermissionScopeEntity
    /// 表数据范围权限
    /// 
    /// 修改纪录
    ///     
    ///     2014-07-30 版本: 2.8 EricHu 以自动属性进行重新组织。
    ///     2013-03-08 版本：3.0 EricHu 创建主键。
    /// 
    /// 版本：3.0
    /// 
    /// <author>
    /// <name>EricHu</name>
    /// <date>2013-03-08</date>
    /// </author>
    /// </summary>
    [Serializable]
    public partial class PiTablePermissionScopeEntity : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// 表
        /// </summary>
        public String ParentId { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public String ItemCode { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public String ItemName { get; set; }

        /// <summary>
        /// 表
        /// </summary>
        public String ItemValue { get; set; }

        /// <summary>
        /// 有效
        /// </summary>
        public int? Enabled { get; set; }

        /// <summary>
        /// 是公开
        /// </summary>
        public int? IsPublic { get; set; }

        /// <summary>
        /// 允许编辑
        /// </summary>
        public int? AllowEdit { get; set; }

        /// <summary>
        /// 允许删除
        /// </summary>
        public int? AllowDelete { get; set; }

        /// <summary>
        /// 删除标记
        /// </summary>
        public int? DeleteMark { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public int? SortCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateOn { get; set; }

        /// <summary>
        /// 创建用户主键
        /// </summary>
        public String CreateUserId { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public String CreateBy { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// 修改用户主键
        /// </summary>
        public String ModifiedUserId { get; set; }

        ///<summary>
        /// 修改用户
        /// </summary>
        public String ModifiedBy { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public PiTablePermissionScopeEntity()
        {
            this.Enabled = 1;
            this.IsPublic = 0;
            this.AllowDelete = 0;
            this.AllowEdit = 0;
            this.DeleteMark = 0;
            this.SortCode = null;
        }

        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow">数据行</param>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            this.Id = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldId]);
            this.ParentId = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldParentId]);
            this.ItemCode = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldItemCode]);
            this.ItemName = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldItemName]);
            this.ItemValue = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldItemValue]);
            this.Enabled = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldEnabled]);
            this.IsPublic = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldIsPublic]);
            this.AllowEdit = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldAllowEdit]);
            this.AllowDelete = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldAllowDelete]);
            this.DeleteMark = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldDeleteMark]);
            this.SortCode = BusinessLogic.ConvertToNullableInt(dataRow[PiTablePermissionScopeTable.FieldSortCode]);
            this.Description = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldDescription]);
            this.CreateOn = BusinessLogic.ConvertToNullableDateTime(dataRow[PiTablePermissionScopeTable.FieldCreateOn]);
            this.CreateUserId = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldCreateUserId]);
            this.CreateBy = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldCreateBy]);
            this.ModifiedOn = BusinessLogic.ConvertToNullableDateTime(dataRow[PiTablePermissionScopeTable.FieldModifiedOn]);
            this.ModifiedUserId = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldModifiedUserId]);
            this.ModifiedBy = BusinessLogic.ConvertToString(dataRow[PiTablePermissionScopeTable.FieldModifiedBy]);
            return this;
        }
    }
}
