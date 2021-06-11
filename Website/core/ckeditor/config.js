/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    config.language = 'fa';


    config.uiColor = '#d6e6f4';
    config.baseFloatZIndex = 9000;
    config.extraPlugins = 'ajax';
    config.extraPlugins = 'backgrounds';
    config.enterMode = CKEDITOR.ENTER_BR;

 //start*********** add z index for always top on updatePopup
    config.baseFloatZIndex = 22220000;

 
 //end*************
    
    //** added
    //**   config.htmlEncodeOutput = true;

};

