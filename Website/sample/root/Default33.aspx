<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default33.aspx.cs" Inherits="Default33" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/admin.css" rel="stylesheet" />
    <link href="css/admin-public.css" rel="stylesheet" />
</head>
<body id="bx-admin-prefix">
    <form id="form1" runat="server">
    <div>
    
        


<style type="text/css">
	.header_text
	{
		font-family:Verdana;
		font-size:12px;
		color:white;
	}
</style>
<table border="0" cellSpacing="0" cellPadding="0" width="100%" background="/bitrix/images/top_bar_fill.gif" bgColor="black" height="25">
	<tbody><tr>
		<td class="header_text">&nbsp;Bitrix Site Manager Virtual Lab</td>
		<td id="timerTD" align="right"><font class="header_text">Time left: <b>103</b> min&nbsp;</font></td>
	</tr>
</tbody></table>
<script>
    var o = 176;
    function dec_timer() {
        if (o > 0) {
            document.getElementById('timerTD').innerHTML = "<font class=header_text>Time left: <b>" + o + "</b> min&nbsp;</font>";
            o--;
            window.setTimeout(dec_timer, 60000);
        }
        else
            document.location = "http://demo.bitrixsoft.com/feedback.php";
    }
    dec_timer();
</script>
	<table class="adm-main-wrap">
		<tbody><tr>
			
		</tr>
		<tr>
		
			<td class="adm-workarea-wrap adm-workarea-wrap-top">
				<div style="opacity: 1;" id="adm-workarea" class="adm-workarea adm-workarea-page">
<div id="main_navchain" class="adm-navchain">
<a class="adm-navchain-item" href="/bitrix/admin/index.php?lang=en"><span class="adm-navchain-item-text adm-navchain-item-desktop">Desktop</span></a><span id="bx_admin_chain_delimiter_" class="adm-navchain-item"><span class="adm-navchain-delimiter"></span></span><a id="bx_admin_chain_item_global_menu_services" class="adm-navchain-item" href="javascript:void(0)"><span class="adm-navchain-item-text">Services</span></a><span id="bx_admin_chain_delimiter_global_menu_services" class="adm-navchain-item"><span class="adm-navchain-delimiter"></span></span><a id="bx_admin_chain_item_menu_webforms" class="adm-navchain-item" href="javascript:void(0)"><span class="adm-navchain-item-text">Web Forms</span></a><span id="bx_admin_chain_delimiter_menu_webforms" class="adm-navchain-item"><span class="adm-navchain-delimiter"></span></span><a class="adm-navchain-item" href="form_list.php?lang=en"><span class="adm-navchain-item-text">Manage Forms</span></a></div>
<script type="text/javascript">new BX.COpener({ 'DIV': 'bx_admin_chain_delimiter_', 'ACTIVE_CLASS': 'adm-navchain-item-active', 'MENU_URL': '/bitrix/admin/get_start_menu.php?skip_recent=Y&lang=en' }); new BX.COpener({ 'DIV': 'bx_admin_chain_item_global_menu_services', 'ACTIVE_CLASS': 'adm-navchain-item-active', 'MENU_URL': '/bitrix/admin/get_start_menu.php?skip_recent=Y&lang=en&mode=chain&admin_mnu_menu_id=global_menu_services' }); new BX.COpener({ 'DIV': 'bx_admin_chain_delimiter_global_menu_services', 'ACTIVE_CLASS': 'adm-navchain-item-active', 'MENU_URL': '/bitrix/admin/get_start_menu.php?skip_recent=Y&lang=en&mode=chain&admin_mnu_menu_id=global_menu_services' }); new BX.COpener({ 'DIV': 'bx_admin_chain_item_menu_webforms', 'ACTIVE_CLASS': 'adm-navchain-item-active', 'MENU_URL': '/bitrix/admin/get_start_menu.php?skip_recent=Y&lang=en&mode=chain&admin_mnu_menu_id=menu_webforms' }); new BX.COpener({ 'DIV': 'bx_admin_chain_delimiter_menu_webforms', 'ACTIVE_CLASS': 'adm-navchain-item-active', 'MENU_URL': '/bitrix/admin/get_start_menu.php?skip_recent=Y&lang=en&mode=chain&admin_mnu_menu_id=menu_webforms' });</script>

		<h1 id="adm-title" class="adm-title">New form<a class="adm-fav-link" title="Add to favorites" onclick="BX.adminFav.titleLinkClick(this, 0, '')" href="javascript:void(0)"></a><a id="navchain-link" title="Link to the current page" href="/bitrix/admin/form_edit.php"></a></h1>
	
<div style="top: -15px; position: relative;" class="adm-info-message-wrap">
	<div class="adm-info-message">
	<span class="required">ATTENTION! Use <a href="/bitrix/admin/sysupdate.php">SiteUpdate</a> technology to get the latest product version.<br></span>
	This is trial version of Bitrix Site Manager product.		Evaluation period expires in <span class="required"><b>30</b></span> days.
		You can purchase the full version of Bitrix Site Manager from the <a href="http://www.bitrixsoft.com/buy/">http://www.bitrixsoft.com/buy/</a> page.
	</div>
</div>
<div class="adm-detail-toolbar"><span style="position: absolute;"></span>
	<a id="btn_list" class="adm-detail-toolbar-btn" title="Form list" href="/bitrix/admin/form_list.php?lang=en"><span class="adm-detail-toolbar-btn-l"></span><span class="adm-detail-toolbar-btn-text">List</span><span class="adm-detail-toolbar-btn-r"></span></a>
<script type="text/javascript"> if (window.BXHotKeys !== undefined) { BXHotKeys.Add("", "var d=BX(\'btn_list\'); if (d) location.href = d.href;", 8, '\"List\" button', 0); } </script></div>

<div class="adm-info-message-wrap adm-info-message-red">
	<div class="adm-info-message">
		<div class="adm-info-message-title">Error writing to the database</div>
		Error! Please fill in the "Name" field.<br>
<br>

		<div class="adm-info-message-icon"></div>
	</div>
</div>
<script>
    function formSubmit() {
        return oForm.serializeForm();
    }
</script>
<form onsubmit="return formSubmit();" encType="multipart/form-data" method="POST" name="form1" action="/bitrix/admin/form_edit.php">
<input id="sessid" name="sessid" value="43f42b1d578079bebc1244b5dd164ba6" type="hidden"><input name="ID" value="0" type="hidden">
<input name="lang" value="en" type="hidden">
<input name="FORM_STRUCTURE" value="" type="hidden">
<div id="tabControl_layout" class="adm-detail-block">
	<div id="tabControl_tabs" class="adm-detail-tabs-block adm-detail-tabs-block-pin">
<span id="tab_cont_edit1" class="adm-detail-tab" title="Parameter settings ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit1');">Properties</span><span id="tab_cont_edit2" class="adm-detail-tab" title="Form description ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit2');">Description</span><span id="tab_cont_edit5" class="adm-detail-tab" title="Main form template ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit5');">Form template</span><span id="tab_cont_edit7" class="adm-detail-tab" title="Result adding restrictions ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit7');">Restrictions</span><span id="tab_cont_edit4" class="adm-detail-tab" title="Event identifiers ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit4');">Statistics</span><span id="tab_cont_editcrm" class="adm-detail-tab adm-detail-tab-active" title="CRM Connection Parameters ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('editcrm');">CRM</span><span id="tab_cont_edit6" class="adm-detail-tab adm-detail-tab-last" title="Group rights for this form ( Ctrl+Alt+Q ) " onclick="tabControl.SelectTab('edit6');">Access</span><div id="tabControl_expand_link" class="adm-detail-title-setting" title="Expand all tabs into one page" onclick="tabControl.ToggleTabs();"><span class="adm-detail-title-setting-btn adm-detail-title-expand"></span></div>	<div class="adm-detail-pin-btn-tabs" title="Pin bar" onclick="tabControl.ToggleFix('top')"></div></div>
	<div class="adm-detail-content-wrap">

<div style="display: none;" id="edit1" class="adm-detail-content">
	<div class="adm-detail-title">Parameter settings</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit1_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
	<tr class="adm-detail-required-field">
		<td class="adm-detail-content-cell-l" width="40%">Name:</td>
		<td class="adm-detail-content-cell-r" width="60%"><input name="NAME" maxLength="255" value="" size="60" type="text"></td>
	</tr>
		<tr>
		<td class="adm-detail-content-cell-l">Sorting:</td>
		<td class="adm-detail-content-cell-r"><input name="C_SORT" maxLength="18" value="100" size="5" type="text"></td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">Menu items<br>in admin section:</td>
		<td class="adm-detail-content-cell-r">
			<table style="width: 0%;" border="0" cellSpacing="1" cellPadding="2">				<tbody><tr>
					<td width="0%" noWrap="">English</td>
					<td><input name="MENU_en" value="" size="30" type="text"></td>
				</tr>
							</tbody></table></td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l" vAlign="top">Form sites:</td>
		<td class="adm-detail-content-cell-r">
			<div class="adm-list">


					<div class="adm-list-item">
				<div class="adm-list-control"><input id="s1" class="adm-designed-checkbox" name="arSITE[]" value="s1" CHECKED="" type="checkbox"><label class="adm-designed-checkbox-label" title="" for="s1"></label></div>
				<div class="adm-list-label"><label for="s1">[<a class="tablebodylink" href="/bitrix/admin/site_edit.php?LID=s1&amp;lang=en">s1</a>]&nbsp;Default site</label></div>
			</div>
			</div></td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">Send form results by email:</td>
		<td class="adm-detail-content-cell-r">
			<input id="mail_check" class="adm-designed-checkbox" name="USE_MAIL_TEMPLATE" type="checkbox"><label class="adm-designed-checkbox-label" title="" for="mail_check"></label>
			[<a href="/bitrix/admin/message_admin.php?find_type_id=FORM_FILLING_SIMPLE_FORM_xcLe3E4U&amp;set_filter=Y">template list</a>]
		</td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">Submit button text:</td>
		<td class="adm-detail-content-cell-r"><input name="BUTTON" maxLength="255" value="Save" size="30" type="text"></td>
	</tr>

	<tr>
		<td class="adm-detail-content-cell-l">Use CAPTCHA:</td>
		<td class="adm-detail-content-cell-r"><input id="USE_CAPTCHA" class="adm-designed-checkbox" name="USE_CAPTCHA" value="Y" type="checkbox"><label class="adm-designed-checkbox-label" title="" for="USE_CAPTCHA"></label></td>
	</tr>

			</tbody>
		</table>
	</div>
