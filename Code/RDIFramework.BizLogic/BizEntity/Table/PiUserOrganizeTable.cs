﻿/******************************************************************************
 *  All Rights Reserved , Copyright (C) 2012 , XuWangBin. 
 *  作    者： XuWangBin
 *  创建时间： 2012-7-20 16:35:54
 ******************************************************************************/

using System;

namespace RDIFramework.BizLogic
{
     /// <summary>
     /// PiUserOrganizeTable
     /// 用户账户组织关系表
     ///
     /// 修改纪录
     ///
     ///		2012-03-02 版本：1.0 XuWangBin 创建主键。
     ///
     /// 版本：1.0
     ///
     /// <author>
     ///		<name>XuWangBin</name>
     ///		<date>2012-03-02</date>
     /// </author>
     /// </summary>
     public partial class PiUserOrganizeTable
     {
          ///<summary>
          /// 用户账户组织关系表
          ///</summary>
          [NonSerialized]
          public static string TableName = "PIUSERORGANIZE";

          ///<summary>
          /// 主键
          ///</summary>
          [NonSerialized]
          public static string FieldId = "ID";

          ///<summary>
          /// 用户账户主键
          ///</summary>
          [NonSerialized]
          public static string FieldUserId = "USERID";

          ///<summary>
          /// 公司代码
          ///</summary>
          [NonSerialized]
          public static string FieldCompanyId = "COMPANYID";

          ///<summary>
          /// 子公司代码
          ///</summary>
          [NonSerialized]
          public static string FieldSubCompanyId = "SUBCOMPANYID";

          ///<summary>
          /// 部门代码
          ///</summary>
          [NonSerialized]
          public static string FieldDepartmentId = "DEPARTMENTID";

          ///<summary>
          /// 子部门代码
          ///</summary>
          [NonSerialized]
          public static string FieldSubDepartmentId = "SUBDEPARTMENTID";

          ///<summary>
          /// 工作组代码
          ///</summary>
          [NonSerialized]
          public static string FieldWorkgroupId = "WORKGROUPID";

          ///<summary>
          /// 角色[职位]主键
          ///</summary>
          [NonSerialized]
          public static string FieldRoleId = "ROLEID";

          ///<summary>
          /// 有效
          ///</summary>
          [NonSerialized]
          public static string FieldEnabled = "ENABLED";

          ///<summary>
          /// 描述
          ///</summary>
          [NonSerialized]
          public static string FieldDescription = "DESCRIPTION";

          ///<summary>
          /// 删除标记
          ///</summary>
          [NonSerialized]
          public static string FieldDeleteMark = "DELETEMARK";

          ///<summary>
          /// 创建日期
          ///</summary>
          [NonSerialized]
          public static string FieldCreateOn = "CREATEON";

          ///<summary>
          /// 创建用户主键
          ///</summary>
          [NonSerialized]
          public static string FieldCreateUserId = "CREATEUSERID";

          ///<summary>
          /// 创建用户
          ///</summary>
          [NonSerialized]
          public static string FieldCreateBy = "CREATEBY";

          ///<summary>
          /// 修改日期
          ///</summary>
          [NonSerialized]
          public static string FieldModifiedOn = "MODIFIEDON";

          ///<summary>
          /// 修改用户主键
          ///</summary>
          [NonSerialized]
          public static string FieldModifiedUserId = "MODIFIEDUSERID";

          ///<summary>
          /// 修改用户
          ///</summary>
          [NonSerialized]
          public static string FieldModifiedBy = "MODIFIEDBY";
      }
}
