<%@ Page language="c#" Codebehind="wfmFalseHistory.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.wfmFalseHistory" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>错误</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="../css/window.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body class="background_group" MS_POSITIONING="GridLayout">
		<form id="Success" method="post" runat="server">
			<table style="WIDTH: 426px; HEIGHT: 500px" height="500" align="center">
				<tr>
					<td>
						<TABLE class="table_title_group" cellSpacing="1" cellPadding="3" width="100%" align="center"
							border="0">
							<TR>
								<TD align="left"><FONT face="宋体" size="Medium">错误提示：</FONT></TD>
							</TR>
						</TABLE>
						<TABLE class="table_content_group" style="HEIGHT: 53px" cellSpacing="0" cellPadding="3"
							width="100%" align="center" border="1">
							<TR>
								<TD align="left" width="10%"><FONT face="宋体">&nbsp;
										<asp:Image id="Image1" runat="server" ImageUrl="image/fail.gif"></asp:Image></FONT></TD>
								<TD align="center" width="90%"><asp:label id="lbMessage" runat="server" ForeColor="Red" Font-Size="Medium"></asp:label></TD>
							</TR>
						</TABLE>
						<TABLE style="HEIGHT: 110px" cellSpacing="1" cellPadding="3" width="100%" align="center"
							border="0">
							<TR>
								<TD align="center">
									<INPUT type="button" style="CURSOR:hand" value="返  回" onClick="javascript:window.history.back();"></TD>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