</div>

<div style="display: none;" id="edit2" class="adm-detail-content">
	<div class="adm-detail-title">Form description</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit2_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
	<tr>
		<td class="adm-detail-content-cell-l" width="40%">Image:</td>
		<td class="adm-detail-content-cell-r" width="60%"> <span class="adm-input-file"><span>Add file</span><input class="typefile adm-designed-file" name="IMAGE_ID" size="20" type="file"></span><span class="bx-input-file-desc"></span><br><img border="0" alt="" src="" width="1" height="1"></td>
	</tr>
		<tr>
		<td colSpan="2" align="center">
				<script>
				    top.onChangeInputType = window.onChangeInputType = function (editorName) {
				        if (window['changeType_' + editorName] && typeof window['changeType_' + editorName] == 'function')
				            window['changeType_' + editorName]();
				        else
				            return setTimeout(function () { onChangeInputType(editorName); }, 100);
				    }
		</script>
		<div class="bx-ed-type-selector">
						<span class="bx-ed-type-selector-item"><input id="bxed_FORM_DESCRIPTION_text" onclick="onChangeInputType('FORM_DESCRIPTION');" name="FORM_DESCRIPTION_TYPE" value="text" CHECKED="checked" type="radio"><label for="bxed_FORM_DESCRIPTION_text">Text</label></span>

			<span class="bx-ed-type-selector-item"><input id="bxed_FORM_DESCRIPTION_html" onclick="onChangeInputType('FORM_DESCRIPTION');" name="FORM_DESCRIPTION_TYPE" value="html" type="radio"><label for="bxed_FORM_DESCRIPTION_html">HTML</label></span>

			<span class="bx-ed-type-selector-item"><input id="bxed_FORM_DESCRIPTION_editor" onclick="onChangeInputType('FORM_DESCRIPTION');" name="FORM_DESCRIPTION_TYPE" value="html" type="radio"><label for="bxed_FORM_DESCRIPTION_editor">Visual Editor</label></span>
					</div>
		<script>
		    BX.ready(
				function () {
				    window.changeType_FORM_DESCRIPTION = function (bSave) {
				        var
							pOptText = BX("bxed_FORM_DESCRIPTION_text"),
							pOptHtml = BX("bxed_FORM_DESCRIPTION_html"),
							pOptEditor = BX("bxed_FORM_DESCRIPTION_editor");

				        var curType = pOptEditor.checked ? 'editor' : 'text';
				        if (pOptHtml && pOptHtml.checked)
				            curType = 'html';

				        // Editor
				        var el = BX("bxed_FORM_DESCRIPTION");
				        if (pOptEditor.checked && el.style.display != "none") {
				            var onEditorInit = function (pMainObj) {
				                pMainObj.SetContent(pMainObj.PreparseHeaders(el.value));
				                pMainObj.Show(true);
				                pMainObj.LoadContent();
				            }

				            el.style.display = "none";
				            if (!el.pMainObj)
				                el.pMainObj = new BXHTMLEditor("FORM_DESCRIPTION", onEditorInit);
				            else
				                onEditorInit(el.pMainObj);
				        }
				        else if (!pOptEditor.checked && el.style.display == "none") {
				            el.pMainObj.Show(false);
				            el.pMainObj.SaveContent(true);
				            el.style.display = "";
				        }

				        // Save choice
				        if (bSave !== false) {
				            BX.ajax.get('/bitrix/admin/fileman_manage_settings.php?sessid=43f42b1d578079bebc1244b5dd164ba6&target=text_type&edname=FORM_DESCRIPTION&key=&type=' + curType);
				        }
				    };


				    var pOptEditor = BX("bxed_FORM_DESCRIPTION_editor");
				    if (pOptEditor) {
				        BX.addCustomEvent(pOptEditor.form, 'onAutoSaveRestore', function (ob, data) {
				            var pOptEditor = BX("bxed_FORM_DESCRIPTION_editor");

				            setTimeout(function () {
				                if (pOptEditor.checked) {
				                    var pMainObj = GLOBAL_pMainObj['FORM_DESCRIPTION'];
				                    if (pMainObj && pMainObj.bShowed) {
				                        pMainObj.SetContent(data[pMainObj.name]);
				                        pMainObj.LoadContent();
				                    }
				                }
				            }, 100);
				        });
				    }
				}
			);
		</script>
			<script>
			    function onContextMenu_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnContextMenu(e); }
			    function onClick_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnClick(e); }
			    function onDblClick_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnDblClick(e); }
			    function onMouseUp_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnMouseUp(e); }
			    function onDragDrop_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnDragDrop(e); }
			    function onKeyPress_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnKeyPress(e); }
			    function onKeyDown_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnKeyDown(e); }
			    function onPaste_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].OnPaste(e); }

			    function OnSubmit_FORM_DESCRIPTION(e) { GLOBAL_pMainObj['FORM_DESCRIPTION'].onSubmit(e); }

			    function OnDispatcherEvent_pDocument_FORM_DESCRIPTION(e) { pBXEventDispatcher.OnEvent(GLOBAL_pMainObj['FORM_DESCRIPTION'].pDocument, e); }
			    function OnDispatcherEvent_pEditorDocument_FORM_DESCRIPTION(e) { pBXEventDispatcher.OnEvent(GLOBAL_pMainObj['FORM_DESCRIPTION'].pEditorDocument, e); }
	</script>
			<textarea style="width: 100%; height: 350px;" id="bxed_FORM_DESCRIPTION" class="typearea" wrap="virtual" name="FORM_DESCRIPTION"></textarea>
				<script>
				    var relPath = "/";
				    var ar_FORM_DESCRIPTION_taskbars = {};
				    ar_FORM_DESCRIPTION_taskbars["BXPropertiesTaskbar"] = true; ar_FORM_DESCRIPTION_taskbars["BXSnippetsTaskbar"] = true; var ar_FORM_DESCRIPTION_toolbars = false;
				    window.ar_FORM_DESCRIPTION_config = { 'bUseOnlyDefinedStyles': true, 'bFromTextarea': true, 'bDisplay': false, 'bWithoutPHP': true, 'arTaskbars': ['BXPropertiesTaskbar', 'BXSnippetsTaskbar'], 'height': '450', 'site': 'en', 'arAdditionalParams': [], 'limit_php_access': false, 'light_mode': false, 'toolbarConfig': false, 'use_advanced_php_parser': 'Y', 'ar_entities': 'umlya,greek,other', 'spellCheckFirstClient': 'Y', 'usePspell': 'N', 'useCustomSpell': 'Y', 'allowRenderComp2': false, 'renderComponents': false, 'TEMPLATE': { 'ID': 'eshop_app', 'NAME': 'E-Shop Mobile App', 'STYLES': '', 'STYLES_TITLE': false }, 'body_class': '', 'body_id': '' }; // editor-config
		</script>
		<script>
		    //Array of settings
		    if (!window.SETTINGS)
		        SETTINGS = {};

		    SETTINGS['FORM_DESCRIPTION'] = {};

		    SETTINGS['FORM_DESCRIPTION'].showTooltips4Components = true;
		    SETTINGS['FORM_DESCRIPTION'].visualEffects = true;

		    window.comp2_dialog_size = { width: '650', height: '450' };
</script>
			<script>
			    var
					arBXTemplates = [{ 'value': '.default', 'name': 'Default template' }, { 'value': 'eshop_app', 'name': 'E-Shop Mobile App' }, { 'value': 'learning', 'name': 'E-learning template 9.1.0' }, { 'value': 'desktop_app', 'name': 'Desktop Application' }, { 'value': 'furniture_gray', 'name': 'Fixed' }],
					BXSite = "",
					BXLang = "en",
					styleList_render_style = true,
					limit_php_access = false,
					lca = false,
					lightMode = false,
					spellcheck_js_v = "1378477355",
					BX_PERSONAL_ROOT = "/bitrix";

			    window.limit_php_access = top.limit_php_access = limit_php_access;
			    window.lightMode = top.lightMode = lightMode;
			    window.lca = top.lca = lca;
			    window.BXLang = top.BXLang = BXLang;
			    window.BXSite = top.BXSite = BXSite;
			    window.BX_PERSONAL_ROOT = top.BX_PERSONAL_ROOT = BX_PERSONAL_ROOT;
			</script>
			<script type="text/javascript" src="/bitrix/admin/fileman_js.php?lang=en&amp;v=1378477296"></script>
