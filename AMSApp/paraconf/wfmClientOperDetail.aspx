<%@ Page language="c#" Codebehind="wfmClientOperDetail.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmClientOperDetail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmClientOperDetail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="../css/window.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server" bgcolor="#feeff8">
			<TABLE id="Table2" cellSpacing="1" cellPadding="5" width="65%" align="center" border="0">
				<TR>
					<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">
						<asp:Label id="lbltitle" runat="server" Height="24px" Width="380px"></asp:Label></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" cellSpacing="10" cellPadding="5" width="65%" align="center" border="0">
				<TR>
					<TD style="WIDTH: 152px; FONT-SIZE: 10pt" align="right">�ͻ��˲���Ա���</TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtOperID" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"></TD>
					<TD style="WIDTH: 150px; FONT-SIZE: 10pt" align="right">�ͻ��˲���Ա����</TD>
					<TD>
						<asp:TextBox id="txtOperName" runat="server" Height="24px" Width="136px" Font-Size="10pt"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 152px; FONT-SIZE: 10pt" align="right"><FONT face="����">Ȩ��</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:DropDownList id="ddlLimit" runat="server" Width="136px" Font-Size="10pt"></asp:DropDownList></TD>
					<TD style="WIDTH: 40px"><FONT face="����"></FONT></TD>
					<TD style="WIDTH: 150px; FONT-SIZE: 10pt" align="right">�ŵ�</TD>
					<TD>
						<asp:DropDownList id="ddlDept" runat="server" Width="136px" Font-Size="10pt"></asp:DropDownList></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 152px" align="center">
						<asp:Button id="btAdd" runat="server" Width="64px" Font-Size="10pt" Text="���"></asp:Button></TD>
					<TD style="WIDTH: 136px" align="center">
						<asp:Button id="btMod" runat="server" Width="64px" Font-Size="10pt" Text="����"></asp:Button></TD>
					<TD style="WIDTH: 40px">
						<asp:Button id="btnFreeze" runat="server" Width="64px" Font-Size="10pt" Text="����"></asp:Button></TD>
					<TD style="WIDTH: 150px" align="center">
						<asp:Button id="btPwdBegin" runat="server" Width="82px" Font-Size="10pt" Text="�����ʼ��"></asp:Button></TD>
					<TD align="center">
						<asp:Button id="btcancel" runat="server" Width="63px" Font-Size="10pt" Text="����"></asp:Button></TD>
				</TR>
				<tr>
					<td colspan="5" style="COLOR: #cc0000; FONT-SIZE: 10pt">1�������ͻ��˲���Աʱ������Ĭ��Ϊ��000000</td>
				</tr>
				<tr>
					<td colspan="5" style="COLOR: #cc0000; FONT-SIZE: 10pt">2�������ʼ������ѿͻ��˲���Ա��¼�������ʼ��Ϊ��000000</td>
				</tr>
			</TABLE>
		</FORM>
	</body>
</HTML>
