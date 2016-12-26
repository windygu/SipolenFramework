﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ToDoTask.aspx.cs" Inherits="RDIFramework.WebApp.WorkFlow.ToDoTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="../Content/Scripts/My97DatePicker/WdatePicker.js"></script>
    
    <div class="searchArea">
        流程实例名称：<input type="text" name="wfInsFullName" id="txtWFInsFullName" class="txt03" style="width: 150px;"/>&nbsp;
        任务时间：<input id="txtFromStartDate" class="Wdate" type="text" onFocus="WdatePicker({lang:'zh-cn'})"/> 
        至 <input id="txtToStartDate" class="Wdate" type="text" onFocus="WdatePicker({lang:'zh-cn'})"/>&nbsp;
        <a id="btnSearch" href="javascript:;" plain="true" class="easyui-linkbutton" icon="icon16_filter" title="查询">搜索</a>                   
    </div>  
    <div id="toolbar">
        <a id="btnRefresh" class="easyui-linkbutton" style="float:left"  plain="true" href="javascript:;" icon="icon16_arrow_refresh"  title="重新加载">刷新</a> 
        <div class='datagrid-btn-separator'></div>
        <a id="btnHandleTask" plain="true" class="easyui-linkbutton" icon="icon16_door" title="处理任务">处理任务</a>          
        <a id="btnGiveupClaim" plain="true" class="easyui-linkbutton" icon="icon16_dish" title="放弃认领">放弃认领</a>          
        <a id="btnViewWfChart" plain="true" class="easyui-linkbutton" icon="icon16_flow" title="查看流程图">查看流程图</a>
        <a id="btnProcessStep" plain="true" class="easyui-linkbutton" icon="icon16_page_white_text" title="处理记录">处理记录</a>
        <a id="btnPrint" plain="true" class="easyui-linkbutton" icon="icon16_printer" title="打印">打印</a>
    </div>
    <!--用于数据显示-->   
    <!--startprint--> 
    <table id="list"></table>    
    <!--endprint-->
    <script type="text/javascript" src="js/ToDoTask.js?v=30"></script>
</asp:Content>
