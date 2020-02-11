namespace Leadtools.Demos
{
   partial class DocumentFormatOptionsDialog
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentFormatOptionsDialog));
         this._okButton = new System.Windows.Forms.Button();
         this._cancelButton = new System.Windows.Forms.Button();
         this._optionsTabControl = new System.Windows.Forms.TabControl();
         this._ldOptionsTabPage = new System.Windows.Forms.TabPage();
         this._ldOptionsNoteLabel = new System.Windows.Forms.Label();
         this._emfOptionsTabPage = new System.Windows.Forms.TabPage();
         this._emfOptionsNoteLabel = new System.Windows.Forms.Label();
         this._pdfOptionsTabPage = new System.Windows.Forms.TabPage();
         this._pdfLinearizedCheckBox = new System.Windows.Forms.CheckBox();
         this._pdfAdvanctionOptionsButton = new System.Windows.Forms.Button();
         this._pdfImageOverTextCheckBox = new System.Windows.Forms.CheckBox();
         this._pdfDocumentTypeComboBox = new System.Windows.Forms.ComboBox();
         this._pdfDocumentTypeLabel = new System.Windows.Forms.Label();
         this._docOptionsTabPage = new System.Windows.Forms.TabPage();
         this._docOptionsDescriptionLabel = new System.Windows.Forms.Label();
         this._docFramedCheckBox = new System.Windows.Forms.CheckBox();
         this._rtfOptionsTabPage = new System.Windows.Forms.TabPage();
         this._rtfOptionsDescriptionLabel = new System.Windows.Forms.Label();
         this._rtfFramedCheckBox = new System.Windows.Forms.CheckBox();
         this._htmlOptionsTabPage = new System.Windows.Forms.TabPage();
         this._htmlBackgroundColorButton = new System.Windows.Forms.Button();
         this._htmlBackgroundColorValueLabel = new System.Windows.Forms.Label();
         this._htmlBackgroundColorLabel = new System.Windows.Forms.Label();
         this._htmlUseBackgroundColorCheckBox = new System.Windows.Forms.CheckBox();
         this._htmlEmbedFontModeComboBox = new System.Windows.Forms.ComboBox();
         this._htmlEmbedFontModeLabel = new System.Windows.Forms.Label();
         this._textOptionsTabPage = new System.Windows.Forms.TabPage();
         this._textFormattedCheckBox = new System.Windows.Forms.CheckBox();
         this._textAddPageBreakCheckBox = new System.Windows.Forms.CheckBox();
         this._textAddPageNumberCheckBox = new System.Windows.Forms.CheckBox();
         this._textDocumentTypeComboBox = new System.Windows.Forms.ComboBox();
         this._textDocumentTypeLabel = new System.Windows.Forms.Label();
         this._docxOptionsTabPage = new System.Windows.Forms.TabPage();
         this._docxOptionsDescriptionLabel = new System.Windows.Forms.Label();
         this._docxFramedCheckBox = new System.Windows.Forms.CheckBox();
         this._altoXmlOptionsTabPage = new System.Windows.Forms.TabPage();
         this._altoXmlMeasurementUnitComboBox = new System.Windows.Forms.ComboBox();
         this._altoXmlMeasurementUnitLabel = new System.Windows.Forms.Label();
         this._altoXmlShowGlyphVariantsCheckBox = new System.Windows.Forms.CheckBox();
         this._altoXmlShowGlyphInfoCheckBox = new System.Windows.Forms.CheckBox();
         this._altoXmlPlainTextCheckBox = new System.Windows.Forms.CheckBox();
         this._altoXmlSortCheckBox = new System.Windows.Forms.CheckBox();
         this._altoXmlApplicationDescriptionTextBox = new System.Windows.Forms.TextBox();
         this._altoXmlApplicationDescriptionLabel = new System.Windows.Forms.Label();
         this._altoXmlSoftwareNameTextBox = new System.Windows.Forms.TextBox();
         this._altoXmlSoftwareNameLabel = new System.Windows.Forms.Label();
         this._altoXmlSoftwareCreatorTextBox = new System.Windows.Forms.TextBox();
         this._altoXmlSoftwareCreatorLabel = new System.Windows.Forms.Label();
         this._altoXmlFileNameTextBox = new System.Windows.Forms.TextBox();
         this._altoXmlFileNameLabel = new System.Windows.Forms.Label();
         this._altoXmlIndentationTextBox = new System.Windows.Forms.TextBox();
         this._altoXmlIndentationLabel = new System.Windows.Forms.Label();
         this._altoXmlFormattedCheckBox = new System.Windows.Forms.CheckBox();
         this._emptyOptionsTabPage = new System.Windows.Forms.TabPage();
         this._emptyOptionsLabel = new System.Windows.Forms.Label();
         this._optionsTabControl.SuspendLayout();
         this._ldOptionsTabPage.SuspendLayout();
         this._emfOptionsTabPage.SuspendLayout();
         this._pdfOptionsTabPage.SuspendLayout();
         this._docOptionsTabPage.SuspendLayout();
         this._rtfOptionsTabPage.SuspendLayout();
         this._htmlOptionsTabPage.SuspendLayout();
         this._textOptionsTabPage.SuspendLayout();
         this._docxOptionsTabPage.SuspendLayout();
         this._altoXmlOptionsTabPage.SuspendLayout();
         this._emptyOptionsTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // _okButton
         // 
         this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._okButton.Location = new System.Drawing.Point(620, 18);
         this._okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._okButton.Name = "_okButton";
         this._okButton.Size = new System.Drawing.Size(112, 35);
         this._okButton.TabIndex = 0;
         this._okButton.Text = "OK";
         this._okButton.UseVisualStyleBackColor = true;
         this._okButton.Click += new System.EventHandler(this._okButton_Click);
         // 
         // _cancelButton
         // 
         this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this._cancelButton.Location = new System.Drawing.Point(620, 63);
         this._cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._cancelButton.Name = "_cancelButton";
         this._cancelButton.Size = new System.Drawing.Size(112, 35);
         this._cancelButton.TabIndex = 1;
         this._cancelButton.Text = "Cancel";
         this._cancelButton.UseVisualStyleBackColor = true;
         // 
         // _optionsTabControl
         // 
         this._optionsTabControl.Controls.Add(this._ldOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._emfOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._pdfOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._docOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._rtfOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._htmlOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._textOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._docxOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._altoXmlOptionsTabPage);
         this._optionsTabControl.Controls.Add(this._emptyOptionsTabPage);
         this._optionsTabControl.Location = new System.Drawing.Point(18, 18);
         this._optionsTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._optionsTabControl.Name = "_optionsTabControl";
         this._optionsTabControl.SelectedIndex = 0;
         this._optionsTabControl.Size = new System.Drawing.Size(564, 507);
         this._optionsTabControl.TabIndex = 2;
         // 
         // _ldOptionsTabPage
         // 
         this._ldOptionsTabPage.Controls.Add(this._ldOptionsNoteLabel);
         this._ldOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._ldOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._ldOptionsTabPage.Name = "_ldOptionsTabPage";
         this._ldOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._ldOptionsTabPage.TabIndex = 7;
         this._ldOptionsTabPage.Text = "LTD Options";
         this._ldOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _ldOptionsNoteLabel
         // 
         this._ldOptionsNoteLabel.AutoSize = true;
         this._ldOptionsNoteLabel.Location = new System.Drawing.Point(33, 18);
         this._ldOptionsNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._ldOptionsNoteLabel.Name = "_ldOptionsNoteLabel";
         this._ldOptionsNoteLabel.Size = new System.Drawing.Size(505, 200);
         this._ldOptionsNoteLabel.TabIndex = 1;
         this._ldOptionsNoteLabel.Text = resources.GetString("_ldOptionsNoteLabel.Text");
         // 
         // _emfOptionsTabPage
         // 
         this._emfOptionsTabPage.Controls.Add(this._emfOptionsNoteLabel);
         this._emfOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._emfOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._emfOptionsTabPage.Name = "_emfOptionsTabPage";
         this._emfOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._emfOptionsTabPage.TabIndex = 6;
         this._emfOptionsTabPage.Text = "EMF options";
         this._emfOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _emfOptionsNoteLabel
         // 
         this._emfOptionsNoteLabel.AutoSize = true;
         this._emfOptionsNoteLabel.Location = new System.Drawing.Point(20, 23);
         this._emfOptionsNoteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._emfOptionsNoteLabel.Name = "_emfOptionsNoteLabel";
         this._emfOptionsNoteLabel.Size = new System.Drawing.Size(473, 60);
         this._emfOptionsNoteLabel.TabIndex = 0;
         this._emfOptionsNoteLabel.Text = "Note that the EMF format does not support multiple-pages, hence\r\nwhen saving a mu" +
    "lti-page document to EMF the result is the last\r\npage only.";
         // 
         // _pdfOptionsTabPage
         // 
         this._pdfOptionsTabPage.Controls.Add(this._pdfLinearizedCheckBox);
         this._pdfOptionsTabPage.Controls.Add(this._pdfAdvanctionOptionsButton);
         this._pdfOptionsTabPage.Controls.Add(this._pdfImageOverTextCheckBox);
         this._pdfOptionsTabPage.Controls.Add(this._pdfDocumentTypeComboBox);
         this._pdfOptionsTabPage.Controls.Add(this._pdfDocumentTypeLabel);
         this._pdfOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._pdfOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._pdfOptionsTabPage.Name = "_pdfOptionsTabPage";
         this._pdfOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._pdfOptionsTabPage.TabIndex = 0;
         this._pdfOptionsTabPage.Text = "PDF options";
         this._pdfOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _pdfLinearizedCheckBox
         // 
         this._pdfLinearizedCheckBox.AutoSize = true;
         this._pdfLinearizedCheckBox.Location = new System.Drawing.Point(190, 146);
         this._pdfLinearizedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._pdfLinearizedCheckBox.Name = "_pdfLinearizedCheckBox";
         this._pdfLinearizedCheckBox.Size = new System.Drawing.Size(221, 24);
         this._pdfLinearizedCheckBox.TabIndex = 4;
         this._pdfLinearizedCheckBox.Text = "Fast web view (Linearized)";
         this._pdfLinearizedCheckBox.UseVisualStyleBackColor = true;
         this._pdfLinearizedCheckBox.CheckedChanged += new System.EventHandler(this._pdfLinearizedCheckBox_CheckedChanged);
         // 
         // _pdfAdvanctionOptionsButton
         // 
         this._pdfAdvanctionOptionsButton.Location = new System.Drawing.Point(190, 68);
         this._pdfAdvanctionOptionsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._pdfAdvanctionOptionsButton.Name = "_pdfAdvanctionOptionsButton";
         this._pdfAdvanctionOptionsButton.Size = new System.Drawing.Size(338, 35);
         this._pdfAdvanctionOptionsButton.TabIndex = 2;
         this._pdfAdvanctionOptionsButton.Text = "Advanced Options...";
         this._pdfAdvanctionOptionsButton.UseVisualStyleBackColor = true;
         this._pdfAdvanctionOptionsButton.Click += new System.EventHandler(this._pdfAdvanctionOptionsButton_Click);
         // 
         // _pdfImageOverTextCheckBox
         // 
         this._pdfImageOverTextCheckBox.AutoSize = true;
         this._pdfImageOverTextCheckBox.Location = new System.Drawing.Point(190, 112);
         this._pdfImageOverTextCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._pdfImageOverTextCheckBox.Name = "_pdfImageOverTextCheckBox";
         this._pdfImageOverTextCheckBox.Size = new System.Drawing.Size(144, 24);
         this._pdfImageOverTextCheckBox.TabIndex = 3;
         this._pdfImageOverTextCheckBox.Text = "Image over text";
         this._pdfImageOverTextCheckBox.UseVisualStyleBackColor = true;
         this._pdfImageOverTextCheckBox.CheckedChanged += new System.EventHandler(this._pdfImageOverTextCheckBox_CheckedChanged);
         // 
         // _pdfDocumentTypeComboBox
         // 
         this._pdfDocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._pdfDocumentTypeComboBox.FormattingEnabled = true;
         this._pdfDocumentTypeComboBox.Location = new System.Drawing.Point(190, 26);
         this._pdfDocumentTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._pdfDocumentTypeComboBox.Name = "_pdfDocumentTypeComboBox";
         this._pdfDocumentTypeComboBox.Size = new System.Drawing.Size(336, 28);
         this._pdfDocumentTypeComboBox.TabIndex = 1;
         this._pdfDocumentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this._pdfDocumentTypeComboBox_SelectedIndexChanged);
         // 
         // _pdfDocumentTypeLabel
         // 
         this._pdfDocumentTypeLabel.AutoSize = true;
         this._pdfDocumentTypeLabel.Location = new System.Drawing.Point(27, 31);
         this._pdfDocumentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._pdfDocumentTypeLabel.Name = "_pdfDocumentTypeLabel";
         this._pdfDocumentTypeLabel.Size = new System.Drawing.Size(121, 20);
         this._pdfDocumentTypeLabel.TabIndex = 0;
         this._pdfDocumentTypeLabel.Text = "Document type:";
         // 
         // _docOptionsTabPage
         // 
         this._docOptionsTabPage.Controls.Add(this._docOptionsDescriptionLabel);
         this._docOptionsTabPage.Controls.Add(this._docFramedCheckBox);
         this._docOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._docOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._docOptionsTabPage.Name = "_docOptionsTabPage";
         this._docOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._docOptionsTabPage.TabIndex = 1;
         this._docOptionsTabPage.Text = "DOC options";
         this._docOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _docOptionsDescriptionLabel
         // 
         this._docOptionsDescriptionLabel.Location = new System.Drawing.Point(26, 62);
         this._docOptionsDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._docOptionsDescriptionLabel.Name = "_docOptionsDescriptionLabel";
         this._docOptionsDescriptionLabel.Size = new System.Drawing.Size(508, 88);
         this._docOptionsDescriptionLabel.TabIndex = 7;
         this._docOptionsDescriptionLabel.Text = resources.GetString("_docOptionsDescriptionLabel.Text");
         // 
         // _docFramedCheckBox
         // 
         this._docFramedCheckBox.AutoSize = true;
         this._docFramedCheckBox.Location = new System.Drawing.Point(30, 31);
         this._docFramedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._docFramedCheckBox.Name = "_docFramedCheckBox";
         this._docFramedCheckBox.Size = new System.Drawing.Size(111, 24);
         this._docFramedCheckBox.TabIndex = 5;
         this._docFramedCheckBox.Text = "Frame text";
         this._docFramedCheckBox.UseVisualStyleBackColor = true;
         // 
         // _rtfOptionsTabPage
         // 
         this._rtfOptionsTabPage.Controls.Add(this._rtfOptionsDescriptionLabel);
         this._rtfOptionsTabPage.Controls.Add(this._rtfFramedCheckBox);
         this._rtfOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._rtfOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._rtfOptionsTabPage.Name = "_rtfOptionsTabPage";
         this._rtfOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._rtfOptionsTabPage.TabIndex = 2;
         this._rtfOptionsTabPage.Text = "RTF options";
         this._rtfOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _rtfOptionsDescriptionLabel
         // 
         this._rtfOptionsDescriptionLabel.Location = new System.Drawing.Point(26, 62);
         this._rtfOptionsDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._rtfOptionsDescriptionLabel.Name = "_rtfOptionsDescriptionLabel";
         this._rtfOptionsDescriptionLabel.Size = new System.Drawing.Size(508, 88);
         this._rtfOptionsDescriptionLabel.TabIndex = 8;
         this._rtfOptionsDescriptionLabel.Text = resources.GetString("_rtfOptionsDescriptionLabel.Text");
         // 
         // _rtfFramedCheckBox
         // 
         this._rtfFramedCheckBox.AutoSize = true;
         this._rtfFramedCheckBox.Location = new System.Drawing.Point(30, 31);
         this._rtfFramedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._rtfFramedCheckBox.Name = "_rtfFramedCheckBox";
         this._rtfFramedCheckBox.Size = new System.Drawing.Size(111, 24);
         this._rtfFramedCheckBox.TabIndex = 6;
         this._rtfFramedCheckBox.Text = "Frame text";
         this._rtfFramedCheckBox.UseVisualStyleBackColor = true;
         // 
         // _htmlOptionsTabPage
         // 
         this._htmlOptionsTabPage.Controls.Add(this._htmlBackgroundColorButton);
         this._htmlOptionsTabPage.Controls.Add(this._htmlBackgroundColorValueLabel);
         this._htmlOptionsTabPage.Controls.Add(this._htmlBackgroundColorLabel);
         this._htmlOptionsTabPage.Controls.Add(this._htmlUseBackgroundColorCheckBox);
         this._htmlOptionsTabPage.Controls.Add(this._htmlEmbedFontModeComboBox);
         this._htmlOptionsTabPage.Controls.Add(this._htmlEmbedFontModeLabel);
         this._htmlOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._htmlOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._htmlOptionsTabPage.Name = "_htmlOptionsTabPage";
         this._htmlOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._htmlOptionsTabPage.TabIndex = 3;
         this._htmlOptionsTabPage.Text = "HTML options";
         this._htmlOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _htmlBackgroundColorButton
         // 
         this._htmlBackgroundColorButton.Location = new System.Drawing.Point(274, 103);
         this._htmlBackgroundColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._htmlBackgroundColorButton.Name = "_htmlBackgroundColorButton";
         this._htmlBackgroundColorButton.Size = new System.Drawing.Size(42, 35);
         this._htmlBackgroundColorButton.TabIndex = 12;
         this._htmlBackgroundColorButton.Text = "...";
         this._htmlBackgroundColorButton.UseVisualStyleBackColor = true;
         this._htmlBackgroundColorButton.Click += new System.EventHandler(this._htmlBackgroundColorButton_Click);
         // 
         // _htmlBackgroundColorValueLabel
         // 
         this._htmlBackgroundColorValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this._htmlBackgroundColorValueLabel.Location = new System.Drawing.Point(190, 103);
         this._htmlBackgroundColorValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._htmlBackgroundColorValueLabel.Name = "_htmlBackgroundColorValueLabel";
         this._htmlBackgroundColorValueLabel.Size = new System.Drawing.Size(74, 34);
         this._htmlBackgroundColorValueLabel.TabIndex = 11;
         // 
         // _htmlBackgroundColorLabel
         // 
         this._htmlBackgroundColorLabel.AutoSize = true;
         this._htmlBackgroundColorLabel.Location = new System.Drawing.Point(22, 109);
         this._htmlBackgroundColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._htmlBackgroundColorLabel.Name = "_htmlBackgroundColorLabel";
         this._htmlBackgroundColorLabel.Size = new System.Drawing.Size(137, 20);
         this._htmlBackgroundColorLabel.TabIndex = 10;
         this._htmlBackgroundColorLabel.Text = "Background color:";
         // 
         // _htmlUseBackgroundColorCheckBox
         // 
         this._htmlUseBackgroundColorCheckBox.AutoSize = true;
         this._htmlUseBackgroundColorCheckBox.Location = new System.Drawing.Point(190, 66);
         this._htmlUseBackgroundColorCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._htmlUseBackgroundColorCheckBox.Name = "_htmlUseBackgroundColorCheckBox";
         this._htmlUseBackgroundColorCheckBox.Size = new System.Drawing.Size(190, 24);
         this._htmlUseBackgroundColorCheckBox.TabIndex = 9;
         this._htmlUseBackgroundColorCheckBox.Text = "Use background color";
         this._htmlUseBackgroundColorCheckBox.UseVisualStyleBackColor = true;
         this._htmlUseBackgroundColorCheckBox.CheckedChanged += new System.EventHandler(this._htmlUseBackgroundColorCheckBox_CheckedChanged);
         // 
         // _htmlEmbedFontModeComboBox
         // 
         this._htmlEmbedFontModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._htmlEmbedFontModeComboBox.FormattingEnabled = true;
         this._htmlEmbedFontModeComboBox.Location = new System.Drawing.Point(190, 28);
         this._htmlEmbedFontModeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._htmlEmbedFontModeComboBox.Name = "_htmlEmbedFontModeComboBox";
         this._htmlEmbedFontModeComboBox.Size = new System.Drawing.Size(336, 28);
         this._htmlEmbedFontModeComboBox.TabIndex = 8;
         // 
         // _htmlEmbedFontModeLabel
         // 
         this._htmlEmbedFontModeLabel.AutoSize = true;
         this._htmlEmbedFontModeLabel.Location = new System.Drawing.Point(30, 31);
         this._htmlEmbedFontModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._htmlEmbedFontModeLabel.Name = "_htmlEmbedFontModeLabel";
         this._htmlEmbedFontModeLabel.Size = new System.Drawing.Size(140, 20);
         this._htmlEmbedFontModeLabel.TabIndex = 7;
         this._htmlEmbedFontModeLabel.Text = "Embed font mode:";
         // 
         // _textOptionsTabPage
         // 
         this._textOptionsTabPage.Controls.Add(this._textFormattedCheckBox);
         this._textOptionsTabPage.Controls.Add(this._textAddPageBreakCheckBox);
         this._textOptionsTabPage.Controls.Add(this._textAddPageNumberCheckBox);
         this._textOptionsTabPage.Controls.Add(this._textDocumentTypeComboBox);
         this._textOptionsTabPage.Controls.Add(this._textDocumentTypeLabel);
         this._textOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._textOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._textOptionsTabPage.Name = "_textOptionsTabPage";
         this._textOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._textOptionsTabPage.TabIndex = 4;
         this._textOptionsTabPage.Text = "Text options";
         this._textOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _textFormattedCheckBox
         // 
         this._textFormattedCheckBox.AutoSize = true;
         this._textFormattedCheckBox.Location = new System.Drawing.Point(192, 138);
         this._textFormattedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._textFormattedCheckBox.Name = "_textFormattedCheckBox";
         this._textFormattedCheckBox.Size = new System.Drawing.Size(109, 24);
         this._textFormattedCheckBox.TabIndex = 19;
         this._textFormattedCheckBox.Text = "Formatted";
         this._textFormattedCheckBox.UseVisualStyleBackColor = true;
         // 
         // _textAddPageBreakCheckBox
         // 
         this._textAddPageBreakCheckBox.AutoSize = true;
         this._textAddPageBreakCheckBox.Location = new System.Drawing.Point(192, 103);
         this._textAddPageBreakCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._textAddPageBreakCheckBox.Name = "_textAddPageBreakCheckBox";
         this._textAddPageBreakCheckBox.Size = new System.Drawing.Size(148, 24);
         this._textAddPageBreakCheckBox.TabIndex = 18;
         this._textAddPageBreakCheckBox.Text = "Add page break";
         this._textAddPageBreakCheckBox.UseVisualStyleBackColor = true;
         // 
         // _textAddPageNumberCheckBox
         // 
         this._textAddPageNumberCheckBox.AutoSize = true;
         this._textAddPageNumberCheckBox.Location = new System.Drawing.Point(192, 68);
         this._textAddPageNumberCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._textAddPageNumberCheckBox.Name = "_textAddPageNumberCheckBox";
         this._textAddPageNumberCheckBox.Size = new System.Drawing.Size(162, 24);
         this._textAddPageNumberCheckBox.TabIndex = 17;
         this._textAddPageNumberCheckBox.Text = "Add page number";
         this._textAddPageNumberCheckBox.UseVisualStyleBackColor = true;
         // 
         // _textDocumentTypeComboBox
         // 
         this._textDocumentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._textDocumentTypeComboBox.FormattingEnabled = true;
         this._textDocumentTypeComboBox.Location = new System.Drawing.Point(192, 26);
         this._textDocumentTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._textDocumentTypeComboBox.Name = "_textDocumentTypeComboBox";
         this._textDocumentTypeComboBox.Size = new System.Drawing.Size(336, 28);
         this._textDocumentTypeComboBox.TabIndex = 14;
         // 
         // _textDocumentTypeLabel
         // 
         this._textDocumentTypeLabel.AutoSize = true;
         this._textDocumentTypeLabel.Location = new System.Drawing.Point(27, 31);
         this._textDocumentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._textDocumentTypeLabel.Name = "_textDocumentTypeLabel";
         this._textDocumentTypeLabel.Size = new System.Drawing.Size(121, 20);
         this._textDocumentTypeLabel.TabIndex = 13;
         this._textDocumentTypeLabel.Text = "Document type:";
         // 
         // _docxOptionsTabPage
         // 
         this._docxOptionsTabPage.Controls.Add(this._docxOptionsDescriptionLabel);
         this._docxOptionsTabPage.Controls.Add(this._docxFramedCheckBox);
         this._docxOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._docxOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._docxOptionsTabPage.Name = "_docxOptionsTabPage";
         this._docxOptionsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._docxOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._docxOptionsTabPage.TabIndex = 8;
         this._docxOptionsTabPage.Text = "DOCX options";
         this._docxOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _docxOptionsDescriptionLabel
         // 
         this._docxOptionsDescriptionLabel.Location = new System.Drawing.Point(26, 62);
         this._docxOptionsDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._docxOptionsDescriptionLabel.Name = "_docxOptionsDescriptionLabel";
         this._docxOptionsDescriptionLabel.Size = new System.Drawing.Size(508, 88);
         this._docxOptionsDescriptionLabel.TabIndex = 7;
         this._docxOptionsDescriptionLabel.Text = resources.GetString("_docxOptionsDescriptionLabel.Text");
         // 
         // _docxFramedCheckBox
         // 
         this._docxFramedCheckBox.AutoSize = true;
         this._docxFramedCheckBox.Location = new System.Drawing.Point(30, 31);
         this._docxFramedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._docxFramedCheckBox.Name = "_docxFramedCheckBox";
         this._docxFramedCheckBox.Size = new System.Drawing.Size(111, 24);
         this._docxFramedCheckBox.TabIndex = 6;
         this._docxFramedCheckBox.Text = "&Frame text";
         this._docxFramedCheckBox.UseVisualStyleBackColor = true;
         // 
         // _altoXmlOptionsTabPage
         // 
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlMeasurementUnitComboBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlMeasurementUnitLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlShowGlyphVariantsCheckBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlShowGlyphInfoCheckBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlPlainTextCheckBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlSortCheckBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlApplicationDescriptionTextBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlApplicationDescriptionLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlSoftwareNameTextBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlSoftwareNameLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlSoftwareCreatorTextBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlSoftwareCreatorLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlFileNameTextBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlFileNameLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlIndentationTextBox);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlIndentationLabel);
         this._altoXmlOptionsTabPage.Controls.Add(this._altoXmlFormattedCheckBox);
         this._altoXmlOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._altoXmlOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlOptionsTabPage.Name = "_altoXmlOptionsTabPage";
         this._altoXmlOptionsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._altoXmlOptionsTabPage.TabIndex = 9;
         this._altoXmlOptionsTabPage.Text = "ALTOXML options";
         this._altoXmlOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _altoXmlMeasurementUnitComboBox
         // 
         this._altoXmlMeasurementUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this._altoXmlMeasurementUnitComboBox.FormattingEnabled = true;
         this._altoXmlMeasurementUnitComboBox.Location = new System.Drawing.Point(207, 16);
         this._altoXmlMeasurementUnitComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlMeasurementUnitComboBox.Name = "_altoXmlMeasurementUnitComboBox";
         this._altoXmlMeasurementUnitComboBox.Size = new System.Drawing.Size(316, 28);
         this._altoXmlMeasurementUnitComboBox.TabIndex = 1;
         // 
         // _altoXmlMeasurementUnitLabel
         // 
         this._altoXmlMeasurementUnitLabel.AutoSize = true;
         this._altoXmlMeasurementUnitLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlMeasurementUnitLabel.Location = new System.Drawing.Point(24, 23);
         this._altoXmlMeasurementUnitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlMeasurementUnitLabel.Name = "_altoXmlMeasurementUnitLabel";
         this._altoXmlMeasurementUnitLabel.Size = new System.Drawing.Size(141, 20);
         this._altoXmlMeasurementUnitLabel.TabIndex = 0;
         this._altoXmlMeasurementUnitLabel.Text = "Measurement unit:";
         // 
         // _altoXmlShowGlyphVariantsCheckBox
         // 
         this._altoXmlShowGlyphVariantsCheckBox.AutoSize = true;
         this._altoXmlShowGlyphVariantsCheckBox.Location = new System.Drawing.Point(28, 402);
         this._altoXmlShowGlyphVariantsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlShowGlyphVariantsCheckBox.Name = "_altoXmlShowGlyphVariantsCheckBox";
         this._altoXmlShowGlyphVariantsCheckBox.Size = new System.Drawing.Size(175, 24);
         this._altoXmlShowGlyphVariantsCheckBox.TabIndex = 16;
         this._altoXmlShowGlyphVariantsCheckBox.Text = "Show glyph variants";
         this._altoXmlShowGlyphVariantsCheckBox.UseVisualStyleBackColor = true;
         // 
         // _altoXmlShowGlyphInfoCheckBox
         // 
         this._altoXmlShowGlyphInfoCheckBox.AutoSize = true;
         this._altoXmlShowGlyphInfoCheckBox.Location = new System.Drawing.Point(28, 364);
         this._altoXmlShowGlyphInfoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlShowGlyphInfoCheckBox.Name = "_altoXmlShowGlyphInfoCheckBox";
         this._altoXmlShowGlyphInfoCheckBox.Size = new System.Drawing.Size(146, 24);
         this._altoXmlShowGlyphInfoCheckBox.TabIndex = 15;
         this._altoXmlShowGlyphInfoCheckBox.Text = "Show glyph info";
         this._altoXmlShowGlyphInfoCheckBox.UseVisualStyleBackColor = true;
         // 
         // _altoXmlPlainTextCheckBox
         // 
         this._altoXmlPlainTextCheckBox.AutoSize = true;
         this._altoXmlPlainTextCheckBox.Location = new System.Drawing.Point(28, 325);
         this._altoXmlPlainTextCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlPlainTextCheckBox.Name = "_altoXmlPlainTextCheckBox";
         this._altoXmlPlainTextCheckBox.Size = new System.Drawing.Size(99, 24);
         this._altoXmlPlainTextCheckBox.TabIndex = 14;
         this._altoXmlPlainTextCheckBox.Text = "Plain text";
         this._altoXmlPlainTextCheckBox.UseVisualStyleBackColor = true;
         // 
         // _altoXmlSortCheckBox
         // 
         this._altoXmlSortCheckBox.AutoSize = true;
         this._altoXmlSortCheckBox.Location = new System.Drawing.Point(28, 287);
         this._altoXmlSortCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlSortCheckBox.Name = "_altoXmlSortCheckBox";
         this._altoXmlSortCheckBox.Size = new System.Drawing.Size(65, 24);
         this._altoXmlSortCheckBox.TabIndex = 13;
         this._altoXmlSortCheckBox.Text = "Sort";
         this._altoXmlSortCheckBox.UseVisualStyleBackColor = true;
         // 
         // _altoXmlApplicationDescriptionTextBox
         // 
         this._altoXmlApplicationDescriptionTextBox.Location = new System.Drawing.Point(207, 175);
         this._altoXmlApplicationDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlApplicationDescriptionTextBox.Name = "_altoXmlApplicationDescriptionTextBox";
         this._altoXmlApplicationDescriptionTextBox.Size = new System.Drawing.Size(316, 26);
         this._altoXmlApplicationDescriptionTextBox.TabIndex = 9;
         // 
         // _altoXmlApplicationDescriptionLabel
         // 
         this._altoXmlApplicationDescriptionLabel.AutoSize = true;
         this._altoXmlApplicationDescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlApplicationDescriptionLabel.Location = new System.Drawing.Point(24, 179);
         this._altoXmlApplicationDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlApplicationDescriptionLabel.Name = "_altoXmlApplicationDescriptionLabel";
         this._altoXmlApplicationDescriptionLabel.Size = new System.Drawing.Size(172, 20);
         this._altoXmlApplicationDescriptionLabel.TabIndex = 8;
         this._altoXmlApplicationDescriptionLabel.Text = "Application description:";
         // 
         // _altoXmlSoftwareNameTextBox
         // 
         this._altoXmlSoftwareNameTextBox.Location = new System.Drawing.Point(207, 135);
         this._altoXmlSoftwareNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlSoftwareNameTextBox.Name = "_altoXmlSoftwareNameTextBox";
         this._altoXmlSoftwareNameTextBox.Size = new System.Drawing.Size(316, 26);
         this._altoXmlSoftwareNameTextBox.TabIndex = 7;
         // 
         // _altoXmlSoftwareNameLabel
         // 
         this._altoXmlSoftwareNameLabel.AutoSize = true;
         this._altoXmlSoftwareNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlSoftwareNameLabel.Location = new System.Drawing.Point(24, 139);
         this._altoXmlSoftwareNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlSoftwareNameLabel.Name = "_altoXmlSoftwareNameLabel";
         this._altoXmlSoftwareNameLabel.Size = new System.Drawing.Size(121, 20);
         this._altoXmlSoftwareNameLabel.TabIndex = 6;
         this._altoXmlSoftwareNameLabel.Text = "Software name:";
         // 
         // _altoXmlSoftwareCreatorTextBox
         // 
         this._altoXmlSoftwareCreatorTextBox.Location = new System.Drawing.Point(207, 95);
         this._altoXmlSoftwareCreatorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlSoftwareCreatorTextBox.Name = "_altoXmlSoftwareCreatorTextBox";
         this._altoXmlSoftwareCreatorTextBox.Size = new System.Drawing.Size(316, 26);
         this._altoXmlSoftwareCreatorTextBox.TabIndex = 5;
         // 
         // _altoXmlSoftwareCreatorLabel
         // 
         this._altoXmlSoftwareCreatorLabel.AutoSize = true;
         this._altoXmlSoftwareCreatorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlSoftwareCreatorLabel.Location = new System.Drawing.Point(24, 99);
         this._altoXmlSoftwareCreatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlSoftwareCreatorLabel.Name = "_altoXmlSoftwareCreatorLabel";
         this._altoXmlSoftwareCreatorLabel.Size = new System.Drawing.Size(131, 20);
         this._altoXmlSoftwareCreatorLabel.TabIndex = 4;
         this._altoXmlSoftwareCreatorLabel.Text = "Software creator:";
         // 
         // _altoXmlFileNameTextBox
         // 
         this._altoXmlFileNameTextBox.Location = new System.Drawing.Point(207, 55);
         this._altoXmlFileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlFileNameTextBox.Name = "_altoXmlFileNameTextBox";
         this._altoXmlFileNameTextBox.Size = new System.Drawing.Size(316, 26);
         this._altoXmlFileNameTextBox.TabIndex = 3;
         // 
         // _altoXmlFileNameLabel
         // 
         this._altoXmlFileNameLabel.AutoSize = true;
         this._altoXmlFileNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlFileNameLabel.Location = new System.Drawing.Point(24, 59);
         this._altoXmlFileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlFileNameLabel.Name = "_altoXmlFileNameLabel";
         this._altoXmlFileNameLabel.Size = new System.Drawing.Size(82, 20);
         this._altoXmlFileNameLabel.TabIndex = 2;
         this._altoXmlFileNameLabel.Text = "File name:";
         // 
         // _altoXmlIndentationTextBox
         // 
         this._altoXmlIndentationTextBox.Location = new System.Drawing.Point(207, 247);
         this._altoXmlIndentationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlIndentationTextBox.Name = "_altoXmlIndentationTextBox";
         this._altoXmlIndentationTextBox.Size = new System.Drawing.Size(316, 26);
         this._altoXmlIndentationTextBox.TabIndex = 12;
         // 
         // _altoXmlIndentationLabel
         // 
         this._altoXmlIndentationLabel.AutoSize = true;
         this._altoXmlIndentationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlIndentationLabel.Location = new System.Drawing.Point(56, 251);
         this._altoXmlIndentationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._altoXmlIndentationLabel.Name = "_altoXmlIndentationLabel";
         this._altoXmlIndentationLabel.Size = new System.Drawing.Size(94, 20);
         this._altoXmlIndentationLabel.TabIndex = 11;
         this._altoXmlIndentationLabel.Text = "Indentation:";
         // 
         // _altoXmlFormattedCheckBox
         // 
         this._altoXmlFormattedCheckBox.AutoSize = true;
         this._altoXmlFormattedCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this._altoXmlFormattedCheckBox.Location = new System.Drawing.Point(28, 221);
         this._altoXmlFormattedCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._altoXmlFormattedCheckBox.Name = "_altoXmlFormattedCheckBox";
         this._altoXmlFormattedCheckBox.Size = new System.Drawing.Size(109, 24);
         this._altoXmlFormattedCheckBox.TabIndex = 10;
         this._altoXmlFormattedCheckBox.Text = "Formatted";
         this._altoXmlFormattedCheckBox.UseVisualStyleBackColor = true;
         this._altoXmlFormattedCheckBox.CheckedChanged += new System.EventHandler(this._altoXmlFormattedCheckBox_CheckedChanged);
         // 
         // _emptyOptionsTabPage
         // 
         this._emptyOptionsTabPage.Controls.Add(this._emptyOptionsLabel);
         this._emptyOptionsTabPage.Location = new System.Drawing.Point(4, 29);
         this._emptyOptionsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this._emptyOptionsTabPage.Name = "_emptyOptionsTabPage";
         this._emptyOptionsTabPage.Size = new System.Drawing.Size(556, 474);
         this._emptyOptionsTabPage.TabIndex = 10;
         this._emptyOptionsTabPage.UseVisualStyleBackColor = true;
         // 
         // _emptyOptionsLabel
         // 
         this._emptyOptionsLabel.AutoSize = true;
         this._emptyOptionsLabel.Location = new System.Drawing.Point(21, 26);
         this._emptyOptionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this._emptyOptionsLabel.Name = "_emptyOptionsLabel";
         this._emptyOptionsLabel.Size = new System.Drawing.Size(235, 20);
         this._emptyOptionsLabel.TabIndex = 2;
         this._emptyOptionsLabel.Text = "This format has no extra options";
         // 
         // DocumentFormatOptionsDialog
         // 
         this.AcceptButton = this._okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this._cancelButton;
         this.ClientSize = new System.Drawing.Size(748, 541);
         this.Controls.Add(this._optionsTabControl);
         this.Controls.Add(this._cancelButton);
         this.Controls.Add(this._okButton);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "DocumentFormatOptionsDialog";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "DocumentFormatOptionsDialog";
         this._optionsTabControl.ResumeLayout(false);
         this._ldOptionsTabPage.ResumeLayout(false);
         this._ldOptionsTabPage.PerformLayout();
         this._emfOptionsTabPage.ResumeLayout(false);
         this._emfOptionsTabPage.PerformLayout();
         this._pdfOptionsTabPage.ResumeLayout(false);
         this._pdfOptionsTabPage.PerformLayout();
         this._docOptionsTabPage.ResumeLayout(false);
         this._docOptionsTabPage.PerformLayout();
         this._rtfOptionsTabPage.ResumeLayout(false);
         this._rtfOptionsTabPage.PerformLayout();
         this._htmlOptionsTabPage.ResumeLayout(false);
         this._htmlOptionsTabPage.PerformLayout();
         this._textOptionsTabPage.ResumeLayout(false);
         this._textOptionsTabPage.PerformLayout();
         this._docxOptionsTabPage.ResumeLayout(false);
         this._docxOptionsTabPage.PerformLayout();
         this._altoXmlOptionsTabPage.ResumeLayout(false);
         this._altoXmlOptionsTabPage.PerformLayout();
         this._emptyOptionsTabPage.ResumeLayout(false);
         this._emptyOptionsTabPage.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button _okButton;
      private System.Windows.Forms.Button _cancelButton;
      private System.Windows.Forms.TabControl _optionsTabControl;
      private System.Windows.Forms.TabPage _ldOptionsTabPage;
      private System.Windows.Forms.Label _ldOptionsNoteLabel;
      private System.Windows.Forms.TabPage _emfOptionsTabPage;
      private System.Windows.Forms.Label _emfOptionsNoteLabel;
      private System.Windows.Forms.TabPage _pdfOptionsTabPage;
      private System.Windows.Forms.CheckBox _pdfImageOverTextCheckBox;
      private System.Windows.Forms.ComboBox _pdfDocumentTypeComboBox;
      private System.Windows.Forms.Label _pdfDocumentTypeLabel;
      private System.Windows.Forms.TabPage _docOptionsTabPage;
      private System.Windows.Forms.CheckBox _docFramedCheckBox;
      private System.Windows.Forms.TabPage _rtfOptionsTabPage;
      private System.Windows.Forms.CheckBox _rtfFramedCheckBox;
      private System.Windows.Forms.TabPage _htmlOptionsTabPage;
      private System.Windows.Forms.Button _htmlBackgroundColorButton;
      private System.Windows.Forms.Label _htmlBackgroundColorValueLabel;
      private System.Windows.Forms.Label _htmlBackgroundColorLabel;
      private System.Windows.Forms.CheckBox _htmlUseBackgroundColorCheckBox;
      private System.Windows.Forms.ComboBox _htmlEmbedFontModeComboBox;
      private System.Windows.Forms.Label _htmlEmbedFontModeLabel;
      private System.Windows.Forms.TabPage _textOptionsTabPage;
      private System.Windows.Forms.CheckBox _textFormattedCheckBox;
      private System.Windows.Forms.CheckBox _textAddPageBreakCheckBox;
      private System.Windows.Forms.CheckBox _textAddPageNumberCheckBox;
      private System.Windows.Forms.ComboBox _textDocumentTypeComboBox;
      private System.Windows.Forms.Label _textDocumentTypeLabel;
      private System.Windows.Forms.Button _pdfAdvanctionOptionsButton;
      private System.Windows.Forms.Label _docOptionsDescriptionLabel;
      private System.Windows.Forms.Label _rtfOptionsDescriptionLabel;
      private System.Windows.Forms.TabPage _docxOptionsTabPage;
      private System.Windows.Forms.Label _docxOptionsDescriptionLabel;
      private System.Windows.Forms.CheckBox _docxFramedCheckBox;
      private System.Windows.Forms.TabPage _altoXmlOptionsTabPage;
      private System.Windows.Forms.TextBox _altoXmlApplicationDescriptionTextBox;
      private System.Windows.Forms.Label _altoXmlApplicationDescriptionLabel;
      private System.Windows.Forms.TextBox _altoXmlSoftwareNameTextBox;
      private System.Windows.Forms.Label _altoXmlSoftwareNameLabel;
      private System.Windows.Forms.TextBox _altoXmlSoftwareCreatorTextBox;
      private System.Windows.Forms.Label _altoXmlSoftwareCreatorLabel;
      private System.Windows.Forms.TextBox _altoXmlFileNameTextBox;
      private System.Windows.Forms.Label _altoXmlFileNameLabel;
      private System.Windows.Forms.TextBox _altoXmlIndentationTextBox;
      private System.Windows.Forms.Label _altoXmlIndentationLabel;
      private System.Windows.Forms.CheckBox _altoXmlFormattedCheckBox;
      private System.Windows.Forms.TabPage _emptyOptionsTabPage;
      private System.Windows.Forms.Label _emptyOptionsLabel;
      private System.Windows.Forms.CheckBox _pdfLinearizedCheckBox;
      private System.Windows.Forms.CheckBox _altoXmlShowGlyphVariantsCheckBox;
      private System.Windows.Forms.CheckBox _altoXmlShowGlyphInfoCheckBox;
      private System.Windows.Forms.CheckBox _altoXmlPlainTextCheckBox;
      private System.Windows.Forms.CheckBox _altoXmlSortCheckBox;
      private System.Windows.Forms.ComboBox _altoXmlMeasurementUnitComboBox;
      private System.Windows.Forms.Label _altoXmlMeasurementUnitLabel;
   }
}