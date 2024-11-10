/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    config.language = 'vi';
    //config.uiColor = '#AADC6E';
    config.toolbar_Basic = [
        ['Source', 'Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
        ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
        ['Undo', 'Redo', 'Paste', 'PasteText', 'PasteFromWord'],
        ['Link', 'Unlink', 'Anchor', 'TextColor', 'BGColor']
    ];
    config.toolbar =
    [
        ['Source', '-', 'Save', 'NewPage', 'Preview', '-', 'Templates'],
        ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Print'],
        ['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
        ['Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
        ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', 'Blockquote', 'CreateDiv'],
        ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
        ['Link', 'Unlink', 'Anchor', 'syntaxhighlight', 'highslide'],
        ['Image', 'Flash', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak'],
        ['Format', 'Font', 'FontSize'],
        ['TextColor', 'BGColor'],
        ['Maximize', 'ShowBlocks', '-', 'About']
    ];
    config.extraPlugins = 'tableresize,syntaxhighlight,highslide';
    config.filebrowserBrowseUrl = '/scripts/ckfinder/ckfinder.html';
    config.entities_latin = false;
};

//CKEDITOR.replace('editor1',
//{
//    filebrowserBrowseUrl: '/ckfinder/ckfinder.html',
//    filebrowserImageBrowseUrl: '/ckfinder/ckfinder.html?type=Images',
//    filebrowserFlashBrowseUrl: '/ckfinder/ckfinder.html?type=Flash',
//    filebrowserUploadUrl: '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files',
//    filebrowserImageUploadUrl: '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images',
//    filebrowserFlashUploadUrl: '/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash'
//});