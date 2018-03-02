<%@ Page language="c#" Codebehind="wfmDeptManage.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmDeptManage" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmDeptManage</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link rel="stylesheet" href="../css/window.css">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">部门参数管理</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 160px" align="right"><asp:label id="Label1" runat="server" Font-Size="10pt" Width="120px">客户端部门名称</asp:label></TD>
								<TD style="WIDTH: 127px"><asp:textbox id="txtClientName" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 186px" align="right"><asp:label id="Label2" runat="server" Font-Size="10pt" Width="104px">客户端部门编号</asp:label></TD>
								<TD style="WIDTH: 142px"><asp:textbox id="txtClientID" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 105px"></TD>
								<TD style="WIDTH: 145px"></TD>
								<TD><asp:button id="btnQuery" runat="server" Width="64px" Text="查询"></asp:button></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 160px" align="right"><asp:label id="Label3" runat="server" Font-Size="10pt" Width="152px">生产库存中的部门名称</asp:label></TD>
								<TD style="WIDTH: 127px"><asp:textbox id="txtNewName" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 186px" align="right"><asp:label id="Label4" runat="server" Font-Size="10pt" Width="149px">生产库存中的部门编号</asp:label></TD>
								<TD style="WIDTH: 142px"><asp:textbox id="txtNewID" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 105px" align="right"><asp:label id="Label5" runat="server" Font-Size="10pt" Width="74px">排序序号</asp:label></TD>
								<TD style="WIDTH: 145px"><asp:textbox id="txtSortNum" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD><asp:button id="btnAdd" runat="server" Width="64px" Text="添加"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="95%" border="0">
				<TR>
					<TD align="center"><asp:datagrid id="DataGrid1" runat="server" Font-Size="X-Small" Width="100%" PagerStyle-HorizontalAlign="Right"
							BorderColor="Black" BorderWidth="1px" CellPadding="3" Font-Name="Verdana" HeaderStyle-BackColor="SteelBlue"
							AlternatingItemStyle-BackColor="#660033" Font-Names="Verdana" AutoGenerateColumns="False">
							<FooterStyle Wrap="False"></FooterStyle>
							<SelectedItemStyle Wrap="False"></SelectedItemStyle>
							<EditItemStyle Wrap="False"></EditItemStyle>
							<AlternatingItemStyle Wrap="False" ForeColor="Black" BackColor="#E6E6E6"></AlternatingItemStyle>
							<ItemStyle Wrap="False" ForeColor="Black" BackColor="White"></ItemStyle>
							<HeaderStyle Font-Size="Small" Font-Bold="True" Wrap="False" ForeColor="White" BackColor="#880028"></HeaderStyle>
							<Columns>
								<asp:BoundColumn DataField="vcCommName" HeaderText="客户端部门名称"></asp:BoundColumn>
								<asp:BoundColumn DataField="vcCommCode" ReadOnly="True" HeaderText="客户端部门编号"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnvcDeptName" HeaderText="生产库存中的部门名称"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnvcDeptID" ReadOnly="True" HeaderText="生产库存中的部门编号"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnnPriority" HeaderText="排序序号"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="PushButton" UpdateText="更新" HeaderText="操作" CancelText="取消" EditText="修改"></asp:EditCommandColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Right" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
