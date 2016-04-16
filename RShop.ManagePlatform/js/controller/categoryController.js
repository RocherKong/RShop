/// <reference path="../app.js" />

'use strict';
(function (global, $) {
    var categoryController = {
        treeSetting: {
            treeId: 'tree_Category',
            view: {
                dblClickExpand: true,
                showLine: true,
                selectedMulti: false
            },
            data: {
                key: {
                    Id: "Id",
                    name: "CategoryName",
                    title: "CategoryName",
                    CategoryCode: "CategoryCode"
                },
                simpleData: {
                    enable: true,
                    idKey: "Id",
                    pIdKey: "ParentId",
                    rootPId: '1'
                }
            },
            callback: {
                onClick: function (e, treeId, node, flg) {
                    var that = categoryController;
                    var $cName = $('p[data-role=cName]');
                    var $cId = $('#CategoryId');
                    var $cCode = $('#CurrentCode');
                    $cName.html(node.CategoryName);
                    $cId.val(node.Id)
                    $cCode.val(node.CategoryCode);
                    $("#cId").val(node.Id);
                    $.ajax({
                        url: '/ProductCategory/GetAttrsById',
                        type: 'Post',
                        data: { CategoryCode: node.CategoryCode },
                        success: function (result) {
                            that.selectAttr.val(result.Body).trigger("change");
                        }
                    })
                }
            }
        },
        init: function () {
            this.bindEvent();
            this.initTree();
        },
        selectAttr: null,
        bindEvent: function () {
            var that = this;
            that.initForm();
            $('a[data-role=saveAttrs]').on('click', function () {
                var cId = $('#CategoryId').val();
                if (cId == '') { artDialog.tips('请先选择分类！'); return; }
                var attrIds = that.selectAttr.val();
                $.ajax({
                    url: '/ProductCategory/SaveAttrs',
                    type: 'Post',
                    data: { Id: cId, AttrIds: attrIds },
                    success: function (result) {
                        artDialog.tips('参数保存成功！');
                    }
                });
            });

            $(document).on('click', 'a[data-role=deleteCategory]', function () {
                var cId = $('#CategoryId').val();
                if (cId == '') { artDialog.tips('请先选择分类！'); return; }

                art.dialog.confirm('你确定要删除该分类吗？', function () {
                    $.ajax({
                        url: '/ProductCategory/Delete',
                        type: 'Post',
                        data: { Id: cId },
                        success: function (result) {
                            artDialog.tips('分类删除成功！');
                            categoryController.initTree();
                        }
                    });
                });
               
            });

            this.selectAttr = $('#sel_attr').select2(
                            {
                                placeholder: "请选择参数",
                                allowClear: true,
                                language: "zh-CN"
                            }
                        );
        },
        initTree: function () {
            var that = this;
            $.ajax({
                url: '/ProductCategory/GetAll',
                type: 'post',
                dataType: 'json',
                success: function (resp) {
                    $(resp.Body).each(function (i, item) {
                        item.FCategoryCode = item.CategoryCode.substr(0, item.CategoryCode.lastIndexOf('-'));
                    });
                    $.fn.zTree.init($("#treeContainer"), that.treeSetting, resp.Body);
                }
            });
        },
        initForm: function () {
            var baseOptions = $.extend(this.defaultValidateOptions, {
                rules: {
                    ProductCategoryId: { required: true },
                    CategoryName: { required: true },
                    SortId: { required: true, digits: true }
                }
            });
            $('#form_base').validate(baseOptions);


        },
        defaultValidateOptions: {
            ignore: '',
            errorClass: 'has-error',
            validClass: 'has-success',
            highlight: function (element, errorClass, validClass) {
                $(element.parentElement.parentElement).addClass(errorClass).removeClass(validClass);
            },
            unhighlight: function (element, errorClass, validClass) {
                $(element.parentElement.parentElement).addClass(validClass).removeClass(errorClass);
            },
            submitHandler: function (form) {
                var cId = $('#CategoryId').val();
                if (cId == '') { artDialog.tips('请先选择分类！'); return; }
                var role = $(this.submitButton).attr('data-role');
                var serviceApi = '';
                switch (role) {
                    case 'addCategory':
                        serviceApi = '/ProductCategory/Add';
                        break;
                    case 'addChildCategory':
                        serviceApi = '/ProductCategory/AddChild';
                        break;
                    case 'updateCategory':
                        serviceApi = '/ProductCategory/Update';
                        break;
                    case 'deleteCategory':
                        serviceApi = '/ProductCategory/Delete';
                        break;
                }
                form.action = serviceApi;
                $(form).ajaxSubmit({
                    success: function (resp) {
                        if (resp.IsSuccess) {
                            artDialog.tips('参数保存成功！');
                            categoryController.initTree();
                        }
                    }
                });
                return false;
            }
        }
    };
    $(function () {
        categoryController.init();
        global.categoryController = categoryController;
    })
}(window, jQuery));

