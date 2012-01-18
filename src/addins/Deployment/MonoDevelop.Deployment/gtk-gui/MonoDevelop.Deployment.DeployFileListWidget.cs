
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Deployment
{
	internal partial class DeployFileListWidget
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label labelFiles;
		private global::Gtk.ComboBox comboConfigs;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView fileList;
		private global::Gtk.HBox hbox2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Deployment.DeployFileListWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Deployment.DeployFileListWidget";
			// Container child MonoDevelop.Deployment.DeployFileListWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelFiles = new global::Gtk.Label ();
			this.labelFiles.Name = "labelFiles";
			this.labelFiles.Xalign = 0F;
			this.labelFiles.LabelProp = global::Mono.Unix.Catalog.GetString ("The following files will be included in the package:");
			this.hbox1.Add (this.labelFiles);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelFiles]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboConfigs = global::Gtk.ComboBox.NewText ();
			this.comboConfigs.Name = "comboConfigs";
			this.hbox1.Add (this.comboConfigs);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboConfigs]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.fileList = new global::Gtk.TreeView ();
			this.fileList.CanFocus = true;
			this.fileList.Name = "fileList";
			this.fileList.RulesHint = true;
			this.scrolledwindow1.Add (this.fileList);
			this.vbox2.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow1]));
			w5.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.comboConfigs.Changed += new global::System.EventHandler (this.OnComboConfigsChanged);
		}
	}
}