<script type="text/javascript" src="/bitrix/admin/fileman_common_js.php?s=ems_12.5.3"></script>
				<script type="text/javascript" src="/bitrix/js/main/popup_menu.js?v=1378477335"></script>
					<div style="display: none;" id="FORM_DESCRIPTION_object" class="bxedmain-cont"><table style="display: none;" id="FORM_DESCRIPTION_pFrame" class="bxedmainframe dim100x100">
					<tbody><tr style="height: 1%;"><td style="width: 100%; border-bottom-color: rgb(128, 128, 128) !important; border-bottom-width: 1px !important; border-bottom-style: solid !important; display: none;" id="FORM_DESCRIPTION_toolBarSet0" colSpan="2"></td></tr>
					<tr>
						<td style="width: 0%; border-right-color: rgb(128, 128, 128) !important; border-right-width: 1px !important; border-right-style: solid !important; display: none;" id="FORM_DESCRIPTION_toolBarSet1"></td>
						<td style="padding: 0px !important; width: 4000px;" vAlign="top">
							<table class="dim100x100">
								<tbody><tr>
									<td id="FORM_DESCRIPTION_cEditor" class="bx-ceditor"></td>
									<td style="width: 0%; display: none;" id="FORM_DESCRIPTION_taskBarSet2" class="bxedtaskbarset">
									<table>
										<tbody><tr><td class="bx-move-col-v" rowSpan="3"><img src="/bitrix/images/1.gif"></td><td style="height: 26px;"></td></tr>
										<tr><td style="vertical-align: top;"></td></tr>
										<tr><td class="bx-taskbar-tabs"></td></tr>
									</tbody></table>
									</td>
								</tr>
								<tr style="height: 0%; display: none;">
									<td id="FORM_DESCRIPTION_taskBarSet3" colSpan="2">
										<table>
											<tbody><tr><td class="bx-move-col-h"><img src="/bitrix/images/1.gif"></td></tr>
											<tr><td style="height: 26px;"></td></tr>
											<tr><td style="background: rgb(244, 244, 244) !important; vertical-align: top;"></td></tr>
											<tr><td class="bx-taskbar-tabs"></td></tr>
										</tbody></table>
									</td>
								</tr>
							</tbody></table>
						</td>
					</tr>
					<tr id="bx-css-tt"><td id="FORM_DESCRIPTION_taskBarTabs" class="tasktabcell" colSpan="2"></td></tr>
				</tbody></table>
			</div>
<script>
    BX.loadCSS('/bitrix/admin/htmleditor2/editor.css');
    var bEd = BX("bxed_FORM_DESCRIPTION_editor");
    if (bEd && !bEd.checked)
        BX("FORM_DESCRIPTION_object").style.display = "none";
</script>
		</td>
	</tr>
	

			</tbody>
		</table>
	</div>
</div>

<div style="display: none;" id="edit5" class="adm-detail-content">
	<div class="adm-detail-title">Main form template</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit5_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
	<tr>
		<td colSpan="2">
			<input id="USE_DEFAULT_TEMPLATE_Y" onclick="BX.hide(BX('form_tpl_editor'))" name="USE_DEFAULT_TEMPLATE" value="Y" CHECKED="" type="radio"> <label for="USE_DEFAULT_TEMPLATE_Y">Use default form template</label><br>
			<input id="USE_DEFAULT_TEMPLATE_N" onclick="BX.show(BX('form_tpl_editor'))" name="USE_DEFAULT_TEMPLATE" value="N" type="radio"> <label for="USE_DEFAULT_TEMPLATE_N">Use customized form template</label>
		</td>
	</tr>
<script>
    var _global_newinput_counter = 0;
    var _global_newanswer_counter = 0;
    var _global_BX_UTF = true;
</script><script src="/bitrix/js/form/form_info.js?1378477335"></script><script>
                                                                            var arrInputObjects = [];


                                                                            var __arr_input_types = ['text', 'textarea', 'radio', 'checkbox', 'dropdown', 'multiselect', 'date', 'image', 'file', 'email', 'url', 'password'];
                                                                            var __arr_input_types_titles = ['Text', 'Textarea', 'Radio Buttons', 'Checkbox', 'Dropdown list', 'Listbox', 'Date', 'Image', 'File', 'Email', 'WWW address', 'Password'];

                                                                            var __arr_api_methods = ['ShowFormTitle', 'ShowFormDescription', 'ShowFormErrors', 'ShowFormNote', 'ShowFormImage', 'ShowInputCaption', 'ShowRequired', 'ShowDateFormat', 'ShowInputCaptionImage', 'ShowCaptcha', 'ShowCaptchaField', 'ShowCaptchaImage', 'ShowSubmitButton', 'ShowApplyButton', 'ShowResetButton', 'ShowResultStatus', 'ShowResultStatusForm'];

                                                                            var __arr_api_methods_params = {
                                                                                ShowFormTitle: ['CSS_STYLE'],
                                                                                ShowFormDescription: ['CSS_STYLE'],
                                                                                ShowFormErrors: [],
                                                                                ShowFormNote: [],
                                                                                ShowFormImage: ['ALIGN', 'MAX_HEIGHT', 'MAX_WIDTH', 'ENLARGE_SHOW', 'ENLARGE_TITLE', 'HSPACE', 'VSPACE', 'BORDER'],
                                                                                ShowInputCaption: ['FIELD_SID', 'CSS_STYLE'],
                                                                                ShowRequired: [],
                                                                                ShowDateFormat: ['CSS_STYLE'],
                                                                                ShowInputCaptionImage: ['FIELD_SID', 'ALIGN', 'MAX_HEIGHT', 'MAX_WIDTH', 'ENLARGE_SHOW', 'ENLARGE_TITLE', 'HSPACE', 'VSPACE', 'BORDER'],
                                                                                ShowCaptcha: [],
                                                                                ShowCaptchaField: [],
                                                                                ShowCaptchaImage: [],
                                                                                ShowSubmitButton: ['CAPTION', 'CSS_STYLE'],
                                                                                ShowApplyButton: ['CAPTION', 'CSS_STYLE'],
                                                                                ShowResetButton: ['CAPTION', 'CSS_STYLE'],
                                                                                ShowResultStatus: ['NOT_SHOW_CSS'],
                                                                                ShowResultStatusForm: []
                                                                            };

                                                                            __arr_api_methods_params_captions = {
                                                                                CSS_STYLE: 'Style',
                                                                                ALIGN: 'Alignment',
                                                                                MAX_HEIGHT: 'Maximum height (px)',
                                                                                MAX_WIDTH: 'Maximum width (px)',
                                                                                ENLARGE_SHOW: 'Enlarge?',
                                                                                ENLARGE_TITLE: 'Enlarge link title',
                                                                                HSPACE: 'Hspace (px)',
                                                                                VSPACE: 'Vspace (px)',
                                                                                BORDER: 'Border (px)',
                                                                                FIELD_SID: 'String identifier',
                                                                                CAPTION: 'Caption',
                                                                                NOT_SHOW_CSS: 'Do not use status CSS class'
                                                                            }

                                                                            var __arr_api_methods_title = ['Form title', 'Form description', 'Form errors', 'Form response message', 'Form image', 'Input field caption', '"Required" sign', 'Date format', 'Input field image', 'CAPTCHA fields', 'CAPTCHA input field', 'CAPTCHA image', '"Send" button', '"Apply" button', '"Cancel" button', 'Result status', 'Result status change'];

                                                                            var __arr_field_titles = { FIELD_SID: 'String identifier', CAPTION_UNFORM: 'Question text', isHTMLCaption: 'Question text uses HTML?', isRequired: 'Required?', type: 'Field type', structure: 'Answers', inResultsTable: 'Show in HTML results table?', inExcelTable: 'Show in Excel results table?' };

                                                                            var oForm = new CFormInfo(arrInputObjects);

                                                                            var __arr_messages = {
                                                                                FORM_TASKBAR_CFORM: 'New form fields',
                                                                                FORM_TASKBAR_CFORMOUTPUT: 'Existing form fields',
                                                                                FORM_TASKBAR_API: 'Additional elements',
                                                                                FORM_METHOD_HAS_NO_PARAMS: 'Element has no any properties',
                                                                                FORM_FIELD_WIDTH_VAL: 'columns',
                                                                                FORM_FIELD_HEIGHT_VAL: 'rows',
                                                                                FORM_ANSWER_VAL: 'answer values',
                                                                                FORM_SORT_VAL: 'sorting',
                                                                                FORM_DEF_VAL: 'selected',
                                                                                FORM_FIELD_DEF_VAL: 'default value',
                                                                                FORM_FIELD_SIZE_VAL: 'size',
                                                                                FORM_FIELD_MULTIPLE_WARNING: 'This field has a mixed answer type. Use question edit form to change its structure.'
                                                                            }
