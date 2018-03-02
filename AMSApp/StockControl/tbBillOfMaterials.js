

var url;
$(function () {
    $('#dlg').dialog({
        title: '配方',
        modal: true,
        collapsible: true,
        resizable: true,
        closed: true,
        shadow: false,
        buttons: '#dlg-buttons'
    });
    $('#dg').datagrid({
        width: 1000,
        height: 350,
        fitColumns: true,
        rownumbers: true,
        singleSelect: true,
        pagination: true,
        title: "配方",
        url: 'Services/tbBillOfMaterials.ashx?Method=query',
        toolbar: '#toolbar'
    });

    $('#search-dlg').dialog({
        title: '查询配方',
        modal: true,
        collapsible: true,
        resizable: true,
        closed: true,
        shadow: false,
        buttons: '#search-dlg-buttons'
    });

    $('#cnvcPartInvCode').combogrid({
        panelWidth: 650,
        idField: 'cnvcInvCode',
        textField: 'cnvcInvName',
        url: 'Services/tbInventory.ashx?Method=query',
        required: true,
        //fitColumns: true,
        rownumbers: true,
        singleSelect: true,
        pagination: true,
        striped: true,
        mode:'remote',
        columns: [[
            { field: 'cnvcInvCCodeComments', width: 100, title: '存货类别' },
            { field: 'cnvcInvCode', width: 100, title: '存货编码' },
			{ field: 'cnvcInvName', width: 100, title: '存货名称' },
			{ field: 'cnbProductBillComments', width: 100, title: '允许生产订单', formatter: formatCheckBox },
			{ field: 'cnbSaleComments', width: 100, title: '是否销售', formatter: formatCheckBox },
			{ field: 'cnbPurchaseComments', width: 100, title: '是否外购', formatter: formatCheckBox },
			{ field: 'cnbSelfComments', width: 100, title: '是否自制', formatter: formatCheckBox },
			{ field: 'cnbComsumeComments', width: 100, title: '是否生产耗用', formatter: formatCheckBox },
			{ field: 'cniInvCCost', width: 100, title: '参考成本（元）' },
			{ field: 'cniInvNCost', width: 100, title: '最新成本（元）' },
			{ field: 'cniSafeNum', width: 100, title: '安全库存量' },
			{ field: 'cniLowSum', width: 100, title: '最低库存量' },
			{ field: 'cnnExpire', width: 100, title: '过期限制（天）' },
			{ field: 'cnnDue', width: 100, title: '到期提示（天）' },
			{ field: 'cndSDate', width: 100, title: '启用日期' },
			{ field: 'cndEDate', width: 100, title: '停用日期' },
            { field: 'cnvcCreatePersonComments', width: 100, title: '建档人' },
            { field: 'cnvcModifyPersonComments', width: 100, title: '变更人' },
			{ field: 'cndModifyDate', width: 100, title: '变更日期' },
            { field: 'cnvcValueTypeComments', width: 100, title: '计价方式' },
			{ field: 'cnvcInvStd', width: 100, title: '规格型号' },
            { field: 'cnvcGroupCodeComments', width: 100, title: '计量单位组' },
            { field: 'cnvcComUnitCodeComments', width: 100, title: '主计量单位' },
            { field: 'cnvcSAComUnitCodeComments', width: 100, title: '销售计量单位' },
            { field: 'cnvcPUComUnitCodeComments', width: 100, title: '采购计量单位' },
            { field: 'cnvcSTComUnitCodeComments', width: 100, title: '库存计量单位' },
            { field: 'cnvcProduceUnitCodeComments', width: 100, title: '生产计量单位' },
			{ field: 'cnfRetailPrice', width: 100, title: '零售价格' },
            { field: 'cnvcShopUnitCodeComments', width: 100, title: '零售计量单位' },
			{ field: 'cnvcFeel', width: 100, title: '口感' },
			{ field: 'cnvcOrganise', width: 100, title: '组织' },
			{ field: 'cnvcColor', width: 100, title: '内馅' },
			{ field: 'cnvcTaste', width: 100, title: '表面装饰' }
    ]]
    });
    $('#cnvcComponentInvCode').combogrid({
        panelWidth: 650,
        idField: 'cnvcInvCode',
        textField: 'cnvcInvName',
        url: 'Services/tbInventory.ashx?Method=query',
        required: true,
        //fitColumns: true,
        rownumbers: true,
        singleSelect: true,
        pagination: true,
        striped: true,
        mode: 'remote',
        columns: [[
            { field: 'cnvcInvCCodeComments', width: 100, title: '存货类别' },
            { field: 'cnvcInvCode', width: 100, title: '存货编码' },
			{ field: 'cnvcInvName', width: 100, title: '存货名称' },
			{ field: 'cnbProductBillComments', width: 100, title: '允许生产订单', formatter: formatCheckBox },
			{ field: 'cnbSaleComments', width: 100, title: '是否销售', formatter: formatCheckBox },
			{ field: 'cnbPurchaseComments', width: 100, title: '是否外购', formatter: formatCheckBox },
			{ field: 'cnbSelfComments', width: 100, title: '是否自制', formatter: formatCheckBox },
			{ field: 'cnbComsumeComments', width: 100, title: '是否生产耗用', formatter: formatCheckBox },
			{ field: 'cniInvCCost', width: 100, title: '参考成本（元）' },
			{ field: 'cniInvNCost', width: 100, title: '最新成本（元）' },
			{ field: 'cniSafeNum', width: 100, title: '安全库存量' },
			{ field: 'cniLowSum', width: 100, title: '最低库存量' },
			{ field: 'cnnExpire', width: 100, title: '过期限制（天）' },
			{ field: 'cnnDue', width: 100, title: '到期提示（天）' },
			{ field: 'cndSDate', width: 100, title: '启用日期' },
			{ field: 'cndEDate', width: 100, title: '停用日期' },
            { field: 'cnvcCreatePersonComments', width: 100, title: '建档人' },
            { field: 'cnvcModifyPersonComments', width: 100, title: '变更人' },
			{ field: 'cndModifyDate', width: 100, title: '变更日期' },
            { field: 'cnvcValueTypeComments', width: 100, title: '计价方式' },
			{ field: 'cnvcInvStd', width: 100, title: '规格型号' },
            { field: 'cnvcGroupCodeComments', width: 100, title: '计量单位组' },
            { field: 'cnvcComUnitCodeComments', width: 100, title: '主计量单位' },
            { field: 'cnvcSAComUnitCodeComments', width: 100, title: '销售计量单位' },
            { field: 'cnvcPUComUnitCodeComments', width: 100, title: '采购计量单位' },
            { field: 'cnvcSTComUnitCodeComments', width: 100, title: '库存计量单位' },
            { field: 'cnvcProduceUnitCodeComments', width: 100, title: '生产计量单位' },
			{ field: 'cnfRetailPrice', width: 100, title: '零售价格' },
            { field: 'cnvcShopUnitCodeComments', width: 100, title: '零售计量单位' },
			{ field: 'cnvcFeel', width: 100, title: '口感' },
			{ field: 'cnvcOrganise', width: 100, title: '组织' },
			{ field: 'cnvcColor', width: 100, title: '内馅' },
			{ field: 'cnvcTaste', width: 100, title: '表面装饰' }
    ]]
    });
    $('#search-cnvcPartInvCode').combogrid({
        panelWidth: 650,
        idField: 'cnvcInvCode',
        textField: 'cnvcInvName',
        url: 'Services/tbInventory.ashx?Method=query',
        //required: true,
        //fitColumns: true,
        rownumbers: true,
        singleSelect: true,
        pagination: true,
        mode: 'remote',
        columns: [[
            { field: 'cnvcInvCCodeComments', width: 100, title: '存货类别' },
            { field: 'cnvcInvCode', width: 100, title: '存货编码' },
			{ field: 'cnvcInvName', width: 100, title: '存货名称' },
			{ field: 'cnbProductBillComments', width: 100, title: '允许生产订单', formatter: formatCheckBox },
			{ field: 'cnbSaleComments', width: 100, title: '是否销售', formatter: formatCheckBox },
			{ field: 'cnbPurchaseComments', width: 100, title: '是否外购', formatter: formatCheckBox },
			{ field: 'cnbSelfComments', width: 100, title: '是否自制', formatter: formatCheckBox },
			{ field: 'cnbComsumeComments', width: 100, title: '是否生产耗用', formatter: formatCheckBox },
			{ field: 'cniInvCCost', width: 100, title: '参考成本（元）' },
			{ field: 'cniInvNCost', width: 100, title: '最新成本（元）' },
			{ field: 'cniSafeNum', width: 100, title: '安全库存量' },
			{ field: 'cniLowSum', width: 100, title: '最低库存量' },
			{ field: 'cnnExpire', width: 100, title: '过期限制（天）' },
			{ field: 'cnnDue', width: 100, title: '到期提示（天）' },
			{ field: 'cndSDate', width: 100, title: '启用日期' },
			{ field: 'cndEDate', width: 100, title: '停用日期' },
            { field: 'cnvcCreatePersonComments', width: 100, title: '建档人' },
            { field: 'cnvcModifyPersonComments', width: 100, title: '变更人' },
			{ field: 'cndModifyDate', width: 100, title: '变更日期' },
            { field: 'cnvcValueTypeComments', width: 100, title: '计价方式' },
			{ field: 'cnvcInvStd', width: 100, title: '规格型号' },
            { field: 'cnvcGroupCodeComments', width: 100, title: '计量单位组' },
            { field: 'cnvcComUnitCodeComments', width: 100, title: '主计量单位' },
            { field: 'cnvcSAComUnitCodeComments', width: 100, title: '销售计量单位' },
            { field: 'cnvcPUComUnitCodeComments', width: 100, title: '采购计量单位' },
            { field: 'cnvcSTComUnitCodeComments', width: 100, title: '库存计量单位' },
            { field: 'cnvcProduceUnitCodeComments', width: 100, title: '生产计量单位' },
			{ field: 'cnfRetailPrice', width: 100, title: '零售价格' },
            { field: 'cnvcShopUnitCodeComments', width: 100, title: '零售计量单位' },
			{ field: 'cnvcFeel', width: 100, title: '口感' },
			{ field: 'cnvcOrganise', width: 100, title: '组织' },
			{ field: 'cnvcColor', width: 100, title: '内馅' },
			{ field: 'cnvcTaste', width: 100, title: '表面装饰' }
    ]]
    });

    $('#search-cnvcComponentInvCode').combogrid({
        panelWidth: 650,
        idField: 'cnvcInvCode',
        textField: 'cnvcInvName',
        url: 'Services/tbInventory.ashx?Method=query',
        //required: true,
        //fitColumns: true,
        rownumbers: true,
        singleSelect: true,
        pagination: true,
        striped: true,
        mode: 'remote',
        columns: [[
            { field: 'cnvcInvCCodeComments', width: 100, title: '存货类别' },
            { field: 'cnvcInvCode', width: 100, title: '存货编码' },
			{ field: 'cnvcInvName', width: 100, title: '存货名称' },
			{ field: 'cnbProductBillComments', width: 100, title: '允许生产订单', formatter: formatCheckBox },
			{ field: 'cnbSaleComments', width: 100, title: '是否销售', formatter: formatCheckBox },
			{ field: 'cnbPurchaseComments', width: 100, title: '是否外购', formatter: formatCheckBox },
			{ field: 'cnbSelfComments', width: 100, title: '是否自制', formatter: formatCheckBox },
			{ field: 'cnbComsumeComments', width: 100, title: '是否生产耗用', formatter: formatCheckBox },
			{ field: 'cniInvCCost', width: 100, title: '参考成本（元）' },
			{ field: 'cniInvNCost', width: 100, title: '最新成本（元）' },
			{ field: 'cniSafeNum', width: 100, title: '安全库存量' },
			{ field: 'cniLowSum', width: 100, title: '最低库存量' },
			{ field: 'cnnExpire', width: 100, title: '过期限制（天）' },
			{ field: 'cnnDue', width: 100, title: '到期提示（天）' },
			{ field: 'cndSDate', width: 100, title: '启用日期' },
			{ field: 'cndEDate', width: 100, title: '停用日期' },
            { field: 'cnvcCreatePersonComments', width: 100, title: '建档人' },
            { field: 'cnvcModifyPersonComments', width: 100, title: '变更人' },
			{ field: 'cndModifyDate', width: 100, title: '变更日期' },
            { field: 'cnvcValueTypeComments', width: 100, title: '计价方式' },
			{ field: 'cnvcInvStd', width: 100, title: '规格型号' },
            { field: 'cnvcGroupCodeComments', width: 100, title: '计量单位组' },
            { field: 'cnvcComUnitCodeComments', width: 100, title: '主计量单位' },
            { field: 'cnvcSAComUnitCodeComments', width: 100, title: '销售计量单位' },
            { field: 'cnvcPUComUnitCodeComments', width: 100, title: '采购计量单位' },
            { field: 'cnvcSTComUnitCodeComments', width: 100, title: '库存计量单位' },
            { field: 'cnvcProduceUnitCodeComments', width: 100, title: '生产计量单位' },
			{ field: 'cnfRetailPrice', width: 100, title: '零售价格' },
            { field: 'cnvcShopUnitCodeComments', width: 100, title: '零售计量单位' },
			{ field: 'cnvcFeel', width: 100, title: '口感' },
			{ field: 'cnvcOrganise', width: 100, title: '组织' },
			{ field: 'cnvcColor', width: 100, title: '内馅' },
			{ field: 'cnvcTaste', width: 100, title: '表面装饰' }
    ]]
    });
});

