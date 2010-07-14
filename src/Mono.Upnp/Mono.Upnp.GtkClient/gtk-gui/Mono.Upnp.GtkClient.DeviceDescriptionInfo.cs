
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Upnp.GtkClient
{
	public partial class DeviceDescriptionInfo
	{
		private global::Gtk.Table table1;

		private global::Gtk.Label deviceType;

		private global::Gtk.Label friendlyName;

		private global::Gtk.VBox iconBox;

		private global::Gtk.Label label1;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.Label manufacturer;

		private global::Gtk.Label manufacturerUrl;

		private global::Gtk.Label modelName;

		private global::Gtk.Label modelNumber;

		private global::Gtk.Label modelUrl;

		private global::Gtk.Label serialNumber;

		private global::Gtk.Label udn;

		private global::Gtk.Label upc;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Upnp.GtkClient.DeviceDescriptionInfo
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Mono.Upnp.GtkClient.DeviceDescriptionInfo";
			// Container child Mono.Upnp.GtkClient.DeviceDescriptionInfo.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(11)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(10));
			this.table1.ColumnSpacing = ((uint)(10));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.deviceType = new global::Gtk.Label ();
			this.deviceType.Name = "deviceType";
			this.deviceType.Xalign = 0f;
			this.deviceType.LabelProp = "deviceType";
			this.deviceType.Selectable = true;
			this.table1.Add (this.deviceType);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.deviceType]));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.friendlyName = new global::Gtk.Label ();
			this.friendlyName.Name = "friendlyName";
			this.friendlyName.Xalign = 0f;
			this.friendlyName.LabelProp = "friendlyName";
			this.friendlyName.Selectable = true;
			this.table1.Add (this.friendlyName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.friendlyName]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.iconBox = new global::Gtk.VBox ();
			this.iconBox.Name = "iconBox";
			this.iconBox.Spacing = 6;
			this.table1.Add (this.iconBox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.iconBox]));
			w3.TopAttach = ((uint)(10));
			w3.BottomAttach = ((uint)(11));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1f;
			this.label1.Yalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Icons</b>");
			this.label1.UseMarkup = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.TopAttach = ((uint)(10));
			w4.BottomAttach = ((uint)(11));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1f;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>UPC</b>");
			this.label10.UseMarkup = true;
			this.table1.Add (this.label10);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label10]));
			w5.TopAttach = ((uint)(9));
			w5.BottomAttach = ((uint)(10));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1f;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Device Type</b>");
			this.label11.UseMarkup = true;
			this.table1.Add (this.label11);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.label11]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>UDN</b>");
			this.label2.UseMarkup = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1f;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Friendly Name</b>");
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.label3]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1f;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Manufacturer</b>");
			this.label4.UseMarkup = true;
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.label4]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1f;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Manufacturer URL</b>");
			this.label5.UseMarkup = true;
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.label5]));
			w10.TopAttach = ((uint)(4));
			w10.BottomAttach = ((uint)(5));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1f;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Model Name</b>");
			this.label6.UseMarkup = true;
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
			w11.TopAttach = ((uint)(5));
			w11.BottomAttach = ((uint)(6));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1f;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Model Number</b>");
			this.label7.UseMarkup = true;
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
			w12.TopAttach = ((uint)(6));
			w12.BottomAttach = ((uint)(7));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 1f;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Model URL</b>");
			this.label8.UseMarkup = true;
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.label8]));
			w13.TopAttach = ((uint)(7));
			w13.BottomAttach = ((uint)(8));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1f;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Serial Number</b>");
			this.label9.UseMarkup = true;
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.label9]));
			w14.TopAttach = ((uint)(8));
			w14.BottomAttach = ((uint)(9));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.manufacturer = new global::Gtk.Label ();
			this.manufacturer.Name = "manufacturer";
			this.manufacturer.Xalign = 0f;
			this.manufacturer.LabelProp = "manufacturer";
			this.manufacturer.Selectable = true;
			this.table1.Add (this.manufacturer);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.manufacturer]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.manufacturerUrl = new global::Gtk.Label ();
			this.manufacturerUrl.Name = "manufacturerUrl";
			this.manufacturerUrl.Xalign = 0f;
			this.manufacturerUrl.LabelProp = "manufacturerUrl";
			this.manufacturerUrl.Selectable = true;
			this.table1.Add (this.manufacturerUrl);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.manufacturerUrl]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.modelName = new global::Gtk.Label ();
			this.modelName.Name = "modelName";
			this.modelName.Xalign = 0f;
			this.modelName.LabelProp = "modelUrl";
			this.modelName.Selectable = true;
			this.table1.Add (this.modelName);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.modelName]));
			w17.TopAttach = ((uint)(5));
			w17.BottomAttach = ((uint)(6));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.modelNumber = new global::Gtk.Label ();
			this.modelNumber.Name = "modelNumber";
			this.modelNumber.Xalign = 0f;
			this.modelNumber.LabelProp = "modelNumber";
			this.modelNumber.Selectable = true;
			this.table1.Add (this.modelNumber);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.modelNumber]));
			w18.TopAttach = ((uint)(6));
			w18.BottomAttach = ((uint)(7));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.modelUrl = new global::Gtk.Label ();
			this.modelUrl.Name = "modelUrl";
			this.modelUrl.Xalign = 0f;
			this.modelUrl.LabelProp = "modelUrl";
			this.modelUrl.Selectable = true;
			this.table1.Add (this.modelUrl);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.modelUrl]));
			w19.TopAttach = ((uint)(7));
			w19.BottomAttach = ((uint)(8));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.serialNumber = new global::Gtk.Label ();
			this.serialNumber.Name = "serialNumber";
			this.serialNumber.Xalign = 0f;
			this.serialNumber.LabelProp = "serialNumber";
			this.serialNumber.Selectable = true;
			this.table1.Add (this.serialNumber);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.serialNumber]));
			w20.TopAttach = ((uint)(8));
			w20.BottomAttach = ((uint)(9));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.udn = new global::Gtk.Label ();
			this.udn.Name = "udn";
			this.udn.Xalign = 0f;
			this.udn.LabelProp = "udn";
			this.udn.Selectable = true;
			this.table1.Add (this.udn);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.udn]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.upc = new global::Gtk.Label ();
			this.upc.Name = "upc";
			this.upc.Xalign = 0f;
			this.upc.LabelProp = "upc";
			this.upc.Selectable = true;
			this.table1.Add (this.upc);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.upc]));
			w22.TopAttach = ((uint)(9));
			w22.BottomAttach = ((uint)(10));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