</script><script src="/bitrix/js/form/form_taskbar.js?1378477335"></script>
	<tr>
		<td colSpan="2"><div style="display: none;" id="form_tpl_editor">
		<script>
		    var relPath = "/";
		    var ar_FORM_TEMPLATE_taskbars = {};
		    ar_FORM_TEMPLATE_taskbars["BXFormElementsTaskbar"] = true; ar_FORM_TEMPLATE_taskbars["BXPropertiesTaskbar"] = true; var ar_FORM_TEMPLATE_toolbars = {}; ar_FORM_TEMPLATE_toolbars["standart"] = true; ar_FORM_TEMPLATE_toolbars["style"] = true; ar_FORM_TEMPLATE_toolbars["formating"] = true; ar_FORM_TEMPLATE_toolbars["source"] = true; ar_FORM_TEMPLATE_toolbars["template"] = true; ar_FORM_TEMPLATE_toolbars["table"] = true;
		    window.ar_FORM_TEMPLATE_config = { 'site': 's1', 'templateID': 'furniture_gray', 'bUseOnlyDefinedStyles': true, 'bWithoutPHP': false, 'arToolbars': ['standart', 'style', 'formating', 'source', 'template', 'table'], 'arTaskbars': ['BXFormElementsTaskbar', 'BXPropertiesTaskbar'], 'toolbarConfig': false, 'sBackUrl': '', 'fullscreen': false, 'width': '100%', 'height': '500', 'limit_php_access': false, 'light_mode': false, 'use_advanced_php_parser': 'Y', 'ar_entities': 'umlya,greek,other', 'spellCheckFirstClient': 'Y', 'usePspell': 'N', 'useCustomSpell': 'Y', 'allowRenderComp2': false, 'renderComponents': false, 'TEMPLATE': { 'ID': 'furniture_gray', 'NAME': 'Fixed', 'STYLES': '﻿img {border:0 none;}  h1, h2, h3, h4, h5, h6 { 	font-family: Arial, Helvetica,sans-serif;  	margin:1.3em 0 1em; 	font-weight:normal; 	line-height:1.2; }  h1 { font-size:200%; margin:0 0 1em; } h2 { font-size:160%; } h3 { font-size:140%; } h4 { font-size:140%; } h5 { font-size:120%; } h6 { font-size:100%; }  hr, .hr  { 	border-top:1px solid; 	display:block; 	font-size:1px; 	height:1px; 	line-height:1px; 	margin:12px 0; 	overflow:hidden; 	padding:0; }  #workarea ol li, #workarea ul li { margin: 0.6em 0; } #workarea ul { list-style-type: disc; }', 'STYLES_TITLE': false }, 'body_class': '', 'body_id': '' }; // editor-config
		</script>
		<script>
		    //Array of settings
		    if (!window.SETTINGS)
		        SETTINGS = {};

		    SETTINGS['FORM_TEMPLATE'] = {};

		    SETTINGS['FORM_TEMPLATE'].showTooltips4Components = true;
		    SETTINGS['FORM_TEMPLATE'].visualEffects = true;

		    window.comp2_dialog_size = { width: '650', height: '450' };