function newtbBillOfMaterials() {
    $('#dlg').dialog('open').dialog('setTitle', '添加配方');
    moveDialog('dlg');
    $('#fm').form('clear');
    url = "Services/tbBillOfMaterials.ashx?Method=new";
}
function edittbBillOfMaterials() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $('#dlg').dialog('open').dialog('setTitle', '编辑配方');
        moveDialog('dlg');
        $('#cnvcPartInvCode').combogrid('setValue', row.cnvcPartInvCode);
        $('#cnvcPartInvCode').combogrid('setText', row.cnvcPartInvName);
        $('#cnvcComponentInvCode').combogrid('setValue', row.cnvcComponentInvCode);
        $('#cnvcComponentInvCode').combogrid('setText', row.cnvcComponentInvName);
        $('#fm').form('load', row);
        url = "Services/tbBillOfMaterials.ashx?Method=update&cnvcPartInvCode="+row.cnvcPartInvCode+"&cnvcComponentInvCode="+row.cnvcComponentInvCode;
    }
    else {
        $.messager.show({
            title: '错误信息',
            msg: '请选择一行数据进行编辑'
        });
    }
}
function savetbBillOfMaterials() {
    $('#fm').form('submit', {
        url: url,
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (result) {
            var json = eval('(' + result + ')');
            if (json.success) {
                $('#dlg').dialog('close');      // close the dialog  
                $('#dg').datagrid('reload');    // reload the user data  
            } else {
                if (json.msg == "loginOvertime") {
                    window.top.location.href = '../default.aspx';
                }
                else {
                    $.messager.show({
                        title: '错误信息',
                        msg: json.msg
                    });
                }
            }
        }
    });
}

