<%@ Page language="c#" Codebehind="wfmEmpEverySchAdd.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.Employ.wfmEmpEverySchAdd" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmEmpEverySchAdd</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgcolor="#feeff8">
		<FONT face="宋体">
			<FORM id="Form1" method="post" runat="server">
				<TABLE id="Table2" cellSpacing="1" cellPadding="5" width="70%" align="center" border="0">
					<TR>
						<TD style="COLOR: #330033; FONT-SIZE: 15pt; FONT-WEIGHT: bold" align="center">员工排班添加
							<asp:Label id="lblDeptID" runat="server" Visible="False"></asp:Label></TD>
					</TR>
				</TABLE>
				<TABLE id="Table1" cellSpacing="10" cellPadding="5" width="70%" align="center" border="0"
					style=" HEIGHT: 188px">
					<TR>
						<TD style="WIDTH: 86px; FONT-SIZE: 10pt" align="right">员工姓名</TD>
						<TD style="WIDTH: 170px">
							<asp:ListBox style="Z-INDEX: 0" id="ltbEmp" runat="server" Width="160px" Height="270px"></asp:ListBox></TD>
						<TD style="WIDTH: 92px; FONT-SIZE: 10pt" align="center"><P>
								<asp:Button style="Z-INDEX: 0" id="btSelect" runat="server" Text="选择>>"></asp:Button></P>
							<P>
								<asp:Button style="Z-INDEX: 0" id="btUnselect" runat="server" Text="<<移除"></asp:Button></P>
						</TD>
						<TD>
							<asp:ListBox style="Z-INDEX: 0" id="ltbSelect" runat="server" Width="160px" Height="270px"></asp:ListBox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 86px; FONT-SIZE: 10pt" align="right">排班日期</TD>
						<TD style="WIDTH: 170px">
							<asp:TextBox id="txtSchDate" runat="server" Height="24px" Width="136px" Font-Size="10pt" MaxLength="30"
								style="Z-INDEX: 0"></asp:TextBox></TD>
						<TD style="WIDTH: 92px; FONT-SIZE: 10pt" align="right"></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 86px; FONT-SIZE: 10pt" align="right"><FONT face="宋体">门店</FONT></TD>
						<TD style="WIDTH: 170px">
							<asp:TextBox id="txtDept" runat="server" Height="24px" Width="136px" Font-Size="10pt" MaxLength="18"></asp:TextBox></TD>
						<TD style="WIDTH: 92px; FONT-SIZE: 10pt" align="right">班次</TD>
						<TD>
							<asp:dropdownlist id="ddlClass" runat="server" Height="24px" Width="144px" Font-Size="10pt" AutoPostBack="True"></asp:dropdownlist></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 86px; FONT-SIZE: 10pt" align="right">上班时间</TD>
						<TD style="WIDTH: 170px">
							<asp:DropDownList id="ddlInHour" runat="server" Width="56px" Font-Size="10pt"></asp:DropDownList>时
							<asp:DropDownList id="ddlInMinute" runat="server" Width="56px" Font-Size="10pt"></asp:DropDownList>分</TD>
						<TD style="WIDTH: 92px; FONT-SIZE: 10pt" align="right">下班时间</TD>
						<TD>
							<asp:DropDownList id="ddlOutHour" runat="server" Width="56px" Font-Size="10pt"></asp:DropDownList>时
							<asp:DropDownList id="ddlOutMinute" runat="server" Width="56px" Font-Size="10pt"></asp:DropDownList>分
							<asp:CheckBox style="Z-INDEX: 0" id="chcSecDay" runat="server" Font-Size="10pt" Text="次日" Enabled="False"
								Visible="False"></asp:CheckBox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 271px" align="right" colSpan="2">
							<asp:Button id="btadd" runat="server" Width="64px" Font-Size="10pt" Text="添加"></asp:Button></TD>
						<TD align="left" colSpan="2">
							<asp:Button id="btcancel" runat="server" Width="56px" Font-Size="10pt" Text="返回"></asp:Button></TD>
					</TR>
				</TABLE>
			</FORM>
		</FONT>
	</body>
</HTML>