</script>
			<div style="width: 100%; height: 500px;" id="FORM_TEMPLATE_object" class="bxedmain-cont"><table style="position: static;" id="FORM_TEMPLATE_pFrame" class="bxedmainframe dim100x100">
					<tbody><tr style="height: 1%;"><td style="width: 100%; border-bottom-color: rgb(128, 128, 128) !important; border-bottom-width: 1px !important; border-bottom-style: solid !important;" id="FORM_TEMPLATE_toolBarSet0" class="bxedtoolbarset" colSpan="2"><table class="bxed-toolbar-inner" cellSpacing="0" cellPadding="0"><tbody><tr><td style="width: 10px;"><table style="width: 0%; height: 20px; z-index: 200;" class="bx-toolbar-tbl"><tbody><tr style="display: none;"><td class="bxedtoolbartitle" noWrap=""><table class="bxedtoolbartitletext"><tbody><tr><td style="padding: 0px 1px 1px 8px;" width="99%" noWrap="">Common</td><td width="0%">&nbsp;</td><td style="padding: 0px 3px; cursor: default;" id="title_x_0.8146542860785275" width="1%"><img class="iconkit_c bx-toolbar-x" src="/bitrix/images/1.gif"></td></tr></tbody></table></td></tr><tr><td class="bxedtoolbar"><table style="height: 22px;" class="bxedtoolbaricons"><tbody><tr style='background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><td style="width: 0%; display: block; cursor: move;"><div style="background-position: -317px -96px; width: 12px; height: 25px;" class="iconkit_c" title="Common"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Fullscreen" class="bxedtbutton" title="Fullscreen" alt="Fullscreen" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Settings" class="bxedtbutton" title="Settings" alt="Settings" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Cut" class="bxedtbutton" title="Cut" alt="Cut" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Copy" class="bxedtbutton" title="Copy" alt="Copy" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Paste" class="bxedtbutton" title="Paste" alt="Paste" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_pasteword" class="bxedtbutton" title="Paste from Word" alt="Paste from Word" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_pastetext" class="bxedtbutton" title="Paste as plain text" alt="Paste as plain text" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_SelectAll" class="bxedtbutton" title="Select All" alt="Select All" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Undo" class="bxedtbutton" title="Undo" alt="Undo" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Redo" class="bxedtbutton" title="Redo" alt="Redo" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(75, 75, 111); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif"); background-color: rgb(255, 198, 120);' id="bx_btn_borders" class="bxedtbutton" title="Show table borders" alt="Show table borders" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_table" class="bxedtbutton" title="Insert table" alt="Insert table" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_anchor" class="bxedtbutton" title="Anchor" alt="Anchor" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_CreateLink" class="bxedtbutton" title="Hyperlink" alt="Hyperlink" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_deletelink" class="bxedtbutton" title="Remove link" alt="Remove link" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_image" class="bxedtbutton" title="Image" alt="Image" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_SpecialChar" class="bxedtbutton" title="Insert Special Char" alt="Insert Special Char" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_page_break" class="bxedtbutton" title="Insert page break (for Print)" alt="Insert page break (for Print)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_break_tag" class="bxedtbutton" title="Insert page delimiter <BREAK />" alt="Insert page delimiter <BREAK />" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_insert_flash" class="bxedtbutton" title="Insert Flash" alt="Insert Flash" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 100%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'> </td><td style="width: 0%; display: block;"><div style="background-position: -334px -96px; width: 5px; height: 25px;" class="iconkit_c" title="Common"></div></td></tr></tbody></table></td></tr></tbody></table></td><td></td></tr></tbody></table><table class="bxed-toolbar-inner" cellSpacing="0" cellPadding="0"><tbody><tr><td style="width: 10px;"><table style="width: 0%; height: 20px; z-index: 200;" class="bx-toolbar-tbl"><tbody><tr style="display: none;"><td class="bxedtoolbartitle" noWrap=""><table class="bxedtoolbartitletext"><tbody><tr><td style="padding: 0px 1px 1px 8px;" width="99%" noWrap="">Style</td><td width="0%">&nbsp;</td><td style="padding: 0px 3px; cursor: default;" id="Td1" width="1%"><img class="iconkit_c bx-toolbar-x" src="/bitrix/images/1.gif"></td></tr></tbody></table></td></tr><tr><td class="bxedtoolbar"><table style="height: 22px;" class="bxedtoolbaricons"><tbody><tr style='background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><td style="width: 0%; display: block; cursor: move;"><div style="background-position: -317px -96px; width: 12px; height: 25px;" class="iconkit_c" title="Style"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div style="width: 130px; display: none;" class="bx-list"><img class="bx-list-over" src="/bitrix/images/1.gif" width="1" height="1"><table style="width: 130px;"><tbody><tr><td><div style="width: 106px;" class="bx-listtitle">(Style)</div></td><td class="bx-listbutton">&nbsp;</td></tr></tbody></table></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div style="width: 75px;" class="bx-list"><img class="bx-list-over" src="/bitrix/images/1.gif" width="1" height="1"><table style="width: 75px;"><tbody><tr><td><div style="width: 51px;" class="bx-listtitle">(Format)</div></td><td class="bx-listbutton">&nbsp;</td></tr></tbody></table></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div style="width: 75px;" class="bx-list"><img class="bx-list-over" src="/bitrix/images/1.gif" width="1" height="1"><table style="width: 75px;"><tbody><tr><td><div style="width: 51px;" class="bx-listtitle">(Font)</div></td><td class="bx-listbutton">&nbsp;</td></tr></tbody></table></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div style="width: 75px;" class="bx-list"><img class="bx-list-over" src="/bitrix/images/1.gif" width="1" height="1"><table style="width: 75px;"><tbody><tr><td><div style="width: 51px;" class="bx-listtitle">(Size)</div></td><td class="bx-listbutton">&nbsp;</td></tr></tbody></table></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Bold" class="bxedtbutton" title="Bold (Ctrl + B)" alt="Bold (Ctrl + B)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Italic" class="bxedtbutton" title="Italic (Ctrl + I)" alt="Italic (Ctrl + I)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Underline" class="bxedtbutton" title="Underline (Ctrl + U)" alt="Underline (Ctrl + U)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Strike" class="bxedtbutton" title="Strikethrough" alt="Strikethrough" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_RemoveFormat" class="bxedtbutton" title="Remove format" alt="Remove format" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 100%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'> </td><td style="width: 0%; display: block;"><div style="background-position: -334px -96px; width: 5px; height: 25px;" class="iconkit_c" title="Style"></div></td></tr></tbody></table></td></tr></tbody></table></td><td style="width: 10px;"><table style="width: 0%; height: 20px; z-index: 200;" class="bx-toolbar-tbl"><tbody><tr style="display: none;"><td class="bxedtoolbartitle" noWrap=""><table class="bxedtoolbartitletext"><tbody><tr><td style="padding: 0px 1px 1px 8px;" width="99%" noWrap="">Site template</td><td width="0%">&nbsp;</td><td style="padding: 0px 3px; cursor: default;" id="Td2" width="1%"><img class="iconkit_c bx-toolbar-x" src="/bitrix/images/1.gif"></td></tr></tbody></table></td></tr><tr><td class="bxedtoolbar"><table style="height: 22px;" class="bxedtoolbaricons"><tbody><tr style='background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><td style="width: 0%; display: block; cursor: move;"><div style="background-position: -317px -96px; width: 12px; height: 25px;" class="iconkit_c" title="Site template"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div style="width: 150px;" class="bx-list"><img class="bx-list-over" src="/bitrix/images/1.gif" width="1" height="1"><table style="width: 150px;"><tbody><tr><td><div style="width: 126px;" class="bx-listtitle">Fixed</div></td><td class="bx-listbutton">&nbsp;</td></tr></tbody></table></div></td><td style='width: 100%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'> </td><td style="width: 0%; display: block;"><div style="background-position: -334px -96px; width: 5px; height: 25px;" class="iconkit_c" title="Site template"></div></td></tr></tbody></table></td></tr></tbody></table></td><td></td></tr></tbody></table><table class="bxed-toolbar-inner" cellSpacing="0" cellPadding="0"><tbody><tr><td style="width: 10px;"><table style="width: 0%; height: 20px; z-index: 200;" class="bx-toolbar-tbl"><tbody><tr style="display: none;"><td class="bxedtoolbartitle" noWrap=""><table class="bxedtoolbartitletext"><tbody><tr><td style="padding: 0px 1px 1px 8px;" width="99%" noWrap="">Formatting</td><td width="0%">&nbsp;</td><td style="padding: 0px 3px; cursor: default;" id="Td3" width="1%"><img class="iconkit_c bx-toolbar-x" src="/bitrix/images/1.gif"></td></tr></tbody></table></td></tr><tr><td class="bxedtoolbar"><table style="height: 22px;" class="bxedtoolbaricons"><tbody><tr style='background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><td style="width: 0%; display: block; cursor: move;"><div style="background-position: -317px -96px; width: 12px; height: 25px;" class="iconkit_c" title="Formatting"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_InsertHorizontalRule" class="bxedtbutton" title="Insert Horizontal line" alt="Insert Horizontal line" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_JustifyLeft" class="bxedtbutton" title="Left" alt="Left" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_JustifyCenter" class="bxedtbutton" title="Center" alt="Center" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_JustifyRight" class="bxedtbutton" title="Right" alt="Right" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_JustifyFull" class="bxedtbutton" title="Justify" alt="Justify" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_InsertOrderedList" class="bxedtbutton" title="Numbered list" alt="Numbered list" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_InsertUnorderedList" class="bxedtbutton" title="Unordered list" alt="Unordered list" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Outdent" class="bxedtbutton" title="Outdent text(Shift + Tab)" alt="Outdent text(Shift + Tab)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_Indent" class="bxedtbutton" title="Indent text(Tab)" alt="Indent text(Tab)" src="/bitrix/images/1.gif" width="20" height="20"></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bxseparator"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bx-ed-colorpicker"><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_BackColor" class="bxedtbutton" title="Background Color" src="/bitrix/images/1.gif" width="1" height="1"></div></td><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'><div class="bx-ed-colorpicker"><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_ForeColor" class="bxedtbutton" title="Foreground Color" src="/bitrix/images/1.gif" width="1" height="1"></div></td><td style='width: 100%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg.gif");'> </td><td style="width: 0%; display: block;"><div style="background-position: -334px -96px; width: 5px; height: 25px;" class="iconkit_c" title="Formatting"></div></td></tr></tbody></table></td></tr></tbody></table></td><td></td></tr></tbody></table></td></tr>
					<tr>
						<td style="width: 0%; vertical-align: top; border-right-color: rgb(128, 128, 128) !important; border-right-width: 1px !important; border-right-style: solid !important;" id="FORM_TEMPLATE_toolBarSet1" class="bxedtoolbarset"><table border="0" cellSpacing="0" cellPadding="0"><tbody><tr><td style="vertical-align: top;"><table border="0" cellSpacing="0" cellPadding="0"><tbody><tr><td style="width: 10px;"><table style="width: 0%; height: 20px; z-index: 200;" class="bx-toolbar-tbl"><tbody><tr style="display: none;"><td class="bxedtoolbartitle" noWrap=""><table class="bxedtoolbartitletext"><tbody><tr><td style="padding: 0px 1px 1px 8px;" width="99%" noWrap="">Edit mode</td><td width="0%">&nbsp;</td><td style="padding: 0px 3px; cursor: default;" id="Td4" width="1%"><img class="iconkit_c bx-toolbar-x" src="/bitrix/images/1.gif"></td></tr></tbody></table></td></tr><tr><td class="bxedtoolbar"><table style="height: 22px;" class="bxedtoolbaricons"><tbody><tr><td style="width: 0%; height: 0%; cursor: move;"><div style="background-position: -291px -100px; width: 25px; height: 12px;" class="iconkit_c" title="Edit mode"></div></td></tr><tr><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg_vert.gif");'><img style='border: 1px solid rgb(75, 75, 111); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif"); background-color: rgb(255, 198, 120);' id="bx_btn_wysiwyg" class="bxedtbutton" title="WYSIWYG editing mode" alt="WYSIWYG editing mode" src="/bitrix/images/1.gif" width="20" height="20"></td></tr><tr><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg_vert.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_source" class="bxedtbutton" title="Code editing mode" alt="Code editing mode" src="/bitrix/images/1.gif" width="20" height="20"></td></tr><tr><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg_vert.gif");'><img style='border: 1px solid rgb(228, 226, 220); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif");' id="bx_btn_split" class="bxedtbutton" title="Split editing mode" alt="Split editing mode" src="/bitrix/images/1.gif" width="20" height="20"></td></tr><tr><td style='width: 0%; background-image: url("/bitrix/images/fileman/htmledit2/toolbarbg_vert.gif");'><img style='border: 1px solid rgb(75, 75, 111); background-image: url("/bitrix/images/fileman/htmledit2/_global_iconkit.gif"); background-color: rgb(255, 198, 120);' id="bx_btn_Wrap" class="bxedtbutton bxedtbutton-disabled" title="Wrap" disabled="" alt="Wrap" src="/bitrix/images/1.gif" width="20" height="20"></td></tr><tr><td><img style="background-position: -291px -113px; width: 25px; height: 5px;" class="iconkit_c" title="Edit mode" src="/bitrix/images/1.gif" width="1" height="1"></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table></td>
						<td style="padding: 0px !important; width: 4000px;" vAlign="top">
							<table class="dim100x100">
								<tbody><tr>
									<td id="FORM_TEMPLATE_cEditor" class="bx-ceditor"><iframe style="height: 100%; display: block;" id="ed_FORM_TEMPLATE" class="bx-editor-iframe" src="javascript:void(0)"></iframe><div style="width: 100%; height: 100%; overflow: auto; display: none; overflow-x: hidden; overflow-y: auto;"><textarea style="height: 100%; display: none;" class="bxeditor-textarea"></textarea></div></td>
									<td style="width: 0%; height: 100%;" id="FORM_TEMPLATE_taskBarSet2" class="bxedtaskbarset">
									<table style="width: 200px; height: 100%;">
										<tbody><tr><td class="bx-move-col-v" rowSpan="3"><img src="/bitrix/images/1.gif"></td><td style="height: 26px;"><table class="bxedtaskbartitletext" __bxtagname="_taskbar_default"><tbody><tr><td style="width: 1%; padding-left: 2px;" class="def"><div></div></td><td class="head_text" noWrap="">Form elements</td><td class="head-button-menu" title="Actions"><div></div></td><td style="width: 20px;" class="head-button-hide" title="Hide"><div></div></td></tr></tbody></table></td></tr>
										<tr><td style="vertical-align: top;"><div class="bxedtaskbar-scroll bxedtaskbar-scroll-tmp"><div style="width: 100%; height: 100%;" class="bxedtaskbar"><table class="bxgroupblock0" cellSpacing="0" cellPadding="0" width="100%" __bxgroup0="__cformelements"><tbody><tr><td style='width: 20px; background-image: url("/bitrix/images/fileman/htmledit2/new_taskbars/part_l.gif");' class="pluscell0"><div id="FORM_TEMPLATE_BXTaskBar_Group_plus_cformelements" class="tskbr_common bx_btn_tabs_plus_small"></div></td><td style='width: 900px; background-image: url("/bitrix/images/fileman/htmledit2/new_taskbars/part_l.gif");' class="titlecell0">New&nbsp;form&nbsp;fields</td></tr><tr style="display: none;" id="FORM_TEMPLATE_BXTaskBar_Group_cformelements"><td class="datacell0" colSpan="2"><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__text"><tbody><tr><td id="element_text" class="iconcell1"><img id="bxid_112123" src="/bitrix/images/form/visual/form_text.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Text</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__textarea"><tbody><tr><td id="element_textarea" class="iconcell1"><img id="bxid_333831" src="/bitrix/images/form/visual/form_textarea.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Textarea</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__radio"><tbody><tr><td id="element_radio" class="iconcell1"><img id="bxid_510794" src="/bitrix/images/form/visual/form_radio.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Radio Buttons</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__checkbox"><tbody><tr><td id="element_checkbox" class="iconcell1"><img id="bxid_894462" src="/bitrix/images/form/visual/form_checkbox.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Checkbox</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__dropdown"><tbody><tr><td id="element_dropdown" class="iconcell1"><img id="bxid_303365" src="/bitrix/images/form/visual/form_dropdown.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Dropdown list</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__multiselect"><tbody><tr><td id="element_multiselect" class="iconcell1"><img id="bxid_936137" src="/bitrix/images/form/visual/form_multiselect.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Listbox</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__date"><tbody><tr><td id="element_date" class="iconcell1"><img id="bxid_462300" src="/bitrix/images/form/visual/form_date.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Date</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__image"><tbody><tr><td id="element_image" class="iconcell1"><img id="bxid_940320" src="/bitrix/images/form/visual/form_image.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Image</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__file"><tbody><tr><td id="element_file" class="iconcell1"><img id="bxid_442246" src="/bitrix/images/form/visual/form_file.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">File</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__email"><tbody><tr><td id="element_email" class="iconcell1"><img id="bxid_944711" src="/bitrix/images/form/visual/form_email.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Email</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__url"><tbody><tr><td id="element_url" class="iconcell1"><img id="bxid_917975" src="/bitrix/images/form/visual/form_url.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">WWW address</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__password"><tbody><tr><td id="element_password" class="iconcell1"><img id="bxid_906916" src="/bitrix/images/form/visual/form_password.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Password</td></tr></tbody></table></td></tr></tbody></table><table class="bxgroupblock0" cellSpacing="0" cellPadding="0" width="100%" __bxgroup0="__cformoutputapimethods"><tbody><tr><td style='width: 20px; background-image: url("/bitrix/images/fileman/htmledit2/new_taskbars/part_l.gif");' class="pluscell0"><div id="FORM_TEMPLATE_BXTaskBar_Group_plus_cformoutputapimethods" class="tskbr_common bx_btn_tabs_plus_small"></div></td><td style='width: 900px; background-image: url("/bitrix/images/fileman/htmledit2/new_taskbars/part_l.gif");' class="titlecell0">Additional&nbsp;elements</td></tr><tr style="display: none;" id="FORM_TEMPLATE_BXTaskBar_Group_cformoutputapimethods"><td class="datacell0" colSpan="2"><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowFormTitle"><tbody><tr><td id="element_ShowFormTitle" class="iconcell1"><img id="bxid_160353" src="/bitrix/images/form/visual/form_api_showformtitle.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Form title</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowFormDescription"><tbody><tr><td id="element_ShowFormDescription" class="iconcell1"><img id="bxid_159720" src="/bitrix/images/form/visual/form_api_showformdescription.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Form description</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowFormErrors"><tbody><tr><td id="element_ShowFormErrors" class="iconcell1"><img id="bxid_978593" src="/bitrix/images/form/visual/form_api_showformerrors.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Form errors</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowFormNote"><tbody><tr><td id="element_ShowFormNote" class="iconcell1"><img id="bxid_199916" src="/bitrix/images/form/visual/form_api_showformnote.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Form response message</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowFormImage"><tbody><tr><td id="element_ShowFormImage" class="iconcell1"><img id="bxid_582162" src="/bitrix/images/form/visual/form_api_showformimage.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Form image</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowInputCaption"><tbody><tr><td id="element_ShowInputCaption" class="iconcell1"><img id="bxid_102621" src="/bitrix/images/form/visual/form_api_showinputcaption.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Input field caption</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowRequired"><tbody><tr><td id="element_ShowRequired" class="iconcell1"><img id="bxid_821392" src="/bitrix/images/form/visual/form_api_showrequired.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">"Required" sign</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowDateFormat"><tbody><tr><td id="element_ShowDateFormat" class="iconcell1"><img id="bxid_384685" src="/bitrix/images/form/visual/form_api_showdateformat.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Date format</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowInputCaptionImage"><tbody><tr><td id="element_ShowInputCaptionImage" class="iconcell1"><img id="bxid_236514" src="/bitrix/images/form/visual/form_api_showinputcaptionimage.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Input field image</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowCaptcha"><tbody><tr><td id="element_ShowCaptcha" class="iconcell1"><img id="bxid_34143" src="/bitrix/images/form/visual/form_api_showcaptcha.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">CAPTCHA fields</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowCaptchaField"><tbody><tr><td id="element_ShowCaptchaField" class="iconcell1"><img id="bxid_68275" src="/bitrix/images/form/visual/form_api_showcaptchafield.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">CAPTCHA input field</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowCaptchaImage"><tbody><tr><td id="element_ShowCaptchaImage" class="iconcell1"><img id="bxid_385613" src="/bitrix/images/form/visual/form_api_showcaptchaimage.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">CAPTCHA image</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowSubmitButton"><tbody><tr><td id="element_ShowSubmitButton" class="iconcell1"><img id="bxid_700311" src="/bitrix/images/form/visual/form_api_showsubmitbutton.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">"Send" button</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowApplyButton"><tbody><tr><td id="element_ShowApplyButton" class="iconcell1"><img id="bxid_340309" src="/bitrix/images/form/visual/form_api_showapplybutton.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">"Apply" button</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowResetButton"><tbody><tr><td id="element_ShowResetButton" class="iconcell1"><img id="bxid_957963" src="/bitrix/images/form/visual/form_api_showresetbutton.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">"Cancel" button</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowResultStatus"><tbody><tr><td id="element_ShowResultStatus" class="iconcell1"><img id="bxid_218099" src="/bitrix/images/form/visual/form_api_showresultstatus.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Result status</td></tr></tbody></table><table class="bxgroupblock1" title="Drag and drop the icon to the work area or double-click it" __bxgroup1="__ShowResultStatusForm"><tbody><tr><td id="element_ShowResultStatusForm" class="iconcell1"><img id="bxid_777316" src="/bitrix/images/form/visual/form_api_showresultstatusform.gif" width="32" height="16"></td><td style="padding-left: 5px;" class="titlecell1">Result status change</td></tr></tbody></table></td></tr></tbody></table><div class="bxedtaskbar-root"></div></div></div></td></tr>
										<tr><td style="display: none;" class="bx-taskbar-tabs"></td></tr>
									</tbody></table>
									</td>
								</tr>
								<tr style="height: 0%;">
									<td id="FORM_TEMPLATE_taskBarSet3" colSpan="2">
										<table style="width: 100%; height: 160px;">
											<tbody><tr><td class="bx-move-col-h"><img src="/bitrix/images/1.gif"></td></tr>
											<tr><td style="height: 26px;"><table class="bxedtaskbartitletext" __bxtagname="_taskbar_properties"><tbody><tr><td style="width: 1%; padding-left: 2px;" class="def"><div class="tb_icon bxed-taskbar-icon-properties"></div></td><td class="head_text" noWrap="">Properties</td><td class="head-button-menu" title="Actions"><div></div></td><td style="width: 20px;" class="head-button-hide" title="Hide"><div></div></td></tr></tbody></table></td></tr>
											<tr><td style="background: rgb(244, 244, 244) !important; vertical-align: top;"><div class="bxedtaskbar-scroll bxedtaskbar-scroll-tmp"><div style="width: 100%; height: 100%;" class="bxedtaskbar bx-props-taskbar"><table style="width: 100%;"><tbody><tr><td style="height: 0%;" class="bxproptagspath"></td></tr><tr><td style="height: 100%;" class="bxtaskbarprops" vAlign="top"><br><span style="padding-left: 15px;">Choose an element to view its properties.</span></td></tr></tbody></table></div></div></td></tr>
											<tr><td style="display: none;" class="bx-taskbar-tabs"></td></tr>
										</tbody></table>
									</td>
								</tr>
							</tbody></table>
						</td>
					</tr>
					<tr id="Tr1"><td id="FORM_TEMPLATE_taskBarTabs" class="tasktabcell" colSpan="2"><div class="bxed-tasktab-cnt"><span id="tab_tb_68492" class="bxed-tasktab bxed-tasktab-pushed" title="Form elements"><i class="tasktab-left"></i><span class="tasktab-center"><span class="tasktab-icon bxed-taskbar-icon-undefined" unselectable="on"></span><span class="tasktab-text" unselectable="on">Form elements</span></span><i class="tasktab-right"></i></span><span id="tab_tb_6507" class="bxed-tasktab bxed-tasktab-pushed" title="Properties"><i class="tasktab-left"></i><span class="tasktab-center"><span class="tasktab-icon bxed-taskbar-icon-properties" unselectable="on"></span><span class="tasktab-text" unselectable="on">Properties</span></span><i class="tasktab-right"></i></span></div></td></tr>
				</tbody></table>
			</div>
