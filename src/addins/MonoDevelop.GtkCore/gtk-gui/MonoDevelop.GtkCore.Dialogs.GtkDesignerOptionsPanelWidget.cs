// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.GtkCore.Dialogs {
    
    
    public partial class GtkDesignerOptionsPanelWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.CheckButton checkSwitchLayout;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.GtkCore.Dialogs.GtkDesignerOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.GtkCore.Dialogs.GtkDesignerOptionsPanelWidget";
            // Container child MonoDevelop.GtkCore.Dialogs.GtkDesignerOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.checkSwitchLayout = new Gtk.CheckButton();
            this.checkSwitchLayout.CanFocus = true;
            this.checkSwitchLayout.Name = "checkSwitchLayout";
            this.checkSwitchLayout.Label = Mono.Unix.Catalog.GetString("Automatically switch to the \"GUI Builder\" layout when opening the designer");
            this.checkSwitchLayout.DrawIndicator = true;
            this.checkSwitchLayout.UseUnderline = true;
            this.vbox2.Add(this.checkSwitchLayout);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.checkSwitchLayout]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}
