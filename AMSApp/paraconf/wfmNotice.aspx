<%@ Page language="c#" Codebehind="wfmNotice.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmNotice" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmNotice</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<SCRIPT language="javascript" src="../js/calendar.js"></SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onload="<%=strExcelPath%>" bgcolor="#feeff8">
		<FONT face="����">
			<FORM id="Form1" method="post" runat="server">
				<TABLE id="Table3" cellSpacing="1" cellPadding="5" width="95%" border="0">
					<TR>
						<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">ϵͳ֪ͨ����</TD>
					</TR>
				</TABLE>
				<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="95%" border="1">
					<TR>
						<TD>
							<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 96px" align="right">
										<asp:label id="Label2" runat="server" Width="69px" Font-Size="10pt">��������</asp:label></TD>
									<TD style="WIDTH: 127px">
										<asp:dropdownlist id="ddlDept" runat="server" Width="168px" Font-Size="10pt" AutoPostBack="True"></asp:dropdownlist></TD>
									<TD style="WIDTH: 545px" align="right">
										<asp:label id="Label5" runat="server" Font-Size="10pt">��ʼʱ��</asp:label></TD>
									<TD style="WIDTH: 671px"><INPUT id=txtBegin style="FONT-SIZE: 10pt; WIDTH: 128px; HEIGHT: 22px" onfocus=HS_setDate(this) readOnly type=text size=16 value="<%=strBeginDate%>" name=txtBegin></TD>
									<TD style="WIDTH: 486px"></TD>
									<TD style="WIDTH: 324px"></TD>
									<TD style="WIDTH: 94px"></TD>
									<TD style="WIDTH: 360px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 96px" align="right">
										<asp:label id="Label1" runat="server" Width="88px" Font-Size="10pt">֪ͨ����</asp:label></TD>
									<TD style="WIDTH: 127px">
										<asp:textbox id="txtContent" runat="server" Width="160px" Font-Size="10pt" Height="24px"></asp:textbox></TD>
									<TD style="WIDTH: 545px" align="right">
										<asp:label id="Label4" runat="server" Font-Size="10pt">����ʱ��</asp:label></TD>
									<TD style="WIDTH: 671px"><INPUT id=txtEnd style="FONT-SIZE: 10pt; WIDTH: 128px; HEIGHT: 22px" onfocus=HS_setDate(this) readOnly type=text size=16 value="<%=strEndDate%>" name=txtEnd></TD>
									<TD style="WIDTH: 486px">
										<asp:button id="btQuery" runat="server" Width="64px" Text="��ѯ"></asp:button></TD>
									<TD style="WIDTH: 324px">
										<asp:button id="btAdd" runat="server" Width="64px" Text="���"></asp:button></TD>
									<TD style="WIDTH: 94px">
										<asp:button id="btnExcel" runat="server" Width="64px" Text="����"></asp:button></TD>
									<TD style="WIDTH: 360px"></TD>
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
		</FONT>
	</body>
</HTML>
