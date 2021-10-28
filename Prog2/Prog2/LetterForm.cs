using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class LetterForm : Form
    {
        public LetterForm(List<Address> AddressList)
        {
            InitializeComponent();
            foreach (Address item in AddressList)
            {
                OriginAddyCombo.Items.Add(item.Name);
                DestAddyCombo.Items.Add(item.Name);
            }
        }

        private void cancelLetterButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OriginAddyCombo_Validating(object sender, CancelEventArgs e)
        {
            if (OriginAddyCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                OriginAddyCombo.Focus();
                OriginAddyErrorProvider.SetError(OriginAddyCombo, "An origin address must be selected.");
            }
            else if (OriginAddyCombo.SelectedIndex == DestAddyCombo.SelectedIndex)
            {
                e.Cancel = true;
                OriginAddyCombo.Focus();
                OriginAddyErrorProvider.SetError(OriginAddyCombo, "You cannot have the same origin and destination address.");
            }
        }

        private void OriginAddyCombo_Validated(object sender, EventArgs e)
        {
            OriginAddyErrorProvider.SetError(OriginAddyCombo, "");
        }

        private void DestAddyCombo_Validating(object sender, CancelEventArgs e)
        {
            if (DestAddyCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                DestAddyCombo.Focus();
                DestAddyErrorProvider.SetError(DestAddyCombo, "A destination address must be selected.");
            }
            else if (DestAddyCombo.SelectedIndex == OriginAddyCombo.SelectedIndex)
            {
                e.Cancel = true;
                DestAddyCombo.Focus();
                DestAddyErrorProvider.SetError(DestAddyCombo, "You cannot have the same origin and destination address.");
            }
        }


        private void DestAddyCombo_Validated(object sender, EventArgs e)
        {
            DestAddyErrorProvider.SetError(DestAddyCombo, "");
        }


        private void FixCost_Validating(object sender, CancelEventArgs e)
        {
            decimal number; 

            if (!decimal.TryParse(FixCostTxtBox.Text, out number))
            {
                e.Cancel = true;
                FixCostTxtBox.SelectAll();
                FixCostErrorProvider.SetError(FixCostTxtBox, "You must enter a valid cost.");
            }
            else if (number <= 0)
            {
                e.Cancel = true;
                FixCostTxtBox.SelectAll();
                FixCostErrorProvider.SetError(FixCostTxtBox, "The Fixed cost must be zero or greater.");
            }
        }

        private void FixCost_Validated(object sender, EventArgs e)
        {
            FixCostErrorProvider.SetError(FixCostTxtBox, "");
        }


        public int OriginIndex
        {

            get { return OriginAddyCombo.SelectedIndex; }


            set { OriginAddyCombo.SelectedIndex = value; }

        }


        public int DestIndex
        {

            get { return DestAddyCombo.SelectedIndex; }

            set { DestAddyCombo.SelectedIndex = value; }
        }

        public string LetterFixedCost
        {

            get { return FixCostTxtBox.Text; }


            set { FixCostTxtBox.Text = value; }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
