'use strict';
(function (global, $) {
    var appSetting = {
        apiToken: '',
        /*
        交易系统API HOST
        */
        TC_Host: 'http://api.tc.i4ta.com/',
        /*
         获取API地址
        */
        getApi: function (apiType, action) {
            var serviceApi = "";
            switch (apiType) {
                case 1:
                    {
                        serviceApi = this.TC_Host + action;
                        break;
                    }
                default: throw '未知Api类型！';
            }
            return serviceApi + "?Token=" + this.apiToken;
        }
    };
    global.appSetting = appSetting;

    var upLoadTips;
    
    var defaultUpLoaderOptions = {
        runtimes: 'html5,flash,html4',
        //browse_button: 'btn_upLoadImg',
        uptoken_url: '/QiNiu/GetToken',
        unique_names: true,
        domain: 'http://static.i4ta.com/',
        max_file_size: '100mb',
        flash_swf_url: '/js/plugins/plupload/Moxie.swf',
        max_retries: 3,
        dragdrop: false,
        chunk_size: '4mb',
        auto_start: true,
        multi_selection: false,
        filters: {
            max_file_size: '10mb',
            mime_types: [
            { title: "Image files", extensions: "jpg,gif,png" }
            ]
        },
        init: {
            'FilesAdded': function (up, files) {
                plupload.each(files, function (file) {
                    // 文件添加进队列后,处理相关的事情
                });
            },
            'BeforeUpload': function (up, file) {
                upLoadTips = artDialog.tips('上传中，请稍后！', 60);
                // 每个文件上传前,处理相关的事情
            },
            'UploadProgress': function (up, file) {
                // 每个文件上传时,处理相关的事情
            },
            'FileUploaded': function (up, file, info) {
                // 每个文件上传成功后,处理相关的事情
                // 其中 info 是文件上传成功后，服务端返回的json，形式如
                // {
                //    "hash": "Fh8xVqod2MQ1mocfI4S4KpRL6D98",
                //    "key": "gogopher.jpg"
                //  }
                // 参考http://developer.qiniu.com/docs/v6/api/overview/up/response/simple-response.html
            },
            'Error': function (up, err, errTip) {
                //上传出错时,处理相关的事情
                upLoadTips.close();
            },
            'UploadComplete': function () {
                //队列文件处理完毕后,处理相关的事情
                upLoadTips.close();
            }
        }
    };

    global.upLoadTips = upLoadTips;
    global.defaultUpLoaderOptions = defaultUpLoaderOptions;


    jQuery.extend({
        /*
        调用服务API
        */
        CallApi: function (options) {
            jQuery.ajax({
                url: options.url,
                type: 'post',
                dataType: 'json',
                success: function (resp) {
                    if (resp.IsSuccess) {
                        options.success(resp.Body);
                    }
                    else {
                        alert(resp.Message);
                    }
                }
            });
        }
    });

}(window, jQuery));

