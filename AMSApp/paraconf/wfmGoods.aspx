<%@ Page language="c#" Codebehind="wfmGoods.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmGoods" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmGoods</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="<%=strExcelPath%>" bgcolor="#feeff8">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD align="center" style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold">商品管理</TD>
				</TR>
				<TR>
					<TD align="left" style="COLOR: #3300ff; FONT-SIZE: 10pt; FONT-WEIGHT: bold; TEXT-DECORATION: underline"><Font style="COLOR: #ff0000; FONT-SIZE: 10pt; FONT-WEIGHT: bold; TEXT-DECORATION: underline"></Font></TD>
				</TR>
			</TABLE>
			<table cellspacing="0" cellpadding="0" width="95%" border="1">
				<tr>
					<td>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 42px"><asp:label id="Label1" runat="server" Width="40px" Font-Size="10pt">商品ID</asp:label></TD>
								<TD style="WIDTH: 127px"><asp:textbox id="txtGoodsID" runat="server" Width="112px" Font-Size="10pt" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 53px"><asp:label id="Label2" runat="server" Width="56px" Font-Size="10pt">商品名称</asp:label></TD>
								<TD style="WIDTH: 118px"><FONT face="宋体"><asp:textbox id="txtGoodsName" runat="server" Width="112px" Font-Size="10pt" Height="24px"></asp:textbox></FONT></TD>
								<TD style="WIDTH: 53px"><asp:label id="Label3" runat="server" Width="56px" Font-Size="10pt">拼音简码</asp:label></TD>
								<TD style="WIDTH: 118px"><FONT face="宋体"><asp:textbox id="txtSpell" runat="server" Width="112px" Font-Size="10pt" Height="24px"></asp:textbox></FONT></TD>
								<td style="WIDTH: 258px"></td>
								<TD><asp:button id="Button1" runat="server" Width="64px" Text="查询"></asp:button></TD>
								<%--<TD><asp:button id="Button2" runat="server" Width="64px" Text="添加"></asp:button></TD>--%>
								<TD><FONT face="宋体">
										<asp:button id="btnExcel" runat="server" Width="64px" Text="导出"></asp:button></FONT></TD>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="95%" border="0">
				<TR>
					<TD align="center">
						<uc1:ucpageview id="UcPageView1" runat="server" Visible="true"></uc1:ucpageview></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD align="right">
						<asp:CheckBox id="chkCreate" runat="server" Font-Size="10pt" Text="生成商品数据" AutoPostBack="True"
							Visible="False"></asp:CheckBox></TD>
					<TD align="left"><asp:button id="Button3" runat="server" Width="86px" Text="商品数据生成" Visible="False"></asp:button></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
