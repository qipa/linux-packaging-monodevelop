// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.OptionPanels {
    
    internal partial class MaintenanceOptionsPanelWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.CheckButton checkInstr;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Ide.Gui.OptionPanels.MaintenanceOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Ide.Gui.OptionPanels.MaintenanceOptionsPanelWidget";
            // Container child MonoDevelop.Ide.Gui.OptionPanels.MaintenanceOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.checkInstr = new Gtk.CheckButton();
            this.checkInstr.CanFocus = true;
            this.checkInstr.Name = "checkInstr";
            this.checkInstr.Label = Mono.Unix.Catalog.GetString("Enable MonoDevelop Instrumentation");
            this.checkInstr.DrawIndicator = true;
            this.checkInstr.UseUnderline = true;
            this.vbox2.Add(this.checkInstr);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.checkInstr]));
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
