﻿//--------------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , HuaSi TECH, Ltd. 
//--------------------------------------------------------------------

using System.Data;
using System.ServiceModel;
using System.Collections.Generic;

namespace CRM
{
    using RDIFramework.Utilities;

    /// <summary>
    /// ILinkManService
    /// 客户联系人服务层接口
    /// 
    /// 修改记录
    /// 
    ///	2012-08-15 版本：1.0 Edward 创建文件。
    ///		
    /// 版本：1.0
    ///
    /// <author>
    ///	<name>Edward</name>
    ///	<date>2012-08-15</date>
    /// </author> 
    /// </summary>
    [ServiceContract]
    public interface ILinkManService
    {
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="entity">实体</param>
        /// <param name="statusCode">返回状态</param>
        /// <param name="statusMessage">返回状态信息</param>
        /// <returns>主键</returns>
        [OperationContract]
        string Add(UserInfo userInfo, LinkManEntity entity, out string statusCode, out string statusMessage);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <returns>数据表</returns>
        [OperationContract]
        DataTable GetDataTable(UserInfo userInfo);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="userId">用户主键</param>
        /// <param name="searchValue">查询关键字</param>
        /// <param name="recordCount">返回记录数</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页显示条数</param>
        /// <param name="sortExpression">排序字段</param>
        /// <param name="sortDire">排序方向</param>
        /// <returns>数据表</returns>
        [OperationContract]
        DataTable GetDataTableByPage(UserInfo userInfo, string userId, string searchValue, out int recordCount, int pageIndex, int pageSize, string sortExpression, string sortDire);

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="id">主键</param>
        /// <returns>实体</returns>
        [OperationContract]
        LinkManEntity GetEntity(UserInfo userInfo, string id);

        /// <summary>
        /// 取得指定客户的主联系人
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="customerId">客户主键</param>
        /// <returns>联系人实体</returns>
        [OperationContract]
        LinkManEntity GetMainByCustomerId(UserInfo userInfo, string customerId);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="entity">实体</param>
        /// <param name="statusCode">返回状态码</param>
        /// <param name="statusMessage">返回状态信息</param>
        /// <returns>影响行数</returns>
        [OperationContract]
        int Update(UserInfo userInfo, LinkManEntity entity, out string statusCode, out string statusMessage);

        /// <summary>
        /// 根据主键获取数据
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="ids">主键</param>
        /// <returns>数据表</returns>
        [OperationContract]
        DataTable GetDataTableByIds(UserInfo userInfo, string[] ids);

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="names">字段</param>
        /// <param name="values">值</param>
        /// <returns>数据表</returns>
        [OperationContract]
        DataTable GetDataTableByValues(UserInfo userInfo, List<KeyValuePair<string, object>> parameters);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="id">主键</param>
        /// <returns>数据表</returns>
        [OperationContract]
        int Delete(UserInfo userInfo, string id);

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="ids">主键数组</param>
        /// <returns>影响行数</returns>
        [OperationContract]
        int BatchDelete(UserInfo userInfo, string[] ids);

        /// <summary>
        /// 批量逻辑删除
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="ids">主键数组</param>
        /// <returns>影响行数</returns>
        [OperationContract]
        int SetDeleted(UserInfo userInfo, string[] ids);
    }
}