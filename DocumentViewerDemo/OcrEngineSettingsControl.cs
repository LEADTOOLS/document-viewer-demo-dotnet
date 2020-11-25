// *************************************************************
// Copyright (c) 1991-2020 LEAD Technologies, Inc.              
// All Rights Reserved.                                         
// *************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Ocr;

namespace Leadtools.Demos
{
   public partial class OcrEngineSettingsControl : UserControl
   {
      public OcrEngineSettingsControl()
      {
         InitializeComponent();
      }

      private IOcrEngine _ocrEngine;

      public void SetEngine(IOcrEngine engine)
      {
         _ocrEngine = engine;

         _tvCategories.BeginUpdate();

         // Clear the old settings
         _tvCategories.Nodes.Clear();

         // Get all the settings
         string[] settingNames = _ocrEngine.SettingManager.GetSettingNames();

         TreeNode currentCatrgoryNode = null;

         foreach(string settingName in settingNames)
         {
            IOcrSettingDescriptor settingDescriptor = _ocrEngine.SettingManager.GetSettingDescriptor(settingName);

            if(settingDescriptor.ValueType == OcrSettingValueType.BeginCategory)
            {
               TreeNode catrgoryNode = new TreeNode(settingDescriptor.FriendlyName);

               if(currentCatrgoryNode != null)
                  currentCatrgoryNode.Nodes.Add(catrgoryNode);
               else
                  _tvCategories.Nodes.Add(catrgoryNode);

               catrgoryNode.Tag = null;

               currentCatrgoryNode = catrgoryNode;
            }
            else if(settingDescriptor.ValueType == OcrSettingValueType.EndCategory)
            {
               currentCatrgoryNode = currentCatrgoryNode.Parent;
            }
            else
            {
               TreeNode settingNode = new TreeNode(settingDescriptor.FriendlyName);
               settingNode.Tag = settingName;
               currentCatrgoryNode.Nodes.Add(settingNode);
            }
         }

         _tvCategories.ExpandAll();

         _tvCategories.EndUpdate();
      }

      private void _tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
      {
         ShowCurrentSetting();
      }

      private void ShowCurrentSetting()
      {
         _pnlSettings.Controls.Clear();

         if (_tvCategories.SelectedNode != null)
         {
            if (_tvCategories.SelectedNode.Tag != null)
            {
               // Get the setting
               string settingName = _tvCategories.SelectedNode.Tag.ToString();
               IOcrSettingDescriptor settingDescriptor = _ocrEngine.SettingManager.GetSettingDescriptor(settingName);

               // Add a control for it
               switch (settingDescriptor.ValueType)
               {
                  case OcrSettingValueType.Integer:
                     AddIntegerSetting(settingDescriptor);
                     break;

                  case OcrSettingValueType.Enum:
                     if (settingDescriptor.EnumIsFlags)
                        AddEnumFlagsSetting(settingDescriptor);
                     else
                        AddEnumSetting(settingDescriptor);
                     break;

                  case OcrSettingValueType.Double:
                     AddDoubleSetting(settingDescriptor);
                     break;

                  case OcrSettingValueType.Boolean:
                     AddBooleanSetting(settingDescriptor);
                     break;

                  case OcrSettingValueType.Character:
                     AddCharacterSetting(settingDescriptor);
                     break;

                  case OcrSettingValueType.String:
                     AddStringSetting(settingDescriptor);
                     break;

                  default:
                     break;
               }
            }
         }
      }

      private const int _edge = 6;

      private void AddIntegerSetting(IOcrSettingDescriptor settingDescriptor)
      {
         Label lbl = new Label();
         lbl.AutoSize = true;
         lbl.TextAlign = ContentAlignment.MiddleLeft;
         lbl.Text = settingDescriptor.Units;
         lbl.Location = new Point(_edge, _edge);
         _pnlSettings.Controls.Add(lbl);

         TextBox tb = new TextBox();
         tb.Width = _pnlSettings.ClientSize.Width - lbl.Width - _edge * 3;
         tb.Location = new Point(lbl.Right + _edge, _edge);
         tb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         _pnlSettings.Controls.Add(tb);

         lbl.Top = tb.Top + (tb.Height - lbl.Height) / 2;

         tb.Text = _ocrEngine.SettingManager.GetIntegerValue(settingDescriptor.Name).ToString();
         tb.Tag = settingDescriptor.Name;
         tb.LostFocus += new EventHandler(IntegerTextBox_LostFocus);
      }

