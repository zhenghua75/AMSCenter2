<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<%@ Page language="c#" Codebehind="wfmWorkDailyEvery.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.Employ.wfmWorkDailyEvery" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmWorkDailyEvery</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT language="javascript" src="../js/calendar.js"></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgcolor="#feeff8">
		<FORM id="Form1" method="post" runat="server" bgcolor="#feeff8">
			<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" align="center" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">员工日工作安排计划</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" align="center" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 70px" align="right">
									<asp:label id="Label1" runat="server" Width="60px" Font-Size="10pt">门店</asp:label></TD>
								<TD style="WIDTH: 124px">
									<asp:dropdownlist id="ddlDept" runat="server" Width="144px" Font-Size="10pt" Height="24px"></asp:dropdownlist></TD>
								<TD style="WIDTH: 143px" align="right">
									<asp:label id="Label4" runat="server" Width="82px" Font-Size="10pt">要排班的日期</asp:label></TD>
								<TD style="WIDTH: 227px" align="left"><INPUT id=txtSchDate onfocus=HS_setDate(this) readOnly type=text size=17 value="<%=strSchDate%>" name=txtSchDate></TD>
								<TD style="WIDTH: 103px"><FONT face="宋体">
										<asp:button id="btquery" runat="server" Width="65px" Text="查询"></asp:button></FONT></TD>
								<TD style="WIDTH: 109px">
									<asp:button id="btnadd" runat="server" Width="65px" Text="添加"></asp:button></TD>
								<TD style="WIDTH: 137px">
									<asp:button id="btnExport" runat="server" Width="65px" Text="导入"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="95%" border="0" align="center">
				<TR>
					<TD align="center"><uc1:ucpageview id="UcPageView1" runat="server" Visible="true"></uc1:ucpageview></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
