
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Projects
{
	internal partial class ApplyPolicyDialog
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.RadioButton radioCustom;
		private global::Gtk.Alignment boxCustom;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label2;
		private global::Gtk.ComboBox combPolicies;
		private global::Gtk.RadioButton radioFile;
		private global::Gtk.Alignment boxFile;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label3;
		private global::MonoDevelop.Components.FileEntry fileEntry;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label labelChangesTitle;
		private global::Gtk.Label labelChanges;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Projects.ApplyPolicyDialog
			this.Name = "MonoDevelop.Ide.Projects.ApplyPolicyDialog";
			this.Title = global::MonoDevelop.Core.GettextCatalog.GetString ("Apply Policies");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoDevelop.Ide.Projects.ApplyPolicyDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(12));
			// Container child vbox3.Gtk.Box+BoxChild
			this.radioCustom = new global::Gtk.RadioButton (global::MonoDevelop.Core.GettextCatalog.GetString ("Apply stock or custom policy set"));
			this.radioCustom.CanFocus = true;
			this.radioCustom.Name = "radioCustom";
			this.radioCustom.DrawIndicator = true;
			this.radioCustom.UseUnderline = true;
			this.radioCustom.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox3.Add (this.radioCustom);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.radioCustom]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.boxCustom = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.boxCustom.Name = "boxCustom";
			this.boxCustom.LeftPadding = ((uint)(42));
			// Container child boxCustom.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("Policy:");
			this.hbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.combPolicies = global::Gtk.ComboBox.NewText ();
			this.combPolicies.Name = "combPolicies";
			this.hbox1.Add (this.combPolicies);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.combPolicies]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.boxCustom.Add (this.hbox1);
			this.vbox3.Add (this.boxCustom);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.boxCustom]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.radioFile = new global::Gtk.RadioButton (global::MonoDevelop.Core.GettextCatalog.GetString ("Apply policies from file"));
			this.radioFile.CanFocus = true;
			this.radioFile.Name = "radioFile";
			this.radioFile.DrawIndicator = true;
			this.radioFile.UseUnderline = true;
			this.radioFile.Group = this.radioCustom.Group;
			this.vbox3.Add (this.radioFile);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.radioFile]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.boxFile = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.boxFile.Name = "boxFile";
			this.boxFile.LeftPadding = ((uint)(42));
			// Container child boxFile.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("File:");
			this.hbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fileEntry = new global::MonoDevelop.Components.FileEntry ();
			this.fileEntry.Name = "fileEntry";
			this.fileEntry.BrowserTitle = "Select Policy Set File";
			this.hbox2.Add (this.fileEntry);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fileEntry]));
			w9.Position = 1;
			this.boxFile.Add (this.hbox2);
			this.vbox3.Add (this.boxFile);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.boxFile]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hseparator1]));
			w12.Position = 4;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelChangesTitle = new global::Gtk.Label ();
			this.labelChangesTitle.Name = "labelChangesTitle";
			this.labelChangesTitle.Xalign = 0F;
			this.labelChangesTitle.LabelProp = global::MonoDevelop.Core.GettextCatalog.GetString ("The following policies will be set or replaced:");
			this.vbox3.Add (this.labelChangesTitle);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelChangesTitle]));
			w13.Position = 5;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelChanges = new global::Gtk.Label ();
			this.labelChanges.Name = "labelChanges";
			this.labelChanges.Xalign = 0F;
			this.vbox3.Add (this.labelChanges);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.labelChanges]));
			w14.Position = 6;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Internal child MonoDevelop.Ide.Projects.ApplyPolicyDialog.ActionArea
			global::Gtk.HButtonBox w16 = this.ActionArea;
			w16.Name = "dialog1_ActionArea";
			w16.Spacing = 10;
			w16.BorderWidth = ((uint)(5));
			w16.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w16 [this.buttonCancel]));
			w17.Expand = false;
			w17.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-apply";
			w16.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w16 [this.buttonOk]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 479;
			this.DefaultHeight = 258;
			this.Hide ();
			this.radioCustom.Toggled += new global::System.EventHandler (this.OnRadioCustomToggled);
			this.combPolicies.Changed += new global::System.EventHandler (this.OnCombPoliciesChanged);
			this.fileEntry.PathChanged += new global::System.EventHandler (this.OnFileEntryPathChanged);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}