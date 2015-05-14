
// This file has been generated by the GUI designer. Do not modify.
namespace Pinta.Effects
{
	public partial class LevelsDialog
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label labelInputHist;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Pinta.Gui.Widgets.HistogramWidget histogramInput;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label labelInput;
		
		private global::Gtk.HSeparator hseparator2;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.VBox vboxInputSpin;
		
		private global::Gtk.SpinButton spinInHigh;
		
		private global::Pinta.Gui.Widgets.ColorPanelWidget colorpanelInHigh;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Pinta.Gui.Widgets.ColorPanelWidget colorpanelInLow;
		
		private global::Gtk.SpinButton spinInLow;
		
		private global::Pinta.Gui.Widgets.ColorGradientWidget gradientInput;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label labelOutput;
		
		private global::Gtk.HSeparator hseparator3;
		
		private global::Gtk.HBox hbox9;
		
		private global::Pinta.Gui.Widgets.ColorGradientWidget gradientOutput;
		
		private global::Gtk.VBox vboxOutputSpin;
		
		private global::Gtk.SpinButton spinOutHigh;
		
		private global::Pinta.Gui.Widgets.ColorPanelWidget colorpanelOutHigh;
		
		private global::Gtk.SpinButton spinOutGamma;
		
		private global::Pinta.Gui.Widgets.ColorPanelWidget colorpanelOutMid;
		
		private global::Pinta.Gui.Widgets.ColorPanelWidget colorpanelOutLow;
		
		private global::Gtk.SpinButton spinOutLow;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Label labelOutputHist;
		
		private global::Gtk.HSeparator hseparator4;
		
		private global::Pinta.Gui.Widgets.HistogramWidget histogramOutput;
		
		private global::Gtk.HBox hboxBottom;
		
		private global::Gtk.Button buttonAuto;
		
		private global::Gtk.Button buttonReset;
		
		private global::Gtk.CheckButton checkRed;
		
		private global::Gtk.CheckButton checkGreen;
		
		private global::Gtk.Button buttonOk;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.CheckButton checkBlue;
		
