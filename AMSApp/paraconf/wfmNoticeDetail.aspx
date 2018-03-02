<%@ Page language="c#" Codebehind="wfmNoticeDetail.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmNoticeDetail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmNoticeDetail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server" bgcolor="#feeff8">
			<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">系统通知添加</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="0">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 101px" align="right">
									<asp:label id="Label2" runat="server" Width="56px" Font-Size="10pt">发往门店</asp:label></TD>
								<TD style="WIDTH: 538px">
									<asp:dropdownlist id="ddlDept" runat="server" Width="248px" Font-Size="10pt" AutoPostBack="True"></asp:dropdownlist></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 101px; HEIGHT: 261px" align="right">
									<asp:label id="Label1" runat="server" Width="88px" Font-Size="10pt">通知内容</asp:label></TD>
								<TD style="WIDTH: 127px; HEIGHT: 261px">
									<asp:textbox id="txtContent" runat="server" Width="745px" Font-Size="12pt" Height="208px" TextMode="MultiLine"></asp:textbox></TD>
							</TR>
							<TR>
								<td></td>
								<TD align="center">
									<asp:button id="btAdd" runat="server" Width="64px" Text="添加"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:button id="btcancel" runat="server" Width="101px" Text="返回通知管理"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
