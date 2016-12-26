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
    /// CiFileEntity
    /// 文件表
    ///
    /// 修改纪录
    ///
    ///     2014-07-30 版本: 2.8 EricHu 以自动属性进行重新组织。
    ///	    2012-03-02 版本：1.0 EricHu 创建主键。
    ///
    /// 版本：3.0
    ///
    /// <author>
    ///		<name>EricHu</name>
    ///		<date>2012-03-02</date>
    /// </author>
    /// </summary>
    [Serializable]
    public partial class CiFileEntity :BaseEntity
    {
        /// <summary>
        /// 代码
        /// </summary>
        public String Id { get; set; }

        /// <summary>
        /// 文件夹节点代码
        /// </summary>
        public String FolderId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public String FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public String FilePath { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        public byte[] FileContent { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public Double? FileSize { get; set; }

        /// <summary>
        /// 图片文件位置
        /// </summary>
        public String ImageUrl { get; set; }

        /// <summary>
        /// 被阅读次数
        /// </summary>
        public int? ReadCount { get; set; }

        /// <summary>
        /// 文件类别
        /// </summary>
        public String Category { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public String Description { get; set; }
        /// <summary>
        /// 有效
        /// </summary>
        public int? Enabled { get; set; }

        /// <summary>
        /// 排序码
        /// </summary>
        public int? SortCode { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        public int? DeleteMark { get; set; }

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

        /// <summary>
        /// 修改用户
        /// </summary>
        public String ModifiedBy { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public CiFileEntity()
        {
            this.Enabled = 1;
            this.ReadCount = 0;
            this.SortCode = null;
            this.ImageUrl = "";
            this.DeleteMark = 0;
        }

        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow">数据行</param>
        protected override BaseEntity GetFrom(IDataRow dataRow)
        {
            this.Id = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldId]);
            this.FolderId = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldFolderId]);
            this.FileName = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldFileName]);
            this.FilePath = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldFilePath]);
            this.FileSize = BusinessLogic.ConvertToNullableDouble(dataRow[CiFileTable.FieldFileSize]);
            this.FileContent = BusinessLogic.ConvertToByte(dataRow[CiFileTable.FieldFileContent]);
            this.ImageUrl = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldImageUrl]);
            this.ReadCount = BusinessLogic.ConvertToNullableInt(dataRow[CiFileTable.FieldReadCount]);
            this.Category = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldCategory]);
            this.Description = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldDescription]);
            this.Enabled = BusinessLogic.ConvertToNullableInt(dataRow[CiFileTable.FieldEnabled]);
            this.SortCode = BusinessLogic.ConvertToNullableInt(dataRow[CiFileTable.FieldSortCode]);
            this.DeleteMark = BusinessLogic.ConvertToNullableInt(dataRow[CiFileTable.FieldDeleteMark]);
            this.CreateOn = BusinessLogic.ConvertToNullableDateTime(dataRow[CiFileTable.FieldCreateOn]);
            this.CreateUserId = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldCreateUserId]);
            this.CreateBy = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldCreateBy]);
            this.ModifiedOn = BusinessLogic.ConvertToNullableDateTime(dataRow[CiFileTable.FieldModifiedOn]);
            this.ModifiedUserId = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldModifiedUserId]);
            this.ModifiedBy = BusinessLogic.ConvertToString(dataRow[CiFileTable.FieldModifiedBy]);
            return this;
        }
    }
}
