<%@ Page language="c#" Codebehind="wfmAssInfo.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.BusiQuery.wfmAssInfo" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>wfmAssInfo</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT language="javascript" src="../js/calendar.js"></SCRIPT>
</HEAD>
	<body MS_POSITIONING="GridLayout" bgcolor="#feeff8" onload="<%=strExcelPath%>">
		<FONT face="宋体">
			<FORM id="Form1" method="post" runat="server">
				<TABLE id="Table1" cellSpacing="1" cellPadding="5" width="95%" border="0">
					<TR>
						<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">会员信息查询</TD>
					</TR>
				</TABLE>
				<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="95%" border="1">
					<TR>
						<TD>
							<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 146px" align="right"><FONT face="宋体">
											<asp:label id="Label2" runat="server" Font-Size="10pt">会员卡号</asp:label></FONT></TD>
									<TD style="WIDTH: 151px">
										<asp:textbox id="txtCardID" runat="server" Font-Size="10pt" Width="142px"></asp:textbox></TD>
									<TD style="WIDTH: 114px" align="right">
										<asp:label id="Label1" runat="server" Font-Size="10pt">会员类型</asp:label></TD>
									<TD style="WIDTH: 156px">
										<asp:dropdownlist id="ddlAssType" runat="server" Font-Size="10pt" Height="24px" Width="144px"></asp:dropdownlist></TD>
									<TD style="WIDTH: 81px" align="right">
										<asp:label id="Label6" runat="server" Font-Size="10pt">门店</asp:label></TD>
									<TD style="WIDTH: 259px">
										<asp:dropdownlist id="ddlDept" runat="server" Font-Size="10pt" Width="144px" AutoPostBack="True"></asp:dropdownlist></TD>
									<TD>
										<asp:button id="btQuery" runat="server" Font-Size="10pt" Width="56px" Text="查询"></asp:button></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 146px" align="right">
										<asp:label id="Label3" runat="server" Font-Size="10pt">会员姓名</asp:label></TD>
									<TD style="WIDTH: 151px">
										<asp:textbox id="txtAssName" runat="server" Font-Size="10pt" Width="142px"></asp:textbox></TD>
									<TD style="WIDTH: 114px" align="right">
										<asp:label id="Label4" runat="server" Font-Size="10pt">会员状态</asp:label></TD>
									<TD style="WIDTH: 156px">
										<asp:dropdownlist id="ddlAssState" runat="server" Font-Size="10pt" Height="24px" Width="144px"></asp:dropdownlist></TD>
									<TD style="WIDTH: 81px" align="right"></TD>
									<TD style="WIDTH: 259px"></TD>
									<TD>
										<asp:button id="btnExcel" runat="server" Font-Size="10pt" Width="56px" Text="导出"></asp:button></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 146px" align="right"><asp:label id="Label5" runat="server" Font-Size="10pt">开始时间(创建)</asp:label></TD>
									<TD style="WIDTH: 134px"><INPUT 
            style="WIDTH: 136px; HEIGHT: 21px" id=txtBegin 
            onfocus=HS_setDate(this) value="<%=strBeginDate%>" readOnly size=17 
            name=txtBegin></TD>
									<TD style="WIDTH: 114px" align="right"><asp:label id="Label7" runat="server" Font-Size="10pt">结束时间(创建)</asp:label></TD>
									<TD style="WIDTH: 156px"><INPUT 
            style="WIDTH: 136px; HEIGHT: 21px" id=txtEnd 
            onfocus=HS_setDate(this) value="<%=strEndDate%>" readOnly size=17 
            name=txtEnd></TD>
									<TD style="WIDTH: 81px" align="right"></TD>
									<TD style="WIDTH: 259px"></TD>
									<TD></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table4" cellSpacing="1" cellPadding="1" border="0">
					<TR>
						<TD align="center">
							<uc1:ucpageview id="UcPageView1" runat="server" Visible="true"></uc1:ucpageview></TD>
					</TR>
				</TABLE>
			</FORM>
		</FONT>
	</body>
</HTML>
