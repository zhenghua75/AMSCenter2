$(function () {
    //    $('#btn').linkbutton({
    //    });
    GetOperName();
    $('#tt').tabs({ fit: true});
//    $('#pp').panel({ fit: true });
//    $(window).resize(function () {
//        $('#pp').panel('resize');
//    });
});
function rd() {
    if (confirm("您是否确认退出系统？")) {
        window.parent.parent.location.href = "Exit.aspx";
    }
}
function GetOperName() {
    $.post('StockControl/Services/wfmMain.ashx', function (result) {
        var json = eval('(' + result + ')');
        if (json.success == true) {
            $('#lblOperName').linkbutton({ text: json.msg });
        } else {
            $.messager.show({
                title: '错误信息',
                msg: json.msg
            });
        }
    });
}
function AddTab(linkurl) {
    var title = linkurl.text || linkurl.innerText;
    if ($('#tt').tabs('exists', title)) {
        $('#tt').tabs('select', title);
        //refreshTab({ tabTitle: title, url: linkurl.href });  
    }
    else {
        var content = '<iframe frameborder="0"  src="' + linkurl.href + '" style="border:0;width:100%;height:100%;"></iframe>';
        $('#tt').tabs('add', {
            title: title,
            content: content,
            //iconCls : '',
            //href:linkurl.href,
            closable: true,
            closed: true,
            cache: false,
            //loadingMessage: '加载...',
            onBeforeDestroy: function () {

                var frame = $('iframe', this);
                if (frame.length > 0) {
                    frame[0].contentWindow.document.write('');
                    frame[0].contentWindow.close();
                    frame.remove();
                    if (/msie/.test(navigator.userAgent.toLowerCase())) { CollectGarbage(); }
                }
            }
        });
    }
}

/**     
* 刷新tab 
* @cfg  
*example: {tabTitle:'tabTitle',url:'refreshUrl'} 
*如果tabTitle为空，则默认刷新当前选中的tab 
*如果url为空，则默认以原来的url进行reload 
*/
function refreshTab(cfg) {
    var refresh_tab = cfg.tabTitle ? $('#tt').tabs('getTab', cfg.tabTitle) : $('#tt').tabs('getSelected');
    if (refresh_tab && refresh_tab.find('iframe').length > 0) {
        var _refresh_ifram = refresh_tab.find('iframe')[0];
        var refresh_url = cfg.url ? cfg.url : _refresh_ifram.src;
        //_refresh_ifram.src = refresh_url;  
        _refresh_ifram.contentWindow.location.href = refresh_url;
    }
} 