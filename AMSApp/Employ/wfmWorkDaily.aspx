<%@ Page language="c#" Codebehind="wfmWorkDaily.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.Employ.wfmWorkDaily" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmWorkDaily</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<SCRIPT language="javascript" src="../js/calendar.js"></SCRIPT>
	</HEAD>
	<body bgColor="#feeff8" MS_POSITIONING="GridLayout">
		<FONT face="����">
			<FORM id="Form1" method="post" bgcolor="#feeff8" runat="server">
				<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" align="center" border="0">
					<TR>
						<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">Ա���չ������żƻ�</TD>
					</TR>
				</TABLE>
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" align="center" border="1">
					<TR>
						<TD>
							<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 224px" align="right"><asp:label id="Label1" runat="server" Width="60px" Font-Size="10pt">�ŵ�</asp:label></TD>
									<TD style="WIDTH: 124px"><asp:dropdownlist id="ddlDept" runat="server" Width="144px" Font-Size="10pt" Height="24px"></asp:dropdownlist></TD>
									<TD style="WIDTH: 49px"></TD>
									<TD style="WIDTH: 174px" align="right"><asp:label id="Label2" runat="server" Width="54px" Font-Size="10pt">�곤��</asp:label></TD>
									<TD style="WIDTH: 264px"><FONT face="����"><asp:label id="lblManager" runat="server" Width="289px" Font-Size="10pt"></asp:label></FONT></TD>
									<TD style="WIDTH: 158px"></TD>
									<TD style="WIDTH: 137px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 224px" align="right"><asp:label id="Label5" runat="server" Width="60px" Font-Size="10pt">ְ��</asp:label></TD>
									<TD style="WIDTH: 124px"><asp:dropdownlist id="ddlOfficer" runat="server" Width="144px" Font-Size="10pt" Height="24px" AutoPostBack="True"></asp:dropdownlist></TD>
									<TD style="WIDTH: 49px"></TD>
									<TD style="WIDTH: 174px" align="right"><asp:label id="Label4" runat="server" Width="96px" Font-Size="10pt">Ҫ�Ű������</asp:label></TD>
									<TD style="WIDTH: 264px"><INPUT id=txtSchDate onfocus=HS_setDate(this) readOnly type=text size=17 value="<%=strSchDate%>" name=txtSchDate></TD>
									<TD style="WIDTH: 158px"></TD>
									<TD style="WIDTH: 137px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 224px" align="right"><asp:label id="Label3" runat="server" Width="60px" Font-Size="10pt">���</asp:label></TD>
									<TD style="WIDTH: 124px"><asp:dropdownlist id="ddlClass" runat="server" Width="144px" Font-Size="10pt" Height="24px"></asp:dropdownlist></TD>
									<TD style="WIDTH: 49px"></TD>
									<TD style="WIDTH: 174px" align="right"></TD>
									<TD style="WIDTH: 264px"><FONT face="����"></FONT></TD>
									<TD style="WIDTH: 158px"><asp:button id="btquery" runat="server" Width="65px" Text="��ѯ"></asp:button></TD>
									<TD style="WIDTH: 137px"><asp:button id="btrefresh" runat="server" Width="65px" Text="����ѡ��"></asp:button></TD>
								</TR>
							</TABLE>
						</TD>
					</TR>
				</TABLE>
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="95%" align="center" border="0">
					<TR>
						<TD style="FONT-SIZE: 10pt; WIDTH: 38.2%; HEIGHT: 36px" vAlign="bottom" align="center">����Ա���б�</TD>
						<td style="WIDTH: 10%"></td>
						<TD style="FONT-SIZE: 10pt; WIDTH: 38.83%; HEIGHT: 36px" vAlign="bottom" align="left"><asp:label id="lblSchedTitle" runat="server" Width="254px" Font-Size="10pt"></asp:label></TD>
						<td align="center" rowSpan="2"><asp:button id="btOk" runat="server" Width="85px" Height="49px" Text="�ύ����"></asp:button></td>
					</TR>
					<TR>
						<TD style="WIDTH: 38.2%; HEIGHT: 386px" align="right"><asp:listbox id="ltbAllEmp" runat="server" Width="304px" Height="359px" SelectionMode="Multiple"></asp:listbox></TD>
						<td style="WIDTH: 10%" align="center">
							<P><asp:button id="Button1" runat="server" Width="68px" Font-Size="10pt" Text="���>>"></asp:button></P>
							<P><asp:button id="Button2" runat="server" Width="68px" Font-Size="10pt" Text="<<ȡ��"></asp:button></P>
						</td>
						<TD style="WIDTH: 38.83%; HEIGHT: 386px" align="left"><asp:listbox id="ltbSchedEmp" runat="server" Width="304px" Height="359px" SelectionMode="Multiple"></asp:listbox></TD>
					</TR>
				</TABLE>
			</FORM>
		</FONT>
	</body>
</HTML>
