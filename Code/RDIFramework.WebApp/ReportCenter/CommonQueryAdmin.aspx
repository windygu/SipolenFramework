﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CommonQueryAdmin.aspx.cs" Inherits="RDIFramework.WebApp.ReportCenter.CommonQueryAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="layout">
        <div region="west" iconCls="icon-chart_organisation" split="true" title="查询树" style="width:260px;padding: 5px" collapsible="false">
            <ul id="queryEngineTree"></ul>
        </div>
        <div region="center" style="padding: 2px; overflow: hidden">
            <div style="width:auto;height:250px;padding:3px">
                <div id="p1" class="easyui-panel" title="查询列表" data-options="iconCls:'icon-layout',fit:true">  
                    <div id="toolbar">
                        <%=base.BuildToolBarButtons()%>
                    </div>
                    <table id="commonQueryGrid"></table>
                </div> 
            </div>
            <div style="width:auto;height:205px;padding:2px">
                 <div id="p2" class="easyui-panel" title="查询结果"  style="width:auto;height:auto;padding:2px;" data-options="iconCls:'icon-list',closable:true,collapsible:true,fit:true,maximizable:true,maximized:true">  
                    <table id="detailGrid"></table>
                     <input type="hidden" id="hid_pageNumber"   value="1"/>
                     <input type="hidden" id="hid_pageSize"  value="10" />
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript" src="../Content/Scripts/Linqjs/linq.min.js"></script>
    <script type="text/javascript" src="../Content/Scripts/Linqjs/linq.jquery.js"></script>
    <script type="text/javascript" src="js/CommonQueryAdmin.js?v=30"></script>
</asp:Content>