      private void IntegerTextBox_LostFocus(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         TextBox tb = sender as TextBox;
         string settingName = tb.Tag.ToString();

         bool valueOk = true;

         int value;
         if(!int.TryParse(tb.Text, out value))
            valueOk = false;

         if(valueOk)
         {
            IOcrSettingDescriptor settingDescriptor = _ocrEngine.SettingManager.GetSettingDescriptor(settingName);
            if(value < settingDescriptor.IntegerMinimumValue) 
            {
               valueOk = false;
               MessageBox.Show(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_ErrorValueGreater") + settingDescriptor.IntegerMinimumValue), DemosGlobalization.GetResxString(GetType(), "Resx_Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(value > settingDescriptor.IntegerMaximumValue)
            {
               valueOk = false;
               MessageBox.Show(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_ErrorValueLess") + settingDescriptor.IntegerMaximumValue), DemosGlobalization.GetResxString(GetType(), "Resx_Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }

         if(valueOk) 
            SetSettingValue(settingName, value.ToString());
         else
         {
            tb.Text = _ocrEngine.SettingManager.GetIntegerValue(settingName).ToString();
            tb.Focus();
         }
      }

      private void AddDoubleSetting(IOcrSettingDescriptor settingDescriptor)
      {
         Label lbl = new Label();
         lbl.AutoSize = true;
         lbl.TextAlign = ContentAlignment.MiddleLeft;
         lbl.Text = settingDescriptor.Units;
         lbl.Location = new Point(_edge, _edge);
         _pnlSettings.Controls.Add(lbl);

         TextBox tb = new TextBox();
         tb.Width = _pnlSettings.ClientSize.Width - lbl.Width - _edge * 3;
         tb.Location = new Point(lbl.Right + _edge, _edge);
         tb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         _pnlSettings.Controls.Add(tb);

         lbl.Top = tb.Top + (tb.Height - lbl.Height) / 2;

         tb.Text = _ocrEngine.SettingManager.GetDoubleValue(settingDescriptor.Name).ToString();
         tb.Tag = settingDescriptor.Name;
         tb.LostFocus += new EventHandler(DoubleTextBox_LostFocus);
      }

      private void DoubleTextBox_LostFocus(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         TextBox tb = sender as TextBox;
         string settingName = tb.Tag.ToString();

         bool valueOk = true;

         double value;
         if(!double.TryParse(tb.Text, out value))
            valueOk = false;

         if(valueOk)
         {
            IOcrSettingDescriptor settingDescriptor = _ocrEngine.SettingManager.GetSettingDescriptor(settingName);
            if(value < settingDescriptor.DoubleMinimumValue)
            {
               valueOk = false;
               MessageBox.Show(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_ErrorValueGreater") + settingDescriptor.IntegerMinimumValue), DemosGlobalization.GetResxString(GetType(), "Resx_Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(value > settingDescriptor.DoubleMaximumValue)
            {
               valueOk = false;
               MessageBox.Show(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_ErrorValueLess") + settingDescriptor.IntegerMaximumValue), DemosGlobalization.GetResxString(GetType(), "Resx_Error"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }

         if(valueOk)
            SetSettingValue(settingName, value.ToString());
         else
         {
            tb.Text = _ocrEngine.SettingManager.GetDoubleValue(settingName).ToString();
            tb.Focus();
         }
      }

      private void AddBooleanSetting(IOcrSettingDescriptor settingDescriptor)
      {
         ComboBox cb = new ComboBox();
         cb.DropDownStyle = ComboBoxStyle.DropDownList;
         cb.Width = _pnlSettings.ClientSize.Width - _edge * 2;
         cb.Location = new Point(_edge, _edge);
         cb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         _pnlSettings.Controls.Add(cb);

         cb.Items.Add(true);
         cb.Items.Add(false);

         cb.SelectedItem = _ocrEngine.SettingManager.GetBooleanValue(settingDescriptor.Name);
         cb.Tag = settingDescriptor.Name;
         cb.SelectedIndexChanged += new EventHandler(BooleanCheckBox_SelectedIndexChanged);
      }

      private void BooleanCheckBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         ComboBox cb = sender as ComboBox;
         string settingName = cb.Tag.ToString();
         SetSettingValue(settingName, cb.SelectedItem.ToString());
      }

      private void AddEnumFlagsSetting(IOcrSettingDescriptor settingDescriptor)
      {
         CheckedListBox clb = new CheckedListBox();
         clb.CheckOnClick = true;
         clb.Location = new Point(_edge, _edge);
         clb.Size = new Size(_pnlSettings.ClientSize.Width - _edge * 2, _pnlSettings.ClientSize.Height - _edge * 2);
         clb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
         _pnlSettings.Controls.Add(clb);

         string[] memberNames = settingDescriptor.GetEnumMemberFriendlyNames();
         int[] memberValues = settingDescriptor.GetEnumMemberValues();

         int value = _ocrEngine.SettingManager.GetEnumValue(settingDescriptor.Name);

         for(int i = 0; i < memberNames.Length; i++)
         {
            int memberValue = memberValues[i];
            if(memberValue != 0)
            {
               int index = clb.Items.Add(memberNames[i]);

               if((memberValue & value) == memberValue)
                  clb.SetItemChecked(index, true);
            }
         }

         clb.Tag = settingDescriptor.Name;
         clb.ItemCheck += new ItemCheckEventHandler(EnumFlagsCheckedListBox_ItemCheck);
      }

      private void EnumFlagsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         CheckedListBox clb = sender as CheckedListBox;

         string settingName = clb.Tag.ToString();

         StringBuilder sb = new StringBuilder();

         for(int i = 0; i < clb.Items.Count; i++)
         {
            if(i != e.Index)
            {
               if(clb.GetItemChecked(i))
                  sb.Append(clb.Items[i] + ", ");
            }
            else if(e.NewValue == CheckState.Checked)
               sb.Append(clb.Items[i] + ", ");
         }

         if(sb.Length > 0)
            sb.Remove(sb.Length - 2, 2);

         SetSettingValue(settingName, sb.ToString());
      }

      private void AddEnumSetting(IOcrSettingDescriptor settingDescriptor)
      {
         ComboBox cb = new ComboBox();
         cb.DropDownStyle = ComboBoxStyle.DropDownList;
         cb.Width = _pnlSettings.ClientSize.Width - _edge * 2;
         cb.Location = new Point(_edge, _edge);
         cb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         _pnlSettings.Controls.Add(cb);

         cb.SelectedItem = _ocrEngine.SettingManager.GetValue(settingDescriptor.Name);

         string[] members = settingDescriptor.GetEnumMemberFriendlyNames();

         foreach(string member in members)
            cb.Items.Add(member);

         int value = _ocrEngine.SettingManager.GetEnumValue(settingDescriptor.Name);
         cb.SelectedIndex = value;
         cb.Tag = settingDescriptor.Name;
         cb.SelectedIndexChanged += new EventHandler(EnumComboBox_SelectedIndexChanged);
      }

      private void EnumComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         ComboBox cb = sender as ComboBox;
         string settingName = cb.Tag.ToString();
         SetSettingValue(settingName, cb.SelectedItem.ToString());
      }

      private void AddCharacterSetting(IOcrSettingDescriptor settingDescriptor)
      {
         TextBox tb = new TextBox();
         tb.Width = _pnlSettings.ClientSize.Width - _edge * 2;
         tb.Location = new Point(_edge, _edge);
         tb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         tb.MaxLength = 1;
         tb.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         _pnlSettings.Controls.Add(tb);

         tb.Text = _ocrEngine.SettingManager.GetCharacterValue(settingDescriptor.Name).ToString();
         tb.Tag = settingDescriptor.Name;
         tb.LostFocus += new EventHandler(CharacterTextBox_LostFocus);
      }

      private void CharacterTextBox_LostFocus(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         TextBox tb = sender as TextBox;
         string settingName = tb.Tag.ToString();

         bool valueOk = true;

         char value;
         if(!char.TryParse(tb.Text, out value))
            valueOk = false;

         if(valueOk)
            SetSettingValue(settingName, value.ToString());
         else
         {
            tb.Text = _ocrEngine.SettingManager.GetCharacterValue(settingName).ToString();
            tb.Focus();
         }
      }

      private void AddStringSetting(IOcrSettingDescriptor settingDescriptor)
      {
         TextBox tb = new TextBox();
         tb.Width = _pnlSettings.ClientSize.Width - _edge * 2;
         tb.Location = new Point(_edge, _edge);
         tb.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
         tb.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         if(settingDescriptor.StringMaximumLength != -1)
            tb.MaxLength = settingDescriptor.StringMaximumLength;
         _pnlSettings.Controls.Add(tb);

         tb.Text = _ocrEngine.SettingManager.GetStringValue(settingDescriptor.Name);
         tb.Tag = settingDescriptor.Name;
         tb.LostFocus += new EventHandler(StringTextBox_LostFocus);
      }

      private void StringTextBox_LostFocus(object sender, EventArgs e)
      {
         if(_ocrEngine == null || !_ocrEngine.IsStarted)
            return;

         TextBox tb = sender as TextBox;
         string settingName = tb.Tag.ToString();

         bool valueOk = true;

         string value = tb.Text;

         if(valueOk)
         {
            IOcrSettingDescriptor settingDescriptor = _ocrEngine.SettingManager.GetSettingDescriptor(settingName);
            if(settingDescriptor.StringNullAllowed && value.Length == 0)
               value = null;
         }

         if(valueOk)
            SetSettingValue(settingName, value);
         else
         {
            tb.Text = _ocrEngine.SettingManager.GetStringValue(settingName);
            tb.Focus();
         }
      }

      private void SetSettingValue(string settingName, string value)
      {
         try
         {
            _ocrEngine.SettingManager.SetValue(settingName, value);
         }
         catch(Exception ex)
         {
            ShowError(ex);
         }
      }

      private void ShowError(Exception ex)
      {
         // Shows an error, check if the exception is an OCR, raster or general one
         OcrException ocr = ex as OcrException;
         if(ocr != null)
         {
             Messager.ShowError(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_OCRError"), ocr.Code, ocr.Message));
            return;
         }

#if LEADTOOLS_V175_OR_LATER
         OcrComponentMissingException ocrComponent = ex as OcrComponentMissingException;
         if(ocrComponent != null)
         {
            Messager.ShowError(this, string.Format("OCR Component Missing\n\n{0}\n\nUse 'Engine/Componets' from the menu to show the available components and instructions of how to install the additional components of this OCR engine.", ocrComponent.Message));
            return;
         }
#endif // #if LEADTOOLS_V175_OR_LATER

         RasterException raster = ex as RasterException;
         if(raster != null)
         {
             Messager.ShowError(this, string.Format(DemosGlobalization.GetResxString(GetType(), "Resx_LEADError"), raster.Code, raster.Message));
            return;
         }

         Messager.ShowError(this, ex);
      }

      private void OcrEngineSettingsControl_Resize(object sender, EventArgs e)
      {
         _tvCategories.Size = new Size(_pnlSettings.Location.X - _tvCategories.Location.X - _edge, ClientRectangle.Bottom);
         _pnlSettings.Size = new Size(ClientRectangle.Right - _pnlSettings.Location.X - _edge, ClientRectangle.Bottom);
      }

      private void _btnLoad_Click(object sender, EventArgs e)
      {
         using (OpenFileDialog dlg = new OpenFileDialog())
         {
            dlg.Filter = "OCR engine settings (*.xml)|*.xml|All files|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               try
               {
                  _ocrEngine.SettingManager.Load(dlg.FileName);
               }
               catch (Exception ex)
               {
                  ShowError(ex);
               }
               finally
               {
                  ShowCurrentSetting();
               }
            }
         }
      }

      private void _btnSave_Click(object sender, EventArgs e)
      {
         using (SaveFileDialog dlg = new SaveFileDialog())
         {
            dlg.Filter = "OCR engine settings (*.xml)|*.xml|All files|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
               try
               {
                  _ocrEngine.SettingManager.Save(dlg.FileName);
               }
               catch (Exception ex)
               {
                  ShowError(ex);
               }
            }
         }
      }
   }
}
