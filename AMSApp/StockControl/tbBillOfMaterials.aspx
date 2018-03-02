<%@ Page Title="配方" MasterPageFile="~/StockControl/StockControl.Master" Language="C#" AutoEventWireup="true" CodeBehind="tbBillOfMaterials.aspx.cs" Inherits="AMSApp.StockControl.tbBillOfMaterials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="javascript" runat="server">
    <script src="tbBillOfMaterials.js" type="text/javascript"></script>
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="dg">
        <thead>
            <tr>
                <th colspan="7">母件</th>
                <th colspan="7">子件</th> 
            </tr>
            <tr>
                 
                <th field="cnvcPartProductTypeName" width="100">产品组</th>
                <th field="cnvcPartInvCName" width="100">产品类别</th>
                <th field="cnvcPartInvCode" width="100">存货编码</th>
                <th field="cnvcPartInvName" width="100">存货名称</th>
                <th field="cnvcPartGroupName" width="100">计量单位组</th>
                <th field="cnvcPartProduceUnitName" width="100">生产计量单位</th>
                <th field="cnnBaseQtyD" width="100">基础用量
                </th>
                
                <th field="cnvcComponentProductTypeName" width="100">产品组</th>
                <th field="cnvcComponentInvCName" width="100">产品类别</th>
                <th field="cnvcComponentInvCode" width="100">存货编码
                </th>
                <th field="cnvcComponentInvName" width="100">存货名称</th>
                <th field="cnvcComponentGroupName" width="100">计量单位组</th>
                <th field="cnvcComponentProduceUnitName" width="100">生产计量单位</th>
                <th field="cnnBaseQtyN" width="100">用量
                </th>
                
            </tr>
        </thead>
    </table>
    <div id="toolbar">
        <a href="#" class="easyui-linkbutton" iconcls="icon-add" plain="true" onclick="newtbBillOfMaterials();return false;">
            添加</a> <a href="#" class="easyui-linkbutton" iconcls="icon-edit" plain="true" onclick="edittbBillOfMaterials();return false;">
                修改</a> <a href="#" class="easyui-linkbutton" iconcls="icon-remove" plain="true" onclick="removetbBillOfMaterials();return false;">
                    删除</a> <a href="#" class="easyui-linkbutton" iconcls="icon-search" plain="true" onclick="searchtbBillOfMaterials();return false;">
                        搜索</a> <a href="#" class="easyui-linkbutton" iconcls="icon-save" plain="true" onclick="tbBillOfMaterialsExportToExcel();return false;">
                            导出</a>
    </div>
    <div id="dlg" style="width: 400px; height: 280px; padding: 10px 20px">
        <div class="ftitle">
            配方</div>
        <form id="fm" method="post">
        <div class="fitem">
            <label>母件
            </label>
            <input id="cnvcPartInvCode" name="cnvcPartInvCode" class="easyui-validatebox" />
        </div>
        <div class="fitem">
            <label>基础用量
            </label>
            <input name="cnnBaseQtyD" class="easyui-validatebox" validtype="Digit" required="true" />
        </div>
        <div class="fitem">
            <label>子件
            </label>
            <input id="cnvcComponentInvCode" name="cnvcComponentInvCode" class="easyui-validatebox"/>
        </div>
        <div class="fitem">
            <label>用量
            </label>
            <input name="cnnBaseQtyN" class="easyui-validatebox" validtype="Digit" required="true" />
        </div>
        
        </form>
    </div>
    <div id="dlg-buttons">
        <a href="#" class="easyui-linkbutton" iconcls="icon-ok" onclick="savetbBillOfMaterials();return false;">
            保存</a> <a href="#" class="easyui-linkbutton" iconcls="icon-cancel" onclick="javascript:$('#dlg').dialog('close');return false;">
                取消</a>
    </div>
    <div id="search-dlg" style="width: 400px; height: 280px; padding: 10px 20px">
        <div class="ftitle">
            配方</div>
        <form id="search-fm" method="post">
        <div class="fitem">
            <label>母件
            </label>
            <input id="search-cnvcPartInvCode" name="cnvcPartInvCode" class="easyui-validatebox"/>
        </div>
        <div class="fitem">
            <label>基础用量
            </label>
            <input id="search-cnnBaseQtyD" name="cnnBaseQtyD" class="easyui-validatebox" validtype="Digit"/>
        </div>
        <div class="fitem">
            <label>子件
            </label>
            <input id="search-cnvcComponentInvCode" name="cnvcComponentInvCode" class="easyui-validatebox"/>
        </div>
        <div class="fitem">
            <label>用量
            </label>
            <input id="search-cnnBaseQtyN" name="cnnBaseQtyN" class="easyui-validatebox" validtype="Digit"/>
        </div>
        
        </form>
    </div>
    <div id="search-dlg-buttons">
        <a href="#" class="easyui-linkbutton" iconcls="icon-ok" onclick="highSearchtbBillOfMaterials();return false;">
            查询</a> <a href="#" class="easyui-linkbutton" iconcls="icon-cancel" onclick="javascript:$('#search-dlg').dialog('close');return false;">
                取消</a>
    </div>
    <form id="export-excel" method="post">
    </form>
</asp:Content>
