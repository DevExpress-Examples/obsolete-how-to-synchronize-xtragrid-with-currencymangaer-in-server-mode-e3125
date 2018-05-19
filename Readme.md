# (Obsolete) How to synchronize XtraGrid with CurrencyMangaer in Server Mode


<p>XtraGrid automatically synchronizes its focused row index and the CurrencyManager.Position property. However, the BindingContext does not create the CurrencyManager for Server Mode components (<a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataLinqEntityServerModeSourcetopic">EntityServerModeSource</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXpoXPServerCollectionSourcetopic">XPServerCollectionSource</a>, <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataLinqLinqServerModeSourcetopic">LinqServerModeSource</a>, etc.), because they are not collections.<br /><br />This example demonstrates how to work around this limitation. Binding to the focused row data is performed through a custom collection component that implements all interfaces necessary to support the WinForms data binding engine. This component uses GridView events to update the CurrencyManager position and obtain data items. <br /><br />The custom component allows you to bind editors to data at design time. This example uses the ServerModeGridProjects database created by the Grid Server Mode demo application shipped with our components.</p>

<br/>