<script>
    BX.loadCSS('/bitrix/admin/htmleditor2/editor.css');
    var bEd = BX("bxed_FORM_TEMPLATE_editor");
    if (bEd && !bEd.checked)
        BX("FORM_TEMPLATE_object").style.display = "none";
</script>
		<input id="bxed_FORM_TEMPLATE" name="FORM_TEMPLATE" value="" type="hidden">	<script>
		                                                                           	    function onContextMenu_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnContextMenu(e); }
		                                                                           	    function onClick_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnClick(e); }
		                                                                           	    function onDblClick_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnDblClick(e); }
		                                                                           	    function onMouseUp_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnMouseUp(e); }
		                                                                           	    function onDragDrop_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnDragDrop(e); }
		                                                                           	    function onKeyPress_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnKeyPress(e); }
		                                                                           	    function onKeyDown_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnKeyDown(e); }
		                                                                           	    function onPaste_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].OnPaste(e); }

		                                                                           	    function OnSubmit_FORM_TEMPLATE(e) { GLOBAL_pMainObj['FORM_TEMPLATE'].onSubmit(e); }

		                                                                           	    function OnDispatcherEvent_pDocument_FORM_TEMPLATE(e) { pBXEventDispatcher.OnEvent(GLOBAL_pMainObj['FORM_TEMPLATE'].pDocument, e); }
		                                                                           	    function OnDispatcherEvent_pEditorDocument_FORM_TEMPLATE(e) { pBXEventDispatcher.OnEvent(GLOBAL_pMainObj['FORM_TEMPLATE'].pEditorDocument, e); }
	</script>
				<script>
				    BX.ready(function () {
				        BX.showWait();
				        BX("bxed_FORM_TEMPLATE").pMainObj = new BXHTMLEditor("FORM_TEMPLATE");
				    });
			</script>
			<script>
			    oBXEditorUtils.addPHPParser(oForm.PHPParser);
			    oBXEditorUtils.addTaskBar('BXFormElementsTaskbar', 2, "Form elements", []);
			    if (window.arButtons['Optimize'])
			        arButtons['Optimize'][1].hideCondition = function (pMainObj) { return pMainObj.name == "FORM_TEMPLATE"; }
