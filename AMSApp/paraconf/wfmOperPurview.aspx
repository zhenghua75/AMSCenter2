<%@ Page language="c#" Codebehind="wfmOperPurview.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmOperPurview" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmOperPurview</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="../css/window.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">操作员权限管理</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" height="30" border="0"
							bgcolor="#99cccc">
							<TR>
								<td></td>
								<TD style="WIDTH: 42px" align="right">
									<asp:label id="Label1" runat="server" Width="88px" Font-Size="10pt">操作员名称：</asp:label></TD>
								<TD style="WIDTH: 191px">
									<asp:label id="lblOperName" runat="server" Font-Size="10pt" Width="240px"></asp:label></TD>
								<TD style="WIDTH: 53px" align="right">
									<asp:label id="Label2" runat="server" Width="56px" Font-Size="10pt">登录ID：</asp:label></TD>
								<TD style="WIDTH: 118px"><FONT face="宋体">
										<asp:label id="lblOperID" runat="server" Font-Size="10pt" Width="123px"></asp:label></FONT></TD>
								<td>
									<asp:TextBox id="txtCS" runat="server" Visible="False"></asp:TextBox></td>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="95%" border="0">
				<TR>
					<TD align="center">
						<TABLE id="Table1" width="100%" cellSpacing="1" cellPadding="0" border="1" bordercolor="#ffffff">
							<TR>
								<TD width="20%"></TD>
								<TD width="40%" style="FONT-SIZE: 10pt">功能列表</TD>
								<TD width="20%"></TD>
								<TD width="20%"></TD>
							</TR>
							<TR>
								<TD width="20%"></TD>
								<TD width="40%">
									<asp:CheckBoxList id="cblFunc" runat="server" Font-Size="10pt"></asp:CheckBoxList></TD>
								<TD width="20%" valign="middle" align="center">
									<P>
										<asp:button id="btnok" runat="server" Width="64px" Text="确  定"></asp:button></P>
									<P>
										<INPUT type="button" style="CURSOR:hand" value="返  回" onClick="javascript:window.history.back();"></P>
								</TD>
								<TD width="20%"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
