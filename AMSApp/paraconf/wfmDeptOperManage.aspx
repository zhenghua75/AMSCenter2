<%@ Page language="c#" Codebehind="wfmDeptOperManage.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmDeptOperManage" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmDeptOperManage</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="../css/window.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="<%=strExcelPath%>">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">客户端操作员管理</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 42px" align="right">
									<asp:label id="Label1" runat="server" Width="88px" Font-Size="10pt">操作员名称</asp:label></TD>
								<TD style="WIDTH: 127px">
									<asp:textbox id="txtOperName" runat="server" Width="112px" Font-Size="10pt" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 53px" align="right">
									<asp:label id="Label2" runat="server" Width="56px" Font-Size="10pt">部门</asp:label></TD>
								<TD style="WIDTH: 118px"><FONT face="宋体">
										<asp:dropdownlist id="ddlDept" runat="server" Width="168px" Font-Size="10pt" AutoPostBack="True"></asp:dropdownlist></FONT></TD>
								<TD style="WIDTH: 142px"></TD>
								<TD>
									<asp:button id="btnQuery" runat="server" Width="64px" Text="查询"></asp:button></TD>
								<TD>
									<asp:button id="btnAdd" runat="server" Width="64px" Text="添加"></asp:button></TD>
								<TD>
									<asp:button id="btnExcel" runat="server" Width="64px" Text="导出"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="95%" border="0">
				<TR>
					<TD align="center">
						<uc1:ucpageview id="UcPageView1" runat="server" Visible="true"></uc1:ucpageview>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