</script>
		</div></td>
	</tr>
	
			</tbody>
		</table>
	</div>
</div>

<div style="display: none;" id="edit7" class="adm-detail-content">
	<div class="adm-detail-title">Result adding restrictions</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit7_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
	<script>
	    function change_restrictions() {
	        var use_rest = document.form1.USE_RESTRICTIONS.checked;
	        if (use_rest) {
	            document.form1.RESTRICT_USER.disabled = false;
	            document.form1.RESTRICT_TIME.disabled = false;
	            document.form1.RESTRICT_TIME_MULTIPLYER.disabled = false;
	        }
	        else {
	            document.form1.RESTRICT_USER.disabled = true;
	            document.form1.RESTRICT_TIME.disabled = true;
	            document.form1.RESTRICT_TIME_MULTIPLYER.disabled = true;
	        }
	    }

	    jsUtils.addEvent(window, 'load', change_restrictions);
	</script>
	<tr>
		<td colSpan="2">
			
<div class="adm-info-message-wrap">
	<div class="adm-info-message">
Attention! All form restrictions work only for authorized users.
	</div>
</div>
			<input id="USE_RESTRICTIONS" class="adm-designed-checkbox" onclick="change_restrictions()" name="USE_RESTRICTIONS" value="Y" type="checkbox"><label class="adm-designed-checkbox-label" title="" for="USE_RESTRICTIONS"></label>
			<label for="USE_RESTRICTIONS">Use restrictions</label>
		</td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l" width="40%">Maximum number of results for one user: </td>
		<td class="adm-detail-content-cell-r" width="60%"><input name="RESTRICT_USER" value="0" size="10" type="text"></td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">Minimum time period between results: </td>
		<td class="adm-detail-content-cell-r"><input name="RESTRICT_TIME" value="0" size="10" type="text">
			<select disabled="" name="RESTRICT_TIME_MULTIPLYER">
				<option selected="selected" value="1">sec</option>
				<option value="60">min</option>
				<option value="3600">hr</option>
				<option value="86400">day</option>
			</select></td>
	</tr>
	
			</tbody>
		</table>
	</div>
</div>

<div style="display: none;" id="edit4" class="adm-detail-content">
	<div class="adm-detail-title">Event identifiers</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit4_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
	<tr>
		<td class="adm-detail-content-cell-l" width="40%">event1:</td>
		<td class="adm-detail-content-cell-r" width="60%"><input name="STAT_EVENT1" maxLength="255" value="form" size="30" type="text"></td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">event2:</td>
		<td class="adm-detail-content-cell-r"><input name="STAT_EVENT2" maxLength="255" value="" size="30" type="text"><br>event1, event2: event type identifiers</td>
	</tr>
	<tr>
		<td class="adm-detail-content-cell-l">event3:</td>
		<td class="adm-detail-content-cell-r"><input name="STAT_EVENT3" maxLength="255" value="" size="30" type="text"><br>event3: auxiliary parameter</td>
	</tr>

			</tbody>
		</table>
	</div>
</div>

<div style="display: block;" id="editcrm" class="adm-detail-content">
	<div class="adm-detail-title">CRM Connection Parameters</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="editcrm_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
<tr>
	<td colSpan="2" align="center">
<div class="adm-info-message-wrap">
	<div class="adm-info-message">
The web form must be saved before connection parameters can be entered.
	</div>
</div>
</td>
</tr>
	
			</tbody>
		</table>
	</div>
</div>

<div style="display: none;" id="edit6" class="adm-detail-content">
	<div class="adm-detail-title">Group rights for this form</div>
	<div style="height: auto; overflow-y: visible;" class="adm-detail-content-item-block">
		<table style="opacity: 1;" id="edit6_edit_table" class="adm-detail-content-table edit-table">
			<tbody>
		<tr>
		<td class="adm-detail-content-cell-l" width="40%">[<a title="Modify group parameters" href="/bitrix/admin/group_edit.php?ID=2&amp;lang=en">2</a>] All users (with non-authorized users):</td>
		<td class="adm-detail-content-cell-r" width="60%"><select style="width: 80%;" id="PERMISSION_2" name="PERMISSION_2"><option selected="" value="0">default - [10] Complete web form</option><option value="1">[1] Deny access</option><option value="10">[10] Complete web form</option><option value="15">[15] own result view/edit</option><option value="25">[25] View web form parameters</option><option value="30">[30] Full access</option></select></td>
	</tr>
		<tr>
		<td class="adm-detail-content-cell-l" width="40%">[<a title="Modify group parameters" href="/bitrix/admin/group_edit.php?ID=3&amp;lang=en">3</a>] Users allowed to vote for rating:</td>
		<td class="adm-detail-content-cell-r" width="60%"><select style="width: 80%;" id="PERMISSION_3" name="PERMISSION_3"><option selected="" value="0">default - [10] Complete web form</option><option value="1">[1] Deny access</option><option value="10">[10] Complete web form</option><option value="15">[15] own result view/edit</option><option value="25">[25] View web form parameters</option><option value="30">[30] Full access</option></select></td>
	</tr>
		<tr>
		<td class="adm-detail-content-cell-l" width="40%">[<a title="Modify group parameters" href="/bitrix/admin/group_edit.php?ID=4&amp;lang=en">4</a>] Users allowed to vote for authority:</td>
		<td class="adm-detail-content-cell-r" width="60%"><select style="width: 80%;" id="PERMISSION_4" name="PERMISSION_4"><option selected="" value="0">default - [10] Complete web form</option><option value="1">[1] Deny access</option><option value="10">[10] Complete web form</option><option value="15">[15] own result view/edit</option><option value="25">[25] View web form parameters</option><option value="30">[30] Full access</option></select></td>
	</tr>
		<tr>
		<td class="adm-detail-content-cell-l" width="40%">[<a title="Modify group parameters" href="/bitrix/admin/group_edit.php?ID=5&amp;lang=en">5</a>] Edit personal profile. Cache control:</td>
		<td class="adm-detail-content-cell-r" width="60%"><select style="width: 80%;" id="PERMISSION_5" name="PERMISSION_5"><option selected="" value="0">default - [10] Complete web form</option><option value="1">[1] Deny access</option><option value="10">[10] Complete web form</option><option value="15">[15] own result view/edit</option><option value="25">[25] View web form parameters</option><option value="30">[30] Full access</option></select></td>
	</tr>
	
			</tbody>
		</table>
	</div>
</div>
<div style="height: 57px; display: block;" class="adm-detail-content-btns-wrap"></div><div style="left: 322px; width: 1241px;" id="tabControl_buttons_div" class="adm-detail-content-btns-wrap bx-fixed-bottom adm-detail-content-btns-fixed"><div class="adm-detail-content-btns"><div class="adm-detail-pin-btn" title="Unpin bar" onclick="tabControl.ToggleFix('bottom')"></div><input class="adm-btn-save" title="Save and go back to the list" name="save" value="Save" type="submit"><script type="text/javascript"> BXHotKeys.Add("", "var d=BX .findChild(document, {attribute: {\'name\': \'save\'}}, true );  if (d) d.click();", 9, '\"Save\" button in property editor', 0);</script><input title="Save and stay here" name="apply" value="Apply" type="submit"><script type="text/javascript">                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                BXHotKeys.Add("", "var d=BX .findChild(document, {attribute: {\'name\': \'apply\'}}, true );  if (d) d.click();", 19, '\"Apply\" button in property editor', 0);</script><input title="Don't save and go back to the list" onclick="                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    window.location = 'form_list.php?lang=en'" name="cancel" value="Cancel" type="button"><script type="text/javascript">                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                BXHotKeys.Add("", "var d=BX .findChild(document, {attribute: {\'name\': \'cancel\'}}, true );  if (d) d.click();", 20, '\"Cancel\" button in property editor', 0); </script></div></div>
</div></div>
<script type="text/javascript"> BXHotKeys.Add("Ctrl+Alt+81", "tabControl.NextTab();", 3, 'Switch tabs', 17); </script>

<input id="tabControl_active_tab" name="tabControl_active_tab" value="editcrm" type="hidden">

<script type="text/javascript">
    if (!window.tabControl || !BX.is_subclass_of(window.tabControl, BX.adminTabControl))
        window.tabControl = new BX.adminTabControl("tabControl", "tabControl_c4c9f5cd24119b949403c8ec32faa92b", [{ 'DIV': 'edit1' }, { 'DIV': 'edit2' }, { 'DIV': 'edit5' }, { 'DIV': 'edit7' }, { 'DIV': 'edit4' }, { 'DIV': 'editcrm' }, { 'DIV': 'edit6' }]);
    else if (!!window.tabControl)
        window.tabControl.PreInit(true);

    tabControl.ToggleFix('top');
