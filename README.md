# Web Dashboard - How to navigate tabs using custom tab header buttons or set up a slide show
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/DXWebApplication1/Default.aspx)
* [slideshow.js](./CS/DXWebApplication1/Scripts/slideshow.js)
<!-- default file list end -->

<p>The following example shows how to navigate through tabs using our Web Forms Dashboard API, i.e. create some kind of slideshow. The main idea is the following:<br/>
1) Create custom header buttons using the approach from the <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ViewerApiExtensionOptions#js_DevExpress_Dashboard_ViewerApiExtensionOptions_onItemCaptionToolbarUpdated">onItemCaptionToolbarUpdated</a> documentation article.<br/>
2) Use our <a href="https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.Model.TabContainerItem">tab container API</a> to perform navigation and start/stop slideshow.
</p>

<br/>


