using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocumentViewerDemo.UI
{
   public partial class RotatePagesDialog : Form
   {
      public RotatePagesDialog()
      {
         InitializeComponent();
      }

      public int PageCount;
      public int FirstPageNumber;
      public int LastPageNumber;
      public int SelectedPageNumber;

      public enum DirectionMode
      {
         Direction90Clockwise,
         Direction90CounterClockwise,
         Direction180
      }
      public DirectionMode Direction = DirectionMode.Direction90Clockwise;

      public enum EvenOddMode
      {
         All,
         OnlyEven,
         OnlyOdd
      }

      public EvenOddMode EventOdd = EvenOddMode.All;

      public enum OrientationMode
      {
         All,
         PortraitOnly,
         LandscapeOnly
      }

      public OrientationMode Orientation = OrientationMode.All;

      protected override void OnLoad(EventArgs e)
      {
         if (!DesignMode)
         {
            _directionComboBox.Items.Add("Clockwise 90 degrees");
            _directionComboBox.Items.Add("Counter-clockwise 90 degrees");
            _directionComboBox.Items.Add("180 degrees");

            _evenOddComboBox.Items.Add("Even and odd Pages");
            _evenOddComboBox.Items.Add("Only even Pages");
            _evenOddComboBox.Items.Add("Only odd Pages");

            _orientationComboBox.Items.Add("Pages of any orientation");
            _orientationComboBox.Items.Add("Portrait pages only");
            _orientationComboBox.Items.Add("Landscape pages only");

            _ofLabel.Text = "of " + this.PageCount.ToString();

            _fromTextBox.Text = this.FirstPageNumber.ToString();
            _toTextBox.Text = this.LastPageNumber.ToString();

            _fromTextBox.LostFocus += _fromTextBox_LostFocus;
            _toTextBox.LostFocus += _toTextBox_LostFocus;

            _allRadioButton.Checked = true;
            _directionComboBox.SelectedIndex = (int)Direction;
            _evenOddComboBox.SelectedIndex = (int)EventOdd;
            _orientationComboBox.SelectedIndex = (int)Orientation;

            UpdateUIState();
         }

         base.OnLoad(e);
      }

      private void _fromTextBox_LostFocus(object sender, EventArgs e)
      {
         var value = _fromTextBox.Text;
         int tempValue;
         if (string.IsNullOrEmpty(value) ||
            !int.TryParse(value, out tempValue) ||
            tempValue < 1 || tempValue > LastPageNumber)
         {
            _fromTextBox.Text = FirstPageNumber.ToString();
            return;
         }

         FirstPageNumber = tempValue;
      }

      private void _toTextBox_LostFocus(object sender, EventArgs e)
      {
         var value = _toTextBox.Text;
         int tempValue;
         if (string.IsNullOrEmpty(value) ||
            !int.TryParse(value, out tempValue) ||
            tempValue < 1 || tempValue > PageCount || tempValue < FirstPageNumber)
         {
            _toTextBox.Text = LastPageNumber.ToString();
            return;
         }

         LastPageNumber = tempValue;
      }

      private void UpdateUIState()
      {
         _fromTextBox.Enabled = _pagesRadioButton.Checked;
         _toTextBox.Enabled = _pagesRadioButton.Checked;
      }

      private void _allRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         if (_allRadioButton.Checked)
         {
            FirstPageNumber = 1;
            LastPageNumber = PageCount;
            _fromTextBox.Text = FirstPageNumber.ToString();
            _toTextBox.Text = LastPageNumber.ToString();
         }

         UpdateUIState();
      }

      private void _selectedRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         if (_selectedRadioButton.Checked)
         {
            FirstPageNumber = SelectedPageNumber;
            LastPageNumber = SelectedPageNumber;
            _fromTextBox.Text = FirstPageNumber.ToString();
            _toTextBox.Text = LastPageNumber.ToString();
         }
         UpdateUIState();
      }

      private void _pagesRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         UpdateUIState();
      }

      private void _okButton_Click(object sender, EventArgs e)
      {
         if (_allRadioButton.Checked)
         {
            FirstPageNumber = 1;
            LastPageNumber = PageCount;
         }
         else if (_selectedRadioButton.Checked)
         {
            FirstPageNumber = SelectedPageNumber;
            LastPageNumber = SelectedPageNumber;
         }

         Direction = (DirectionMode)_directionComboBox.SelectedIndex;
         EventOdd = (EvenOddMode)_evenOddComboBox.SelectedIndex;
         Orientation = (OrientationMode)_orientationComboBox.SelectedIndex;
      }
   }
}
