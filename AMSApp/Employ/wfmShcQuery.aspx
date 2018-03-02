<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<%@ Page language="c#" Codebehind="wfmShcQuery.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.Employ.wfmShcQuery" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmShcQuery</title>
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
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">员工每日排班表</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" align="center" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 224px" align="right"></TD>
								<TD style="WIDTH: 174px" align="right">
									<asp:label id="Label4" runat="server" Font-Size="10pt" Width="75px">排班日期</asp:label></TD>
								<TD style="WIDTH: 264px"><FONT face="宋体"><INPUT id=txtSchDate style="WIDTH: 136px; HEIGHT: 22px" onfocus=HS_setDate(this) readOnly type=text size=17 value="<%=strSchDate%>" name=txtSchDate></FONT></TD>
								<TD style="WIDTH: 158px">
									<asp:button id="btquery" runat="server" Width="65px" Text="查询"></asp:button></TD>
								<TD style="WIDTH: 137px"></TD>
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
