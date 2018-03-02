<%@ Page language="c#" Codebehind="wfmOperDetail.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmOperDetail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmOperDetail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="../css/window.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server" bgcolor="#feeff8">
			<TABLE id="Table2" cellSpacing="1" cellPadding="5" width="60%" align="center" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">
						<asp:Label id="lbltitle" runat="server" Height="24px" Width="380px"></asp:Label></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" cellSpacing="10" cellPadding="5" width="60%" align="center" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 90px" align="right">登录ID</TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtLoginID" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"></TD>
					<TD style="FONT-SIZE: 10pt; WIDTH: 79px" align="right">操作员名称</TD>
					<TD>
						<asp:TextBox id="txtOperName" runat="server" Height="24px" Width="136px" Font-Size="10pt"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 90px" align="right"><FONT face="宋体">查看权限</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:DropDownList id="ddlLimit" runat="server" Width="136px" Font-Size="10pt"></asp:DropDownList></TD>
					<TD style="WIDTH: 40px"><FONT face="宋体"></FONT></TD>
					<TD style="FONT-SIZE: 10pt; WIDTH: 79px" align="right">门店</TD>
					<TD>
						<asp:DropDownList id="ddlDept" runat="server" Width="136px" Font-Size="10pt"></asp:DropDownList></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px" align="center">
						<asp:Button id="btAdd" runat="server" Font-Size="10pt" Width="64px" Text="添加"></asp:Button></TD>
					<TD style="WIDTH: 136px" align="center">
						<asp:Button id="btMod" runat="server" Width="64px" Font-Size="10pt" Text="保存"></asp:Button></TD>
					<td style="WIDTH: 40px"></td>
					<TD style="WIDTH: 79px" align="center">
						<asp:Button id="btDel" runat="server" Width="64px" Font-Size="10pt" Text="删除"></asp:Button></TD>
					<TD align="center">
						<asp:Button id="btcancel" runat="server" Font-Size="10pt" Width="103px" Text="返回操作员管理"></asp:Button></TD>
				</TR>
				<tr>
					<td colspan="5" style="FONT-SIZE: 10pt; COLOR: #cc0000">新增网站操作员时，密码默认为：123456</td>
				</tr>
			</TABLE>
		</FORM>
	</body>
</HTML>
