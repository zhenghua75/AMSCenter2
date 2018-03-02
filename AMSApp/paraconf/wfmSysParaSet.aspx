<%@ Page language="c#" Codebehind="wfmSysParaSet.aspx.cs" AutoEventWireup="false" Inherits="AMSApp.paraconf.wfmSysParaSet" %>
<%@ Register TagPrefix="uc1" TagName="ucPageView" Src="../ucPageView.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>wfmSysParaSet</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#feeff8" MS_POSITIONING="GridLayout">
		<FORM id="Form2" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="5" width="95%" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; FONT-SIZE: 15pt; COLOR: #330033" align="center">系统参数管理</TD>
				</TR>
			</TABLE>
			<TABLE id="Table2" height="500" cellSpacing="1" cellPadding="1" width="95%" border="0">
				<TR>
					<TD width="50%">
						<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="100%" border="1" height="100%">
							<TR>
								<TD colspan="3" style="FONT-SIZE: 10pt; COLOR: #3366cc">新商品推荐设置</TD>
							</TR>
							<TR>
								<TD style="FONT-SIZE: 10pt; WIDTH: 184px">现有商品</TD>
								<TD style="WIDTH: 49px"></TD>
								<TD style="FONT-SIZE: 10pt">推荐新品</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 184px"><FONT face="宋体">
										<asp:ListBox id="lbtcurrent" runat="server" Height="444px" Width="176px" Font-Size="10pt"></asp:ListBox></FONT></TD>
								<TD style="WIDTH: 49px">
									<TABLE id="Table5" cellSpacing="1" cellPadding="1" width="83" border="0" style="WIDTH: 83px; HEIGHT: 225px"
										align="center">
										<TR>
											<TD align="center">
												<asp:Button id="btAdd" runat="server" Text="添加>>"></asp:Button></TD>
										</TR>
										<TR>
											<TD align="center">
												<asp:Button id="btDel" runat="server" Text="<<移除"></asp:Button></TD>
										</TR>
										<TR>
											<TD align="center">
												<asp:Button id="btNewGoods" runat="server" Text="保存" Width="61px"></asp:Button></TD>
										</TR>
									</TABLE>
								</TD>
								<TD>
									<asp:ListBox id="lbtNew" runat="server" Height="446px" Width="176px" Font-Size="10pt"></asp:ListBox></TD>
							</TR>
						</TABLE>
					</TD>
					<TD width="100%">
						<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="100%" height="100%" border="0">
							<TR>
								<TD style="HEIGHT: 166px">
									<TABLE id="Table6" cellSpacing="1" cellPadding="1" width="100%" border="1">
										<TR>
											<TD colspan="5" style="FONT-SIZE: 10pt; COLOR: #3366cc">消费积分设置：</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 91px" align="right">消费</TD>
											<TD style="WIDTH: 85px" align="center">
												<asp:TextBox id="txtFee" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt; WIDTH: 69px" align="center">元，赠送</TD>
											<TD style="WIDTH: 67px" align="center">
												<asp:TextBox id="txtIg" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">积分</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 344px; COLOR: #cc0000" colspan="4">注意：该参数如果不设置，将视为消费无积分</TD>
											<TD>
												<asp:Button id="btIg" runat="server" Width="48px" Text="设置"></asp:Button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 117px">
									<TABLE id="Table7" cellSpacing="1" cellPadding="1" width="100%" border="1">
										<TR>
											<TD colspan="3" style="FONT-SIZE: 10pt; COLOR: #3366cc">充值赠款金额设置：</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 164px" align="right">100-200赠款比例</TD>
											<TD style="WIDTH: 96px">
												<asp:TextBox id="txtPromRate1" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">%</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 164px" align="right">200-300赠款比例</TD>
											<TD style="WIDTH: 96px">
												<asp:TextBox id="txtPromRate2" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">%</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 164px" align="right">300-400赠款比例</TD>
											<TD style="WIDTH: 96px">
												<asp:TextBox id="txtPromRate3" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">%</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 164px" align="right">400-500赠款比例</TD>
											<TD style="WIDTH: 96px">
												<asp:TextBox id="txtPromRate4" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">%</TD>
										</TR>
										<TR>
											<TD style="FONT-SIZE: 10pt; WIDTH: 167px" align="right">500以上赠款比例</TD>
											<TD style="WIDTH: 96px">
												<asp:TextBox id="txtPromRate5" runat="server" Width="94px" Font-Size="10pt"></asp:TextBox></TD>
											<TD style="FONT-SIZE: 10pt">%</TD>
										</TR>
										<TR>
											<TD colspan="2" style="FONT-SIZE: 10pt; WIDTH: 295px; COLOR: #cc0000">注意：该参数如果不设置，将视为充值无赠款</TD>
											<TD>
												<asp:Button id="btProm" runat="server" Width="48px" Text="设置"></asp:Button></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</FORM>
	</body>
</HTML>
