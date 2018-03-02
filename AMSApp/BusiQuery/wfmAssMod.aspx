<%@ Page language="c#" Codebehind="wfmAssMod.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.BusiQuery.wfmAssMod" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>wfmAssMod</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link rel="stylesheet" href="../css/window.css">
  </HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server" bgcolor="#feeff8">
			<TABLE id="Table2" border="0" cellSpacing="1" cellPadding="5" width="700" align="center">
				<TR>
					<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">会员资料修改</TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" border="0" cellSpacing="10" cellPadding="5" width="700" align="center">
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right">会员卡号</TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtCardID" runat="server" Height="24px" Width="135px" Font-Size="10pt" ReadOnly="True"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"></TD>
					<TD style="WIDTH: 79px; FONT-SIZE: 10pt" align="right"></TD>
					<TD>
						<asp:TextBox id="txtAssID" runat="server" Height="24px" Width="136px" Font-Size="10pt" Visible="False"
							ReadOnly="True"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right"><FONT face="宋体">会员姓名</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox style="Z-INDEX: 0" id="txtAssName" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"><FONT face="宋体"></FONT></TD>
					<TD style="WIDTH: 79px; FONT-SIZE: 10pt" align="right">拼音简写</TD>
					<TD>
						<asp:TextBox style="Z-INDEX: 0" id="txtSpell" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right"><FONT face="宋体">身份证号</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox style="Z-INDEX: 0" id="txtAssNbr" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"><FONT face="宋体"></FONT></TD>
					<TD style="WIDTH: 79px; FONT-SIZE: 10pt" align="right">会员类型</TD>
					<TD>
						<asp:TextBox style="Z-INDEX: 0" id="txtAssType" runat="server" Height="24px" Width="135px" Font-Size="10pt"
							ReadOnly="True"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right"><FONT face="宋体">联系电话</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox style="Z-INDEX: 0" id="txtLinkPhone" runat="server" Height="24px" Width="135px"
							Font-Size="10pt"></asp:TextBox></TD>
					<TD style="WIDTH: 40px"><FONT face="宋体"></FONT></TD>
					<TD style="WIDTH: 79px; FONT-SIZE: 10pt" align="right">E-Mail</TD>
					<TD>
						<asp:TextBox style="Z-INDEX: 0" id="txtEmail" runat="server" Height="24px" Width="135px" Font-Size="10pt"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right"><FONT face="宋体">联系地址</FONT></TD>
					<TD colspan="4">
						<asp:TextBox style="Z-INDEX: 0" id="txtLinkAddress" runat="server" Height="56px" Width="450px"
							Font-Size="10pt" TextMode="MultiLine"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px; FONT-SIZE: 10pt" align="right">备&nbsp; 注</TD>
					<TD colspan="4">
						<asp:TextBox style="Z-INDEX: 0" id="txtComments" runat="server" Height="56px" Width="450px" Font-Size="10pt"
							TextMode="MultiLine"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px" align="center"></TD>
					<TD style="WIDTH: 136px" align="center">
						<asp:Button id="btMod" runat="server" Width="64px" Font-Size="10pt" Text="保存"></asp:Button></TD>
					<TD style="WIDTH: 40px"></TD>
					<TD style="WIDTH: 79px" align="center"><INPUT type="button" style="CURSOR:hand" value="返  回" onClick="javascript:window.history.back();"></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
