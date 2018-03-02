<%@ Page language="c#" Codebehind="wfmLoginPwd.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmLoginPwd" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmLoginPwd</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgcolor="#feeff8">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="60%" align="center" border="0"
				height="40">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">
						<asp:Label id="lbltitle" runat="server" Height="24px" Width="380px">操作员密码修改</asp:Label></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="561" align="center" border="1"
				style="WIDTH: 561px; HEIGHT: 168px">
				<TR>
					<TD width="40%" align="center" style="FONT-SIZE: 10pt">登录ID</TD>
					<TD width="60%">
						<asp:TextBox id="txtLoginID" runat="server" Height="24px" Width="184px" Font-Size="10pt"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD width="40%" align="center" style="FONT-SIZE: 10pt">新密码</TD>
					<TD width="60%">
						<asp:TextBox id="txtNewPwd" runat="server" Height="24px" Width="184px" Font-Size="10pt" TextMode="Password"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD width="40%" align="center" style="FONT-SIZE: 10pt">新密码确认</TD>
					<TD width="60%" align="left">
						<asp:TextBox id="txtNewPwdConf" runat="server" Height="24px" Width="184px" Font-Size="10pt" TextMode="Password"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD width="40%" align="center">
						<asp:Button id="btMod" runat="server" Width="64px" Font-Size="10pt" Text="保存"></asp:Button></TD>
					<TD width="60%" align="center">
						<asp:Button id="btClose" runat="server" Width="64px" Font-Size="10pt" Text="关闭"></asp:Button></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
