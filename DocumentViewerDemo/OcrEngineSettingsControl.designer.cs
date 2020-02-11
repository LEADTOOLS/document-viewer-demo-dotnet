namespace Leadtools.Demos
{
   partial class OcrEngineSettingsControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OcrEngineSettingsControl));
         this._pnlSettings = new System.Windows.Forms.Panel();
         this._tvCategories = new System.Windows.Forms.TreeView();
         this._btnLoad = new System.Windows.Forms.Button();
         this._btnSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // _pnlSettings
         // 
         resources.ApplyResources(this._pnlSettings, "_pnlSettings");
         this._pnlSettings.Name = "_pnlSettings";
         // 
         // _tvCategories
         // 
         resources.ApplyResources(this._tvCategories, "_tvCategories");
         this._tvCategories.HideSelection = false;
         this._tvCategories.Name = "_tvCategories";
         this._tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tvCategories_AfterSelect);
         // 
         // _btnLoad
         // 
         resources.ApplyResources(this._btnLoad, "_btnLoad");
         this._btnLoad.Name = "_btnLoad";
         this._btnLoad.UseVisualStyleBackColor = true;
         this._btnLoad.Click += new System.EventHandler(this._btnLoad_Click);
         // 
         // _btnSave
         // 
         resources.ApplyResources(this._btnSave, "_btnSave");
         this._btnSave.Name = "_btnSave";
         this._btnSave.UseVisualStyleBackColor = true;
         this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
         // 
         // OcrEngineSettingsControl
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this._btnSave);
         this.Controls.Add(this._btnLoad);
         this.Controls.Add(this._pnlSettings);
         this.Controls.Add(this._tvCategories);
         this.Name = "OcrEngineSettingsControl";
         this.Resize += new System.EventHandler(this.OcrEngineSettingsControl_Resize);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel _pnlSettings;
      private System.Windows.Forms.TreeView _tvCategories;
      private System.Windows.Forms.Button _btnLoad;
      private System.Windows.Forms.Button _btnSave;
   }
}
