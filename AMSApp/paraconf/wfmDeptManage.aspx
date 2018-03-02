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
					<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">���Ų�������</TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="1">
				<TR>
					<TD>
						<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 160px" align="right"><asp:label id="Label1" runat="server" Font-Size="10pt" Width="120px">�ͻ��˲�������</asp:label></TD>
								<TD style="WIDTH: 127px"><asp:textbox id="txtClientName" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 186px" align="right"><asp:label id="Label2" runat="server" Font-Size="10pt" Width="104px">�ͻ��˲��ű��</asp:label></TD>
								<TD style="WIDTH: 142px"><asp:textbox id="txtClientID" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 105px"></TD>
								<TD style="WIDTH: 145px"></TD>
								<TD><asp:button id="btnQuery" runat="server" Width="64px" Text="��ѯ"></asp:button></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 160px" align="right"><asp:label id="Label3" runat="server" Font-Size="10pt" Width="152px">��������еĲ�������</asp:label></TD>
								<TD style="WIDTH: 127px"><asp:textbox id="txtNewName" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 186px" align="right"><asp:label id="Label4" runat="server" Font-Size="10pt" Width="149px">��������еĲ��ű��</asp:label></TD>
								<TD style="WIDTH: 142px"><asp:textbox id="txtNewID" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD style="WIDTH: 105px" align="right"><asp:label id="Label5" runat="server" Font-Size="10pt" Width="74px">�������</asp:label></TD>
								<TD style="WIDTH: 145px"><asp:textbox id="txtSortNum" runat="server" Font-Size="10pt" Width="152px" Height="24px"></asp:textbox></TD>
								<TD><asp:button id="btnAdd" runat="server" Width="64px" Text="���"></asp:button></TD>
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
								<asp:BoundColumn DataField="vcCommName" HeaderText="�ͻ��˲�������"></asp:BoundColumn>
								<asp:BoundColumn DataField="vcCommCode" ReadOnly="True" HeaderText="�ͻ��˲��ű��"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnvcDeptName" HeaderText="��������еĲ�������"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnvcDeptID" ReadOnly="True" HeaderText="��������еĲ��ű��"></asp:BoundColumn>
								<asp:BoundColumn DataField="cnnPriority" HeaderText="�������"></asp:BoundColumn>
								<asp:EditCommandColumn ButtonType="PushButton" UpdateText="����" HeaderText="����" CancelText="ȡ��" EditText="�޸�"></asp:EditCommandColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Right" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
