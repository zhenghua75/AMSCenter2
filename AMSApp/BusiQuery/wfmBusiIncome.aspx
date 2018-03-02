<%@ Page language="c#" Codebehind="wfmBusiIncome.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.BusiQuery.wfmBusiIncome" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmBusiIncome</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT language="javascript" src="../js/calendar.js"></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="<%=strExcelPath%>" bgColor="#feeff8">
		<FORM id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">ҵ����ͳ�Ʊ���</TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" cellSpacing="1" cellPadding="1" width="95%" border="1">
				<TR>
					<TD>
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD style="WIDTH: 171px" align="right">
									<asp:label id="Label6" runat="server" Font-Size="10pt">�ŵ�</asp:label></TD>
								<TD style="WIDTH: 156px">
									<asp:dropdownlist id="ddlDept" runat="server" Font-Size="10pt" Width="144px"></asp:dropdownlist></TD>
								<TD style="WIDTH: 81px" align="right">
									<asp:label id="Label5" runat="server" Font-Size="10pt">��ʼʱ��</asp:label></TD>
								<TD style="WIDTH: 259px"><INPUT id=txtBegin onfocus=HS_setDate(this) type=text readonly size=11 value="<%=strBeginDate%>" name=txtBegin></TD>
								<TD>
									<asp:button id="btQuery" runat="server" Font-Size="10pt" Width="56px" Text="��ѯ"></asp:button></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 171px" align="right"></TD>
								<TD style="WIDTH: 156px"></TD>
								<TD style="WIDTH: 81px" align="right">
									<asp:label id="Label4" runat="server" Font-Size="10pt">����ʱ��</asp:label></TD>
								<TD style="WIDTH: 259px"><INPUT id=txtEnd onfocus=HS_setDate(this) type=text readonly size=11 value="<%=strEndDate%>" name=txtEnd></TD>
								<TD><FONT face="����">
										<asp:button id="btnExcel" runat="server" Font-Size="10pt" Width="56px" Text="����"></asp:button></FONT></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="95%" border="0">
				<TR>
					<TD align="center">
						<uc1:ucpageview id="UcPageView1" runat="server" Visible="true"></uc1:ucpageview></TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
