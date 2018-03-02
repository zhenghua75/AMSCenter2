<%@ Page language="c#" CodeBehind="wfmGoodsDetail.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmGoodsDetail" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmGoodsDetail</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	    <style type="text/css">
            #Table1
            {
                width: 67%;
            }
        </style>
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgcolor="#feeff8">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table2" align="center" cellSpacing="1" cellPadding="5" width="60%" border="0">
				<TR>
					<TD align="center" style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033">
						<asp:Label id="lbltitle" runat="server" Height="24px" Width="380px">Label</asp:Label></TD>
				</TR>
			</TABLE>
			<TABLE id="Table1" align="center" cellSpacing="10" cellPadding="5" border="0">
				<TR>
					<TD style="FONT-SIZE: 10pt; WIDTH: 90px" align="right">
						<asp:Label id="lbGoodsID" runat="server">商品ID</asp:Label>
						<asp:Label id="lbGoodsType" runat="server">商品类型</asp:Label></TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtGoodsID" runat="server" Font-Size="10pt" Width="135px" Height="24px"></asp:TextBox>
						<asp:DropDownList ID="ddlGoodsTypeSum" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlGoodsTypeSum_SelectedIndexChanged" Width="200px">
                        </asp:DropDownList>
						<asp:dropdownlist id="ddlGoodsType" runat="server"  Width="200px" 
                            Font-Size="10pt" AutoPostBack="True" 
                            onselectedindexchanged="ddlGoodsType_SelectedIndexChanged"></asp:dropdownlist></TD>
					<td style="WIDTH: 40px"></td>
					<TD style="FONT-SIZE: 10pt;WIDTH: 61px" align="right">商品名称</TD>
					<TD>
						<asp:TextBox id="txtGoodsName" runat="server" Font-Size="10pt" Width="200px" 
                            Height="24px"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt;WIDTH: 90px" align="right"><FONT face="宋体">拼音简写</FONT></TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtSpell" runat="server" Font-Size="10pt" Width="200px" 
                            Height="24px"></asp:TextBox></TD>
					<td style="WIDTH: 40px"><FONT face="宋体"></FONT></td>
					<TD style="FONT-SIZE: 10pt;WIDTH: 61px" align="right">单价</TD>
					<TD>
						<asp:TextBox id="txtPrice" runat="server" Font-Size="10pt" Width="200px" 
                            Height="24px"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt;WIDTH: 90px" align="right">积分兑换分值</TD>
					<TD style="WIDTH: 136px">
						<asp:TextBox id="txtigvalue" runat="server" Font-Size="10pt" Width="200px" 
                            Height="24px">-1</asp:TextBox></TD>
					<td style="WIDTH: 40px"></td>
					<TD style="WIDTH: 61px"><FONT face="宋体"></FONT></TD>
					<TD></TD>
				</TR>
				<TR>
					<TD style="FONT-SIZE: 10pt;WIDTH: 90px;HEIGHT: 78px" align="right">备注</TD>
					<TD colspan="4" style="HEIGHT: 78px">
						<asp:TextBox id="txtComments" runat="server" Font-Size="10pt" Width="443px" Height="88px" TextMode="MultiLine"></asp:TextBox></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 90px" align="center">
						<asp:Button id="btAdd" runat="server" Font-Size="10pt" Width="64px" Text="添加"></asp:Button></TD>
					<TD style="WIDTH: 136px" align="center">
						<asp:Button id="btMod" runat="server" Width="64px" Font-Size="10pt" Text="保存"></asp:Button></TD>
					<td style="WIDTH: 40px"></td>
					<TD style="WIDTH: 61px" align="center">
						<asp:Button id="btDel" runat="server" Width="64px" Font-Size="10pt" Text="删除"></asp:Button></TD>
					<TD align="center">
						<asp:Button id="btcancel" runat="server" Font-Size="10pt" Width="89px" Text="返回商品管理"></asp:Button></TD>
				</TR>
				<tr>
					<td colspan="5" align="center">
						<asp:Label id="lblPromt" runat="server" Width="512px" ForeColor="Red"></asp:Label></td>
				</tr>
			</TABLE>
		</form>
	</body>
</HTML>