function removetbBillOfMaterials() {
    var row = $('#dg').datagrid('getSelected');
    if (row) {
        $.messager.confirm('提示', '是否确定删除?', function (r) {
            if (r) {
                $.post('Services/tbBillOfMaterials.ashx', { 'Method': 'remove', 'cnvcPartInvCode': row.cnvcPartInvCode, 'cnvcComponentInvCode': row.cnvcComponentInvCode}, function (json) {
                    if (json.success == true) {
                        $('#dg').datagrid('reload');
                    } else {
                        $.messager.show({
                            title: '错误信息',
                            msg: json.msg
                        });
                    }
                }, 'json');
            }
        });
    }
    else {
        $.messager.show({
            title: '错误信息',
            msg: '请选择一行数据进行删除'
        });
    }
}


function searchtbBillOfMaterials() {
    $('#search-dlg').dialog('open').dialog('setTitle', '查询配方');
    moveDialog('search-dlg');
}
function highSearchtbBillOfMaterials() {
    $('#search-dlg').dialog('close');

    $('#dg').datagrid({
        pageNumber: 1,
        queryParams: {
            'cnvcPartInvCode': $('#search-cnvcPartInvCode').combogrid("getValue"),
            'cnvcComponentInvCode': $('#search-cnvcComponentInvCode').combogrid("getValue"),
'cnnBaseQtyN':$('#search-cnnBaseQtyN').val(),
'cnnBaseQtyD':$('#search-cnnBaseQtyD').val()}
    });
}

function tbBillOfMaterialsExportToExcel() {
    $('#export-excel').form('submit', {
        url: 'Services/tbBillOfMaterials.ashx?Method=excel',
        onSubmit: function () {
            return $(this).form('validate');
        },
        success: function (result) {
            var json = eval('(' + result + ')');
            if (json.msg == "loginOvertime") {
                window.top.location.href = '../default.aspx';
            }
        }
    });
}