</script>
</form>
<script type="text/javascript"> BXHotKeys.Add("Ctrl+Alt+75", "location.href=\'/bitrix/admin/hot_keys_list.php?lang=ru\';", 106, 'Open keyboard shortcuts management page', 18); BXHotKeys.Add("Ctrl+Alt+80", "BXHotKeys.ShowSettings();", 17, 'Page keyboard shortcuts', 14); BXHotKeys.Add("Ctrl+Alt+85", "location.href=\'/bitrix/admin/user_admin.php?lang=\'+phpVars.LANGUAGE_ID;", 139, 'Open user management page', 13);</script><script type="text/javascript">    var d = BX('bx-panel-hotkeys'); if (!d) d = BX.findChild(document, { attribute: { 'name': 'bx-panel-hotkeys' } }, true); if (d) d.title += ' ( Ctrl+Alt+P ) ';</script><script type="text/javascript">
    BXHotKeys.MesNotAssign = 'not assigned';
    BXHotKeys.MesClToChange = 'Click to edit';
    BXHotKeys.MesClean = 'Clear';
    BXHotKeys.MesBusy = 'This keyboard shortcut is already in use. Are you sure you want to reassign it?';
    BXHotKeys.MesClose = 'Close';
    BXHotKeys.MesSave = 'Save';
    BXHotKeys.MesSettings = 'Customize keyboard shortcuts';
    BXHotKeys.MesDefault = 'Default';
    BXHotKeys.MesDelAll = 'Delete all';
    BXHotKeys.MesDelConfirm = 'Are you sure you want to delete all keyboard shortcuts?';
    BXHotKeys.MesDefaultConfirm = 'Are you sure you want to reset all keyboard shortcuts to default values?';
    BXHotKeys.MesExport = 'Export';
    BXHotKeys.MesImport = 'Import';
    BXHotKeys.MesExpFalse = 'Cannot export keyboard shortcuts.';
    BXHotKeys.MesImpFalse = 'Cannot import keyboard shortcuts.';
    BXHotKeys.MesImpSuc = 'Keyboard shortcuts imported: ';
    BXHotKeys.MesImpHeader = 'Import Keyboard Shortcuts';
    BXHotKeys.MesFileEmpty = 'Please specify the source file to import keyboard shortcuts from.';
    BXHotKeys.MesDelete = 'Delete';
    BXHotKeys.MesChooseFile = 'Select file';
    BXHotKeys.uid = 1;
			</script>


<script type="text/javascript">
    BX.ready(function () { BX.adminInformer.Init(3); });
</script>				</div>			</td>		</tr>
		<tr class="adm-footer-wrap">
			<td class="adm-left-side-wrap"></td>
			<td class="adm-workarea-wrap">
			<table border="0" cellSpacing="0" cellPadding="0" width="100%">
				<tbody><tr>
					<td>Powered by <a href="http://www.bitrixsoft.com/">Bitrix Site Manager 12.5.11</a>. Copyright © 2002-2013 Bitrix, Inc.</td>
					<td align="right"><a href="http://www.bitrixsoft.com/">www.bitrixsoft.com</a>&nbsp;&nbsp;|&nbsp;&nbsp;<a class="adm-main-support-link" href="http://www.bitrixsoft.com/support/">Support</a></td>
				</tr>
			</tbody></table>
			</td>
		</tr>
	</tbody></table>


	<div style="display: none;" id="fav_cont_item" class="adm-favorites-main">
		<div class="adm-favorites-alignment">
			<div id="fav_dest_item" class="adm-favorites-center">
				<div style="display: inline-block;" id="fav_text_item">
					<div class="adm-favorites-text">Add to <b>Favorites</b></div>
					<div class="adm-favorites-description">Drag and drop an item here</div>
				</div>
				<div style="display: none;" id="fav_text_finish_item">
					<div class="adm-favorites-text">Added to <b>Favorites</b></div>
					<div class="adm-favorites-description"><a class="adm-favorites-description_link" onclick="BX.adminMenu.showFavorites(this);" href="javascript:void(0);">View Favorites</a></div>
				</div>
				<div style="display: none;" id="fav_text_error_item">
					<div class="adm-favorites-text">Error adding a link to favorites.</div>
				</div>
				<div class="adm-favorites-center-border-2"></div>
				<div class="adm-favorites-center-border-1"></div>
				<div id="fav_icon_finish_item" class="adm-favorites-check-icon"></div>
			</div>
		</div>
	</div>
	<div style="display: none;" id="fav_cont_fav" class="adm-favorites-main remove-favorites-main">
		<div class="adm-favorites-alignment">
			<div id="fav_dest_fav" class="adm-favorites-center">
				<div style="display: inline-block;" id="fav_text_fav">
					<div class="adm-favorites-text">Remove from <b>Favorites</b></div>
					<div class="adm-favorites-description">Drag and drop an item here</div>
				</div>
				<div style="display: none;" id="fav_text_finish_fav">
					<div class="adm-favorites-text">Removed from <b>Favorites</b></div>
				</div>
				<div style="display: none;" id="fav_text_error_fav">
					<div class="adm-favorites-text">Error removing from favorites.</div>
				</div>
				<div class="adm-favorites-center-border-2"></div>
				<div class="adm-favorites-center-border-1"></div>
				<div id="fav_icon_finish_fav" class="adm-favorites-check-icon"></div>
			</div>
		</div>
	</div>


<img src="/bitrix/images/1.gif" width="1" height="1"><iframe style="left: -1000px; top: -1000px; position: absolute; z-index: 9999;" class="bxedpopupframe" src="javascript:void(0)" frameBorder="no" scrolling="no"></iframe><iframe class="bxedpopupframe" src="javascript:void(0)" frameBorder="no" scrolling="no"></iframe><div style="left: -1000px; top: -1000px; visibility: hidden; position: absolute; z-index: 1500;" id="FORM_TEMPLATE__BXContextMenu" class="bx_ed_context_menu"><table cellSpacing="0" cellPadding="0"><tbody><tr><td class="popupmenu"><table id="FORM_TEMPLATE__BXContextMenu_items" cellSpacing="0" cellPadding="0"><tbody><tr><td></td></tr></tbody></table></td></tr></tbody></table></div><iframe style="left: -1000px; top: -1000px; visibility: hidden; position: absolute; z-index: 1495;" id="FORM_TEMPLATE__BXContextMenu_frame" src="javascript:void(0)"></iframe><div style="display: none;" class="visual_minimize"></div><div style="left: 316px; top: 48px; display: none;" id="admin-informer" class="adm-informer" onclick="return BX.adminInformer.OnInnerClick(event);">
	<div class="adm-informer-header">New notifications</div>
		<div style="display: block;" class="adm-informer-item adm-informer-item-green">
			<div class="adm-informer-item-title">
				CDN Web Accelerator
			</div>
			<div class="adm-informer-item-body">
				<div id="adm-informer-item-html-0" class="adm-informer-item-html">
					
				<div class="adm-informer-item-section">
					<span class="adm-informer-strong-text">Disabled.</span>
				</div>
				<div class="adm-informer-status-bar-block">
					<div style="width: 0%;" class="adm-informer-status-bar-indicator"></div>
					<div class="adm-informer-status-bar-text">0%</div>
				</div>
			
					<span class="adm-informer-icon"></span>
				</div>
				<div id="adm-informer-item-footer-0" class="adm-informer-item-footer">
				<a href="/bitrix/admin/bitrixcloud_cdn.php?lang=en">Enable acceleration</a>
				</div>
			</div>
		</div>
		<div style="display: block;" class="adm-informer-item adm-informer-item-blue">
			<div class="adm-informer-item-title">
				Security scanner
			</div>
			<div class="adm-informer-item-body">
				<div id="adm-informer-item-html-1" class="adm-informer-item-html">
					
<div class="adm-informer-item-section">
	<span class="adm-informer-item-l">
		<span>The system was last scanned log ago, or never at all.</span>
	</span>
</div>

					<span class="adm-informer-icon"></span>
				</div>
				<div id="adm-informer-item-footer-1" class="adm-informer-item-footer">
				<a href="/bitrix/admin/security_scanner.php?lang=en">Scan now</a>
				</div>
			</div>
		</div>
		<div style="display: block;" class="adm-informer-item adm-informer-item-gray">
			<div class="adm-informer-item-title">
				Updates
			</div>
			<div class="adm-informer-item-body">
				<div id="adm-informer-item-html-2" class="adm-informer-item-html">
					<span class="adm-informer-strong-text">Current version 12.5.11</span><br>Last updated on:<br>09.06.2013 06:17
					<span class="adm-informer-icon"></span>
				</div>
				<div id="adm-informer-item-footer-2" class="adm-informer-item-footer">
				<a href="/bitrix/admin/update_system.php?refresh=Y&amp;lang=en">Check for updates</a>
				</div>
			</div>
		</div>
		<div style="display: none;" class="adm-informer-item adm-informer-item-blue">
			<div class="adm-informer-item-title">
				Proactive Protection
			</div>
			<div class="adm-informer-item-body">
				<div id="adm-informer-item-html-3" class="adm-informer-item-html">
					
<div class="adm-informer-item-section">
	<span class="adm-informer-item-l">
		<span class="adm-informer-strong-text">Protection enabled.<br></span>
		<span>No intrusion attempts detected</span>
	</span>
</div>

					<span class="adm-informer-icon"></span>
				</div>
				<div id="adm-informer-item-footer-3" class="adm-informer-item-footer">
				<a href="/bitrix/admin/security_filter.php?lang=en">Configure protection</a>
				</div>
			</div>
		</div>
	<a hideFocus="true" id="adm-informer-footer" class="adm-informer-footer adm-informer-footer-collapsed" onclick="return BX.adminInformer.ToggleExtra();" href="javascript:void(0);">Show all (4) </a>
	<span class="adm-informer-arrow"></span>
</div><div style="left: 295px;" class="adm-resize-block"><div style="left: 295px;" class="adm-resizer-btn"></div></div><div style="left: 475px; top: 272px;" class="bx-session-message"><a class="bx-session-message-close" href="javascript:bxSession.Close()"></a>Your session has been terminated due to inactivity for 24 min. The new information on this page will not be saved. Please copy your data before closing or refreshing the page.</div>

    </div>
    </form>
</body>
</html>
