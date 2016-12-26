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
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.ServiceModel;

namespace RDIFramework.BizLogic
{
	using RDIFramework.Utilities;
	
    public partial class QueryEngineService
    {
        #region public string AddQueryEngineDefine(UserInfo userInfo, QueryEngineDefineEntity entity, out string statusCode, out string statusMessage) 新增查询引擎定义
        /// <summary>
		/// 新增查询引擎定义
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="entity">查询引擎定义实体</param>
		/// <param name="statusCode">返回状态码</param>
		/// <param name="statusMessage">返回状态消息</param>
		/// <returns>主鍵</returns>
        public string AddQueryEngineDefine(UserInfo userInfo, QueryEngineDefineEntity entity, out string statusCode, out string statusMessage)
		{
            var returnValue = string.Empty;
            string returnCode = string.Empty;
            string returnMessage = string.Empty;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_Add);

            ServiceUtil.ProcessRDIWriteDb(userInfo, parameter, dbProvider =>
            {
                var manager = new QueryEngineDefineManager(dbProvider, userInfo);
                returnValue = manager.Add(entity, out returnCode);
                returnMessage = manager.GetStateMessage(returnCode);
            });
            statusCode = returnCode;
            statusMessage = returnMessage;
            return returnValue;
		}
		#endregion

        #region public int UpdateQueryEngineDefine(UserInfo userInfo, QueryEngineDefineEntity entity, out string statusCode, out string statusMessage) 更新查询引擎定义
        /// <summary>
		/// 更新查询引擎定义
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="entity">查询引擎定义实体</param>
		/// <param name="statusCode">返回状态码</param>
		/// <param name="statusMessage">返回状态信息</param>
		/// <returns>影响行数</returns>
        public int UpdateQueryEngineDefine(UserInfo userInfo, QueryEngineDefineEntity entity, out string statusCode, out string statusMessage)
		{
            int returnValue = 0;
            string returnCode = string.Empty;
            string returnMessage = string.Empty;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_Update);

