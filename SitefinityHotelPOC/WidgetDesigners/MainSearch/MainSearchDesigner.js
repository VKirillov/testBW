Type.registerNamespace("SitefinityWebApp.WidgetDesigners.MainSearch");

SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner = function (element) {
    this._message = null;

    SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner.initializeBase(this, [element]);
}

SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {        
        var controlData = this._propertyEditor.get_control().Settings; /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI Message */
        jQuery(this.get_message()).val(controlData.Message);
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control().Settings;

        controlData.Message = jQuery(this.get_message()).val();
    },


    /* --------------------------------- properties -------------------------------------- */

    /* Message properties */
    get_message: function () { return this._message; }, 
    set_message: function (value) { this._message = value; }
}

SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner.registerClass('SitefinityWebApp.WidgetDesigners.MainSearch.MainSearchDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);

