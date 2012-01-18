
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.AspNet.Gui
{
	internal partial class AspNetConfigurationPanelWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label2;
		private global::Gtk.VBox vbox2;
		private global::Gtk.CheckButton disableCodeBehindGeneration;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.AspNet.Gui.AspNetConfigurationPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.AspNet.Gui.AspNetConfigurationPanelWidget";
			// Container child MonoDevelop.AspNet.Gui.AspNetConfigurationPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Code Generation");
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 18;
			this.label2.Name = "label2";
			this.hbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.disableCodeBehindGeneration = new global::Gtk.CheckButton ();
			this.disableCodeBehindGeneration.CanFocus = true;
			this.disableCodeBehindGeneration.Name = "disableCodeBehindGeneration";
			this.disableCodeBehindGeneration.Label = global::MonoDevelop.Core.GettextCatalog.GetString ("Disable automatic updating of CodeBehind partial classes");
			this.disableCodeBehindGeneration.DrawIndicator = true;
			this.disableCodeBehindGeneration.UseUnderline = true;
			this.vbox2.Add (this.disableCodeBehindGeneration);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.disableCodeBehindGeneration]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w4.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