            ServiceUtil.ProcessRDIWriteDb(userInfo, parameter, dbProvider =>
            {
                var manager = new QueryEngineDefineManager(dbProvider, userInfo);
                returnValue = manager.UpdateEntity(entity, out returnCode);
                returnMessage = manager.GetStateMessage(returnCode);
            });
            statusCode = returnCode;
            statusMessage = returnMessage;
            return returnValue;
		}
		#endregion

        #region public DataTable GetQueryEngineDefineDT(UserInfo userInfo) 获取查询引擎定义列表
        /// <summary>
		/// 获取查询引擎定义列表
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <returns>数据表</returns>
        public DataTable GetQueryEngineDefineDT(UserInfo userInfo)
		{
            var dataTable = new DataTable(QueryEngineDefineTable.TableName);
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_GetDT);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                dataTable = new QueryEngineDefineManager(dbProvider, userInfo).GetDT(QueryEngineDefineTable.FieldDeleteMark, 0, QueryEngineDefineTable.FieldSortCode);
                dataTable.TableName = QueryEngineDefineTable.TableName;
            });
            return dataTable;
		}
		#endregion

        #region public DataTable GetQueryEngineDefineDTByEngineId(UserInfo userInfo,queryEngineId) 根据查询引擎主键获取查询引擎定义列表
        /// <summary>
        /// 根据查询引擎主键获取查询引擎定义列表
        /// </summary>
        /// <param name="userInfo">用户</param>
        /// <param name="queryEngineId">查询引擎主键</param>
        /// <returns>数据表</returns>
        public DataTable GetQueryEngineDefineDTByEngineId(UserInfo userInfo,string queryEngineId)
        {
            var dataTable = new DataTable(QueryEngineDefineTable.TableName);
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_GetDT);
            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                List<KeyValuePair<string, object>> tempParameter = new List<KeyValuePair<string, object>>();
                tempParameter.Add(new KeyValuePair<string, object>(QueryEngineDefineTable.FieldQueryEngineId, queryEngineId));
                tempParameter.Add(new KeyValuePair<string, object>(QueryEngineDefineTable.FieldDeleteMark, 0));
                dataTable = new QueryEngineDefineManager(dbProvider, userInfo).GetDT(tempParameter, QueryEngineDefineTable.FieldSortCode);
                dataTable.TableName = QueryEngineDefineTable.TableName;
            });
            return dataTable;
        }
        #endregion

        #region public DataTable GetQueryEngineDefineDTByPage(UserInfo userInfo, string searchValue, out int recordCount, int pageIndex = 1, int pageSize = 20, string sortExpression = null) 分页获取查询引擎定义列表
        /// <summary>
		/// 分页获取查询引擎定义列表
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="searchValue">查询关键字</param>
		/// <param name="recordCount">记录数</param>
		/// <param name="pageIndex">当前页</param>
		/// <param name="pageSize">每页显示记录条数</param>
		/// <param name="sortExpression">排序字段</param>
		/// <returns>数据表</returns>
        public DataTable GetQueryEngineDefineDTByPage(UserInfo userInfo, string searchValue, out int recordCount, int pageIndex = 1, int pageSize = 20, string sortExpression = null)
		{
            var dataTable = new DataTable(QueryEngineDefineTable.TableName);
            var returnRecordCount = 0;
            var parameter = ParameterUtil.CreateWithOutMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                var manager = new QueryEngineDefineManager(dbProvider, userInfo);
                if (string.IsNullOrEmpty(searchValue))
                {
                    searchValue = QueryEngineDefineTable.FieldDeleteMark + " = 0 ";
                }
                else
                {
                    searchValue += " AND " + QueryEngineDefineTable.FieldDeleteMark + " = 0 ";
                }

                dataTable = manager.GetDTByPage(out returnRecordCount, pageIndex, pageSize, searchValue, sortExpression);
                dataTable.TableName = QueryEngineDefineTable.TableName;

                // 这里是获数据库连接名称中文显示
                CiDbLinkDefineManager dbLinkManager = new CiDbLinkDefineManager(dbProvider, userInfo);
                if (!dataTable.Columns.Contains("LINKNAME_CHS"))
                {
                    dataTable.Columns.Add("LINKNAME_CHS");
                }

                foreach (DataRow dr in dataTable.Rows)
                {
                    string dbLinkId = BusinessLogic.ConvertToString(dr[QueryEngineDefineTable.FieldDataBaseLinkName]);
                    if (!string.IsNullOrEmpty(dbLinkId))
                    {
                        dr["LINKNAME_CHS"] = dbLinkManager.GetEntity(dbLinkId).LinkName;
                    }
                }
                dataTable.AcceptChanges();
            });
            recordCount = returnRecordCount;
            return dataTable;
		}
		#endregion

        #region public GetQueryEngineDefineEntity GetEntity(UserInfo userInfo, string id) 获取查询引擎定义实体
        /// <summary>
		/// 得到查询引擎定义实体
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="id">主鍵</param>
		/// <returns>实体</returns>
        public QueryEngineDefineEntity GetQueryEngineDefineEntity(UserInfo userInfo, string id)
		{
            QueryEngineDefineEntity entity = null;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_GetEntity);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                entity = new QueryEngineDefineManager(dbProvider, userInfo).GetEntity(id);
            });
            return entity;
		}
		#endregion

        #region public DataTable GetQueryEngineDefineDTByIds(UserInfo userInfo, string[] ids) 根据主键数组获取数据
        /// <summary>
		/// 根据主键数组获取数据
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="ids">主鍵</param>
		/// <returns>数据表</returns>
        public DataTable GetQueryEngineDefineDTByIds(UserInfo userInfo, string[] ids)
		{
            var dataTable = new DataTable(QueryEngineDefineTable.TableName);
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_GetDTByIds);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                dataTable = new QueryEngineDefineManager(dbProvider, userInfo).GetDT(QueryEngineDefineTable.FieldId, ids, QueryEngineDefineTable.FieldSortCode);
                dataTable.TableName = QueryEngineDefineTable.TableName;
            });
            return dataTable;
		}
		#endregion

        #region public DataTable GetQueryEngineDefineDTByValues(UserInfo userInfo, List<KeyValuePair<string, object>> parameters) 根据条件获取数据
        /// <summary>
		/// 根据条件获取数据
		/// </summary>
		/// <param name="userInfo">用户</param>
        /// <param name="parameters">参数</param>
		/// <returns>数据表</returns>
        public DataTable GetQueryEngineDefineDTByValues(UserInfo userInfo, List<KeyValuePair<string, object>> parameters)
		{
            var dataTable = new DataTable(QueryEngineDefineTable.TableName);
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_GetDTByValues);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                dataTable = new QueryEngineDefineManager(dbProvider, userInfo).GetDT(parameters);
                dataTable.TableName = QueryEngineDefineTable.TableName;
            });
            return dataTable;
		}
		#endregion
		
        #region public int DeleteQueryEngineDefine(UserInfo userInfo, string id) 删除指定数据
        /// <summary>
		/// 删除指定数据
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="id">主鍵</param>
		/// <returns>数据表</returns>
        public int DeleteQueryEngineDefine(UserInfo userInfo, string id)
		{
            var returnValue = 0;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_Delete, "主键：" + id);

            ServiceUtil.ProcessRDIReadDb(userInfo, parameter, dbProvider =>
            {
                returnValue = new QueryEngineDefineManager(dbProvider, userInfo).Delete(id);
            });

            return returnValue;
		}
		#endregion

        #region public int BatchDeleteQueryEngineDefine(UserInfo userInfo, string[] ids) 批量删除数据
        /// <summary>
		/// 批量删除数据
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="ids">主键数组</param>
		/// <returns>影响行数</returns>
        public int BatchDeleteQueryEngineDefine(UserInfo userInfo, string[] ids)
		{
            var returnValue = 0;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_BatchDelete);

            ServiceUtil.ProcessRDIWriteDbWithTran(userInfo, parameter, dbProvider =>
            {
                returnValue = new QueryEngineDefineManager(dbProvider, userInfo).BatchDelete(ids);
            });
            return returnValue;
		}
		#endregion

        #region public int SetDeletedQueryEngineDefine(UserInfo userInfo, string[] ids) 批量设置删除标志
        /// <summary>
		/// 批量设置删除标志
		/// </summary>
		/// <param name="userInfo">用户</param>
		/// <param name="ids">主键数组</param>
		/// <returns>影响行数</returns>
        public int SetDeletedQueryEngineDefine(UserInfo userInfo, string[] ids)
		{
            var returnValue = 0;
            var parameter = ParameterUtil.CreateWithMessage(userInfo, MethodBase.GetCurrentMethod(), this.serviceName, RDIFrameworkMessage.QueryEnginService_SetDeleted);

            ServiceUtil.ProcessRDIWriteDbWithTran(userInfo, parameter, dbProvider =>
            {
                returnValue = new QueryEngineDefineManager(dbProvider, userInfo).SetDeleted(ids);
            });

            return returnValue;
		}
		#endregion
	}
}
