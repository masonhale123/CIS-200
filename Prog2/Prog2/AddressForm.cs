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
    public partial class AddressForm : Form
    {
        const int Min_Zip = 00000;
        const int Max_Zip = 99999;
        public AddressForm()
        {
            InitializeComponent();

            StateCombo.Items.Add("KY");
            StateCombo.Items.Add("TN");
            StateCombo.Items.Add("IN");
            StateCombo.Items.Add("FL");

        }

        private void AddressCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddressName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(AddressNameTxtBox.Text))
            {
                e.Cancel = true;
                nameErrorProvider.SetError(AddressNameTxtBox, "You must type a name.");
                AddressNameTxtBox.Focus();
            }
        }
        private void AddressName_Validated(object sender, EventArgs e)
        {
            nameErrorProvider.SetError(AddressNameTxtBox, "");
        }

        private void AddressLine1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(AddressLine1TxtBox.Text))
            {
                e.Cancel = true;
                AddressErrorProvider.SetError(AddressLine1TxtBox, "You must type an address.");
                AddressLine1TxtBox.Focus();
            }
        }

        private void AddressLine1_Validated(object sender, EventArgs e)
        {
            AddressErrorProvider.SetError(AddressLine1TxtBox, "");
        }

        private void AddressCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AddressCityTxtBox.Text))
            {
                e.Cancel = true;
                CityErrorProvider.SetError(AddressCityTxtBox, "You must type a city.");
                AddressCityTxtBox.Focus();
            }
        }

        private void AddressCity_Validated(object sender, EventArgs e)
        {
            CityErrorProvider.SetError(AddressCityTxtBox, "");
        }

        private void StateCombo_Validating(object sender, CancelEventArgs e)
        {
            if (StateCombo.SelectedIndex < 0)
            {
                e.Cancel = true;
                StateErrorProvider.SetError(StateCombo, "You must select a state.");
                StateCombo.Focus();
            }
        }

        private void StateCombo_Validated(object sender, EventArgs e)
        {
            StateErrorProvider.SetError(StateCombo, "");
        }

        private void AddressZip_Validating(object sender, CancelEventArgs e)
        {
            int number; 

            if (!int.TryParse(AddressZipTxtBox.Text, out number))
            {
                e.Cancel = true;
                ZipErrorProvider.SetError(AddressZipTxtBox, "You must enter an interger.");
                AddressZipTxtBox.SelectAll();                
            }
            else if (number <= Min_Zip || number >= Max_Zip)
            {
                e.Cancel = true;
                ZipErrorProvider.SetError(AddressZipTxtBox, "You must enter a zipcode between 00000 and 99999");
                AddressZipTxtBox.SelectAll();
            }
        }

        private void AddressZip_Validated(object sender, EventArgs e)
        {
            ZipErrorProvider.SetError(AddressZipTxtBox, "");
        }

        internal string AddressName
        {

            get { return AddressNameTxtBox.Text; }


            set { AddressNameTxtBox.Text = value; }
        }

        internal string AddressLine1
        {

            get { return AddressLine1TxtBox.Text; }

            set { AddressLine1TxtBox.Text = value; }
        }

        internal string AddressLine2
        {

            get { return AddressLine2TxtBox.Text; }

            set { AddressLine2TxtBox.Text = value; }
        }

        internal string AddressCity
        {

            get { return AddressCityTxtBox.Text; }


            set { AddressCityTxtBox.Text = value; }
        }

        internal string AddressState
        {

            get { return StateCombo.Text; }


            set { StateCombo.Text = value; }
        }

        internal string AddressZip
        {

            get { return AddressZipTxtBox.Text; }


            set { AddressZipTxtBox.Text = value; }
        }

        private void AddressOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}