		private global::Gtk.Button buttonDummy;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Pinta.Effects.LevelsDialog
			this.Events = ((global::Gdk.EventMask)(260));
			this.Name = "Pinta.Effects.LevelsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Levels Adjustment");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.SkipTaskbarHint = true;
			// Internal child Pinta.Effects.LevelsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Events = ((global::Gdk.EventMask)(1534));
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Events = ((global::Gdk.EventMask)(260));
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelInputHist = new global::Gtk.Label ();
			this.labelInputHist.Name = "labelInputHist";
			this.labelInputHist.LabelProp = global::Mono.Unix.Catalog.GetString ("Input Histogram");
			this.hbox2.Add (this.labelInputHist);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelInputHist]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.hbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.hseparator1]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.histogramInput = new global::Pinta.Gui.Widgets.HistogramWidget ();
			this.histogramInput.WidthRequest = 130;
			this.histogramInput.Events = ((global::Gdk.EventMask)(256));
			this.histogramInput.Name = "histogramInput";
			this.histogramInput.FlipHorizontal = true;
			this.histogramInput.FlipVertical = false;
			this.vbox2.Add (this.histogramInput);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.histogramInput]));
			w5.Position = 1;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w6.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Events = ((global::Gdk.EventMask)(36));
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelInput = new global::Gtk.Label ();
			this.labelInput.Name = "labelInput";
			this.labelInput.LabelProp = global::Mono.Unix.Catalog.GetString ("Input");
			this.hbox3.Add (this.labelInput);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.labelInput]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.hbox3.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hseparator2]));
			w8.Position = 1;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Events = ((global::Gdk.EventMask)(260));
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vboxInputSpin = new global::Gtk.VBox ();
			this.vboxInputSpin.Name = "vboxInputSpin";
			this.vboxInputSpin.Spacing = 6;
			// Container child vboxInputSpin.Gtk.Box+BoxChild
			this.spinInHigh = new global::Gtk.SpinButton (1D, 255D, 1D);
			this.spinInHigh.CanFocus = true;
			this.spinInHigh.Name = "spinInHigh";
			this.spinInHigh.Adjustment.PageIncrement = 10D;
			this.spinInHigh.ClimbRate = 1D;
			this.spinInHigh.Numeric = true;
			this.spinInHigh.Value = 255D;
			this.vboxInputSpin.Add (this.spinInHigh);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxInputSpin [this.spinInHigh]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vboxInputSpin.Gtk.Box+BoxChild
			this.colorpanelInHigh = new global::Pinta.Gui.Widgets.ColorPanelWidget ();
			this.colorpanelInHigh.HeightRequest = 24;
			this.colorpanelInHigh.Events = ((global::Gdk.EventMask)(256));
			this.colorpanelInHigh.Name = "colorpanelInHigh";
			this.vboxInputSpin.Add (this.colorpanelInHigh);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxInputSpin [this.colorpanelInHigh]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxInputSpin.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.vboxInputSpin.Add (this.alignment1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxInputSpin [this.alignment1]));
			w12.Position = 2;
			// Container child vboxInputSpin.Gtk.Box+BoxChild
			this.colorpanelInLow = new global::Pinta.Gui.Widgets.ColorPanelWidget ();
			this.colorpanelInLow.HeightRequest = 24;
			this.colorpanelInLow.Events = ((global::Gdk.EventMask)(256));
			this.colorpanelInLow.Name = "colorpanelInLow";
			this.vboxInputSpin.Add (this.colorpanelInLow);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxInputSpin [this.colorpanelInLow]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vboxInputSpin.Gtk.Box+BoxChild
			this.spinInLow = new global::Gtk.SpinButton (0D, 254D, 1D);
			this.spinInLow.CanFocus = true;
			this.spinInLow.Name = "spinInLow";
			this.spinInLow.Adjustment.PageIncrement = 10D;
			this.spinInLow.ClimbRate = 1D;
			this.spinInLow.Numeric = true;
			this.vboxInputSpin.Add (this.spinInLow);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxInputSpin [this.spinInLow]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			this.hbox8.Add (this.vboxInputSpin);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.vboxInputSpin]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.gradientInput = new global::Pinta.Gui.Widgets.ColorGradientWidget ();
			this.gradientInput.WidthRequest = 40;
			this.gradientInput.CanFocus = true;
			this.gradientInput.Events = ((global::Gdk.EventMask)(510));
			this.gradientInput.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.gradientInput.Name = "gradientInput";
			this.gradientInput.Count = 2;
			this.hbox8.Add (this.gradientInput);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.gradientInput]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox3.Add (this.hbox8);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox8]));
			w17.Position = 1;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w18.Position = 1;
			w18.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelOutput = new global::Gtk.Label ();
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.LabelProp = global::Mono.Unix.Catalog.GetString ("Output");
			this.hbox4.Add (this.labelOutput);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelOutput]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.hbox4.Add (this.hseparator3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.hseparator3]));
			w20.Position = 1;
			this.vbox4.Add (this.hbox4);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.gradientOutput = new global::Pinta.Gui.Widgets.ColorGradientWidget ();
			this.gradientOutput.WidthRequest = 40;
			this.gradientOutput.Events = ((global::Gdk.EventMask)(256));
			this.gradientOutput.Name = "gradientOutput";
			this.gradientOutput.Count = 3;
			this.hbox9.Add (this.gradientOutput);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.gradientOutput]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vboxOutputSpin = new global::Gtk.VBox ();
			this.vboxOutputSpin.Name = "vboxOutputSpin";
			this.vboxOutputSpin.Spacing = 6;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.spinOutHigh = new global::Gtk.SpinButton (2D, 255D, 1D);
			this.spinOutHigh.CanFocus = true;
			this.spinOutHigh.Name = "spinOutHigh";
			this.spinOutHigh.Adjustment.PageIncrement = 10D;
			this.spinOutHigh.ClimbRate = 1D;
			this.spinOutHigh.Numeric = true;
			this.spinOutHigh.Value = 255D;
			this.vboxOutputSpin.Add (this.spinOutHigh);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.spinOutHigh]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.colorpanelOutHigh = new global::Pinta.Gui.Widgets.ColorPanelWidget ();
			this.colorpanelOutHigh.HeightRequest = 24;
			this.colorpanelOutHigh.Events = ((global::Gdk.EventMask)(256));
			this.colorpanelOutHigh.Name = "colorpanelOutHigh";
			this.vboxOutputSpin.Add (this.colorpanelOutHigh);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.colorpanelOutHigh]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.spinOutGamma = new global::Gtk.SpinButton (0D, 100D, 0.1D);
			this.spinOutGamma.CanFocus = true;
			this.spinOutGamma.Name = "spinOutGamma";
			this.spinOutGamma.Adjustment.PageIncrement = 10D;
			this.spinOutGamma.ClimbRate = 1D;
			this.spinOutGamma.Numeric = true;
			this.spinOutGamma.Value = 1D;
			this.vboxOutputSpin.Add (this.spinOutGamma);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.spinOutGamma]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.colorpanelOutMid = new global::Pinta.Gui.Widgets.ColorPanelWidget ();
			this.colorpanelOutMid.HeightRequest = 24;
			this.colorpanelOutMid.Events = ((global::Gdk.EventMask)(256));
			this.colorpanelOutMid.Name = "colorpanelOutMid";
			this.vboxOutputSpin.Add (this.colorpanelOutMid);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.colorpanelOutMid]));
			w26.Position = 3;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.colorpanelOutLow = new global::Pinta.Gui.Widgets.ColorPanelWidget ();
			this.colorpanelOutLow.HeightRequest = 24;
			this.colorpanelOutLow.Events = ((global::Gdk.EventMask)(256));
			this.colorpanelOutLow.Name = "colorpanelOutLow";
			this.vboxOutputSpin.Add (this.colorpanelOutLow);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.colorpanelOutLow]));
			w27.Position = 4;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vboxOutputSpin.Gtk.Box+BoxChild
			this.spinOutLow = new global::Gtk.SpinButton (0D, 252D, 1D);
			this.spinOutLow.CanFocus = true;
			this.spinOutLow.Name = "spinOutLow";
			this.spinOutLow.Adjustment.PageIncrement = 10D;
			this.spinOutLow.ClimbRate = 1D;
			this.spinOutLow.Numeric = true;
			this.vboxOutputSpin.Add (this.spinOutLow);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vboxOutputSpin [this.spinOutLow]));
			w28.Position = 5;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox9.Add (this.vboxOutputSpin);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.vboxOutputSpin]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox4.Add (this.hbox9);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox9]));
			w30.Position = 1;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.labelOutputHist = new global::Gtk.Label ();
			this.labelOutputHist.Name = "labelOutputHist";
			this.labelOutputHist.LabelProp = global::Mono.Unix.Catalog.GetString ("Output Histogram");
			this.hbox5.Add (this.labelOutputHist);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.labelOutputHist]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hseparator4 = new global::Gtk.HSeparator ();
			this.hseparator4.Name = "hseparator4";
			this.hbox5.Add (this.hseparator4);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.hseparator4]));
			w33.Position = 1;
			this.vbox5.Add (this.hbox5);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox5]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.histogramOutput = new global::Pinta.Gui.Widgets.HistogramWidget ();
			this.histogramOutput.WidthRequest = 130;
			this.histogramOutput.Events = ((global::Gdk.EventMask)(256));
			this.histogramOutput.Name = "histogramOutput";
			this.histogramOutput.FlipHorizontal = false;
			this.histogramOutput.FlipVertical = false;
			this.vbox5.Add (this.histogramOutput);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.histogramOutput]));
			w35.Position = 1;
			this.hbox1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox5]));
			w36.Position = 3;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w37.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hboxBottom = new global::Gtk.HBox ();
			this.hboxBottom.Name = "hboxBottom";
			this.hboxBottom.Spacing = 6;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.buttonAuto = new global::Gtk.Button ();
			this.buttonAuto.WidthRequest = 80;
			this.buttonAuto.CanFocus = true;
			this.buttonAuto.Name = "buttonAuto";
			this.buttonAuto.UseUnderline = true;
			this.buttonAuto.Label = global::Mono.Unix.Catalog.GetString ("Auto");
			this.hboxBottom.Add (this.buttonAuto);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.buttonAuto]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.buttonReset = new global::Gtk.Button ();
			this.buttonReset.WidthRequest = 80;
			this.buttonReset.CanFocus = true;
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.UseUnderline = true;
			this.buttonReset.Label = global::Mono.Unix.Catalog.GetString ("Reset");
			this.hboxBottom.Add (this.buttonReset);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.buttonReset]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.checkRed = new global::Gtk.CheckButton ();
			this.checkRed.CanFocus = true;
			this.checkRed.Name = "checkRed";
			this.checkRed.Label = global::Mono.Unix.Catalog.GetString ("Red");
			this.checkRed.Active = true;
			this.checkRed.DrawIndicator = true;
			this.checkRed.UseUnderline = true;
			this.hboxBottom.Add (this.checkRed);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.checkRed]));
			w40.Position = 2;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.checkGreen = new global::Gtk.CheckButton ();
			this.checkGreen.CanFocus = true;
			this.checkGreen.Name = "checkGreen";
			this.checkGreen.Label = global::Mono.Unix.Catalog.GetString ("Green");
			this.checkGreen.Active = true;
			this.checkGreen.DrawIndicator = true;
			this.checkGreen.UseUnderline = true;
			this.hboxBottom.Add (this.checkGreen);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.checkGreen]));
			w41.Position = 3;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.WidthRequest = 80;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.hboxBottom.Add (this.buttonOk);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.buttonOk]));
			w42.PackType = ((global::Gtk.PackType)(1));
			w42.Position = 4;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.WidthRequest = 80;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.hboxBottom.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.buttonCancel]));
			w43.PackType = ((global::Gtk.PackType)(1));
			w43.Position = 5;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hboxBottom.Gtk.Box+BoxChild
			this.checkBlue = new global::Gtk.CheckButton ();
			this.checkBlue.CanFocus = true;
			this.checkBlue.Name = "checkBlue";
			this.checkBlue.Label = global::Mono.Unix.Catalog.GetString ("Blue");
			this.checkBlue.Active = true;
			this.checkBlue.DrawIndicator = true;
			this.checkBlue.UseUnderline = true;
			this.hboxBottom.Add (this.checkBlue);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hboxBottom [this.checkBlue]));
			w44.PackType = ((global::Gtk.PackType)(1));
			w44.Position = 6;
			w1.Add (this.hboxBottom);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(w1 [this.hboxBottom]));
			w45.PackType = ((global::Gtk.PackType)(1));
			w45.Position = 4;
			w45.Expand = false;
			w45.Fill = false;
			// Internal child Pinta.Effects.LevelsDialog.ActionArea
			global::Gtk.HButtonBox w46 = this.ActionArea;
			w46.Name = "__gtksharp_58_Stetic_TopLevelDialog_ActionArea";
			w46.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child __gtksharp_58_Stetic_TopLevelDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonDummy = new global::Gtk.Button ();
			this.buttonDummy.Sensitive = false;
			this.buttonDummy.CanFocus = true;
			this.buttonDummy.Name = "buttonDummy";
			this.buttonDummy.UseUnderline = true;
			this.buttonDummy.Label = global::Mono.Unix.Catalog.GetString ("In stetic action button box cannot be empty");
			this.AddActionWidget (this.buttonDummy, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w47 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w46 [this.buttonDummy]));
			w47.Expand = false;
			w47.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1754;
			this.DefaultHeight = 326;
			this.buttonDummy.Hide ();
			this.Show ();
		}
	}
}
